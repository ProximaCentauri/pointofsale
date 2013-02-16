﻿/*
 * Created by SharpDevelop.
 * User: user
 * Date: 2/10/2013
 * Time: 6:11 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using NJournals.Common.Util;
using NJournals.Common.Interfaces;
using NJournals.Common.Gui;
using NJournals.Common.DataEntities;
using System.Collections.Generic;
using NJournals.Core.Presenter;
using NJournals.Core.Models;
using System.Data;

namespace NJournals.Core.Views
{
	/// <summary>
	/// Description of RefillingConfigurationView.
	/// </summary>
	public partial class RefillingConfigurationView : BaseForm, IRefillingConfigurationView
	{
		RefillingConfigurationViewPresenter m_presenter;
		List<RefillProductTypeDataEntity> m_productTypeEntity;
		List<RefillInventoryHeaderDataEntity> m_refillInvEntity;
		
		List<int> productTypeIndexChange = new List<int>();
		List<int> refillInvIndexChange = new List<int>();
		
		int productTypeMaxRowIndex = -1;
		int refillInvMaxRowIndex = -1;
		
		public RefillingConfigurationView()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void RefillingConfigurationFormLoad(object sender, EventArgs e)
		{
			setButtonImages();
			formatAlternatingRows();
			
			m_presenter = new RefillingConfigurationViewPresenter(this);
			m_presenter.SetAllRefillProductType();
			m_presenter.SetAllRefillInventory();
		}
		
		public void SetAllRefillProductType(List<RefillProductTypeDataEntity> productTypes)
		{
			m_productTypeEntity = productTypes;
			BindingSource source = new BindingSource();
			source.DataSource = m_productTypeEntity;
			this.dgvProductType.DataSource = source;
			productTypeMaxRowIndex = this.dgvProductType.RowCount - 1;
			formatProductTypeDataGridView();
		}
		
		public void SetAllRefillInventory(List<RefillInventoryHeaderDataEntity> refillInvs)
		{
			m_refillInvEntity = refillInvs;
			BindingSource source = new BindingSource();
			
			DataTable tempTable = new DataTable();
			tempTable.Columns.Add("InvHeaderID", typeof(int));
			tempTable.Columns.Add("Name", typeof(string));
			tempTable.Columns.Add("TotalQty", typeof(int));
			tempTable.Columns.Add("QtyOnHand", typeof(int));
			tempTable.Columns.Add("QtyReleased", typeof(int));
			tempTable.Columns.Add("AddStocks", typeof(int));
			tempTable.Columns.Add("RemoveStocks", typeof(int));
			
			foreach(RefillInventoryHeaderDataEntity inv in refillInvs)
			{
				tempTable.Rows.Add(inv.InvHeaderID, inv.Name, inv.TotalQty, inv.QtyOnHand, 
				                   inv.QtyReleased, 0, 0);
			}
			
			source.DataSource = tempTable;
			this.dgvRefillInventory.DataSource = source;
			refillInvMaxRowIndex = this.dgvRefillInventory.RowCount - 1;
			formatRefillIventoryDataGridView();
		}
		
		#region ProductType
		
		private void dgvProductType_CellValueChanged(object sender,
		    DataGridViewCellEventArgs e)
		{		   	
			if(e.RowIndex != -1)
			{
				if(!productTypeIndexChange.Contains(e.RowIndex))
					productTypeIndexChange.Add(e.RowIndex);
			}
		}
		
		void BtnSaveProductClick(object sender, EventArgs e)
		{
			List<RefillProductTypeDataEntity> productTypes = new List<RefillProductTypeDataEntity>();
			productTypes = GetProductTypeDataValueChange(productTypeIndexChange);					
			if(productTypes.Count != 0)
			{
			 	m_presenter.SaveOrUpdateProductType(productTypes);
				m_presenter.SetAllRefillProductType();
				productTypeMaxRowIndex = this.dgvProductType.RowCount - 1;
				dgvProductType.Refresh();	
			}
		}
		
		void BtnDeleteProductClick(object sender, EventArgs e)
		{
			RefillProductTypeDataEntity productType = new RefillProductTypeDataEntity();
			
			if(this.dgvProductType.SelectedRows.Count > 0)
			{
				foreach(DataGridViewRow currentRow in this.dgvProductType.SelectedRows)
				{
					if(currentRow.Index < productTypeMaxRowIndex)
					{
						int productTypeID = (int)this.dgvProductType.Rows[currentRow.Index].Cells["ProductTypeID"].Value;
						productType = m_productTypeEntity.Find(m_productType => m_productType.ProductTypeID == productTypeID);						
						m_presenter.DeleteProductType(productType);
					}
					
					if(!this.dgvProductType.Rows[currentRow.Index].IsNewRow)
						dgvProductType.Rows.Remove(this.dgvProductType.Rows[currentRow.Index]);											
				}
				m_presenter.SetAllRefillProductType();
			}
			productTypeMaxRowIndex = this.dgvProductType.RowCount - 1;
		}
		
		private List<RefillProductTypeDataEntity> GetProductTypeDataValueChange(List<int> rowIndexChange)
		{
			List<RefillProductTypeDataEntity> productTypes = new List<RefillProductTypeDataEntity>();			
			
			foreach(int rowIndex in rowIndexChange)
			{
				RefillProductTypeDataEntity productType = new RefillProductTypeDataEntity();
				
				if(rowIndex < productTypeMaxRowIndex)
				{
					int productTypeID = (int)this.dgvProductType.Rows[rowIndex].Cells["ProductTypeID"].Value;
					productType = m_productTypeEntity.Find(m_productType => m_productType.ProductTypeID == productTypeID);
				}

				productType.Name = this.dgvProductType.Rows[rowIndex].Cells["Name"].Value.ToString();
				productType.Description = this.dgvProductType.Rows[rowIndex].Cells["Description"].Value.ToString();
				productType.Price = Convert.ToDecimal(this.dgvProductType.Rows[rowIndex].Cells["Price"].Value.ToString());
				productTypes.Add(productType);
			}			
			return productTypes;
		}
		
		#endregion ProductType
		
		#region RefillInventory
		
		void BtnAddInvClick(object sender, EventArgs e)
		{
			this.dgvRefillInventory.AllowUserToAddRows = true;
			
			this.dgvRefillInventory["Name", dgvRefillInventory.RowCount - 1].ReadOnly = false;
			this.dgvRefillInventory["AddStocks", dgvRefillInventory.RowCount - 1].ReadOnly = false;
			this.dgvRefillInventory["RemoveStocks", dgvRefillInventory.RowCount - 1].ReadOnly = true;
			this.dgvRefillInventory["TotalQty", dgvRefillInventory.RowCount - 1].Value = 0;
			this.dgvRefillInventory["QtyOnHand", dgvRefillInventory.RowCount - 1].Value = 0;
			this.dgvRefillInventory["QtyReleased", dgvRefillInventory.RowCount - 1].Value = 0;
			this.dgvRefillInventory["RemoveStocks", dgvRefillInventory.RowCount - 1].Value = 0;
		}
		
		void BtnSaveInvClick(object sender, EventArgs e)
		{
			List<RefillInventoryHeaderDataEntity> refillInvs = new List<RefillInventoryHeaderDataEntity>();
			
			//get modified row
			if(refillInvIndexChange != null)
			{
				refillInvs = GetRefillInvDataValueChange(refillInvIndexChange);
			}
			
			//get new data
			if(this.dgvRefillInventory.RowCount - 1 > refillInvMaxRowIndex)
			{
				int rowDataToAdd = (this.dgvRefillInventory.RowCount - 1) - refillInvMaxRowIndex;
							
				for(int ctr = 1; ctr < rowDataToAdd; ctr++)
				{
					DataGridViewRow currentRow = this.dgvRefillInventory.Rows[refillInvMaxRowIndex + ctr];
					int addStocks = (int)currentRow.Cells["AddStocks"].Value;
					
					RefillInventoryDetailDataEntity detail = new RefillInventoryDetailDataEntity();					
					detail.Date = DateTime.Now.Date;
					detail.QtyAdded += addStocks;
					detail.QtyOnHand += addStocks;
					detail.TotalQty += addStocks;
					
					RefillInventoryHeaderDataEntity refillInv = new RefillInventoryHeaderDataEntity();
					refillInv.Name = currentRow.Cells["Name"].Value.ToString();
					refillInv.QtyOnHand += addStocks;
					refillInv.TotalAdded += addStocks;
					refillInv.TotalQty += addStocks;
					refillInv.DetailEntities.Add(detail);
					
					refillInvs.Add(refillInv);					
				}
			}
			
			if(refillInvs.Count > 0)
			{
				m_presenter.SaveOrUpdateRefillInventory(refillInvs);
				m_presenter.SetAllRefillInventory();
			}
		}
		
		void BtnDeleteInvClick(object sender, EventArgs e)
		{
			RefillInventoryHeaderDataEntity refillInv = new RefillInventoryHeaderDataEntity();
			
			if(this.dgvRefillInventory.SelectedRows.Count > 0)
			{
				foreach(DataGridViewRow currentRow in this.dgvRefillInventory.SelectedRows)
				{
					if(currentRow.Index <= refillInvMaxRowIndex)
					{
						int ID = (int)this.dgvRefillInventory.Rows[currentRow.Index].Cells["InvHeaderID"].Value;
						refillInv = m_refillInvEntity.Find(m_refillInv => m_refillInv.InvHeaderID == ID);
						m_presenter.DeleteRefillInventory(refillInv);
					}					
					if(!this.dgvRefillInventory.Rows[currentRow.Index].IsNewRow)
						dgvRefillInventory.Rows.Remove(this.dgvRefillInventory.Rows[currentRow.Index]);						
				}
				m_presenter.SetAllRefillInventory();
				this.dgvRefillInventory.AllowUserToAddRows = false;
			}
			refillInvMaxRowIndex = this.dgvRefillInventory.RowCount - 1;
		}
		
		private void dgvRefillInventory_CellValueChanged(object sender,
		    DataGridViewCellEventArgs e)
		{		   	
			if(e.RowIndex != -1)
			{
				if(!refillInvIndexChange.Contains(e.RowIndex))
					refillInvIndexChange.Add(e.RowIndex);
			}
		}
		
		private List<RefillInventoryHeaderDataEntity> GetRefillInvDataValueChange(List<int> rowIndexChange)
		{
			List<RefillInventoryHeaderDataEntity> refillInvs = new List<RefillInventoryHeaderDataEntity>();
			
			foreach(int rowIndex in rowIndexChange)
			{
				RefillInventoryHeaderDataEntity refillInv = new RefillInventoryHeaderDataEntity();
				List<RefillInventoryDetailDataEntity> detailInvs = new List<RefillInventoryDetailDataEntity>();
				int addStocks = 0;
				int removeStocks = 0;
				
				if(rowIndex <= refillInvMaxRowIndex)
				{
					addStocks = (int)this.dgvRefillInventory.Rows[rowIndex].Cells["AddStocks"].Value;
					removeStocks = (int)this.dgvRefillInventory.Rows[rowIndex].Cells["RemoveStocks"].Value;
					int ID = (int)this.dgvRefillInventory.Rows[rowIndex].Cells["InvHeaderID"].Value;
					
					refillInv = m_refillInvEntity.Find(m_refillInv => m_refillInv.InvHeaderID == ID);
					
					RefillInventoryDetailDataEntity invDetail = new RefillInventoryDetailDataEntity();
					
					foreach(RefillInventoryDetailDataEntity detail in refillInv.DetailEntities)
					{
						detailInvs.Add(detail);
					}
					
					invDetail = detailInvs.Find(detailInv => detailInv.Date == DateTime.Now.Date);
										
					if(invDetail != null)
					{	
						invDetail.QtyAdded += addStocks;
						invDetail.QtyRemoved += removeStocks;
						invDetail.TotalQty = invDetail.TotalQty + addStocks - removeStocks;
						invDetail.QtyOnHand += addStocks;
					}
					else
					{
						invDetail.Date = DateTime.Now.Date;
						invDetail.QtyAdded = addStocks;
						invDetail.QtyOnHand = addStocks;
						invDetail.QtyRemoved = removeStocks;
						invDetail.TotalQty = addStocks - removeStocks;
					}				
					
					refillInv.QtyOnHand += addStocks;
					refillInv.TotalAdded += addStocks;
					refillInv.TotalRemoved += removeStocks;
					refillInv.TotalQty = refillInv.TotalQty + addStocks - removeStocks;
					refillInv.DetailEntities.Add(invDetail);
					
					refillInvs.Add(refillInv);
				}
			}
			
			return refillInvs;
		}
		#endregion
		
		
		#region Format Methods
		void setButtonImages()
		{
			Resource.setImage(this.btnSaveProduct,System.IO.Directory.GetCurrentDirectory() + "/images/save2.png");
			Resource.setImage(this.btnDeleteProduct,System.IO.Directory.GetCurrentDirectory() + "/images/delete2.png");
			
			Resource.setImage(this.btnAddInv,System.IO.Directory.GetCurrentDirectory() + "/images/add2.png");
			Resource.setImage(this.btnSaveInv,System.IO.Directory.GetCurrentDirectory() + "/images/save2.png");
			Resource.setImage(this.btnDeleteInv,System.IO.Directory.GetCurrentDirectory() + "/images/delete2.png");	
			
		}
		
		void formatAlternatingRows()
		{
			this.dgvProductType.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(177)))));
            this.dgvProductType.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(225)))));        
			this.dgvRefillInventory.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(177)))));
            this.dgvRefillInventory.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(225)))));        
		}
		
		void formatProductTypeDataGridView()
		{
			this.dgvProductType.Columns["ProductTypeID"].Visible = false;
            this.dgvProductType.Columns["Name"].Width = 200;
            this.dgvProductType.Columns["Description"].Width = 429;
            this.dgvProductType.Columns["Price"].Width = 100;
            this.dgvProductType.Columns["Name"].HeaderText = "Product Name";
            this.dgvProductType.Columns["Description"].HeaderText = "Product Description";
            this.dgvProductType.Columns["Price"].HeaderText = "Price";
		}
		
		void formatRefillIventoryDataGridView()
		{
			this.dgvRefillInventory.Columns["InvHeaderID"].Visible = false;
			this.dgvRefillInventory.Columns["Name"].Width = 155;
			this.dgvRefillInventory.Columns["TotalQty"].Width = 120;
			this.dgvRefillInventory.Columns["QtyOnHand"].Width = 120;
			this.dgvRefillInventory.Columns["QtyReleased"].Width = 120;
			this.dgvRefillInventory.Columns["AddStocks"].Width = 115;
			this.dgvRefillInventory.Columns["RemoveStocks"].Width = 115;
			this.dgvRefillInventory.Columns["Name"].ReadOnly = true;
			this.dgvRefillInventory.Columns["TotalQty"].ReadOnly = true;
			this.dgvRefillInventory.Columns["QtyOnHand"].ReadOnly = true;
			this.dgvRefillInventory.Columns["QtyReleased"].ReadOnly = true;	
			this.dgvRefillInventory.Columns["TotalQty"].HeaderText = "Total QTY";
			this.dgvRefillInventory.Columns["QtyOnHand"].HeaderText = "QTY On Hand";
			this.dgvRefillInventory.Columns["QtyReleased"].HeaderText = "QTY Released";
			this.dgvRefillInventory.Columns["AddStocks"].HeaderText = "Add Stocks";
			this.dgvRefillInventory.Columns["RemoveStocks"].HeaderText = "Remove Stocks";
		}
		#endregion
		
	
		
		
		
		

		
		
	}
}

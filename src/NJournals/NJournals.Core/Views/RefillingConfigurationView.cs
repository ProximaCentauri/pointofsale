/*
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
			SetToolTip();
			this.Icon = new System.Drawing.Icon(System.IO.Directory.GetCurrentDirectory() + "/images/config.ico");
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
				                   inv.QtyReleased, "0", "0");
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
			string errorMessage = string.Empty;
			
			if(ValidateProductTypeName(productTypeIndexChange))
			{
				productTypes = GetProductTypeDataValueChange(productTypeIndexChange, out errorMessage);		
				
				if(errorMessage.Equals(string.Empty))
				{
					if(productTypes.Count != 0)
					{
						try
						{
						 	m_presenter.SaveOrUpdateProductType(productTypes);
							m_presenter.SetAllRefillProductType();
							MessageService.ShowInfo("Successfully added/updated Product Type.", "Save  or Updated Product Type");
							dgvProductType.Refresh();
							productTypeMaxRowIndex = this.dgvProductType.RowCount - 1;							
						}
						catch(Exception ex)
						{
							//TODO: error message
                            MessageService.ShowError("Unable to save data; an unexpected error occurred.\n" +
                                       "Please check error log for details.\n", ex);
						}
					}
				}
				else
				{
					//TODO: error message
					MessageService.ShowWarning("Unable to insert duplicate Product Type name: " + errorMessage.Remove(errorMessage.LastIndexOf(',')).Trim() +
					                          " . Please make sure that no duplicate entries before saving.", "Duplicate Product Type name");
				}
			}
			else
			{
				MessageService.ShowWarning("Cannot save empty product type name.");
			}
		}
		
		void BtnDeleteProductClick(object sender, EventArgs e)
		{
			RefillProductTypeDataEntity productType = new RefillProductTypeDataEntity();
			
			if(this.dgvProductType.SelectedRows.Count > 0)
			{
				if(MessageService.ShowYesNo("Are you sure to delete the selected Product Type?", "Delete Product Type"))
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
					productTypeMaxRowIndex = this.dgvProductType.RowCount - 1;
				}
			}			
		}
		
		private List<RefillProductTypeDataEntity> GetProductTypeDataValueChange(List<int> rowIndexChange, out string errorMessage)
		{
			List<RefillProductTypeDataEntity> productTypes = new List<RefillProductTypeDataEntity>();
			List<string> updatedProducts = new List<string>();
			string errorMsg = string.Empty;
			string name = string.Empty;
			string description = string.Empty;
			decimal price = 0;
			
			foreach(int rowIndex in rowIndexChange)
			{
				RefillProductTypeDataEntity productType = new RefillProductTypeDataEntity();
				name = this.dgvProductType.Rows[rowIndex].Cells["Name"].Value.ToString().Trim();
				
				if(this.dgvProductType.Rows[rowIndex].Cells["Description"].Value != null)
					description = this.dgvProductType.Rows[rowIndex].Cells["Description"].Value.ToString().Trim();
				
				price = Convert.ToDecimal(this.dgvProductType.Rows[rowIndex].Cells["Price"].Value.ToString());
				
				if(rowIndex < productTypeMaxRowIndex)
				{
					int productTypeID = (int)this.dgvProductType.Rows[rowIndex].Cells["ProductTypeID"].Value;
					productType = m_productTypeEntity.Find(m_productType => m_productType.ProductTypeID == productTypeID);
					
					productType.Name = name;
					productType.Description = description;
					productType.Price = price;
					
					productTypes.Add(productType);
					updatedProducts.Add(productType.Name.ToUpper());
				}
				else
				{
					RefillProductTypeDataEntity newProduct = new RefillProductTypeDataEntity();
					newProduct = m_productTypeEntity.Find(m_productType => m_productType.Name.ToUpper() == name.ToUpper());
					
					if((newProduct == null || newProduct.ProductTypeID == 0) && !updatedProducts.Contains(name.ToUpper()))
					{
						productType.Name = name;
						productType.Description = description;
						productType.Price = price;
						
						updatedProducts.Add(productType.Name.ToUpper());
						productTypes.Add(productType);
					}
					else
					{
						errorMsg += name + " , ";
					}
				}

			}
			errorMessage = errorMsg;			
			return productTypes;
		}
		
		private bool ValidateProductTypeName(List<int> rowIndexChange)
		{
			foreach(int rowIndex in rowIndexChange)
			{
				if(this.dgvProductType.Rows[rowIndex].Cells["Name"].Value == null ||
				   this.dgvProductType.Rows[rowIndex].Cells["Name"].Value.ToString().Trim().Equals(string.Empty))
					return false;
			}			
			return true;
		}
		
		void dgvProductType_cellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{		
			DataGridViewColumn price = dgvProductType.Columns["Price"];
			
			if(dgvProductType.Rows[e.RowIndex].IsNewRow) { return;}
			if(dgvProductType.CurrentCell.OwningColumn.HeaderText == "Price" && dgvProductType.IsCurrentCellInEditMode)
			{
				Decimal val;
				if(!Decimal.TryParse(Convert.ToString(e.FormattedValue), out val)){
					e.Cancel = true;
					MessageService.ShowWarning("Invalid value being inputted.", "Invalid Value");
					dgvProductType.CurrentCell = dgvProductType.Rows[e.RowIndex].Cells["Price"];
				}
			}
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
			string errorMessage = string.Empty;
			
			if(ValidateInventoryName())
			{
				refillInvs = GetRefillInvDataValueChange(refillInvIndexChange, out errorMessage);
				
				if(errorMessage.Equals(string.Empty))
				{
					if(refillInvs.Count > 0)
					{
						try
						{
							m_presenter.SaveOrUpdateRefillInventory(refillInvs);
							m_presenter.SetAllRefillInventory();	
							MessageService.ShowInfo("Successfully added/updated Inventory item.", "Save or Update Inventory Item");
							this.dgvRefillInventory.AllowUserToAddRows = false;
							dgvRefillInventory.Refresh();
							refillInvMaxRowIndex = this.dgvRefillInventory.RowCount - 1;
						}
						catch(Exception ex)
						{
                            MessageService.ShowError("Unable to save data; an unexpected error occurred.\n" +
                                       "Please check error log for details.\n", ex);
						}
					}
				}
				else
				{
					//TODO: error message
					MessageService.ShowWarning("Unable to insert duplicate inventory name: " + errorMessage.Remove(errorMessage.LastIndexOf(',')).Trim() +
					                          " . Please make sure that no duplicate entries before saving");
				}
			}
			else
			{
				MessageService.ShowWarning("Cannot save empty inventory name. Please input inventory name.");
			}		
		}
		
		void BtnDeleteInvClick(object sender, EventArgs e)
		{
			RefillInventoryHeaderDataEntity refillInv = new RefillInventoryHeaderDataEntity();
			
			if(this.dgvRefillInventory.SelectedRows.Count > 0)
			{
				if(MessageService.ShowYesNo("Are you sure to delete selected inventory item?", "Delete Inventory Item"))
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
					refillInvMaxRowIndex = this.dgvRefillInventory.RowCount - 1;
				}
			}			
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
		
		private List<RefillInventoryHeaderDataEntity> GetRefillInvDataValueChange(List<int> rowIndexChange, out string errorMessage)
		{
			List<RefillInventoryHeaderDataEntity> refillInvs = new List<RefillInventoryHeaderDataEntity>();
			RefillInventoryHeaderDataEntity refillInv = new RefillInventoryHeaderDataEntity();
			List<string> updatedRefillInv = new List<string>();
			string errorMsg = string.Empty;
			int addStocks = 0;
			int removeStocks = 0;
			string name = string.Empty;
				
			foreach(int rowIndex in rowIndexChange)
			{												
				if(!this.dgvRefillInventory.Rows[rowIndex].Cells["AddStocks"].Value.ToString().Trim().Equals(string.Empty))
					addStocks = (int)this.dgvRefillInventory.Rows[rowIndex].Cells["AddStocks"].Value;
				if(!this.dgvRefillInventory.Rows[rowIndex].Cells["RemoveStocks"].Value.ToString().Trim().Equals(string.Empty))
					removeStocks = (int)this.dgvRefillInventory.Rows[rowIndex].Cells["RemoveStocks"].Value;
				
				if(rowIndex <= refillInvMaxRowIndex)
				{					
					int ID = (int)this.dgvRefillInventory.Rows[rowIndex].Cells["InvHeaderID"].Value;					
					refillInv = m_refillInvEntity.Find(m_refillInv => m_refillInv.InvHeaderID == ID);					
					RefillInventoryDetailDataEntity invDetail = new RefillInventoryDetailDataEntity();
									
					bool detailFound = false;
					foreach(RefillInventoryDetailDataEntity detail in refillInv.DetailEntities)
					{
						if(detail.Date == DateTime.Now.Date)
						{
							detail.QtyAdded += addStocks;
							detail.QtyRemoved += removeStocks;
							detail.QtyOnHand += addStocks - removeStocks;						
							detail.TotalQty += addStocks - removeStocks;
							detailFound = true;
							break;							
						}
					}
					if(!detailFound){						
						invDetail = new RefillInventoryDetailDataEntity();
						invDetail.Date = DateTime.Now.Date;
						invDetail.QtyAdded += addStocks;
						invDetail.QtyRemoved += removeStocks;
						invDetail.QtyOnHand += addStocks - removeStocks;						
						invDetail.TotalQty += addStocks - removeStocks;
						invDetail.Header = refillInv;
						refillInv.DetailEntities.Add(invDetail);
					}																		
					refillInv.QtyOnHand += addStocks - removeStocks;
					refillInv.TotalAdded += addStocks;
					refillInv.TotalRemoved += removeStocks;
					refillInv.TotalQty += addStocks - removeStocks;
																
					refillInvs.Add(refillInv);
					updatedRefillInv.Add(refillInv.Name.ToUpper());
				}
				else
				{
					RefillInventoryHeaderDataEntity header = new RefillInventoryHeaderDataEntity();
					RefillInventoryHeaderDataEntity newHeader = new RefillInventoryHeaderDataEntity();
					RefillInventoryDetailDataEntity detail = new RefillInventoryDetailDataEntity();	
					name = this.dgvRefillInventory.Rows[rowIndex].Cells["Name"].Value.ToString().Trim();
					
					newHeader = m_refillInvEntity.Find(m_refillInv => m_refillInv.Name.ToUpper() == name.ToUpper());
					
					if((newHeader == null || newHeader.InvHeaderID == 0) && !updatedRefillInv.Contains(name.ToUpper()))
					{
						header.Name = name;
						header.QtyOnHand += addStocks;
						header.TotalAdded += addStocks;
						header.TotalQty += addStocks;
						
						detail.Header = header;			
						detail.Date = DateTime.Now.Date;
						detail.QtyAdded += addStocks;
						detail.QtyOnHand += addStocks;
						detail.TotalQty += addStocks;				
						
						header.DetailEntities.Add(detail);						
						refillInvs.Add(header);		
						updatedRefillInv.Add(header.Name.ToUpper());
					}
					else
					{
						errorMsg += name + " , ";
					}		
				}
			}

			errorMessage = errorMsg;
			return refillInvs;
		}
		
		private bool ValidateInventoryName()
		{
			int rowDataToAdd = (this.dgvRefillInventory.RowCount - 1) - refillInvMaxRowIndex;
			
			if(rowDataToAdd == 1)
			{
				return false;
			}
			
			for(int ctr = 1; ctr < rowDataToAdd; ctr++)
			{
				DataGridViewRow currentRow = this.dgvRefillInventory.Rows[refillInvMaxRowIndex + ctr];
				
				if(currentRow.Cells["Name"].Value == null || currentRow.Cells["Name"].Value.ToString().Trim().Equals(string.Empty))
						return false;
			}			
			
			return true;
		}
		
		void dgvRefillInventory_cellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{		
			Decimal val;
			
			if(dgvRefillInventory.Rows[e.RowIndex].IsNewRow) { return;}
			if(dgvRefillInventory.CurrentCell.OwningColumn.HeaderText == "Add Stocks" && dgvRefillInventory.IsCurrentCellInEditMode)
			{
				
				if(!Decimal.TryParse(Convert.ToString(e.FormattedValue), out val)){
					e.Cancel = true;
					MessageService.ShowWarning("Invalid value being inputted.", "Invalid Value");
					dgvRefillInventory.CurrentCell = dgvRefillInventory.Rows[e.RowIndex].Cells["AddStocks"];
				}
			}
			
			if(dgvRefillInventory.CurrentCell.OwningColumn.HeaderText == "Remove Stocks" && dgvRefillInventory.IsCurrentCellInEditMode)
			{
				if(!Decimal.TryParse(Convert.ToString(e.FormattedValue), out val)){
					e.Cancel = true;
					MessageService.ShowWarning("Invalid value being inputted.", "Invalid Value");
					dgvRefillInventory.CurrentCell = dgvRefillInventory.Rows[e.RowIndex].Cells["RemoveStocks"];
				}
			}
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
            this.dgvProductType.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvProductType.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));        
			this.dgvRefillInventory.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvRefillInventory.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));        
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
		
		void SetToolTip()
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(btnAddInv, "Add new inventory item");
			toolTip.SetToolTip(btnDeleteInv, "Remove inventory item");
			toolTip.SetToolTip(btnSaveInv, "Save or Update inventory item");
			toolTip.SetToolTip(btnDeleteProduct, "Remove product type");
			toolTip.SetToolTip(btnSaveProduct, "Save or Update product type");
		}
		#endregion

		
		
		
		
		

		
		
	}
}

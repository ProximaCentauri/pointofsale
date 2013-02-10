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
		
		List<int> productTypeIndexChange = new List<int>();
		int productTypeMaxRowIndex = -1;
		
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
		}
		
		public void SetAllRefillProductType(List<RefillProductTypeDataEntity> productTypes)
		{
			m_productTypeEntity = productTypes;
			BindingSource source = new BindingSource();
			source.DataSource = m_productTypeEntity;
			this.dgvProductType.DataSource = source;
			
			formatProductTypeDataGridView();
		}
		
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
		
		
		#region Format Methods
		void setButtonImages()
		{
			Resource.setImage(this.btnSaveProduct,System.IO.Directory.GetCurrentDirectory() + "/images/save2.png");
			Resource.setImage(this.btnDeleteProduct,System.IO.Directory.GetCurrentDirectory() + "/images/delete2.png");
			
			//Resource.setImage(this.btnSaveCategory,System.IO.Directory.GetCurrentDirectory() + "/images/save2.png");
			//Resource.setImage(this.btnDeleteCategory,System.IO.Directory.GetCurrentDirectory() + "/images/delete2.png");	
			
		}
		
		void formatAlternatingRows()
		{
			this.dgvProductType.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(177)))));
            this.dgvProductType.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(225)))));        
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
		#endregion
		
		
	}
}

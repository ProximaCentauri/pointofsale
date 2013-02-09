/*
 * Created by SharpDevelop.
 * User: user
 * Date: 1/31/2013
 * Time: 12:10 AM
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
	/// Description of LaundryConfigurationView.
	/// </summary>
	public partial class LaundryConfigurationView : BaseForm, ILaundryConfigurationView
	{
		LaundryConfigurationViewPresenter m_presenter;
		List<LaundryServiceDataEntity> m_serviceEntity;
		List<LaundryCategoryDataEntity> m_categoryEntity;
		List<LaundryPriceSchemeDataEntity> m_priceSchemeEntity;
			
		
		List<int> serviceRowIndexChange = new List<int>();
		List<int> categoryRowIndexChange = new List<int>();
		List<int> priceSchemeRowIndexChange = new List<int>();
		
		int servicesDataRowCount = 0;
		int categoryDataRowCount = 0;
		//int priceSchemeDataRowCount = 0;
		
		public LaundryConfigurationView()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void setButtonImages()
		{
			Resource.setImage(this.btnAddPriceScheme,System.IO.Directory.GetCurrentDirectory() + "/images/add2.png");
			Resource.setImage(this.btnSavePriceScheme,System.IO.Directory.GetCurrentDirectory() + "/images/save2.png");
			Resource.setImage(this.btnDeletePriceScheme,System.IO.Directory.GetCurrentDirectory() + "/images/delete2.png");
			
			Resource.setImage(this.btnSaveServices,System.IO.Directory.GetCurrentDirectory() + "/images/save2.png");
			Resource.setImage(this.btnDeleteServices,System.IO.Directory.GetCurrentDirectory() + "/images/delete2.png");
			
			Resource.setImage(this.btnSaveCategory,System.IO.Directory.GetCurrentDirectory() + "/images/save2.png");
			Resource.setImage(this.btnDeleteCategory,System.IO.Directory.GetCurrentDirectory() + "/images/delete2.png");	
			
		}
		
		void formatAlternatingRows()
		{
			this.dgvServices.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(177)))));
            this.dgvServices.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(225)))));
            this.dgvCategory.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(177)))));
            this.dgvCategory.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(225)))));
            this.dgvPriceScheme.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(177)))));
            this.dgvPriceScheme.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(250)))), ((int)(((byte)(225)))));
		}
			

		void LaundryConfigurationFormLoad(object sender, EventArgs e)
		{
			setButtonImages();
			formatAlternatingRows();
			
			m_presenter = new LaundryConfigurationViewPresenter(this);
			m_presenter.SetAllCategories();
			m_presenter.SetAllServices();
			m_presenter.SetAllPriceScheme();
		}
		
		public void SetAllCategories(List<LaundryCategoryDataEntity> categories){	
			m_categoryEntity = categories;			
			BindingSource source = new BindingSource();
			source.DataSource = m_categoryEntity;
			dgvCategory.DataSource = source;
			categoryDataRowCount = this.dgvCategory.RowCount;
			
			this.dgvCategory.Columns["CategoryID"].Visible = false;
            this.dgvCategory.Columns["Name"].Width = 300;
            this.dgvCategory.Columns["Description"].Width = 429;
            this.dgvCategory.Columns["Name"].HeaderText = "Category Name";
            this.dgvCategory.Columns["Description"].HeaderText = "Category Description";
			
		}
		
		public void SetAllServices(List<LaundryServiceDataEntity> services)
		{
			m_serviceEntity = services;
            BindingSource source = new BindingSource();
            source.DataSource = m_serviceEntity;
            dgvServices.DataSource = source;
            servicesDataRowCount = this.dgvServices.RowCount;
            
            this.dgvServices.Columns["ServiceID"].Visible = false;
            this.dgvServices.Columns["Name"].Width = 300;
            this.dgvServices.Columns["Description"].Width = 429;
            this.dgvServices.Columns["Name"].HeaderText = "Service Name";
            this.dgvServices.Columns["Description"].HeaderText = "Service Description";                
		}
		
		public void SetAllPriceScheme(List<LaundryPriceSchemeDataEntity> priceScheme)
		{
			m_priceSchemeEntity = priceScheme;		
			BindingSource source = new BindingSource();		

			DataTable tempTable = new DataTable();
			tempTable.Columns.Add("ID", typeof(int));
			tempTable.Columns.Add("ServiceName", typeof(string));
			tempTable.Columns.Add("CategoryName", typeof(string));
			tempTable.Columns.Add("Description", typeof(string));
			tempTable.Columns.Add("Price", typeof(int));
			                      
			foreach(LaundryPriceSchemeDataEntity price in m_priceSchemeEntity)
			{				
				tempTable.Rows.Add(price.ID, price.Service.Name, price.Category.Name,
                   price.Description, price.Price);
			}		
			
			source.DataSource = tempTable;
			dgvPriceScheme.DataSource = source;			
			
			dgvPriceScheme.Columns["ID"].Visible = false;
			dgvPriceScheme.Columns["ServiceName"].Width = 175;			
			dgvPriceScheme.Columns["ServiceName"].HeaderText = "Service Name";
			dgvPriceScheme.Columns["CategoryName"].Width = 175;			
			dgvPriceScheme.Columns["CategoryName"].HeaderText = "Category Name";
			dgvPriceScheme.Columns["Description"].Width = 295;		
			dgvPriceScheme.Columns["Description"].HeaderText = "Description";
			dgvPriceScheme.Columns["Price"].Width = 100;
			dgvPriceScheme.Columns["Price"].HeaderText = "Price";			
			
		}	
		
		
		#region Services
		
		void BtnDeleteServicesClick(object sender, EventArgs e)
		{
			LaundryServiceDataEntity service = new LaundryServiceDataEntity();
			
			if(this.dgvServices.SelectedRows.Count > 0)
			{
				foreach(DataGridViewRow currentRow in this.dgvServices.SelectedRows)
				{
					if(currentRow.Index < servicesDataRowCount - 1)
					{
						int serviceId = (int)this.dgvServices.Rows[currentRow.Index].Cells["ServiceID"].Value;
						service = m_serviceEntity.Find(m_service => m_service.ServiceID == serviceId);						
						m_presenter.DeleteService(service);						
					}
					
					if(!this.dgvServices.Rows[currentRow.Index].IsNewRow)
					 dgvServices.Rows.Remove(this.dgvServices.Rows[currentRow.Index]);										
				}
				m_presenter.SetAllServices();
			}
			servicesDataRowCount = this.dgvServices.RowCount;
			
		}
		
		void BtnSaveServicesClick(object sender, EventArgs e)
		{
			List<LaundryServiceDataEntity> services = new List<LaundryServiceDataEntity>();
			services = GetServiceDataValueChange(serviceRowIndexChange);
			if(services.Count != 0)
			{
			 	m_presenter.SaveOrUpdateService(services);
				m_presenter.SetAllServices();
				servicesDataRowCount = this.dgvServices.RowCount;
				dgvServices.Refresh();	
			}
		}
		
		private void dgvServices_CellValueChanged(object sender,
		    DataGridViewCellEventArgs e)
		{		   	
			if(e.RowIndex != -1)
			{
				if(!serviceRowIndexChange.Contains(e.RowIndex))
					serviceRowIndexChange.Add(e.RowIndex);
			}
		}
		
		private List<LaundryServiceDataEntity> GetServiceDataValueChange(List<int> rowIndexChange)
		{
			List<LaundryServiceDataEntity> services = new List<LaundryServiceDataEntity>();			
			
			foreach(int rowIndex in rowIndexChange)
			{
				LaundryServiceDataEntity service = new LaundryServiceDataEntity();
				
				if(rowIndex <  servicesDataRowCount - 1)
				{
					int serviceId = (int)this.dgvServices.Rows[rowIndex].Cells["ServiceID"].Value;
					service = m_serviceEntity.Find(m_service => m_service.ServiceID == serviceId);
				}

				service.Name = this.dgvServices.Rows[rowIndex].Cells["Name"].Value.ToString();
				service.Description = this.dgvServices.Rows[rowIndex].Cells["Description"].Value.ToString();
				services.Add(service);
			}			
			return services;
		}
		
		#endregion Services
		
		#region Category
		private void dgvCategory_CellValueChanged(object sender,
		    DataGridViewCellEventArgs e)
		{		   	
			if(e.RowIndex != -1)
			{
				if(!categoryRowIndexChange.Contains(e.RowIndex))
					categoryRowIndexChange.Add(e.RowIndex);
			}
		}
		
		void BtnSaveCategoryClick(object sender, EventArgs e)
		{
			List<LaundryCategoryDataEntity> category = new List<LaundryCategoryDataEntity>();
			category = GetCategoryDataValueChange(categoryRowIndexChange);					
			if(category.Count != 0)
			{
			 	m_presenter.SaveOrUpdateCategory(category);
				m_presenter.SetAllCategories();
				categoryDataRowCount = this.dgvCategory.RowCount;
				dgvCategory.Refresh();	
			}
		}
		
		void BtnDeleteCategoryClick(object sender, EventArgs e)
		{
			LaundryCategoryDataEntity category = new LaundryCategoryDataEntity();
			
			if(this.dgvCategory.SelectedRows.Count > 0)
			{
				foreach(DataGridViewRow currentRow in this.dgvCategory.SelectedRows)
				{
					if(currentRow.Index < categoryDataRowCount - 1)
					{
						int categoryId = (int)this.dgvCategory.Rows[currentRow.Index].Cells["CategoryID"].Value;
						category = m_categoryEntity.Find(m_category => m_category.CategoryID == categoryId);						
						m_presenter.DeleteCategory(category);
					}
					
					if(!this.dgvCategory.Rows[currentRow.Index].IsNewRow)
						dgvCategory.Rows.Remove(this.dgvCategory.Rows[currentRow.Index]);											
				}
				m_presenter.SetAllCategories();
			}
			categoryDataRowCount = this.dgvCategory.RowCount;
		}
		
		private List<LaundryCategoryDataEntity> GetCategoryDataValueChange(List<int> rowIndexChange)
		{
			List<LaundryCategoryDataEntity> categories = new List<LaundryCategoryDataEntity>();			
			
			foreach(int rowIndex in rowIndexChange)
			{
				LaundryCategoryDataEntity category = new LaundryCategoryDataEntity();
				
				if(rowIndex < categoryDataRowCount - 1)
				{
					int categoryId = (int)this.dgvCategory.Rows[rowIndex].Cells["CategoryID"].Value;
					category = m_categoryEntity.Find(m_category => m_category.CategoryID == categoryId);
				}

				category.Name = this.dgvCategory.Rows[rowIndex].Cells["Name"].Value.ToString();
				category.Description = this.dgvCategory.Rows[rowIndex].Cells["Description"].Value.ToString();
				categories.Add(category);
			}			
			return categories;
		}
		
		#endregion Category

		
		#region PriceScheme
		
		void BtnAddPriceSchemeClick(object sender, EventArgs e)
		{
			this.dgvPriceScheme.AllowUserToAddRows = true;
			
			DataGridViewComboBoxCell  serviceCbox = new DataGridViewComboBoxCell();
			this.dgvPriceScheme[1,dgvPriceScheme.RowCount-1] = serviceCbox;
			this.dgvPriceScheme[1,dgvPriceScheme.RowCount-1].ReadOnly = false;
			GetServiceName(serviceCbox);		
			
			DataGridViewComboBoxCell  categoryCBox = new DataGridViewComboBoxCell();
			this.dgvPriceScheme[2,dgvPriceScheme.RowCount-1] = categoryCBox;
			this.dgvPriceScheme[2,dgvPriceScheme.RowCount-1].ReadOnly = false;
			GetCategoryName(categoryCBox);
			
			this.dgvPriceScheme[3,dgvPriceScheme.RowCount-1].ReadOnly = false;
			this.dgvPriceScheme[4,dgvPriceScheme.RowCount-1].ReadOnly = false;			
				
		}
		
		void BtnSavePriceSchemeClick(object sender, EventArgs e)
		{
			LaundryPriceSchemeDataEntity newPriceScheme = new LaundryPriceSchemeDataEntity();			
			
			DataGridViewRow currentRow = this.dgvPriceScheme.CurrentCell.OwningRow;			
			newPriceScheme.Service = new LaundryServiceDataEntity();
			newPriceScheme.Service = m_serviceEntity.Find(m_service => m_service.Name == currentRow.Cells["ServiceName"].Value.ToString());
			newPriceScheme.Category = new LaundryCategoryDataEntity();
			newPriceScheme.Category = m_categoryEntity.Find(m_category => m_category.Name == currentRow.Cells["CategoryName"].Value.ToString());
			newPriceScheme.Description = currentRow.Cells["Description"].Value.ToString();
			newPriceScheme.Price = Convert.ToDecimal(currentRow.Cells["Price"].Value.ToString());
			
			m_presenter.SaveOrUpdatePriceScheme(newPriceScheme);
			m_presenter.SetAllPriceScheme();
		}
		
		private void GetCategoryName(DataGridViewComboBoxCell categoryCBox){	
			foreach(LaundryCategoryDataEntity category in m_categoryEntity)
			{
				categoryCBox.Items.Add(category.Name);
			}
		}
		
		
		
		private void GetServiceName(DataGridViewComboBoxCell serviceCBox){
			foreach(LaundryServiceDataEntity service in m_serviceEntity)
			{
				serviceCBox.Items.Add(service.Name);
			}
		}
		
		
		#endregion PriceScheme
		
		
	}
}

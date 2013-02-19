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
using System.Text;
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
		
		int servicesMaxRowIndex = -1;
		int categoryMaxRowIndex = -1;
		int priceSchemeMaxRowIndex = -1;
		
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
			categoryMaxRowIndex = this.dgvCategory.RowCount - 1;			
			formatCategoryDataGridView();			
		}
		
		public void SetAllServices(List<LaundryServiceDataEntity> services)
		{
			m_serviceEntity = services;
            BindingSource source = new BindingSource();
            source.DataSource = m_serviceEntity;
            dgvServices.DataSource = source;
            servicesMaxRowIndex = this.dgvServices.RowCount - 1;
            formatServicesDataGridView();                          
		}
		
		public void SetAllPriceScheme(List<LaundryPriceSchemeDataEntity> priceSchemes)
		{
			m_priceSchemeEntity = priceSchemes;		
			BindingSource source = new BindingSource();		

			DataTable tempTable = new DataTable();
			tempTable.Columns.Add("ID", typeof(int));
			tempTable.Columns.Add("ServiceName", typeof(string));
			tempTable.Columns.Add("CategoryName", typeof(string));
			tempTable.Columns.Add("Description", typeof(string));
			tempTable.Columns.Add("Price", typeof(Decimal));
			                      
			foreach(LaundryPriceSchemeDataEntity priceScheme in m_priceSchemeEntity)
			{				
				tempTable.Rows.Add(priceScheme.ID, priceScheme.Service.Name, priceScheme.Category.Name,
                   priceScheme.Description, priceScheme.Price);
			}		
			
			source.DataSource = tempTable;
			dgvPriceScheme.DataSource = source;		
			priceSchemeMaxRowIndex = this.dgvPriceScheme.RowCount - 1;	
			formatPriceSchemeDataGridView();
		}	
		
		
		#region Services
		
		void BtnDeleteServicesClick(object sender, EventArgs e)
		{
			LaundryServiceDataEntity service = new LaundryServiceDataEntity();
			
			if(this.dgvServices.SelectedRows.Count > 0)
			{
				foreach(DataGridViewRow currentRow in this.dgvServices.SelectedRows)
				{
					if(currentRow.Index < servicesMaxRowIndex)
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
			servicesMaxRowIndex = this.dgvServices.RowCount - 1;
			
		}
		
		void BtnSaveServicesClick(object sender, EventArgs e)
		{
			List<LaundryServiceDataEntity> services = new List<LaundryServiceDataEntity>();
			string errorMessage = string.Empty;
			
			services = GetServiceDataValueChange(serviceRowIndexChange, out errorMessage);
			
			if(errorMessage == string.Empty)
			{
				if(services.Count > 0)
				{	 				
					try
					{
						m_presenter.SaveOrUpdateService(services);	 	
						m_presenter.SetAllServices();
						servicesMaxRowIndex = this.dgvServices.RowCount - 1;
						dgvServices.Refresh();	
					}
					catch
					{
						//TODO: error message
						MessageService.ShowError("Unable to save data.");
					}
				}
			}
			else
			{
				//TODO: error message
				MessageService.ShowWarning("Unable to insert duplicate service name: " + errorMessage +
				                          " . Please make sure that no duplicate entries before saving");
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
		
		private List<LaundryServiceDataEntity> GetServiceDataValueChange(List<int> rowIndexChange, out string errorMessage)
		{
			List<LaundryServiceDataEntity> services = new List<LaundryServiceDataEntity>();		
			List<string> updatedServices = new List<string>();		
			string errorMsg = string.Empty;
			string name = string.Empty;
			string description = string.Empty;
			
			foreach(int rowIndex in rowIndexChange)
			{
				LaundryServiceDataEntity service = new LaundryServiceDataEntity();
				name = this.dgvServices.Rows[rowIndex].Cells["Name"].Value.ToString();
				description = this.dgvServices.Rows[rowIndex].Cells["Description"].Value.ToString();
				
				if(rowIndex <  servicesMaxRowIndex)
				{
					int serviceId = (int)this.dgvServices.Rows[rowIndex].Cells["ServiceID"].Value;
					service = m_serviceEntity.Find(m_service => m_service.ServiceID == serviceId);
					service.Name = name;
					service.Description = description;
					
					services.Add(service);
					updatedServices.Add(service.Name);
				}
				else
				{	
					LaundryServiceDataEntity newService = new LaundryServiceDataEntity();	
					newService = m_serviceEntity.Find(m_service => m_service.Name == name);

					if(newService.ServiceID == 0 && !updatedServices.Contains(name))
					{
						service.Name = name;
						service.Description = description;
					
						updatedServices.Add(service.Name);
						services.Add(service);
					}
					else
					{
						errorMsg += name + " , ";
					}
				}			

			}
			errorMessage = errorMsg;
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
			List<LaundryCategoryDataEntity> dupEntries = new List<LaundryCategoryDataEntity>();
			string errorMessage = string.Empty;
			
			category = GetCategoryDataValueChange(categoryRowIndexChange, out errorMessage);					
			
			if(errorMessage == string.Empty)
			{
				if(category.Count > 0)
				{		 
					try
					{
						m_presenter.SaveOrUpdateCategory(category);
						m_presenter.SetAllCategories();
						categoryMaxRowIndex = this.dgvCategory.RowCount - 1;
						dgvCategory.Refresh();	
					}
					catch(Exception ex)
					{
						//TODO: error message
						MessageService.ShowError("Unable to save data", ex.Message);
					}
				}
			}
			else
			{
				//TODO: error message
				MessageService.ShowWarning("Unable to insert duplicate category name: " + errorMessage +
				                          " . Please make sure that no duplicate entries before saving");
			}
		}
		
		void BtnDeleteCategoryClick(object sender, EventArgs e)
		{
			LaundryCategoryDataEntity category = new LaundryCategoryDataEntity();
			
			if(this.dgvCategory.SelectedRows.Count > 0)
			{
				foreach(DataGridViewRow currentRow in this.dgvCategory.SelectedRows)
				{
					if(currentRow.Index < categoryMaxRowIndex)
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
			categoryMaxRowIndex = this.dgvCategory.RowCount - 1;
		}
		
		private List<LaundryCategoryDataEntity> GetCategoryDataValueChange(List<int> rowIndexChange, out string errorMessage)
		{
			List<LaundryCategoryDataEntity> categories = new List<LaundryCategoryDataEntity>();		
			List<string> updatedCategories = new List<string>();
			string name = string.Empty;
			string description = string.Empty;
			string errorMsg = string.Empty;
			
			foreach(int rowIndex in rowIndexChange)
			{
				LaundryCategoryDataEntity category = new LaundryCategoryDataEntity();
				name = this.dgvCategory.Rows[rowIndex].Cells["Name"].Value.ToString();
				description = this.dgvCategory.Rows[rowIndex].Cells["Description"].Value.ToString();
				
				if(rowIndex < categoryMaxRowIndex)
				{
					int categoryId = (int)this.dgvCategory.Rows[rowIndex].Cells["CategoryID"].Value;
					category = m_categoryEntity.Find(m_category => m_category.CategoryID == categoryId);
					category.Name = name;
					category.Description = description;
					
					categories.Add(category);
					updatedCategories.Add(category.Name);
				}
				else
				{
					LaundryCategoryDataEntity newCategory = new LaundryCategoryDataEntity();
					newCategory = m_categoryEntity.Find(m_category => m_category.Name == name);					
					
					if(newCategory.CategoryID == 0 && !updatedCategories.Contains(name))
					{
						category.Name = name;
						category.Description = description;
					
						updatedCategories.Add(category.Name);
						categories.Add(category);
					}
					else
					{
						errorMsg += name + " , ";
					}
					
				}
			}			
			errorMessage = errorMsg;
			return categories;
		}
		
		#endregion Category

		
		#region PriceScheme
		
		private void dgvPriceScheme_CellValueChanged(object sender,
		    DataGridViewCellEventArgs e)
		{		   	
			if(e.RowIndex != -1)
			{
				if(!priceSchemeRowIndexChange.Contains(e.RowIndex))
					priceSchemeRowIndexChange.Add(e.RowIndex);
			}
		}
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
			List<LaundryPriceSchemeDataEntity> priceSchemes = new List<LaundryPriceSchemeDataEntity>();
			List<LaundryPriceSchemeDataEntity> dupEntries = new List<LaundryPriceSchemeDataEntity>();
			
			//get modified row
			if(priceSchemeRowIndexChange != null)
			{				
				priceSchemes = GetPriceSchemeDataValueChange(priceSchemeRowIndexChange);

			}
			
			//get new data
			if(this.dgvPriceScheme.RowCount -1 > priceSchemeMaxRowIndex)
			{
				int rowDataToAdd =  (this.dgvPriceScheme.RowCount - 1) - priceSchemeMaxRowIndex;
				string serviceName = string.Empty;
				string categoryName = string.Empty;
				
				for(int ctr = 1; ctr < rowDataToAdd; ctr++)
				{
					LaundryPriceSchemeDataEntity priceScheme = new LaundryPriceSchemeDataEntity();	
					LaundryPriceSchemeDataEntity newPriceScheme = new LaundryPriceSchemeDataEntity();
					DataGridViewRow currentRow = this.dgvPriceScheme.Rows[priceSchemeMaxRowIndex + ctr];
					serviceName = currentRow.Cells["ServiceName"].Value.ToString();
					categoryName = currentRow.Cells["CategoryName"].Value.ToString();
					
					newPriceScheme = m_priceSchemeEntity.Find(m_priceScheme => (m_priceScheme.Service.Name == serviceName) 
					                                          && (m_priceScheme.Category.Name == categoryName));				
										
					priceScheme.Service = new LaundryServiceDataEntity();
					priceScheme.Service = m_serviceEntity.Find(m_service => m_service.Name == serviceName);
					priceScheme.Category = new LaundryCategoryDataEntity();
					priceScheme.Category = m_categoryEntity.Find(m_category => m_category.Name == categoryName);
					priceScheme.Description = currentRow.Cells["Description"].Value.ToString();
					priceScheme.Price = Convert.ToDecimal(currentRow.Cells["Price"].Value.ToString());
					
					priceSchemes.Add(priceScheme);
				}
			}			
			
			if(priceSchemes.Count > 0)
			{
				if((dupEntries = m_presenter.SaveOrUpdatePriceScheme(priceSchemes)).Count > 0)
				{
					ErrorMessage(dupEntries);
				}
				m_presenter.SetAllPriceScheme();
				priceSchemeMaxRowIndex = this.dgvPriceScheme.RowCount - 1;
				this.dgvPriceScheme.AllowUserToAddRows = false;
			}
		}
		
		void BtnDeletePriceSchemeClick(object sender, EventArgs e)
		{
			LaundryPriceSchemeDataEntity priceScheme = new LaundryPriceSchemeDataEntity();
			
			if(this.dgvPriceScheme.SelectedRows.Count > 0)
			{
				foreach(DataGridViewRow currentRow in this.dgvPriceScheme.SelectedRows)
				{
					if(currentRow.Index <= priceSchemeMaxRowIndex)
					{
						int ID = (int)this.dgvPriceScheme.Rows[currentRow.Index].Cells["ID"].Value;
						priceScheme = m_priceSchemeEntity.Find(m_priceScheme => m_priceScheme.ID == ID);						
						m_presenter.DeletePriceScheme(priceScheme);
					}
					
					if(!this.dgvPriceScheme.Rows[currentRow.Index].IsNewRow)
						dgvPriceScheme.Rows.Remove(this.dgvPriceScheme.Rows[currentRow.Index]);
				}
				m_presenter.SetAllPriceScheme();
			    this.dgvPriceScheme.AllowUserToAddRows = false;
			}
			priceSchemeMaxRowIndex = this.dgvPriceScheme.RowCount - 1;
		}
		
		private List<LaundryPriceSchemeDataEntity> GetPriceSchemeDataValueChange(List<int> rowIndexChange)
		{
			List<LaundryPriceSchemeDataEntity> priceSchemes = new List<LaundryPriceSchemeDataEntity>();	
			List<string> updatedPriceScheme = new List<string>();
			string serviceName = string.Empty;
			string categoryName = string.Empty;
			
			foreach(int rowIndex in rowIndexChange)
			{
				LaundryPriceSchemeDataEntity priceScheme = new LaundryPriceSchemeDataEntity();
				serviceName = this.dgvPriceScheme.Rows[rowIndex].Cells["ServiceName"].Value.ToString();
				categoryName = this.dgvPriceScheme.Rows[rowIndex].Cells["CategoryName"].Value.ToString();
				
				if(rowIndex <= priceSchemeMaxRowIndex)
				{
					int ID = (int)this.dgvPriceScheme.Rows[rowIndex].Cells["ID"].Value;
					priceScheme = m_priceSchemeEntity.Find(m_priceScheme => m_priceScheme.ID == ID);
					priceScheme.Description = this.dgvPriceScheme.Rows[rowIndex].Cells["Description"].Value.ToString();
					priceScheme.Price = Convert.ToDecimal(this.dgvPriceScheme.Rows[rowIndex].Cells["Price"].Value.ToString());
					priceSchemes.Add(priceScheme);
				}
				else
				{
					//TODO: new data
				}
				

			}			
			return priceSchemes;
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
		
		
		#region Format Methods
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
		
		void formatCategoryDataGridView()
		{
			this.dgvCategory.Columns["CategoryID"].Visible = false;
            this.dgvCategory.Columns["Name"].Width = 300;
            this.dgvCategory.Columns["Description"].Width = 429;
            this.dgvCategory.Columns["Name"].HeaderText = "Category Name";
            this.dgvCategory.Columns["Description"].HeaderText = "Category Description";
		}
		
		void formatServicesDataGridView()
		{
			this.dgvServices.Columns["ServiceID"].Visible = false;
            this.dgvServices.Columns["Name"].Width = 300;
            this.dgvServices.Columns["Description"].Width = 429;
            this.dgvServices.Columns["Name"].HeaderText = "Service Name";
            this.dgvServices.Columns["Description"].HeaderText = "Service Description";  
		}
		
		void formatPriceSchemeDataGridView()
		{
			dgvPriceScheme.Columns["ID"].Visible = false;
			dgvPriceScheme.Columns["ServiceName"].Width = 175;			
			dgvPriceScheme.Columns["ServiceName"].HeaderText = "Service Name";
			dgvPriceScheme.Columns["ServiceName"].ReadOnly = true;
			dgvPriceScheme.Columns["CategoryName"].Width = 175;			
			dgvPriceScheme.Columns["CategoryName"].HeaderText = "Category Name";
			dgvPriceScheme.Columns["CategoryName"].ReadOnly = true;
			dgvPriceScheme.Columns["Description"].Width = 295;		
			dgvPriceScheme.Columns["Description"].HeaderText = "Description";
			dgvPriceScheme.Columns["Price"].Width = 100;
			dgvPriceScheme.Columns["Price"].HeaderText = "Price";	
		}
		#endregion
		
		#region Helper Methods
		private void ErrorMessage<T>(List<T> dupEntries)
		{
			StringBuilder message = new StringBuilder();
			message.AppendLine("Cannot insert duplicate entry: ");
			
			foreach(object dup in dupEntries)
			{
				switch(dup.GetType().ToString())
				{
					case "NJournals.Common.DataEntities.LaundryServiceDataEntity":
						{
							LaundryServiceDataEntity var = (LaundryServiceDataEntity) dup;
							message.AppendLine(" - " + var.Name);
						}
					break;
					case "NJournals.Common.DataEntities.LaundryCategoryDataEntity":
						{
							LaundryCategoryDataEntity var = (LaundryCategoryDataEntity) dup;
							message.AppendLine(" - " + var.Name);
						}
					break;
					case "NJournals.Common.DataEntities.LaundryPriceSchemeDataEntity":
						{
							LaundryPriceSchemeDataEntity var = (LaundryPriceSchemeDataEntity) dup;
							message.AppendLine(" - " + var.Service.Name + " - " + var.Category.Name);
						}
					break;
				}
			}			
			MessageService.ShowWarning(message.ToString());		
		}
		
		
		#endregion
		
	}
}

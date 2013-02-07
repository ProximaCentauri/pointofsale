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
			Resource.setImage(this.btnEditPriceScheme,System.IO.Directory.GetCurrentDirectory() + "/images/edit2.png");
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
			foreach(LaundryCategoryDataEntity category in categories){
				this.dgvCategory.Rows.Add(category.Name, category.Description);
			}
		}
		
		public void SetAllServices(List<LaundryServiceDataEntity> services)
		{
			m_serviceEntity = services;
			foreach(LaundryServiceDataEntity service in services)
			{
				this.dgvServices.Rows.Add(service.ServiceID,service.Name, service.Description);
			}
			
		}
		
		public void SetAllPriceScheme(List<LaundryPriceSchemeDataEntity> priceScheme)
		{
		}	
		
		void BtnDeleteServicesClick(object sender, EventArgs e)
		{
			
		}
		
		void BtnSaveServicesClick(object sender, EventArgs e)
		{
			
		}
		
		private void dgvServices_CellValueChanged(object sender,
		    DataGridViewCellEventArgs e)
		{		    	
			if(e.RowIndex != -1)
		   	 GetDataValueChange(e.RowIndex, e.ColumnIndex);
		}
		
		private void GetDataValueChange(int rowIndex, int columnIndex)
		{
			LaundryServiceDataEntity service = new LaundryServiceDataEntity();
			
			if(rowIndex < this.dgvServices.RowCount - 2)
			{
				int serviceId = (int)this.dgvServices.Rows[rowIndex].Cells["ID"].Value;
				service = m_serviceEntity.Find(m_service => m_service.ServiceID == serviceId);
			}
			//else
			//{
			//	service.Name = this.dgvServices.Rows[rowIndex].Cells["ServiceName"].Value.ToString();
			//	service.Description = this.dgvServices.Rows[rowIndex].Cells["ServiceDescription"].Value.ToString();
			//}
			
			
		}
	}
}

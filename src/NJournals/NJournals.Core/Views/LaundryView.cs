/*
 * Created by SharpDevelop.
 * User: vo185003
 * Date: 1/25/2013
 * Time: 7:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using NJournals.Common.Interfaces;
using NJournals.Common.Gui;
using NJournals.Common.DataEntities;
using NJournals.Common.Util;
using System.Collections.Generic;
using NJournals.Core.Presenter;
using NJournals.Core.Models;
using System.Data;
namespace NJournals.Core.Views
{
	/// <summary>
	/// Description of LaundryNewView.
	/// </summary>
	public partial class LaundryNewView : BaseForm, ILaundryView
	{
		public LaundryNewView()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		
		}
		
		LaundryViewPresenter m_presenter;
		ILaundryDao m_laundryDao;
		
		void setButtonImages()
		{
			Resource.setImage(this.btnsearch, System.IO.Directory.GetCurrentDirectory() + "/images/search.png");
			Resource.setImage(this.btnCustomerSearch, System.IO.Directory.GetCurrentDirectory() + "/images/search.png");
		}
		
		void LaundryNewViewLoad(object sender, EventArgs e)
		{
			setButtonImages();
				
			m_laundryDao = new LaundryDao();
			m_presenter = new LaundryViewPresenter(this, m_laundryDao);
			if(this.Text.Contains("[NEW]")){
				m_presenter.SetAllCategories();
				m_presenter.SetAllServices();
				this.groupBox2.Enabled = this.btnclaim.Enabled = false;
			}
		}
				
		public void SetAllCategories(IList<LaundryCategoryDataEntity> categories){
			foreach(LaundryCategoryDataEntity category in categories){
				this.cmbcategory.Items.Add(category.Name);
			}
		}
		
		public void SetAllServices(IList<LaundryServiceDataEntity> services){
			foreach(LaundryServiceDataEntity service in services){
				this.cmbservices.Items.Add(service.Name);
			}
		}
		
		void BtncancelClick(object sender, EventArgs e){
			m_presenter.CancelClicked();
		}		
		
		private void processHeaderDataEntity(){
			m_headerEntity = new LaundryHeaderDataEntity();
			double amountDue;
			double.TryParse(this.txtamtdue.Text, out amountDue);
			double amountTender;
			double.TryParse(txtamttender.Text, out amountTender);
			if(amountDue > 0 && amountTender > 0){
				m_headerEntity.AmountDue = 	amountDue;
				m_headerEntity.AmountTender = amountTender;
			}else
				MessageService.ShowError("Invalid field in Amount due or Amount tender.","Error");
			
			m_headerEntity.ReceivedDate = dtrecieveDate.Value;
			m_headerEntity.DueDate = dtdueDate.Value;
			//TODO: change totalitemqty value to textbox value of totalitemqty
			m_headerEntity.TotalItemQty = 1;
			m_headerEntity.PaidFlag = chkpaywhenclaim.Checked;
			m_headerEntity.ClaimFlag = btnclaim.Enabled;		
			CustomerDataEntity customer = new CustomerDataEntity();
			customer.Name = txtname.Text;
			m_headerEntity.Customer = customer;			
			
			foreach(DataGridViewRow row in this.dataGridView1.Rows){
				LaundryDetailDataEntity detail = new LaundryDetailDataEntity();
				detail.Header = m_headerEntity;
				LaundryCategoryDataEntity category = new LaundryCategoryDataEntity();
				category.Name = row.Cells[0].Value.ToString();
				detail.Category = category;			
				LaundryServiceDataEntity service = new LaundryServiceDataEntity();
				service.Name = row.Cells[1].Value.ToString();
				detail.Service = service;
				detail.Kilo = int.Parse(row.Cells[2].Value.ToString());
				detail.ItemQty = int.Parse(row.Cells[3].Value.ToString());
				detail.Amount = int.Parse(row.Cells[4].Value.ToString());
				m_headerEntity.DetailEntities.Add(detail);
			}
			 
			
		}
		
		LaundryHeaderDataEntity m_headerEntity;
		
		public LaundryHeaderDataEntity HeaderDataEntity {
			get { return m_headerEntity; }
			set { m_headerEntity = value; }
		}
	
		public void AddItem(){
			LaundryPriceSchemeDao priceDao = new LaundryPriceSchemeDao();
			LaundryPriceSchemeDataEntity priceEntity = new LaundryPriceSchemeDataEntity();
			priceEntity = priceDao.GetByCategoryService(cmbcategory.Text, cmbservices.Text);
			
			IList<String> lstItems = new List<String>();
			lstItems.Add(cmbcategory.Text);
			lstItems.Add(cmbservices.Text);
			lstItems.Add(txtnoitems.Text);
			lstItems.Add(txtkilo.Text);
			string[] items = new string[lstItems.Count];
			lstItems.CopyTo(items,0);
			dataGridView1.Rows.Add(items);
		}
		
		void BtnaddClick(object sender, EventArgs e)
		{
			m_presenter.AddNewItemClicked();
		}
	}
}

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
		private decimal amountTender = 0;
		private decimal amountDue = 0;
		
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
				m_presenter.SetAllCustomers();
				m_presenter.SetAllCharges();
				this.groupBox2.Enabled = this.btnclaim.Enabled = false;
				txtjoborder.Text = m_presenter.getHeaderID().ToString().PadLeft(6, '0');
			}
		}
				
		public void SetAllCategories(List<LaundryCategoryDataEntity> categories){				
			foreach(LaundryCategoryDataEntity category in categories){
				this.cmbcategory.Items.Add(category.Name);
			}
		}
		
		public void SetAllServices(List<LaundryServiceDataEntity> services){			
			foreach(LaundryServiceDataEntity service in services){
				this.cmbservices.Items.Add(service.Name);
			}
		}
		
		public void SetAllCustomers(List<CustomerDataEntity> customers){
			foreach(CustomerDataEntity customer in customers){
				this.cmbCustomers.Items.Add(customer.Name);
			}
		}
		
		public void SetAllCharges(List<LaundryChargeDataEntity> charges){
			foreach(LaundryChargeDataEntity charge in charges){
				this.chkchargesList.Items.Add(charge.Name);
			}
		}
		
		void BtncancelClick(object sender, EventArgs e){
			m_presenter.CancelClicked();
		}		
		
		private void processHeaderDataEntity(){
			m_headerEntity = new LaundryHeaderDataEntity();
			m_headerEntity.AmountTender = this.amountTender;
			m_headerEntity.AmountDue = this.amountDue;
			
			m_headerEntity.ReceivedDate = dtrecieveDate.Value;
			m_headerEntity.DueDate = dtdueDate.Value;
			//TODO: change totalitemqty value to textbox value of totalitemqty
			m_headerEntity.TotalItemQty = 1;
			m_headerEntity.PaidFlag = chkpaywhenclaim.Checked;
			m_headerEntity.ClaimFlag = btnclaim.Enabled;		
			
			m_headerEntity.Customer = m_presenter.getCustomerByName(cmbCustomers.Text);			
			
			foreach(DataGridViewRow row in this.dataGridView1.Rows){
				LaundryDetailDataEntity detail = new LaundryDetailDataEntity();
				detail.Header = m_headerEntity;				
				detail.Category = m_presenter.getCategoryByName(row.Cells[0].Value.ToString());				
				detail.Service = m_presenter.getServiceByName(row.Cells[1].Value.ToString());
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
			LaundryPriceSchemeDataEntity priceEntity = m_presenter.getLaundryPrice(cmbcategory.Text,cmbservices.Text);
			decimal kilo = decimal.Parse(txtkilo.Text);			
			decimal price = priceEntity.Price * kilo;	
			List<String> lstItems = new List<String>();
			lstItems.Add(cmbcategory.Text);
			lstItems.Add(cmbservices.Text);
			lstItems.Add(txtnoitems.Text);
			lstItems.Add(txtkilo.Text);
			lstItems.Add(price.ToString("N2"));
			string[] items = new string[lstItems.Count];
			lstItems.CopyTo(items,0);
			dataGridView1.Rows.Add(items);
			txtamtdue.Text = (this.amountDue + price).ToString("N2");			
		}
		
		void BtnaddClick(object sender, EventArgs e)
		{
			m_presenter.AddNewItemClicked();
		}
		
		void txtbox_keypress(object sender, KeyPressEventArgs e)
		{
			if(sender is TextBox){
				TextBox txt = sender as TextBox;
				if(!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) 
				   && (e.KeyChar != (char)Keys.Decimal) && (e.KeyChar != (char)Keys.OemPeriod)){
				   e.Handled = true;
				}
				else{
					e.Handled = false;						
				}									   
			}					
		}			
		
		void txtamttender_textchanged(object sender, EventArgs e)
		{
			if(txtamttender.Text.Length == 0){
				txtamttender.Text = "0.00";				
			}	
			this.amountTender = decimal.Parse(txtamttender.Text);
			this.amountDue = decimal.Parse(txtamtdue.Text);				
			if(amountTender < amountDue){
				txtbalance.Text = (amountDue - amountTender).ToString("N2");
				txtchange.Text = "0.00";
			}else{
				txtchange.Text = (amountTender - amountDue).ToString("N2");	
				txtbalance.Text = "0.00";
			}							
		}		
		
		void additionalCharges_checkedchanged(object sender, EventArgs e)
		{
			/*decimal totalcharge = 0M;
			decimal charge = 0M;
			if(sender is CheckBox){
				CheckBox chargeChkBox = sender as CheckBox;
				if(chargeChkBox.Checked){
					///add charge to totalcharge
					charge = m_presenter.getJobChargeByName(chargeChkBox.Text);
					//totalcharge = decimal.Parse(txtcharges.Text) + charge;
					//txtcharges.Text = totalcharge.ToString("N2");
				}else{
					charge = m_presenter.getJobChargeByName(chargeChkBox.Text);
					//totalcharge = decimal.Parse(txtcharges.Text) - charge;
					//txtcharges.Text = totalcharge.ToString("N2");
				}
			}*/
		}
		
		void chkchargeList_selectedindexchanged(object sender, EventArgs e)
		{
			decimal totalcharge = 0M;
			decimal charge = 0M;
			foreach(object checkedItem in this.chkchargesList.CheckedItems){
				
			}
		}
	}	
}


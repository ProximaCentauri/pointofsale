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
		LaundryJobChargesDataEntity m_jobcharge = null;
		private decimal amountTender = 0;
		private decimal amountDue = 0;
		private decimal totalAmtDue = 0;
		
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
				this.dtrecieveDate.Value = DateTime.Now;
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
		
		private LaundryHeaderDataEntity processHeaderDataEntity(){
			m_headerEntity = new LaundryHeaderDataEntity();			
			
			m_headerEntity.AmountTender = decimal.Parse(this.txtamttender.Text);			                                            
			m_headerEntity.TotalAmountDue = decimal.Parse(txttotalamtdue.Text);
			
			m_headerEntity.ReceivedDate = dtrecieveDate.Value;
			m_headerEntity.DueDate = dtdueDate.Value;
			//TODO: change totalitemqty value to textbox value of totalitemqty
			m_headerEntity.TotalItemQty = 1;			
			m_headerEntity.ClaimFlag = btnclaim.Enabled;			
			m_headerEntity.Customer = m_presenter.getCustomerByName(cmbCustomers.Text);			
			
			foreach(DataGridViewRow row in this.dataGridView1.Rows){
				if(row.Cells[0].Value != null){
					if(!string.IsNullOrEmpty(row.Cells[0].Value.ToString())){
						LaundryDetailDataEntity detail = new LaundryDetailDataEntity();
						detail.Header = m_headerEntity;				
						detail.Category = m_presenter.getCategoryByName(row.Cells[0].Value.ToString());				
						detail.Service = m_presenter.getServiceByName(row.Cells[1].Value.ToString());
						detail.Kilo = double.Parse(row.Cells[2].Value.ToString());
						detail.ItemQty = int.Parse(row.Cells[3].Value.ToString());
						detail.Amount = decimal.Parse(row.Cells[4].Value.ToString());
						m_headerEntity.DetailEntities.Add(detail);
					}	
				}							
			}		
			m_headerEntity.TotalAmountDue = decimal.Parse(txttotalamtdue.Text);
			m_headerEntity.TotalCharge = decimal.Parse(txttotalcharges.Text);
			m_headerEntity.TotalDiscount = decimal.Parse(txttotaldiscount.Text);
			m_headerEntity.AmountTender = decimal.Parse(txtamttender.Text);
			m_headerEntity.AmountDue = decimal.Parse(txtamtdue.Text);
			
			LaundryPaymentDetailDataEntity paymentdetail = new LaundryPaymentDetailDataEntity();
			//TODO: amount should be amounttender - amount change.
			paymentdetail.Amount = m_headerEntity.AmountTender;
			paymentdetail.PaymentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			paymentdetail.Header = m_headerEntity;
			m_headerEntity.PaymentDetailEntities.Add(paymentdetail);
			foreach(object checkedItem in this.chkchargesList.CheckedItems){
				m_jobcharge = new LaundryJobChargesDataEntity();
				m_jobcharge.Charge = m_presenter.getJobChargeByName(checkedItem.ToString());
				m_jobcharge.Header = m_headerEntity;
				m_headerEntity.JobChargeEntities.Add(m_jobcharge);
			}
			if(decimal.Parse(this.txtbalance.Text) == 0){
				m_headerEntity.PaidFlag = true;				
			}else
				m_headerEntity.PaidFlag = false;
			
			return m_headerEntity;
		}
		
		
		LaundryHeaderDataEntity m_headerEntity;
		
		public LaundryHeaderDataEntity HeaderDataEntity {
			get { return processHeaderDataEntity(); }
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
			this.totalAmtDue = decimal.Parse(txtamtdue.Text) + totalAmtDue;
			this.txttotalamtdue.Text = (decimal.Parse(txttotalamtdue.Text) + totalAmtDue).ToString("N2");
			this.txtbalance.Text = this.txttotalamtdue.Text;
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
			this.totalAmtDue = decimal.Parse(txttotalamtdue.Text);				
			if(amountTender < totalAmtDue){
				txtbalance.Text = (totalAmtDue - amountTender).ToString("N2");
				txtchange.Text = "0.00";
			}else{
				txtchange.Text = (amountTender - totalAmtDue).ToString("N2");	
				txtbalance.Text = "0.00";
			}							
		}		
		
		void chkchargeList_selectedindexchanged(object sender, EventArgs e)
		{
			decimal totalcharge = 0M;
			decimal temp_totalcharge = 0M;
			decimal charge = 0M;
			txttotalcharges.Text = "0.00";
			foreach(object checkedItem in this.chkchargesList.CheckedItems){
				charge = m_presenter.getAmtChargeByName(checkedItem.ToString());
				temp_totalcharge = totalcharge + charge;
				totalcharge = temp_totalcharge;
			}
			txttotalcharges.Text = totalcharge.ToString("N2");
			txttotalamtdue.Text = (decimal.Parse(txttotalcharges.Text) + totalAmtDue).ToString("N2");
		}
		
		
		void textbox_click(object sender, EventArgs e)
		{
			if(sender is TextBox){
				TextBox txt = sender as TextBox;
				txt.SelectionStart = 0;
				txt.SelectionLength = txt.Text.Length;
				txt.Focus();
			}
		}
		
		void txtdiscount_textchange(object sender, EventArgs e)
		{
			txttotaldiscount.Text = ((decimal.Parse(txtdiscount.Text) / 100M) * decimal.Parse(txttotalamtdue.Text)).ToString("N2");
			txttotalamtdue.Text = (decimal.Parse(txttotalamtdue.Text) - decimal.Parse(txttotaldiscount.Text)).ToString("N2");
		}
		
		void BtnsavecloseClick(object sender, EventArgs e)
		{
			m_presenter.SaveClicked();
			MessageService.ShowInfo("Successfully saved entries.","Information");			
			                       
		}
	}	
}


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
		LaundryHeaderDataEntity m_headerEntity;
		CheckListView chklistView = null;
		private decimal amountTender = 0;
		
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
				m_headerEntity = new LaundryHeaderDataEntity();						
				m_presenter.SetAllServices();
				m_presenter.SetAllCustomers();
				m_presenter.SetAllCharges();
				this.groupBox2.Enabled = this.btnclaim.Enabled = false;
				txtjoborder.Text = m_presenter.getHeaderID().ToString().PadLeft(6, '0');
				this.dtrecieveDate.Value = DateTime.Now;				
			}else{
				grpServices.Enabled = false;
				lblchecklist.Enabled = false;
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
		
		public LaundryHeaderDataEntity ProcessHeaderDataEntity(){				
			
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
			
			if(m_headerEntity.AmountTender >= m_headerEntity.TotalAmountDue){
				paymentdetail.Amount = m_headerEntity.TotalAmountDue;	
			}else{
				paymentdetail.Amount = m_headerEntity.TotalAmountDue - decimal.Parse(txtbalance.Text);
			}
			
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
		
	
		public void AddItem(){
			LaundryPriceSchemeDataEntity priceEntity = m_presenter.getLaundryPrice(cmbcategory.Text,cmbservices.Text);
			decimal kilo = decimal.Parse(txtkilo.Text);			
			decimal price = priceEntity.Price * kilo;	
			dataGridView1.Rows.Add(cmbcategory.Text, cmbservices.Text, txtnoitems.Text, txtkilo.Text, price.ToString("N2"));
			txtamtdue.Text = (decimal.Parse(txtamtdue.Text) + price).ToString("N2");
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
			if(txttotaldiscount.Text.Length == 0){
				txttotaldiscount.Text = "0";	
			}
			txttotaldiscount.Text = ((decimal.Parse(txtdiscount.Text) / 100M) * (decimal.Parse(txtamtdue.Text) + decimal.Parse(txttotalcharges.Text))).ToString("N2");
			txttotalamtdue.Text = (decimal.Parse(txttotalamtdue.Text) - decimal.Parse(txttotaldiscount.Text)).ToString("N2");	
		}
		
		void BtnsavecloseClick(object sender, EventArgs e)
		{
			m_presenter.SaveClicked();			                       
		}
		
		void lblchecklist_click(object sender, EventArgs e)
		{
			m_presenter.LaunchChecklist();
		}
		
		public void LaunchChecklist(){			
			chklistView = new CheckListView(m_headerEntity);
			chklistView.SelectChecklist += delegate { GetSelectedChecklist(); };
			chklistView.ShowDialog();		
		}
		
		public void GetSelectedChecklist(){
			List<LaundryJobChecklistDataEntity> checkListEntities = chklistView.GetAllSelectedCheckList();
			if(checkListEntities.Count > 0){
				m_headerEntity.JobChecklistEntities = checkListEntities;
				MessageService.ShowInfo("fire in the hole!");
			}else
				MessageService.ShowInfo("enemy down!");				
		}
		
		public void LoadHeaderEntityData(LaundryHeaderDataEntity p_headerEntity){
			this.m_headerEntity = p_headerEntity;
			if(this.m_headerEntity != null){
				txtjoborder.Text = m_headerEntity.LaundryHeaderID.ToString().PadLeft(6, '0');
				cmbCustomers.Text = m_headerEntity.Customer.Name;
				dtrecieveDate.Value = m_headerEntity.ReceivedDate;
				dtdueDate.Value = m_headerEntity.DueDate;
				foreach(LaundryDetailDataEntity detailEntity in m_headerEntity.DetailEntities){
					dataGridView1.Rows.Add(detailEntity.Category.Name, detailEntity.Service.Name, detailEntity.Kilo.ToString(), detailEntity.ItemQty.ToString(), detailEntity.Amount.ToString("N2"));
				}
				txtamtdue.Text = m_headerEntity.AmountDue.ToString("N2");
				txttotalamtdue.Text = m_headerEntity.TotalAmountDue.ToString("N2");
				txttotalcharges.Text = m_headerEntity.TotalCharge.ToString("N2");
				txttotaldiscount.Text = m_headerEntity.TotalDiscount.ToString("0");
				
				txtdiscount.Text = ((m_headerEntity.TotalDiscount / (m_headerEntity.AmountDue + m_headerEntity.TotalCharge)) * 100).ToString("0");
								
				chkpaywhenclaim.Enabled = m_headerEntity.PaidFlag;
				
				foreach(LaundryJobChargesDataEntity chargeEntity in m_headerEntity.JobChargeEntities){
					chkchargesList.Items.Add(chargeEntity.Charge.Name, true);
				}
				lblchecklist.Enabled = true;
			}else
				MessageService.ShowWarning("Can't find JO Number: " + txtsearch.Text, "Non-existing");
		}
		
		void BtnsearchClick(object sender, EventArgs e)
		{
			m_presenter.getHeaderEntityByJONumber(int.Parse(txtsearch.Text));
		}
		
		void txtsearch_keypress(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter){
				m_presenter.getHeaderEntityByJONumber(int.Parse(txtsearch.Text));
			}			
		}
		
		void cmbservices_selectedindexchange(object sender, EventArgs e)
		{
			LaundryServiceDataEntity service = m_presenter.getServiceByName(cmbservices.Text);
			List<LaundryPriceSchemeDataEntity> prices = m_presenter.getCategoriesByServiceID(service.ServiceID);
			this.cmbcategory.Items.Clear();
			foreach(LaundryPriceSchemeDataEntity price in prices){
				cmbcategory.Items.Add(m_presenter.getCategoryById(price.Category.CategoryID).Name);
			}
		}			
		
		void chkchargesList_ItemChecked(object sender, ItemCheckEventArgs e)
		{			
			decimal charge = 0M;
			if(e.NewValue == CheckState.Checked){
				charge = m_presenter.getAmtChargeByName(chkchargesList.Items[e.Index].ToString());
				txttotalcharges.Text = (decimal.Parse(txttotalcharges.Text) + charge).ToString("N2");
				txttotalamtdue.Text = (decimal.Parse(txttotalamtdue.Text) + charge).ToString("N2");
			}else{
				charge = m_presenter.getAmtChargeByName(chkchargesList.Items[e.Index].ToString());
				txttotalcharges.Text = (decimal.Parse(txttotalcharges.Text) - charge).ToString("N2");
				txttotalamtdue.Text = (decimal.Parse(txttotalamtdue.Text) - charge).ToString("N2");
			}			
		}
	}	
}


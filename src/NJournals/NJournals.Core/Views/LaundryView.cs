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
using NJournals.Common.LREventArgs;
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
		LaundryCustomerSearchView customerSearchView = null;
		LaundryChargesView chargesView = null;
		LaundryPriceSchemeDataEntity priceEntity = null;
		List<LaundryChargeDataEntity> m_charges = new List<LaundryChargeDataEntity>();
		private decimal removePrice = 0;
		private decimal amountTender = 0;		
		private decimal totalAmtDue = 0;
		private decimal totalPayment = 0;
		void setButtonImages()
		{
			Resource.setImage(this.btnsearch, System.IO.Directory.GetCurrentDirectory() + "/images/search.png");
			Resource.setImage(this.btnCustomerSearch, System.IO.Directory.GetCurrentDirectory() + "/images/search.png");
			Resource.setImage(this.btnDeleteDetail,System.IO.Directory.GetCurrentDirectory() + "/images/delete2.png");
			Resource.setImage(this.btnEditCharges, System.IO.Directory.GetCurrentDirectory() + "/images/edit2.png");
		}
		
		void LaundryNewViewLoad(object sender, EventArgs e)
		{
			setButtonImages();			
			Resource.formatAlternatingRows(dataGridView1);
			m_laundryDao = new LaundryDao();
			m_presenter = new LaundryViewPresenter(this, m_laundryDao);
			if(this.Text.Contains("[NEW]")){

				Resource.setIcon(this, System.IO.Directory.GetCurrentDirectory() + "/images/basket_new.ico");				
				m_headerEntity = new LaundryHeaderDataEntity();						
				m_presenter.SetAllCustomers();
				this.groupBox2.Enabled = this.btnclaim.Enabled = btndelete.Enabled = false;
				txtjoborder.Text = m_presenter.getHeaderID().ToString().PadLeft(6, '0');
				this.dtrecieveDate.Value = DateTime.Now;	
				this.dtdueDate.Value = DateTime.Now;				
				dataGridView1.AllowUserToDeleteRows = true;
			}else{	
				Resource.setIcon(this, System.IO.Directory.GetCurrentDirectory() + "/images/basket_claim.ico");				
				cmbCustomers.Enabled = false;
				grpServices.Enabled = false;
				lblchecklist.Enabled = false;
				//btncancel.Enabled = false;
				txtdiscount.Enabled = false;
				dataGridView1.AllowUserToDeleteRows = false;
				//btnprint.Enabled = true;
				
				btnDeleteDetail.Enabled = false;
				cmbCustomers.DropDownStyle = ComboBoxStyle.DropDown;
				EnableDisableControls(false);
				txtsearch.Focus();
			}
			m_presenter.SetAllServices();
			m_presenter.SetAllCharges();
			
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
			m_charges = charges;
			chkchargesList.Items.Clear();
			foreach(LaundryChargeDataEntity charge in charges){
				this.chkchargesList.Items.Add(charge.Name);
			}
		}
		
		void BtncancelClick(object sender, EventArgs e){			
			if(MessageService.ShowYesNo("Are you sure you want to cancel this transaction? Data in the fields will be remove.","Cancel Transaction")){
				ClearFields();
			}			   			   
		}		
		
		public LaundryHeaderDataEntity ProcessHeaderDataEntity(){				
			int totalItemQty = 0;
			int itemQty = 0;
			
			//TODO:calculate totalpayment;if claim then retrieve values from paymentdetail table else totalamtdue - balance
			//m_headerEntity.TotalPayment = decimal.Parse(this.txtamttender.Text);			                                            
			m_headerEntity.TotalAmountDue = decimal.Parse(txttotalamtdue.Text);
			
			m_headerEntity.ReceivedDate = dtrecieveDate.Value;
			m_headerEntity.DueDate = dtdueDate.Value;
					
			//m_headerEntity.ClaimFlag = btnclaim.Enabled;			
			m_headerEntity.Customer = m_presenter.getCustomerByName(cmbCustomers.Text);			
			m_headerEntity.DetailEntities = new List<LaundryDetailDataEntity>();
			foreach(DataGridViewRow row in this.dataGridView1.Rows){
				if(row.Cells[0].Value != null){
					if(!string.IsNullOrEmpty(row.Cells[0].Value.ToString())){
						LaundryDetailDataEntity detail = new LaundryDetailDataEntity();
						detail.Header = m_headerEntity;				
						detail.Category = m_presenter.getCategoryByName(row.Cells[1].Value.ToString());				
						detail.Service = m_presenter.getServiceByName(row.Cells[0].Value.ToString());
						detail.Kilo = double.Parse(row.Cells[2].Value.ToString());
						itemQty = int.Parse(row.Cells[3].Value.ToString());
						detail.ItemQty = itemQty;
						totalItemQty += itemQty;
						detail.Amount = decimal.Parse(row.Cells[4].Value.ToString());
						m_headerEntity.DetailEntities.Add(detail);
					}	
				}							
			}		
			m_headerEntity.TotalItemQty = totalItemQty;			
			m_headerEntity.TotalAmountDue = decimal.Parse(txttotalamtdue.Text);
			m_headerEntity.TotalCharge = decimal.Parse(txttotalcharges.Text);
			m_headerEntity.TotalDiscount = decimal.Parse(txttotaldiscount.Text);			
			m_headerEntity.AmountDue = decimal.Parse(txtamtdue.Text);
			
			LaundryPaymentDetailDataEntity paymentdetail = new LaundryPaymentDetailDataEntity();
			
			if(decimal.Parse(txtamttender.Text) > 0){	
				if(decimal.Parse(txtamttender.Text) >=  (decimal.Parse(txttotalamtdue.Text) - m_headerEntity.TotalPayment)){
					paymentdetail.Amount = decimal.Parse(txttotalamtdue.Text) - m_headerEntity.TotalPayment;
				}else{
					//paymentdetail.Amount = m_headerEntity.TotalAmountDue - decimal.Parse(txtbalance.Text);
					paymentdetail.Amount = decimal.Parse(txtamttender.Text);
				}	
			}else
				paymentdetail.Amount = 0;
				
			
			if(this.Text.Contains("NEW"))
				m_headerEntity.TotalPayment = paymentdetail.Amount;					
			else
				m_headerEntity.TotalPayment += paymentdetail.Amount;		
			
			paymentdetail.PaymentDate = Convert.ToDateTime(DateTime.Now);
			paymentdetail.Header = m_headerEntity;
			paymentdetail = paymentdetail.Amount > 0 ? paymentdetail : null;
			m_headerEntity.PaymentDetailEntities.Add(paymentdetail);
			m_headerEntity.JobChargeEntities = new List<LaundryJobChargesDataEntity>();
			foreach(object checkedItem in this.chkchargesList.CheckedItems){
				m_jobcharge = new LaundryJobChargesDataEntity();
				m_jobcharge.Charge = m_presenter.getJobChargeByName(checkedItem.ToString());
				m_jobcharge.Header = m_headerEntity;				
				m_headerEntity.JobChargeEntities.Add(m_jobcharge);
			}
			
			m_headerEntity.PaidFlag = (decimal.Parse(txtbalance.Text) == 0) ? true : false;			
				
			return m_headerEntity;
		}				
		
		public void AddItem(){
			
			decimal kilo = decimal.Parse(txtkilo.Text);			
			decimal price = priceEntity.Price * kilo;	
			bool alreadyExist = false;
			for(int i=0;i<dataGridView1.Rows.Count;i++){
				if(dataGridView1.Rows[i].Cells[0].Value != null){
					if(dataGridView1.Rows[i].Cells[1].Value.ToString().Equals(cmbcategory.Text) &&
					   dataGridView1.Rows[i].Cells[0].Value.ToString().Equals(cmbservices.Text)){
						dataGridView1.Rows[i].Cells[2].Value = (int.Parse(txtnoitems.Text) + int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString())).ToString();
						dataGridView1.Rows[i].Cells[3].Value = (int.Parse(txtkilo.Text) + int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString())).ToString();
						dataGridView1.Rows[i].Cells[4].Value = (decimal.Parse((dataGridView1.Rows[i].Cells[4].Value.ToString())) + price).ToString("N2");
						alreadyExist = true;
						break;
					}
				}
			}
			
			if(!alreadyExist)
				dataGridView1.Rows.Add(cmbservices.Text, cmbcategory.Text, txtnoitems.Text, txtkilo.Text, price.ToString("N2"));
			this.totalAmtDue = decimal.Parse(txtamtdue.Text) + price;
			txtamtdue.Text = totalAmtDue.ToString("N2");			
			this.txttotalamtdue.Text = (decimal.Parse(txttotalamtdue.Text) + price).ToString("N2");
			this.txtbalance.Text = this.txttotalamtdue.Text;	
			dataGridView1.CurrentRow.Selected = false;
			dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count-1].Cells[0];
		}		
		
		void BtnaddClick(object sender, EventArgs e)
		{
			foreach(Control c in grpServices.Controls){
				if(c.Text.Trim().Equals(string.Empty)){
					MessageService.ShowWarning("Please input a value in empty field.","Empty Field");
					c.Focus();
					return;
				}
			}
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
					if(char.IsLetter(e.KeyChar))
						e.Handled = true;
					else
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
			if(amountTender < (totalAmtDue - totalPayment)){
				txtbalance.Text = (totalAmtDue - totalPayment - amountTender).ToString("N2");
				txtchange.Text = "0.00";
			}else{
				txtchange.Text = (amountTender - (totalAmtDue - totalPayment)).ToString("N2");
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
			txttotalamtdue.Text = txttotalamtdue.Text = (decimal.Parse(txtamtdue.Text) + decimal.Parse(txttotalcharges.Text)).ToString("N2");
			if(txtdiscount.Text.Length == 0 || txtdiscount.Text.Equals("0")){
				txttotaldiscount.Text = "0";					
			}else{
				decimal discount = decimal.Parse(txtdiscount.Text) / 100M;
				txttotaldiscount.Text = (decimal.Parse(txttotalamtdue.Text) * discount).ToString("N2");
				txttotalamtdue.Text = (decimal.Parse(txttotalamtdue.Text) - decimal.Parse(txttotaldiscount.Text)).ToString("N2");		
			}
			//TODO: accurate calculation for balance when amttender > 0
			txtbalance.Text = (decimal.Parse(txttotalamtdue.Text) - decimal.Parse(txtamttender.Text)).ToString("N2");
		}
		
		void BtnsavecloseClick(object sender, EventArgs e)
		{
			if(CheckForEmptyFields())
				return;
			
			if(MessageService.ShowYesNo("Are you sure you want to save this transaction with JO number: " + txtjoborder.Text + "?", "Saving New Entries?")){
				m_presenter.SaveClicked();			        
				this.Close();
			}			
		}
		
		void lblchecklist_click(object sender, EventArgs e)
		{
			m_presenter.LaunchChecklist();
		}
		
		bool CheckForEmptyFields(){
			if(cmbCustomers.Text.Trim().Equals(string.Empty)){
				MessageService.ShowWarning("No customer being selected. Please select a customer.","Empty Field");				
				cmbCustomers.Focus();
				return true;
			}
			if(dataGridView1.Rows.Count == 0){
				MessageService.ShowWarning("No list to save. Please add an item before saving.","Empty Field");				
				return true;
			}
			return false;
		}
		
		public void LaunchChecklist(){			
			chklistView = new CheckListView(m_headerEntity, int.Parse(txtjoborder.Text));
			chklistView.SelectChecklist += new EventHandler<ChecklistEventArgs>(OnCheckListChange);
			chklistView.ShowDialog();		
			chklistView.SelectChecklist -= new EventHandler<ChecklistEventArgs>(OnCheckListChange);
			
		}
		
		public void OnCheckListChange(object sender, ChecklistEventArgs e){
			m_headerEntity.JobChecklistEntities = new List<LaundryJobChecklistDataEntity>();
			foreach(string checklist in e.Checklist){
				string[] arrchecklist = checklist.Split('|');
				LaundryJobChecklistDataEntity newChecklist = new LaundryJobChecklistDataEntity();
				newChecklist.Header = m_headerEntity;
				newChecklist.Checklist = m_presenter.GetChecklistByName(arrchecklist[0]);
				newChecklist.Qty = int.Parse(arrchecklist[1]);				
				m_headerEntity.JobChecklistEntities.Add(newChecklist);
			}			
		}
		
		public void LoadHeaderEntityData(LaundryHeaderDataEntity p_headerEntity){
			this.m_headerEntity = p_headerEntity;
			if(this.m_headerEntity != null){
				btnsaveclose.Enabled = true;
				btnclaim.Enabled = true;
				chkchargesList.Enabled = true;
				
				txtjoborder.Text = m_headerEntity.LaundryHeaderID.ToString().PadLeft(6, '0');
				cmbCustomers.Text = m_headerEntity.Customer.Name;
				dtrecieveDate.Value = m_headerEntity.ReceivedDate;
				dtdueDate.Value = m_headerEntity.DueDate;
				foreach(LaundryDetailDataEntity detailEntity in m_headerEntity.DetailEntities){
					dataGridView1.Rows.Add(detailEntity.Service.Name, detailEntity.Category.Name,  detailEntity.Kilo.ToString(), detailEntity.ItemQty.ToString(), detailEntity.Amount.ToString("N2"));
				}				
				//chkpaywhenclaim.Enabled = m_headerEntity.PaidFlag;										
				for(int i=0;i<chkchargesList.Items.Count;i++){
					foreach(LaundryJobChargesDataEntity chargeEntity in m_headerEntity.JobChargeEntities){
						if(chkchargesList.Items[i].ToString().Equals(chargeEntity.Charge.Name)){
							chkchargesList.SetItemChecked(i, true);
						}
					}					
				}
				// load amount details				
				txtamtdue.Text = m_headerEntity.AmountDue.ToString("N2");
				txttotalamtdue.Text = m_headerEntity.TotalAmountDue.ToString("N2");				
				txttotaldiscount.Text = m_headerEntity.TotalDiscount.ToString("0");				
				txtdiscount.Text = ((m_headerEntity.TotalDiscount / (m_headerEntity.AmountDue + m_headerEntity.TotalCharge)) * 100).ToString("0");
				totalPayment = m_headerEntity.TotalPayment;
				txtbalance.Text = (m_headerEntity.TotalAmountDue - m_headerEntity.TotalPayment).ToString("N2");			
				lblchecklist.Enabled = true;	
				
				if(m_headerEntity.ClaimFlag){
					lblvoid.Visible = true;
					lblvoid.Text = "CLAIMED TRANSACTION";
					lblvoid.ForeColor = Color.Green;
					EnableDisableControls(false);
				}else{
					EnableDisableControls(true);					
				}
				
				if(m_headerEntity.VoidFlag){
					lblvoid.Visible = true;
					lblvoid.Text = "VOIDED TRANSACTION";
					lblvoid.ForeColor = Color.Red;
					//btndelete.Enabled = false;
					EnableDisableControls(false);
				}else if(!m_headerEntity.ClaimFlag){
					lblvoid.Visible = false;
					//btndelete.Enabled = true;
					//EnableDisableControls(true);
				}								
			}else
				MessageService.ShowWarning("Can't find JO Number: " + txtsearch.Text, "Non-existing");
		}
		
		private void EnableDisableControls(bool enabled){
			btnsaveclose.Enabled = enabled;
			btnclaim.Enabled = enabled;
			chkchargesList.Enabled = enabled;			
			txtamttender.Enabled = enabled;
			btndelete.Enabled = enabled;
			btnprint.Enabled = enabled;
			btncancel.Enabled = enabled;
		}
		
		void BtnsearchClick(object sender, EventArgs e)
		{
			ClearFields();
			int id = 0;
			int.TryParse(txtsearch.Text, out id);
			m_presenter.getHeaderEntityByJONumber(id);
		}
			
		private void ClearFields(){
			// clear data first
			this.dataGridView1.Rows.Clear();
			this.cmbcategory.Text = 
				cmbservices.Text = 
				cmbCustomers.Text = string.Empty;			
			for(int i=0;i<chkchargesList.Items.Count;i++)
				chkchargesList.SetItemCheckState(i, CheckState.Unchecked);
			txttotalamtdue.Text = 					
				txtamtdue.Text = 
				txtbalance.Text = 
				txtchange.Text =
				txtamttender.Text = 
				txttotaldiscount.Text = "0.00";
			txtdiscount.Text = "0";
			txtnoitems.Text = string.Empty;
			txtkilo.Text = string.Empty;	
		}
		
		void txtsearch_keypress(object sender, KeyEventArgs e)
		{			
			if(e.KeyCode == Keys.Enter){
				int id = 0;
				int.TryParse(txtsearch.Text, out id);
				ClearFields();
				m_presenter.getHeaderEntityByJONumber(id);
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
			CalculateCharges(e);
		}
		
		void CalculateCharges(ItemCheckEventArgs e){
			decimal charge = 0M;
			charge = m_charges.Find(x => x.Name.Equals(chkchargesList.Items[e.Index].ToString())).Amount;
			//charge = m_presenter.getAmtChargeByName(chkchargesList.Items[e.Index].ToString());
			if(e.NewValue == CheckState.Checked){				
				txttotalcharges.Text = (decimal.Parse(txttotalcharges.Text) + charge).ToString("N2");
				txttotalamtdue.Text = (decimal.Parse(txttotalamtdue.Text) + charge).ToString("N2");
			}else{				
				txttotalcharges.Text = (decimal.Parse(txttotalcharges.Text) - charge).ToString("N2");
				txttotalamtdue.Text = (decimal.Parse(txttotalamtdue.Text) - charge).ToString("N2");
			}			
			txtbalance.Text = (decimal.Parse(txttotalamtdue.Text) - totalPayment).ToString("N2");
			decimal discount = decimal.Parse(txtdiscount.Text) / 100M;
			txttotaldiscount.Text = (decimal.Parse(txttotalamtdue.Text) * discount).ToString("N2");
		}
					
		void BtnCustomerSearchClick(object sender, EventArgs e)
		{
			m_presenter.LaunchCustomerSearch();
		}
		
		public void LaunchCustomerSearch()
		{			
			customerSearchView = new LaundryCustomerSearchView(m_presenter.getCustomerByName(cmbCustomers.Text));			
			customerSearchView.ShowDialog();				
		}
		
		void dgv_rowsremoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{			
			decimal amtdue = decimal.Parse(txtamtdue.Text);
			decimal totaldue = decimal.Parse(txttotalamtdue.Text);
			
			amtdue -= removePrice;
			txtamtdue.Text = amtdue.ToString("N2");
			totaldue -= removePrice;
			txttotalamtdue.Text = totaldue.ToString("N2");
			txtbalance.Text = (totaldue - decimal.Parse(txtamttender.Text)).ToString("N2");
		}		
		
		void dgv_selectionchanged(object sender, EventArgs e)
		{
			if(dataGridView1.SelectedRows.Count > 0 )
				removePrice = decimal.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
		}		
		
		void BtndeleteClick(object sender, EventArgs e)
		{
			if(m_headerEntity == null){
				MessageService.ShowWarning("No transaction to delete!");
				return;
			}
			if(MessageService.ShowYesNo("Are you sure you want to void this transaction: " + txtjoborder.Text + "?")){
				m_presenter.VoidingTransaction();	
			}			
		}
		
		void BtnclaimClick(object sender, EventArgs e)
		{
			m_presenter.ClaimTransaction();
		}
		
		public bool ClaimTransaction(){
			
			if(decimal.Parse(txtbalance.Text) <= 0.00M){
				MessageService.ShowInfo("Claiming transaction with JO number: " + txtjoborder.Text , "Claim");				
				return true;				
			}
			else{
				MessageService.ShowWarning("Unable to claim transaction with JO number: " + txtjoborder.Text + ".\n" +
				                           "Please make sure transaction is fully paid to claim transaction.","Claim");	
				return false;				
			}
			
		}
		
		public void VoidingTransaction(){
			this.Close();
		}
		
		public override void CloseView(){
			this.Close();
		}
		
		void BtnprintClick(object sender, EventArgs e)
		{
			if(CheckForEmptyFields())
				return;
			if(MessageService.ShowYesNo("Are you sure you want to print this transaction with JO number: " + txtjoborder.Text + "?")){
				m_presenter.PrintTransaction();
				this.Close();
			}			
		}
		
		void BtnDeleteDetailClick(object sender, EventArgs e)
		{
			if(dataGridView1.SelectedRows.Count > 0 && this.Text.Contains("NEW")){
				dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
			}
		}
		
		void BtnEditChargesClick(object sender, EventArgs e)
		{
			m_presenter.LaunchCharges();
		}
		
		public void LaunchCharges(){
			chargesView = new LaundryChargesView();
			chargesView.SelectChargelist += new EventHandler<ChargeListEventArgs>(OnChargeListChange);
			chargesView.ShowDialog();
			chargesView.SelectChargelist -= new EventHandler<ChargeListEventArgs>(OnChargeListChange);			
		}
		
		private void OnChargeListChange(object sender, ChargeListEventArgs e){
			
			foreach(LaundryChargeDataEntity charge in e.Charges){
				bool newEntry = true;
				for(int i=0; i < chkchargesList.Items.Count; i++){
					if(chkchargesList.GetItemChecked(i) && string.Equals(chkchargesList.Items[i].ToString(), charge.Name, StringComparison.OrdinalIgnoreCase)){
						//TODO: calculate 								
						CalculateCharges(new ItemCheckEventArgs(i, CheckState.Unchecked, CheckState.Checked));
						newEntry = false;
						int index = m_charges.FindIndex(x => x.Name.Equals(charge.Name));
						m_charges[index].Amount = charge.Amount;
						CalculateCharges(new ItemCheckEventArgs(i, CheckState.Checked, CheckState.Unchecked));
					}
					if(string.Equals(chkchargesList.Items[i].ToString(), charge.Name, StringComparison.OrdinalIgnoreCase)){
						newEntry = false;
					}
				}
				if(newEntry){
					chkchargesList.Items.Add(charge.Name);
					m_charges.Add(charge);
				}					
			}
		}
		
		void cmbcategory_selectedindexchanged(object sender, EventArgs e)
		{
			priceEntity = m_presenter.getLaundryPrice(cmbcategory.Text,cmbservices.Text);
			txtunitprice.Text = priceEntity.Price.ToString("N2");
			txtnoitems.Focus();
		}
		
		void BtnRefreshClick(object sender, EventArgs e)
		{
			m_presenter.SetAllCharges();
		}
	}	
}


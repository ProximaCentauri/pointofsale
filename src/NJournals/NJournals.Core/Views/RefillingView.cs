﻿/*
 * Created by SharpDevelop.
 * User: vo185003
 * Date: 1/25/2013
 * Time: 9:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using NJournals.Common.Gui;
using NJournals.Common.Interfaces;
using System.Collections.Generic;
using NJournals.Core.Models;
using NJournals.Common.DataEntities;
using NJournals.Core.Presenter;
using NJournals.Common.Util;
namespace NJournals.Core.Views
{
	/// <summary>
	/// Description of RefillingView.
	/// </summary>
	public partial class RefillingView : BaseForm, IRefillingView
	{
		public RefillingView()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			m_refillDao = new RefillDao();
			m_presenter = new RefillingViewPresenter(this, m_refillDao);
		}
		
		private IRefillDao m_refillDao;
		private RefillingViewPresenter m_presenter;
		private decimal removePrice = 0;
		private decimal unitprice = 0;
		private RefillHeaderDataEntity m_headerEntity = null;
		void RefillingViewLoad(object sender, EventArgs e)
		{
			setButtonImages();		
			Resource.formatAlternatingRows(dataGridView1);
			if(this.Text.Contains("[NEW]")){
				Resource.setIcon(this, System.IO.Directory.GetCurrentDirectory() + "/images/bottle_new.ico");
				m_presenter.SetAllCustomers();
				m_presenter.SetAllProducts();
				m_presenter.SetAllTransactionTypes();
				txtjonumber.Text = m_presenter.getHeaderID().ToString().PadLeft(6, '0');
				this.dtDate.Value = DateTime.Now;
			}else{
				Resource.setIcon(this, System.IO.Directory.GetCurrentDirectory() + "/images/bottle_return.ico");
				foreach(Control c in this.Controls){
					if(c is GroupBox){
						GroupBox groupBox = c as GroupBox;
						groupBox.Enabled = false;
					}					
				}
				groupBox2.Enabled = true;
				btnprintclose.Enabled = btnsave.Enabled = btncancel.Enabled = chkunpaid.Enabled = false;
				btndeleteclose.Enabled = true;
				cmbCustomers.DropDownStyle = ComboBoxStyle.DropDown;
				cmbtransTypes.DropDownStyle = ComboBoxStyle.DropDown;
				btnprintclose.Enabled = true;
				dataGridView1.AllowUserToDeleteRows = false;
			}
		}
		
		public void SetAllCustomers(List<CustomerDataEntity> customers){
			foreach(CustomerDataEntity customer in customers){
				this.cmbCustomers.Items.Add(customer.Name);
			}
		}
		
		public void SetAllTransactionTypes(List<RefillTransactionTypeDataEntity> transTypes){
			foreach(RefillTransactionTypeDataEntity transType in transTypes){
				this.cmbtransTypes.Items.Add(transType.Name);
			}
		}
		
		public void SetAllProducts(List<RefillProductTypeDataEntity> products){
			foreach(RefillProductTypeDataEntity product in products){
				this.cmbproducts.Items.Add(product.Name);
			}
		}		
		
		void BtnaddClick(object sender, EventArgs e)
		{			
			foreach(Control c in grpServices.Controls){
				if(c.Enabled){
					if(c.Text.Trim().Equals(string.Empty)){
						MessageService.ShowWarning("Please input a value in empty field.","Empty Field");
						c.Focus();
						return;
					}else if(c.Name.Equals("txtnoitems") ||
					         c.Name.Equals("txtbottles") ||
					         c.Name.Equals("txtcaps")){
						int i = 0;
						int.TryParse(c.Text, out i);
						foreach(char val in c.Text.ToCharArray()){
							if((i == 0 || i < 0) && (!char.IsNumber(val) || !char.IsDigit(val))){
								MessageService.ShowWarning("Invalid data in input field. " + c.Text,"Invalid data");
								c.Focus();
								return;
							}
						}						
					}
				}				
			}
			m_presenter.AddNewItemClicked();	
		}
		
		public void AddItem(){
			
			decimal totalPrice = decimal.Parse(txtnoitems.Text) * unitprice;
			bool alreadyExist = false;
			string nobottles = txtbottles.Text.Trim().Equals(string.Empty) ? "0" : txtbottles.Text;
			string nocaps = txtcaps.Text.Trim().Equals(string.Empty) ? "0" : txtcaps.Text;
			for(int i=0;i<dataGridView1.Rows.Count;i++){
				if(dataGridView1.Rows[i].Cells[0].Value != null){
					if(dataGridView1.Rows[i].Cells[0].Value.ToString().Equals(cmbproducts.Text)){
						dataGridView1.Rows[i].Cells[1].Value = (int.Parse(nobottles) + int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString())).ToString();
						dataGridView1.Rows[i].Cells[2].Value = (int.Parse(nocaps) + int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString())).ToString();
						dataGridView1.Rows[i].Cells[3].Value = (int.Parse(txtnoitems.Text) + int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString())).ToString();
						dataGridView1.Rows[i].Cells[4].Value = (decimal.Parse((dataGridView1.Rows[i].Cells[4].Value.ToString())) + totalPrice).ToString("N2");
						alreadyExist = true;
					}
				}
			}				
			if(!alreadyExist)
				dataGridView1.Rows.Add(cmbproducts.Text, nobottles, nocaps, txtnoitems.Text, totalPrice.ToString("N2"));
			this.txtamtdue.Text = (decimal.Parse(txtamtdue.Text) + totalPrice).ToString("N2");
			txtbalance.Text = txtamtdue.Text;
			
			dataGridView1.CurrentRow.Selected = false;
			dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count-1].Cells[0];
		}
		
		void BtnprintcloseClick(object sender, EventArgs e)
		{
			if(CheckForEmptyFields())
				return;
			
			if(MessageService.ShowYesNo("Are you sure you want to print this transaction with JO number: " + txtjonumber.Text + "?")){
			   	m_presenter.PrintTransaction();		
			   	this.Close();
			}			
		}
		
		private bool CheckForEmptyFields(){
			if(cmbCustomers.Text.Trim().Equals(string.Empty)){
				cmbCustomers.Focus();
				MessageService.ShowWarning("No customer being selected. Please select a customer.","Empty Field");				
				return true;
			}
			if(dataGridView1.Rows.Count == 0){
				MessageService.ShowWarning("No list to save. Please add an item before saving.","Empty Field");				
				return true;
			}
			if(cmbtransTypes.Text.Trim().Equals(string.Empty)){
				MessageService.ShowWarning("No transaction type being selected. Please select a type of transaction.","Empty Field");
				cmbtransTypes.Focus();
				return true;
			}
			return false;
		}
		
		public RefillHeaderDataEntity ProcessHeaderDataEntity(){
			int totalQty = 0;
			RefillHeaderDataEntity m_headerEntity = new RefillHeaderDataEntity();
			m_headerEntity.Date = dtDate.Value;
			m_headerEntity.Customer = m_presenter.getCustomerByName(cmbCustomers.Text);
			m_headerEntity.TransactionType = m_presenter.getTransactionTypeByName(cmbtransTypes.Text);
			m_headerEntity.AmountDue = decimal.Parse(txtamtdue.Text);
			//m_headerEntity.AmountTender = decimal.Parse(txtamttender.Text);
			List<RefillDetailDataEntity> refillDetails = new List<RefillDetailDataEntity>();
			foreach(DataGridViewRow row in this.dataGridView1.Rows){
				if(row.Cells[0].Value != null){
					if(!string.IsNullOrEmpty(row.Cells[0].Value.ToString())){
						RefillDetailDataEntity detail = new RefillDetailDataEntity();
						detail.Header = m_headerEntity;
						detail.ProductType = m_presenter.getProductByName(row.Cells[0].Value.ToString());
						detail.StoreBottleQty = int.Parse(row.Cells[1].Value.ToString());
						detail.StoreCapQty = int.Parse(row.Cells[2].Value.ToString());
						detail.Qty = int.Parse(row.Cells[3].Value.ToString());
						totalQty += detail.Qty;
						detail.Amount = decimal.Parse(row.Cells[4].Value.ToString());
						refillDetails.Add(detail);							
					}
				}
			}
			m_headerEntity.DetailEntities = refillDetails;
			m_headerEntity.PaidFlag = chkunpaid.Checked;
			RefillPaymentDetailDataEntity paymentDetail = new RefillPaymentDetailDataEntity();
			m_headerEntity.PaidFlag = false;
			
			if(decimal.Parse(txtamttender.Text) > 0){
				if(decimal.Parse(txtamttender.Text) >= m_headerEntity.AmountDue){
					paymentDetail.Amount = m_headerEntity.AmountDue;
					m_headerEntity.PaidFlag = true;
				}else{
					paymentDetail.Amount = decimal.Parse(txtamttender.Text);
				}
			}else
				paymentDetail.Amount = 0M;
			
			m_headerEntity.AmountTender = paymentDetail.Amount;		
			m_headerEntity.TotalQty = totalQty;
			paymentDetail.PaymentDate = Convert.ToDateTime(DateTime.Now);		
			paymentDetail.Header = m_headerEntity;
			paymentDetail = paymentDetail.Amount > 0 ? paymentDetail : null;
			m_headerEntity.PaymentDetailEntities.Add(paymentDetail);
			
			return m_headerEntity;
		}
		
		public void LoadHeaderEntityData(RefillHeaderDataEntity p_headerEntity){
			m_headerEntity = p_headerEntity;
			txtjonumber.Text = m_headerEntity.RefillHeaderID.ToString().PadLeft(6, '0');
			cmbCustomers.Text = m_headerEntity.Customer.Name;
			cmbtransTypes.Text = m_headerEntity.TransactionType.Name;
			dataGridView1.Rows.Clear();
			dtDate.Value = m_headerEntity.Date;
			foreach(RefillDetailDataEntity detail in m_headerEntity.DetailEntities){
				dataGridView1.Rows.Add(detail.ProductType.Name, detail.StoreBottleQty.ToString(), detail.StoreCapQty.ToString(), detail.Qty.ToString(), detail.Amount.ToString("N2"));
			}
			txtamtdue.Text = m_headerEntity.AmountDue.ToString("N2");
			txtbalance.Text = (m_headerEntity.AmountDue - m_headerEntity.AmountTender).ToString("N2");
			chkunpaid.Checked = decimal.Parse(txtbalance.Text) == 0 ? false : true;
			lblvoid.Visible = m_headerEntity.VoidFlag;
			if(m_headerEntity.VoidFlag){
				btndeleteclose.Enabled = false;				
			}else{
				btndeleteclose.Enabled = true;				
			}
		}
		
		void BtndeletecloseClick(object sender, EventArgs e)
		{
			if(m_headerEntity == null){
				MessageService.ShowWarning("No transaction to delete!");
				return;
			}
			if(MessageService.ShowYesNo("Are you sure you want to void this transaction: " + txtjonumber.Text + "?" + Environment.NewLine +
			                            "Please note that voiding this transaction will revert back items being released to your inventory." + Environment.NewLine + 
			                            "If you know what you're doing, then proceed by clicking option below.","Voiding Transaction?")){
				m_presenter.VoidTransaction();
				this.Close();
			}		
		}
		
		
		void txtsearch_keydown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter){
				int id = 0;
				int.TryParse(txtsearch.Text, out id);
				if(m_presenter.getHeaderByJoNumber(id) != null){
					m_presenter.loadHeaderEntity();
				}else{
					MessageService.ShowWarning("Can't find JO number: " + txtsearch.Text);
				}
			}	
		}
		
		void BtnsearchClick(object sender, EventArgs e)
		{
			int id = 0;
			int.TryParse(txtsearch.Text, out id);
			if(m_presenter.getHeaderByJoNumber(id) != null){
				m_presenter.loadHeaderEntity();
			}else{
				MessageService.ShowWarning("Can't find JO number: " + txtsearch.Text);
			}
		}
		
		void BtncancelClick(object sender, EventArgs e)
		{
			if(MessageService.ShowYesNo("Are you sure you want to cancel this transaction? Data in the fields will be remove.","Cancel Transaction")){
				this.dataGridView1.Rows.Clear();
				txtamtdue.Text = txtamttender.Text = txtbalance.Text = 
					txtchange.Text = "0.00";
				cmbproducts.Text = cmbCustomers.Text = cmbtransTypes.Text = string.Empty;
				txtbottles.Text = txtcaps.Text = txtnoitems.Text = "0";
			}
		}
		
		void cmbproducts_selectedindexchange(object sender, EventArgs e)
		{
			if(!cmbproducts.Text.StartsWith("5 Gal", true, null)){
				txtbottles.Enabled = false;
				txtcaps.Enabled = false;				
			}else{				
				txtbottles.Enabled = true;
				txtcaps.Enabled = true;			
			}			
			txtcaps.Text = "0";
			txtbottles.Text = "0";
			unitprice = m_presenter.getAmtChargeByName(cmbproducts.Text);
			txtunitprice.Text = unitprice.ToString("N2");
			txtnoitems.Focus();
		}
		
		void chkunpaid_click(object sender, EventArgs e)
		{
			if(chkunpaid.Checked){
				txtamttender.Text = "0.00";
				txtamttender.Enabled = false;
			}else{
				txtamttender.Enabled = true;
				txtamttender.Focus();
			}
		}
		
		void txtamttender_textchanged(object sender, EventArgs e)
		{			
			if(txtamttender.Text.Length == 0){
				txtamttender.Text = "0.00";				
			}	
			decimal amountTender = decimal.Parse(txtamttender.Text);
			decimal amtdue = decimal.Parse(txtamtdue.Text);				
			if(amountTender < amtdue){
				txtbalance.Text = (amtdue - amountTender).ToString("N2");
				txtchange.Text = "0.00";
			}else{
				txtchange.Text = (amountTender - amtdue).ToString("N2");
				txtbalance.Text = "0.00";
			}		
		}
		
		void BtnsaveClick(object sender, EventArgs e)
		{
			if(CheckForEmptyFields())
				return;
			
			if(MessageService.ShowYesNo("Are you sure you want to save this transaction with JO number: " + txtjonumber.Text + "?", "Save?")){
				m_presenter.SaveClicked();			
				this.Close();
			}		
		}
		
		void txtbox_keypress(object sender, KeyPressEventArgs e)
		{
			if(sender is TextBox){
				TextBox txt = sender as TextBox;
				if(!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) 
				   && (e.KeyChar != (char)Keys.Decimal) && (e.KeyChar != (char)Keys.OemPeriod) && !char.IsNumber(e.KeyChar)){
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
		
		void setButtonImages()
		{			
			Resource.setImage(this.btnsearch, System.IO.Directory.GetCurrentDirectory() + "/images/search.png");
			Resource.setImage(this.btnDeleteDetail, System.IO.Directory.GetCurrentDirectory() + "/images/delete2.png");
		}

		
		void BtnDeleteDetailClick(object sender, EventArgs e)
		{
			if(dataGridView1.SelectedRows.Count > 0 && this.Text.Contains("NEW")){
				dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
			}
		}
		
		void dgv_rowsremoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{			
			decimal amtdue = decimal.Parse(txtamtdue.Text);
			amtdue -= removePrice;
			txtamtdue.Text = amtdue.ToString("N2");
			txtbalance.Text = (amtdue - decimal.Parse(txtamttender.Text)).ToString("N2");
		}		
		
		void dgv_selectionchanged(object sender, EventArgs e)
		{
			if(dataGridView1.SelectedRows.Count > 0 )
				removePrice = decimal.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
		}		
	}
}

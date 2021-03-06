﻿/*
 * Created by SharpDevelop.
 * User: user
 * Date: 2/12/2013
 * Time: 8:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using NJournals.Common.Util;
using NJournals.Common.Gui;
using NJournals.Common.Interfaces;
using NJournals.Common.DataEntities;
using NJournals.Core.Presenter;
using System.Collections.Generic;

namespace NJournals.Core.Views
{
	/// <summary>
	/// Description of RefillReturnPaymentView.
	/// </summary>
	public partial class RefillReturnPaymentView : BaseForm , IRefillReturnPaymentView
	{
		RefillingReturnPaymentPresenter m_presenter;
		List<CustomerDataEntity> m_customerEntity;
		List<RefillHeaderDataEntity> refillHeaders;
		private decimal totalAmountDue = 0.00M;
		private int capsOnHand = 0;
		private int bottlesOnHand =0;
		
		public RefillReturnPaymentView()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Resource.setIcon(this, System.IO.Directory.GetCurrentDirectory() + "/images/user1.ico");
		}
		
		void RefillReturnPaymentViewLoad(object sender, EventArgs e)
		{
			setButtonImages();
			Resource.formatAlternatingRows(dgvOutBalance);
			m_presenter = new RefillingReturnPaymentPresenter(this);
			refillHeaders = null;
			m_customerEntity = null;
			m_presenter.SetAllCustomers();
			totalAmountDue = 0.00M;			
			dtDate.Value = DateTime.Now;
			btnSave.Enabled = false;
			btncancel.Enabled = false;			
		}
		
		void setButtonImages()
		{			
			Resource.setImage(this.btnCustomerSearch, System.IO.Directory.GetCurrentDirectory() + "/images/search.png");
		}
		
		public void SetAllCustomers(List<CustomerDataEntity> customers)
		{
			m_customerEntity = customers;        	
        	foreach(CustomerDataEntity customer in customers){
        		this.cmbCustomers.Items.Add(customer.Name);
        	}        	
		}
		
		void BtnCustomerSearchClick(object sender, EventArgs e)
		{           
			if(ValidateCustomerInput())
			{
				ClearFields();
				this.refillHeaders = null;
                txtReturnedBottles.Enabled = false;
                txtReturnedCaps.Enabled = false;
				m_presenter.GetRefillJOsByCustomer(this.cmbCustomers.SelectedItem.ToString());							
				btnSave.Enabled = true;		
				btncancel.Enabled = true;
			}
			else
			{
				MessageService.ShowWarning("No customer selected. Please select a customer.");
				btnSave.Enabled = false;
				btncancel.Enabled = false;
			}
		}
		
		public void LoadRefillHeaderAndInventoryData(List<RefillHeaderDataEntity> m_headers, 
		                                      RefillCustInventoryHeaderDataEntity custInv)
		{			
			this.txtamttender.Enabled = true;
			txtBottlesOnHand.Text = (custInv != null) ? custInv.BottlesOnHand.ToString() : "0";
			txtCapsOnHand.Text = (custInv != null) ? custInv.CapsOnHand.ToString() : "0";
			
			bottlesOnHand = Int32.Parse(txtBottlesOnHand.Text);
			capsOnHand = Int32.Parse(txtCapsOnHand.Text);
			
			txtReturnedBottles.Enabled = (txtBottlesOnHand.Text != "0") ? true : false;
			txtReturnedCaps.Enabled = (txtCapsOnHand.Text != "0") ? true : false;
		
			this.refillHeaders = m_headers;		
			totalAmountDue = 0.00M;
			foreach(RefillHeaderDataEntity header in this.refillHeaders)
			{				
				dgvOutBalance.Rows.Add(header.Date.ToShortDateString(), header.RefillHeaderID, header.TotalQty, 
				                       header.AmountDue.ToString("N2"), header.AmountTender.ToString("N2"),
				                       (header.AmountDue - header.AmountTender).ToString("N2"));
				totalAmountDue += (header.AmountDue - header.AmountTender);				                      
			}
			txtTotalAmtDue.Text = totalAmountDue.ToString("N2");
			txtbalance.Text = totalAmountDue.ToString("N2");		
		}
			

		void TxtamttenderTextChanged(object sender, EventArgs e)
		{
			if(txtamttender.Text.Length == 0){
				txtamttender.Text = "0.00";				
			}
			decimal amountTender = decimal.Parse(txtamttender.Text);
			decimal totalAmtDue = decimal.Parse(txtTotalAmtDue.Text);				
			if(amountTender < totalAmtDue){
				txtbalance.Text = (totalAmtDue - amountTender).ToString("N2");
				txtchange.Text = "0.00";
			}else{
				txtchange.Text = (amountTender - totalAmtDue).ToString("N2");	
				txtbalance.Text = "0.00";
			}
		}		
				
		void BtnSaveClick(object sender, EventArgs e)
		{		
			if(this.ValidateCustomerInput())
			{		
							
				int returnedBottles = (txtReturnedBottles.Text != string.Empty) ? Convert.ToInt32(txtReturnedBottles.Text) : 0;
				int returnedCaps = (txtReturnedCaps.Text != string.Empty) ? Convert.ToInt32(txtReturnedCaps.Text) : 0;
				DateTime daystamp = dtDate.Value;
				decimal amountTender = Convert.ToDecimal(txtamttender.Text);
				
				if(returnedBottles > 0 || returnedCaps > 0 || amountTender > 0)
				{
					if(MessageService.ShowYesNo("Are you sure you want to save changes?", "Saving Return/Payment?"))
					{																			
						try
						{							
							if(returnedBottles > 0 || returnedCaps > 0)
							{
								this.UpdateCustomerInventory(returnedBottles, returnedCaps, daystamp);								
							}
							if(amountTender > 0.0M)
							{
								this.UpdateCustomerRefillHeaders(amountTender, daystamp);
							}							
							MessageService.ShowInfo("Save successful!","Save");							
						}
						catch(Exception ex)
						{
		                    MessageService.ShowError("Unable to save data; an unexpected error occurred.\n" +
		                                        "Please check error log for details.\n", ex);
						}	
						this.Close();						
					}							
				}
				else{
						MessageService.ShowWarning("No changes; nothing to save.","Save");
				}
			}			
		}
		
		private void UpdateCustomerInventory(int returnedBottles, int returnedCaps, DateTime daystamp)
		{
			m_presenter.UpdateCustomerInventory(returnedBottles, returnedCaps, daystamp.Date);	
		}
		
		private void UpdateCustomerRefillHeaders(decimal amountTender, DateTime daystamp)
		{
			if(this.refillHeaders.Count > 0)
			{
				m_presenter.UpdateCustomerRefillHeaders(amountTender, refillHeaders, daystamp);
			}			
		}
		
		private bool ValidateCustomerInput()
		{
			if(this.cmbCustomers.SelectedItem != null && this.cmbCustomers.SelectedItem.ToString() != string.Empty)
			{
				return true;
			}
			return false;
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
		
		private void ClearFields()
		{
			txtBottlesOnHand.Text = 
				txtCapsOnHand.Text =
				txtReturnedBottles.Text =
				txtReturnedCaps.Text ="0";
			txtTotalAmtDue.Text =
				txtamttender.Text =
				txtchange.Text =
				txtbalance.Text = "0.00";
			dgvOutBalance.Rows.Clear();				
		}
						
		
		void TxtReturnedBottlesTextChanged(object sender, EventArgs e)
		{
			if(txtReturnedBottles.Text.Length == 0){
				txtReturnedBottles.Text = "0";				
			}			
			txtBottlesOnHand.Text = (bottlesOnHand - Int32.Parse(txtReturnedBottles.Text)).ToString();			
		}
		
		void TxtReturnedCapsTextChanged(object sender, EventArgs e)
		{
			if(txtReturnedCaps.Text.Length == 0){
				txtReturnedCaps.Text = "0";
			}
			txtCapsOnHand.Text = (capsOnHand - Int32.Parse(txtReturnedCaps.Text)).ToString();
		}
		
		void BtncancelClick(object sender, EventArgs e)
		{
			if(MessageService.ShowYesNo("Are you sure you want to cancel changes? Data in the fields will be remove.","Cancel Transaction")){
				txtReturnedCaps.Text = "";
				txtReturnedBottles.Text = "";
				txtamttender.Text="0.00";
			}	
		}

	}
}

/*
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
		
		public RefillReturnPaymentView()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void RefillReturnPaymentViewLoad(object sender, EventArgs e)
		{
			setButtonImages();
			m_presenter = new RefillingReturnPaymentPresenter(this);
			m_presenter.SetAllCustomers();
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
			if(!string.IsNullOrEmpty(this.cmbCustomers.SelectedText))
			{
				m_presenter.GetRefillJOsByCustomer(this.cmbCustomers.SelectedText);
			}
			else
			{
				MessageService.ShowWarning("No customer selected. Please select a customer.");
			}
		}
		
		public void LoadRefillHeaderAndInventoryData(List<RefillHeaderDataEntity> headers, 
		                                      RefillCustInventoryHeaderDataEntity custInv)
		{
			txtBottlesOnHand.Text = (custInv != null) ? custInv.BottlesOnHand.ToString() : "0";
			txtCapsOnHand.Text = (custInv != null) ? custInv.CapsOnHand.ToString() : "0";
			
			foreach(RefillHeaderDataEntity header in headers)
			{
				dgvOutBalance.Rows.Add(header.Date.ToShortDateString(), header.RefillHeaderID, header.TotalQty, 
				                       header.AmountDue, header.AmountTender, (header.AmountDue - header.AmountTender));
				                       
			}
			
		}
			
	}
}

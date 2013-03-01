/*
 * Created by SharpDevelop.
 * User: vo185003
 * Date: 2/4/2013
 * Time: 9:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using NJournals.Common.Gui;
using NJournals.Common.Interfaces;
using NJournals.Core.Models;
using NJournals.Core.Presenter;
using System.Collections.Generic;
using NJournals.Common.DataEntities;
using NJournals.Common.Util;

namespace NJournals.Core.Views
{
	/// <summary>
	/// Description of CustomerSearchView.
	/// </summary>
	public partial class LaundryCustomerSearchView : Form, ILaundryCustomerSearchView
	{
		private CustomerDataEntity m_customer;
		private LaundryCustomerSearchViewPresenter m_presenter;
		public LaundryCustomerSearchView(CustomerDataEntity p_customer)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//			
			m_customer = p_customer;			
			m_presenter = new LaundryCustomerSearchViewPresenter(this, p_customer);
		}
		
		void LaundryCustomerSearchViewLoad(object sender, EventArgs e)
		{
			this.Icon = new System.Drawing.Icon(System.IO.Directory.GetCurrentDirectory() + "/images/user1.ico");
			if(m_customer!=null)
			{
				txtcustomer.Text = m_customer.Name;			
				m_presenter.GetAllUnclaimedItems();
				m_presenter.GetAllUnpaidTransactions();
			}
		}
		
		public void SetAllUnclaimedItems(List<LaundryHeaderDataEntity> unclaimeditems)
		{
			foreach(LaundryHeaderDataEntity header in unclaimeditems)
			{
				dgvunclaimeditems.Rows.Add(header.LaundryHeaderID,header.ReceivedDate,header.DueDate, header.TotalItemQty,
				                           header.TotalAmountDue.ToString("N2"),(header.TotalAmountDue - header.TotalPayment).ToString("N2"));
			}
		}
		
		public void SetAllUnpaidTransactions(List<LaundryHeaderDataEntity> unpaidtransactions)
		{
			foreach(LaundryHeaderDataEntity header in unpaidtransactions)
			{
				dgvunpaidtrans.Rows.Add(header.LaundryHeaderID,header.ReceivedDate,header.DueDate, header.TotalItemQty,
				                           header.TotalAmountDue.ToString("N2"),(header.TotalAmountDue - header.TotalPayment).ToString("N2"));
			}
		}
		
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Dispose();
			this.Close();
		}
	}
}

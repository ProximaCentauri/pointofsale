/*
 * Created by SharpDevelop.
 * User: vo185003
 * Date: 2/21/2013
 * Time: 2:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NJournals.Common.Interfaces;
using NJournals.Core.Models;
using NJournals.Common.DataEntities;
using System.Collections.Generic;

namespace NJournals.Core.Presenter
{
	/// <summary>
	/// Description of CustomerListViewPresenter.
	/// </summary>
	public class CustomerListViewPresenter
	{
		ICustomerListView m_view;
		ICustomerDao m_customerDao;
		ILaundryReportDao m_laundryReport;
		IRefillReportDao m_refillReport;
		
		public CustomerListViewPresenter(ICustomerListView p_view)
		{
			this.m_view = p_view;
			m_customerDao = new CustomerDao();
			m_laundryReport = new LaundryReportDao();
			m_refillReport = new RefillReportDao();
		}
		
		public void SetAllCustomerList()
		{
			List<CustomerDataEntity> customers = m_customerDao.GetAllItems() as List<CustomerDataEntity>;
			m_view.SetAllCustomerList(customers);
		}
		
		public void SaveOrUpdateCustomer(CustomerDataEntity customer)
		{
			try
			{
				m_customerDao.SaveOrUpdate(customer);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		
		public void DeleteCustomer(CustomerDataEntity customer)
		{
			try
			{
				m_customerDao.Delete(customer);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		
		public void viewCustomersByName(string custName)
		{
			List<CustomerDataEntity> customers = m_customerDao.GetCustomersByName(custName) as List<CustomerDataEntity>;
			m_view.ViewCustomersByName(customers);
		}
		
		public bool VerifyCustomerPendingTransaction(CustomerDataEntity customer)
		{
			List<LaundryHeaderDataEntity> laundryHeader = null;
			List<RefillHeaderDataEntity> refillHeader = null;
			
			if((laundryHeader = m_laundryReport.GetUnclaimedItemsReport(customer) as List<LaundryHeaderDataEntity>).Count > 0)
			{
				return true;
			}
			if((laundryHeader = m_laundryReport.GetUnpaidTransactionsReport(customer) as List<LaundryHeaderDataEntity>).Count > 0)
			{
				return true;
			}
			if((refillHeader = m_refillReport.GetUnpaidTransactionsReport(customer) as List<RefillHeaderDataEntity>).Count > 0)
			{
				return true;
			}
			
			return false;			
		}
	}
}

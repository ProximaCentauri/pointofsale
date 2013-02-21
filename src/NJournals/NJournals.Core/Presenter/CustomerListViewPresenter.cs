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
		
		public CustomerListViewPresenter(ICustomerListView p_view)
		{
			this.m_view = p_view;
			m_customerDao = new CustomerDao();
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
	}
}

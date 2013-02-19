/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/19/2013
 * Time: 7:45 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NJournals.Core.Models;
using NJournals.Common.DataEntities;
using System.Collections.Generic;
using NJournals.Common.Interfaces;

namespace NJournals.Core.Presenter
{
	/// <summary>
	/// Description of LaundryCustomerSearchViewPresenter.
	/// </summary>
	public class LaundryCustomerSearchViewPresenter
	{
		ILaundryReportDao m_dao;
		ILaundryCustomerSearchView m_view;
	    CustomerDataEntity m_customer;
		public LaundryCustomerSearchViewPresenter(ILaundryCustomerSearchView p_view, 		                                        
		                                         CustomerDataEntity p_customer)
		{
			m_view = p_view;
			m_dao = new LaundryReportDao();
			m_customer = p_customer;
		}
		
		public void GetAllUnclaimedItems()
		{			
			List<LaundryHeaderDataEntity> unclaimedItems = m_dao.GetUnclaimedItemsReport(m_customer) as List<LaundryHeaderDataEntity>;
			m_view.SetAllUnclaimedItems(unclaimedItems);
		}
			
		public void GetAllUnpaidTransactions()
		{
			List<LaundryHeaderDataEntity> unpaidtrans = m_dao.GetUnpaidTransactionsReport(m_customer) as List<LaundryHeaderDataEntity>;
			m_view.SetAllUnpaidTransactions(unpaidtrans);
		}
	}
}

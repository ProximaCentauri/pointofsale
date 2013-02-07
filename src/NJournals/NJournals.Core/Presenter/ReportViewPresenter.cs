/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/7/2013
 * Time: 7:19 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NJournals.Common.Interfaces;
using NJournals.Core.Models;
using NJournals.Common.DataEntities;
using System.Collections.Generic;
using System.Data;

namespace NJournals.Core.Presenter
{
	/// <summary>
	/// Description of ReportViewPresenter.
	/// </summary>
	public class ReportViewPresenter
	{
		IReportView m_view;
		ICustomerDao m_customerDao;
		ILaundryReportDao m_laundryReportDao;
		
		private const string SALES_REPORT				= "Sales Report";
		private const string UNCLAIMED_ITEMS_REPORT		= "Unclaimed Items Report";
		private const string UNPAID_TRANSACTIONS_REPORT	= "Unpaid Transactions Report";
		private const string CLAIMED_ITEMS_REPORT		= "Claimed Items Report";	
		private const string INVENTORY_REPORT			= "Inventory Report";
		
		private const string LAUNDRY_WINDOW				= "Laundry Report";
		private const string REFILL_WINDOW				= "Refilling Report";
		
		
		public ReportViewPresenter(IReportView p_view)
		{
			this.m_view = p_view;
			m_customerDao = new CustomerDao();
			m_laundryReportDao = new LaundryReportDao();
		}
		
		public void SetAllReportTypes(string wndTitle)
		{
			List<string> reportTypes = new List<string>();
			switch(wndTitle)
        	{
        		case LAUNDRY_WINDOW:
					reportTypes.Add(SALES_REPORT);        			
        			reportTypes.Add(UNCLAIMED_ITEMS_REPORT);
        			reportTypes.Add(UNPAID_TRANSACTIONS_REPORT);
        			reportTypes.Add(CLAIMED_ITEMS_REPORT);
        			break;
        		case REFILL_WINDOW:
        			reportTypes.Add(SALES_REPORT);
        			reportTypes.Add(INVENTORY_REPORT);
        			reportTypes.Add(UNPAID_TRANSACTIONS_REPORT);
        			break;
        		default:
        			break;
        	}
			m_view.SetAllReportTypes(reportTypes);
		}
		
		public void SetAllCustomers()
		{
			List<CustomerDataEntity> customers = m_customerDao.GetAllItems() as List<CustomerDataEntity>;
			m_view.SetAllCustomers(customers);
		}
		
		public void RunReport(string wndTitle, string selectedReport, CustomerDataEntity customer, 
		                      DateTime fromDateTime, DateTime toDateTime, bool b_isAll)
		{			
			switch(wndTitle)
        	{
        		case LAUNDRY_WINDOW:
					RunLaundryReport(selectedReport, customer, fromDateTime, 
					                 toDateTime, b_isAll);
					break;
				case REFILL_WINDOW:
					break;
				default:
					break;
			}
		}
				
		private void RunLaundryReport(string selectedReport, CustomerDataEntity customer, 
		                      DateTime fromDateTime, DateTime toDateTime, bool b_isAll)
		{
			switch(selectedReport)
			{
				case SALES_REPORT:
					if(b_isAll)
					{
						List<LaundryDaySummaryDataEntity> report = m_laundryReportDao
							.GetAllCustomersSalesReport(fromDateTime, toDateTime) as List<LaundryDaySummaryDataEntity>;                      
						 m_view.DisplayReport(report);
					}
					else{
						List<LaundryHeaderDataEntity> report = m_laundryReportDao
							.GetCustomerSalesReport(customer, fromDateTime, toDateTime) as List<LaundryHeaderDataEntity>;
						m_view.DisplayReport(report);
					}
					break;
				default:
					break;
			}
		}			
	}
}

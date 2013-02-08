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
using NJournals.Common.Constants;
using Microsoft.Reporting.WinForms;

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
                case ReportConstants.LAUNDRY_WINDOW:
                    reportTypes.Add(ReportConstants.SALES_REPORT);
                    reportTypes.Add(ReportConstants.UNCLAIMED_ITEMS_REPORT);
                    reportTypes.Add(ReportConstants.UNPAID_TRANSACTIONS_REPORT);
                    reportTypes.Add(ReportConstants.CLAIMED_ITEMS_REPORT);
        			break;
                case ReportConstants.REFILL_WINDOW:
                    reportTypes.Add(ReportConstants.SALES_REPORT);
                    reportTypes.Add(ReportConstants.INVENTORY_REPORT);
                    reportTypes.Add(ReportConstants.UNPAID_TRANSACTIONS_REPORT);
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
                case ReportConstants.LAUNDRY_WINDOW:
					RunLaundryReport(selectedReport, customer, fromDateTime, 
					                 toDateTime, b_isAll);
					break;
                case ReportConstants.REFILL_WINDOW:
					break;
				default:
					break;
			}
		}
				
		private void RunLaundryReport(string selectedReport, CustomerDataEntity customer, 
		                      DateTime fromDateTime, DateTime toDateTime, bool b_isAll)
		{
            List<ReportDataSource> datasources = new List<ReportDataSource>();
			switch(selectedReport)
			{
                case ReportConstants.SALES_REPORT:
                   
					if(b_isAll)
					{
						List<LaundryDaySummaryDataEntity> report = m_laundryReportDao
							.GetAllCustomersSalesReport(fromDateTime, toDateTime) as List<LaundryDaySummaryDataEntity>;
 
                        datasources.Add(new ReportDataSource(ReportConstants.DS_LAUNDRYDAYSUMMARY, report));
                        datasources.Add(new ReportDataSource(ReportConstants.DS_LAUNDRYHEADER, report));
                        m_view.DisplayReport(report, datasources, ReportConstants.ES_SALESREPORT, ReportConstants.DS_LAUNDRYDAYSUMMARY);
					}
					else{
						List<LaundryHeaderDataEntity> report = m_laundryReportDao
							.GetCustomerSalesReport(customer, fromDateTime, toDateTime) as List<LaundryHeaderDataEntity>;
                        datasources.Add(new ReportDataSource(ReportConstants.DS_LAUNDRYDAYSUMMARY, report));
                        datasources.Add(new ReportDataSource(ReportConstants.DS_LAUNDRYHEADER, report));
                        m_view.DisplayReport(report, datasources, ReportConstants.ES_SALESREPORT, ReportConstants.DS_LAUNDRYHEADER);
                    }
					break;
				default:
					break;
			}
            datasources.Clear();
		}			
	}
}

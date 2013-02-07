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

namespace NJournals.Core.Presenter
{
	/// <summary>
	/// Description of ReportViewPresenter.
	/// </summary>
	public class ReportViewPresenter
	{
		IReportView m_view;
		ICustomerDao m_customerDao;
		ILaundryReportDao m_laundryReportDao = null;
		
		public ReportViewPresenter(IReportView p_view)
		{
			this.m_view = p_view;
			m_customerDao = new CustomerDao();
		}
		
		public void SetAllReportTypes()
		{
			m_view.SetAllReportTypes();
		}
		
		public void SetAllCustomers()
		{
			List<CustomerDataEntity> customers = m_customerDao.GetAllItems() as List<CustomerDataEntity>;
			m_view.SetAllCustomers(customers);
		}
		
		public void RunLaundryReport(string selectedReport, CustomerDataEntity customer, 
		                      DateTime fromDateTime, DateTime toDateTime, bool b_isAll)
		{
			switch(selectedReport)
			{
				case "Sales Report":
					if(b_isAll){
						 List<LaundryDaySummaryDataEntity> salesReport = m_laundryReportDao
							.GetAllCustomersSalesReport(fromDateTime, toDateTime) as List<LaundryDaySummaryDataEntity>;
						 m_view.DisplayReport(salesReport);
					}
					break;
				default:
					break;
			}
		}
	}
}

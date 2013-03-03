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
        IRefillReportDao m_refillReportDao;
		
		public ReportViewPresenter(IReportView p_view)
		{
			this.m_view = p_view;
			m_customerDao = new CustomerDao();
			m_laundryReportDao = new LaundryReportDao();
            m_refillReportDao = new RefillReportDao();
		}
		
		public void SetAllReportTypes(string wndTitle)
		{
			List<string> reportTypes = new List<string>();
			switch(wndTitle)
        	{
                case ReportConstants.LAUNDRY_WINDOW:
                    reportTypes.Add(ReportConstants.CLAIMED_ITEMS_REPORT);
                    reportTypes.Add(ReportConstants.SALES_REPORT);
                    reportTypes.Add(ReportConstants.UNCLAIMED_ITEMS_REPORT);
                    reportTypes.Add(ReportConstants.UNPAID_TRANSACTIONS_REPORT);  
                    reportTypes.Add(ReportConstants.VOID_TRANSACTIONS_REPORT);
        			break;
                case ReportConstants.REFILL_WINDOW:
                    reportTypes.Add(ReportConstants.INVENTORY_REPORT);
                    reportTypes.Add(ReportConstants.CUSTINVENTORY_REPORT);
                    reportTypes.Add(ReportConstants.SALES_REPORT);
                    reportTypes.Add(ReportConstants.UNPAID_TRANSACTIONS_REPORT);                    
                    reportTypes.Add(ReportConstants.VOID_TRANSACTIONS_REPORT);
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
                    RunRefillReport(selectedReport, customer, fromDateTime, toDateTime, b_isAll);
					break;
				default:
					break;
			}
		}
				
		private void RunLaundryReport(string selectedReport, CustomerDataEntity customer, 
		                      DateTime fromDateTime, DateTime toDateTime, bool b_isAll)
		{
            List<ReportDataSource> datasources = new List<ReportDataSource>();   
            List<ReportParameter> parameters = SetReportParameters(customer, fromDateTime, toDateTime, b_isAll);
                                              
			switch(selectedReport)
			{
                case ReportConstants.SALES_REPORT:
					List<LaundryDaySummaryDataEntity> salesReport = m_laundryReportDao
						.GetCustomerSalesReport(customer, fromDateTime, toDateTime, b_isAll) as List<LaundryDaySummaryDataEntity>;
                    datasources.Add(new ReportDataSource(ReportConstants.DS_LAUNDRYDAYSUMMARY, salesReport));                    
                    m_view.DisplayReport(salesReport, datasources, parameters, ReportConstants.ES_LAUNDRY_SALES_REPORT);                  
				    break;
                case ReportConstants.UNCLAIMED_ITEMS_REPORT:
                    List<LaundryHeaderDataEntity> unclaimedReport = m_laundryReportDao
                        .GetUnclaimedItemsReport(customer, fromDateTime, toDateTime, b_isAll) as List<LaundryHeaderDataEntity>;
                    datasources.Add(new ReportDataSource(ReportConstants.DS_LAUNDRYHEADER, unclaimedReport));
                    m_view.DisplayReport(unclaimedReport, datasources, parameters, ReportConstants.ES_LAUNDRY_UNCLAIMEDITEMS_REPORT);                   
                    break;
                case ReportConstants.CLAIMED_ITEMS_REPORT:
                    List<LaundryHeaderDataEntity> claimedReport = m_laundryReportDao
                        .GetClaimedItemsReport(customer, fromDateTime, toDateTime, b_isAll) as List<LaundryHeaderDataEntity>;
                    datasources.Add(new ReportDataSource(ReportConstants.DS_LAUNDRYHEADER, claimedReport));
                    m_view.DisplayReport(claimedReport, datasources, parameters, ReportConstants.ES_LAUNDRY_CLAIMEDITEMS_REPORT);
                    break;
                case ReportConstants.UNPAID_TRANSACTIONS_REPORT:
                    List<LaundryHeaderDataEntity> unpaidReport = m_laundryReportDao
                        .GetUnpaidTransactionsReport(customer, fromDateTime, toDateTime, b_isAll) as List<LaundryHeaderDataEntity>;
                    datasources.Add(new ReportDataSource(ReportConstants.DS_LAUNDRYHEADER, unpaidReport));
                    m_view.DisplayReport(unpaidReport, datasources, parameters, ReportConstants.ES_LAUNDRY_UNPAIDTRANSACTIONS_REPORT);
                    break;
                case ReportConstants.VOID_TRANSACTIONS_REPORT:
                    List<LaundryHeaderDataEntity> voidReport = m_laundryReportDao
                    	.GetVoidTransactionsReport(customer, fromDateTime, toDateTime, b_isAll) as List<LaundryHeaderDataEntity>;
                    datasources.Add(new ReportDataSource(ReportConstants.DS_LAUNDRYHEADER, voidReport));
                    m_view.DisplayReport(voidReport, datasources, parameters, ReportConstants.ES_LAUNDRY_VOIDTRANSACTIONS_REPORT);
                    break;
				default:
					break;
			}
          
            datasources.Clear();
		}		

		private void RunRefillReport(string selectedReport, CustomerDataEntity customer, 
		                      DateTime fromDateTime, DateTime toDateTime, bool b_isAll)
		{
            List<ReportDataSource> datasources = new List<ReportDataSource>();
            List<ReportParameter> parameters = new List<ReportParameter>();
			switch(selectedReport)
			{
                case ReportConstants.SALES_REPORT:
                    List<RefillDaySummaryDataEntity> salesReport = m_refillReportDao
						.GetCustomerSalesReport(customer, fromDateTime, toDateTime, b_isAll) as List<RefillDaySummaryDataEntity>;
                    parameters = SetReportParameters(customer, fromDateTime, toDateTime, b_isAll);
                    datasources.Add(new ReportDataSource(ReportConstants.DS_REFILLDAYSUMMARY, salesReport));
                    m_view.DisplayReport(salesReport, datasources, parameters, ReportConstants.ES_REFILL_SALES_REPORT);                  
				    break;                
                case ReportConstants.UNPAID_TRANSACTIONS_REPORT:
                    List<RefillHeaderDataEntity> unpaidReport = m_refillReportDao
                        .GetUnpaidTransactionsReport(customer, fromDateTime, toDateTime, b_isAll) as List<RefillHeaderDataEntity>;
                    parameters = SetReportParameters(customer, fromDateTime, toDateTime, b_isAll);
                    datasources.Add(new ReportDataSource(ReportConstants.DS_REFILLHEADER, unpaidReport));
                    m_view.DisplayReport(unpaidReport, datasources, parameters, ReportConstants.ES_REFILL_UNPAIDTRANSACTIONS_REPORT);
                    break;
                case ReportConstants.INVENTORY_REPORT:
                    List<RefillInventoryReportDataEntity> invReport = m_refillReportDao                        
                         .GetInventoryReport(fromDateTime, toDateTime) as List<RefillInventoryReportDataEntity>;                                                                                                                              
				    parameters = SetReportParameters(fromDateTime, toDateTime);                
                    if(invReport.Count > 0)
                    {
                        datasources.Add(new ReportDataSource(ReportConstants.DS_REFILLINVENTORYDETAIL, invReport));
                        datasources.Add(new ReportDataSource(ReportConstants.DS_REFILLINVENTORYHEADER, new List<RefillInventoryHeaderDataEntity>()));
                        parameters.Add(new ReportParameter("reportType", "inventorydetail"));
                    	m_view.DisplayReport(invReport, datasources, parameters, ReportConstants.ES_REFILL_INVENTORY_REPORT);                   
                    }
                    else{
                    	// TODO: update report file to add datasource for header
                    	List<RefillInventoryHeaderDataEntity> invHeader = m_refillReportDao                    		
                    		.GetInventoryHeaderReport() as List<RefillInventoryHeaderDataEntity>;
                        datasources.Add(new ReportDataSource(ReportConstants.DS_REFILLINVENTORYDETAIL, invReport));
                    	datasources.Add(new ReportDataSource(ReportConstants.DS_REFILLINVENTORYHEADER, invHeader));  
                        parameters.Add(new ReportParameter("reportType", "inventoryheader"));
                    	m_view.DisplayReport(invHeader, datasources, parameters, ReportConstants.ES_REFILL_INVENTORY_REPORT);
                    }
                	                	
                    
                	break;
                case ReportConstants.CUSTINVENTORY_REPORT:
                	List<RefillCustInventoryHeaderDataEntity> custInvReport = m_refillReportDao
                		.GetCustomerInventoryReport(customer, b_isAll) as List<RefillCustInventoryHeaderDataEntity>;
                	parameters = SetReportParameters(customer, b_isAll);
                    datasources.Add(new ReportDataSource(ReportConstants.DS_REFILLCUSTINVENTORY, custInvReport));
                    m_view.DisplayReport(custInvReport, datasources, parameters, ReportConstants.ES_REFILL_CUSTINVENTORY_REPORT);       
                	break;
                case ReportConstants.VOID_TRANSACTIONS_REPORT:
                    List<RefillHeaderDataEntity> voidReport = m_refillReportDao
                    	.GetVoidTransactionsReport(customer, fromDateTime, toDateTime, b_isAll) as List<RefillHeaderDataEntity>;
                    parameters = SetReportParameters(customer, fromDateTime, toDateTime, b_isAll);
                    datasources.Add(new ReportDataSource(ReportConstants.DS_REFILLHEADER, voidReport));
                    m_view.DisplayReport(voidReport, datasources, parameters, ReportConstants.ES_REFILL_VOIDTRANSACTIONS_REPORT);
                    break;
				default:
					break;
			}
          
            datasources.Clear();
		}	

		private List<ReportParameter> SetReportParameters( CustomerDataEntity customer, 
		                      DateTime fromDateTime, DateTime toDateTime, bool b_isAll)
		{
			List<ReportParameter> parameters = new List<ReportParameter>();           
            parameters.Add(new ReportParameter("fromDateTime", fromDateTime.ToShortDateString()));
            parameters.Add(new ReportParameter("toDateTime", toDateTime.ToShortDateString()));
            
            if(customer.Name == null)
            {
            	 parameters.Add(new ReportParameter("customerName", ""));
            }
            else{
            	 parameters.Add(new ReportParameter("customerName", customer.Name));
            }
            parameters.Add(new ReportParameter("isAll", b_isAll.ToString())); 
			return parameters;            
		}
		
		private List<ReportParameter> SetReportParameters(DateTime fromDateTime, DateTime toDateTime)
		{
			List<ReportParameter> parameters = new List<ReportParameter>();           
            parameters.Add(new ReportParameter("fromDateTime", fromDateTime.ToShortDateString()));
            parameters.Add(new ReportParameter("toDateTime", toDateTime.ToShortDateString()));           
			return parameters;    
		}
		
		private List<ReportParameter> SetReportParameters(CustomerDataEntity customer, bool b_isAll)
		{
			List<ReportParameter> parameters = new List<ReportParameter>();      
 			if(customer.Name == null)
            {
            	 parameters.Add(new ReportParameter("customerName", ""));
            }
            else{
            	 parameters.Add(new ReportParameter("customerName", customer.Name));
            }			            
 			parameters.Add(new ReportParameter("isAll", b_isAll.ToString()));
			return parameters;  
		}
	}
}

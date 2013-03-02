/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/14/2013
 * Time: 7:04 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NJournals.Common.Interfaces;
using NJournals.Core.Models;
using NJournals.Common.DataEntities;
using System.Collections.Generic;
using System.Data;
using NJournals.Common.Util;

namespace NJournals.Core.Presenter
{
	/// <summary>
	/// Description of RefillingReturnPaymentPresenter.
	/// </summary>
	public class RefillingReturnPaymentPresenter
	{
		IRefillReturnPaymentView m_view;
		ICustomerDao m_customerDao;
		IRefillDao m_refillDao;		
		IRefillReportDao m_refillReportDao;
		IRefillCustomerInventoryDao m_custInvDao;	
		IRefillDaySummaryDao m_daysummaryDao;
		IRefillInventoryDao m_invDao;		
		CustomerDataEntity customer;
		RefillCustInventoryHeaderDataEntity custInv ;
		
		
		public RefillingReturnPaymentPresenter(IRefillReturnPaymentView m_view)
		{
			this.m_view = m_view;
			m_customerDao = new CustomerDao();
			m_refillDao = new RefillDao();
			m_refillReportDao = new RefillReportDao();
			m_custInvDao = new RefillCustomerInventoryDao();
			m_daysummaryDao = new RefillDaySummaryDao();
			m_invDao = new RefillInventoryDao();
			customer = new CustomerDataEntity();
			custInv = new RefillCustInventoryHeaderDataEntity();
		}
		
		public void SetAllCustomers()
		{
			try
			{
				List<CustomerDataEntity> customers = m_customerDao.GetAllItems() as List<CustomerDataEntity>;
				m_view.SetAllCustomers(customers);
			}
			catch(Exception ex)
			{
                MessageService.ShowError("Unable to display data; an unexpected error occurred.\n" +
                                        "Please check error log for details.\n", ex);
			}
		}
		
		public void GetRefillJOsByCustomer(string customerName)
		{
			try
			{
				customer = m_customerDao.GetByName(customerName) as CustomerDataEntity;
				List<RefillHeaderDataEntity> refillHeaders = m_refillReportDao.GetUnpaidTransactionsReport(customer) as List<RefillHeaderDataEntity>;
				custInv = m_custInvDao.GetByCustomer(customer) as RefillCustInventoryHeaderDataEntity;
				if(custInv == null && refillHeaders.Count == 0)
				{
					MessageService.ShowInfo("No records found for customer: " + customerName);
					return;
				}				
				m_view.LoadRefillHeaderAndInventoryData(refillHeaders, custInv);
			}
			catch(Exception ex)
			{
                MessageService.ShowError("Unable to display data; an unexpected error occurred.\n" +
                                        "Please check error log for details.\n", ex);
			}
		}
		
		public void UpdateCustomerInventory(int returnedBottles, int returnedCaps, DateTime returnDate)
		{			
			try
			{			
				custInv.BottlesReturned += returnedBottles;
				custInv.CapsReturned += returnedCaps;
				if(custInv.BottlesOnHand != 0){
					custInv.BottlesOnHand -= returnedBottles;	
				}
				if(custInv.CapsOnHand != 0){
					custInv.CapsOnHand -= returnedCaps;	
				}
				
				RefillCustInventoryDetailDataEntity detail = m_custInvDao.GetDetailByDay(custInv, returnDate);								
				if(detail == null){
					detail = CreateNewCustInventoryDetail(custInv, returnedBottles, returnedCaps, returnDate);										
					custInv.DetailEntities.Add(detail);
				}
				else{
					detail.BottlesReturned += returnedBottles;
					detail.CapsReturned += returnedCaps;
				}	
				
				m_custInvDao.SaveOrUpdate(custInv);
						
				if(returnedBottles != 0){
					UpdateInventory("5 GAL BOTTLE", returnedBottles, returnDate);
				}
				if(returnedCaps != 0){
					UpdateInventory("CAPS", returnedCaps, returnDate);				
				}
			}
			catch(Exception ex)
			{								
				throw ex;				
			}
		}
		
		private void UpdateInventory(string name, int returnedQty, DateTime daystamp)
		{
			try
			{
				RefillInventoryHeaderDataEntity header = m_invDao.GetByName(name);
				if(header == null) 
					return;
				
				header.QtyOnHand += returnedQty;
				if(header.QtyReleased !=0){
					header.QtyReleased -= returnedQty;
				}
				RefillInventoryDetailDataEntity detail = m_invDao.GetDetailByDay(header,daystamp);							
				if(detail == null)
				{
					detail = CreateNewInventoryDetail(header, returnedQty, daystamp);
					header.DetailEntities.Add(detail);
				}else{
					detail.QtyOnHand += returnedQty;
					detail.QtyReleased -= returnedQty;	
				}
				m_invDao.SaveOrUpdate(header);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		
		public void UpdateCustomerRefillHeaders(decimal amtTender, List<RefillHeaderDataEntity> refillHeaders, DateTime paymentDate)
		{
			try
			{
				decimal balance = 0.00M;				
				foreach(RefillHeaderDataEntity header in refillHeaders)
				{					
					balance = header.AmountDue - header.AmountTender;
					if(amtTender >= balance)
					{
						header.AmountTender += balance;
						if(header.AmountDue == header.AmountTender){
							header.PaidFlag = true;
						}
						amtTender -= balance;
						header.PaymentDetailEntities.Add(CreateNewPayment(balance, header, paymentDate));						
						m_refillDao.SaveOrUpdate(header);
						UpdateDaySummary(balance, paymentDate, header);
					}
					else if(amtTender < balance)
					{
						header.AmountTender += amtTender;
						if(header.AmountDue == header.AmountTender){
							header.PaidFlag = true;
						}							
						header.PaymentDetailEntities.Add(CreateNewPayment(amtTender, header, paymentDate));
						m_refillDao.SaveOrUpdate(header);
						UpdateDaySummary(amtTender, paymentDate, header);
						amtTender = 0.00M;
					}
					if(amtTender <= 0.00M)
					{
						break;
					}
				}			
			}
			catch(Exception ex)
			{				
				throw ex;				
			}
		}
		
		private void UpdateDaySummary(decimal amount, DateTime paymentDate, RefillHeaderDataEntity header)
		{
			try
			{
				RefillDaySummaryDataEntity daysummary = m_daysummaryDao.GetByDay(paymentDate);
				if(daysummary == null)
				{
					daysummary = new RefillDaySummaryDataEntity();
					daysummary.HeaderEntities.Add(header);
					daysummary.TotalSales += amount;
					daysummary.DayStamp = paymentDate;				
				}else{                   
					daysummary.TotalSales += amount;
				}
				m_daysummaryDao.SaveOrUpdate(daysummary);
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		
		private RefillPaymentDetailDataEntity CreateNewPayment(decimal amount, RefillHeaderDataEntity header, DateTime paymentDate)
		{
			RefillPaymentDetailDataEntity payment = new RefillPaymentDetailDataEntity();
			payment.Header = header;
			payment.Amount = amount;
			payment.PaymentDate = paymentDate;		
			return payment;
		}
		
		private RefillCustInventoryDetailDataEntity CreateNewCustInventoryDetail(RefillCustInventoryHeaderDataEntity header,
		                                                                    int returnedBottles, int returnedCaps, DateTime returnDate)
		{
			RefillCustInventoryDetailDataEntity detail = new RefillCustInventoryDetailDataEntity();
			detail.Header = header;
			detail.BottlesReturned = returnedBottles;
			detail.CapsReturned = returnedCaps;
			detail.Date = returnDate;	
			return detail;						
		}
		
		private RefillInventoryDetailDataEntity CreateNewInventoryDetail(RefillInventoryHeaderDataEntity header, int returnedQty, DateTime daystamp)
		{
			RefillInventoryDetailDataEntity detail = new RefillInventoryDetailDataEntity();
			detail.Header = header;
			detail.QtyOnHand += returnedQty;
			detail.QtyReleased -= returnedQty;			
			detail.Date = daystamp;
			return detail;
		}
	}
}

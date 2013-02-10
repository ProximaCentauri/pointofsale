/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/10/2013
 * Time: 8:11 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;
using NJournals.Common.DataEntities;
using NJournals.Common.DataMappers;
using NJournals.Core.Models;
using System.Collections.Generic;
using NJournals.Common.Util;
using System.Globalization;

namespace NJournals.Tests
{
	[TestFixture]
	public class RefillTest
	{
		[Test]
		public void TestMethod()
		{
			// TODO: Add your test.
		}
		
		[Test]
		public void Setup(){
			NHibernateHelper.OpenSession();
		}
		
		[Test]
		public void saveNewHeaderAndNewDaySummary(){	
			// test for new header and new day
			// should create new record for daysummary			
			RefillHeaderDataEntity header = new RefillHeaderDataEntity();
			RefillDetailDataEntity detail = new RefillDetailDataEntity();			
						
			RefillTransactionTypeDataEntity transactionType = new RefillTransactionTypeDao().GetByName("Delivery");
			RefillProductTypeDataEntity productType = new RefillProductTypeDao().GetByName("5 Gal at 25");
			
			CustomerDao custdao = new CustomerDao();
			CustomerDataEntity customer = custdao.GetByName("John Dee");
			if(customer == null)
			{
				customer = new CustomerDataEntity();
				customer.Name = "John Dee";
				customer.Address = "Cebu";
				customer.ContactNumber = "111-1111";
			}
			
			header.Customer = customer;
			header.Date = DateTime.Now;			
			header.TransactionType = transactionType;
			
			detail.Header = header; // set header entity in detail for nhibernate to pickup and map
			detail.ProductType = productType;
			detail.Qty = 10;
			detail.Amount = productType.Price * Convert.ToDecimal(detail.Qty);
			detail.StoreBottleQty = 10;
			detail.StoreCapQty = 10;
			
			header.DetailEntities.Add(detail); // add detail to header details list
			header.AmountDue = detail.Amount;						
			header.TotalQty = detail.Qty;			
			header.AmountTender = header.AmountDue;
			
			if(header.AmountTender == header.AmountTender){
				header.PaidFlag = true;
			}
			else{
				header.PaidFlag = false;
			}
			
			// set paymentdetail
			RefillPaymentDetailDataEntity paymentdetail = new RefillPaymentDetailDataEntity();
			paymentdetail.Amount = header.AmountTender;
			paymentdetail.PaymentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			paymentdetail.Header = header;
			header.PaymentDetailEntities.Add(paymentdetail);
				
			// set daysummary			
			RefillDaySummaryDataEntity daysummary = new RefillDaySummaryDataEntity();
			daysummary.DayStamp = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			daysummary.TotalSales += header.AmountTender; 
			daysummary.TransCount += 1;
			daysummary.HeaderEntities.Add(header); // set header entity in daysummary for nhibernate to pickup and map			
			header.DaySummary = daysummary; // set daysummary entity in header for nhibernate to pickup and map
			
			custdao.SaveOrUpdate(customer); // save or update customer
			// save daysummary record; no need to explicitly save header,detail,jobcharges,paymentdetail, etc for new daysummary record
			// this will handle the saving for the linked tables
			RefillDaySummaryDao dao = new RefillDaySummaryDao();
			dao.SaveOrUpdate(daysummary);
		}
		
		[Test]
		public void saveNewHeaderAndUpdateDaySummary()
		{
			// test for new header but with existing daysummary
			// should not save new record for daysummary
			// should only update existing daysummary with transcount and sales			
			
			DateTime sampleDay = Convert.ToDateTime(DateTime.Now.ToShortDateString()); // daystamp in daysummary should be date only (no time);
			
			RefillDaySummaryDao summarydao = new RefillDaySummaryDao();			
			RefillDaySummaryDataEntity summary = summarydao.GetByDay(sampleDay);
			if(summary!= null)
			{
				RefillHeaderDataEntity header = new RefillHeaderDataEntity();
				RefillDetailDataEntity detail = new RefillDetailDataEntity();
				
				RefillTransactionTypeDataEntity transactionType = new RefillTransactionTypeDao().GetByName("Delivery");
				RefillProductTypeDataEntity productType = new RefillProductTypeDao().GetByName("5 Gal at 15");
			
			
				CustomerDao custdao = new CustomerDao();
				CustomerDataEntity customer = custdao.GetByName("John Dee");
				if(customer == null)
				{
					customer = new CustomerDataEntity();
					customer.Name = "John Dee";
					customer.Address = "Cebu";
					customer.ContactNumber = "111-1111";
				}
				header.Customer = customer;
				header.Date = DateTime.Now;
				header.TransactionType = transactionType;				
				
				detail.Header = header; // set header entity in detail for nhibernate to pickup and map
				detail.ProductType = productType;
				detail.Qty = 20;
				detail.Amount = productType.Price * Convert.ToDecimal(detail.Qty);
				detail.StoreBottleQty = 10;
				detail.StoreCapQty = 10;
									
				header.DetailEntities.Add(detail); // add detail to header details list
				header.AmountDue = detail.Amount;
				header.TotalQty = detail.Qty;
				header.AmountTender += 25.00M; // accumulate amount tender with current amount tender
				
				// TODO: should update paidflag in header if total balance = 0.
								
				// set paymentdetail
				RefillPaymentDetailDataEntity paymentdetail = new RefillPaymentDetailDataEntity();
				paymentdetail.Amount = header.AmountTender;
				paymentdetail.PaymentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
				paymentdetail.Header = header;
				header.PaymentDetailEntities.Add(paymentdetail);
								
				summary.TransCount += 1;
				summary.TotalSales += header.AmountTender;
				header.DaySummary = summary;
				
				// update daysummary with transcount and totalsales
				RefillDaySummaryDao dao = new RefillDaySummaryDao();
				dao.Update(summary);
				
				// save header,details,etc.
				RefillDao ldao = new RefillDao();
				ldao.Save(header);
			}				
		}
		
		[Test]
		public void saveNewPaymentDetail()
		{
			// test for saving new paymentdetail for partial payments
			RefillHeaderDataEntity header = new RefillDao().GetByID(2);
			
			header.AmountTender += 10.00M; // accumulate amount tender with current payment
			// set paymentdetail
			RefillPaymentDetailDataEntity paymentdetail = new RefillPaymentDetailDataEntity();
			paymentdetail.Amount = 10.00M; // current amount tender or payment
			paymentdetail.PaymentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			paymentdetail.Header = header;
			
			// TODO: should update paidflag in header if total balance = 0.
			
			// update daysummary
			DateTime daysummaryDay = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			RefillDaySummaryDataEntity daysummary = new RefillDaySummaryDao().GetByDay(daysummaryDay);
			if(daysummary != null)
			{
				daysummary.TotalSales += paymentdetail.Amount;
				daysummary.DayStamp = daysummaryDay;		
			}
			RefillDaySummaryDao dao = new RefillDaySummaryDao();
			dao.SaveOrUpdate(daysummary);
			
			// update header, save payment detail etc.
			header.PaymentDetailEntities.Add(paymentdetail);
			RefillDao ldao = new RefillDao();
			ldao.Update(header);
			
		}
	}
}

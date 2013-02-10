/*
 * Created by SharpDevelop.
 * User: jl185099
 * Date: 2/1/2013
 * Time: 2:33 PM
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
	public class LaundryTest
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
			LaundryHeaderDataEntity header = new LaundryHeaderDataEntity();
			LaundryDetailDataEntity detail = new LaundryDetailDataEntity();
			LaundryJobChargesDataEntity jobcharge = new LaundryJobChargesDataEntity();
						
			LaundryCategoryDataEntity category = new LaundryCategoryDao().GetByName("Colored Garments");
			LaundryServiceDataEntity service = new LaundryServiceDao().GetByName("Wash - Dry - Fold");
			LaundryPriceSchemeDataEntity pricescheme = new LaundryPriceSchemeDao().GetByCategoryService(service,category);
			
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
			header.ReceivedDate = DateTime.Now;
			header.DueDate = DateTime.Now.AddDays(5); // add 5 days for due date
					
			detail.Header = header; // set header entity in detail for nhibernate to pickup and map
			detail.Category = category;
			detail.Service = service;
			detail.Kilo = 5;
			detail.Amount = pricescheme.Price * Convert.ToDecimal(detail.Kilo);
			detail.ItemQty = 20;
						
			jobcharge.Charge = new LaundryChargeDao().GetByName("Delivery");
			jobcharge.Header = header; // set header entity in jobcharge for nhibernate to pickup and map
			
			header.DetailEntities.Add(detail); // add detail to header details list
			header.JobChargeEntities.Add(jobcharge); // add charges to header charges list
			
			header.ClaimFlag = false;
			header.AmountDue = detail.Amount;
			header.TotalItemQty = detail.ItemQty;
			header.TotalCharge = jobcharge.Charge.Amount;
			header.TotalDiscount = 0;
			header.TotalAmountDue = (header.AmountDue + header.TotalCharge) - header.TotalDiscount;
			header.AmountTender = header.TotalAmountDue;
			
			if(header.AmountTender == header.TotalAmountDue){
				header.PaidFlag = true;
			}
			else{
				header.PaidFlag = false;
			}
			
			// set paymentdetail
			LaundryPaymentDetailDataEntity paymentdetail = new LaundryPaymentDetailDataEntity();
			paymentdetail.Amount = header.AmountTender;
			paymentdetail.PaymentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			paymentdetail.Header = header;
			header.PaymentDetailEntities.Add(paymentdetail);
				
			// set daysummary			
			LaundryDaySummaryDataEntity daysummary = new LaundryDaySummaryDataEntity();
			daysummary.DayStamp = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			daysummary.TotalSales += header.AmountTender; 
			daysummary.TransCount += 1;
			daysummary.HeaderEntities.Add(header); // set header entity in daysummary for nhibernate to pickup and map			
			header.DaySummary = daysummary; // set daysummary entity in header for nhibernate to pickup and map
			
			custdao.SaveOrUpdate(customer); // save or update customer
			// save daysummary record; no need to explicitly save header,detail,jobcharges,paymentdetail, etc for new daysummary record
			// this will handle the saving for the linked tables
			
			// FIX: save new header & new daysummary thru laundrydao instead of laundrydaysummary
			LaundryDao dao = new LaundryDao();
			dao.Save(header);
		}
		
		[Test]
		public void saveNewHeaderAndUpdateDaySummary()
		{
			// test for new header but with existing daysummary
			// should not save new record for daysummary
			// should only update existing daysummary with transcount and sales			
			
			DateTime sampleDay = Convert.ToDateTime(DateTime.Now.ToShortDateString()); // daystamp in daysummary should be date only (no time);
			
			LaundryDaySummaryDao summarydao = new LaundryDaySummaryDao();			
			LaundryDaySummaryDataEntity summary = summarydao.GetByDay(sampleDay);
			if(summary!= null)
			{
				LaundryHeaderDataEntity header = new LaundryHeaderDataEntity();
				LaundryDetailDataEntity detail = new LaundryDetailDataEntity();
				LaundryJobChargesDataEntity jobcharge = new LaundryJobChargesDataEntity();
							
				LaundryCategoryDataEntity category = new LaundryCategoryDao().GetByName("White Garments");
				LaundryServiceDataEntity service = new LaundryServiceDao().GetByName("Wash - Dry - Press");
				LaundryPriceSchemeDataEntity pricescheme = new LaundryPriceSchemeDao().GetByCategoryService(service,category);
	
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
				header.ReceivedDate = DateTime.Now;
				header.DueDate = DateTime.Now.AddDays(5); // add 5 days for due date
						
				detail.Header = header; // set header entity in detail for nhibernate to pickup and map
				detail.Category = category;
				detail.Service = service;
				detail.Kilo = 100;
				detail.Amount = pricescheme.Price * Convert.ToDecimal(detail.Kilo);
				detail.ItemQty = 300;
							
				jobcharge.Charge = new LaundryChargeDao().GetByName("Delivery");
				jobcharge.Header = header; // set header entity in jobcharge for nhibernate to pickup and map
				
				header.DetailEntities.Add(detail); // add detail to header details list
				header.JobChargeEntities.Add(jobcharge); // add charges to header charges list
				
				header.ClaimFlag = false;
				header.AmountDue = detail.Amount;
				header.TotalItemQty = detail.ItemQty;
				header.TotalCharge = jobcharge.Charge.Amount;
				header.TotalDiscount = 50.00M;
				header.TotalAmountDue = (header.AmountDue + header.TotalCharge) - header.TotalDiscount;
				header.AmountTender += 50.00M; // accumulate amount tender with current amount tender
				
				// TODO: should update paidflag in header if total balance = 0.
				
				
				// set paymentdetail
				LaundryPaymentDetailDataEntity paymentdetail = new LaundryPaymentDetailDataEntity();
				paymentdetail.Amount = header.AmountTender;
				paymentdetail.PaymentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
				paymentdetail.Header = header;
				header.PaymentDetailEntities.Add(paymentdetail);
								
				summary.TransCount += 1;
				summary.TotalSales += header.AmountTender;
				header.DaySummary = summary;
				
				// update daysummary with transcount and totalsales
				LaundryDaySummaryDao dao = new LaundryDaySummaryDao();
				dao.Update(summary);
				
				// save header,details,etc.
				LaundryDao ldao = new LaundryDao();
				ldao.Save(header);
			}				
		}
		
		[Test]
		public void saveNewPaymentDetail()
		{
			// test for saving new paymentdetail for partial payments
			LaundryHeaderDataEntity header = new LaundryDao().GetByID(2);
			
			header.AmountTender += 50.00M; // accumulate amount tender with current payment
			// set paymentdetail
			LaundryPaymentDetailDataEntity paymentdetail = new LaundryPaymentDetailDataEntity();
			paymentdetail.Amount = 50.00M; // current amount tender or payment
			paymentdetail.PaymentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			paymentdetail.Header = header;
			
			// TODO: should update paidflag in header if total balance = 0.
			
			// update daysummary
			DateTime daysummaryDay = Convert.ToDateTime(DateTime.Now.ToShortDateString());
			LaundryDaySummaryDataEntity daysummary = new LaundryDaySummaryDao().GetByDay(daysummaryDay);
			if(daysummary != null)
			{
				daysummary.TotalSales += paymentdetail.Amount;
				daysummary.DayStamp = daysummaryDay;		
			}
			LaundryDaySummaryDao dao = new LaundryDaySummaryDao();
			dao.SaveOrUpdate(daysummary);
			
			// update header, save payment detail etc.
			header.PaymentDetailEntities.Add(paymentdetail);
			LaundryDao ldao = new LaundryDao();
			ldao.Update(header);
			
		}
			
		[Test]
		public void getLaundryByID()
		{
			LaundryHeaderDataEntity header = new LaundryHeaderDataEntity();
			LaundryDao dao = new LaundryDao();
			header = dao.GetByID(1);
			
			Assert.NotNull(header);	
			Assert.AreEqual("John Doe", header.Customer.Name);
			
			foreach(LaundryDetailDataEntity detail in header.DetailEntities)
			{
				Console.WriteLine("service name: " + detail.Service.Name);
				Console.WriteLine("category name: " + detail.Category.Name);
				Console.WriteLine("itemqty: " + detail.ItemQty);
				Console.WriteLine("kilo: " + detail.Kilo);
				Console.WriteLine("amount: " + detail.Amount);
			}
			
		}
		
		[Test]
		public void getAllLaundryItems()
		{
			LaundryDao dao = new LaundryDao();
			IEnumerable<LaundryHeaderDataEntity> headers = dao.GetAllItems();
			
			Assert.NotNull(headers);	
			
			foreach(LaundryHeaderDataEntity header in headers)
			{
				Console.WriteLine("headerID: " + header.LaundryHeaderID);
				foreach(LaundryDetailDataEntity detail in header.DetailEntities)
				{
					Console.WriteLine("detailID: " + detail.ID);
					Console.WriteLine("service name: " + detail.Service.Name);
					Console.WriteLine("category name: " + detail.Category.Name);
					Console.WriteLine("itemqty: " + detail.ItemQty);
					Console.WriteLine("kilo: " + detail.Kilo);
					Console.WriteLine("amount: " + detail.Amount);
				}
				Console.WriteLine("================================");
			}
		}
	}
}

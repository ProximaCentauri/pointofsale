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
		public void saveNewHeaderWithoutExistingDaySummary(){			
			LaundryHeaderDataEntity header = new LaundryHeaderDataEntity();
			LaundryDetailDataEntity detail = new LaundryDetailDataEntity();
			LaundryJobChargesDataEntity jobcharge = new LaundryJobChargesDataEntity();
						
			LaundryCategoryDataEntity category = new LaundryCategoryDao().GetByName("Colored Garments");
			LaundryServiceDataEntity service = new LaundryServiceDao().GetByName("Wash - Dry - Fold");
			LaundryChargeDataEntity charge = new LaundryChargeDao().GetByName("Delivery");
			
			CustomerDao custdao = new CustomerDao();
			CustomerDataEntity customer = custdao.GetByName("John Doe");
			if(customer == null)
			{
				customer = new CustomerDataEntity();
				customer.Name = "John Doe";
				customer.Address = "Cebu";
				customer.ContactNumber = "111-1111";
			}
			
			header.Customer = customer;
			header.ReceivedDate = DateTime.Now;
			header.DueDate = DateTime.Now;
			header.ClaimFlag = false;
			header.PaidFlag = true;
			header.AmountDue = 1520.00M;
			
			detail.Header = header;
			detail.Category = category;
			detail.Service = service;
			detail.Amount = 23;
			detail.Kilo = 5;
						
			jobcharge.Charge = charge;
			jobcharge.Header = header;
			
			header.DetailEntities.Add(detail);
			header.JobChargeEntities.Add(jobcharge);
			
			LaundryDaySummaryDataEntity daysummary = new LaundryDaySummaryDataEntity();
			daysummary.DayStamp = Convert.ToDateTime("02/09/2013");
			daysummary.TotalSales = header.AmountDue;
			daysummary.TransCount = 1;
			daysummary.HeaderEntities.Add(header);
			
			header.DaySummary = daysummary;
			
			custdao.SaveOrUpdate(customer);
			LaundryDaySummaryDao dao = new LaundryDaySummaryDao();
			dao.Save(daysummary);
		}
		
		[Test]
		public void saveNewHeaderWithExistingDaySummary()
		{
			LaundryDaySummaryDao summarydao = new LaundryDaySummaryDao();
			LaundryDaySummaryDataEntity summary = summarydao.GetByDay(Convert.ToDateTime("2013-02-01 23:55:30"));
			if(summary!= null)
			{
				LaundryHeaderDataEntity header = new LaundryHeaderDataEntity();
				LaundryDetailDataEntity detail = new LaundryDetailDataEntity();
							
				LaundryCategoryDataEntity category = new LaundryCategoryDao().GetByName("Wash Dry Fold");
				LaundryServiceDataEntity service = new LaundryServiceDao().GetByName("Wash Dry Fold");
	
				CustomerDataEntity customer = new CustomerDataEntity();
				customer.Name = "John Doe";
				customer.Address = "Cebu";
				customer.ContactNumber = "111-1111";
			
				header.Customer = customer;
				header.ReceivedDate = DateTime.Now;
				header.DueDate = DateTime.Now;
				header.ClaimFlag = true;
				header.PaidFlag = true;
				header.AmountDue = 2322.00M;
				
				detail.Header = header;
				detail.Category = category;
				detail.Service = service;
				detail.Amount = 2333;
				detail.Kilo = 15;
							
				header.DetailEntities.Add(detail);
				
				summary.TransCount += 1;
				summary.TotalSales += detail.Amount;
				header.DaySummary = summary;
				
				LaundryDaySummaryDao dao = new LaundryDaySummaryDao();
				dao.Update(summary);
				
				LaundryDao ldao = new LaundryDao();
				ldao.Save(header);
			}				
		}
			
		[Test]
		public void getLaundryByID()
		{
			LaundryHeaderDataEntity header = new LaundryHeaderDataEntity();
			LaundryDao dao = new LaundryDao();
			header = dao.GetByID(3);
			
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

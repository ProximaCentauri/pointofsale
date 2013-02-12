/*
 * Created by SharpDevelop.
 * User: jl185099
 * Date: 2/7/2013
 * Time: 5:58 PM
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
using NJournals.Common.Interfaces;


namespace NJournals.Tests
{
	[TestFixture]
	public class ReportDaoTest
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
		public void getAllCustomersSalesReport(){
			LaundryReportDao reportDao = new LaundryReportDao();
			List<LaundryDaySummaryDataEntity> entities = reportDao.GetCustomerSalesReport(null,DateTime.Now.AddDays(-5),
				                                 DateTime.Now.AddDays(5), true)
				as List<LaundryDaySummaryDataEntity>;
			Assert.NotNull(entities);
			foreach(LaundryDaySummaryDataEntity entity in entities)
			{
				Console.WriteLine("daystamp: " + entity.DayStamp);
				Console.WriteLine("transcount: " + entity.TransCount);
				Console.WriteLine("sales: " + entity.TotalSales);
			}
		}
		
		[Test]
		public void getSpecificCustomerSalesReport(){
			CustomerDataEntity customer = new CustomerDao().GetByName("John Dee");
			LaundryReportDao reportDao = new LaundryReportDao();
			List<LaundryDaySummaryDataEntity> entities = 
				reportDao.GetCustomerSalesReport(customer, DateTime.Now.AddDays(-5),
				                                 DateTime.Now.AddDays(5), false)
				as List<LaundryDaySummaryDataEntity>;
			Assert.NotNull(entities);
			foreach(LaundryDaySummaryDataEntity entity in entities)
			{				
				Console.WriteLine("daystamp: " + entity.DayStamp);
				Console.WriteLine("transcount: " + entity.TransCount);
				
				Console.WriteLine("sales: " + entity.TotalSales);
			}
		}
		
		[Test]
		public void getUnclaimedItemsReport()
		{			
			LaundryReportDao reportDao = new LaundryReportDao();
			List<LaundryHeaderDataEntity> entities = 
				reportDao.GetUnclaimedItemsReport(null, DateTime.Now.AddDays(-5),
				                                 DateTime.Now.AddDays(5),true)
				as List<LaundryHeaderDataEntity>;
			Assert.NotNull(entities);
			foreach(LaundryHeaderDataEntity entity in entities)
			{				
				Console.WriteLine("daystamp: " + entity.ReceivedDate);
				Console.WriteLine("customer: " + entity.Customer.Name);
				Console.WriteLine("claimflag: " + entity.ClaimFlag);
				
				
			}
		}
		
		[Test]
		public void getInventoryReport()
		{
			RefillReportDao dao = new RefillReportDao();
			List<RefillInventoryReportDataEntity> entities = dao.GetInventoryReport(DateTime.Now.AddDays(-5),
			                                                                        DateTime.Now.AddDays(5)) as List<RefillInventoryReportDataEntity>;
			
			Assert.NotNull(entities);
			foreach(RefillInventoryReportDataEntity entity in entities)
			{				
				Console.WriteLine("daystamp: " + entity.DayStamp);
				Console.WriteLine("totalqty: " + entity.TotalQty);
				Console.WriteLine("added: " + entity.TotalAdded);
				
				
			}
		}
	}
}

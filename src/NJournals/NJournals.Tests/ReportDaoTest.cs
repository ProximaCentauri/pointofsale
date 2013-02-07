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
			List<LaundryDaySummaryDataEntity> entities = reportDao.GetAllCustomersSalesReport(Convert.ToDateTime("2013-02-01 00:00:00"), Convert.ToDateTime("2013-02-08 23:59:59"))
				as List<LaundryDaySummaryDataEntity>;
			Assert.NotNull(entities);
			foreach(LaundryDaySummaryDataEntity entity in entities)
			{
				Console.WriteLine("daystamp: " + entity.DayStamp);
				Console.WriteLine("transcount: " + entity.TransCount);
				Console.WriteLine("sales: " + entity.TotalSales);
			}
		}
	}
}

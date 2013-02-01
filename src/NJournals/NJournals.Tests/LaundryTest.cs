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
		public void saveLaundryOrder(){
			LaundryHeaderDataEntity header = new LaundryHeaderDataEntity();
			LaundryDetailDataEntity detail = new LaundryDetailDataEntity();
						
			LaundryCategoryDataEntity category = new LaundryCategoryDao().GetByName("Wash Dry Fold");
			LaundryServiceDataEntity service = new LaundryServiceDao().GetByName("Wash Dry Fold");

			header.CustomerName = "John Doe";
			header.ReceivedDate = DateTime.Now;
			header.DueDate = DateTime.Now;
			header.ClaimFlag = false;
			header.PaidFlag = true;
			header.AmountDue = 145.00;
			
			detail.HeaderEntity = header;
			detail.Category = category;
			detail.Service = service;
			detail.Amount = 29;
			detail.Kilo = 5;
						
			header.DetailEntities.Add(detail);
			
			
			LaundryDaySummaryDataEntity daysummary = new LaundryDaySummaryDataEntity();
			daysummary.DayStamp = DateTime.Now;
			daysummary.TotalSales = header.AmountDue;
			daysummary.TransCount = 1;
			daysummary.HeaderEntities.Add(header);
			
			header.DaySummary = daysummary;
			
			LaundryDao dao = new LaundryDao();
			dao.SaveOrUpdate(daysummary);
		}
		
		[Test]
		public void queryPriceScheme(){			
			List<LaundryPriceSchemeDataEntity> priceschemes = new LaundryPriceSchemeDao().GetAllItems() as List<LaundryPriceSchemeDataEntity>;
			Assert.NotNull(priceschemes);			
			foreach(LaundryPriceSchemeDataEntity pricescheme in priceschemes){								
				Console.WriteLine("Description: " + pricescheme.Description);
				Console.WriteLine("Service: " + pricescheme.Service.Name);
				Console.WriteLine("Category: " + pricescheme.Category.Name);
				Console.WriteLine("Price: " + pricescheme.Price);								
			}
			
		}
	}
}

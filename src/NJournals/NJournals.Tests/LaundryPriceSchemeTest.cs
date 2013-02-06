/*
 * Created by SharpDevelop.
 * User: jl185099
 * Date: 2/1/2013
 * Time: 2:07 PM
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
	public class LaundryPriceSchemeTest
	{
		[Test]
		public void Setup(){
			NHibernateHelper.OpenSession();
		}
		
		[Test]
		public void savePriceScheme(){
			LaundryPriceSchemeDataEntity entity = new LaundryPriceSchemeDataEntity();
            LaundryCategoryDataEntity category = new LaundryCategoryDao().GetByName("Colored Garments");
			LaundryServiceDataEntity service = new LaundryServiceDao().GetByName("Wash - Dry - Fold");
			entity.Category = category;
			entity.Service = service;
			entity.Description = "sample price scheme";
			entity.Price = 29.00;
			
			LaundryPriceSchemeDao dao = new LaundryPriceSchemeDao();
			dao.Save(entity);
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

        [Test]
        public void queryPriceScheme2()
        {
        	LaundryCategoryDataEntity category = new LaundryCategoryDao().GetByName("Colored Garments");
			LaundryServiceDataEntity service = new LaundryServiceDao().GetByName("Wash - Dry - Fold");
            LaundryPriceSchemeDataEntity pricescheme = new LaundryPriceSchemeDao().GetByCategoryService(service,category) as LaundryPriceSchemeDataEntity;
            Assert.NotNull(pricescheme);
            Console.WriteLine("Service: " + pricescheme.Service.Name);
            Console.WriteLine("Category: " + pricescheme.Category.Name);
            Console.WriteLine("Price: " + pricescheme.Price);
        }
	}
}

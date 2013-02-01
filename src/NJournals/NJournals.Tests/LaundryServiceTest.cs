/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 2/1/2013
 * Time: 11:50 AM
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
	/// <summary>
	/// Description of LaundryCategoryTests.
	/// </summary>
	[TestFixture]
	public class LaundryServiceTests
	{
		[Test]
		public void Setup(){
			NHibernateHelper.OpenSession();
		}
		
		[Test]
		public void saveCategory(){
			LaundryServiceDataEntity entity = new LaundryServiceDataEntity();			
			entity.Name = "Wash Dry Fold";
			entity.Description = "Wash and Burn";
			LaundryServiceDao dao = new LaundryServiceDao();
			dao.Save(entity);				
		}
		
		[Test]
		public void queryCategory(){
			List<LaundryServiceDataEntity> categories = new LaundryServiceDao().GetAllItems() as List<LaundryServiceDataEntity>;
			Assert.NotNull(categories);
			foreach(LaundryServiceDataEntity category in categories){
				Console.WriteLine("Name: " + category.Name);
				Console.WriteLine("Description: " + category.Description);
			}
		}
	}
}

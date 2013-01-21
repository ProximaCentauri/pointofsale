/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 1/21/2013
 * Time: 5:18 PM
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
	/// Description of ItemCategoryTest.
	/// </summary>
	/// 
	[TestFixture]
	public class ItemCategoryTest
	{
		[Test]
		public void Setup(){
			NHibernateHelper.OpenSession();
		}
		
		[Test]
		public void saveCategory(){
			ItemCategoryDataEntity entity = new ItemCategoryDataEntity();			
			entity.CategoryName = "Medicine";
			ItemCategoryDao dao = new ItemCategoryDao();
			dao.Save(entity);				
		}
		
		[Test]
		public void queryCategory(){
			List<ItemCategoryDataEntity> categories = new ItemCategoryDao().GetAllItems() as List<ItemCategoryDataEntity>;
			Assert.NotNull(categories);
			foreach(ItemCategoryDataEntity category in categories){
				Console.WriteLine(category.CategoryName);
			}
		}
	}
}

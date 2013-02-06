/*
 * Created by SharpDevelop.
 * User: jl185099
 * Date: 1/31/2013
 * Time: 8:08 PM
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
	public class LaundryCategoryTests
	{
		[Test]
		public void Setup(){
			NHibernateHelper.OpenSession();
		}
		
		[Test]
		public void saveCategory(){
			LaundryCategoryDataEntity entity = new LaundryCategoryDataEntity();			
			entity.Name = "Wash Dry Fold";
			entity.Description = "Wash and Burn";
			LaundryCategoryDao dao = new LaundryCategoryDao();
			dao.Save(entity);				
			
			entity = new LaundryCategoryDataEntity();
			entity.Name = "Wash Dry Press";
			entity.Description = "Wash Dry Press";
			
			dao.Save(entity);
		}
		
		[Test]
		public void queryCategory(){
			List<LaundryCategoryDataEntity> categories = new LaundryCategoryDao().GetAllItems() as List<LaundryCategoryDataEntity>;
			Assert.NotNull(categories);
			foreach(LaundryCategoryDataEntity category in categories){
				Console.WriteLine("Name: " + category.Name);
				Console.WriteLine("Description: " + category.Description);
			}
		}
	}
}

/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 1/21/2013
 * Time: 5:20 PM
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
	/// Description of ItemTest.
	/// </summary>
	/// 
	[TestFixture]
	public class ItemTest
	{
		[Test]
		public void Setup(){
			NHibernateHelper.OpenSession();
		}	
		
		[Test]
		public void saveItem(){					
			ItemCategoryDataEntity category = new ItemCategoryDao().GetByName("Medicine");			
			ItemGenericDataEntity generic = new ItemGenericDao().GetByName("Paracetamol");
			ItemDataEntity entity = new ItemDataEntity();
			entity.Barcode = "12323";
			entity.BuyPrice = 12.33;
			entity.Name = "Biogesic";
			entity.Category = category;
			entity.Generic = generic;
			entity.SellPrice = 3939.33;
			entity.Rack = "a1";
			new ItemDao().Save(entity);			
		}
		
		[Test]
		public void queryItem(){
			List<ItemDataEntity> entities = new ItemDao().GetAllItems() as List<ItemDataEntity>;
			Assert.NotNull(entities);
			foreach(ItemDataEntity entity in entities){
				Console.WriteLine(entity.Name);
			}	
		}
		
		[Test]
		public void queryByName(){
			ItemDataEntity entity = new ItemDao().GetByName("Biogesic");
			Console.WriteLine(entity.Barcode);
		}
		
		[Test]
		public void sample(){
			string startupPath = System.IO.Directory.GetCurrentDirectory() + "\\images\\add2.png";
			Console.WriteLine(startupPath);
				
		}
	}
}

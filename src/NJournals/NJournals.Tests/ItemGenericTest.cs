/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 1/21/2013
 * Time: 5:19 PM
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
	/// Description of ItemGenericTest.
	/// </summary>
	/// 
	[TestFixture]
	public class ItemGenericTest
	{
		[Test]
		public void Setup(){
			NHibernateHelper.OpenSession();
		}
		
		[Test]
		public void saveGeneric(){
			ItemGenericDataEntity entity = new ItemGenericDataEntity();
			entity.GenericName = "Ibuprofen";
			new ItemGenericDao().Save(entity);
		}
		
		
	}
}

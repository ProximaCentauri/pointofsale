/*
 * Created by SharpDevelop.
 * User: matt
 * Date: 2/2/2013
 * Time: 3:34 PM
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
	public class LaundryDaySummaryTest
	{		
		ILaundryDaySummaryDao daysummaryDao;
		[Test]
		public void Setup(){
			NHibernateHelper.OpenSession();
			daysummaryDao = new LaundryDaySummaryDao();
		}
		
		[Test]
		public void saveNewDaysummary(){
			LaundryDaySummaryDataEntity daysummary = new LaundryDaySummaryDataEntity();
			
		}
		
	}
}

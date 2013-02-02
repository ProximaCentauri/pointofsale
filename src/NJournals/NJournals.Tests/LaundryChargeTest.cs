/*
 * Created by SharpDevelop.
 * User: matt
 * Date: 2/2/2013
 * Time: 3:19 PM
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
	public class LaundryChargeTest
	{		
		ILaundryChargeDao chargeDao;
		[Test]
		public void Setup(){
			NHibernateHelper.OpenSession();
			chargeDao = new LaundryChargeDao();
		}
		
		[Test]
		public void saveNewCharge(){
			chargeDao = new LaundryChargeDao();
			LaundryChargeDataEntity charge = new LaundryChargeDataEntity();
			charge.Name = "Pickup";
			charge.Amount = 10.00;
			chargeDao.Save(charge);
			charge = new LaundryChargeDataEntity();
			charge.Name = "Deliver";
			charge.Amount = 20.00;
			chargeDao.Save(charge);
		}
		
		[Test]
		public void getAllCharges(){
			chargeDao = new LaundryChargeDao();
			IList<LaundryChargeDataEntity> charges = chargeDao.GetAllItems() as List<LaundryChargeDataEntity>;
			Assert.AreEqual(2, charges.Count);
			foreach(LaundryChargeDataEntity charge in charges){
				Console.WriteLine(charge.Name);
			}
		}
	}
}

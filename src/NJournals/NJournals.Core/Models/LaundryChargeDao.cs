/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 1/31/2013
 * Time: 11:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NJournals.Common;
using NJournals.Common.Util;
using System.Linq;
using System.Text;
using NHibernate.Linq;
using System.Collections.Generic;
using NJournals.Common.Interfaces;
using NJournals.Common.DataEntities;

namespace NJournals.Core.Models
{
	/// <summary>
	/// Description of LaundryChargesDao.
	/// </summary>
	public class LaundryChargeDao : ILaundryChargeDao
	{
		public LaundryChargeDao()
		{
		}
		
		public void Save(LaundryChargeDataEntity p_charge)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Save(p_charge);
					transaction.Commit();
				}
			}
		}
		
		public IEnumerable<LaundryChargeDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = (from LaundryCharges in session.Query<LaundryChargeDataEntity>()
				             select LaundryCharges);
				return query.ToList();
			}
		}
		
		public LaundryChargeDataEntity GetByName(string p_name)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = (from LaundryCharges in session.Query<LaundryChargeDataEntity>()
				             where LaundryCharges.Name == p_name
				             select LaundryCharges).FirstOrDefault();
				return query;
			}
		}
		
		public void Delete(LaundryChargeDataEntity p_charge)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Delete(p_charge);
					transaction.Commit();
				}
			}
		}
		
		public void Update(LaundryChargeDataEntity p_charge)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Update(p_charge);
					transaction.Commit();
				}
			}
		}
	}
}

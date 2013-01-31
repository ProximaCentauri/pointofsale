/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 1/31/2013
 * Time: 11:47 PM
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
	/// Description of LaundryServiceDao.
	/// </summary>
	public class LaundryServiceDao : ILaundryServiceDao
	{
		public LaundryServiceDao()
		{
		}
		
		public void Save(LaundryServiceDataEntity p_service)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Save(p_service);
					transaction.Commit();
				}
			}
		}
		
		public IEnumerable<LaundryServiceDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = (from LaundryServices in session.Query<LaundryServiceDataEntity>()
				             select LaundryServices);
				return query.ToList();
			}
		}
		
		public LaundryServiceDataEntity GetByName(string p_name)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = (from LaundryServices in session.Query<LaundryServiceDataEntity>()
				             where LaundryServices.Name == p_name
				             select LaundryServices).FirstOrDefault();
				return query;
			}
		}
		
		public void Delete(LaundryServiceDataEntity p_service)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Delete(p_service);
					transaction.Commit();
				}
			}
		}
		
		public void Update(LaundryServiceDataEntity p_service)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Update(p_service);
					transaction.Commit();
				}
			}
		}
	}
}

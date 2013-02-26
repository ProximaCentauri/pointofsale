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
					try
					{
						session.SaveOrUpdate(p_service);
						transaction.Commit();
					}					
					catch(Exception ex)
					{
						transaction.Rollback();
						throw ex;
					}		
				}
			}
		}
		
		public IEnumerable<LaundryServiceDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
                var query = session.Query<LaundryServiceDataEntity>()
                    .OrderBy(x => x.Name)
                    .ToList();
                return query;
			}
		}
		
		public LaundryServiceDataEntity GetByName(string p_name)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
                var query = session.Query<LaundryServiceDataEntity>()
                    .Where(x => x.Name == p_name)
                    .SingleOrDefault();
				return query;
			}
		}
		
		public LaundryServiceDataEntity GetById(int p_id)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
                var query = session.Query<LaundryServiceDataEntity>()
                    .Where(x => x.ServiceID == p_id)
                    .SingleOrDefault();
				return query;
			}
		}
		
		public void Delete(LaundryServiceDataEntity p_service)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.Delete(p_service);
						transaction.Commit();
					}
					catch(Exception ex)
					{
						transaction.Rollback();
						throw ex;
					}		
				}
			}
		}
		
		public void Update(LaundryServiceDataEntity p_service)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.Update(p_service);
						transaction.Commit();
					}
					catch(Exception ex)
					{
						transaction.Rollback();
						throw ex;
					}		
				}
			}
		}
	}
}

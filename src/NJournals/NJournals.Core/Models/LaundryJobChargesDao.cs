/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 2/13/2013
 * Time: 11:36 AM
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
	/// Description of LaundryJobChargesDao.
	/// </summary>
	public class LaundryJobChargesDao : ILaundryJobChargesDao
	{
		
		public LaundryJobChargesDao()
		{
		}
		
		public void SaveOrUpdate(LaundryJobChargesDataEntity p_checklist)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.SaveOrUpdate(p_checklist);
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
		
		public IEnumerable<LaundryJobChargesDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
                var query = session.Query<LaundryJobChargesDataEntity>()
                    .OrderBy(x => x.ID)
                    .ToList();
                return query;
			}
		}
		
		public IEnumerable<LaundryJobChargesDataEntity> GetAllItemsByHeaderId(int p_id)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
                var query = session.Query<LaundryJobChargesDataEntity>()
                	.Where(x => x.Header.LaundryHeaderID == p_id)
                    .OrderBy(x => x.ID)
                    .ToList();
                return query;
			}
		}
		
		public LaundryJobChargesDataEntity GetByID(int p_id)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
                var query = session.Query<LaundryJobChargesDataEntity>()
                    .Where(x => x.ID == p_id)
                    .SingleOrDefault();
				return query;
			}
		}
		
		public void Delete(LaundryJobChargesDataEntity p_jobcharge)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.Delete(p_jobcharge);
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
		
		public void Update(LaundryJobChargesDataEntity p_jobcharge)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.Update(p_jobcharge);
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

/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 2/28/2013
 * Time: 10:49 PM
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
	/// Description of RefillInventoryDetailDao.
	/// </summary>
	public class RefillInventoryDetailDao : IRefillInventoryDetailDao
	{
		public RefillInventoryDetailDao()
		{
		}
		
		public void SaveOrUpdate(RefillInventoryDetailDataEntity p_inventory)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.SaveOrUpdate(p_inventory);
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
		
		public IEnumerable<RefillInventoryDetailDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = session.Query<RefillInventoryDetailDataEntity>()
                    .OrderBy(x => x.ID)
                    .ToList();
                return query;
			}
		}
		
		public RefillInventoryDetailDataEntity GetById(int p_id)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
                var query = session.Query<RefillInventoryDetailDataEntity>()
                	.Where(x => x.ID == p_id)
                	.FirstOrDefault();
                   	
				return query;
			}
		}
		
		
		public RefillInventoryDetailDataEntity GetDetailDay(RefillInventoryHeaderDataEntity p_header, DateTime p_dayStamp)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
                var query = session.QueryOver<RefillInventoryDetailDataEntity>()
                	.Where(x => x.Header == p_header)
                	.And(x => x.Date == p_dayStamp)
                	.SingleOrDefault();
                   	
				return query;
			}
		}
		
		public void Delete(RefillInventoryDetailDataEntity p_inventory)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.Delete(p_inventory);
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
		
		public void Update(RefillInventoryDetailDataEntity p_inventory	)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Update(p_inventory);
					transaction.Commit();
				}
			}
		}
	}
}

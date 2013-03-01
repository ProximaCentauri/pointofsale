/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/9/2013
 * Time: 12:46 PM
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
	/// Description of RefillInventoryDao.
	/// </summary>
	public class RefillInventoryDao : IRefillInventoryDao
	{
		public RefillInventoryDao()
		{
		}
		
		public void SaveOrUpdate(RefillInventoryHeaderDataEntity p_inventory)
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
		
		public IEnumerable<RefillInventoryHeaderDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = session.Query<RefillInventoryHeaderDataEntity>()
                    .OrderBy(x => x.Name)
                    .ToList();
                return query;
			}
		}
		
		public RefillInventoryHeaderDataEntity GetByName(string p_name)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
                var query = session.Query<RefillInventoryHeaderDataEntity>()
                	.Where(x => x.Name.ToUpper().Contains(p_name.ToUpper()))
                	.FirstOrDefault();
                   	
				return query;
			}
		}
						
		public void Delete(RefillInventoryHeaderDataEntity p_inventory)
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
		
		public void Update(RefillInventoryHeaderDataEntity p_inventory	)
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

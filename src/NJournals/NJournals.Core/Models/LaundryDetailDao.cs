/*
 * Created by SharpDevelop.
 * User: matt
 * Date: 2/17/2013
 * Time: 8:42 PM
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
	/// Description of LaundryDetailDao.
	/// </summary>
	public class LaundryDetailDao : ILaundryDetailDao
	{
		public LaundryDetailDao()
		{
		}
		public void SaveOrUpdate(LaundryDetailDataEntity p_detail)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.SaveOrUpdate(p_detail);
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
		
		public IEnumerable<LaundryDetailDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = session.Query<LaundryDetailDataEntity>()
                    .OrderBy(x => x.ID)
                    .ToList();
                return query;
			}
		}
		
		public IEnumerable<LaundryDetailDataEntity> GetAllItemsByHeaderId(int p_id)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = session.Query<LaundryDetailDataEntity>()
					.Where(x => x.Header.LaundryHeaderID == p_id)
                    .OrderBy(x => x.ID)
                    .ToList();
                return query;
			}
		}
		
		public void Delete(LaundryDetailDataEntity p_detail)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.Delete(p_detail);
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
		
		public void Update(LaundryDetailDataEntity p_detail)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.Update(p_detail);
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

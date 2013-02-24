/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/2/2013
 * Time: 12:41 PM
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
	/// Description of RefillDaySummaryDao.
	/// </summary>
	public class RefillDaySummaryDao : IRefillDaySummaryDao
	{
		public RefillDaySummaryDao()
		{
		}
		
		public void SaveOrUpdate(RefillDaySummaryDataEntity p_daysummary)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.SaveOrUpdate(p_daysummary);
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
		
		
		public RefillDaySummaryDataEntity GetByDay(DateTime p_day)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					var query = session.Query<RefillDaySummaryDataEntity>()
						.Where(x => x.DayStamp == p_day)
						.SingleOrDefault();
					return query;
				}
			}
		}
		
		public RefillDaySummaryDataEntity GetByDayId(int p_id)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					var query = session.Query<RefillDaySummaryDataEntity>()
						.Where(x => x.DayID == p_id)
						.SingleOrDefault();
					return query;
				}
			}
		}
		
		public IEnumerable<RefillDaySummaryDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
                var query = session.Query<RefillDaySummaryDataEntity>()
                    .ToList();
                return query;
			}
		}
		
		public void Update(RefillDaySummaryDataEntity p_daysummary)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{					
					try
					{
						session.Update(p_daysummary);
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
		
		public void Delete(RefillDaySummaryDataEntity p_daysummary)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.Delete(p_daysummary);
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

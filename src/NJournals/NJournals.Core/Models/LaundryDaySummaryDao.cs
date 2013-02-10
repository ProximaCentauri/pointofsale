/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/2/2013
 * Time: 12:06 AM
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
	/// Description of LaundryDaySummaryDao.
	/// </summary>
	public class LaundryDaySummaryDao : ILaundryDaySummaryDao
	{
		public LaundryDaySummaryDao()
		{
		}
		
		public void SaveOrUpdate(LaundryDaySummaryDataEntity p_daysummary)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.SaveOrUpdate(p_daysummary);
					transaction.Commit();
				}
			}
		}
		
		
		public LaundryDaySummaryDataEntity GetByDay(DateTime p_day)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					var query = session.Query<LaundryDaySummaryDataEntity>()
						.Where(x => x.DayStamp == p_day)
						.SingleOrDefault();
					return query;
				}
			}
		}
		
		public IEnumerable<LaundryDaySummaryDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
                var query = session.Query<LaundryDaySummaryDataEntity>()
                    .ToList();
                return query;
			}
		}
		
		public void Update(LaundryDaySummaryDataEntity p_daysummary)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Update(p_daysummary);
					transaction.Commit();
				}
			}
		}
		
		public void Delete(LaundryDaySummaryDataEntity p_daysummary)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Delete(p_daysummary);
					transaction.Commit();
				}
			}
		}
	}
}

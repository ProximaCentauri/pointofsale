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
		
		public void Save(RefillDaySummaryDataEntity p_daysummary)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Save(p_daysummary);
					transaction.Commit();
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
						.Single();
					return query;
				}
			}
		}
		
		public IEnumerable<RefillDaySummaryDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = (from RefillDaySummary in session.Query<RefillDaySummaryDataEntity>()
				             select RefillDaySummary);
				return query.ToList();
			}
		}
		
		public void Update(RefillDaySummaryDataEntity p_daysummary)
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
		
		public void Delete(RefillDaySummaryDataEntity p_daysummary)
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

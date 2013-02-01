/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/1/2013
 * Time: 1:07 AM
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
	/// Description of LaundryDao.
	/// </summary>
	public class LaundryDao : ILaundryDao
	{
		public LaundryDao()
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
		
		public LaundryHeaderDataEntity GetLaundryByID(int p_headerID)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					var query = session.Query<LaundryHeaderDataEntity>()
						.Where(x => x.LaundryHeaderID == p_headerID)
						.FetchMany(x => x.DetailEntities)
						.ToFuture();
					return query.Single();
				}
			}
		}
		
		public IEnumerable<LaundryHeaderDataEntity> GetAllLaundryItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					var query = session.Query<LaundryHeaderDataEntity>()
						.FetchMany(x => x.DetailEntities)
						.ToFuture();
					return query;
				}
			}
		}
		
		public IEnumerable<LaundryDaySummaryDataEntity> GetAllDaySummary()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					var query = (from LaundryDaySummary in session.Query<LaundryDaySummaryDataEntity>()
				             select LaundryDaySummary);
						return query.ToList();
				}
			}
		}
		
		public void DeleteLaundry(LaundryHeaderDataEntity p_header)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Delete(p_header);
					transaction.Commit();
				}
			}
		}
	
		public void DeleteDaySummary(LaundryDaySummaryDataEntity p_daysummary)
		{
			using (var session = NHibernateHelper.OpenSession())
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

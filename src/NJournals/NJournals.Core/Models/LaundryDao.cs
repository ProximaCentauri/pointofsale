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
		
		public void Save(LaundryDaySummaryDataEntity p_daysummary)
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
		
//		public IEnumerable<LaundryHeaderDataEntity> GetAllItems()
//		{
//			using(var session = NHibernateHelper.OpenSession())
//			{
//				var query = (from LaundryHeader in session.Query<LaundryHeaderDataEntity>()
//				             select LaundryHeader);
//				return query.ToList();
//			}
//		}
//		
//		public LaundryHeaderDataEntity GetByID(int p_headerID)
//		{
//			using(var session = NHibernateHelper.OpenSession())
//			{
//				var query = (from LaundryHeader in session.Query<LaundryHeaderDataEntity>()
//				             where LaundryHeader.LaundryHeaderID == p_headerID
//				             select LaundryHeader).FirstOrDefault();
//				return query;
//			}
//		}
//		
//		public void Delete(LaundryHeaderDataEntity p_header)
//		{
//			using(var session = NHibernateHelper.OpenSession())
//			{
//				using(var transaction = session.BeginTransaction())
//				{
//					session.Delete(p_header);
//					transaction.Commit();
//				}
//			}
//		}
//		
//		public void Update(LaundryHeaderDataEntity p_header)
//		{
//			using(var session = NHibernateHelper.OpenSession())
//			{
//				using(var transaction = session.BeginTransaction())
//				{
//					session.Update(p_header);
//					transaction.Commit();
//				}
//			}
//		}
	}
}

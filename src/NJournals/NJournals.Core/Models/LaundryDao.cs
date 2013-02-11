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
		
		public void SaveOrUpdate(LaundryHeaderDataEntity p_header)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.SaveOrUpdate(p_header);
					transaction.Commit();
				}
			}
		}
		
		
		public LaundryHeaderDataEntity GetByID(int p_headerID)
		{
			using(var session = NHibernateHelper.OpenSession())			
			{
				using(var transaction = session.BeginTransaction())
				{
					var query = session.Query<LaundryHeaderDataEntity>()						
						.Where(x => x.LaundryHeaderID == p_headerID)
						.FetchMany(x => x.DetailEntities)																		
						.SingleOrDefault();
					return query;
				}
			}
		}
		
		public IEnumerable<LaundryHeaderDataEntity> GetByCustomer(CustomerDataEntity customer)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					var query = session.Query<LaundryHeaderDataEntity>()
					    .Where(x => x.Customer == customer)
						.FetchMany(x => x.DetailEntities)
						.ToList();
					return query;
				}
			}
		}
		
		public IEnumerable<LaundryHeaderDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					var query = session.Query<LaundryHeaderDataEntity>()
						.FetchMany(x => x.DetailEntities)
						.ToList();
					return query;
				}
			}
		}
		
		public void Update(LaundryHeaderDataEntity p_header)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Update(p_header);
					transaction.Commit();
				}
			}
		}
		
		public void Delete(LaundryHeaderDataEntity p_header)
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

	}
}

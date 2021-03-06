﻿/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/2/2013
 * Time: 1:31 PM
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
	/// Description of RefillDao.
	/// </summary>
	public class RefillDao : IRefillDao
	{
		public RefillDao()
		{
		}
		
		public void SaveOrUpdate(RefillHeaderDataEntity p_header)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.SaveOrUpdate(p_header);
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
		
		
		public RefillHeaderDataEntity GetByID(int p_headerID)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					var query = session.Query<RefillHeaderDataEntity>()
						.Where(x => x.RefillHeaderID == p_headerID)
						.FetchMany(x => x.DetailEntities)
						.SingleOrDefault();
					return query;
				}
			}
		}
		
		public IEnumerable<RefillHeaderDataEntity> GetByCustomer(CustomerDataEntity customer)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					var query = session.Query<RefillHeaderDataEntity>()
					    .Where(x => x.Customer == customer)
						.FetchMany(x => x.DetailEntities)
						.ToList();
					return query;
				}
			}
		}
		
		
		public IEnumerable<RefillHeaderDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					var query = session.Query<RefillHeaderDataEntity>()
						.FetchMany(x => x.DetailEntities)
						.ToList();
					return query;
				}
			}
		}
		
		public void Update(RefillHeaderDataEntity p_header)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.Update(p_header);
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
		
		public void Delete(RefillHeaderDataEntity p_header)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.Delete(p_header);
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

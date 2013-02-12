﻿/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/10/2013
 * Time: 10:10 PM
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
	/// Description of RefillCustomerInventoryDao.
	/// </summary>
	public class RefillCustomerInventoryDao : IRefillCustomerInventoryDao
	{
		public RefillCustomerInventoryDao()
		{
		}
		
		public void SaveOrUpdate(RefillCustomerInventoryDataEntity p_custinv)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.SaveOrUpdate(p_custinv);
					transaction.Commit();
				}
			}
		}
		
		public IEnumerable<RefillCustomerInventoryDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = session.Query<RefillCustomerInventoryDataEntity>()
                    .OrderBy(x => x.Customer)
                    .ToList();
                return query;
			}
		}
		
		public RefillCustomerInventoryDataEntity GetByCustomer(CustomerDataEntity customer)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
                var query = session.Query<RefillCustomerInventoryDataEntity>()
                    .Where(x => x.Customer == customer)
                    .SingleOrDefault();
				return query;
			}
		}
		
		public void Delete(RefillCustomerInventoryDataEntity p_custinv)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Delete(p_custinv);
					transaction.Commit();
				}
			}
		}
		
		public void Update(RefillCustomerInventoryDataEntity p_custinv)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Update(p_custinv);
					transaction.Commit();
				}
			}
		}
	}
}
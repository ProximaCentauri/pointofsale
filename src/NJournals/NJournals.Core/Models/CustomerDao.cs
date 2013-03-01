/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/5/2013
 * Time: 8:40 AM
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
	/// Description of CustomerDao.
	/// </summary>
	public class CustomerDao : ICustomerDao
	{
		public CustomerDao()
		{
		}
		
		public void SaveOrUpdate(CustomerDataEntity p_customer)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.SaveOrUpdate(p_customer);
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
		
		
		public CustomerDataEntity GetByName(string p_name)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
                    var query = session.Query<CustomerDataEntity>()
                        .Where(x => x.Name == p_name)
                        .SingleOrDefault();
					return query;
				}
			}
		}
		
		public IEnumerable<CustomerDataEntity> GetCustomersByName(string p_name)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
                    var query = session.Query<CustomerDataEntity>()
                    	.Where(x => (x.Name.Contains(p_name) && x.VoidFlag == false))
                    	.ToList();
					return query;
				}
			}
		}
		
		public IEnumerable<CustomerDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
                var query = session.Query<CustomerDataEntity>()
                	.Where(x => x.VoidFlag == false)
                	.OrderBy(x => x.Name)
                    .ToList();
                return query;
			}
		}
		
		public void Update(CustomerDataEntity p_customer)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.Update(p_customer);
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
		
		public void Delete(CustomerDataEntity p_customer)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.Delete(p_customer);
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

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
					session.SaveOrUpdate(p_customer);
					transaction.Commit();
				}
			}
		}
		
		
		public CustomerDataEntity GetByName(string p_name)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					var query = (from Customer in session.Query<CustomerDataEntity>()
				             where Customer.Name == p_name
				             select Customer).FirstOrDefault();
					return query;
				}
			}
		}
		
		public IEnumerable<CustomerDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = (from Customer in session.Query<CustomerDataEntity>()
				             select Customer);
				return query.ToList();
			}
		}
		
		public void Update(CustomerDataEntity p_customer)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Update(p_customer);
					transaction.Commit();
				}
			}
		}
		
		public void Delete(CustomerDataEntity p_customer)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Delete(p_customer);
					transaction.Commit();
				}
			}
		}
	}
}

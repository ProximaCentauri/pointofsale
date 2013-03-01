/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 3/1/2013
 * Time: 3:13 PM
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
	/// Description of CompanyDao.
	/// </summary>
	public class CompanyDao : ICompanyDao
	{
		public CompanyDao()
		{
		}
		
		public void SaveOrUpdate(CompanyDataEntity p_company)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.SaveOrUpdate(p_company);
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
		
		
		public CompanyDataEntity GetByName(string p_name)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
                    var query = session.Query<CompanyDataEntity>()
                        .Where(x => x.Name == p_name)
                        .SingleOrDefault();
					return query;
				}
			}
		}
		
		
		public IEnumerable<CompanyDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
                var query = session.Query<CompanyDataEntity>()
                	.Where(x => x.VoidFlag == false)
                	.OrderBy(x => x.Name)
                    .ToList();
                return query;
			}
		}
		
		public void Update(CompanyDataEntity p_company)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.Update(p_company);
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
		
		public void Delete(CompanyDataEntity p_company)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.Delete(p_company);
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

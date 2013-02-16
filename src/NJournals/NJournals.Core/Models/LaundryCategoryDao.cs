/*
 * Created by SharpDevelop.
 * User: jl185099
 * Date: 1/31/2013
 * Time: 8:02 PM
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
	/// Description of LaundryCategoryDao.
	/// </summary>
	public class LaundryCategoryDao : ILaundryCategoryDao
	{
		public LaundryCategoryDao()
		{
		}
		
		public void Save(LaundryCategoryDataEntity p_category)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.SaveOrUpdate(p_category);
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
		
		public IEnumerable<LaundryCategoryDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
                var query = session.Query<LaundryCategoryDataEntity>()
                    .OrderBy(x => x.Name)
                    .ToList();
                return query;
			}
		}
		
		public LaundryCategoryDataEntity GetByName(string p_name)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
                var query = session.Query<LaundryCategoryDataEntity>()
                    .Where(x => x.Name == p_name)
                    .OrderBy(x => x.Name)
                    .SingleOrDefault();
				return query;
			}
		}
		
		public LaundryCategoryDataEntity GetById(int p_id)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
                var query = session.Query<LaundryCategoryDataEntity>()
                    .Where(x => x.CategoryID == p_id)
                    .OrderBy(x => x.Name)
                    .SingleOrDefault();
				return query;
			}
		}
		
		public void Delete(LaundryCategoryDataEntity p_category)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.Delete(p_category);
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
		
		public void Update(LaundryCategoryDataEntity p_category)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.Update(p_category);
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

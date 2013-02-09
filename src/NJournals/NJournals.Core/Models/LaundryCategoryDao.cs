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
					session.SaveOrUpdate(p_category);
					transaction.Commit();
				}
			}
		}
		
		public IEnumerable<LaundryCategoryDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = (from LaundryCategory in session.Query<LaundryCategoryDataEntity>()
				             select LaundryCategory);
				if(query != null)
					return query.ToList();
				else
					return null;
			}
		}
		
		public LaundryCategoryDataEntity GetByName(string p_name)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = (from LaundryCategory in session.Query<LaundryCategoryDataEntity>()
				             where LaundryCategory.Name == p_name
				             select LaundryCategory).FirstOrDefault();
				return query;
			}
		}
		
		public void Delete(LaundryCategoryDataEntity p_category)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Delete(p_category);
					transaction.Commit();
				}
			}
		}
		
		public void Update(LaundryCategoryDataEntity p_category)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Update(p_category);
					transaction.Commit();
				}
			}
		}
	}
}

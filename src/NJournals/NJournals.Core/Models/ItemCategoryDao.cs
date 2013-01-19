/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 1/19/2013
 * Time: 9:53 PM
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
	/// Description of ItemCategoryDao.
	/// </summary>
	public class ItemCategoryDao : IItemCategoryDao
	{
		public ItemCategoryDao()
		{
			
		}
		
		public void Save(ItemCategoryDataEntity p_category)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Save(ItemCategoryDataEntity);
					transaction.Commit;
				}
			}
		}
		
		public IEnumerable<ItemCategoryDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = (from CategoryInfo in session.Query<ItemCategoryDataEntity>()
				             select CategoryInfo);
				return query.AsEnumerable();
			}
		}
		
		public ItemCategoryDataEntity GetByName(string p_name)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = (from CategoryInfo in session.Query<ItemCategoryDataEntity>()
				             where CategoryInfo.CategoryName = p_name
				             select CategoryInfo);
				return query;
			}
		}
		
		public void Delete(ItemCategoryDataEntity p_category)
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
		
		public void Update(ItemCategoryDataEntity p_category)
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

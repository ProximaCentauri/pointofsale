/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 1/20/2013
 * Time: 11:59 AM
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
	/// Description of ItemGenericDao.
	/// </summary>
	public class ItemGenericDao
	{
		public ItemGenericDao()
		{
		}
		
		public void Save(ItemGenericDataEntity p_generic)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Save(p_generic);
					transaction.Commit();
				}
			}
		}
		
		public IEnumerable<ItemGenericDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = (from GenericInfo in session.Query<ItemGenericDataEntity>()
				             select GenericInfo);
				return query.AsEnumerable();
			}
		}
		
		public ItemGenericDataEntity GetByName(string p_name)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = (from GenericInfo in session.Query<ItemGenericDataEntity>()
				             where GenericInfo.GenericName == p_name
				             select GenericInfo).Single();
				return query;
			}
		}
		
		public void Delete(ItemGenericDataEntity p_generic)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Delete(p_generic);
					transaction.Commit();
				}
			}
		}
		
		public void Update(ItemGenericDataEntity p_generic)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Update(p_generic);
					transaction.Commit();
				}
			}
		}
	}
}

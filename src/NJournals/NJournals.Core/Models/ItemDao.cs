/*
 * Created by SharpDevelop.
 * User: matt
 * Date: 1/19/2013
 * Time: 10:12 AM
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
	/// Description of ItemDao.
	/// </summary>
	public class ItemDao : IItemDao
	{
		public ItemDao()
		{
			
		}
		
		public void Save(ItemDataEntity p_item)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Save(p_item);
					transaction.Commit();
				}
			}
		}
		
		public IEnumerable<ItemDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = session.Query<ItemDataEntity>()
					.Fetch(x => x.Category)
					.Fetch(x => x.Generic)
					.ToList();
	
				return query;
			}
		}
		
		public ItemDataEntity GetByBarcode(string p_barcode)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = session.Query<ItemDataEntity>()
					.Where(x => x.Barcode == p_barcode)
					.Fetch(x => x.Category)
					.Fetch(x => x.Generic)
					.Single();
	
				return query;
			}
		}
		
		public ItemDataEntity GetByName(string p_name)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = session.Query<ItemDataEntity>()
					.Where(x => x.Name == p_name)
					.Fetch(x => x.Category)
					.Fetch(x => x.Generic)
					.FirstOrDefault();
	
				return query;
			}
		}
		
		public IEnumerable<ItemDataEntity> GetByCategory(string p_category)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = session.Query<ItemDataEntity>()					
					.Fetch(x => x.Category)
					.Where(x => x.Category.CategoryName == p_category)
					.Fetch(x => x.Generic)
					.ToList();
	
				return query;
			}
		}
		
		public IEnumerable<ItemDataEntity> GetByGeneric(string p_generic)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = session.Query<ItemDataEntity>()
					.Fetch(x => x.Generic)
					.Where(x => x.Generic.GenericName == p_generic)
					.Fetch(x => x.Category)
					.ToList();
				return query;
			}
		}
		
		public IEnumerable<ItemDataEntity> GetByDescription(string p_desc)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = session.Query<ItemDataEntity>()
					.Where(x => x.Description == p_desc)
					.Fetch(x => x.Category)
					.Fetch(x => x.Generic)
					.ToList();
	
				return query;
			}
		}
		
		public void Delete(ItemDataEntity p_item)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Delete(p_item);
					transaction.Commit();
				}
			}
		}
		
		public void Update(ItemDataEntity p_item)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Update(p_item);
					transaction.Commit();
				}
			}
		}
	}
}

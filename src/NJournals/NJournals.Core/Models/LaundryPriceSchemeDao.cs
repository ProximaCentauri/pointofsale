/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/1/2013
 * Time: 12:26 AM
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
	/// Description of LaundryPriceSchemeDao.
	/// </summary>
	public class LaundryPriceSchemeDao : ILaundryPriceSchemeDao
	{
		public LaundryPriceSchemeDao()
		{
		}
		
		public void Save(LaundryPriceSchemeDataEntity p_priceScheme)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Save(p_priceScheme);
					transaction.Commit();
				}
			}
		}
		
		public IEnumerable<LaundryPriceSchemeDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = session.Query<LaundryPriceSchemeDataEntity>()
					.Fetch(x => x.Category)
					.Fetch(x => x.Service)
					.ToList();
//				
//				var query = (from LaundryPriceScheme in session.Query<LaundryPriceSchemeDataEntity>()
//				             select LaundryPriceScheme);
				return query;//.ToList();
			}
		}
		
		public LaundryPriceSchemeDataEntity GetByCategoryService(string p_category, 
		                                             string p_service)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = session.Query<LaundryPriceSchemeDataEntity>()					
					.Fetch(x => x.Category)
					.Where(x => x.Category.Name == p_category)
					.Fetch(x => x.Service)
					.Where(x => x.Service.Name == p_service)
					.FirstOrDefault();
				return query;
			}
		}
		
		public void Delete(LaundryPriceSchemeDataEntity p_priceScheme)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Delete(p_priceScheme);
					transaction.Commit();
				}
			}
		}
		
		public void Update(LaundryPriceSchemeDataEntity p_priceScheme)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Update(p_priceScheme);
					transaction.Commit();
				}
			}
		}
	}
}

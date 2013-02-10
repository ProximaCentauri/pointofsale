﻿/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/9/2013
 * Time: 12:46 PM
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
	/// Description of RefillInventoryDao.
	/// </summary>
	public class RefillInventoryDao : IRefillInventoryDao
	{
		public RefillInventoryDao()
		{
		}
		
		public void SaveOrUpdate(RefillInventoryDataEntity p_inventory)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.SaveOrUpdate(p_inventory);
					transaction.Commit();
				}
			}
		}
		
		public IEnumerable<RefillInventoryDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = session.Query<RefillInventoryDataEntity>()
                    .OrderBy(x => x.Name)
                    .ToList();
                return query;
			}
		}
		
		public RefillInventoryDataEntity GetByName(string p_name)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
                var query = session.Query<RefillInventoryDataEntity>()
                    .Where(x => x.Name == p_name)
                    .SingleOrDefault();
				return query;
			}
		}
		
		public void Delete(RefillInventoryDataEntity p_inventory)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Delete(p_inventory);
					transaction.Commit();
				}
			}
		}
		
		public void Update(RefillInventoryDataEntity p_inventory	)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Update(p_inventory);
					transaction.Commit();
				}
			}
		}
	}
}
﻿/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/2/2013
 * Time: 12:15 PM
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
	/// Description of RefillProductTypeDao.
	/// </summary>
	public class RefillProductTypeDao : IRefillProductTypeDao
	{
		public RefillProductTypeDao()
		{
		}
		
		public void Save(RefillProductTypeDataEntity p_type)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Save(p_type);
					transaction.Commit();
				}
			}
		}
		
		public IEnumerable<RefillProductTypeDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = (from RefillProductType in session.Query<RefillProductTypeDataEntity>()
				             select RefillProductType);
				return query.ToList();
			}
		}
		
		public RefillProductTypeDataEntity GetByName(string p_name)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = (from RefillProductType in session.Query<RefillProductTypeDataEntity>()
				             where RefillProductType.Name == p_name
				             select RefillProductType).FirstOrDefault();
				return query;
			}
		}
		
		public void Delete(RefillProductTypeDataEntity p_type)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Delete(p_type);
					transaction.Commit();
				}
			}
		}
		
		public void Update(RefillProductTypeDataEntity p_type)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Update(p_type);
					transaction.Commit();
				}
			}
		}
	}
}

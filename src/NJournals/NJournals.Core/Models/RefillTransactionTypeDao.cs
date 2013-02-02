/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/2/2013
 * Time: 12:13 PM
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
	/// Description of RefillTransactionTypeDao.
	/// </summary>
	public class RefillTransactionTypeDao : IRefillTransactionTypeDao
	{
		public RefillTransactionTypeDao()
		{
		}
		
		public void Save(RefillTransactionTypeDataEntity p_type)
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
		
		public IEnumerable<RefillTransactionTypeDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = (from RefillTransactionType in session.Query<RefillTransactionTypeDataEntity>()
				             select RefillTransactionType);
				return query.ToList();
			}
		}
		
		public RefillTransactionTypeDataEntity GetByName(string p_name)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = (from RefillTransactionType in session.Query<RefillTransactionTypeDataEntity>()
				             where RefillTransactionType.Name == p_name
				             select RefillTransactionType).FirstOrDefault();
				return query;
			}
		}
		
		public void Delete(RefillTransactionTypeDataEntity p_type)
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
		
		public void Update(RefillTransactionTypeDataEntity p_type)
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

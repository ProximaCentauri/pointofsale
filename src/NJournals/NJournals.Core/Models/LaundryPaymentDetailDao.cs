/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 2/13/2013
 * Time: 11:45 AM
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
	/// Description of LaundryPaymentDetailDao.
	/// </summary>
	public class LaundryPaymentDetailDao : ILaundryPaymentDetailDao
	{
		public LaundryPaymentDetailDao()
		{
			
		}
		
		public void SaveOrUpdate(LaundryPaymentDetailDataEntity p_payment)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.SaveOrUpdate(p_payment);
					transaction.Commit();
				}
			}
		}
		
		public IEnumerable<LaundryPaymentDetailDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
                var query = session.Query<LaundryPaymentDetailDataEntity>()
                    .OrderBy(x => x.ID)
                    .ToList();
                return query;
			}
		}
		
		public LaundryPaymentDetailDataEntity GetByID(int p_id)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
                var query = session.Query<LaundryPaymentDetailDataEntity>()
                    .Where(x => x.ID == p_id)
                    .SingleOrDefault();
				return query;
			}
		}
		
		public void Delete(LaundryPaymentDetailDataEntity p_payment)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Delete(p_payment);
					transaction.Commit();
				}
			}
		}
		
		public void Update(LaundryPaymentDetailDataEntity p_payment)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Update(p_payment);
					transaction.Commit();
				}
			}
		}
	}
}

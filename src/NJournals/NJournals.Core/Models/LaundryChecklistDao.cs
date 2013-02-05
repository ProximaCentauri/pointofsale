/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/5/2013
 * Time: 8:43 AM
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
	/// Description of LaundryChecklistDao.
	/// </summary>
	public class LaundryChecklistDao : ILaundryChecklistDao
	{
		public LaundryChecklistDao()
		{
		}
		
		public void Save(LaundryChecklistDataEntity p_checklist)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Save(p_checklist);
					transaction.Commit();
				}
			}
		}
		
		public IEnumerable<LaundryChecklistDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = (from LaundryChecklist in session.Query<LaundryChecklistDataEntity>()
				             select LaundryChecklist);
				return query.ToList();
			}
		}
		
		public LaundryChecklistDataEntity GetByName(string p_name)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				var query = (from LaundryChecklist in session.Query<LaundryChecklistDataEntity>()
				             where LaundryChecklist.Name == p_name
				             select LaundryChecklist).FirstOrDefault();
				return query;
			}
		}
		
		public void Delete(LaundryChecklistDataEntity p_checklist)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Delete(p_checklist);
					transaction.Commit();
				}
			}
		}
		
		public void Update(LaundryChecklistDataEntity p_checklist)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					session.Update(p_checklist);
					transaction.Commit();
				}
			}
		}
	}
}

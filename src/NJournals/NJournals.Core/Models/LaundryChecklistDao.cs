﻿/*
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
		
		public void SaveOrUpdate(LaundryChecklistDataEntity p_checklist)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.SaveOrUpdate(p_checklist);
						transaction.Commit();
					}
					catch(Exception ex)
					{
						transaction.Rollback();
						throw ex;
					}		
				}
			}
		}
		
		public IEnumerable<LaundryChecklistDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
                var query = session.Query<LaundryChecklistDataEntity>()
                    .OrderBy(x => x.Name)
                    .ToList();
                return query;
			}
		}
		
		public LaundryChecklistDataEntity GetByName(string p_name)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
                var query = session.Query<LaundryChecklistDataEntity>()
                    .Where(x => x.Name == p_name)
                    .SingleOrDefault();
				return query;
			}
		}
		
		public LaundryChecklistDataEntity GetById(int p_id)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
                var query = session.Query<LaundryChecklistDataEntity>()
                    .Where(x => x.ChecklistID == p_id)
                    .SingleOrDefault();
				return query;
			}
		}
		
		public void Delete(LaundryChecklistDataEntity p_checklist)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.Delete(p_checklist);
						transaction.Commit();
					}
					catch(Exception ex)
					{
						transaction.Rollback();
						throw ex;
					}		
				}
			}
		}
		
		public void Update(LaundryChecklistDataEntity p_checklist)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.Update(p_checklist);
						transaction.Commit();
					}
					catch(Exception ex)
					{
						transaction.Rollback();
						throw ex;
					}		
				}
			}
		}
	}
}

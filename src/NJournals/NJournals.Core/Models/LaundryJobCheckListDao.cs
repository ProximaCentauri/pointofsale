﻿/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 2/13/2013
 * Time: 11:22 AM
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
	/// Description of LaundryJobCheckListDao.
	/// </summary>
	public class LaundryJobCheckListDao : ILaundryJobCheckListDao
	{
		public LaundryJobCheckListDao()
		{
		}
		
		public void SaveOrUpdate(LaundryJobChecklistDataEntity p_checklist)
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
		
		public IEnumerable<LaundryJobChecklistDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
                var query = session.Query<LaundryJobChecklistDataEntity>()
                    .OrderBy(x => x.ID)
                    .ToList();
                return query;
			}
		}
		
		public IEnumerable<LaundryJobChecklistDataEntity> GetAllItemsByHeaderId(int p_headerID)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
                var query = session.Query<LaundryJobChecklistDataEntity>()
                	.Where(x => x.Header.LaundryHeaderID == p_headerID)
                    .OrderBy(x => x.ID)
                    .ToList();
                return query;
			}
		}
		
		public LaundryJobChecklistDataEntity GetByID(int p_id)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
                var query = session.Query<LaundryJobChecklistDataEntity>()
                    .Where(x => x.ID == p_id)
                    .SingleOrDefault();
				return query;
			}
		}
		
		public void Delete(LaundryJobChecklistDataEntity p_checklist)
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
		
		public void Update(LaundryJobChecklistDataEntity p_checklist)
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

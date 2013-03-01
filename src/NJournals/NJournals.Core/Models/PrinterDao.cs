/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 3/1/2013
 * Time: 4:21 PM
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
	/// Description of PrinterDao.
	/// </summary>
	public class PrinterDao : IPrinterDao
	{
		public PrinterDao()
		{
		}
		
		public void SaveOrUpdate(PrinterDataEntity p_printer)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.SaveOrUpdate(p_printer);
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
		
		
		public PrinterDataEntity GetByName(string p_name)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
                    var query = session.Query<PrinterDataEntity>()
                        .Where(x => x.Name == p_name)
                        .SingleOrDefault();
					return query;
				}
			}
		}
		
		
		public IEnumerable<PrinterDataEntity> GetAllItems()
		{
			using(var session = NHibernateHelper.OpenSession())
			{
                var query = session.Query<PrinterDataEntity>()
                	.Where(x => x.Status == false)
                	.OrderBy(x => x.Name)
                    .ToList();
                return query;
			}
		}
		
		public void Update(PrinterDataEntity p_printer)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.Update(p_printer);
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
		
		public void Delete(PrinterDataEntity p_printer)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					try
					{
						session.Delete(p_printer);
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

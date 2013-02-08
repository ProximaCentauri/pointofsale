/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/7/2013
 * Time: 8:32 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NHibernate.Type;
using NJournals.Common;
using NJournals.Common.Util;
using System.Linq;
using System.Text;
using NHibernate.Linq;
using NHibernate.Criterion;
using System.Collections.Generic;
using NJournals.Common.Interfaces;
using NJournals.Common.DataEntities;
using System.Globalization;


namespace NJournals.Core.Models
{
	/// <summary>
	/// Description of LaundryReportDao.
	/// </summary>
	public class LaundryReportDao : ILaundryReportDao
	{
		public LaundryReportDao()
		{
		}
		
		public IEnumerable<LaundryDaySummaryDataEntity> GetAllCustomersSalesReport(DateTime fromDateTime,
		                                                                   DateTime toDateTime)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
                     var query = session.QueryOver<LaundryDaySummaryDataEntity>()
                        .Where(x => x.DayStamp >= fromDateTime)
                        .And(x => x.DayStamp <= toDateTime)
                        .OrderBy(x => x.DayStamp).Asc
                        .List();
                    return query;
				}
			}
		}
		
		public IEnumerable<LaundryHeaderDataEntity> GetCustomerSalesReport(CustomerDataEntity customer,
		                                                                   DateTime fromDateTime,
		                                                                   DateTime toDateTime)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
					var query = session.QueryOver<LaundryHeaderDataEntity>()
						.Where(x => x.Customer == customer)
						.And(x => x.ClaimDate >= fromDateTime)
						.And(x => x.ClaimDate <= toDateTime)
						.And(x => x.PaidFlag == true)
						.OrderBy(x => x.ClaimDate).Asc
						.List();
					return query;
				}
			}
		}
		
		public IEnumerable<LaundryHeaderDataEntity> GetUnclaimedItemsReport(CustomerDataEntity customer, 
		                                                             DateTime fromDateTime, 
		                                                             DateTime toDateTime,
		                                                            bool b_isAll)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{					
					if(b_isAll)
					{
						var query = session.QueryOver<LaundryHeaderDataEntity>()							
							.Where(x => x.ReceivedDate >= fromDateTime)
							.And(x => x.ReceivedDate <= toDateTime)
							.And(x => x.ClaimFlag == false)
							.OrderBy(x => x.ReceivedDate).Asc
							.List();
						return query;
					}
					else{
						var query = session.QueryOver<LaundryHeaderDataEntity>()
							.Where(x => x.Customer == customer)
							.And(x => x.ReceivedDate >= fromDateTime)
							.And(x => x.ReceivedDate <= toDateTime)
							.And(x => x.ClaimFlag == false)
							.OrderBy(x => x.ReceivedDate).Asc
							.List(); 
						return query;
					}
					
				}
			}
		}
		
		public IEnumerable<LaundryHeaderDataEntity> GetClaimedItemsReport(CustomerDataEntity customer,
		                                                           DateTime fromDateTime,
		                                                           DateTime toDateTime,
		                                                           bool b_isAll)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{					
					if(b_isAll)
					{
						var query = session.QueryOver<LaundryHeaderDataEntity>()							
							.Where(x => x.ReceivedDate >= fromDateTime)
							.And(x => x.ReceivedDate <= toDateTime)
							.And(x => x.ClaimFlag == true)
							.OrderBy(x => x.ReceivedDate).Asc
							.List();
						return query;
					}
					else{
						var query = session.QueryOver<LaundryHeaderDataEntity>()
							.Where(x => x.Customer == customer)
							.And(x => x.ReceivedDate >= fromDateTime)
							.And(x => x.ReceivedDate <= toDateTime)
							.And(x => x.ClaimFlag == true)
							.OrderBy(x => x.ReceivedDate).Asc
							.List(); 
						return query;
					}
					
				}
			}
		}
		
        public IEnumerable<LaundryHeaderDataEntity> GetUnpaidItemsReport(CustomerDataEntity customer, 
		                                                             DateTime fromDateTime, 
		                                                             DateTime toDateTime,
		                                                            bool b_isAll)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{					
					if(b_isAll)
					{
						var query = session.QueryOver<LaundryHeaderDataEntity>()							
							.Where(x => x.ReceivedDate >= fromDateTime)
							.And(x => x.ReceivedDate <= toDateTime)
							.And(x => x.PaidFlag == false)
							.OrderBy(x => x.ReceivedDate).Asc
							.List();
						return query;
					}
					else{
						var query = session.QueryOver<LaundryHeaderDataEntity>()
							.Where(x => x.Customer == customer)
							.And(x => x.ReceivedDate >= fromDateTime)
							.And(x => x.ReceivedDate <= toDateTime)
							.And(x => x.PaidFlag == false)
							.OrderBy(x => x.ReceivedDate).Asc
							.List(); 
						return query;
					}					
				}
			}
		}
		public IEnumerable<LaundryHeaderDataEntity> GetPaidItemsReport(CustomerDataEntity customer, 
		                                                             DateTime fromDateTime, 
		                                                             DateTime toDateTime,
		                                                             bool b_isAll)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{					
					if(b_isAll)
					{
						var query = session.QueryOver<LaundryHeaderDataEntity>()							
							.Where(x => x.ReceivedDate >= fromDateTime)
							.And(x => x.ReceivedDate <= toDateTime)
							.And(x => x.PaidFlag == true)
							.OrderBy(x => x.ReceivedDate).Asc
							.List();
						return query;
					}
					else{
						var query = session.QueryOver<LaundryHeaderDataEntity>()
							.Where(x => x.Customer == customer)
							.And(x => x.ReceivedDate >= fromDateTime)
							.And(x => x.ReceivedDate <= toDateTime)
							.And(x => x.PaidFlag == true)
							.OrderBy(x => x.ReceivedDate).Asc
							.List(); 
						return query;
					}					
				}
			}
		}		
	}
}

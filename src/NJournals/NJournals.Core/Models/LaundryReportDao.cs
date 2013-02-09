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
using NHibernate;
using NHibernate.Linq;
using NHibernate.Criterion;
using NHibernate.Transform;
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
			
		public IEnumerable<LaundryDaySummaryDataEntity> GetCustomerSalesReport(CustomerDataEntity customer,
		                                                                   DateTime fromDateTime,
		                                                                   DateTime toDateTime, bool b_isAll)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{					
					if(b_isAll)
					{
                        var query = session.QueryOver<LaundryDaySummaryDataEntity>()
                            .WhereRestrictionOn(x => x.DayStamp).IsBetween(fromDateTime).And(toDateTime)
                            .OrderBy(x => x.DayStamp).Asc
                            .List<LaundryDaySummaryDataEntity>();						
                    	return query;	
					}
					else
					{
						var query = session.CreateCriteria<LaundryHeaderDataEntity>("header")
							.Add(Restrictions.Eq("header.Customer",customer))
							.CreateAlias("header.PaymentDetailEntities","paymentdetails")
							.SetProjection(Projections.ProjectionList()
										   .Add(Projections.GroupProperty(Projections.Cast(NHibernateUtil.Date
							                                                               ,Projections.GroupProperty("paymentdetails.PaymentDate"))),"DayStamp")
							               .Add(Projections.Sum("paymentdetails.Amount"),"TotalSales")
							               .Add(Projections.CountDistinct("LaundryHeaderID"),"TransCount"))
							.Add(Restrictions.Between("paymentdetails.PaymentDate",fromDateTime,toDateTime))           						          
							.AddOrder(Order.Asc("paymentdetails.PaymentDate"))
							.SetResultTransformer(Transformers.AliasToBean(typeof(LaundryDaySummaryDataEntity)))
							.List<LaundryDaySummaryDataEntity>();
						return query;
					}
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

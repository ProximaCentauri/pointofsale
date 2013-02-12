/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/10/2013
 * Time: 7:41 PM
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
	/// Description of RefillReportDao.
	/// </summary>
	public class RefillReportDao : IRefillReportDao
	{
		public RefillReportDao()
		{
		}
		
		public IEnumerable<RefillDaySummaryDataEntity> GetCustomerSalesReport(CustomerDataEntity customer,
		                                                                   DateTime fromDateTime,
		                                                                   DateTime toDateTime, bool b_isAll)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{					
					if(b_isAll)
					{
                        var query = session.QueryOver<RefillDaySummaryDataEntity>()
                            .WhereRestrictionOn(x => x.DayStamp).IsBetween(fromDateTime).And(toDateTime)
                            .OrderBy(x => x.DayStamp).Asc
                            .List<RefillDaySummaryDataEntity>();						
                    	return query;	
					}
					else
					{
						var query = session.CreateCriteria<RefillHeaderDataEntity>("header")
							.Add(Restrictions.Eq("header.Customer",customer))
							.CreateAlias("header.PaymentDetailEntities","paymentdetails")
							.SetProjection(Projections.ProjectionList()
										   .Add(Projections.GroupProperty(Projections.Cast(NHibernateUtil.Date
							                                                               ,Projections.GroupProperty("paymentdetails.PaymentDate"))),"DayStamp")
							               .Add(Projections.Sum("paymentdetails.Amount"),"TotalSales")
							               .Add(Projections.CountDistinct("RefillHeaderID"),"TransCount"))
							.Add(Restrictions.Between("paymentdetails.PaymentDate",fromDateTime,toDateTime))           						          
							.AddOrder(Order.Asc("paymentdetails.PaymentDate"))
							.SetResultTransformer(Transformers.AliasToBean(typeof(RefillDaySummaryDataEntity)))
							.List<RefillDaySummaryDataEntity>();
						return query;
					}
				}
			}   
		}
			
        public IEnumerable<RefillHeaderDataEntity> GetUnpaidTransactionsReport(CustomerDataEntity customer, 
		                                                             DateTime fromDateTime, 
		                                                             DateTime toDateTime,
		                                                            bool b_isAll)
		{
			using(var session = NHibernateHelper.OpenSession())
			{
				using(var transaction = session.BeginTransaction())
				{
                    if (b_isAll)
                    {
                        var query = session.CreateCriteria<RefillHeaderDataEntity>("header")
                           .Add(Restrictions.Between("header.Date", fromDateTime, toDateTime))
                           .Add(Restrictions.Eq("header.PaidFlag", false))                        
                           .AddOrder(Order.Asc("header.Date"))
                           .List<RefillHeaderDataEntity>();
                        return query;
                    }
                    else
                    {
                        var query = session.CreateCriteria<RefillHeaderDataEntity>("header")
                            .Add(Restrictions.Eq("header.Customer", customer))
                            .Add(Restrictions.Between("header.Date", fromDateTime, toDateTime))
                            .Add(Restrictions.Eq("header.PaidFlag", false))
                            .AddOrder(Order.Asc("header.Date"))
                            .List<RefillHeaderDataEntity>();
                        return query;
                    }
				}
			}			
		}

        public IEnumerable<RefillInventoryHeaderDataEntity> GetInventoryReport(DateTime fromDateTime, DateTime toDateTime)
        {          
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
//                	var query = session.CreateCriteria<RefillInventoryHeaderDataEntity>("header")
//                		.CreateAlias("header.DetailEntities","detailentities")
//                		.SetProjection(Projections.ProjectionList()
//                		               .Add(Projections.GroupProperty("header.Name"),"Name")
//                		               .Add(Projections.GroupProperty(Projections.Cast(NHibernateUtil.Date
//							                                                               ,Projections.GroupProperty("detailentities.Date"))),"DayStamp")                		              
//                		               .Add(Projections.Sum("detailentities.TotalQty"), "TotalQty")
//                		               .Add(Projections.Sum("detailentities.QtyOnHand"), "QtyOnHand")
//                		               .Add(Projections.Sum("detailentities.QtyAdded"), "TotalAdded")
//                		               .Add(Projections.Sum("detailentities.QtyRemoved"), "TotalRemoved")
//                		               .Add(Projections.Sum("detailentities.QtyReleased"), "QtyReleased"))
//                		.Add(Restrictions.Between("details.Date", fromDateTime,toDateTime))
//                		.AddOrder(Order.Asc("Name"))
//                		.AddOrder(Order.Asc("DayStamp"))
//                		.SetResultTransformer(Transformers.AliasToBean(typeof(RefillInventoryReportDataEntity)))
//                		.List<RefillInventoryReportDataEntity>();

					var query = session.CreateCriteria<RefillInventoryHeaderDataEntity>("header")						
                		.CreateAlias("header.DetailEntities","detailentities")
                		.SetProjection(Projections.ProjectionList()						               
                		               .Add(Projections.GroupProperty("header.Name"),"Name")
                		               .Add(Projections.GroupProperty(Projections.Cast(NHibernateUtil.Date
							                                                               ,Projections.GroupProperty("detailentities.Date"))),"DayStamp")                		              
                		               .Add(Projections.Sum("detailentities.TotalQty"))
                		               .Add(Projections.Sum("detailentities.QtyOnHand"))
                		               .Add(Projections.Sum("detailentities.QtyAdded"))
                		               .Add(Projections.Sum("detailentities.QtyRemoved"))
                		               .Add(Projections.Sum("detailentities.QtyReleased")))
                		.Add(Restrictions.Between("details.Date", fromDateTime,toDateTime))
                		.AddOrder(Order.Asc("Name"))
                		.AddOrder(Order.Asc("DayStamp"))
                		.SetResultTransformer(Transformers.AliasToBean(typeof(RefillInventoryHeaderDataEntity)))
                		.List<RefillInventoryHeaderDataEntity>();
                	return query;
                }
            }
        }
        
        public IEnumerable<RefillCustInventoryHeaderDataEntity> GetCustomerInventoryReport(CustomerDataEntity customer, bool b_isAll)
        {          
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                	if(b_isAll)
                	{
                		var query = session.CreateCriteria<RefillCustInventoryHeaderDataEntity>("header")                			
                			.AddOrder(Order.Asc("header.Customer.Name"))
                           .List<RefillCustInventoryHeaderDataEntity>();
                        return query;
                	}
                	else{
                		var query = session.CreateCriteria<RefillCustInventoryHeaderDataEntity>("header")
                			.Add(Restrictions.Eq("header.Customer",customer))                			
                           .List<RefillCustInventoryHeaderDataEntity>();
                        return query;
                	}                
                }
            }
        }
	}
}

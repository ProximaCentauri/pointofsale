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
						   .Add(Restrictions.Eq("header.VoidFlag",false))                        	
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
                        	.Add(Restrictions.Eq("header.VoidFlag",false))
                            .AddOrder(Order.Asc("header.Date"))
                            .List<RefillHeaderDataEntity>();
                        return query;
                    }
				}
			}			
		}

        public IEnumerable<RefillInventoryReportDataEntity> GetInventoryReport(DateTime fromDateTime, DateTime toDateTime)
        {          
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
					var query = session.CreateCriteria<RefillInventoryHeaderDataEntity>("header")						
                		.CreateAlias("header.DetailEntities","detailentities")                        
                		.SetProjection(Projections.ProjectionList()						                         
                		               .Add(Projections.Distinct(Projections.GroupProperty("header.Name")),"Name")
                		               .Add(Projections.GroupProperty(Projections.Cast(NHibernateUtil.Date
							                                                               ,Projections.GroupProperty("detailentities.Date"))),"DayStamp")
                                       .Add(Projections.Sum("header.TotalQty"), "HeaderTotalQty")
                                       .Add(Projections.Sum("header.QtyReleased"), "HeaderQtyReleased")
                                       .Add(Projections.Sum("header.QtyOnHand"), "HeaderQtyOnHand")
                                       .Add(Projections.Sum("detailentities.TotalQty"),"DetailTotalQty")
                		               .Add(Projections.Sum("detailentities.QtyOnHand"),"DetailQtyOnHand")
                		               .Add(Projections.Sum("detailentities.QtyAdded"),"TotalAdded")
                		               .Add(Projections.Sum("detailentities.QtyRemoved"),"TotalRemoved")
                		               .Add(Projections.Sum("detailentities.QtyReleased"),"DetailQtyReleased"))
                        .Add(Restrictions.Between("detailentities.Date", fromDateTime, toDateTime))
                		.AddOrder(Order.Asc("Name"))
                        .AddOrder(Order.Asc("DayStamp"))
                        .SetResultTransformer(Transformers.AliasToBean(typeof(RefillInventoryReportDataEntity)))
                        .List<RefillInventoryReportDataEntity>();
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
                           .CreateAlias("header.Customer","customer")                          
                           .AddOrder(Order.Asc("customer.Name"))
                           .List<RefillCustInventoryHeaderDataEntity>();
                        return query;                       
                	}
                	else{
                        var query = session.QueryOver<RefillCustInventoryHeaderDataEntity>()
                            .Where(x => x.Customer == customer)                           
                            .List<RefillCustInventoryHeaderDataEntity>();
                        return query;	 
                	}                
                }
            }
        }
        
        public IEnumerable<RefillHeaderDataEntity> GetVoidTransactionsReport(CustomerDataEntity customer,
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
                           .Add(Restrictions.Eq("header.VoidFlag", true))
                           .AddOrder(Order.Asc("header.Date"))
                           .List<RefillHeaderDataEntity>();
                        return query;
                    }
                    else
                    {
                        var query = session.CreateCriteria<RefillHeaderDataEntity>("header")
                            .Add(Restrictions.Eq("header.Customer", customer))
                            .Add(Restrictions.Between("header.Date", fromDateTime, toDateTime))
                            .Add(Restrictions.Eq("header.VoidFlag", true))
                            .AddOrder(Order.Asc("header.Date"))
                            .List<RefillHeaderDataEntity>();
                        return query;
                    }
					
				}
			}
        }
	}
}

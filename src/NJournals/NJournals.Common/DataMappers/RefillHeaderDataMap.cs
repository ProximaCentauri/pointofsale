/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/2/2013
 * Time: 12:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using FluentNHibernate.Mapping;
using NHibernate.Linq;
using NJournals.Common.DataEntities;

namespace NJournals.Common.DataMappers
{
	/// <summary>
	/// Description of RefillHeaderDataMap.
	/// </summary>
	public class RefillHeaderDataMap : ClassMap<RefillHeaderDataEntity>
	{
		public RefillHeaderDataMap()
		{
			Id(x => x.RefillHeaderID);
			Map(x => x.Date);
			Map(x => x.AmountDue);
			Map(x => x.AmountTender);
			Map(x => x.TotalQty);
			Map(x => x.PaidFlag);
			References(x => x.TransactionType).Column("TransactionTypeID").Not.LazyLoad();
			HasMany<RefillDetailDataEntity>(x => x.DetailEntities)
				.KeyColumn("RefillHeaderID")
				.Inverse()
				.Cascade.AllDeleteOrphan();
			HasMany<RefillPaymentDetailDataEntity>(x => x.PaymentDetailEntities)
				.KeyColumn("RefillHeaderID").Not.LazyLoad()
				.Inverse()
				.Cascade.AllDeleteOrphan();
			References<CustomerDataEntity>(x => x.Customer)
				.Column("CustomerID").Not.Nullable().Not.LazyLoad();
			References<RefillDaySummaryDataEntity>(x => x.DaySummary)
				.Column("DayID")
				.Cascade.SaveUpdate();
				
			Table("RefillHeader");
		}
	}
}

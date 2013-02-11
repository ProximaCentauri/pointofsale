/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/1/2013
 * Time: 12:04 AM
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
	/// Description of LaundryHeaderDataMap.
	/// </summary>
	public class LaundryHeaderDataMap : ClassMap<LaundryHeaderDataEntity>
	{
		public LaundryHeaderDataMap()
		{
			Id(x => x.LaundryHeaderID);
			Map(x => x.ReceivedDate);
			Map(x => x.ClaimDate);
			Map(x => x.DueDate);
			Map(x => x.ClaimFlag);
			Map(x => x.PaidFlag);			
			Map(x => x.AmountDue);
			Map(x => x.TotalCharge);
			Map(x => x.TotalDiscount);
			Map(x => x.TotalAmountDue);
			Map(x => x.AmountTender);
			Map(x => x.TotalItemQty);		
			HasMany<LaundryDetailDataEntity>(x => x.DetailEntities)
				.KeyColumn("LaundryHeaderID")
				.Inverse()
				.Cascade.AllDeleteOrphan();
			HasMany<LaundryJobChargesDataEntity>(x => x.JobChargeEntities)				
				.KeyColumn("LaundryHeaderID").Not.LazyLoad()
				.Inverse()
				.Cascade.AllDeleteOrphan();
			HasMany<LaundryPaymentDetailDataEntity>(x => x.PaymentDetailEntities)
				.KeyColumn("LaundryHeaderID").Not.LazyLoad()
				.Inverse()
				.Cascade.AllDeleteOrphan();
			HasMany<LaundryJobChecklistDataEntity>(x => x.JobChecklistEntities)
				.KeyColumn("ChecklistID")
				.Inverse()
				.Cascade.AllDeleteOrphan();
			References<CustomerDataEntity>(x => x.Customer)
				.Column("CustomerID").Not.Nullable().Not.LazyLoad();
			References<LaundryDaySummaryDataEntity>(x => x.DaySummary)
				.Column("DayID")
				.Cascade.SaveUpdate();
			
			Table("LaundryHeader");
		}
	}
}

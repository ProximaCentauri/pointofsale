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
			Map(x => x.CustomerName);
			Map(x => x.Date);
			Map(x => x.AmountDue);
			References(x => x.TransactionType).Column("TransactionTypeID").Not.LazyLoad();
			HasMany<RefillDetailDataEntity>(x => x.DetailEntities)
				.KeyColumn("RefillHeaderID")
				.Inverse()
				.Cascade.AllDeleteOrphan();
			References<RefillDaySummaryDataEntity>(x => x.DaySummary)
				.Column("DayID").Not.Nullable();
				
			Table("RefillHeader");
		}
	}
}

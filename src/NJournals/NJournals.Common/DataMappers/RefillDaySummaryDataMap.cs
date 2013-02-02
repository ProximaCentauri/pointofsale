/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/2/2013
 * Time: 12:26 PM
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
	/// Description of RefillDaySummaryDataMap.
	/// </summary>
	public class RefillDaySummaryDataMap : ClassMap<RefillDaySummaryDataEntity>
	{
		public RefillDaySummaryDataMap()
		{
			Id(x => x.DayID);
			Map(x => x.DayStamp);
			Map(x => x.TotalSales);
			Map(x => x.TransCount);
			HasMany<RefillHeaderDataEntity>(x => x.HeaderEntities)
				.KeyColumn("DayID")
				.Inverse()
				.Cascade.AllDeleteOrphan();
			Table("RefillDaySummary");
				
		}
	}
}

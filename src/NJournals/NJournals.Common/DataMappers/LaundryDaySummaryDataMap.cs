/*
 * Created by SharpDevelop.
 * User: jl185099
 * Date: 2/1/2013
 * Time: 3:22 PM
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
	/// Description of LaundryDaySummaryDataMap.
	/// </summary>
	public class LaundryDaySummaryDataMap : ClassMap<LaundryDaySummaryDataEntity>
	{
		public LaundryDaySummaryDataMap()
		{
			Id(x => x.DayID);
			Map(x => x.DayStamp);
			Map(x => x.TotalSales);
			Map(x => x.TransCount);
			HasMany<LaundryHeaderDataEntity>(x => x.HeaderEntities)
				.KeyColumn("DayID")
				.Inverse()
				.Cascade.All();
			Table("LaundryDaySummary");
		}
	}
}

/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/1/2013
 * Time: 12:59 AM
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
	/// Description of LaundryDetailDataMap.
	/// </summary>
	public class LaundryDetailDataMap : ClassMap<LaundryDetailDataEntity>
	{
		public LaundryDetailDataMap()
		{
			Id(x => x.ID);
			References(x => x.Category).Column("CategoryID").Not.LazyLoad();
			References(x => x.Service).Column("ServiceID").Not.LazyLoad();
			Map(x => x.ItemQty);
			Map(x => x.Kilo);
			Map(x => x.Amount);
			References<LaundryHeaderDataEntity>(x => x.Header)
				.Column("LaundryHeaderID");
			Table("LaundryDetail");
				
		}
	}
}

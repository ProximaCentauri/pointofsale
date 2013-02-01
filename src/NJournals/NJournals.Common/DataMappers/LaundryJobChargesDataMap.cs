/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/2/2013
 * Time: 12:31 AM
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
	/// Description of LaundryJobChargesDataMap.
	/// </summary>
	public class LaundryJobChargesDataMap : ClassMap<LaundryJobChargesDataEntity>
	{
		public LaundryJobChargesDataMap()
		{
			Id(x => x.ID);
			References(x => x.Charge).Column("ChargeID").Not.LazyLoad();
			References<LaundryHeaderDataEntity>(x => x.Header)
				.Column("LaundryHeaderID").Not.Nullable();
			Table("LaundryJobCharges");	
		}
	}
}

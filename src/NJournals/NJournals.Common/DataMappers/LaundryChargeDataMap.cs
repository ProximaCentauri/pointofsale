/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 1/31/2013
 * Time: 11:36 PM
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
	/// Description of LaundryChargeDataMap.
	/// </summary>
	public class LaundryChargeDataMap : ClassMap<LaundryChargeDataEntity>
	{
		public LaundryChargeDataMap()
		{
			Id(x => x.ChargeID);
			Map(x => x.Name);
			Map(x => x.Amount);
			Map(x => x.VoidFlag);
			Table("LaundryCharges");
		}
	}
}

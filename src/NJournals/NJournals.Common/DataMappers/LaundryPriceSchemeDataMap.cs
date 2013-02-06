/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 1/31/2013
 * Time: 11:53 PM
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
	/// Description of LaundryPriceSchemeDataMap.
	/// </summary>
	public class LaundryPriceSchemeDataMap : ClassMap<LaundryPriceSchemeDataEntity>
	{
		public LaundryPriceSchemeDataMap()
		{
			Id(x => x.ID);
			Map(x => x.Description);
			Map(x => x.Price);
			References(x => x.Category).Column("CategoryID").Not.LazyLoad();
			References(x => x.Service).Column("ServiceID").Not.LazyLoad();
			Table("LaundryPriceScheme");
		}
	}
}

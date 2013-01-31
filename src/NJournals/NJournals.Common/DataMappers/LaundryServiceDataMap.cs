/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 1/31/2013
 * Time: 11:44 PM
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
	/// Description of LaundryServiceDataMap.
	/// </summary>
	public class LaundryServiceDataMap : ClassMap<LaundryServiceDataEntity>
	{
		public LaundryServiceDataMap()
		{
			Id(x => x.ServiceID);
			Map(x => x.Name);
			Map(x => x.Description);
			Table("LaundryServices");
		}
	}
}

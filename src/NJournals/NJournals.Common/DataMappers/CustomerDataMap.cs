/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/5/2013
 * Time: 8:14 AM
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
	/// Description of CustomerDataMap.
	/// </summary>
	public class CustomerDataMap : ClassMap<CustomerDataEntity>
	{
		public CustomerDataMap()
		{
			Id(x => x.CustomerID);
			Map(x => x.Name);
			Map(x => x.Address);
			Map(x => x.ContactNumber);	
			Map(x => x.VoidFlag);
			
			Table("Customer");
		}
	}
}

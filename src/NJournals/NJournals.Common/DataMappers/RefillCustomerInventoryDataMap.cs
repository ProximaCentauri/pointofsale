/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/9/2013
 * Time: 12:41 PM
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
	/// Description of RefillCustomerInventoryDataMap.
	/// </summary>
	public class RefillCustomerInventoryDataMap : ClassMap<RefillCustomerInventoryDataEntity>
	{
		public RefillCustomerInventoryDataMap()
		{
			Id(x => x.ID);
			Map(x => x.BottlesOnHand);
			Map(x => x.BottlesReturned);
			Map(x => x.CapsOnHand);
			Map(x => x.CapsReturned);
			References<CustomerDataEntity>(x => x.Customer)
				.Column("CustomerID");
			Table("RefillCustomerInventory");
		}
	}
}

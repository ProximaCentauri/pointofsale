/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/9/2013
 * Time: 12:40 PM
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
	/// Description of RefillInventoryDataMap.
	/// </summary>
	public class RefillInventoryDataMap : ClassMap<RefillInventoryDataEntity>
	{
		public RefillInventoryDataMap()
		{
			Id(x => x.ID);
			Map(x => x.Name);
			Map(x => x.TotalQty);
			Map(x => x.QtyOnHand);
			Map(x => x.QtyReleased);
			Table("RefillInventory");
		}
	}
}

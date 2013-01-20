/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 1/20/2013
 * Time: 12:29 PM
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
	/// Description of ItemDataDataMap.
	/// </summary>
	public class ItemDataMap : ClassMap<ItemDataEntity>
	{
		public ItemDataMap()
		{
			Id(x => x.ItemID);
			Map(x => x.Name)
				.Column("ItemName");
			Map(x => x.Barcode);
			Map(x => x.Description);
			Map(x => x.Manufacturer);
			Map(x => x.BuyPrice);
			Map(x => x.Markup);
			Map(x => x.SellPrice);
			Map(x => x.OriginalStock);
			Map(x => x.QtySold);
			Map(x => x.QtyStock);
			Map(x => x.ThresholdValue);
			Map(x => x.Rack);
			Map(x => x.Unit);
			References(x => x.Generic).Column("GenericID").Fetch.Join();
			References(x => x.Category).Column("CategoryID").Fetch.Join();
			Table("ItemInfo");
		}
	}
}

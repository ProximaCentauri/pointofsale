/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/2/2013
 * Time: 12:32 PM
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
	/// Description of RefillDetailDataMap.
	/// </summary>
	public class RefillDetailDataMap : ClassMap<RefillDetailDataEntity>
	{
		public RefillDetailDataMap()
		{
			Id(x => x.ID);
			References(x => x.ProductType).Column("ProductTypeID").Not.LazyLoad();
			Map(x => x.Qty);
			Map(x => x.Amount);
			Map(x => x.StoreBottleQty);
			Map(x => x.StoreCapQty);
			References<RefillHeaderDataEntity>(x => x.Header)
				.Column("RefillHeaderID").Not.Nullable();
			Table("RefillDetail");
		}
	}
}

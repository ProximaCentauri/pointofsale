/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/11/2013
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
	/// Description of RefillInventoryDetailDataMap.
	/// </summary>
	public class RefillInventoryDetailDataMap : ClassMap<RefillInventoryDetailDataEntity>
	{
		public RefillInventoryDetailDataMap()
		{
			Id(x => x.ID);			
			Map(x => x.QtyAdded);
			Map(x => x.QtyRemoved);
			Map(x => x.Date);
			References<RefillInventoryHeaderDataEntity>(x => x.Header)
				.Column("InvHeaderID");
			Table("RefillInventoryDetail");
		}
	}
}

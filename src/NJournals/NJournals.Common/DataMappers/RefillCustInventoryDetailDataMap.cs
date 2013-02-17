/*
 * Created by SharpDevelop.
 * User: jl185099
 * Date: 2/12/2013
 * Time: 7:39 PM
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
	/// Description of RefillCustInventoryDetailDataMap.
	/// </summary>
	public class RefillCustInventoryDetailDataMap : ClassMap<RefillCustInventoryDetailDataEntity>
	{
		public RefillCustInventoryDetailDataMap()
		{
			Id(x => x.ID);
			Map(x => x.CapsReturned);  
			Map(x => x.BottlesReturned);
			Map(x => x.Date);
			References<RefillCustInventoryHeaderDataEntity>(x => x.Header)
				.Column("CustInvID");
			Table("RefillCustomerInventoryDetail");
		}
	}
}

/*
 * Created by SharpDevelop.
 * User: jl185099
 * Date: 2/8/2013
 * Time: 7:38 PM
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
	/// Description of LaundryPaymentDetailDataMap.
	/// </summary>
	public class LaundryPaymentDetailDataMap : ClassMap<LaundryPaymentDetailDataEntity>
	{
		public LaundryPaymentDetailDataMap()
		{
			Id(x => x.ID);			
			Map(x => x.Amount);			
			References<LaundryHeaderDataEntity>(x => x.Header)
				.Column("LaundryHeaderID");
			Table("LaundryPaymentDetail");
		}
	}
}

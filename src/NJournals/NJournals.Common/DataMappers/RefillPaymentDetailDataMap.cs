/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/10/2013
 * Time: 7:49 PM
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
	/// Description of RefillPaymentDetailDataMap.
	/// </summary>
	public class RefillPaymentDetailDataMap : ClassMap<RefillPaymentDetailDataEntity>
	{
		public RefillPaymentDetailDataMap()
		{
			Id(x => x.ID);			
			Map(x => x.Amount);
            Map(x => x.PaymentDate);
			References<RefillHeaderDataEntity>(x => x.Header)
				.Column("RefillHeaderID");
			Table("RefillPaymentDetail");
		}
	}
}

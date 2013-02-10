/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/10/2013
 * Time: 7:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NJournals.Common.DataEntities
{
	/// <summary>
	/// Description of RefillPaymentDetailDataEntity.
	/// </summary>
	public class RefillPaymentDetailDataEntity
	{
		public virtual int ID {get;set;}
        public virtual DateTime PaymentDate { get; set; }
		public virtual RefillPaymentDetailDataEntity Header {get;set;}
		public virtual decimal Amount {get;set;}		
	}
}

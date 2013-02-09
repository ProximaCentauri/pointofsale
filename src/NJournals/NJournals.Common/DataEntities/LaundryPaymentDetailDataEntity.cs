/*
 * Created by SharpDevelop.
 * User: jl185099
 * Date: 2/8/2013
 * Time: 7:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NJournals.Common.DataEntities
{
	/// <summary>
	/// Description of LaundryPaymentDetailDataEntity.
	/// </summary>
	public class LaundryPaymentDetailDataEntity
	{
		public virtual int ID {get;set;}
        public virtual DateTime PaymentDate { get; set; }
		public virtual LaundryHeaderDataEntity Header {get;set;}
		public virtual decimal Amount {get;set;}			
	}
}

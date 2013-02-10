/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/2/2013
 * Time: 12:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace NJournals.Common.DataEntities
{
	/// <summary>
	/// Description of RefillHeaderDataEntity.
	/// </summary>
	public class RefillHeaderDataEntity
	{
		public virtual int RefillHeaderID {get;set;}
		public virtual DateTime Date {get;set;}
		public virtual double AmountDue {get;set;}
		public virtual double AmountTender {get;set;}
		public virtual int TotalQty {get;set;}
		public virtual bool PaidFlag {get;set;}
		
		public virtual CustomerDataEntity Customer {get;set;}
		public virtual RefillTransactionTypeDataEntity TransactionType {get;set;}
		public virtual IList<RefillPaymentDetailDataEntity> PaymentDetailEntities {get;set;}
		public virtual IList<RefillDetailDataEntity> DetailEntities {get;set;}		
		public virtual RefillDaySummaryDataEntity DaySummary {get;set;}
		
		public RefillHeaderDataEntity()
		{			
			DetailEntities = new List<RefillDetailDataEntity>();
			PaymentDetailEntities = new List<RefillPaymentDetailDataEntity>();
		}
	}
}

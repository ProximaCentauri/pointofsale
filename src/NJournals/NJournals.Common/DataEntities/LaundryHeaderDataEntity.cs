/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 1/31/2013
 * Time: 11:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace NJournals.Common.DataEntities
{
	/// <summary>
	/// Description of LaundryHeaderDataEntity.
	/// </summary>
	public class LaundryHeaderDataEntity
	{
		public virtual int LaundryHeaderID {get;set;}		
		public virtual string CustomerName {get;set;}
		public virtual DateTime ReceivedDate {get;set;}
		public virtual DateTime DueDate {get;set;}
		public virtual DateTime ClaimDate {get;set;}
		public virtual bool PaidFlag {get;set;}
		public virtual bool ClaimFlag {get;set;}
		public virtual double AmountDue {get;set;}
		
		public virtual IList<LaundryDetailDataEntity> DetailEntities {get; set;}
		public virtual LaundryDaySummaryDataEntity DaySummary {get;set;}
		public virtual IList<LaundryJobChargesDataEntity> JobChargeEntities {get;set;}
		
		public LaundryHeaderDataEntity()
		{
			DetailEntities = new List<LaundryDetailDataEntity>();
			JobChargeEntities = new List<LaundryJobChargesDataEntity>();
		}
	}
}

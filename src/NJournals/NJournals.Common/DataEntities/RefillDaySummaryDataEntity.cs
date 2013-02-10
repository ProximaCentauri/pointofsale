/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/2/2013
 * Time: 12:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace NJournals.Common.DataEntities
{
	/// <summary>
	/// Description of RefillDaySummaryDataEntity.
	/// </summary>
	public class RefillDaySummaryDataEntity
	{
		public virtual int DayID {get;set;}
		public virtual decimal TotalSales {get;set;}
		public virtual int TransCount {get;set;}
		public virtual DateTime DayStamp {get;set;}
		
		public virtual IList<RefillHeaderDataEntity> HeaderEntities {get; set;}	

		public RefillDaySummaryDataEntity()
		{
			HeaderEntities = new List<RefillHeaderDataEntity>();
		}
	}
}

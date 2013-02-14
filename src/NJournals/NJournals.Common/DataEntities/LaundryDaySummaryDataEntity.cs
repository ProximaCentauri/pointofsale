/*
 * Created by SharpDevelop.
 * User: jl185099
 * Date: 2/1/2013
 * Time: 3:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace NJournals.Common.DataEntities
{
	/// <summary>
	/// Description of LaundryDaySummary.
	/// </summary>
	public class LaundryDaySummaryDataEntity
	{
		public virtual int DayID {get;set;}
		public virtual DateTime DayStamp {get;set;}
		public virtual decimal TotalSales {get;set;}
		public virtual int TransCount {get;set;}
		
		public virtual List<LaundryHeaderDataEntity> HeaderEntities {get; set;}	

		public LaundryDaySummaryDataEntity()
		{
			HeaderEntities = new List<LaundryHeaderDataEntity>();
		}
	}
}

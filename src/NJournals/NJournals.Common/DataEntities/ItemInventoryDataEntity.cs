/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 1/20/2013
 * Time: 9:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NJournals.Common.DataEntities
{
	/// <summary>
	/// Description of ItemInventoryDataEntity.
	/// </summary>
	public class ItemInventoryDataEntity
	{
		public virtual int InventoryID {get; set;}
		public virtual DateTime DayStamp {get; set;}
		public virtual int StockAdded {get; set;}
		public virtual int StockRemoved {get; set;}
		public virtual ItemDataEntity Item {get; set;}
	}
}

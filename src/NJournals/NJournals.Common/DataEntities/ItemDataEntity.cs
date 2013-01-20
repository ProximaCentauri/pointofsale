/*
 * Created by SharpDevelop.
 * User: matt
 * Date: 1/19/2013
 * Time: 10:02 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
	
namespace NJournals.Common.DataEntities
{
	/// <summary>
	/// Description of ItemDataEntity.
	/// </summary>
	public class ItemDataEntity
	{
		public virtual long ItemID { get; set; }
		public virtual string Barcode { get; set; }
		public virtual string Name { get; set; }
		public virtual string Description { get; set; }
		public virtual string Manufacturer { get; set; }
		public virtual double BuyPrice { get; set; }
		public virtual double Markup { get; set; }
		public virtual double SellPrice { get; set; }
		public virtual int OriginalStock { get; set; }
		public virtual int QtyStock { get; set; }
		public virtual int QtySold { get; set; }
		public virtual int ThresholdValue { get; set; }
		public virtual string Rack { get; set; }
		public virtual string Unit { get; set; }
		public virtual ItemGenericDataEntity Generic { get; set; }
		public virtual ItemCategoryDataEntity Category { get; set; }
	}
}

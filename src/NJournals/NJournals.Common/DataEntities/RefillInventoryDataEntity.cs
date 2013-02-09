/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/9/2013
 * Time: 12:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NJournals.Common.DataEntities
{
	/// <summary>
	/// Description of RefillInventoryDataEntity.
	/// </summary>
	public class RefillInventoryDataEntity
	{
		public virtual int ID {get;set;}
		public virtual string Name {get;set;}
		public virtual int TotalQty {get;set;}
		public virtual int QtyOnHand {get;set;}
		public virtual int QtyReleased {get;set;}
	}
}

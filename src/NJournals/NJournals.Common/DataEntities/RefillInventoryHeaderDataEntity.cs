/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/9/2013
 * Time: 12:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace NJournals.Common.DataEntities
{
	/// <summary>
	/// Description of RefillInventoryHeaderDataEntity.
	/// </summary>
	public class RefillInventoryHeaderDataEntity
	{
		public virtual int InvHeaderID {get;set;}
		public virtual string Name {get;set;}
		public virtual int TotalQty {get;set;}
		public virtual int QtyOnHand {get;set;}
		public virtual int QtyReleased {get;set;}
		
		public virtual IList<RefillInventoryDetailDataEntity> DetailEntities {get;set;}
		
		public RefillInventoryHeaderDataEntity()
		{
			DetailEntities = new List<RefillInventoryDetailDataEntity>();
		}
	}
}

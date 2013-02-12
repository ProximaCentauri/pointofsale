/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/9/2013
 * Time: 12:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace NJournals.Common.DataEntities
{
	/// <summary>
	/// Description of RefillCustInventoryHeaderDataEntity.
	/// </summary>
	public class RefillCustInventoryHeaderDataEntity
	{
		public virtual int CustInvID {get;set;}
		public virtual int BottlesOnHand {get;set;}
		public virtual int BottlesReturned {get;set;}
		public virtual int CapsOnHand {get;set;}
		public virtual int CapsReturned {get;set;}
		public virtual CustomerDataEntity Customer {get;set;}
		
		public virtual IList<RefillCustInventoryDetailDataEntity> DetailEntities {get;set;}
		
		public RefillCustInventoryHeaderDataEntity()
		{
			DetailEntities = new List<RefillCustInventoryDetailDataEntity>();
		}
	}
}

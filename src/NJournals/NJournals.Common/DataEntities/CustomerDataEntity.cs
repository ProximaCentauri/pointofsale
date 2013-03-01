/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/5/2013
 * Time: 8:03 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace NJournals.Common.DataEntities
{
	/// <summary>
	/// Description of CustomerDataEntity.
	/// </summary>
	public class CustomerDataEntity
	{
		public virtual int CustomerID {get;set;}
		public virtual string Name {get;set;}
		public virtual string Address {get;set;}
		public virtual string ContactNumber {get;set;}
		public virtual bool VoidFlag {get;set;}
		
		//public virtual RefillCustomerInventoryDataEntity CustomerInventory {get;set;}
	}
}

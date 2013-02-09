/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/9/2013
 * Time: 12:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NJournals.Common.DataEntities
{
	/// <summary>
	/// Description of RefillCustomerInventoryDataEntity.
	/// </summary>
	public class RefillCustomerInventoryDataEntity
	{
		public virtual int ID {get;set;}
		public virtual int BottlesOnHand {get;set;}
		public virtual int BottlesReturned {get;set;}
		public virtual int CapsOnHand {get;set;}
		public virtual int CapsReturned {get;set;}
		public virtual CustomerDataEntity Customer {get;set;}
	}
}

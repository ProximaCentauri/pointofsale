/*
 * Created by SharpDevelop.
 * User: jl185099
 * Date: 2/12/2013
 * Time: 7:27 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NJournals.Common.DataEntities
{
	/// <summary>
	/// Description of RefillCustInventoryDetailDataEntity.
	/// </summary>
	public class RefillCustInventoryDetailDataEntity
	{
		public virtual int ID {get;set;}
		public virtual int BottlesOnHand {get;set;}
		public virtual int BottlesReturned {get;set;}
		public virtual DateTime Date {get;set;}
		public virtual RefillCustInventoryHeaderDataEntity Header {get;set;}
	}
}

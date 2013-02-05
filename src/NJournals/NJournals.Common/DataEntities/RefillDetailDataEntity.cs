/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/2/2013
 * Time: 12:21 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NJournals.Common.DataEntities
{
	/// <summary>
	/// Description of RefillDetailDataEntity.
	/// </summary>
	public class RefillDetailDataEntity
	{
		public virtual int ID {get;set;}
		public virtual RefillHeaderDataEntity Header {get;set;}
		public virtual RefillProductTypeDataEntity ProductType {get;set;}
		public virtual int Qty {get;set;}
		public virtual int StoreBottleQty {get;set;}
		public virtual int StoreCapQty {get;set;}
		public virtual double Amount {get;set;}
	}
}

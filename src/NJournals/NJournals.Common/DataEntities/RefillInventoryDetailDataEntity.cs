/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/11/2013
 * Time: 11:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NJournals.Common.DataEntities
{
	/// <summary>
	/// Description of RefillInventoryDetailDataEntity.
	/// </summary>
	public class RefillInventoryDetailDataEntity
	{
		public virtual int ID {get;set;}
		public virtual int QtyAdded {get;set;}
		public virtual int QtyRemoved {get;set;}
		public virtual DateTime Date {get;set;}
		public virtual RefillInventoryHeaderDataEntity Header {get;set;}
	}
}

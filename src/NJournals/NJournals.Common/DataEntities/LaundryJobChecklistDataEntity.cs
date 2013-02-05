/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/5/2013
 * Time: 8:04 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NJournals.Common.DataEntities
{
	/// <summary>
	/// Description of LaundryJobChecklistDataEntity.
	/// </summary>
	public class LaundryJobChecklistDataEntity
	{
		public virtual int ID {get;set;}
		public virtual LaundryChecklistDataEntity Checklist {get;set;}
		public virtual LaundryHeaderDataEntity Header {get;set;}
		public virtual int Qty {get;set;}
	}
}

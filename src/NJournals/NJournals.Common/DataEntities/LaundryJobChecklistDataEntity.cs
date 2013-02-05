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
	/// Description of LaundryJobChecklist.
	/// </summary>
	public class LaundryJobChecklist
	{
		public virtual int ID {get;set;}
		public virtual LaundryChecklistDataEntity Checklist {get;set;}
		public virtual LaundryHeaderDataEntity Header {get;set;}
		public virtual int Qty {get;set;}
	}
}

/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/2/2013
 * Time: 12:30 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NJournals.Common.DataEntities
{
	/// <summary>
	/// Description of LaundryJobChargesDataEntity.
	/// </summary>
	public class LaundryJobChargesDataEntity
	{
		public virtual int ID {get;set;}
		public virtual LaundryHeaderDataEntity Header {get;set;}
		public virtual LaundryChargeDataEntity Charge {get;set;}
	}
}

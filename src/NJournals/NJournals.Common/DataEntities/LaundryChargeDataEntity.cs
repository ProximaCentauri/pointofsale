/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 1/31/2013
 * Time: 11:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NJournals.Common.DataEntities
{
	/// <summary>
	/// Description of LaundryChargeDataEntity.
	/// </summary>
	public class LaundryChargeDataEntity
	{
		public virtual int ChargeID {get;set;}
		public virtual string Name {get;set;}
		public virtual decimal Amount {get;set;}
	}
}

/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 1/31/2013
 * Time: 11:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NJournals.Common.DataEntities
{
	/// <summary>
	/// Description of LaundryServiceDataEntity.
	/// </summary>
	public class LaundryServiceDataEntity
	{
		public virtual int ServiceID {get;set;}
		public virtual string Name {get;set;}
		public virtual string Description {get;set;}
	}
}

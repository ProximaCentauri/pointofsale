/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/1/2013
 * Time: 12:50 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NJournals.Common.DataEntities
{
	/// <summary>
	/// Description of LaundryDetailDataEntity.
	/// </summary>
	public class LaundryDetailDataEntity
	{
		public virtual int ID {get;set;}
		public virtual LaundryHeaderDataEntity Header {get;set;}
		public virtual LaundryServiceDataEntity Service {get;set;}
		public virtual LaundryCategoryDataEntity Category {get;set;}
		public virtual int ItemQty {get;set;}
		public virtual double Kilo {get;set;}
		public virtual decimal Amount {get;set;}
		
	}
}

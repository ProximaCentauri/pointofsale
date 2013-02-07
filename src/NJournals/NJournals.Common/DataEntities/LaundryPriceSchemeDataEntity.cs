/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 1/31/2013
 * Time: 11:50 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NJournals.Common.DataEntities
{
	/// <summary>
	/// Description of LaundryPriceSchemeDataEntity.
	/// </summary>
	public class LaundryPriceSchemeDataEntity
	{
		
		public virtual int ID {get;set;}
		public virtual LaundryCategoryDataEntity Category{get;set;}
		public virtual LaundryServiceDataEntity Service{get;set;}
		public virtual string Description {get;set;}
		public virtual decimal Price {get;set;}
	}
}

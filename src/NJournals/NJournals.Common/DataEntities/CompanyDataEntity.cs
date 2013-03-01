/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 3/1/2013
 * Time: 3:09 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace NJournals.Common.DataEntities
{
	/// <summary>
	/// Description of CompanyDataEntity.
	/// </summary>
	public class CompanyDataEntity
	{				
		public virtual int CompanyID {get;set;}
		public virtual string Name {get;set;}
		public virtual string Address {get;set;}
		public virtual string ContactNumber {get;set;}
		public virtual bool VoidFlag {get;set;}
		
	}
}

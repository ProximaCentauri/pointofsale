/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/2/2013
 * Time: 12:06 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NJournals.Common.DataEntities
{
	/// <summary>
	/// Description of RefillProductTypeDataEntity.
	/// </summary>
	public class RefillProductTypeDataEntity
	{
		public virtual int ProductTypeID {get;set;}
		public virtual string Name {get;set;}
		public virtual string Description {get;set;}
		public virtual double Price {get;set;}
	}
}

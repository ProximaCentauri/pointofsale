/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 3/1/2013
 * Time: 4:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NJournals.Common.DataEntities
{
	/// <summary>
	/// Description of PrinterDataEntity.
	/// </summary>
	public class PrinterDataEntity
	{
		public virtual int PrinterID {get;set;}
		public virtual string Name {get;set;}
		public virtual string Model {get;set;}			
		public virtual bool Active {get;set;}
	}
}

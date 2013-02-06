/*
 * Created by SharpDevelop.
 * User: JulieAnn
 * Date: 1/31/2013
 * Time: 7:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NJournals.Common.DataEntities
{
	/// <summary>
	/// Description of LaundryCategoryDataEntity.
	/// </summary>
	public class LaundryCategoryDataEntity
	{		
		public virtual int CategoryID {get;set;}
		public virtual string Name {get;set;}
		public virtual string Description {get;set;}
	}
}

/*
 * Created by SharpDevelop.
 * User: matt
 * Date: 1/19/2013
 * Time: 2:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NJournals.Common.Entities
{
	/// <summary>
	/// Description of ItemCategoryDataEntity.
	/// </summary>
	public class ItemCategoryDataEntity
	{
		public virtual int CategoryID { get; set; }
		public virtual string CategoryName { get; set; }
	}
}
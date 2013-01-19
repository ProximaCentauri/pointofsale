/*
 * Created by SharpDevelop.
 * User: matt
 * Date: 1/19/2013
 * Time: 2:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NJournals.Common
{
	/// <summary>
	/// Description of ItemCategoryDataEntity.
	/// </summary>
	public class ItemCategoryDataEntity
	{
		public ItemCategoryDataEntity()
		{
		}
		
		string name;
		
		public string Name {
			get { return name; }
			set { name = value; }
		}
		string notes;
		
		public string Notes {
			get { return notes; }
			set { notes = value; }
		}
	}
}

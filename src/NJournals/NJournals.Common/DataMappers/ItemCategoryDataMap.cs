/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 1/19/2013
 * Time: 9:28 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using FluentNHibernate.Mapping;
using NHibernate.Linq;
using NJournals.Common.DataEntities;

namespace NJournals.Common.DataMappers
{
	/// <summary>
	/// Description of ItemCategoryDataMap.
	/// </summary>
	public class ItemCategoryDataMap : ClassMap<ItemCategoryDataEntity>
	{
		public ItemCategoryDataMap()
		{
			Id(x => x.CategoryID);
			Map(x => x.CategoryName);
			Table("CategoryInfo");
		}
	}
}

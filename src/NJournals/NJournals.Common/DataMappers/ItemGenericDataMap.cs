/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 1/20/2013
 * Time: 10:43 AM
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
	/// Description of ItemGenericDataMap.
	/// </summary>
	public class ItemGenericDataMap : ClassMap<ItemGenericDataEntity>
	{
		public ItemGenericDataMap()
		{
			Id(x => x.GenericID);
			Map(x => x.GenericName);
			Table("GenericInfo");
		}
	}
}

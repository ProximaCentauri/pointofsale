/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/5/2013
 * Time: 8:15 AM
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
	/// Description of LaundryChecklistDataMap.
	/// </summary>
	public class LaundryChecklistDataMap : ClassMap<LaundryChecklistDataEntity>
	{
		public LaundryChecklistDataMap()
		{
			Id(x => x.ChecklistID);
			Map(x => x.Name);
			Table("LaundryChecklist");
		}
	}
}

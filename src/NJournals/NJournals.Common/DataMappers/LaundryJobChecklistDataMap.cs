/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/5/2013
 * Time: 8:16 AM
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
	/// Description of LaundryJobChecklistDataMap.
	/// </summary>
	public class LaundryJobChecklistDataMap : ClassMap<LaundryJobChecklistDataEntity>
	{
		public LaundryJobChecklistDataMap()
		{
			Id(x => x.ID);
			References(x => x.Checklist).Column("ChecklistID").Not.LazyLoad();
			References<LaundryHeaderDataEntity>(x => x.Header)
				.Column("LaundryHeaderID").Not.Nullable();
			Map(x => x.Qty);
			Table("LaundryJobChecklist");	
		}
	}
}

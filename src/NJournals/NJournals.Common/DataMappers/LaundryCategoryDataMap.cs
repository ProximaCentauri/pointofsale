/*
 * Created by SharpDevelop.
 * User: jl185099
 * Date: 1/31/2013
 * Time: 7:59 PM
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
	/// Description of LaundryCategoryDataMap.
	/// </summary>
	public class LaundryCategoryDataMap : ClassMap<LaundryCategoryDataEntity>
	{
		public LaundryCategoryDataMap()
		{
			Id(x => x.CategoryID);
			Map(x => x.Name);
			Map(x => x.Description);
			Table("LaundryCategory");
		}
	}
}

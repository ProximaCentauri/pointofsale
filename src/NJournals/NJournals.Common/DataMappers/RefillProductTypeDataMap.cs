/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/2/2013
 * Time: 12:09 PM
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
	/// Description of RefillProductTypeDataMap.
	/// </summary>
	public class RefillProductTypeDataMap : ClassMap<RefillProductTypeDataEntity>
	{
		public RefillProductTypeDataMap()
		{
			Id(x => x.ProductTypeID);
			Map(x => x.Name);
			Map(x => x.Description);
			Map(x => x.Price);
			Table("RefillProductType");
		}
	}
}

/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 3/1/2013
 * Time: 3:11 PM
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
	/// Description of CompanyDataMap.
	/// </summary>
	public class CompanyDataMap : ClassMap<CompanyDataEntity>
	{
		
		public CompanyDataMap()
		{
			Id(x => x.CompanyID);
			Map(x => x.Name);
			Map(x => x.Address);
			Map(x => x.ContactNumber);				
			
			Table("Company");
		}
	}
}

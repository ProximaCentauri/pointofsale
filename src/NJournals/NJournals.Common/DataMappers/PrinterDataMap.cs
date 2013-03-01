/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 3/1/2013
 * Time: 4:17 PM
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
	/// Description of PrinterDataMap.
	/// </summary>
	public class PrinterDataMap : ClassMap<PrinterDataEntity>
	{
		public PrinterDataMap()
		{
			Id(x => x.PrinterID);
			Map(x => x.Name);
			Map(x => x.Model);
			Map(x => x.Status);				
			
			Table("Printer");
		}
	}
}

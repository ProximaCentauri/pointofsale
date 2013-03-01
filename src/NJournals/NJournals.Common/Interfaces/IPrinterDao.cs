/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 3/1/2013
 * Time: 4:20 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using NHibernate.Linq;
using NJournals.Common.DataEntities;

namespace NJournals.Common.Interfaces
{
	/// <summary>
	/// Description of IPrinterDao.
	/// </summary>
	public interface IPrinterDao
	{
		void SaveOrUpdate(PrinterDataEntity p_printer);
		IEnumerable<PrinterDataEntity> GetAllItems();		
		PrinterDataEntity GetByName(string p_name);
		void Delete(PrinterDataEntity p_printer);
		void Update(PrinterDataEntity p_printer);
	}
}

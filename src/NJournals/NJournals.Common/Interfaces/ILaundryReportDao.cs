/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/7/2013
 * Time: 8:29 AM
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
	/// Description of ILaundryReportDao.
	/// </summary>
	public interface ILaundryReportDao
	{
		IEnumerable<LaundryDaySummaryDataEntity> GetAllCustomersSalesReport(DateTime fromDateTime,
		                                                                   DateTime toDateTime);
		IEnumerable<LaundryHeaderDataEntity> GetCustomerSalesReport(CustomerDataEntity customer,
		                                                            DateTime fromDateTime,
		                                                            DateTime toDateTime);
		
	}
}

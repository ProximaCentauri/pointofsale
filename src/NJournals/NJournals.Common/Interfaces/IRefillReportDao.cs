/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/10/2013
 * Time: 7:39 PM
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
	/// Description of IRefillReportDao.
	/// </summary>
	public interface IRefillReportDao
	{
		IEnumerable<RefillDaySummaryDataEntity> GetCustomerSalesReport(CustomerDataEntity customer,
		                                                            DateTime fromDateTime,
		                                                            DateTime toDateTime,
		                                                            bool b_isAll);       
        IEnumerable<RefillHeaderDataEntity> GetUnpaidTransactionsReport(CustomerDataEntity customer, 
		                                                             DateTime fromDateTime, 
		                                                             DateTime toDateTime,
		                                                            bool b_isAll);
		IEnumerable<RefillHeaderDataEntity> GetUnpaidTransactionsReport(CustomerDataEntity customer);
		IEnumerable<RefillInventoryReportDataEntity> GetInventoryReport(DateTime fromDateTime, DateTime toDateTime);
		IEnumerable<RefillCustInventoryHeaderDataEntity> GetCustomerInventoryReport(CustomerDataEntity customer, bool  b_isAll);
		IEnumerable<RefillHeaderDataEntity> GetVoidTransactionsReport(CustomerDataEntity customer,
		                                                               DateTime fromDateTime,
		                                                               DateTime toDateTime,
		                                                               bool b_isAll);
		IEnumerable<RefillInventoryHeaderDataEntity> GetInventoryHeaderReport();
	}
}

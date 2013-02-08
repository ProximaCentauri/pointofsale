﻿/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 1/31/2013
 * Time: 4:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NJournals.Common.DataEntities;
using System.Collections.Generic;
using Microsoft.Reporting.WinForms;


namespace NJournals.Common.Interfaces
{
	/// <summary>
	/// Description of IReportView.
	/// </summary>
	public interface IReportView : IView
	{
		void SetAllReportTypes(List<string> reportTypes);
		void SetAllCustomers(List<CustomerDataEntity> customers);
		void DisplayReport<T>(List<T> rpt,List<ReportDataSource> datasources, 
            string rptembeddedsource, string p_datasource);
	}
}

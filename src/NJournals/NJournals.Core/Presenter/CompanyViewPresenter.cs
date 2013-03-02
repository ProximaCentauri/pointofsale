/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 3/1/2013
 * Time: 3:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NJournals.Common.DataEntities;
using NJournals.Core.Models;
using NJournals.Common.Interfaces;
using System.Collections.Generic;
using NJournals.Common.Util;
namespace NJournals.Core.Presenter
{
	/// <summary>
	/// Description of CompanyViewPresenter.
	/// </summary>
	public class CompanyViewPresenter
	{
		private ICompanyDao m_companyDao;
		private IPrinterDao m_printerDao;
		private ICompanyView m_view;		
		public CompanyViewPresenter(ICompanyView p_view)
		{
			m_view = p_view;
			m_companyDao = new CompanyDao();
			m_printerDao = new PrinterDao();
		}
		
		public void ShowCompanyInfo(){
			List<CompanyDataEntity> companyEntities = m_companyDao.GetAllItems() as List<CompanyDataEntity>;
			
			m_view.SetCompanyInfo(companyEntities);
		}
		
		public void ShowPrinterInfo(){
			List<PrinterDataEntity> printerEntities = m_printerDao.GetAllItems() as List<PrinterDataEntity>;
			m_view.SetPrinterInfo(printerEntities);
		}
		
		public void SaveClicked(){
			try{
				CompanyDataEntity company = m_view.ProcessCompanyInfo();
				m_companyDao.SaveOrUpdate(company);
				PrinterDataEntity printer = m_view.ProcessPrinterInfo();
				m_printerDao.SaveOrUpdate(printer);
				MessageService.ShowInfo("Successfully save your request.");
			}catch(Exception ex){
				MessageService.ShowError("There's some proble while saving your request." + Environment.NewLine +
				                         "Please check the logs for technical details.", "Error in Saving", ex);
			}			
		}
	}
}

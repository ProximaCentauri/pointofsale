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
namespace NJournals.Core.Presenter
{
	/// <summary>
	/// Description of CompanyViewPresenter.
	/// </summary>
	public class CompanyViewPresenter
	{
		private ICompanyDao m_companyDao;
		private IPrinterDao m_printerDao;
		
		public CompanyViewPresenter()
		{
			m_companyDao = new CompanyDao();
			m_printerDao = new PrinterDao();
		}
		
		public void ShowCompanyInfo(){
			//return m_companyDao.
		}
		
		public void ShowPrinterInfo(){
			
		}
	}
}

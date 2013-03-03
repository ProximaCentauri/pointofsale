/*
 * Created by SharpDevelop.
 * User: matt
 * Date: 2/10/2013
 * Time: 9:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NJournals.Core.Models;
using NJournals.Common.DataEntities;
using System.Collections.Generic;
using NJournals.Common.Interfaces;
using NJournals.Common.Util;
namespace NJournals.Core.Presenter
{
	/// <summary>
	/// Description of ChekcListViewPresenter.
	/// </summary>
	public class CheckListViewPresenter
	{
		ILaundryChecklistDao m_checklistDao;
		ICheckListView m_view;
		ICompanyDao m_companyDao;
		IPrinterDao m_printerDao;
		ILaundryDao m_laundryDao;
		
		public CheckListViewPresenter(ICheckListView p_view, ILaundryChecklistDao p_checklistDao)
		{
			m_checklistDao = p_checklistDao;
			m_view = p_view;
			m_printerDao = new PrinterDao();
			m_companyDao = new CompanyDao();
			m_laundryDao = new LaundryDao();
		}
		
		public void SetAllChecklist(){
			List<LaundryChecklistDataEntity> checklistEntities = m_checklistDao.GetAllItems() as List<LaundryChecklistDataEntity>;
			m_view.SetAllCheckList(checklistEntities);
		}
		
		public LaundryChecklistDataEntity getChecklistByName(string p_name){
			return m_checklistDao.GetByName(p_name);
		}
		
		public void SetSelectedChecklist(){
			m_view.SetSelectedCheckList();
		}
		
		public void PrintTransaction(LaundryHeaderDataEntity p_headerEntity){
			if(p_headerEntity != null){
				MessageService.ShowInfo("Printing checklist with JO number: " + p_headerEntity.LaundryHeaderID.ToString().PadLeft(6, '0'));
				
				try{
					PrintService.PrintCheckList(p_headerEntity, GetPrinterInfo());
				}catch(Exception ex){
					MessageService.ShowError("Unexpected exception has occurred during printing. Please verify whether printer is installed and online. \n Please check error logs for details.", "Error in Printing", ex);
				}		
			}
		}
		
		private CompanyDataEntity GetCompanyInfo(){
			List<CompanyDataEntity> companies = m_companyDao.GetAllItems() as List<CompanyDataEntity>;
			return companies[0];
		}
		
		private PrinterDataEntity GetPrinterInfo(){
			List<PrinterDataEntity> printers = m_printerDao.GetAllItems() as List<PrinterDataEntity>;
			return printers[0];
		}
		
		public LaundryHeaderDataEntity GetLaundryHeader(int p_id){
			return m_laundryDao.GetByID(p_id);
		}
	}
}

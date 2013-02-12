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
namespace NJournals.Core.Presenter
{
	/// <summary>
	/// Description of ChekcListViewPresenter.
	/// </summary>
	public class CheckListViewPresenter
	{
		ILaundryChecklistDao m_checklistDao;
		ICheckListView m_view;
		public CheckListViewPresenter(ICheckListView p_view, ILaundryChecklistDao p_checklistDao)
		{
			m_checklistDao = p_checklistDao;
			m_view = p_view;
			
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
	}
}

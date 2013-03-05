/*
 * Created by SharpDevelop.
 * User: matt
 * Date: 2/10/2013
 * Time: 9:50 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NJournals.Common.DataEntities;
using System.Collections.Generic;

namespace NJournals.Common.Interfaces
{
	/// <summary>
	/// Description of ICheckListView.
	/// </summary>
	public interface ICheckListView : IView
	{
		event EventHandler SelectChecklist;
		void SetAllCheckList(List<LaundryChecklistDataEntity> checkListEntities);
		void SetSelectedCheckList();
		List<LaundryChecklistDataEntity> ProcessCheckList();
		List<string> GetAllSelectedCheckList();
	}
}

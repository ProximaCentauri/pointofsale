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
		void SetAllCheckList(List<LaundryChecklistDataEntity> checkListEntities);
	}
}

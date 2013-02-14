/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 2/13/2013
 * Time: 11:20 AM
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
	/// Description of ILaundryJobCheckList.
	/// </summary>
	public interface ILaundryJobCheckListDao
	{
		void SaveOrUpdate(LaundryJobChecklistDataEntity p_checklist);
		IEnumerable<LaundryJobChecklistDataEntity> GetAllItems();
		IEnumerable<LaundryJobChecklistDataEntity> GetAllItemsByHeaderId(int p_headerID);
		LaundryJobChecklistDataEntity GetByID(int p_id);
		void Delete(LaundryJobChecklistDataEntity p_checklist);
		void Update(LaundryJobChecklistDataEntity p_checklist);
	}
}

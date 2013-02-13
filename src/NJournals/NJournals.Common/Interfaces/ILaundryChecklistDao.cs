/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/5/2013
 * Time: 8:38 AM
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
	/// Description of ILaundryChecklistDao.
	/// </summary>
	public interface ILaundryChecklistDao 
	{
		void SaveOrUpdate(LaundryChecklistDataEntity p_checklist);
		IEnumerable<LaundryChecklistDataEntity> GetAllItems();
		LaundryChecklistDataEntity GetByName(string p_name);
		void Delete(LaundryChecklistDataEntity p_checklist);
		void Update(LaundryChecklistDataEntity p_checklist);
	}
}

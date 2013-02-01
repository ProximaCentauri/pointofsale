/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/1/2013
 * Time: 12:07 AM
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
	/// Description of ILaundryDao.
	/// </summary>
	public interface ILaundryDao
	{
		void SaveOrUpdate(LaundryDaySummaryDataEntity p_daysummary);
		LaundryHeaderDataEntity GetLaundryByID(int p_headerID);
		IEnumerable<LaundryHeaderDataEntity> GetAllLaundryItems();
		IEnumerable<LaundryDaySummaryDataEntity> GetAllDaySummary();
		void DeleteLaundry(LaundryHeaderDataEntity p_header);
		void DeleteDaySummary(LaundryDaySummaryDataEntity p_daysummary);
//		LaundryHeaderDataEntity GetByID(int p_headerID);
//		void Delete(LaundryHeaderDataEntity p_header);
//		void Update(LaundryHeaderDataEntity p_header);
	}
}

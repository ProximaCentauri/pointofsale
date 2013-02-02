/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/2/2013
 * Time: 12:35 PM
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
	/// Description of IRefillDaySummaryDao.
	/// </summary>
	public interface IRefillDaySummaryDao
	{
		void Save(RefillDaySummaryDataEntity p_daysummary);
		RefillDaySummaryDataEntity GetByDay(DateTime p_day);
		IEnumerable<RefillDaySummaryDataEntity> GetAllItems();
		void Update(RefillDaySummaryDataEntity p_daysummary);
		void Delete(RefillDaySummaryDataEntity p_daysummary);
	}
}

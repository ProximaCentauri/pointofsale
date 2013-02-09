/*
 * Created by SharpDevelop.
 * User: jl185099
 * Date: 2/1/2013
 * Time: 3:48 PM
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
	/// Description of ILaundryDaySummaryDao.
	/// </summary>
	public interface ILaundryDaySummaryDao
	{
		void SaveOrUpdate(LaundryDaySummaryDataEntity p_daysummary);
		LaundryDaySummaryDataEntity GetByDay(DateTime p_day);
		IEnumerable<LaundryDaySummaryDataEntity> GetAllItems();
		void Update(LaundryDaySummaryDataEntity p_daysummary);
		void Delete(LaundryDaySummaryDataEntity p_daysummary);
	}
}

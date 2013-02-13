/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 2/13/2013
 * Time: 11:34 AM
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
	/// Description of ILaundryJobChargesDao.
	/// </summary>
	public interface ILaundryJobChargesDao
	{
		void SaveOrUpdate(LaundryJobChargesDataEntity p_jobcharge);
		IEnumerable<LaundryJobChargesDataEntity> GetAllItems();
		
		void Delete(LaundryJobChargesDataEntity p_jobcharge);
		void Update(LaundryJobChargesDataEntity p_jobcharge);
	}
}

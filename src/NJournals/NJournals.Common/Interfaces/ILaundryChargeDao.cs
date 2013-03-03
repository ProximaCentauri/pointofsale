/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 1/31/2013
 * Time: 11:37 PM
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
	/// Description of ILaundryChargeDao.
	/// </summary>
	public interface ILaundryChargeDao
	{
		void SaveOrUpdate(LaundryChargeDataEntity p_charge);
		IEnumerable<LaundryChargeDataEntity> GetAllItems();
		IEnumerable<LaundryChargeDataEntity> GetAllItemsWithVoid();
		LaundryChargeDataEntity GetByName(string p_name);
		void Delete(LaundryChargeDataEntity p_charge);
		void Update(LaundryChargeDataEntity p_charge);
	}
}

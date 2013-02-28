/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 2/28/2013
 * Time: 10:47 PM
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
	/// Description of IRefillInventoryDetailDao.
	/// </summary>
	public interface IRefillInventoryDetailDao
	{
		void SaveOrUpdate(RefillInventoryDetailDataEntity p_inventory);
		IEnumerable<RefillInventoryDetailDataEntity> GetAllItems();
		RefillInventoryDetailDataEntity GetById(int p_id);
		RefillInventoryDetailDataEntity GetDetailDay(RefillInventoryHeaderDataEntity p_header, DateTime p_dayStamp);
		void Delete(RefillInventoryDetailDataEntity p_inventory);
		void Update(RefillInventoryDetailDataEntity p_inventory);
	}
}

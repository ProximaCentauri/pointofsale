/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/9/2013
 * Time: 12:44 PM
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
	/// Description of IRefillInventoryDao.
	/// </summary>
	public interface IRefillInventoryDao
	{
		void SaveOrUpdate(RefillInventoryHeaderDataEntity p_inventory);
		IEnumerable<RefillInventoryHeaderDataEntity> GetAllItems();
		RefillInventoryHeaderDataEntity GetByName(string p_name);	
		RefillInventoryDetailDataEntity GetDetailByDay(RefillInventoryHeaderDataEntity header, DateTime daystamp);		
		void Delete(RefillInventoryHeaderDataEntity p_inventory);
		void Update(RefillInventoryHeaderDataEntity p_inventory);
	}
}

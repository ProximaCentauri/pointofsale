/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/9/2013
 * Time: 12:45 PM
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
	/// Description of IRefillCustomerInventoryDao.
	/// </summary>
	public interface IRefillCustomerInventoryDao
	{
		void Save(RefillCustomerInventoryDataEntity p_custinv);
		IEnumerable<RefillCustomerInventoryDataEntity> GetAllItems();
		RefillCustomerInventoryDataEntity GetByCustomer(CustomerDataEntity customer);
		void Delete(RefillCustomerInventoryDataEntity p_custinv);
		void Update(RefillCustomerInventoryDataEntity p_custinv);
	}
}

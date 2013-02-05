/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/5/2013
 * Time: 8:39 AM
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
	/// Description of ICustomerDao.
	/// </summary>
	public interface ICustomerDao
	{
		void SaveOrUpdate(CustomerDataEntity p_customer);
		IEnumerable<CustomerDataEntity> GetAllItems();
		CustomerDataEntity GetByName(string p_name);
		void Delete(CustomerDataEntity p_customer);
		void Update(CustomerDataEntity p_customer);
	}
}

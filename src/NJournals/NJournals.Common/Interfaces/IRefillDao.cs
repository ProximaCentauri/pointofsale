/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/2/2013
 * Time: 12:36 PM
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
	/// Description of IRefillDao.
	/// </summary>
	public interface IRefillDao
	{
		void Save(RefillHeaderDataEntity p_header);
		RefillHeaderDataEntity GetByID(int p_headerID);
		IEnumerable<RefillHeaderDataEntity> GetByCustomer(CustomerDataEntity customer);
		IEnumerable<RefillHeaderDataEntity> GetAllItems();
		void Update(RefillHeaderDataEntity p_header);
		void Delete(RefillHeaderDataEntity p_header);
	}
}

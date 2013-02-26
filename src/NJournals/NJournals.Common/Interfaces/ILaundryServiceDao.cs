/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 1/31/2013
 * Time: 11:46 PM
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
	/// Description of ILaundryServiceDao.
	/// </summary>
	public interface ILaundryServiceDao
	{
		void Save(LaundryServiceDataEntity p_service);
		IEnumerable<LaundryServiceDataEntity> GetAllItems();
		LaundryServiceDataEntity GetByName(string p_name);
		LaundryServiceDataEntity GetById(int p_id);
		void Delete(LaundryServiceDataEntity p_service);
		void Update(LaundryServiceDataEntity p_service);
	}
}

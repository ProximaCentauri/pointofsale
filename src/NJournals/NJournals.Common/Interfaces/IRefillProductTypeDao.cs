/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/2/2013
 * Time: 12:10 PM
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
	/// Description of IRefillProductTypeDao.
	/// </summary>
	public interface IRefillProductTypeDao
	{
		void SaveOrUpdate(RefillProductTypeDataEntity p_type);
		IEnumerable<RefillProductTypeDataEntity> GetAllItems();
		RefillProductTypeDataEntity GetByName(string p_name);
		void Delete(RefillProductTypeDataEntity p_type);
		void Update(RefillProductTypeDataEntity p_type);
	}
}

/*
 * Created by SharpDevelop.
 * User: matt
 * Date: 1/19/2013
 * Time: 2:08 PM
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
	/// Description of IItemGenericDao.
	/// </summary>
	public interface IItemGenericDao
	{
		void Save(ItemGenericDataEntity p_generic);
		IEnumerable<ItemGenericDataEntity> GetAllItems();
		ItemGenericDataEntity GetByName(string p_name);
		void Delete(ItemGenericDataEntity p_generic);
		void Update(ItemGenericDataEntity p_generic);
	}
}

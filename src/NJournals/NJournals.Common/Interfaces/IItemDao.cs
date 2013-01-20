/*
 * Created by SharpDevelop.
 * User: matt
 * Date: 1/19/2013
 * Time: 1:22 PM
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
	/// Description of IItemDao.
	/// </summary>
	public interface IItemDao
	{
		void Save(ItemDataEntity p_item);
		IEnumerable<ItemDataEntity> GetAllItems();
		ItemDataEntity GetByBarcode(string p_barcode);
		ItemDataEntity GetByName(string p_name);
		IEnumerable<ItemDataEntity> GetByCategory(string p_category);
		IEnumerable<ItemDataEntity> GetByGeneric(string p_generic);
		IEnumerable<ItemDataEntity> GetByDescription(string p_desc);
		void Delete(ItemDataEntity p_item);
		void Update(ItemDataEntity p_item);
	}
}

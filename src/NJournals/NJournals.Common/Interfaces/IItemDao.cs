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
namespace NJournals.Common.Interfaces
{
	/// <summary>
	/// Description of IItemDao.
	/// </summary>
	public interface IItemDao
	{
		ItemDataEntity CreateItemDataEntity();
        IEnumerable<ItemDataEntity> GetAllItems();
        void Save(ItemDataEntity p_item);
        ItemDataEntity GetByName(string p_name);
	}
}

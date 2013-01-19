/*
 * Created by SharpDevelop.
 * User: matt
 * Date: 1/19/2013
 * Time: 2:07 PM
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
	/// Description of IItemCategoryDao.
	/// </summary>
	public interface IItemCategoryDao
	{
		void Save(ItemCategoryDataEntity p_category);
		IEnumerable<ItemCategoryDataEntity> GetAllItems();
		ItemCategoryDataEntity GetByName(string p_name);
		void Delete(ItemCategoryDataEntity p_category);
		void Update(ItemCategoryDataEntity p_category);
	}
}

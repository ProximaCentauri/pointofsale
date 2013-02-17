/*
 * Created by SharpDevelop.
 * User: matt
 * Date: 2/17/2013
 * Time: 8:45 PM
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
	/// Description of ILaundryDetailDao.
	/// </summary>
	public interface ILaundryDetailDao
	{
		void SaveOrUpdate(LaundryDetailDataEntity p_detail);
		IEnumerable<LaundryDetailDataEntity> GetAllItems();
		IEnumerable<LaundryDetailDataEntity> GetAllItemsByHeaderId(int p_id);
		
		void Delete(LaundryDetailDataEntity p_detail);
		void Update(LaundryDetailDataEntity p_detail);
	}
}

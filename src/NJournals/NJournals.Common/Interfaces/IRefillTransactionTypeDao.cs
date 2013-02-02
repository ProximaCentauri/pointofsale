/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/2/2013
 * Time: 12:12 PM
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
	/// Description of IRefillTransactionTypeDao.
	/// </summary>
	public interface IRefillTransactionTypeDao
	{
		void Save(RefillTransactionTypeDataEntity p_type);
		IEnumerable<RefillTransactionTypeDataEntity> GetAllItems();
		RefillTransactionTypeDataEntity GetByName(string p_name);
		void Delete(RefillTransactionTypeDataEntity p_type);
		void Update(RefillTransactionTypeDataEntity p_type);
	}
}

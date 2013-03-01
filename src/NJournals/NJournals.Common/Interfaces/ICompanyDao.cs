/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 3/1/2013
 * Time: 3:08 PM
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
	/// Description of ICompanyDao.
	/// </summary>
	public interface ICompanyDao
	{
		void SaveOrUpdate(CompanyDataEntity p_customer);
		IEnumerable<CompanyDataEntity> GetAllItems();
		IEnumerable<CompanyDataEntity> GetCompanyByName(string p_name);
		CompanyDataEntity GetByName(string p_name);
		void Delete(CompanyDataEntity p_customer);
		void Update(CompanyDataEntity p_customer);
	}
}

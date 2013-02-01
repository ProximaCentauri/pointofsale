/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/1/2013
 * Time: 12:07 AM
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
	/// Description of ILaundryDao.
	/// </summary>
	public interface ILaundryDao
	{
		void Save(LaundryHeaderDataEntity p_header);		
		LaundryHeaderDataEntity GetByID(int p_headerID);
		IEnumerable<LaundryHeaderDataEntity> GetAllItems();
		void Update(LaundryHeaderDataEntity p_header);
		void Delete(LaundryHeaderDataEntity p_header);
	}
}

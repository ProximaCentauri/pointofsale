/*
 * Created by SharpDevelop.
 * User: JulieAnn
 * Date: 1/31/2013
 * Time: 7:40 PM
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
	/// Description of ILaundryCategoryDao.
	/// </summary>
	public interface ILaundryCategoryDao
	{
		void Save(LaundryCategoryDataEntity p_category);
		IEnumerable<LaundryCategoryDataEntity> GetAllItems();
		LaundryCategoryDataEntity GetByName(string p_name);
		LaundryCategoryDataEntity GetById(int p_id);
		void Delete(LaundryCategoryDataEntity p_category);
		void Update(LaundryCategoryDataEntity p_category);
	}
}

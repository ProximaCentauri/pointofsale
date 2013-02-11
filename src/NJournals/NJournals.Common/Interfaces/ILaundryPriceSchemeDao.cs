/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 1/31/2013
 * Time: 11:56 PM
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
	/// Description of LaundryPriceSchemeDao.
	/// </summary>
	public interface ILaundryPriceSchemeDao
	{
		void SaveOrUpdate(LaundryPriceSchemeDataEntity p_priceScheme);
		IEnumerable<LaundryPriceSchemeDataEntity> GetAllItems();
		IEnumerable<LaundryPriceSchemeDataEntity> GetAllItemsByServiceId(int serviceID);
		LaundryPriceSchemeDataEntity GetByCategoryService(LaundryServiceDataEntity p_service, 
		                                                  LaundryCategoryDataEntity p_category);
		void Delete(LaundryPriceSchemeDataEntity p_priceScheme);
		void Update(LaundryPriceSchemeDataEntity p_priceScheme);
	}
}

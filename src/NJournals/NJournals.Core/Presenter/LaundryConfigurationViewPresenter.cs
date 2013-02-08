/*
 * Created by SharpDevelop.
 * User: vo185003
 * Date: 2/6/2013
 * Time: 9:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NJournals.Common.Interfaces;
using NJournals.Core.Models;
using NJournals.Common.DataEntities;
using System.Collections.Generic;

namespace NJournals.Core.Presenter
{
	/// <summary>
	/// Description of LaundryConfigurationViewPresenter.
	/// </summary>
	public class LaundryConfigurationViewPresenter
	{
		ILaundryConfigurationView m_view;
		ILaundryCategoryDao m_categoryDao;
		ILaundryServiceDao m_serviceDao;
		ILaundryPriceSchemeDao m_priceSchemeDao;
		
		public LaundryConfigurationViewPresenter(ILaundryConfigurationView p_view)
		{
			this.m_view = p_view;
			m_categoryDao = new LaundryCategoryDao();
			m_serviceDao = new LaundryServiceDao();
			m_priceSchemeDao = new LaundryPriceSchemeDao();
		}
		
		public void SetAllCategories(){
			List<LaundryCategoryDataEntity> categories = m_categoryDao.GetAllItems() as List<LaundryCategoryDataEntity>;
			m_view.SetAllCategories(categories);
		}
		
		public void SetAllServices(){
			List<LaundryServiceDataEntity> services = m_serviceDao.GetAllItems() as List<LaundryServiceDataEntity>;
			m_view.SetAllServices(services);
		}
		
		public void SetAllPriceScheme(){
			List<LaundryPriceSchemeDataEntity> priceScheme = m_priceSchemeDao.GetAllItems() as List<LaundryPriceSchemeDataEntity>;
			m_view.SetAllPriceScheme(priceScheme);
		}
		
		public void SaveOrUpdateService(List<LaundryServiceDataEntity> services){
			
			foreach(LaundryServiceDataEntity service in services)
			{
				m_serviceDao.Save(service);
			}
		}
		
		public void DeleteService(LaundryServiceDataEntity service) {
			m_serviceDao.Delete(service);
		}
		
		public void SaveOrUpdateCategory(List<LaundryCategoryDataEntity> categories){
			
			foreach(LaundryCategoryDataEntity category in categories)
			{
				m_categoryDao.Save(category);
			}
		}
		
		public void DeleteCategory(LaundryCategoryDataEntity category) {
			m_categoryDao.Delete(category);
		}
		
	}
}

/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 1/30/2013
 * Time: 12:17 PM
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
	/// Description of LaundryViewPresenter.
	/// </summary>
	public class LaundryViewPresenter
	{
		ILaundryView m_view;
		ILaundryCategoryDao m_categoryDao;
		ILaundryServiceDao m_serviceDao;
		ILaundryDao m_laundryDao;
		
		public LaundryViewPresenter(ILaundryView p_view, ILaundryDao p_laundryDao)
		{
			this.m_view = p_view;
			m_laundryDao = p_laundryDao;
			m_categoryDao = new LaundryCategoryDao();
			m_serviceDao = new LaundryServiceDao();
			
		}
		
		public void SaveClicked(){
			
		}
		
		public void CancelClicked(){
			m_view.CloseView();
		}
		
		public void AddNewItemClicked(){
			m_view.AddItem();
		}
		
		public void SetAllCategories(){
			List<LaundryCategoryDataEntity> categories = m_categoryDao.GetAllItems() as List<LaundryCategoryDataEntity>;
			m_view.SetAllCategories(categories);
		}
		
		public void SetAllServices(){
			List<LaundryServiceDataEntity> services = m_serviceDao.GetAllItems() as List<LaundryServiceDataEntity>;
			m_view.SetAllServices(services);
		}
		
		public LaundryPriceSchemeDataEntity getLaundryPrice(string p_category, string p_service, 
		                                                    List<LaundryCategoryDataEntity> p_categories, List<LaundryServiceDataEntity> p_services){
			LaundryPriceSchemeDao priceDao = new LaundryPriceSchemeDao();
			LaundryPriceSchemeDataEntity priceEntity = new LaundryPriceSchemeDataEntity();
			LaundryCategoryDataEntity category = p_categories.Find(f_category => f_category.Name == p_category);
			LaundryServiceDataEntity service = p_services.Find(f_service => f_service.Name == p_service);
			priceEntity = priceDao.GetByCategoryService(service, category);
			return priceEntity;
		}
		
		
	}
}

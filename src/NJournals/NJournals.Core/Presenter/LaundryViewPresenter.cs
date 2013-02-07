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
		ICustomerDao m_customerDao;
		
		ILaundryDao m_laundryDao;		
		List<LaundryCategoryDataEntity> categories = null;
		List<LaundryServiceDataEntity> services = null;
		List<CustomerDataEntity> customers = null;
		
		public LaundryViewPresenter(ILaundryView p_view, ILaundryDao p_laundryDao)
		{
			this.m_view = p_view;
			m_laundryDao = p_laundryDao;
			m_categoryDao = new LaundryCategoryDao();
			m_serviceDao = new LaundryServiceDao();
			m_customerDao = new CustomerDao();
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
			categories = m_categoryDao.GetAllItems() as List<LaundryCategoryDataEntity>;
			m_view.SetAllCategories(categories);
		}
		
		public void SetAllServices(){
			services = m_serviceDao.GetAllItems() as List<LaundryServiceDataEntity>;
			m_view.SetAllServices(services);
		}
		
		public void SetAllCustomers(){
			customers = m_customerDao.GetAllItems() as List<CustomerDataEntity>;
			m_view.SetAllCustomers(customers);
		}
		
		public LaundryPriceSchemeDataEntity getLaundryPrice(string p_category, string p_service){
			LaundryPriceSchemeDao priceDao = new LaundryPriceSchemeDao();
			LaundryPriceSchemeDataEntity priceEntity = new LaundryPriceSchemeDataEntity();			
			priceEntity = priceDao.GetByCategoryService(getServiceByName(p_service), getCategoryByName(p_category));
			return priceEntity;
		}		
		
		public CustomerDataEntity getCustomerByName(string name){
			return m_customerDao.GetByName(name);
		}
		
		public LaundryCategoryDataEntity getCategoryByName(string p_category){
			return m_categoryDao.GetByName(p_category);
		}
		
		public LaundryServiceDataEntity getServiceByName(string p_service){
			return m_serviceDao.GetByName(p_service);
		}
		
		public int getHeaderID(){
			List<LaundryHeaderDataEntity> headerEntities = m_laundryDao.GetAllItems() as List<LaundryHeaderDataEntity>;
			if(headerEntities.Count > 0){
				return headerEntities[headerEntities.Count-1].LaundryHeaderID + 1;
			}
			return 1;
		}
	}
}

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
		ILaundryChargeDao m_chargeDao;
		ICustomerDao m_customerDao;
		ILaundryDaySummaryDao m_summaryDao;
		
		ILaundryDao m_laundryDao;		
		List<LaundryCategoryDataEntity> categories = null;
		List<LaundryServiceDataEntity> services = null;
		List<CustomerDataEntity> customers = null;
		List<LaundryChargeDataEntity> charges = null;
		
		public LaundryViewPresenter(ILaundryView p_view, ILaundryDao p_laundryDao)
		{
			this.m_view = p_view;
			m_laundryDao = p_laundryDao;
			m_categoryDao = new LaundryCategoryDao();
			m_serviceDao = new LaundryServiceDao();
			m_customerDao = new CustomerDao();
			m_chargeDao = new LaundryChargeDao();
			m_summaryDao = new LaundryDaySummaryDao();
		}
		
		public void SaveClicked(){
			
			DateTime today = Convert.ToDateTime(DateTime.Now.ToShortDateString()); // daystamp in daysummary should be date only (no time);
			LaundryHeaderDataEntity headerEntity = m_view.HeaderDataEntity;			
			LaundryDaySummaryDataEntity daySummary = m_summaryDao.GetByDay(today);
			if(daySummary != null)
			{
				daySummary.TransCount += 1;
				//TODO: totalsales should be amounttender - amount change.
				daySummary.TotalSales += headerEntity.AmountTender;
				headerEntity.DaySummary = daySummary;
				
				// update daysummary with transcount and totalsales				
				m_summaryDao.Update(daySummary);
				m_laundryDao.SaveOrUpdate(headerEntity);
			
				
			}else{
				// set daysummary			
				daySummary = new LaundryDaySummaryDataEntity();
				daySummary.DayStamp = Convert.ToDateTime(DateTime.Now.ToShortDateString());
				//TODO: totalsales should be amounttender - amount change.			
				
				daySummary.TotalSales += headerEntity.AmountTender;
				daySummary.TransCount += 1;
				
				// set header entity in daysummary for nhibernate to pickup and map			
				daySummary.HeaderEntities.Add(headerEntity);
				// set daysummary entity in header for nhibernate to pickup and map
				headerEntity.DaySummary = daySummary;
				
				m_customerDao.SaveOrUpdate(headerEntity.Customer);				
				// save daysummary record; no need to explicitly save header,detail,jobcharges,paymentdetail, etc for new daysummary record
				// this will handle the saving for the linked tables				
				m_laundryDao.SaveOrUpdate(headerEntity);
			}		
			m_view.CloseView();
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
		
		public void SetAllCharges(){
			charges = m_chargeDao.GetAllItems() as List<LaundryChargeDataEntity>;
			m_view.SetAllCharges(charges);
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
		
		public decimal getAmtChargeByName(string name){			
			return m_chargeDao.GetByName(name).Amount;
		}
		
		public LaundryChargeDataEntity getJobChargeByName(string name){			
			return m_chargeDao.GetByName(name);
		}	
		
		public void getHeaderEntityByJONumber(int jonumber){
			m_view.LoadHeaderEntityData(m_laundryDao.GetByID(jonumber));			
		}
		
		public void LaunchChecklist(){
			m_view.LaunchChecklist();
		}
		
		public void getJobChargesByHeaderId(int headerID){
			
		}
	}
}

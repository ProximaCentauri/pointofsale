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
using NJournals.Common.Util;

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
		ILaundryPriceSchemeDao m_priceDao;
		ILaundryJobChargesDao m_jobChargeDao;
		ILaundryDao m_laundryDao;		
		ILaundryJobCheckListDao m_jobChecklistDao;
		ILaundryPaymentDetailDao m_paymentDetailDao;
		ILaundryChecklistDao m_checklistDao;
		List<LaundryCategoryDataEntity> categories = null;
		List<LaundryServiceDataEntity> services = null;
		List<CustomerDataEntity> customers = null;
		List<LaundryChargeDataEntity> charges = null;
		LaundryHeaderDataEntity m_headerEntity = null;
		LaundryHeaderDataEntity m_OriginalHeaderEntity = null;
		
		public LaundryViewPresenter(ILaundryView p_view, ILaundryDao p_laundryDao)
		{
			this.m_view = p_view;
			m_laundryDao = p_laundryDao;
			m_categoryDao = new LaundryCategoryDao();
			m_serviceDao = new LaundryServiceDao();
			m_customerDao = new CustomerDao();
			m_chargeDao = new LaundryChargeDao();
			m_summaryDao = new LaundryDaySummaryDao();
			m_priceDao = new LaundryPriceSchemeDao();
			m_jobChargeDao = new LaundryJobChargesDao();
			m_jobChecklistDao = new LaundryJobCheckListDao();
			m_paymentDetailDao = new LaundryPaymentDetailDao();
			m_checklistDao = new LaundryChecklistDao();
		}
		
		public void SaveClicked(){
			m_headerEntity = m_view.ProcessHeaderDataEntity();
			
			if(m_view.GetTitle().Contains("NEW")){
				SaveDaySummary(m_headerEntity);
			}else if(m_view.GetTitle().Contains("CLAIM")){								
				//TODO: process header details
				List<LaundryDetailDataEntity> m_origdetailEntities = m_OriginalHeaderEntity.DetailEntities as List<LaundryDetailDataEntity>;
				List<LaundryDetailDataEntity> m_newdetailEntities = new List<LaundryDetailDataEntity>();
				LaundryDetailDataEntity updatedDetail = null;
				foreach(LaundryDetailDataEntity detailEntity in m_headerEntity.DetailEntities){
					updatedDetail = new LaundryDetailDataEntity();
					updatedDetail = m_origdetailEntities.Find(x => x.Header.LaundryHeaderID == detailEntity.Header.LaundryHeaderID);
					
					if(updatedDetail != null){
						updatedDetail.ItemQty = detailEntity.ItemQty;
						updatedDetail.Kilo = detailEntity.Kilo;
						updatedDetail.Amount = detailEntity.Amount;
						m_newdetailEntities.Add(updatedDetail);
						//m_OriginalHeaderEntity.DetailEntities[index] = udpatedDetail;
					}
				}				
				if(updatedDetail != null)
					m_OriginalHeaderEntity.DetailEntities = m_newdetailEntities;
				
				//TODO: process payment detail
				m_OriginalHeaderEntity.PaymentDetailEntities = m_headerEntity.PaymentDetailEntities;
				
				/*List<LaundryPaymentDetailDataEntity> m_origPaymentEntities = m_OriginalHeaderEntity.PaymentDetailEntities as List<LaundryPaymentDetailDataEntity>;
				
				foreach(LaundryPaymentDetailDataEntity paymentEntity in m_headerEntity.PaymentDetailEntities){
					LaundryPaymentDetailDataEntity updatedPayment = m_origPaymentEntities.Find(x => x.Header.LaundryHeaderID == paymentEntity.Header.LaundryHeaderID);
					int index = m_origPaymentEntities.FindIndex(x => x.Header.LaundryHeaderID == paymentEntity.Header.LaundryHeaderID);
					if(updatedPayment != null){
						updatedPayment.Amount = paymentEntity.Amount;
					}
					m_OriginalHeaderEntity.PaymentDetailEntities[index] = updatedPayment;
				}*/
				//TODO: process jobcharges
				
				//TODO: process jobchecklist
				
				SaveDaySummary(m_OriginalHeaderEntity);
			}							
				
			MessageService.ShowInfo("Successfully saved entries.","Information");						
		}
		
		private void SaveDaySummary(LaundryHeaderDataEntity headerEntity){
			DateTime today = Convert.ToDateTime(DateTime.Now.ToShortDateString()); // daystamp in daysummary should be date only (no time);
			LaundryDaySummaryDataEntity daySummary = m_summaryDao.GetByDay(today);
			if(daySummary != null)
			{
				daySummary.TransCount += 1;
				//TODO: totalsales should be totalamoutdue - balance
				daySummary.TotalSales += headerEntity.PaymentDetailEntities[0].Amount;
				headerEntity.DaySummary = daySummary;
				
				// update daysummary with transcount and totalsales				
				m_summaryDao.Update(daySummary);					
				
				m_laundryDao.Update(headerEntity);
			}else{
				// set daysummary			
				daySummary = new LaundryDaySummaryDataEntity();
				daySummary.DayStamp = Convert.ToDateTime(DateTime.Now.ToShortDateString());
				//TODO: totalsales should be amounttender - amount change.			
				
				daySummary.TotalSales +=  headerEntity.PaymentDetailEntities[0].Amount;
				daySummary.TransCount += 1;
				
				// set header entity in daysummary for nhibernate to pickup and map			
				daySummary.HeaderEntities.Add(headerEntity);
				// set daysummary entity in header for nhibernate to pickup and map
				m_headerEntity.DaySummary = daySummary;
				//m_chargeDao.SaveOrUpdate(headerEntity.
				//m_customerDao.SaveOrUpdate(headerEntity.Customer);				
				// save daysummary record; no need to explicitly save header,detail,jobcharges,paymentdetail, etc for new daysummary record
				// this will handle the saving for the linked tables				
				m_laundryDao.SaveOrUpdate(headerEntity);
			}
		}
		
		private void SaveOrUpdateJobCheckList(){
			List<LaundryJobChecklistDataEntity> checklistEntities = m_jobChecklistDao.GetAllItemsByHeaderId(m_headerEntity.LaundryHeaderID) as List<LaundryJobChecklistDataEntity>;
			List<LaundryJobChecklistDataEntity> newChecklistEntities = m_headerEntity.JobChecklistEntities as List<LaundryJobChecklistDataEntity>;
			
			if(newChecklistEntities == null)
				return;
			
			foreach(LaundryJobChecklistDataEntity checklist in checklistEntities){					
				LaundryJobChecklistDataEntity m_entity = newChecklistEntities.Find(m_checklist => m_checklist.Checklist.ChecklistID == checklist.Checklist.ChecklistID);
				if(m_entity == null){
					m_jobChecklistDao.Delete(checklist);						
				}
			}
			  
			checklistEntities = m_jobChecklistDao.GetAllItemsByHeaderId(m_headerEntity.LaundryHeaderID) as List<LaundryJobChecklistDataEntity>;
			foreach(LaundryJobChecklistDataEntity checklist in newChecklistEntities){
				LaundryJobChecklistDataEntity m_entity = checklistEntities.Find(m_checklist => m_checklist.Checklist.ChecklistID == checklist.Checklist.ChecklistID);
				if(m_entity != null){	
					m_entity.Qty = checklist.Qty;						
					m_jobChecklistDao.Update(m_entity);	
				}else{//new entry
					m_jobChecklistDao.SaveOrUpdate(checklist);
				}					
			}
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
			
			LaundryPriceSchemeDataEntity priceEntity = new LaundryPriceSchemeDataEntity();			
			priceEntity = m_priceDao.GetByCategoryService(getServiceByName(p_service), getCategoryByName(p_category));
			return priceEntity;
		}		
		
		public CustomerDataEntity getCustomerByName(string name){
			return m_customerDao.GetByName(name);
		}
		
		public LaundryCategoryDataEntity getCategoryByName(string p_category){
			return m_categoryDao.GetByName(p_category);
		}
		
		public LaundryCategoryDataEntity getCategoryById(int p_categoryId){
			return m_categoryDao.GetById(p_categoryId);
		}
		
		public LaundryServiceDataEntity getServiceByName(string p_service){
			return m_serviceDao.GetByName(p_service);
		}
		
		public List<LaundryPriceSchemeDataEntity> getCategoriesByServiceID(int serviceID){
			return m_priceDao.GetAllItemsByServiceId(serviceID) as List<LaundryPriceSchemeDataEntity>;
		}
		
		public int getHeaderID(){
			List<LaundryHeaderDataEntity> headerEntities = m_laundryDao.GetAllItems() as List<LaundryHeaderDataEntity>;
			if(headerEntities.Count > 0){
				return headerEntities[headerEntities.Count-1].LaundryHeaderID + 1;
			}
			return 1;
		}
		
		public bool headerIDExist(int headerID){
			if(m_laundryDao.GetByID(headerID) != null)
				return true;
			return false;
		}
		
		public decimal getAmtChargeByName(string name){			
			return m_chargeDao.GetByName(name).Amount;
		}
		
		public LaundryChargeDataEntity getJobChargeByName(string name){			
			return m_chargeDao.GetByName(name);
		}	
		
		public void getHeaderEntityByJONumber(int jonumber){
			m_OriginalHeaderEntity = m_laundryDao.GetByID(jonumber);
			m_view.LoadHeaderEntityData(m_OriginalHeaderEntity);			
		}
		
		public List<LaundryJobChecklistDataEntity> GetJobChecklistByHeaderId(int p_id){
			return m_jobChecklistDao.GetAllItemsByHeaderId(p_id) as List<LaundryJobChecklistDataEntity>;
		}
		
		public void LaunchChecklist(){
			m_view.LaunchChecklist();	
		}
		
		public LaundryChecklistDataEntity GetChecklistByName(string p_name){
			return m_checklistDao.GetByName(p_name);
		}
		
	}
}

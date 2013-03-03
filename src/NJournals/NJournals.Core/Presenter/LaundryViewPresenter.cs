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
using System.Linq;

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
		ILaundryDetailDao m_detailDao;
		ILaundryPaymentDetailDao m_paymentDetailDao;		
		ILaundryChecklistDao m_checklistDao;
		
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
			m_detailDao = new LaundryDetailDao();
		}
		
		List<LaundryJobChargesDataEntity> new_ChargeEntities = null;
		List<LaundryJobChargesDataEntity> orig_ChargeEntities = null;
		List<LaundryDetailDataEntity> new_DetailEntities = null;
		List<LaundryJobChecklistDataEntity> orig_ChecklistEntities = null;
		List<LaundryJobChecklistDataEntity> new_ChecklistEntities = null;
		
		public void SaveClicked(){
			m_headerEntity = m_view.ProcessHeaderDataEntity();
			new_ChargeEntities = m_headerEntity.JobChargeEntities as List<LaundryJobChargesDataEntity>;
			new_DetailEntities = m_headerEntity.DetailEntities as List<LaundryDetailDataEntity>;
			new_ChecklistEntities = m_headerEntity.JobChecklistEntities as List<LaundryJobChecklistDataEntity>;
			if(m_view.GetTitle().Contains("NEW")){
				SaveDaySummary(m_headerEntity);
				if(MessageService.ShowYesNo("Successfully saved entries." + Environment.NewLine +
			                           "Do you want to print this transaction with JO number: " + m_headerEntity.LaundryHeaderID.ToString().PadLeft(6, '0') + "?" ,"Information")){
					try{
						PrintService.PrintLaundrySlip(null,m_headerEntity, null);
					}catch(Exception ex){
						MessageService.ShowError("Unexpected exception has occurred during printing. Please verify whether printer is installed and online. \n Please check error logs for details.", "Error in Printing", ex);	
					}
				}
			}else if(m_view.GetTitle().Contains("CLAIM")){								

				SaveUpdateDetails();						
				
				SaveOrDeleteJobCharges();
				
				SaveUpdateOrDeleteJobCheckList();			
				
				SaveDaySummary(m_OriginalHeaderEntity);
				
				MessageService.ShowInfo("Successfully saved entries.","Information");
			}									
		}	
		
		private void SaveUpdateOrDeleteJobCheckList(){
			if(new_ChecklistEntities == null)
				return;
			
			orig_ChecklistEntities = m_jobChecklistDao.GetAllItemsByHeaderId(m_headerEntity.LaundryHeaderID) as List<LaundryJobChecklistDataEntity>;
			
			var listToLookUp = new_ChecklistEntities.ToLookup(entity => entity.Checklist.ChecklistID);
			var listToDelete = orig_ChecklistEntities.Where(entity => (!listToLookUp.Contains(entity.Checklist.ChecklistID)));
			
			foreach(LaundryJobChecklistDataEntity entity in listToDelete.ToList()){
				m_jobChecklistDao.Delete(entity);
			}	
			
			orig_ChecklistEntities = m_jobChecklistDao.GetAllItemsByHeaderId(m_headerEntity.LaundryHeaderID) as List<LaundryJobChecklistDataEntity>;
			List<LaundryJobChecklistDataEntity> new_Checklist = new List<LaundryJobChecklistDataEntity>();
						
			foreach(LaundryJobChecklistDataEntity entity in orig_ChecklistEntities)
			{
				LaundryJobChecklistDataEntity checklist = new LaundryJobChecklistDataEntity();
				checklist = new_ChecklistEntities.Where(x => x.Checklist.ChecklistID == entity.Checklist.ChecklistID).FirstOrDefault();
				if(checklist != null)
				{
					entity.Qty = checklist.Qty;
					new_Checklist.Add(entity);
				}				
			}			
					
			var listToLookUpForAdd = orig_ChecklistEntities.ToLookup(entity => entity.Checklist.ChecklistID);		
			var listToAdd = new_ChecklistEntities.Where(entity => (!listToLookUpForAdd.Contains(entity.Checklist.ChecklistID)));
			foreach(LaundryJobChecklistDataEntity entity in listToAdd.ToList()){
				new_Checklist.Add(entity);
			}

			m_OriginalHeaderEntity.JobChecklistEntities = new_Checklist;		
		}
		
		private void SaveOrDeleteJobCharges(){
			if(m_headerEntity.JobChargeEntities != null){
				orig_ChargeEntities = m_jobChargeDao.GetAllItemsByHeaderId(m_OriginalHeaderEntity.LaundryHeaderID) as List<LaundryJobChargesDataEntity>;
				
				var listToLookUp = new_ChargeEntities.ToLookup(entity => entity.Charge.Name);
				var listDiff = orig_ChargeEntities.Where(entity => (!listToLookUp.Contains(entity.Charge.Name)));
				
				foreach(LaundryJobChargesDataEntity chargeEntity in listDiff.ToList()){
					m_jobChargeDao.Delete(chargeEntity);
				}
				
				orig_ChargeEntities = m_jobChargeDao.GetAllItemsByHeaderId(m_OriginalHeaderEntity.LaundryHeaderID) as List<LaundryJobChargesDataEntity>;
				
				var listToLookUp2 = orig_ChargeEntities.ToLookup(entity => entity.Charge.ChargeID);
				var listDiff2 = new_ChargeEntities.Where(entity => (!listToLookUp2.Contains(entity.Charge.ChargeID)));
				
				foreach(LaundryJobChargesDataEntity chargeEntity in listDiff2.ToList()){
					orig_ChargeEntities.Add(chargeEntity);
				}
				
				m_OriginalHeaderEntity.JobChargeEntities = orig_ChargeEntities;			
			}
		}
		
		private void SaveUpdateDetails(){
			//LaundryHeaderDataEntity headerData = m_laundryDao.GetByID(m_headerEntity.LaundryHeaderID);
			List<LaundryDetailDataEntity> detailData = m_detailDao.GetAllItemsByHeaderId(m_headerEntity.LaundryHeaderID) as List<LaundryDetailDataEntity>;
			
			var listToLookUp = detailData.ToLookup(entity => entity.Category.Name);
			var listToAdd = new_DetailEntities.Where(entity => (!listToLookUp.Contains(entity.Category.Name)));
			var listToUpdate = new_DetailEntities.Where(entity => listToLookUp.Contains(entity.Category.Name));
			List<LaundryDetailDataEntity> newDetailList = new List<LaundryDetailDataEntity>();
			
			foreach(LaundryDetailDataEntity detail in listToUpdate.ToList()){
				LaundryDetailDataEntity entity = new LaundryDetailDataEntity();
				LaundryDetailDataEntity m_entity = detailData.Find(x => x.Category.Name == detail.Category.Name && x.Service.Name == detail.Service.Name);
				if(m_entity != null){
					entity.ItemQty = detail.ItemQty;
					entity.Kilo = detail.Kilo;
					entity.Amount = detail.Amount;
					entity.Category = detail.Category;
					entity.Service = detail.Service;
					entity.Header = detail.Header;
					entity.ID = m_entity.ID;				
					newDetailList.Add(entity);
				}				
			}		
			
			foreach(LaundryDetailDataEntity detail in listToAdd.ToList()){
				newDetailList.Add(detail);
			}
			
			m_OriginalHeaderEntity.DetailEntities = newDetailList;	
		}
		
		private void SaveDaySummary(LaundryHeaderDataEntity headerEntity){
			DateTime today = Convert.ToDateTime(DateTime.Now.ToShortDateString()); // daystamp in daysummary should be date only (no time);
			LaundryDaySummaryDataEntity daySummary = m_summaryDao.GetByDay(today);
			
			headerEntity.PaymentDetailEntities = m_headerEntity.PaymentDetailEntities;
			
			if(daySummary != null)
			{
				if(m_view.GetTitle().Contains("NEW"))
					daySummary.TransCount += 1;
				//TODO: totalsales should be totalamoutdue - balance
				daySummary.TotalSales += headerEntity.PaymentDetailEntities[headerEntity.PaymentDetailEntities.Count-1].Amount;
				headerEntity.DaySummary = daySummary;
				
				// update daysummary with transcount and totalsales				
				m_summaryDao.Update(daySummary);				
			}else{
				// set daysummary			
				daySummary = new LaundryDaySummaryDataEntity();
				daySummary.DayStamp = Convert.ToDateTime(DateTime.Now.ToShortDateString());
				//TODO: totalsales should be amounttender - amount change.			
				
				
				
				daySummary.TotalSales +=  headerEntity.PaymentDetailEntities[headerEntity.PaymentDetailEntities.Count-1].Amount;
				if(m_view.GetTitle().Contains("NEW"))
					daySummary.TransCount += 1;
				
				// set header entity in daysummary for nhibernate to pickup and map			
				daySummary.HeaderEntities.Add(headerEntity);
				// set daysummary entity in header for nhibernate to pickup and map
				m_headerEntity.DaySummary = daySummary;
				//m_chargeDao.SaveOrUpdate(headerEntity.
				//m_customerDao.SaveOrUpdate(headerEntity.Customer);				
				// save daysummary record; no need to explicitly save header,detail,jobcharges,paymentdetail, etc for new daysummary record
				// this will handle the saving for the linked tables								
			}
			m_laundryDao.SaveOrUpdate(headerEntity);
			
		}
		
		public void CancelClicked(){
			m_view.CloseView();
		}
		
		public void AddNewItemClicked(){
			m_view.AddItem();
		}
		
		
		public void SetAllServices(){
			List<LaundryServiceDataEntity> serviceEntities = GetAllServiceInPriceScheme();
			m_view.SetAllServices(serviceEntities);
		}
		
		public void SetAllCustomers(){
			customers = m_customerDao.GetAllItems() as List<CustomerDataEntity>;
			m_view.SetAllCustomers(customers);
		}
		
		public void SetAllCharges(){
			charges = m_chargeDao.GetAllItems() as List<LaundryChargeDataEntity>;
			m_view.SetAllCharges(charges);
		}
		
		private List<LaundryServiceDataEntity> GetAllServiceInPriceScheme(){
			List<LaundryServiceDataEntity> m_services = m_serviceDao.GetAllItems() as List<LaundryServiceDataEntity>;
			List<LaundryPriceSchemeDataEntity> priceEntities = m_priceDao.GetAllItems() as List<LaundryPriceSchemeDataEntity>;
			var listToLookUp = priceEntities.ToLookup(id => id.Service.ServiceID);
			var ids = m_services.Where(entity => (listToLookUp.Contains(entity.ServiceID)));
			
			return ids.ToList() as List<LaundryServiceDataEntity>;			
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
		
		public void LaunchCharges(){
			m_view.LaunchCharges();
		}
		
		public LaundryChecklistDataEntity GetChecklistByName(string p_name){
			return m_checklistDao.GetByName(p_name);
		}
		
		public void LaunchCustomerSearch()
		{
			m_view.LaunchCustomerSearch();
		}
		
		public void VoidingTransaction(){
			
			m_OriginalHeaderEntity.VoidFlag = true;
			try{
				m_laundryDao.Update(m_OriginalHeaderEntity);	
				LaundryDaySummaryDataEntity daysummary = m_summaryDao.GetByDayId(m_OriginalHeaderEntity.DaySummary.DayID);
				daysummary.TotalSales -= m_OriginalHeaderEntity.TotalPayment;
				daysummary.TransCount -= 1;
				m_summaryDao.Update(daysummary);
				MessageService.ShowInfo("Successfully voiding the transaction with JO number: " + m_OriginalHeaderEntity.LaundryHeaderID.ToString().PadLeft(6, '0'));
				m_view.VoidingTransaction();	
			}catch(Exception ex){
				MessageService.ShowError("There is a problem while void this transaction." + Environment.NewLine + ex.Message,"Error in Voiding Transaction", ex);
			}		
					
		}
		
		public void ClaimTransaction(){
			if(m_view.ClaimTransaction())
			{
				m_OriginalHeaderEntity.ClaimDate = DateTime.Now;			
				m_OriginalHeaderEntity.ClaimFlag = true;
				SaveClicked();							
				m_view.CloseView();
			}			
		}
		
		public void PrintTransaction(){
			m_headerEntity = m_view.ProcessHeaderDataEntity();
			if(m_headerEntity != null){			
				MessageService.ShowInfo("Printing transaction with JO number: " + m_headerEntity.LaundryHeaderID.ToString().PadLeft(6, '0'));
					
				try{
					PrintService.PrintLaundrySlip(null,m_headerEntity, null);
				}catch(Exception ex){
					MessageService.ShowError("Unexpected exception has occurred during printing. Please verify whether printer is installed and online. \n Please check error logs for details.", "Error in Printing", ex);
					
				}

			}					
		}
	}
}

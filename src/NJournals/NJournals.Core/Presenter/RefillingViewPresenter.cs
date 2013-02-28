/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 2/8/2013
 * Time: 2:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NJournals.Common.Interfaces;
using NJournals.Common.DataEntities;
using NJournals.Core.Models;
using NJournals.Core.Views;
using System.Collections.Generic;
using NJournals.Common.Util;
using System.Configuration;

namespace NJournals.Core.Presenter
{
	/// <summary>
	/// Description of RefillingViewPresenter.
	/// </summary>
	public class RefillingViewPresenter
	{
		IRefillingView m_view;
		IRefillDao m_refillDao;
		ICustomerDao m_customerDao;
		IRefillTransactionTypeDao m_transTypeDao;
		IRefillProductTypeDao m_productDao;
		IRefillDaySummaryDao m_summaryDao;
		IRefillCustomerInventoryDao m_customerInvDao;
		IRefillInventoryDao m_refillInvDao;
				
		List<CustomerDataEntity> customers = null;
		List<RefillTransactionTypeDataEntity> transactionTypes = null;
		List<RefillProductTypeDataEntity> products = null;	
		RefillHeaderDataEntity m_headerEntity = null;	
		RefillHeaderDataEntity m_OriginalHeaderEntity = null;		
		
		public RefillingViewPresenter(IRefillingView p_view, IRefillDao p_refillDao)
		{
			this.m_view = p_view;
			this.m_refillDao = p_refillDao;
			this.m_transTypeDao = new RefillTransactionTypeDao();
			this.m_customerDao = new CustomerDao();
			this.m_productDao = new RefillProductTypeDao();		
			m_summaryDao = new RefillDaySummaryDao();
			m_customerInvDao = new RefillCustomerInventoryDao();
			m_refillInvDao = new RefillInventoryDao();
		}
		
		public void SetAllCustomers(){
			customers = m_customerDao.GetAllItems() as List<CustomerDataEntity>;
			m_view.SetAllCustomers(customers);
		}
		
		public void SetAllTransactionTypes(){
			transactionTypes = m_transTypeDao.GetAllItems() as List<RefillTransactionTypeDataEntity>;
			m_view.SetAllTransactionTypes(transactionTypes);
		}
		
		public void SetAllProducts(){
			products = m_productDao.GetAllItems() as List<RefillProductTypeDataEntity>;
			m_view.SetAllProducts(products);
		}
		
		public int getHeaderID(){
			List<RefillHeaderDataEntity> refillHeader = m_refillDao.GetAllItems() as List<RefillHeaderDataEntity>;
			if(refillHeader.Count > 0){
				return refillHeader[refillHeader.Count-1].RefillHeaderID + 1;
			}
			return 1;
		}
		
		public void AddNewItemClicked(){
			m_view.AddItem();
		}
		
		public decimal getAmtChargeByName(string name){			
			return m_productDao.GetByName(name).Price;
		}
		
		public void PrintClicked(){
			m_headerEntity = m_view.ProcessHeaderDataEntity();
			if(SaveDaySummary(m_headerEntity)){
				UpdateRefillCustomerInventory(m_headerEntity);
				MessageService.ShowInfo("Successfully saved the entries.","Save");
			}
				
		}
		
		private void UpdateRefillCustomerInventory(RefillHeaderDataEntity headerEntity){
			RefillInventoryHeaderDataEntity inventoryHeader = new RefillInventoryHeaderDataEntity();
			RefillCustInventoryHeaderDataEntity customerInvHeader = new RefillCustInventoryHeaderDataEntity();
			customerInvHeader.Customer = headerEntity.Customer;
			foreach(RefillDetailDataEntity detail in headerEntity.DetailEntities){
				if(detail.ProductType.Name.StartsWith("5 Gal",true,null)){
					inventoryHeader = m_refillInvDao.GetByName("5 Gal");
					if(inventoryHeader != null){
						inventoryHeader.QtyOnHand -= detail.StoreBottleQty;
						inventoryHeader.QtyReleased += detail.StoreBottleQty;
						customerInvHeader.CapsOnHand += detail.StoreCapQty;
						customerInvHeader.BottlesOnHand += detail.StoreBottleQty;
						m_refillInvDao.Update(inventoryHeader);
						m_customerInvDao.SaveOrUpdate(customerInvHeader);
					}		
				}						
			}			
		}
		
		public void VoidTransaction(){
			try{
				m_OriginalHeaderEntity.VoidFlag = true;
				m_refillDao.Update(m_OriginalHeaderEntity);
				RefillDaySummaryDataEntity daySummary = m_summaryDao.GetByDayId(m_OriginalHeaderEntity.DaySummary.DayID);
				daySummary.TotalSales -= m_OriginalHeaderEntity.AmountTender;
				daySummary.TransCount -= 1;
				m_summaryDao.Update(daySummary);
					
				RefillInventoryHeaderDataEntity inventoryHeader = new RefillInventoryHeaderDataEntity();
				RefillCustInventoryHeaderDataEntity customerInvHeader = m_customerInvDao.GetByCustomer(m_OriginalHeaderEntity.Customer);
				foreach(RefillDetailDataEntity detail in m_OriginalHeaderEntity.DetailEntities){
					if(detail.ProductType.Name.StartsWith("5 Gal",true,null)){
						inventoryHeader = m_refillInvDao.GetByName("5 Gal");
						if(inventoryHeader != null){
							inventoryHeader.QtyOnHand += detail.StoreBottleQty;
							inventoryHeader.QtyReleased -= detail.StoreBottleQty;
							customerInvHeader.CapsOnHand -= detail.StoreCapQty;
							customerInvHeader.BottlesOnHand -= detail.StoreBottleQty;
							m_refillInvDao.Update(inventoryHeader);
							m_customerInvDao.SaveOrUpdate(customerInvHeader);
						}		
					}							
				}		
			}catch(Exception ex){
				MessageService.ShowError("There is a problem while void this transaction." ,"Error in Voiding Transaction", ex);
			}			
		}
		
		private bool SaveDaySummary(RefillHeaderDataEntity headerEntity){		
			try{
				DateTime today = Convert.ToDateTime(DateTime.Now.ToShortDateString()); // daystamp in daysummary should be date only (no time);
				RefillDaySummaryDataEntity daySummary = m_summaryDao.GetByDay(today);
				if(daySummary != null)
				{
					daySummary.TransCount += 1;
					//TODO: totalsales should be totalamoutdue - balance
					daySummary.TotalSales += headerEntity.PaymentDetailEntities[0].Amount;
					headerEntity.DaySummary = daySummary;
					
					// update daysummary with transcount and totalsales				
					m_summaryDao.Update(daySummary);				
				}else{
					// set daysummary			
					daySummary = new RefillDaySummaryDataEntity();
					daySummary.DayStamp = Convert.ToDateTime(DateTime.Now.ToShortDateString());
					//TODO: totalsales should be amounttender - amount change.			
					
					daySummary.TotalSales +=  headerEntity.PaymentDetailEntities[0].Amount;
					daySummary.TransCount += 1;
					
					// set header entity in daysummary for nhibernate to pickup and map			
					daySummary.HeaderEntities.Add(headerEntity);
					// set daysummary entity in header for nhibernate to pickup and map
					headerEntity.DaySummary = daySummary;
					//m_chargeDao.SaveOrUpdate(headerEntity.
					//m_customerDao.SaveOrUpdate(headerEntity.Customer);				
					// save daysummary record; no need to explicitly save header,detail,jobcharges,paymentdetail, etc for new daysummary record
					// this will handle the saving for the linked tables								
				}
				m_refillDao.SaveOrUpdate(headerEntity);
				return true;
			}catch(Exception ex){
				MessageService.ShowError("There's been a problem while processing this request.", "Error in saving", ex);
			}	
			return false;
		}
		
		public CustomerDataEntity getCustomerByName(string name){
			return m_customerDao.GetByName(name);
		}
		
		public RefillTransactionTypeDataEntity getTransactionTypeByName(string name){
			return m_transTypeDao.GetByName(name);
		}
		
		public RefillProductTypeDataEntity getProductByName(string name){
			return m_productDao.GetByName(name);
		}
		
		public RefillHeaderDataEntity getHeaderByJoNumber(int id){
			m_OriginalHeaderEntity = m_refillDao.GetByID(id);
			return m_OriginalHeaderEntity;
		}
		
		public void loadHeaderEntity(){
			m_view.LoadHeaderEntityData(m_OriginalHeaderEntity);
		}
	}
}

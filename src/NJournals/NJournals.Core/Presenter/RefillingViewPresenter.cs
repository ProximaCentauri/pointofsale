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
		IRefillInventoryDetailDao m_refillInvDetailDao;
				
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
			m_refillInvDetailDao = new RefillInventoryDetailDao();
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
		
		public void SaveClicked(){
			m_headerEntity = m_view.ProcessHeaderDataEntity();
			if(SaveDaySummary(m_headerEntity)){
				UpdateRefillCustomerInventory(m_headerEntity);
				if(MessageService.ShowYesNo("Successfully saved entries." + Environment.NewLine +
				                            "Do you want to print this transaction with JO number: " + m_headerEntity.RefillHeaderID.ToString().PadLeft(6, '0') + "?" ,"Information")){
					PrintService.PrintRefillSlip(null,m_headerEntity, null);

				}
			}
		}
		
		private void UpdateRefillCustomerInventory(RefillHeaderDataEntity headerEntity){
			RefillInventoryHeaderDataEntity inventoryHeader = new RefillInventoryHeaderDataEntity();
			RefillCustInventoryHeaderDataEntity customerInvHeader = m_customerInvDao.GetByCustomer(headerEntity.Customer);
			if(customerInvHeader == null){
				customerInvHeader = new RefillCustInventoryHeaderDataEntity();
				customerInvHeader.Customer = headerEntity.Customer;	
			}			
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
						UpdateCapsQty(detail, customerInvHeader, false);
						UpdateInventoryDetail(inventoryHeader);
					}		
				}
			}			
		}
		
		public void UpdateInventoryDetail(RefillInventoryHeaderDataEntity p_inventoryHeader){
			if(p_inventoryHeader != null){
				DateTime today = Convert.ToDateTime(DateTime.Now.ToShortDateString());
				RefillInventoryDetailDataEntity inventoryDetail = m_refillInvDetailDao.GetDetailDay(p_inventoryHeader, today);
				if(inventoryDetail == null){
					inventoryDetail = new RefillInventoryDetailDataEntity();
				}
				inventoryDetail.Header = p_inventoryHeader;
				inventoryDetail.Date = today;
				inventoryDetail.QtyAdded = 0;
				inventoryDetail.QtyOnHand = p_inventoryHeader.QtyOnHand;
				inventoryDetail.QtyReleased = p_inventoryHeader.QtyReleased;
				inventoryDetail.QtyRemoved = 0;
				inventoryDetail.TotalQty = p_inventoryHeader.TotalQty;					
				m_refillInvDetailDao.SaveOrUpdate(inventoryDetail);
			}
		}
		
		private void UpdateCapsQty(RefillDetailDataEntity detail, RefillCustInventoryHeaderDataEntity customerInvHeader, bool voided){
			RefillInventoryHeaderDataEntity inventoryHeader = new RefillInventoryHeaderDataEntity();
			inventoryHeader = m_refillInvDao.GetByName("Caps");
			if(inventoryHeader != null){
				if(!voided){
					inventoryHeader.QtyOnHand -= detail.StoreCapQty;
					inventoryHeader.QtyReleased += detail.StoreCapQty;
					customerInvHeader.CapsOnHand += detail.StoreCapQty;
				}else{
					inventoryHeader.QtyOnHand += detail.StoreCapQty;
					inventoryHeader.QtyReleased -= detail.StoreCapQty;
					customerInvHeader.CapsOnHand -= detail.StoreCapQty;
				}
				m_refillInvDao.Update(inventoryHeader);
				UpdateInventoryDetail(inventoryHeader);
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
							UpdateCapsQty(detail, customerInvHeader, true);
							UpdateInventoryDetail(inventoryHeader);
						}		
					}							
				}		
				MessageService.ShowInfo("Successfully voiding transaction with JO number: " + m_OriginalHeaderEntity.RefillHeaderID.ToString().PadLeft(6, '0'));
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
		
		public void PrintTransaction(){
			m_headerEntity = m_view.ProcessHeaderDataEntity();
			if(m_headerEntity != null){
				MessageService.ShowInfo("Printing transaction...");
				PrintService.PrintRefillSlip(null,m_headerEntity, null);	

			}			
			
		}
	}
}

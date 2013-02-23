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
		
		List<CustomerDataEntity> customers = null;
		List<RefillTransactionTypeDataEntity> transactionTypes = null;
		List<RefillProductTypeDataEntity> products = null;	
		RefillHeaderDataEntity m_headerEntity = null;		
		
		public RefillingViewPresenter(IRefillingView p_view, IRefillDao p_refillDao)
		{
			this.m_view = p_view;
			this.m_refillDao = p_refillDao;
			this.m_transTypeDao = new RefillTransactionTypeDao();
			this.m_customerDao = new CustomerDao();
			this.m_productDao = new RefillProductTypeDao();		
			m_summaryDao = new RefillDaySummaryDao();
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
		
		public decimal getAmtChargeByName(string name){			
			return m_productDao.GetByName(name).Price;
		}
		
		public void PrintClicked(){
			m_headerEntity = m_view.ProcessHeaderDataEntity();
			SaveDaySummary(m_headerEntity);
		}
		
		private void SaveDaySummary(RefillHeaderDataEntity headerEntity){
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
				m_headerEntity.DaySummary = daySummary;
				//m_chargeDao.SaveOrUpdate(headerEntity.
				//m_customerDao.SaveOrUpdate(headerEntity.Customer);				
				// save daysummary record; no need to explicitly save header,detail,jobcharges,paymentdetail, etc for new daysummary record
				// this will handle the saving for the linked tables								
			}
			m_refillDao.SaveOrUpdate(headerEntity);
			
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
	}
}

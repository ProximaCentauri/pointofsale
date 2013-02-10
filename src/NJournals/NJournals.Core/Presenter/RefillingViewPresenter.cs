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
		List<CustomerDataEntity> customers = null;
		List<RefillTransactionTypeDataEntity> transactionTypes = null;
		List<RefillProductTypeDataEntity> products = null;		
		
		public RefillingViewPresenter(IRefillingView p_view, IRefillDao p_refillDao)
		{
			this.m_view = p_view;
			this.m_refillDao = p_refillDao;
			this.m_transTypeDao = new RefillTransactionTypeDao();
			this.m_customerDao = new CustomerDao();
			this.m_productDao = new RefillProductTypeDao();			
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
	}
}

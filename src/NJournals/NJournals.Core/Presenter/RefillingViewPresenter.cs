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
		IRefillTransactionTypeDao m_transTypeDao;
		List<CustomerDataEntity> customers = null;
		List<RefillTransactionTypeDataEntity> transactionTypes = null;
			
		public RefillingViewPresenter(IRefillingView p_view, IRefillDao p_refillDao)
		{
			this.m_view = p_view;
			this.m_refillDao = p_refillDao;
			this.m_transTypeDao = new RefillTransactionTypeDao();
		}
		
		public void SetAllCustomers(){
			customers = m_customerDao.GetAllItems() as List<CustomerDataEntity>;
			m_view.SetAllCustomers(customers);
		}
		
		public void SetAllTransactionTypes(){
			transactionTypes = m_transTypeDao.GetAllItems() as List<RefillTransactionTypeDataEntity>;
		}
	}
}

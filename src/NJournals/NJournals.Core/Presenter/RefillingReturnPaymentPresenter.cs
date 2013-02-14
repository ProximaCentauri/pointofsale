/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/14/2013
 * Time: 7:04 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NJournals.Common.Interfaces;
using NJournals.Core.Models;
using NJournals.Common.DataEntities;
using System.Collections.Generic;
using System.Data;

namespace NJournals.Core.Presenter
{
	/// <summary>
	/// Description of RefillingReturnPaymentPresenter.
	/// </summary>
	public class RefillingReturnPaymentPresenter
	{
		IRefillReturnPaymentView m_view;
		ICustomerDao m_customerDao;
		IRefillDao m_refillDao;		
		IRefillCustomerInventoryDao m_custInvDao;		
		CustomerDataEntity customer;
		RefillCustInventoryHeaderDataEntity custInv ;
		
		public RefillingReturnPaymentPresenter(IRefillReturnPaymentView m_view)
		{
			this.m_view = m_view;
			m_customerDao = new CustomerDao();
			m_refillDao = new RefillDao();
			m_custInvDao = new RefillCustomerInventoryDao();
			customer = new CustomerDataEntity();
			custInv = new RefillCustInventoryHeaderDataEntity();
		}
		
		public void SetAllCustomers()
		{
			List<CustomerDataEntity> customers = m_customerDao.GetAllItems() as List<CustomerDataEntity>;
			m_view.SetAllCustomers(customers);
		}
		
		public void GetRefillJOsByCustomer(string customerName)
		{
			customer = m_customerDao.GetByName(customerName) as CustomerDataEntity;
			List<RefillHeaderDataEntity> refillHeaders = m_refillDao.GetByCustomer(customer) as List<RefillHeaderDataEntity>;
			custInv = m_custInvDao.GetByCustomer(customer) as RefillCustInventoryHeaderDataEntity;
			m_view.LoadRefillHeaderAndInventoryData(refillHeaders, custInv);
		}
		
		public void UpdateCustomerInventory(int returnedBottles, int returnedCaps, DateTime returnDate)
		{			
			custInv.BottlesReturned += returnedBottles;
			custInv.CapsOnHand += returnedCaps;
			
			RefillCustInventoryDetailDataEntity detail = new RefillCustInventoryDetailDataEntity();
			detail.BottlesReturned = returnedBottles;
			detail.CapsReturned = returnedCaps;
			detail.Date = returnDate;
			detail.Header = custInv;
			custInv.DetailEntities.Add(detail);
			m_custInvDao.SaveOrUpdate(custInv);						
		}
	}
}

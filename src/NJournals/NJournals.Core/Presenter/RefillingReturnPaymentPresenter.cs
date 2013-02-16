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
using NJournals.Common.Util;

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
			try
			{
				List<CustomerDataEntity> customers = m_customerDao.GetAllItems() as List<CustomerDataEntity>;
				m_view.SetAllCustomers(customers);
			}
			catch(Exception ex)
			{
				MessageService.ShowInfo("Unable to display data; an unexpected error occurred.\n" +
				                        "Please check error log for details.","Error");
				LogHelper.Log(ex.Message,LogType.ERR,false);
			}
		}
		
		public void GetRefillJOsByCustomer(string customerName)
		{
			try
			{
				customer = m_customerDao.GetByName(customerName) as CustomerDataEntity;
				List<RefillHeaderDataEntity> refillHeaders = m_refillDao.GetByCustomer(customer) as List<RefillHeaderDataEntity>;
				custInv = m_custInvDao.GetByCustomer(customer) as RefillCustInventoryHeaderDataEntity;
				if(custInv == null && refillHeaders.Count == 0)
				{
					MessageService.ShowInfo("No records found for customer: " + customerName);
					return;
				}				
				m_view.LoadRefillHeaderAndInventoryData(refillHeaders, custInv);
			}
			catch(Exception ex)
			{
				MessageService.ShowInfo("Unable to display data; an unexpected error occurred.\n" +
				                        "Please check error log for details.","Error");
				LogHelper.Log(ex.Message,LogType.ERR,false);
			}
		}
		
		public void UpdateCustomerInventory(int returnedBottles, int returnedCaps, DateTime returnDate)
		{			
			try
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
				
				// TODO: update inventory header - qtyonhand & releases
			}
			catch(Exception ex)
			{								
				throw ex;				
			}
		}
		
		public void UpdateCustomerRefillHeaders(decimal amtTender, List<RefillHeaderDataEntity> refillHeaders)
		{
			try
			{
				decimal balance = 0.00M;				
				foreach(RefillHeaderDataEntity header in refillHeaders)
				{					
					balance = header.AmountDue - header.AmountTender;
					if(amtTender >= balance)
					{
						header.AmountTender += balance;
						amtTender -= balance;
						header.PaymentDetailEntities.Add(CreateNewPayment(balance, header));
						m_refillDao.SaveOrUpdate(header);						
					}
					else if(amtTender < balance)
					{
						header.AmountTender += amtTender;
						header.PaymentDetailEntities.Add(CreateNewPayment(amtTender, header));
						m_refillDao.SaveOrUpdate(header);
						amtTender = 0.00M;
					}
					if(amtTender <= 0.00M)
					{
						break;
					}
				}			
			}
			catch(Exception ex)
			{				
				throw ex;				
			}
		}
		
		private RefillPaymentDetailDataEntity CreateNewPayment(decimal amount, RefillHeaderDataEntity header)
		{
			RefillPaymentDetailDataEntity payment = new RefillPaymentDetailDataEntity();
			payment.Header = header;
			payment.Amount = amount;
			payment.PaymentDate = DateTime.Now;			
			return payment;
		}
	}
}

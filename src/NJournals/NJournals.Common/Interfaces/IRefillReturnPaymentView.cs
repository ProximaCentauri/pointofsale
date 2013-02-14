/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/14/2013
 * Time: 7:00 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NJournals.Common.DataEntities;
using System.Collections.Generic;

namespace NJournals.Common.Interfaces
{
	/// <summary>
	/// Description of IRefillReturnPaymentView.
	/// </summary>
	public interface IRefillReturnPaymentView : IView
	{		
		void SetAllCustomers(List<CustomerDataEntity> customers);
		void LoadRefillHeaderAndInventoryData(List<RefillHeaderDataEntity> headers, 
		                                      RefillCustInventoryHeaderDataEntity custInv);
		
	}
}

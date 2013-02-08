/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 1/31/2013
 * Time: 4:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NJournals.Common.DataEntities;
using System.Collections.Generic;
namespace NJournals.Common.Interfaces
{
	/// <summary>
	/// Description of IRefillingView.
	/// </summary>
	public interface IRefillingView : IView
	{
		void SetAllCustomers(List<CustomerDataEntity> customers);
		void SetAllTransactionTypes(List<RefillTransactionTypeDataEntity> transactionTypes);
		void SetAllProducts(List<RefillProductTypeDataEntity> products);
	}
}

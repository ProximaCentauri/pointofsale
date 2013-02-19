/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/19/2013
 * Time: 7:36 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NJournals.Common.DataEntities;
using System.Collections.Generic;

namespace NJournals.Common.Interfaces
{
	/// <summary>
	/// Description of ILaundryCustomerSearchView.
	/// </summary>
	public interface ILaundryCustomerSearchView
	{
		void SetAllUnclaimedItems(List<LaundryHeaderDataEntity> unclaimeditems);
		void SetAllUnpaidTransactions(List<LaundryHeaderDataEntity> unpaidtransactions);
	}
}

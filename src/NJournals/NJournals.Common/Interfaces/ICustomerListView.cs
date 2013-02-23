/*
 * Created by SharpDevelop.
 * User: vo185003
 * Date: 2/21/2013
 * Time: 2:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NJournals.Common.DataEntities;
using System.Collections.Generic;

namespace NJournals.Common.Interfaces
{
	/// <summary>
	/// Description of ICustomerListView.
	/// </summary>
	public interface ICustomerListView : IView
	{
		void SetAllCustomerList(List<CustomerDataEntity> customers);
		void ViewCustomersByName(List<CustomerDataEntity> customers);
	}
}

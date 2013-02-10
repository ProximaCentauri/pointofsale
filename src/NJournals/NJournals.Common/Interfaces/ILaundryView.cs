/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 1/30/2013
 * Time: 12:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NJournals.Common.DataEntities;
using System.Collections.Generic;
namespace NJournals.Common.Interfaces
{
	/// <summary>
	/// Description of ILaundryView.
	/// </summary>
	public interface ILaundryView : IView
	{
		//LaundryCategoryDataEntity CategoryDataEntity{get;set;}
		LaundryHeaderDataEntity HeaderDataEntity{get;set;}
		//LaundryDetailDataEntity DetailDataEntity{get;set;}
		
		
		void SetAllCategories(List<LaundryCategoryDataEntity> categories);
		void SetAllServices(List<LaundryServiceDataEntity> services);		
		void SetAllCustomers(List<CustomerDataEntity> customers);		
		void SetAllCharges(List<LaundryChargeDataEntity> charges);
		void LaunchChecklist();
		void AddItem();
		
	}
}

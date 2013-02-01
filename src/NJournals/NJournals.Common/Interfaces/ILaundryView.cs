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
		
		void SetAllCategories(IList<LaundryCategoryDataEntity> categories);
		void SetAllServices(IList<LaundryServiceDataEntity> services);		
		void Save(LaundryDaySummaryDataEntity entities);
		
	}
}

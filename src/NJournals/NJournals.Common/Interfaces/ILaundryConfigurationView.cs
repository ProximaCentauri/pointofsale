/*
 * Created by SharpDevelop.
 * User: vo185003
 * Date: 2/6/2013
 * Time: 9:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NJournals.Common.DataEntities;
using System.Collections.Generic;

namespace NJournals.Common.Interfaces
{
	/// <summary>
	/// Description of ILaundryConfigurationView.
	/// </summary>
	public interface ILaundryConfigurationView : IView
	{
		
		void SetAllCategories(List<LaundryCategoryDataEntity> categories);
		void SetAllServices(List<LaundryServiceDataEntity> services);
		void SetAllPriceScheme(List<LaundryPriceSchemeDataEntity> priceScheme);
	}
}

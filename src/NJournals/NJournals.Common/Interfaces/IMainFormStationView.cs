/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 1/30/2013
 * Time: 10:34 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NJournals.Common.Interfaces
{
	/// <summary>
	/// Description of IMainFormView.
	/// </summary>
	public interface IMainFormStationView : IView
	{		
		event EventHandler SelectLaundryNew;
		event EventHandler SelectLaundryClaim;
		event EventHandler SelectLaundryReport;
		event EventHandler SelectLaundryConfiguration;
		event EventHandler SelectRefillingNew;
		event EventHandler SelectRefillingClaim;
		event EventHandler SelectRefillingReport;
		event EventHandler SelectRefillingConfiguration;
		event EventHandler SelectCustomerList;
		event EventHandler SelectRefillingDelete;
		event EventHandler SelectCompany;
		
		void ShowLaundryNewView();
		void ShowCompanyView();
		void ShowLaundryClaimView();
		void ShowRefillingNewView();
		void ShowRefillingDeleteView();
		void ShowRefillingClaimView();
		void ShowLaundryReportView();
		void ShowRefillingReportView();
		void ShowLaundryConfigurationView();
		void ShowRefillingConfigurationView();
		void ShowCustomerListView();
	}
}

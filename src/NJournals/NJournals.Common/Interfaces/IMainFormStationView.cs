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
	public interface IMainFormStationView
	{		
		event EventHandler SelectLaundryNew;
		event EventHandler SelectLaundryClaim;
		event EventHandler SelectLaundryReport;
		event EventHandler SelectLaundryConfiguration;
		event EventHandler SelectRefillingNew;
		event EventHandler SelectRefillingClaim;
		event EventHandler SelectRefillingReport;
		event EventHandler SelectRefillingConfiguration;
		
		void CloseWindow();
		void ShowLaundryView();
		void ShowRefillingView();
		void ShowReportView();
	}
}

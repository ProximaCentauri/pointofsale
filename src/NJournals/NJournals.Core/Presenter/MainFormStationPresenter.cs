﻿/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 1/30/2013
 * Time: 10:40 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NJournals.Common.Interfaces;
using NJournals.Core.Views;
namespace NJournals.Core.Presenter
{
	/// <summary>
	/// Description of MainFormStationPresenter.
	/// </summary>
	public class MainFormStationPresenter
	{
		IMainFormStationView m_view;
		public MainFormStationPresenter(IMainFormStationView p_view)
		{
			this.m_view = p_view;
			this.m_view.SelectLaundryNew += delegate { ShowLaundryNewView(); };
			this.m_view.SelectLaundryClaim += delegate { ShowLaundryClaimView(); };
			this.m_view.SelectRefillingNew += delegate { ShowRefillingNewView(); };
			this.m_view.SelectRefillingClaim += delegate { ShowRefillingClaimView(); };
			this.m_view.SelectRefillingReport += delegate { ShowRefillingReportView(); };
			this.m_view.SelectLaundryReport += delegate { ShowLaundryReportView(); };
			this.m_view.SelectLaundryConfiguration += delegate { ShowLaundryConfigurationView(); };
			this.m_view.SelectRefillingConfiguration += delegate { ShowRefillingConfigurationView(); };
		}
		
		public void ShowLaundryNewView(){
			this.m_view.ShowLaundryNewView();
		}
		
		public void ShowLaundryClaimView(){
			this.m_view.ShowLaundryClaimView();
		}
		
		public void ShowRefillingNewView(){
			this.m_view.ShowRefillingNewView();
		}
		
		public void ShowRefillingClaimView(){
			this.m_view.ShowRefillingClaimView();
		}
		
		public void ShowLaundryReportView(){
			this.m_view.ShowLaundryReportView();
		}
		
		public void ShowRefillingReportView(){
			this.m_view.ShowRefillingReportView();
		}
		
		public void ShowLaundryConfigurationView(){
			this.m_view.ShowLaundryConfigurationView();
		}
		
		public void ShowRefillingConfigurationView(){
			this.m_view.ShowRefillingConfigurationView();
		}
		
	}
}
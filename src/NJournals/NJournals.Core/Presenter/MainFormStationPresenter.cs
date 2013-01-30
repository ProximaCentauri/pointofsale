/*
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
			this.m_view.SelectLaundryNew += delegate { ShowLaundryView(); };
			this.m_view.SelectRefillingNew += delegate { ShowRefillingView(); };
			this.m_view.SelectRefillingReport += delegate { ShowReportView(); };
		}
		
		public void ShowLaundryView(){
			this.m_view.ShowLaundryView();
		}
		
		public void ShowRefillingView(){
			this.m_view.ShowRefillingView();
		}
		
		public void ShowReportView(){
			this.m_view.ShowReportView();
		}
		
	}
}

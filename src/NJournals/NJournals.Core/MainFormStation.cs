/*
 * Created by SharpDevelop.
 * User: vo185003
 * Date: 1/25/2013
 * Time: 7:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using NJournals.Common.Interfaces;
using NJournals.Core.Views;
using NJournals.Core.Presenter;
using NJournals.Common.Util;
using NJournals.Common.Gui;
namespace NJournals.Core
{
	/// <summary>
	/// Description of MainFormStation.
	/// </summary>
	public partial class MainFormStation : BaseForm, IMainFormStationView
	{
		
		
		public MainFormStation()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			MessageService.Attach(new MessageBoxMessageProvider());
			
		}
		
		public event EventHandler SelectLaundryNew;
		public event EventHandler SelectLaundryClaim;
		public event EventHandler SelectLaundryReport;
		public event EventHandler SelectLaundryConfiguration;
		public event EventHandler SelectRefillingNew;
		public event EventHandler SelectRefillingClaim;
		public event EventHandler SelectRefillingReport;
		public event EventHandler SelectRefillingConfiguration;
		
		private LaundryNewView laundryView = new LaundryNewView();
		private RefillingView refillingView = new RefillingView();
		private ReportView reportView = new ReportView();
		private ConfigurationView configView = new ConfigurationView();
		
		public void ShowLaundryNewView(){					
			laundryView.SetTitle("Laundry  [NEW]");
			ShowSingletonForm(laundryView);
		}
		
		public void ShowLaundryClaimView(){
			laundryView.SetTitle("Laundry  [CLAIM]");
			ShowSingletonForm(laundryView);
		}
		
		public void ShowRefillingNewView(){
			refillingView.SetTitle("Refilling  [NEW]");
			ShowSingletonForm(refillingView);
		}
		
		public void ShowRefillingClaimView(){
			refillingView.SetTitle("Refilling  [CLAIM]");
			ShowSingletonForm(refillingView);
		}
		
		public void ShowLaundryReportView(){
			reportView.SetTitle("Laundry Report");
			ShowSingletonForm(reportView);
		}
		
		public void ShowRefillingReportView(){
			reportView.SetTitle("Refilling Report");
			ShowSingletonForm(reportView);
		}
		
		public void ShowLaundryConfigurationView(){
			configView.SetTitle("Laundry Configuration");
			ShowSingletonForm(configView);
		}
		
		public void ShowRefillingConfigurationView(){
			configView.SetTitle("Refilling Configuration");
			ShowSingletonForm(configView);
		}
		
		private void ShowSingletonForm(Form p_form){			
			string title = p_form.Text;
			foreach(Form m_form in Application.OpenForms){
				if(m_form.GetType() == p_form.GetType()){
					if(m_form.Text.Equals(p_form.Text)){
						m_form.StartPosition = FormStartPosition.CenterScreen;
						m_form.Activate();
						return;	
					}				
				}
			}		
			p_form = (Form)Activator.CreateInstance(p_form.GetType());
			p_form.Text = title;
			p_form.StartPosition = FormStartPosition.CenterScreen;			
			p_form.MdiParent = this;
			p_form.Show();
		}
		
		private void listOpenWindows(){
			this.lstOpenWindows.Items.Clear();
			foreach(Form m_form in Application.OpenForms){
				this.lstOpenWindows.Items.Add(m_form.Text);
			}
		}
				
		protected virtual void OnSelectLaundryNew(EventArgs e){
			if(SelectLaundryNew != null){
				SelectLaundryNew(this, e);
			}				
		}
		
		protected virtual void OnSelectLaundryClaim(EventArgs e){
			if(SelectLaundryClaim != null){
				SelectLaundryClaim(this, e);
			}
		}
		
		protected virtual void OnSelectLaundryConfig(EventArgs e){
			if(SelectLaundryConfiguration != null){
				SelectLaundryConfiguration(this, e);
			}
		}
		
		protected virtual void OnSelectLaundryReports(EventArgs e){
			if(SelectLaundryReport != null){
				SelectLaundryReport(this, e);
			}
		}
		
		protected virtual void OnSelectRefillingNew(EventArgs e){
			if(SelectRefillingNew != null){
				SelectRefillingNew(this, e);
			}				
		}
		
		protected virtual void OnSelectRefillingClaim(EventArgs e){
			if(SelectRefillingClaim != null){
				SelectRefillingClaim(this, e);
			}
		}
		
		protected virtual void OnSelectRefillingConfig(EventArgs e){
			if(SelectRefillingConfiguration != null){
				SelectRefillingConfiguration(this, e);
			}
		}
		
		protected virtual void OnSelectRefillingReports(EventArgs e){
			if(SelectRefillingReport != null){
				SelectRefillingReport(this, e);
			}
		}
		
		void label_mousehover(object sender, EventArgs e)
		{
			Label label = sender as Label;			
			label.Font = new Font("Calibri", 9, FontStyle.Bold);
		}
		
		void label_mouseleave(object sender, EventArgs e)
		{
			Label label = sender as Label;
			label.Font = new Font("Calibri", 9, FontStyle.Regular);
		}
		
		
		void MainFormStationLoad(object sender, EventArgs e)
		{
			this.lbllaundryNew.Click += delegate { OnSelectLaundryNew(null); };
			this.lbllaundryClaim.Click += delegate { OnSelectLaundryClaim(null); };
			this.lbllaundryConfig.Click += delegate { OnSelectLaundryConfig(null); };
			this.lbllaundryReports.Click += delegate { OnSelectLaundryReports(null); };
			this.lblRefNew.Click += delegate { OnSelectRefillingNew(null); };
			this.lblRefClaim.Click += delegate { OnSelectRefillingClaim(null); };
			this.lblRefConfig.Click += delegate { OnSelectRefillingConfig(null); };
			this.lblRefReports.Click += delegate { OnSelectRefillingReports(null); };
			this.laundryView.ViewClose += delegate { FormViewClose(this.laundryView, null); };
			this.laundryView.ViewShow += delegate { FormViewShow(this.laundryView, null); };
		}
		
		void FormViewClose(object sender, EventArgs e){
			Form m_form = sender as Form;
			foreach(string s in this.lstOpenWindows.Items){
				if(s.Equals(m_form.Text)){
					this.lstOpenWindows.Items.Remove(s);
				}
			}
		}
		
		void FormViewShow(object sender, EventArgs e){
			Form m_form = sender as Form;
			foreach(string s in this.lstOpenWindows.Items){
				if(s.Equals(m_form.Text)){
					return;
				}
			}
			this.lstOpenWindows.Items.Add(m_form.Text);
		}
	}
}

/*
 * Created by SharpDevelop.
 * User: vo185003
 * Date: 1/25/2013
 * Time: 9:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using NJournals.Common.Interfaces;
using NJournals.Common.DataEntities;
using NJournals.Core.Presenter;
using NJournals.Common.Gui;
using System.Collections.Generic;
using Microsoft.Reporting.WinForms;
using System.Globalization;
using NJournals.Core;

namespace NJournals.Core.Views
{
	/// <summary>
	/// Description of ReportView.
	/// </summary>
	public partial class ReportView : BaseForm, IReportView
	{
		ReportViewPresenter m_presenter;
		List<CustomerDataEntity> m_customerEntity;
        DateTime fromDateTime;
        DateTime toDateTime;
        bool b_isAll = true;
		
		public ReportView()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

        private void ReportView_Load(object sender, EventArgs e)
        {
        	m_presenter = new ReportViewPresenter(this);
        	
            this.reportViewer.RefreshReport();
            this.reportViewer.LocalReport.ReportEmbeddedResource = null;
            m_presenter.SetAllReportTypes(this.GetTitle());
            m_presenter.SetAllCustomers();

            this.reportViewer.RefreshReport();
        }
        
        public void SetAllReportTypes(List<string> reportTypes)
        {
        	foreach(string reportType in reportTypes)
        	{
        		this.cmbReportTypes.Items.Add(reportType);
        	}        	
        	this.cmbReportTypes.SelectedIndex = 0;
        }
        
        public void SetAllCustomers(List<CustomerDataEntity> customers)
        {
        	m_customerEntity = customers;
        	this.cmbCustomers.Items.Add("All");
        	foreach(CustomerDataEntity customer in customers){
        		this.cmbCustomers.Items.Add(customer.Name);
        	}
        	this.cmbCustomers.SelectedIndex = 0;
        }
		
		void BtnRunReportClick(object sender, EventArgs e)
		{
			string selectedReport = this.cmbReportTypes.Text;
            b_isAll = true;
			CustomerDataEntity customer = new CustomerDataEntity();
			if(this.cmbCustomers.Text != "All"){
				b_isAll = false;
				customer = m_customerEntity.Find(m_customer => m_customer.Name == cmbCustomers.Text);
			}

            fromDateTime = Convert.ToDateTime(this.dateFromPicker.Text);           
           	toDateTime = Convert.ToDateTime(this.dateToPicker.Text + " 23:59:59");
            

			m_presenter.RunReport(this.GetTitle(), selectedReport, customer, fromDateTime,
			                      toDateTime, b_isAll);			
			
		}
		
		public void DisplayReport<T>(List<T> rpt, List<ReportDataSource> datasources, 
            string rptembeddedsource)
		{
            this.reportViewer.Reset();           
            this.reportViewer.LocalReport.ReportEmbeddedResource = rptembeddedsource;                
            this.rptBindingSource.DataSource = rpt;

            foreach (ReportDataSource datasource in datasources)
            {
                this.reportViewer.LocalReport.DataSources.Add(datasource);
            }
            IList<ReportParameter> parameters = new List<ReportParameter>();           
            parameters.Add(new ReportParameter("fromDateTime", fromDateTime.ToShortDateString()));
            parameters.Add(new ReportParameter("toDateTime", toDateTime.ToShortDateString()));
            parameters.Add(new ReportParameter("customerName", cmbCustomers.Text));
            parameters.Add(new ReportParameter("isAll", b_isAll.ToString()));
            this.reportViewer.LocalReport.SetParameters(parameters);
            this.reportViewer.RefreshReport();            
		}
    
	}
}

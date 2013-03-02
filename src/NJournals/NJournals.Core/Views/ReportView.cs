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
using NJournals.Common.Util;
using NJournals.Common.Constants;

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
			Resource.setIcon(this, System.IO.Directory.GetCurrentDirectory() + "/images/chart.ico");
		}

        private void ReportView_Load(object sender, EventArgs e)
        {
        	m_presenter = new ReportViewPresenter(this);        	
            this.reportViewer.RefreshReport();
            this.reportViewer.LocalReport.ReportEmbeddedResource = null;
            m_presenter.SetAllReportTypes(this.GetTitle());
            m_presenter.SetAllCustomers();

            this.reportViewer.RefreshReport();
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
            if (ValidateReportParameters())
            { 
               	string selectedReport = this.cmbReportTypes.Text;
                b_isAll = true;
                CustomerDataEntity customer = new CustomerDataEntity();
                if (this.cmbCustomers.Text != "All")
                {
                    b_isAll = false;
                    customer = m_customerEntity.Find(m_customer => m_customer.Name == cmbCustomers.Text);
                }


                m_presenter.RunReport(this.GetTitle(), selectedReport, customer, fromDateTime,
                                      toDateTime, b_isAll);
         
            }            			
		}
				
		public void DisplayReport<T>(List<T> rpt, List<ReportDataSource> datasources, 
		                             List<ReportParameter> parameters, string rptembeddedsource)
		{
            try
            {
				this.reportViewer.Reset();
	            this.reportViewer.LocalReport.ReportEmbeddedResource = rptembeddedsource;                
	            this.rptBindingSource.DataSource = rpt;
	
	            foreach (ReportDataSource datasource in datasources)
	            {
	                this.reportViewer.LocalReport.DataSources.Add(datasource);
	            }
	                  
	            this.reportViewer.LocalReport.SetParameters(parameters);
	            this.reportViewer.RefreshReport();     
            }
            catch(Exception ex)
            {
            	MessageService.ShowError("Unable to display report; an unexpected error occurred.\n" +
                                        "Please check error log for details.\n", ex);	                       
            }
		}

        private bool ValidateReportParameters()
        {        	
            fromDateTime = Convert.ToDateTime(this.dateFromPicker.Text);
            toDateTime = Convert.ToDateTime(this.dateToPicker.Text + " 23:59:59");
            if ((cmbReportTypes.SelectedItem != null && cmbReportTypes.SelectedItem.ToString() != string.Empty) &&
            	(cmbCustomers.SelectedItem != null && cmbCustomers.SelectedItem.ToString() != string.Empty) &&
                !String.IsNullOrEmpty(this.dateFromPicker.Text) && !String.IsNullOrEmpty(this.dateToPicker.Text) &&
                (fromDateTime < toDateTime))
            {
                return true;
            }
            MessageService.ShowWarning("One of the parameters is invalid. " +
                                     "Please input a valid report type and/or customer and/or and date range!", 
                                     "Invalid Report Parameters");
            return false;           
        }   
        
        void CmbReportTypesSelectedIndexChanged(object sender, System.EventArgs e)
		{
        	if(this.GetTitle() == ReportConstants.REFILL_WINDOW 
        	   && this.cmbReportTypes.SelectedItem.ToString() == ReportConstants.INVENTORY_REPORT)
        	{
        		cmbCustomers.Enabled = false;
        	}        	
        	else{
        		cmbCustomers.Enabled = true;
        	}
        	if(this.GetTitle() == ReportConstants.REFILL_WINDOW
        	   && this.cmbReportTypes.SelectedItem.ToString() == ReportConstants.CUSTINVENTORY_REPORT)
        	{
        		this.dateFromPicker.Enabled = false;
        		this.dateToPicker.Enabled = false;        		
        	}
        	else{
        		this.dateFromPicker.Enabled = true;
        		this.dateToPicker.Enabled = true;
        	}
		}
	}
}

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

namespace NJournals.Core.Views
{
	/// <summary>
	/// Description of ReportView.
	/// </summary>
	public partial class ReportView : BaseForm, IReportView
	{
		ReportViewPresenter m_presenter;
		List<CustomerDataEntity> m_customerEntity;
		
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
        	
            this.laundryReportViewer.RefreshReport();
            this.laundryReportViewer.RefreshReport();
            this.laundryReportViewer.RefreshReport();
            m_presenter.SetAllReportTypes();
            m_presenter.SetAllCustomers();
            
        }
        
        public void SetAllReportTypes()
        {
        	switch(this.GetTitle())
        	{
        		case "Laundry Report":
        			this.cmbReportTypes.Items.Add("Sales Report");
        			this.cmbReportTypes.Items.Add("Unclaimed Items Report");
        			this.cmbReportTypes.Items.Add("Unpaid Transactions Report");
        			this.cmbReportTypes.Items.Add("Claimed Items Report");
        			break;
        		case "Refilling Report":
        			this.cmbReportTypes.Items.Add("Sales Report");
        			this.cmbReportTypes.Items.Add("Inventory Report");
        			this.cmbReportTypes.Items.Add("Unpaid Transactions Report");
        			break;
        		default:
        			break;
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
			bool b_isAll = true;
			CustomerDataEntity customer = new CustomerDataEntity();
			if(this.cmbCustomers.Text != "All"){
				b_isAll = false;
				customer = m_customerEntity.Find(m_customer => m_customer.Name == cmbCustomers.Text);
			}
			DateTime fromDateTime = Convert.ToDateTime(this.dateFromPicker.Text);
			DateTime toDateTime = Convert.ToDateTime(this.dateToPicker.Text);
			
			if(this.GetTitle() == "Laundry Report"){
				m_presenter.RunLaundryReport(selectedReport, customer, fromDateTime,
			                      toDateTime, b_isAll);
			}
			else{
				
			}
			
		}
		
		public void DisplayReport<T>(List<T> report)
		{
			
		}
	}
}

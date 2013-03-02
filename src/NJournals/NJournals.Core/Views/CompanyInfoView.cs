/*
 * Created by SharpDevelop.
 * User: vo185003
 * Date: 3/1/2013
 * Time: 3:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using NJournals.Common.Interfaces;
using NJournals.Common.Gui;
using NJournals.Common.DataEntities;
using NJournals.Core.Presenter;
using NJournals.Common.Util;
using System.Collections.Generic;
namespace NJournals.Core.Views
{
	/// <summary>
	/// Description of CompanyInfoView.
	/// </summary>
	public partial class CompanyInfoView : BaseForm, ICompanyView
	{
		public CompanyInfoView()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Resource.setIcon(this, System.IO.Directory.GetCurrentDirectory() + "/images/company.ico");
		}
		
		private CompanyDataEntity m_companyEntity;
		private List<CompanyDataEntity> m_companyEntities;
		private List<PrinterDataEntity> m_printers;
		private PrinterDataEntity m_printerEntity;
		private CompanyViewPresenter m_presenter;
		
		public void SetCompanyInfo(List<CompanyDataEntity> p_entities){
			m_companyEntities = p_entities;
			if(m_companyEntities.Count <= 0){
				m_companyEntity = new CompanyDataEntity();
				m_companyEntities.Add(m_companyEntity);
			}
			
			foreach(CompanyDataEntity entity in m_companyEntities){
				m_companyEntity = entity;	
			}
			txtname.Text = m_companyEntity.Name == null ? "" : m_companyEntity.Name;
			txtaddress.Text = m_companyEntity.Address == null ? "" : m_companyEntity.Address;
			txtcontact.Text = m_companyEntity.ContactNumber == null ? "" : m_companyEntity.ContactNumber;
			
		}
		
		public void SetPrinterInfo(List<PrinterDataEntity> p_printers){
			m_printers = p_printers;
			if(m_printers.Count <= 0){
				m_printerEntity = new PrinterDataEntity();
				m_printers.Add(m_printerEntity);
			}
			foreach(PrinterDataEntity entity in m_printers){
				m_printerEntity = entity;
			}
			txtprinter.Text = m_printerEntity.Name == null ? "" : m_printerEntity.Name;
			txtmodel.Text = m_printerEntity.Model == null ? "" : m_printerEntity.Model;
			
			//m_printerEntity.Active = m_printerEntity.Active == null ? false : m_printerEntity.Active;
			if(!m_printerEntity.Active){
				rdbinactive.Checked = true;
			}
			rdbactive.Checked = rdbinactive.Checked ? false : true;
			foreach(string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters){
				
				listBox1.Items.Add(printer);
			}
			
		}	
		
		void CompanyInfoViewLoad(object sender, EventArgs e)
		{
			m_presenter = new CompanyViewPresenter(this);
			m_presenter.ShowCompanyInfo();
			m_presenter.ShowPrinterInfo();
		}
		
		void BtnselectprinterClick(object sender, EventArgs e)
		{
			if(listBox1.SelectedItems.Count > 0)
				txtprinter.Text = listBox1.SelectedItem.ToString();
		}
		
		void BtnsaveClick(object sender, EventArgs e)
		{
			if(CheckForEmptyFields()){
				MessageService.ShowWarning("Please fill up the empty fields.","Empty fields");
				return;				                           
			}
			
			if(MessageService.ShowYesNo("Are you sure you want to save these entries?")){
				m_presenter.SaveClicked();
			}		
		}
		
		bool CheckForEmptyFields(){
			if(txtname.Text.Trim().Equals(string.Empty) ||
			   txtaddress.Text.Trim().Equals(string.Empty) ||
			   txtcontact.Text.Trim().Equals(string.Empty) ||
			   txtprinter.Text.Trim().Equals(string.Empty))
				return true;
			return false;
		}
		
		public CompanyDataEntity ProcessCompanyInfo(){
			CompanyDataEntity company = new CompanyDataEntity();
			company.Name = txtname.Text;
			company.Address = txtaddress.Text;
			company.ContactNumber = txtcontact.Text;
			return company;
		}
		
		public PrinterDataEntity ProcessPrinterInfo(){
			PrinterDataEntity printer = new PrinterDataEntity();
			printer.Name = txtprinter.Text;
			printer.Model = txtmodel.Text;
			printer.Active = rdbactive.Checked ? true : false;
			return printer;
		}
		
		
	}
}

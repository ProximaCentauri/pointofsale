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
			
			
		}
		
		private CompanyDataEntity m_companyEntity;
		private PrinterDataEntity m_printerEntity;
		
		public void SetCompanyInfo(CompanyDataEntity p_entity){
			m_companyEntity = p_entity;
			if(m_companyEntity == null){
				m_companyEntity = new CompanyDataEntity();
			}
			txtname.Text = m_companyEntity.Name;
			txtaddress.Text = m_companyEntity.Address;
			txtcontact.Text = m_companyEntity.ContactNumber;			
		}
		
		public void SetPrinterInfo(PrinterDataEntity p_printer){
			m_printerEntity = p_printer;
			if(m_printerEntity == null){
				m_printerEntity = new PrinterDataEntity();
			}
			txtprinter.Text = m_printerEntity.Name;
			txtmodel.Text = m_printerEntity.Model;
			if(!m_printerEntity.Active){
				rdbinactive.Checked = true;
			}
			rdbactive.Checked = rdbinactive.Checked ? false : true;
		}
		
		
	}
}

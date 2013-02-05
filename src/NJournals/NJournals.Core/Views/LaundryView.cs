/*
 * Created by SharpDevelop.
 * User: vo185003
 * Date: 1/25/2013
 * Time: 7:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using NJournals.Common.Interfaces;
using NJournals.Common.Gui;
using NJournals.Common.DataEntities;
using NJournals.Common.Util;
using System.Collections.Generic;
using NJournals.Core.Presenter;
using NJournals.Core.Models;
namespace NJournals.Core.Views
{
	/// <summary>
	/// Description of LaundryNewView.
	/// </summary>
	public partial class LaundryNewView : BaseForm, ILaundryView
	{
		public LaundryNewView()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		
		}
		
		LaundryViewPresenter m_presenter;
		ILaundryDao m_laundryDao;
		
		void setButtonImages()
		{
			Resource.setImage(this.btnsearch, System.IO.Directory.GetCurrentDirectory() + "/images/search.png");
			Resource.setImage(this.btnCustomerSearch, System.IO.Directory.GetCurrentDirectory() + "/images/search.png");
		}
		
		void LaundryNewViewLoad(object sender, EventArgs e)
		{
			setButtonImages();
				
			m_laundryDao = new LaundryDao();
			m_presenter = new LaundryViewPresenter(this, m_laundryDao);
			if(this.Text.Contains("[NEW]")){
				m_presenter.SetAllCategories();
				m_presenter.SetAllServices();
				this.groupBox2.Enabled = false;
			}
		}
		
		public void Save(LaundryDaySummaryDataEntity entities){
			
		}
		
		public void SetAllCategories(IList<LaundryCategoryDataEntity> categories){
			foreach(LaundryCategoryDataEntity category in categories){
				this.cmbcategory.Items.Add(category.Name);
			}
		}
		
		public void SetAllServices(IList<LaundryServiceDataEntity> services){
			foreach(LaundryServiceDataEntity service in services){
				this.cmbservices.Items.Add(service.Name);
			}
		}
		
		void BtncancelClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

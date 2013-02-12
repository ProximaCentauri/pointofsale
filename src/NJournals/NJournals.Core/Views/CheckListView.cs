﻿/*
 * Created by SharpDevelop.
 * User: vo185003
 * Date: 2/4/2013
 * Time: 9:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using NJournals.Common.Gui;
using NJournals.Common.Interfaces;
using NJournals.Core.Models;
using NJournals.Core.Presenter;
using System.Collections.Generic;
using NJournals.Common.DataEntities;
using NJournals.Common.Util;
namespace NJournals.Core.Views
{
	/// <summary>
	/// Description of CheckListView.
	/// </summary>
	public partial class CheckListView : BaseForm, ICheckListView
	{
		public CheckListView()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			m_checklistDao = new LaundryChecklistDao();
			m_presenter = new CheckListViewPresenter(this, m_checklistDao);
		}
		
		private ILaundryChecklistDao m_checklistDao;
		private CheckListViewPresenter m_presenter;
		
		public void SetAllCheckList(List<LaundryChecklistDataEntity> entities){
			foreach(LaundryChecklistDataEntity entity in entities){				
				dgvCheckList.Rows.Add(false, entity.Name, "");
			}
		}
		
		void CheckListViewLoad(object sender, EventArgs e)
		{
			setButtonImages();
			m_presenter.SetAllChecklist();
		}
		
		void BtnsaveClick(object sender, EventArgs e)
		{
			
		}
		
		void setButtonImages()
		{		
			Resource.setImage(this.btnSaveCheckList,System.IO.Directory.GetCurrentDirectory() + "/images/save2.png");
			Resource.setImage(this.btnDeleteCheckList,System.IO.Directory.GetCurrentDirectory() + "/images/delete2.png");			
		}
	}
}

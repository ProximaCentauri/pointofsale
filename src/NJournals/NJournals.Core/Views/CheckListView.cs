/*
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
		public CheckListView(LaundryHeaderDataEntity p_headerEntity, int p_jonumber)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Resource.setIcon(this, System.IO.Directory.GetCurrentDirectory() + "/images/checklist.ico");
			m_presenter = new CheckListViewPresenter(this, new LaundryChecklistDao());
			m_headerEntity = p_headerEntity;
			m_jonumber = p_jonumber;
		}
		
	
		private CheckListViewPresenter m_presenter;
		public event EventHandler SelectChecklist;
		private int m_jonumber;
		private LaundryHeaderDataEntity m_headerEntity;
		private List<LaundryChecklistDataEntity> m_checklistEntities = new List<LaundryChecklistDataEntity>();
		private List<int> itemsIndex = new List<int>();
		void CheckListViewLoad(object sender, EventArgs e)
		{
			setButtonImages();
			Resource.formatAlternatingRows(dgvCheckList);
			m_presenter.SetAllChecklist();
			if(m_headerEntity.JobChecklistEntities.Count > 0){
				btnprint.Enabled = true;
				txtjonumber.Text = m_headerEntity.LaundryHeaderID.ToString().PadLeft(6,'0');
				m_presenter.SetSelectedChecklist();
			}else{
				txtjonumber.Text = m_jonumber.ToString().PadLeft(6, '0');					
			}
			
			btnok.Click += delegate { OnSelectChecklist(null); };
		}
		
		public List<string> GetAllSelectedCheckList(){
			List<string> checklistEntities = new List<string>();;
			foreach(DataGridViewRow row in dgvCheckList.Rows){
				if(row.Cells[0].Value != null){
					if(!string.IsNullOrEmpty(row.Cells[0].Value.ToString())){
						//LaundryJobChecklistDataEntity entity = new LaundryJobChecklistDataEntity();
						bool isChecked = bool.Parse(row.Cells[0].Value.ToString());
						if(isChecked && row.Cells[1].Value != null){
							checklistEntities.Add(row.Cells[1].Value.ToString() + "|" + row.Cells[2].Value.ToString());
						}
					}
				}
			}
			return checklistEntities;
		}		

		void setButtonImages()
		{		
			Resource.setImage(this.btnSaveCheckList,System.IO.Directory.GetCurrentDirectory() + "/images/save2.png");
			Resource.setImage(this.btnDeleteCheckList,System.IO.Directory.GetCurrentDirectory() + "/images/delete2.png");			
		}
		
		void BtncancelClick(object sender, EventArgs e)
		{			
			this.Close();
		}			
		
		protected virtual void OnSelectChecklist(EventArgs e){
			if(SelectChecklist != null){
				SelectChecklist(this, e);
				if(itemsIndex.Count > 0){
					if(MessageService.ShowYesNo("You have made changes to the checklist. Do you want to save your changes?")){
						m_presenter.SaveClicked();
					}
				}
				this.Close();
			}
		}
		
		public void SetAllCheckList(List<LaundryChecklistDataEntity> entities){
			m_checklistEntities = entities;
			foreach(LaundryChecklistDataEntity entity in m_checklistEntities){				
				dgvCheckList.Rows.Add(false, entity.Name, "0", entity.ChecklistID);
			}
		}
		
		public void SetSelectedCheckList(){			
			foreach(LaundryJobChecklistDataEntity checklistEntity in m_headerEntity.JobChecklistEntities){
				foreach(DataGridViewRow row in dgvCheckList.Rows){
					if(row.Cells[0].Value != null){
						if(!string.IsNullOrEmpty(row.Cells[0].Value.ToString())){
							if(row.Cells[3].Value.ToString().Equals(checklistEntity.Checklist.ChecklistID.ToString())){
								row.Cells[0].Value = true;
								row.Cells[1].Value =  checklistEntity.Checklist.Name;								
								row.Cells[2].Value = checklistEntity.Qty;
								row.Cells[3].Value = checklistEntity.Checklist.ChecklistID;
								txttotal.Text = (int.Parse(txttotal.Text) + int.Parse(row.Cells[2].Value.ToString())).ToString();
							}
						}	
					}					
				}
			}
		}		
		
		void dgvChecklist_cellvalidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			DataGridViewColumn itemQty = dgvCheckList.Columns[e.ColumnIndex];
			
			if(itemQty == this.Column3 && dgvCheckList.IsCurrentCellInEditMode){
				int val;					
				if(!int.TryParse(Convert.ToString(e.FormattedValue), out val)){
					e.Cancel = true;
					MessageService.ShowWarning("Invalid value being inputted.","Invalid Value");
					dgvCheckList.CurrentCell = dgvCheckList.Rows[e.RowIndex].Cells[2];				
				}		
			}
			if(itemQty == Column2 && dgvCheckList.IsCurrentCellInEditMode){
				if(m_checklistEntities.Find(x => x.Name == Convert.ToString(e.FormattedValue)) != null){
					e.Cancel = true;
					MessageService.ShowWarning("Duplicate entry is not allowed. Please input another name of the item.","Duplicate Value");
					dgvCheckList.CurrentCell = dgvCheckList.Rows[e.RowIndex].Cells[1];	
				}
			}

			if(itemQty == this.Column1){
				if(!Convert.ToBoolean(e.FormattedValue)){
					dgvCheckList.Rows[e.RowIndex].Cells[2].Value = "0";
				}
			}
			
			calculateQty();			
		}
		
		private void calculateQty(){
			txttotal.Text = "0";
			foreach(DataGridViewRow row in dgvCheckList.Rows){
				if(row.Cells[0].Value != null && row.Cells[2].Value != null){					
					if(!string.IsNullOrEmpty(row.Cells[2].Value.ToString())){
						txttotal.Text = (int.Parse(txttotal.Text) + int.Parse(row.Cells[2].Value.ToString())).ToString();
					}	
				}
				
			}					
		}
		
		void dgvchecklist_cellclick(object sender, DataGridViewCellEventArgs e)
		{			
			calculateQty();			
		}		
		
		void BtnprintClick(object sender, EventArgs e)
		{
			if(MessageService.ShowYesNo("Are you sure you want to print this checklist?")){
				LaundryHeaderDataEntity headerEntity = m_presenter.GetLaundryHeader(m_headerEntity.LaundryHeaderID);
				if(headerEntity != null){
					m_presenter.PrintTransaction(headerEntity);
				}else{
					MessageService.ShowWarning("Can't print this checklist. Please save first the transaction before printing this checklist.");
				}
				this.Close();
			}			
		}
		
		void BtnDeleteCheckListClick(object sender, EventArgs e)
		{
			if(dgvCheckList.SelectedRows.Count > 0){
				if(dgvCheckList.SelectedRows[0].Cells[1].Value != null)
					dgvCheckList.Rows.RemoveAt(dgvCheckList.SelectedRows[0].Index);
			}
		}
		
		void BtnSaveCheckListClick(object sender, EventArgs e)
		{			
			if(itemsIndex.Count > 0){
				if(MessageService.ShowYesNo("Are you sure you want to save your new entries?")){
					m_presenter.SaveClicked();
					itemsIndex.Clear();
				}
			}
		}
		
		public List<LaundryChecklistDataEntity> ProcessCheckList(){
			List<LaundryChecklistDataEntity> checklist = new List<LaundryChecklistDataEntity>();
			foreach(DataGridViewRow row in dgvCheckList.Rows){
				if(row.Cells[1].Value != null){
					string name = row.Cells[1].Value.ToString().Trim();
					LaundryChecklistDataEntity entity = null;
					if(row.Cells[3].Value != null){
						entity = m_presenter.GetById(int.Parse(row.Cells[3].Value.ToString()));	
					}					
					
					if(entity == null){
						entity = new LaundryChecklistDataEntity();
						entity.Name = name;		
						checklist.Add(entity);
					}else if(!entity.Name.Equals(name)){
						entity.Name = name;
						checklist.Add(entity);
					}
				}		
			}
			return checklist;
		}
		
		void dgvChecklist_valuechanged(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex != -1){		
				if(dgvCheckList.Columns[e.ColumnIndex] == Column2){
					if(!itemsIndex.Contains(e.RowIndex))
						itemsIndex.Add(e.RowIndex);
				}
												
			}			
		}	
	
	}
}

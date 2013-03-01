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
			m_presenter = new CheckListViewPresenter(this, new LaundryChecklistDao());
			m_headerEntity = p_headerEntity;
			m_jonumber = p_jonumber;
		}
		
	
		private CheckListViewPresenter m_presenter;
		public event EventHandler SelectChecklist;
		private int m_jonumber;
		private LaundryHeaderDataEntity m_headerEntity;
		
		void CheckListViewLoad(object sender, EventArgs e)
		{
			setButtonImages();
			m_presenter.SetAllChecklist();
			if(m_headerEntity.JobChecklistEntities.Count > 0){
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
						if(isChecked){
							
							//entity.Checklist = m_presenter.getChecklistByName(row.Cells[1].Value.ToString());
							//entity.Qty = int.Parse(row.Cells[2].Value.ToString());
							//checklistEntities.Add(entity);
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
				this.Close();
			}
		}
		
		public void SetAllCheckList(List<LaundryChecklistDataEntity> entities){
			foreach(LaundryChecklistDataEntity entity in entities){				
				dgvCheckList.Rows.Add(false, entity.Name, "0");
			}
		}
		
		public void SetSelectedCheckList(){			
			foreach(LaundryJobChecklistDataEntity checklistEntity in m_headerEntity.JobChecklistEntities){
				foreach(DataGridViewRow row in dgvCheckList.Rows){
					if(row.Cells[0].Value != null){
						if(!string.IsNullOrEmpty(row.Cells[0].Value.ToString())){
							if(row.Cells[1].Value.ToString().Equals(checklistEntity.Checklist.Name)){
								row.Cells[0].Value = true;
								row.Cells[2].Value = checklistEntity.Qty;
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
				if(bool.Parse(dgvCheckList.Rows[e.RowIndex].Cells[0].Value.ToString())){
					int val;					
					if(!int.TryParse(Convert.ToString(e.FormattedValue), out val)){
						e.Cancel = true;
						MessageService.ShowWarning("Invalid value being inputted.","Invalid Value");
						dgvCheckList.CurrentCell = dgvCheckList.Rows[e.RowIndex].Cells[2];				
					}
						
				}
			}
			if(itemQty == this.Column1){
				if(!Convert.ToBoolean(e.FormattedValue)){
					dgvCheckList.Rows[e.RowIndex].Cells[2].Value = "0";
				}
			}
			//TODO: improve the calculating qty
			calculateQty();
			
		}
		
		private void calculateQty(){
			txttotal.Text = "0";
			foreach(DataGridViewRow row in dgvCheckList.Rows){
				if(row.Cells[0].Value != null){
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
	}
}

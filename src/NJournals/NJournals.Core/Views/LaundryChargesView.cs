/*
 * Created by SharpDevelop.
 * User: vo185003
 * Date: 3/1/2013
 * Time: 4:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using NJournals.Common.Util;
using NJournals.Common.Interfaces;
using NJournals.Common.Gui;
using NJournals.Common.DataEntities;
using System.Collections.Generic;
using NJournals.Core.Presenter;
using NJournals.Core.Models;
using System.Data;

namespace NJournals.Core.Views
{
	/// <summary>
	/// Description of LaundryChargesView.
	/// </summary>
	public partial class LaundryChargesView : BaseForm, ILaundryChargesView
	{
		LaundryChargesViewPresenter m_presenter;
		List<LaundryChargeDataEntity> m_chargesEntity;
		List<int> chargesIndexChange = new List<int>();
		int chargesMaxRowIndex = -1;
		
		public LaundryChargesView()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Resource.setImage(this, System.IO.Directory.GetCurrentDirectory() + "/images/checklist.ico");
		}
		
		void LaundryChargesFormLoad(object sender, EventArgs e)
		{
			setButtonImages();
			Resource.formatAlternatingRows(dgvCharges);
			m_presenter = new LaundryChargesViewPresenter(this);
			m_presenter.SetAllLaundryCharges();
		}
		
		public void SetAllLaundryCharges(List<LaundryChargeDataEntity> charges)
		{
			m_chargesEntity = charges;
			BindingSource source = new BindingSource();
			source.DataSource = m_chargesEntity;
			dgvCharges.DataSource = source;
			chargesMaxRowIndex = dgvCharges.RowCount - 1;
			formatChargesDataGridView();
		}
		
		#region Charges
		private void dgvCharges_CellValueChanged(object sender,
		    DataGridViewCellEventArgs e)
		{		   	
			if(e.RowIndex != -1)
			{
				if(!chargesIndexChange.Contains(e.RowIndex))
					chargesIndexChange.Add(e.RowIndex);
			}
		}
		
		void BtnSaveChargesClick(object sender, EventArgs e)
		{
			List<LaundryChargeDataEntity> charges = new List<LaundryChargeDataEntity>();
			string errorMessage = string.Empty;
			
			if(ValidateChargeName(chargesIndexChange))
			{
				charges = GetChargesDataValueChange(chargesIndexChange, out errorMessage);
				
				if(errorMessage.Equals(string.Empty))
				{
					if(charges.Count > 0)
					{
						try
						{
							m_presenter.SaveOrUpdateCharge(charges);
							m_presenter.SetAllLaundryCharges();
							MessageService.ShowInfo("Successfully saved/updated charges.", "Save or Update charges");
							chargesMaxRowIndex = dgvCharges.RowCount - 1;
							dgvCharges.Refresh();
						}
						catch (Exception ex)
						{
							//TODO: error message
                            MessageService.ShowError("Unable to save data; an unexpected error occurred.\n" +
                                       "Please check error log for details.\n", ex); ;
						}
					}
				}
				else
				{
					//TODO: error message
					MessageService.ShowWarning("Unable to insert duplicate charge name: " + errorMessage.Remove(errorMessage.LastIndexOf(',')).Trim() +
					                          " . Please make sure that no duplicate entry before saving.");
				}
			}
			else
			{
				MessageService.ShowWarning("Cannot save empty charge name.");
			}
		}
		
		void BtnDeleteChargesClick(object sender, EventArgs e)
		{
			LaundryChargeDataEntity charge = new LaundryChargeDataEntity();
			
			if(dgvCharges.SelectedRows.Count > 0)
			{
				if(MessageService.ShowYesNo("Are you sure you want to remove the selected charges from the list?", "Remove Charges"))
				{
					foreach(DataGridViewRow currentRow in dgvCharges.SelectedRows)
					{
						if(currentRow.Index < chargesMaxRowIndex)
						{
							int chargeID = (int)this.dgvCharges.Rows[currentRow.Index].Cells["ChargeID"].Value;
							charge = m_chargesEntity.Find(m_charge => m_charge.ChargeID == chargeID);
							charge.VoidFlag = true;								
							m_presenter.SaveOrUpdateCharge(charge);
						}							
						if(!this.dgvCharges.Rows[currentRow.Index].IsNewRow)
							dgvCharges.Rows.Remove(this.dgvCharges.Rows[currentRow.Index]);	
					}
					m_presenter.SetAllLaundryCharges();
					chargesMaxRowIndex = dgvCharges.RowCount - 1;
				}
			}
		}
		
		private List<LaundryChargeDataEntity> GetChargesDataValueChange(List<int> rowIndexChange, out string errorMessage)
		{
			List<LaundryChargeDataEntity> charges = new List<LaundryChargeDataEntity>();
			List<string> updateCharges = new List<string>();
			string errorMsg = string.Empty;
			string name = string.Empty;
			decimal price = 0;
			
			foreach(int rowIndex in rowIndexChange)
			{
				LaundryChargeDataEntity charge = new LaundryChargeDataEntity();
				name = dgvCharges.Rows[rowIndex].Cells["Name"].Value.ToString().Trim();
				price = Convert.ToDecimal(dgvCharges.Rows[rowIndex].Cells["Amount"].Value.ToString());
				
				if(rowIndex < chargesMaxRowIndex)
				{
					int chargeID = (int)dgvCharges.Rows[rowIndex].Cells["ChargeID"].Value;
					charge = m_chargesEntity.Find(chargesEntity => chargesEntity.ChargeID == chargeID);
					
					charge.Name = name;
					charge.Amount = price;
					charge.VoidFlag = false;
					charges.Add(charge);
					updateCharges.Add(charge.Name.ToUpper());
				}
				else
				{
					LaundryChargeDataEntity newCharge = new LaundryChargeDataEntity();
					newCharge = m_chargesEntity.Find(chargesEntity => chargesEntity.Name.ToUpper() == name.ToUpper());
					
					if((newCharge == null || newCharge.ChargeID == 0) && !updateCharges.Contains(name))
					{
						charge.Name = name;
						charge.Amount = price;
						charge.VoidFlag = false;
						
						updateCharges.Add(charge.Name.ToUpper());
						charges.Add(charge);
					}
					else
					{
						errorMsg += name + ", ";
					}
				}				
			}
			errorMessage = errorMsg;
			return charges;
			
		}
		
		private bool ValidateChargeName(List<int> rowIndexChange)
		{
			foreach(int rowIndex in rowIndexChange)
			{
				if(dgvCharges.Rows[rowIndex].Cells["Name"].Value == null ||
				   dgvCharges.Rows[rowIndex].Cells["Name"].Value.ToString().Trim().Equals(string.Empty))
					return false;
			}
			return true;
		}
		
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void dgvCharges_cellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{		
			DataGridViewColumn price = dgvCharges.Columns["Amount"];
			
			if(dgvCharges.Rows[e.RowIndex].IsNewRow) { return;}
			if(dgvCharges.CurrentCell.OwningColumn.HeaderText == "Price" && dgvCharges.IsCurrentCellInEditMode)
			{
				Decimal val;
				if(!Decimal.TryParse(Convert.ToString(e.FormattedValue), out val)){
					e.Cancel = true;
					MessageService.ShowWarning("Invalid value being inputted.", "Invalid Value");
					dgvCharges.CurrentCell = dgvCharges.Rows[e.RowIndex].Cells["Amount"];
				}
			}
		}
		
		#endregion
		
		void setButtonImages()
		{
			Resource.setImage(this.btnSaveCharges,System.IO.Directory.GetCurrentDirectory() + "/images/save2.png");
			Resource.setImage(this.btnDeleteCharges,System.IO.Directory.GetCurrentDirectory() + "/images/delete2.png");
			
		}		
		
		private void formatChargesDataGridView()
		{
			dgvCharges.Columns["ChargeID"].Visible = false;
			dgvCharges.Columns["VoidFlag"].Visible = false;
			dgvCharges.Columns["Name"].HeaderText = "Charge Name";
			dgvCharges.Columns["Amount"].HeaderText = "Price";
			dgvCharges.Columns["Name"].Width = 200;
			dgvCharges.Columns["Amount"].Width = 88;
		}	
	}
}

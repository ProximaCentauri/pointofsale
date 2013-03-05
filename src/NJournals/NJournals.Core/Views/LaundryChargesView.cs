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
			Resource.setIcon(this, System.IO.Directory.GetCurrentDirectory() + "/images/checklist.ico");
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
			
			DataTable tempTable = new DataTable();
			tempTable.Columns.Add("ChargeID", typeof(int));
			tempTable.Columns.Add("Name", typeof(string));
			tempTable.Columns.Add("Amount", typeof(decimal));
			
			foreach(LaundryChargeDataEntity charge in m_chargesEntity)
			{
				tempTable.Rows.Add(charge.ChargeID, charge.Name, charge.Amount);
			}
			
			source.DataSource = tempTable;
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
							chargesIndexChange.Clear();
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
				MessageService.ShowWarning("Cannot save empty charge name or amount.");
			}
		}
			
		private List<LaundryChargeDataEntity> GetChargesDataValueChange(List<int> rowIndexChange, out string errorMessage)
		{
			List<LaundryChargeDataEntity> charges = new List<LaundryChargeDataEntity>();
			LaundryChargeDataEntity charge = null;
			LaundryChargeDataEntity newCharge = null;
			List<string> updateCharges = new List<string>();
			string errorMsg = string.Empty;
			string name = string.Empty;
			decimal price = 0;
			bool isNameExists = true;
			
			foreach(int rowIndex in rowIndexChange)
			{
				charge = new LaundryChargeDataEntity();
				newCharge = new LaundryChargeDataEntity();
				name = dgvCharges.Rows[rowIndex].Cells["Name"].Value.ToString().Trim();
				price = Convert.ToDecimal(dgvCharges.Rows[rowIndex].Cells["Amount"].Value.ToString());	
				
				newCharge = m_chargesEntity.Find(chargesEntity => chargesEntity.Name.ToUpper() == name.ToUpper());
				if(newCharge == null || newCharge.ChargeID == 0)
					isNameExists = false;
					
				if(rowIndex < chargesMaxRowIndex)
				{
					int chargeID = (int)dgvCharges.Rows[rowIndex].Cells["ChargeID"].Value;
					charge = m_chargesEntity.Find(chargesEntity => chargesEntity.ChargeID == chargeID);
					
					if(charge.Name.ToUpper().Equals(name.ToUpper()))
					{
						charge.Name = name;
						charge.Amount = price;
						charges.Add(charge);
					}
					else if(!charge.Name.ToUpper().Equals(name.ToUpper())
					        && !isNameExists && !updateCharges.Contains(name.ToUpper()))
					{						
						charge.Name = name;
						charge.Amount = price;
						charges.Add(charge);
						updateCharges.Add(charge.Name.ToUpper());
					}
					else
					{
						errorMsg += name + " , ";
					}
				}
				else
				{				
					if(!isNameExists && !updateCharges.Contains(name.ToUpper()))
					{
						charge.Name = name;
						charge.Amount = price;
						
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
				   dgvCharges.Rows[rowIndex].Cells["Name"].Value.ToString().Trim().Equals(string.Empty) ||
				  dgvCharges.Rows[rowIndex].Cells["Amount"].Value == null ||
				 dgvCharges.Rows[rowIndex].Cells["Amount"].Value.ToString().Trim().Equals(string.Empty))
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
		}		
		
		private void formatChargesDataGridView()
		{
			dgvCharges.Columns["ChargeID"].Visible = false;
			dgvCharges.Columns["Name"].HeaderText = "Charge Name";
			dgvCharges.Columns["Amount"].HeaderText = "Price";
			dgvCharges.Columns["Name"].Width = 200;
			dgvCharges.Columns["Amount"].Width = 88;
			dgvCharges.Columns["Name"].SortMode = DataGridViewColumnSortMode.NotSortable;
			dgvCharges.Columns["Amount"].SortMode = DataGridViewColumnSortMode.NotSortable;
		}	
	}
}

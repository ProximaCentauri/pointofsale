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
		}
		
		void LaundryChargesFormLoad(object sender, EventArgs e)
		{
			setButtonImages();
			formatAlternatingRows();
			
			m_presenter = new LaundryChargesViewPresenter(this);
			m_presenter.SetAllLaundryCharges();
		}
		
		public void SetAllLaundryCharges(List<LaundryChargeDataEntity> charges)
		{
			m_chargesEntity = charges;
			BindingSource source = new BindingSource();
			source.DataSource = m_chargesEntity;
			dgvCharges.DataSource = source;
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
				
			}
		}
		
		void BtnDeleteChargesClick(object sender, EventArgs e)
		{
			
		}
		
		private bool ValidateChargeName(List<int> rowIndexChange)
		{
			foreach(int rowIndex in rowIndexChange)
			{
				
			}
		}
		
		#endregion
		
		//TODO: 1. add voidFlag column;
		
		void setButtonImages()
		{
			Resource.setImage(this.btnSaveCharges,System.IO.Directory.GetCurrentDirectory() + "/images/save2.png");
			Resource.setImage(this.btnDeleteCharges,System.IO.Directory.GetCurrentDirectory() + "/images/delete2.png");
			
		}
		
		void formatAlternatingRows()
		{
            this.dgvCharges.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvCharges.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));        
		}
		
		private void formatChargesDataGridView()
		{
			dgvCharges.Columns["ChargeID"].Visible = false;
			dgvCharges.Columns["Name"].HeaderText = "Charge Name";
			dgvCharges.Columns["Amount"].HeaderText = "Price";
			dgvCharges.Columns["Name"].Width = 150;
			dgvCharges.Columns["Amount"].Width = 120;
		}
		
		
	}
}

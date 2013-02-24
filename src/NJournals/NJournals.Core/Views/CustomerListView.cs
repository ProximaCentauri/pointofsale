/*
 * Created by SharpDevelop.
 * User: vo185003
 * Date: 2/4/2013
 * Time: 9:51 PM
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
using System.ComponentModel;

namespace NJournals.Core.Views
{
	/// <summary>
	/// Description of CustomerView.
	/// </summary>
	public partial class CustomerListView : BaseForm, ICustomerListView
	{
		CustomerListViewPresenter m_presenter;
		List<CustomerDataEntity> m_customersEntity = null;
		int selectedIndex = -1;
		
		public CustomerListView()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void CustomerListViewLoad(object sender, EventArgs e)
		{
			setButtonImages();
			formatAlternatingRows();
			setToolTip();
			m_presenter = new CustomerListViewPresenter(this);
			m_presenter.SetAllCustomerList();
		}
		
		public void SetAllCustomerList(List<CustomerDataEntity> customers)
		{
			m_customersEntity = customers;
			BindingSource source = new BindingSource();
			source.DataSource = m_customersEntity;
			this.dgvCustomerList.DataSource = source;
			formatCustomerListDataGridView();
		}	
		
		void BtnShowClick(object sender, EventArgs e)
		{
			if(dgvCustomerList.SelectedRows.Count == 1)
			{
				DataGridViewRow currentRow = dgvCustomerList.CurrentRow;
				
				selectedIndex = currentRow.Index;
				txtName.Text = currentRow.Cells["Name"].Value.ToString();
				txtAddress.Text = currentRow.Cells["Address"].Value.ToString();
				txtNumber.Text = currentRow.Cells["ContactNumber"].Value.ToString();
				
				txtsearch.Text = string.Empty;
			}
			else
			{
				//TODO: info message
				MessageService.ShowInfo("Cannot view multiple customer details. Please select one customer at a time.");
			}
		}
		
		void BtnSaveClick(object sender, EventArgs e)
		{		
			if(txtName.Text.Trim() == "")
			{
				errorProvider.SetError(txtName, "Name is required.");
				return;
			}
			else
			{
				errorProvider.SetError(txtName, "");
				
				CustomerDataEntity customer = new CustomerDataEntity();
				string name = txtName.Text.ToString();
				string address = txtAddress.Text.ToString();
				string number = txtNumber.Text.ToString();
				
				if(selectedIndex != -1)
				{				
					int ID = (int)dgvCustomerList.Rows[selectedIndex].Cells["CustomerID"].Value;
					customer = m_customersEntity.Find(m_customer => m_customer.CustomerID == ID);
				}
				else
				{
					customer = m_customersEntity.Find(m_customer => m_customer.Name == name);	

					if(customer != null && customer.CustomerID != 0)
					{
						MessageService.ShowWarning("Unable to insert duplicate name: " + name);
						return;
					}
					else
					{
						customer = new CustomerDataEntity();
					}
				}	
			
				customer.Name = name;
				customer.Address = address;
				customer.ContactNumber = number;
				
				try
				{
					m_presenter.SaveOrUpdateCustomer(customer);					
					selectedIndex = -1;
					ClearData();
					m_presenter.SetAllCustomerList();					
				}
				catch(Exception ex)
				{
					MessageService.ShowError("Unable to save data.", ex.Message);
				}
			}			
		}
		
		void BtnCancelClick(object sender, EventArgs e)
		{
			ClearData();
		}
		
		void ClearData()
		{
			txtName.Text = string.Empty;
			txtAddress.Text = string.Empty;
			txtNumber.Text = string.Empty;
			txtsearch.Text = string.Empty;
			
			errorProvider.SetError(txtName, "");
		}
		
		void txtName_Validating(object sender, CancelEventArgs e)
		{
			if(txtName.Text.Trim() == "")
			{
				e.Cancel = true;
				errorProvider.SetError(txtName, "Name is required");
				return;
			}
			
			errorProvider.SetError(txtName, "");
		}
		

		
		void BtnsearchClick(object sender, EventArgs e)
		{
			if(!txtsearch.Text.Trim().Equals(string.Empty))
			{
				m_presenter.viewCustomersByName(txtsearch.Text.Trim().ToString());
			}
			else
			{
				
			}
		}
		
		void BtnRefreshClick(object sender, EventArgs e)
		{
			txtsearch.Text = string.Empty;
			m_presenter.SetAllCustomerList();
		}
		
		public void ViewCustomersByName(List<CustomerDataEntity> p_customers)
		{
			m_customersEntity = p_customers;
			if(m_customersEntity != null)
			{
				BindingSource source = new BindingSource();
				source.DataSource = m_customersEntity;
				dgvCustomerList.Rows.Clear();
				dgvCustomerList.DataSource = source;
			}
			else
			{
				MessageService.ShowWarning("Can't find customer name: " + txtsearch.Text.Trim(), "Non-existing");
			}
		}		
		
		void BtnDeleteCustomerClick(object sender, EventArgs e)
		{
			CustomerDataEntity customer = new CustomerDataEntity();
			
			if(dgvCustomerList.SelectedRows.Count > 0)
			{
				try
				{
					foreach(DataGridViewRow currentRow in dgvCustomerList.SelectedRows)
					{
						int ID = (int)dgvCustomerList.Rows[currentRow.Index].Cells["CustomerID"].Value;
						customer = m_customersEntity.Find(m_customer => m_customer.CustomerID == ID);
						m_presenter.DeleteCustomer(customer);
						dgvCustomerList.Rows.Remove(dgvCustomerList.Rows[currentRow.Index]);
					}
					m_presenter.SetAllCustomerList();
				}
				catch(Exception ex)
				{
					MessageService.ShowError("Unable to delete selected data.", ex.Message);
				}
			}
		}
		
		
		#region Format Methods
		
		void setButtonImages()
		{
			Resource.setImage(this.btnDeleteCustomer,System.IO.Directory.GetCurrentDirectory() + "/images/delete2.png");
			Resource.setImage(this.btnShow,System.IO.Directory.GetCurrentDirectory() + "/images/viewUser.png");			
			Resource.setImage(this.btnsearch,System.IO.Directory.GetCurrentDirectory() + "/images/search.png");	
			Resource.setImage(this.btnRefresh,System.IO.Directory.GetCurrentDirectory() + "/images/refresh.png");				
		}
		
		private void formatCustomerListDataGridView()
		{
			dgvCustomerList.Columns["CustomerID"].Visible = false;
			dgvCustomerList.Columns["Name"].ReadOnly = true;
			dgvCustomerList.Columns["Address"].ReadOnly = true;
			dgvCustomerList.Columns["ContactNumber"].ReadOnly = true;
			dgvCustomerList.Columns["ContactNumber"].HeaderText = "Contact Number";
			dgvCustomerList.Columns["Name"].Width = 115;
			dgvCustomerList.Columns["Address"].Width = 140;
			dgvCustomerList.Columns["ContactNumber"].Width = 110;
		}
		
		void formatAlternatingRows()
		{
            this.dgvCustomerList.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvCustomerList.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));        
		}
		
		void setToolTip()
		{
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(btnCancel, "Clear data");
			toolTip.SetToolTip(btnDeleteCustomer, "Remove customer from the list");
			toolTip.SetToolTip(btnRefresh, "Loads the customer list");
			toolTip.SetToolTip(btnSave, "Save new customer data");
			toolTip.SetToolTip(btnShow, "Show customer data");
			toolTip.SetToolTip(btnsearch, "Search customer by name");
		}
		
		#endregion
		
		
		
		
		
	}
}

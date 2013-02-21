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
		List<CustomerDataEntity> m_customersEntity;
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
		
		
		private void formatCustomerListDataGridView()
		{
			dgvCustomerList.Columns["CustomerID"].Visible = false;
			dgvCustomerList.Columns["Name"].ReadOnly = true;
			dgvCustomerList.Columns["Address"].ReadOnly = true;
			dgvCustomerList.Columns["ContactNumber"].ReadOnly = true;
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
		
		void BtnDeleteClick(object sender, EventArgs e)
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
	}
}

/*
 * Created by SharpDevelop.
 * User: vo185003
 * Date: 1/25/2013
 * Time: 9:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using NJournals.Common.Gui;
using NJournals.Common.Interfaces;
using System.Collections.Generic;
using NJournals.Core.Models;
using NJournals.Common.DataEntities;
using NJournals.Core.Presenter;

namespace NJournals.Core.Views
{
	/// <summary>
	/// Description of RefillingView.
	/// </summary>
	public partial class RefillingView : BaseForm, IRefillingView
	{
		public RefillingView()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			m_refillDao = new RefillDao();
			m_presenter = new RefillingViewPresenter(this, m_refillDao);
		}
		
		private IRefillDao m_refillDao;
		private RefillingViewPresenter m_presenter;
		
		void RefillingViewLoad(object sender, EventArgs e)
		{
			if(this.Text.Contains("[NEW]")){
				m_presenter.SetAllCustomers();
				m_presenter.SetAllProducts();
				m_presenter.SetAllTransactionTypes();
				txtjonumber.Text = m_presenter.getHeaderID().ToString().PadLeft(6, '0');
			}			
		}
		
		public void SetAllCustomers(List<CustomerDataEntity> customers){
			foreach(CustomerDataEntity customer in customers){
				this.cmbCustomers.Items.Add(customer.Name);
			}
		}
		
		public void SetAllTransactionTypes(List<RefillTransactionTypeDataEntity> transTypes){
			foreach(RefillTransactionTypeDataEntity transType in transTypes){
				this.cmbtransTypes.Items.Add(transType.Name);
			}
		}
		
		public void SetAllProducts(List<RefillProductTypeDataEntity> products){
			foreach(RefillProductTypeDataEntity product in products){
				this.cmbproducts.Items.Add(product.Name);
			}
		}		
		
		void BtnaddClick(object sender, EventArgs e)
		{
			decimal price = m_presenter.getAmtChargeByName(cmbproducts.Text);
			decimal totalPrice = decimal.Parse(txtnoitems.Text) * price;
			bool alreadyExist = false;
			for(int i=0;i<dataGridView1.Rows.Count;i++){
				if(dataGridView1.Rows[i].Cells[0].Value != null){
					if(dataGridView1.Rows[i].Cells[0].Value.ToString().Equals(cmbproducts.Text)){
						dataGridView1.Rows[i].Cells[1].Value = (int.Parse(txtbottles.Text) + int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString())).ToString();
						dataGridView1.Rows[i].Cells[2].Value = (int.Parse(txtcaps.Text) + int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString())).ToString();
						dataGridView1.Rows[i].Cells[3].Value = (int.Parse(txtnoitems.Text) + int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString())).ToString();
						dataGridView1.Rows[i].Cells[4].Value = (decimal.Parse((dataGridView1.Rows[i].Cells[4].Value.ToString())) + totalPrice).ToString("N2");
						alreadyExist = true;
					}
				}
			}				
			if(!alreadyExist)
				dataGridView1.Rows.Add(cmbproducts.Text, txtbottles.Text, txtcaps.Text, txtnoitems.Text, totalPrice.ToString("N2"));
			this.txtamtdue.Text = (decimal.Parse(txtamtdue.Text) + totalPrice).ToString("N2");
		}
	}
}

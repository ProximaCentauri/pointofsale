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
			List<String> lstItems = new List<String>();
			lstItems.Add(cmbproducts.Text);			
			lstItems.Add(txtbottles.Text);
			lstItems.Add(txtcaps.Text);
			lstItems.Add(txtnoitems.Text);
			lstItems.Add(totalPrice.ToString("N2"));
			string[] items = new string[lstItems.Count];
			lstItems.CopyTo(items,0);
			dataGridView1.Rows.Add(items);
			this.txtamtdue.Text = (decimal.Parse(txtamtdue.Text) + totalPrice).ToString("N2");
		}
	}
}

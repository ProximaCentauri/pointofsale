/*
 * Created by SharpDevelop.
 * User: vo185003
 * Date: 2/4/2013
 * Time: 9:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NJournals.Core.Views
{
	partial class LaundryCustomerSearchView
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtcustomer = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvunclaimeditems = new System.Windows.Forms.DataGridView();
			this.TransactionNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ReceivedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ItemQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AmtDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvunpaidtrans = new System.Windows.Forms.DataGridView();
			this.TransactionNo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ReceivedDate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DueDate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ItemQty2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AmtDue2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Balance2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label3 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvunclaimeditems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvunpaidtrans)).BeginInit();
			this.SuspendLayout();
			// 
			// txtcustomer
			// 
			this.txtcustomer.BackColor = System.Drawing.SystemColors.Info;
			this.txtcustomer.Enabled = false;
			this.txtcustomer.Location = new System.Drawing.Point(153, 22);
			this.txtcustomer.Name = "txtcustomer";
			this.txtcustomer.Size = new System.Drawing.Size(289, 20);
			this.txtcustomer.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(38, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "Customer Name: ";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Calibri", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Teal;
			this.label1.Location = new System.Drawing.Point(48, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(183, 23);
			this.label1.TabIndex = 8;
			this.label1.Text = "UNCLAIMED ITEMS:";
			// 
			// dgvunclaimeditems
			// 
			this.dgvunclaimeditems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvunclaimeditems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.TransactionNo,
									this.ReceivedDate,
									this.DueDate,
									this.ItemQty,
									this.AmtDue,
									this.Balance});
			this.dgvunclaimeditems.Location = new System.Drawing.Point(48, 82);
			this.dgvunclaimeditems.Name = "dgvunclaimeditems";
			this.dgvunclaimeditems.Size = new System.Drawing.Size(645, 107);
			this.dgvunclaimeditems.TabIndex = 9;
			// 
			// TransactionNo
			// 
			this.TransactionNo.HeaderText = "Transaction #";
			this.TransactionNo.Name = "TransactionNo";
			this.TransactionNo.ReadOnly = true;
			this.TransactionNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// ReceivedDate
			// 
			this.ReceivedDate.HeaderText = "Received Date";
			this.ReceivedDate.Name = "ReceivedDate";
			this.ReceivedDate.ReadOnly = true;
			this.ReceivedDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// DueDate
			// 
			this.DueDate.HeaderText = "Due Date";
			this.DueDate.Name = "DueDate";
			this.DueDate.ReadOnly = true;
			this.DueDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// ItemQty
			// 
			this.ItemQty.HeaderText = "# of Items";
			this.ItemQty.Name = "ItemQty";
			this.ItemQty.ReadOnly = true;
			this.ItemQty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// AmtDue
			// 
			this.AmtDue.HeaderText = "Amount Due";
			this.AmtDue.Name = "AmtDue";
			this.AmtDue.ReadOnly = true;
			this.AmtDue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// Balance
			// 
			this.Balance.HeaderText = "Balance";
			this.Balance.Name = "Balance";
			this.Balance.ReadOnly = true;
			this.Balance.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// dgvunpaidtrans
			// 
			this.dgvunpaidtrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvunpaidtrans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.TransactionNo2,
									this.ReceivedDate2,
									this.DueDate2,
									this.ItemQty2,
									this.AmtDue2,
									this.Balance2});
			this.dgvunpaidtrans.Location = new System.Drawing.Point(48, 220);
			this.dgvunpaidtrans.Name = "dgvunpaidtrans";
			this.dgvunpaidtrans.Size = new System.Drawing.Size(645, 107);
			this.dgvunpaidtrans.TabIndex = 11;
			// 
			// TransactionNo2
			// 
			this.TransactionNo2.HeaderText = "Transaction #";
			this.TransactionNo2.Name = "TransactionNo2";
			this.TransactionNo2.ReadOnly = true;
			this.TransactionNo2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// ReceivedDate2
			// 
			this.ReceivedDate2.HeaderText = "Received Date";
			this.ReceivedDate2.Name = "ReceivedDate2";
			this.ReceivedDate2.ReadOnly = true;
			this.ReceivedDate2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// DueDate2
			// 
			this.DueDate2.HeaderText = "Due Date";
			this.DueDate2.Name = "DueDate2";
			this.DueDate2.ReadOnly = true;
			this.DueDate2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// ItemQty2
			// 
			this.ItemQty2.HeaderText = "# of Items";
			this.ItemQty2.Name = "ItemQty2";
			this.ItemQty2.ReadOnly = true;
			this.ItemQty2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// AmtDue2
			// 
			this.AmtDue2.HeaderText = "Amount Due";
			this.AmtDue2.Name = "AmtDue2";
			this.AmtDue2.ReadOnly = true;
			this.AmtDue2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// Balance2
			// 
			this.Balance2.HeaderText = "Balance";
			this.Balance2.Name = "Balance2";
			this.Balance2.ReadOnly = true;
			this.Balance2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Calibri", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Teal;
			this.label3.Location = new System.Drawing.Point(48, 206);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(183, 23);
			this.label3.TabIndex = 10;
			this.label3.Text = "OUTSTANDING BALANCE:";
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Location = new System.Drawing.Point(617, 349);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 12;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// LaundryCustomerSearchView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.ClientSize = new System.Drawing.Size(742, 410);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.dgvunpaidtrans);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dgvunclaimeditems);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtcustomer);
			this.Controls.Add(this.label2);
			this.Name = "LaundryCustomerSearchView";
			this.Text = "CustomerSearchView";
			this.Load += new System.EventHandler(this.LaundryCustomerSearchViewLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvunclaimeditems)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvunpaidtrans)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Balance2;
		private System.Windows.Forms.DataGridViewTextBoxColumn AmtDue2;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemQty2;
		private System.Windows.Forms.DataGridViewTextBoxColumn DueDate2;
		private System.Windows.Forms.DataGridViewTextBoxColumn ReceivedDate2;
		private System.Windows.Forms.DataGridViewTextBoxColumn TransactionNo2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
		private System.Windows.Forms.DataGridViewTextBoxColumn AmtDue;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemQty;
		private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn ReceivedDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn TransactionNo;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dgvunpaidtrans;
		private System.Windows.Forms.DataGridView dgvunclaimeditems;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtcustomer;
	}
}

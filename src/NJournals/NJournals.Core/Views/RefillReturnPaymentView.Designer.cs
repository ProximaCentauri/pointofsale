/*
 * Created by SharpDevelop.
 * User: user
 * Date: 2/12/2013
 * Time: 8:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NJournals.Core.Views
{
	partial class RefillReturnPaymentView
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
			this.cmbCustomers = new System.Windows.Forms.ComboBox();
			this.btnCustomerSearch = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtBottlesOnHand = new System.Windows.Forms.TextBox();
			this.txtCapsOnHand = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dgvOutBalance = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.txtchange = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtamttender = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtamtdue = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.btncancel = new System.Windows.Forms.Button();
			this.btnprint = new System.Windows.Forms.Button();
			this.dtDate = new System.Windows.Forms.DateTimePicker();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TransactionNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ItemQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalAmtDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalAmtTender = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvOutBalance)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbCustomers
			// 
			this.cmbCustomers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbCustomers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbCustomers.FormattingEnabled = true;
			this.cmbCustomers.Location = new System.Drawing.Point(125, 33);
			this.cmbCustomers.Name = "cmbCustomers";
			this.cmbCustomers.Size = new System.Drawing.Size(165, 21);
			this.cmbCustomers.TabIndex = 14;
			// 
			// btnCustomerSearch
			// 
			this.btnCustomerSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnCustomerSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCustomerSearch.FlatAppearance.BorderSize = 0;
			this.btnCustomerSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnCustomerSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnCustomerSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCustomerSearch.Location = new System.Drawing.Point(296, 31);
			this.btnCustomerSearch.Name = "btnCustomerSearch";
			this.btnCustomerSearch.Size = new System.Drawing.Size(24, 24);
			this.btnCustomerSearch.TabIndex = 13;
			this.btnCustomerSearch.UseVisualStyleBackColor = false;
			this.btnCustomerSearch.Click += new System.EventHandler(this.BtnCustomerSearchClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 22);
			this.label2.TabIndex = 12;
			this.label2.Text = "Customer Name: ";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 23);
			this.label1.TabIndex = 15;
			this.label1.Text = "Bottles on hand:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtBottlesOnHand
			// 
			this.txtBottlesOnHand.Location = new System.Drawing.Point(125, 60);
			this.txtBottlesOnHand.Name = "txtBottlesOnHand";
			this.txtBottlesOnHand.ReadOnly = true;
			this.txtBottlesOnHand.Size = new System.Drawing.Size(84, 20);
			this.txtBottlesOnHand.TabIndex = 16;
			// 
			// txtCapsOnHand
			// 
			this.txtCapsOnHand.Location = new System.Drawing.Point(125, 83);
			this.txtCapsOnHand.Name = "txtCapsOnHand";
			this.txtCapsOnHand.ReadOnly = true;
			this.txtCapsOnHand.Size = new System.Drawing.Size(84, 20);
			this.txtCapsOnHand.TabIndex = 18;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 23);
			this.label3.TabIndex = 17;
			this.label3.Text = "Caps on hand:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(364, 62);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(84, 20);
			this.textBox3.TabIndex = 20;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(251, 60);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(109, 23);
			this.label4.TabIndex = 19;
			this.label4.Text = "Returned Bottles:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(364, 85);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(84, 20);
			this.textBox4.TabIndex = 22;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(251, 83);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(109, 23);
			this.label5.TabIndex = 21;
			this.label5.Text = "Returned Caps:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(465, 33);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 23);
			this.label6.TabIndex = 23;
			this.label6.Text = "Date:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dgvOutBalance
			// 
			this.dgvOutBalance.AllowUserToAddRows = false;
			this.dgvOutBalance.AllowUserToDeleteRows = false;
			this.dgvOutBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOutBalance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Date,
									this.TransactionNo,
									this.ItemQty,
									this.TotalAmtDue,
									this.TotalAmtTender,
									this.Balance});
			this.dgvOutBalance.Location = new System.Drawing.Point(16, 149);
			this.dgvOutBalance.Name = "dgvOutBalance";
			this.dgvOutBalance.ReadOnly = true;
			this.dgvOutBalance.Size = new System.Drawing.Size(710, 180);
			this.dgvOutBalance.TabIndex = 25;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.label7.Font = new System.Drawing.Font("Calibri", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Teal;
			this.label7.Location = new System.Drawing.Point(16, 130);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(183, 16);
			this.label7.TabIndex = 26;
			this.label7.Text = "OUTSTANDING BALANCE:";
			// 
			// txtchange
			// 
			this.txtchange.Enabled = false;
			this.txtchange.Location = new System.Drawing.Point(607, 387);
			this.txtchange.Name = "txtchange";
			this.txtchange.Size = new System.Drawing.Size(119, 20);
			this.txtchange.TabIndex = 32;
			this.txtchange.Text = "0.00";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label12.Location = new System.Drawing.Point(514, 387);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(93, 18);
			this.label12.TabIndex = 31;
			this.label12.Text = "Change:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtamttender
			// 
			this.txtamttender.Location = new System.Drawing.Point(607, 361);
			this.txtamttender.Name = "txtamttender";
			this.txtamttender.Size = new System.Drawing.Size(119, 20);
			this.txtamttender.TabIndex = 30;
			this.txtamttender.Text = "0.00";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label11.Location = new System.Drawing.Point(483, 361);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(124, 18);
			this.label11.TabIndex = 29;
			this.label11.Text = "Amount Tender:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtamtdue
			// 
			this.txtamtdue.Enabled = false;
			this.txtamtdue.Location = new System.Drawing.Point(607, 335);
			this.txtamtdue.Name = "txtamtdue";
			this.txtamtdue.Size = new System.Drawing.Size(119, 20);
			this.txtamtdue.TabIndex = 28;
			this.txtamtdue.Text = "0.00";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Red;
			this.label10.Location = new System.Drawing.Point(538, 331);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(70, 28);
			this.label10.TabIndex = 27;
			this.label10.Text = "Balance:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btncancel
			// 
			this.btncancel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncancel.Location = new System.Drawing.Point(651, 441);
			this.btncancel.Name = "btncancel";
			this.btncancel.Size = new System.Drawing.Size(75, 23);
			this.btncancel.TabIndex = 34;
			this.btncancel.Text = "Cancel";
			this.btncancel.UseVisualStyleBackColor = true;
			// 
			// btnprint
			// 
			this.btnprint.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnprint.Location = new System.Drawing.Point(558, 441);
			this.btnprint.Name = "btnprint";
			this.btnprint.Size = new System.Drawing.Size(75, 23);
			this.btnprint.TabIndex = 33;
			this.btnprint.Text = "Save";
			this.btnprint.UseVisualStyleBackColor = true;
			// 
			// dtDate
			// 
			this.dtDate.Font = new System.Drawing.Font("Calibri", 9.75F);
			this.dtDate.Location = new System.Drawing.Point(526, 33);
			this.dtDate.Name = "dtDate";
			this.dtDate.Size = new System.Drawing.Size(200, 23);
			this.dtDate.TabIndex = 35;
			this.dtDate.Value = new System.DateTime(2013, 2, 2, 18, 46, 34, 0);
			// 
			// Date
			// 
			this.Date.HeaderText = "Date";
			this.Date.Name = "Date";
			this.Date.ReadOnly = true;
			this.Date.Width = 135;
			// 
			// TransactionNo
			// 
			this.TransactionNo.HeaderText = "Transaction #";
			this.TransactionNo.Name = "TransactionNo";
			this.TransactionNo.ReadOnly = true;
			this.TransactionNo.Width = 131;
			// 
			// ItemQty
			// 
			this.ItemQty.HeaderText = "Total # Items";
			this.ItemQty.Name = "ItemQty";
			this.ItemQty.ReadOnly = true;
			// 
			// TotalAmtDue
			// 
			this.TotalAmtDue.HeaderText = "Total Amount Due";
			this.TotalAmtDue.Name = "TotalAmtDue";
			this.TotalAmtDue.ReadOnly = true;
			// 
			// TotalAmtTender
			// 
			this.TotalAmtTender.HeaderText = "Total Amount Tender";
			this.TotalAmtTender.Name = "TotalAmtTender";
			this.TotalAmtTender.ReadOnly = true;
			// 
			// Balance
			// 
			this.Balance.HeaderText = "Balance";
			this.Balance.Name = "Balance";
			this.Balance.ReadOnly = true;
			// 
			// RefillReturnPaymentView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.ClientSize = new System.Drawing.Size(751, 487);
			this.Controls.Add(this.dtDate);
			this.Controls.Add(this.btncancel);
			this.Controls.Add(this.btnprint);
			this.Controls.Add(this.txtchange);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtamttender);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtamtdue);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dgvOutBalance);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtCapsOnHand);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtBottlesOnHand);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbCustomers);
			this.Controls.Add(this.btnCustomerSearch);
			this.Controls.Add(this.label2);
			this.Name = "RefillReturnPaymentView";
			this.Text = "RefillReturnPaymentView";
			this.Load += new System.EventHandler(this.RefillReturnPaymentViewLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvOutBalance)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmtTender;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmtDue;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemQty;
		private System.Windows.Forms.DataGridViewTextBoxColumn TransactionNo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Date;
		private System.Windows.Forms.DateTimePicker dtDate;
		private System.Windows.Forms.Button btnprint;
		private System.Windows.Forms.Button btncancel;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtamtdue;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtamttender;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtchange;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dgvOutBalance;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCapsOnHand;
		private System.Windows.Forms.TextBox txtBottlesOnHand;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnCustomerSearch;
		private System.Windows.Forms.ComboBox cmbCustomers;
	}
}

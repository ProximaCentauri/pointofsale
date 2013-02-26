﻿/*
 * Created by SharpDevelop.
 * User: vo185003
 * Date: 1/25/2013
 * Time: 9:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NJournals.Core.Views
{
	partial class RefillingView
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtDate = new System.Windows.Forms.DateTimePicker();
			this.cmbCustomers = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtjonumber = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbtransTypes = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.grpServices = new System.Windows.Forms.GroupBox();
			this.txtcaps = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtbottles = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnadd = new System.Windows.Forms.Button();
			this.txtnoitems = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbproducts = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtchange = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtamttender = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtamtdue = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.btncancel = new System.Windows.Forms.Button();
			this.btnprintclose = new System.Windows.Forms.Button();
			this.chkunpaid = new System.Windows.Forms.CheckBox();
			this.btndeleteclose = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblvoid = new System.Windows.Forms.Label();
			this.btnsearch = new System.Windows.Forms.Button();
			this.txtsearch = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtbalance = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.grpServices.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtDate);
			this.groupBox1.Controls.Add(this.cmbCustomers);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtjonumber);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cmbtransTypes);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(16, 70);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(730, 113);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Transaction Information";
			// 
			// dtDate
			// 
			this.dtDate.Location = new System.Drawing.Point(421, 23);
			this.dtDate.Name = "dtDate";
			this.dtDate.Size = new System.Drawing.Size(200, 23);
			this.dtDate.TabIndex = 24;
			this.dtDate.Value = new System.DateTime(2013, 2, 2, 18, 46, 34, 0);
			// 
			// cmbCustomers
			// 
			this.cmbCustomers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbCustomers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbCustomers.FormattingEnabled = true;
			this.cmbCustomers.Location = new System.Drawing.Point(143, 84);
			this.cmbCustomers.Name = "cmbCustomers";
			this.cmbCustomers.Size = new System.Drawing.Size(154, 23);
			this.cmbCustomers.TabIndex = 23;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(315, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Date:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(28, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Customer Name: ";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtjonumber
			// 
			this.txtjonumber.BackColor = System.Drawing.Color.White;
			this.txtjonumber.Enabled = false;
			this.txtjonumber.Location = new System.Drawing.Point(143, 55);
			this.txtjonumber.Name = "txtjonumber";
			this.txtjonumber.Size = new System.Drawing.Size(154, 23);
			this.txtjonumber.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(33, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Job Order:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbtransTypes
			// 
			this.cmbtransTypes.FormattingEnabled = true;
			this.cmbtransTypes.Location = new System.Drawing.Point(143, 23);
			this.cmbtransTypes.Name = "cmbtransTypes";
			this.cmbtransTypes.Size = new System.Drawing.Size(154, 23);
			this.cmbtransTypes.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(35, 26);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(109, 23);
			this.label5.TabIndex = 2;
			this.label5.Text = "Transaction Type:";
			// 
			// grpServices
			// 
			this.grpServices.Controls.Add(this.txtcaps);
			this.grpServices.Controls.Add(this.label8);
			this.grpServices.Controls.Add(this.txtbottles);
			this.grpServices.Controls.Add(this.label6);
			this.grpServices.Controls.Add(this.btnadd);
			this.grpServices.Controls.Add(this.txtnoitems);
			this.grpServices.Controls.Add(this.label7);
			this.grpServices.Controls.Add(this.label4);
			this.grpServices.Controls.Add(this.cmbproducts);
			this.grpServices.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpServices.Location = new System.Drawing.Point(16, 189);
			this.grpServices.Name = "grpServices";
			this.grpServices.Size = new System.Drawing.Size(239, 197);
			this.grpServices.TabIndex = 4;
			this.grpServices.TabStop = false;
			this.grpServices.Text = "Services";
			// 
			// txtcaps
			// 
			this.txtcaps.Location = new System.Drawing.Point(87, 105);
			this.txtcaps.Name = "txtcaps";
			this.txtcaps.Size = new System.Drawing.Size(100, 23);
			this.txtcaps.TabIndex = 16;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(16, 107);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(70, 23);
			this.label8.TabIndex = 15;
			this.label8.Text = "Store Caps:";
			// 
			// txtbottles
			// 
			this.txtbottles.Location = new System.Drawing.Point(87, 79);
			this.txtbottles.Name = "txtbottles";
			this.txtbottles.Size = new System.Drawing.Size(100, 23);
			this.txtbottles.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(3, 82);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 23);
			this.label6.TabIndex = 13;
			this.label6.Text = "Store Bottles:";
			// 
			// btnadd
			// 
			this.btnadd.Location = new System.Drawing.Point(154, 155);
			this.btnadd.Name = "btnadd";
			this.btnadd.Size = new System.Drawing.Size(75, 23);
			this.btnadd.TabIndex = 12;
			this.btnadd.Text = "Add";
			this.btnadd.UseVisualStyleBackColor = true;
			this.btnadd.Click += new System.EventHandler(this.BtnaddClick);
			// 
			// txtnoitems
			// 
			this.txtnoitems.Location = new System.Drawing.Point(87, 53);
			this.txtnoitems.Name = "txtnoitems";
			this.txtnoitems.Size = new System.Drawing.Size(100, 23);
			this.txtnoitems.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(19, 56);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(71, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "# of Items:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(25, 32);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Products:";
			// 
			// cmbproducts
			// 
			this.cmbproducts.FormattingEnabled = true;
			this.cmbproducts.Location = new System.Drawing.Point(87, 27);
			this.cmbproducts.Name = "cmbproducts";
			this.cmbproducts.Size = new System.Drawing.Size(142, 23);
			this.cmbproducts.TabIndex = 2;
			this.cmbproducts.SelectedIndexChanged += new System.EventHandler(this.cmbproducts_selectedindexchange);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column3,
									this.Column4,
									this.column2,
									this.Column5});
			this.dataGridView1.Location = new System.Drawing.Point(318, 189);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(538, 197);
			this.dataGridView1.TabIndex = 5;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Products";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Store Bottles";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Store Caps";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// column2
			// 
			this.column2.HeaderText = "No. of Items";
			this.column2.Name = "column2";
			this.column2.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Price";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// txtchange
			// 
			this.txtchange.Enabled = false;
			this.txtchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtchange.Location = new System.Drawing.Point(737, 504);
			this.txtchange.Name = "txtchange";
			this.txtchange.Size = new System.Drawing.Size(119, 20);
			this.txtchange.TabIndex = 19;
			this.txtchange.Text = "0.00";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label12.Location = new System.Drawing.Point(641, 505);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(93, 18);
			this.label12.TabIndex = 18;
			this.label12.Text = "Change:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtamttender
			// 
			this.txtamttender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtamttender.Location = new System.Drawing.Point(737, 452);
			this.txtamttender.Name = "txtamttender";
			this.txtamttender.Size = new System.Drawing.Size(119, 20);
			this.txtamttender.TabIndex = 17;
			this.txtamttender.Text = "0.00";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label11.Location = new System.Drawing.Point(613, 452);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(124, 18);
			this.label11.TabIndex = 16;
			this.label11.Text = "Amount Tender:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtamtdue
			// 
			this.txtamtdue.Enabled = false;
			this.txtamtdue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtamtdue.Location = new System.Drawing.Point(737, 398);
			this.txtamtdue.Name = "txtamtdue";
			this.txtamtdue.Size = new System.Drawing.Size(119, 20);
			this.txtamtdue.TabIndex = 15;
			this.txtamtdue.Text = "0.00";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Red;
			this.label10.Location = new System.Drawing.Point(647, 398);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(93, 18);
			this.label10.TabIndex = 14;
			this.label10.Text = "Amount Due:";
			// 
			// btncancel
			// 
			this.btncancel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncancel.Location = new System.Drawing.Point(768, 531);
			this.btncancel.Name = "btncancel";
			this.btncancel.Size = new System.Drawing.Size(85, 23);
			this.btncancel.TabIndex = 21;
			this.btncancel.Text = "Cancel";
			this.btncancel.UseVisualStyleBackColor = true;
			this.btncancel.Click += new System.EventHandler(this.BtncancelClick);
			// 
			// btnprintclose
			// 
			this.btnprintclose.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnprintclose.Location = new System.Drawing.Point(498, 531);
			this.btnprintclose.Name = "btnprintclose";
			this.btnprintclose.Size = new System.Drawing.Size(136, 23);
			this.btnprintclose.TabIndex = 20;
			this.btnprintclose.Text = " Print && Close";
			this.btnprintclose.UseVisualStyleBackColor = true;
			this.btnprintclose.Click += new System.EventHandler(this.BtnprintcloseClick);
			// 
			// chkunpaid
			// 
			this.chkunpaid.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkunpaid.Location = new System.Drawing.Point(737, 424);
			this.chkunpaid.Name = "chkunpaid";
			this.chkunpaid.Size = new System.Drawing.Size(104, 24);
			this.chkunpaid.TabIndex = 22;
			this.chkunpaid.Text = "Unpaid";
			this.chkunpaid.UseVisualStyleBackColor = true;
			// 
			// btndeleteclose
			// 
			this.btndeleteclose.Enabled = false;
			this.btndeleteclose.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btndeleteclose.Location = new System.Drawing.Point(644, 531);
			this.btndeleteclose.Name = "btndeleteclose";
			this.btndeleteclose.Size = new System.Drawing.Size(118, 23);
			this.btndeleteclose.TabIndex = 23;
			this.btndeleteclose.Text = "Delete && Close";
			this.btndeleteclose.UseVisualStyleBackColor = true;
			this.btndeleteclose.Click += new System.EventHandler(this.BtndeletecloseClick);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.groupBox2.Controls.Add(this.lblvoid);
			this.groupBox2.Controls.Add(this.btnsearch);
			this.groupBox2.Controls.Add(this.txtsearch);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Enabled = false;
			this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(19, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(831, 48);
			this.groupBox2.TabIndex = 24;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Search";
			// 
			// lblvoid
			// 
			this.lblvoid.BackColor = System.Drawing.Color.Transparent;
			this.lblvoid.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblvoid.ForeColor = System.Drawing.Color.Red;
			this.lblvoid.Location = new System.Drawing.Point(415, 12);
			this.lblvoid.Name = "lblvoid";
			this.lblvoid.Size = new System.Drawing.Size(403, 33);
			this.lblvoid.TabIndex = 6;
			this.lblvoid.Text = "VOIDED TRANSACTION";
			this.lblvoid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblvoid.Visible = false;
			// 
			// btnsearch
			// 
			this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnsearch.FlatAppearance.BorderSize = 0;
			this.btnsearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnsearch.Location = new System.Drawing.Point(415, 10);
			this.btnsearch.Name = "btnsearch";
			this.btnsearch.Size = new System.Drawing.Size(24, 24);
			this.btnsearch.TabIndex = 4;
			this.btnsearch.UseVisualStyleBackColor = false;
			this.btnsearch.Click += new System.EventHandler(this.BtnsearchClick);
			// 
			// txtsearch
			// 
			this.txtsearch.Location = new System.Drawing.Point(140, 17);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new System.Drawing.Size(258, 23);
			this.txtsearch.TabIndex = 3;
			this.txtsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsearch_keydown);
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(33, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 2;
			this.label9.Text = "Job Order:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtbalance
			// 
			this.txtbalance.BackColor = System.Drawing.SystemColors.Info;
			this.txtbalance.Enabled = false;
			this.txtbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtbalance.ForeColor = System.Drawing.Color.Black;
			this.txtbalance.Location = new System.Drawing.Point(737, 478);
			this.txtbalance.Name = "txtbalance";
			this.txtbalance.Size = new System.Drawing.Size(119, 20);
			this.txtbalance.TabIndex = 26;
			this.txtbalance.Text = "0.00";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Maroon;
			this.label13.Location = new System.Drawing.Point(647, 478);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(90, 18);
			this.label13.TabIndex = 25;
			this.label13.Text = "Balance:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// RefillingView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.ClientSize = new System.Drawing.Size(892, 566);
			this.Controls.Add(this.txtbalance);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btndeleteclose);
			this.Controls.Add(this.chkunpaid);
			this.Controls.Add(this.btncancel);
			this.Controls.Add(this.btnprintclose);
			this.Controls.Add(this.txtchange);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtamttender);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtamtdue);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.grpServices);
			this.Controls.Add(this.groupBox1);
			this.Name = "RefillingView";
			this.Text = "RefillingView";
			this.Load += new System.EventHandler(this.RefillingViewLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.grpServices.ResumeLayout(false);
			this.grpServices.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblvoid;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtbalance;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtsearch;
		private System.Windows.Forms.Button btnsearch;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btndeleteclose;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DateTimePicker dtDate;
		private System.Windows.Forms.ComboBox cmbCustomers;
		private System.Windows.Forms.CheckBox chkunpaid;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtbottles;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtcaps;
		private System.Windows.Forms.Button btnprintclose;
		private System.Windows.Forms.Button btncancel;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtamtdue;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtamttender;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtchange;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox cmbproducts;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtnoitems;
		private System.Windows.Forms.Button btnadd;
		private System.Windows.Forms.GroupBox grpServices;
		private System.Windows.Forms.ComboBox cmbtransTypes;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtjonumber;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}

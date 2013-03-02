/*
 * Created by SharpDevelop.
 * User: vo185003
 * Date: 1/25/2013
 * Time: 7:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NJournals.Core.Views
{
	partial class LaundryNewView
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbCustomers = new System.Windows.Forms.ComboBox();
			this.btnCustomerSearch = new System.Windows.Forms.Button();
			this.dtdueDate = new System.Windows.Forms.DateTimePicker();
			this.dtrecieveDate = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtjoborder = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbservices = new System.Windows.Forms.ComboBox();
			this.grpServices = new System.Windows.Forms.GroupBox();
			this.btnadd = new System.Windows.Forms.Button();
			this.txtkilo = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtnoitems = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbcategory = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblvoid = new System.Windows.Forms.Label();
			this.btnsearch = new System.Windows.Forms.Button();
			this.txtsearch = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtamtdue = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtamttender = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtchange = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.chkchargesList = new System.Windows.Forms.CheckedListBox();
			this.btnsaveclose = new System.Windows.Forms.Button();
			this.btncancel = new System.Windows.Forms.Button();
			this.btndelete = new System.Windows.Forms.Button();
			this.txtbalance = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.lblchecklist = new System.Windows.Forms.Label();
			this.btnclaim = new System.Windows.Forms.Button();
			this.txttotalcharges = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.txtdiscount = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.txttotalamtdue = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.txttotaldiscount = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.btnDeleteDetail = new System.Windows.Forms.Button();
			this.btnprint = new System.Windows.Forms.Button();
			this.btnEditCharges = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.grpServices.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbCustomers);
			this.groupBox1.Controls.Add(this.btnCustomerSearch);
			this.groupBox1.Controls.Add(this.dtdueDate);
			this.groupBox1.Controls.Add(this.dtrecieveDate);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtjoborder);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(20, 74);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(834, 84);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Transaction Information";
			// 
			// cmbCustomers
			// 
			this.cmbCustomers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbCustomers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCustomers.FormattingEnabled = true;
			this.cmbCustomers.Location = new System.Drawing.Point(143, 50);
			this.cmbCustomers.Name = "cmbCustomers";
			this.cmbCustomers.Size = new System.Drawing.Size(258, 26);
			this.cmbCustomers.TabIndex = 11;
			// 
			// btnCustomerSearch
			// 
			this.btnCustomerSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnCustomerSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCustomerSearch.FlatAppearance.BorderSize = 0;
			this.btnCustomerSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnCustomerSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnCustomerSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCustomerSearch.Location = new System.Drawing.Point(417, 51);
			this.btnCustomerSearch.Name = "btnCustomerSearch";
			this.btnCustomerSearch.Size = new System.Drawing.Size(24, 24);
			this.btnCustomerSearch.TabIndex = 10;
			this.btnCustomerSearch.UseVisualStyleBackColor = false;
			this.btnCustomerSearch.Click += new System.EventHandler(this.BtnCustomerSearchClick);
			// 
			// dtdueDate
			// 
			this.dtdueDate.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtdueDate.Location = new System.Drawing.Point(610, 50);
			this.dtdueDate.Name = "dtdueDate";
			this.dtdueDate.Size = new System.Drawing.Size(200, 24);
			this.dtdueDate.TabIndex = 9;
			this.dtdueDate.Value = new System.DateTime(2013, 2, 2, 18, 46, 42, 0);
			// 
			// dtrecieveDate
			// 
			this.dtrecieveDate.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtrecieveDate.Location = new System.Drawing.Point(610, 20);
			this.dtrecieveDate.Name = "dtrecieveDate";
			this.dtrecieveDate.Size = new System.Drawing.Size(200, 24);
			this.dtrecieveDate.TabIndex = 8;
			this.dtrecieveDate.Value = new System.DateTime(2013, 2, 2, 18, 46, 34, 0);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(507, 51);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Due Date:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(508, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Received Date:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(33, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Customer Name: ";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtjoborder
			// 
			this.txtjoborder.BackColor = System.Drawing.Color.White;
			this.txtjoborder.Enabled = false;
			this.txtjoborder.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtjoborder.Location = new System.Drawing.Point(143, 21);
			this.txtjoborder.Name = "txtjoborder";
			this.txtjoborder.Size = new System.Drawing.Size(258, 24);
			this.txtjoborder.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(40, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Job Order:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbservices
			// 
			this.cmbservices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbservices.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbservices.FormattingEnabled = true;
			this.cmbservices.Location = new System.Drawing.Point(84, 27);
			this.cmbservices.Name = "cmbservices";
			this.cmbservices.Size = new System.Drawing.Size(190, 23);
			this.cmbservices.TabIndex = 2;
			this.cmbservices.SelectedIndexChanged += new System.EventHandler(this.cmbservices_selectedindexchange);
			// 
			// grpServices
			// 
			this.grpServices.Controls.Add(this.btnadd);
			this.grpServices.Controls.Add(this.txtkilo);
			this.grpServices.Controls.Add(this.label8);
			this.grpServices.Controls.Add(this.txtnoitems);
			this.grpServices.Controls.Add(this.label7);
			this.grpServices.Controls.Add(this.cmbcategory);
			this.grpServices.Controls.Add(this.label5);
			this.grpServices.Controls.Add(this.label6);
			this.grpServices.Controls.Add(this.cmbservices);
			this.grpServices.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpServices.Location = new System.Drawing.Point(21, 167);
			this.grpServices.Name = "grpServices";
			this.grpServices.Size = new System.Drawing.Size(292, 173);
			this.grpServices.TabIndex = 3;
			this.grpServices.TabStop = false;
			this.grpServices.Text = "Services";
			// 
			// btnadd
			// 
			this.btnadd.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnadd.Location = new System.Drawing.Point(199, 137);
			this.btnadd.Name = "btnadd";
			this.btnadd.Size = new System.Drawing.Size(75, 23);
			this.btnadd.TabIndex = 12;
			this.btnadd.Text = "Add";
			this.btnadd.UseVisualStyleBackColor = true;
			this.btnadd.Click += new System.EventHandler(this.BtnaddClick);
			// 
			// txtkilo
			// 
			this.txtkilo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtkilo.Location = new System.Drawing.Point(84, 105);
			this.txtkilo.Name = "txtkilo";
			this.txtkilo.Size = new System.Drawing.Size(100, 24);
			this.txtkilo.TabIndex = 10;
			this.txtkilo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_keypress);
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(43, 108);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 23);
			this.label8.TabIndex = 9;
			this.label8.Text = "Kilos:";
			// 
			// txtnoitems
			// 
			this.txtnoitems.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtnoitems.Location = new System.Drawing.Point(84, 79);
			this.txtnoitems.Name = "txtnoitems";
			this.txtnoitems.Size = new System.Drawing.Size(100, 24);
			this.txtnoitems.TabIndex = 7;
			this.txtnoitems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_keypress);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(13, 82);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(71, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "# of Items:";
			// 
			// cmbcategory
			// 
			this.cmbcategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbcategory.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbcategory.FormattingEnabled = true;
			this.cmbcategory.Location = new System.Drawing.Point(84, 53);
			this.cmbcategory.Name = "cmbcategory";
			this.cmbcategory.Size = new System.Drawing.Size(190, 23);
			this.cmbcategory.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(22, 31);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Services:";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(9, 52);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 23);
			this.label6.TabIndex = 3;
			this.label6.Text = "Category:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2,
									this.Column3,
									this.Column4,
									this.Column5});
			this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridView1.Location = new System.Drawing.Point(329, 176);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(591, 240);
			this.dataGridView1.TabIndex = 4;
			this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_rowsremoved);
			this.dataGridView1.SelectionChanged += new System.EventHandler(this.dgv_selectionchanged);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Category";
			this.Column1.Name = "Column1";
			this.Column1.Width = 130;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Service";
			this.Column2.Name = "Column2";
			this.Column2.Width = 130;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "No. of Items";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Kilo";
			this.Column4.Name = "Column4";
			this.Column4.Width = 88;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Price";
			this.Column5.Name = "Column5";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.groupBox2.Controls.Add(this.lblvoid);
			this.groupBox2.Controls.Add(this.btnsearch);
			this.groupBox2.Controls.Add(this.txtsearch);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(21, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(831, 54);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Search";
			// 
			// lblvoid
			// 
			this.lblvoid.BackColor = System.Drawing.Color.Transparent;
			this.lblvoid.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblvoid.ForeColor = System.Drawing.Color.Red;
			this.lblvoid.Location = new System.Drawing.Point(497, 16);
			this.lblvoid.Name = "lblvoid";
			this.lblvoid.Size = new System.Drawing.Size(310, 33);
			this.lblvoid.TabIndex = 5;
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
			this.btnsearch.Location = new System.Drawing.Point(407, 21);
			this.btnsearch.Name = "btnsearch";
			this.btnsearch.Size = new System.Drawing.Size(24, 24);
			this.btnsearch.TabIndex = 4;
			this.btnsearch.UseVisualStyleBackColor = false;
			this.btnsearch.Click += new System.EventHandler(this.BtnsearchClick);
			// 
			// txtsearch
			// 
			this.txtsearch.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtsearch.Location = new System.Drawing.Point(143, 22);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new System.Drawing.Size(258, 24);
			this.txtsearch.TabIndex = 3;
			this.txtsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsearch_keypress);
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(37, 22);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 2;
			this.label9.Text = "Job Order:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtamtdue
			// 
			this.txtamtdue.BackColor = System.Drawing.SystemColors.Info;
			this.txtamtdue.Enabled = false;
			this.txtamtdue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtamtdue.ForeColor = System.Drawing.Color.Black;
			this.txtamtdue.Location = new System.Drawing.Point(801, 422);
			this.txtamtdue.Name = "txtamtdue";
			this.txtamtdue.Size = new System.Drawing.Size(119, 27);
			this.txtamtdue.TabIndex = 9;
			this.txtamtdue.Text = "0.00";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.DimGray;
			this.label10.Location = new System.Drawing.Point(711, 425);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(93, 18);
			this.label10.TabIndex = 8;
			this.label10.Text = "Amount Due:";
			// 
			// txtamttender
			// 
			this.txtamttender.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtamttender.Location = new System.Drawing.Point(801, 540);
			this.txtamttender.Name = "txtamttender";
			this.txtamttender.Size = new System.Drawing.Size(119, 29);
			this.txtamttender.TabIndex = 11;
			this.txtamttender.Text = "0.00";
			this.txtamttender.Click += new System.EventHandler(this.textbox_click);
			this.txtamttender.TextChanged += new System.EventHandler(this.txtamttender_textchanged);
			this.txtamttender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_keypress);
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label11.Location = new System.Drawing.Point(677, 544);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(124, 18);
			this.label11.TabIndex = 10;
			this.label11.Text = "Amount Tender:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtchange
			// 
			this.txtchange.BackColor = System.Drawing.SystemColors.Info;
			this.txtchange.Enabled = false;
			this.txtchange.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtchange.ForeColor = System.Drawing.Color.Black;
			this.txtchange.Location = new System.Drawing.Point(801, 609);
			this.txtchange.Name = "txtchange";
			this.txtchange.Size = new System.Drawing.Size(119, 29);
			this.txtchange.TabIndex = 13;
			this.txtchange.Text = "0.00";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label12.Location = new System.Drawing.Point(708, 613);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(93, 18);
			this.label12.TabIndex = 12;
			this.label12.Text = "Change:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.chkchargesList);
			this.groupBox3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.groupBox3.Location = new System.Drawing.Point(329, 421);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(206, 197);
			this.groupBox3.TabIndex = 14;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Additional Charges";
			// 
			// chkchargesList
			// 
			this.chkchargesList.CheckOnClick = true;
			this.chkchargesList.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkchargesList.FormattingEnabled = true;
			this.chkchargesList.Location = new System.Drawing.Point(12, 18);
			this.chkchargesList.Name = "chkchargesList";
			this.chkchargesList.Size = new System.Drawing.Size(182, 156);
			this.chkchargesList.TabIndex = 24;
			this.chkchargesList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkchargesList_ItemChecked);
			// 
			// btnsaveclose
			// 
			this.btnsaveclose.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsaveclose.Location = new System.Drawing.Point(716, 670);
			this.btnsaveclose.Name = "btnsaveclose";
			this.btnsaveclose.Size = new System.Drawing.Size(99, 23);
			this.btnsaveclose.TabIndex = 16;
			this.btnsaveclose.Text = "Save && Close";
			this.btnsaveclose.UseVisualStyleBackColor = true;
			this.btnsaveclose.Click += new System.EventHandler(this.BtnsavecloseClick);
			// 
			// btncancel
			// 
			this.btncancel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncancel.Location = new System.Drawing.Point(28, 670);
			this.btncancel.Name = "btncancel";
			this.btncancel.Size = new System.Drawing.Size(99, 23);
			this.btncancel.TabIndex = 17;
			this.btncancel.Text = "Cancel";
			this.btncancel.UseVisualStyleBackColor = true;
			this.btncancel.Click += new System.EventHandler(this.BtncancelClick);
			// 
			// btndelete
			// 
			this.btndelete.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btndelete.Location = new System.Drawing.Point(133, 670);
			this.btndelete.Name = "btndelete";
			this.btndelete.Size = new System.Drawing.Size(91, 23);
			this.btndelete.TabIndex = 18;
			this.btndelete.Text = "Delete";
			this.btndelete.UseVisualStyleBackColor = true;
			this.btndelete.Click += new System.EventHandler(this.BtndeleteClick);
			// 
			// txtbalance
			// 
			this.txtbalance.BackColor = System.Drawing.SystemColors.Info;
			this.txtbalance.Enabled = false;
			this.txtbalance.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtbalance.ForeColor = System.Drawing.Color.Black;
			this.txtbalance.Location = new System.Drawing.Point(801, 575);
			this.txtbalance.Name = "txtbalance";
			this.txtbalance.Size = new System.Drawing.Size(119, 29);
			this.txtbalance.TabIndex = 21;
			this.txtbalance.Text = "0.00";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Maroon;
			this.label13.Location = new System.Drawing.Point(711, 579);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(90, 18);
			this.label13.TabIndex = 20;
			this.label13.Text = "Balance:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblchecklist
			// 
			this.lblchecklist.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblchecklist.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblchecklist.ForeColor = System.Drawing.Color.Blue;
			this.lblchecklist.Location = new System.Drawing.Point(54, 400);
			this.lblchecklist.Name = "lblchecklist";
			this.lblchecklist.Size = new System.Drawing.Size(116, 23);
			this.lblchecklist.TabIndex = 22;
			this.lblchecklist.Text = "Add/Edit CheckList";
			this.lblchecklist.Click += new System.EventHandler(this.lblchecklist_click);
			// 
			// btnclaim
			// 
			this.btnclaim.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnclaim.Location = new System.Drawing.Point(821, 670);
			this.btnclaim.Name = "btnclaim";
			this.btnclaim.Size = new System.Drawing.Size(99, 23);
			this.btnclaim.TabIndex = 23;
			this.btnclaim.Text = "Claim && Close";
			this.btnclaim.UseVisualStyleBackColor = true;
			this.btnclaim.Click += new System.EventHandler(this.BtnclaimClick);
			// 
			// txttotalcharges
			// 
			this.txttotalcharges.BackColor = System.Drawing.SystemColors.Info;
			this.txttotalcharges.Enabled = false;
			this.txttotalcharges.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttotalcharges.ForeColor = System.Drawing.Color.Black;
			this.txttotalcharges.Location = new System.Drawing.Point(801, 448);
			this.txttotalcharges.Name = "txttotalcharges";
			this.txttotalcharges.Size = new System.Drawing.Size(119, 27);
			this.txttotalcharges.TabIndex = 25;
			this.txttotalcharges.Text = "0.00";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.ForeColor = System.Drawing.Color.DimGray;
			this.label16.Location = new System.Drawing.Point(708, 449);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(93, 18);
			this.label16.TabIndex = 24;
			this.label16.Text = "Total Charges:";
			// 
			// txtdiscount
			// 
			this.txtdiscount.BackColor = System.Drawing.SystemColors.Info;
			this.txtdiscount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtdiscount.ForeColor = System.Drawing.Color.Black;
			this.txtdiscount.Location = new System.Drawing.Point(801, 477);
			this.txtdiscount.Name = "txtdiscount";
			this.txtdiscount.Size = new System.Drawing.Size(34, 27);
			this.txtdiscount.TabIndex = 27;
			this.txtdiscount.Text = "0";
			this.txtdiscount.Click += new System.EventHandler(this.textbox_click);
			this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_textchange);
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.ForeColor = System.Drawing.Color.DimGray;
			this.label17.Location = new System.Drawing.Point(690, 479);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(114, 18);
			this.label17.TabIndex = 26;
			this.label17.Text = "Total Discount:";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txttotalamtdue
			// 
			this.txttotalamtdue.BackColor = System.Drawing.SystemColors.Info;
			this.txttotalamtdue.Enabled = false;
			this.txttotalamtdue.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttotalamtdue.ForeColor = System.Drawing.Color.Black;
			this.txttotalamtdue.Location = new System.Drawing.Point(801, 506);
			this.txttotalamtdue.Name = "txttotalamtdue";
			this.txttotalamtdue.Size = new System.Drawing.Size(119, 29);
			this.txttotalamtdue.TabIndex = 29;
			this.txttotalamtdue.Text = "0.00";
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.ForeColor = System.Drawing.Color.Red;
			this.label18.Location = new System.Drawing.Point(650, 510);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(152, 18);
			this.label18.TabIndex = 28;
			this.label18.Text = "Total Amount Due:";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txttotaldiscount
			// 
			this.txttotaldiscount.BackColor = System.Drawing.SystemColors.Info;
			this.txttotaldiscount.Enabled = false;
			this.txttotaldiscount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttotaldiscount.ForeColor = System.Drawing.Color.Black;
			this.txttotaldiscount.Location = new System.Drawing.Point(861, 477);
			this.txttotaldiscount.Name = "txttotaldiscount";
			this.txttotaldiscount.Size = new System.Drawing.Size(59, 27);
			this.txttotaldiscount.TabIndex = 30;
			this.txttotaldiscount.Text = "0.00";
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(836, 478);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(22, 17);
			this.label19.TabIndex = 31;
			this.label19.Text = "%";
			// 
			// btnDeleteDetail
			// 
			this.btnDeleteDetail.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDeleteDetail.FlatAppearance.BorderSize = 0;
			this.btnDeleteDetail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnDeleteDetail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnDeleteDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteDetail.Location = new System.Drawing.Point(926, 219);
			this.btnDeleteDetail.Name = "btnDeleteDetail";
			this.btnDeleteDetail.Size = new System.Drawing.Size(35, 23);
			this.btnDeleteDetail.TabIndex = 32;
			this.btnDeleteDetail.UseVisualStyleBackColor = true;
			this.btnDeleteDetail.Click += new System.EventHandler(this.BtnDeleteDetailClick);
			// 
			// btnprint
			// 
			this.btnprint.Enabled = false;
			this.btnprint.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnprint.Location = new System.Drawing.Point(611, 670);
			this.btnprint.Name = "btnprint";
			this.btnprint.Size = new System.Drawing.Size(99, 23);
			this.btnprint.TabIndex = 33;
			this.btnprint.Text = "Print";
			this.btnprint.UseVisualStyleBackColor = true;
			this.btnprint.Click += new System.EventHandler(this.BtnprintClick);
			// 
			// btnEditCharges
			// 
			this.btnEditCharges.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditCharges.FlatAppearance.BorderSize = 0;
			this.btnEditCharges.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnEditCharges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnEditCharges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditCharges.Location = new System.Drawing.Point(541, 439);
			this.btnEditCharges.Name = "btnEditCharges";
			this.btnEditCharges.Size = new System.Drawing.Size(24, 24);
			this.btnEditCharges.TabIndex = 34;
			this.btnEditCharges.UseVisualStyleBackColor = true;
			this.btnEditCharges.Click += new System.EventHandler(this.BtnEditChargesClick);
			// 
			// LaundryNewView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.ClientSize = new System.Drawing.Size(984, 722);
			this.Controls.Add(this.btnEditCharges);
			this.Controls.Add(this.btnprint);
			this.Controls.Add(this.btnDeleteDetail);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.txttotaldiscount);
			this.Controls.Add(this.txttotalamtdue);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.txtdiscount);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.txttotalcharges);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.btnclaim);
			this.Controls.Add(this.lblchecklist);
			this.Controls.Add(this.txtbalance);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.btndelete);
			this.Controls.Add(this.btncancel);
			this.Controls.Add(this.btnsaveclose);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.txtchange);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtamttender);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtamtdue);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.grpServices);
			this.Controls.Add(this.groupBox1);
			this.Name = "LaundryNewView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "LaundryNewView";
			this.Load += new System.EventHandler(this.LaundryNewViewLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.grpServices.ResumeLayout(false);
			this.grpServices.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnEditCharges;
		private System.Windows.Forms.Button btnprint;
		private System.Windows.Forms.Label lblvoid;
		private System.Windows.Forms.Button btnDeleteDetail;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox txttotaldiscount;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox txttotalamtdue;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtdiscount;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txttotalcharges;
		private System.Windows.Forms.CheckedListBox chkchargesList;
		private System.Windows.Forms.ComboBox cmbCustomers;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.Button btnclaim;
		private System.Windows.Forms.Button btnCustomerSearch;
		private System.Windows.Forms.Label lblchecklist;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtbalance;
		private System.Windows.Forms.Button btndelete;
		private System.Windows.Forms.DateTimePicker dtrecieveDate;
		private System.Windows.Forms.DateTimePicker dtdueDate;
		private System.Windows.Forms.Button btncancel;
		private System.Windows.Forms.Button btnsaveclose;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtchange;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtamttender;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtamtdue;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtsearch;
		private System.Windows.Forms.Button btnsearch;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtnoitems;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtkilo;
		private System.Windows.Forms.Button btnadd;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbcategory;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox grpServices;
		private System.Windows.Forms.ComboBox cmbservices;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtjoborder;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}

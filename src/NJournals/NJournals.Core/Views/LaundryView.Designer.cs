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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtdueDate = new System.Windows.Forms.DateTimePicker();
			this.dtrecieveDate = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtjoborder = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbservices = new System.Windows.Forms.ComboBox();
			this.Services = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.txtkilo = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtnoitems = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbcategory = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
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
			this.chk15discount = new System.Windows.Forms.CheckBox();
			this.chk10discount = new System.Windows.Forms.CheckBox();
			this.chksameday = new System.Windows.Forms.CheckBox();
			this.chk24rush = new System.Windows.Forms.CheckBox();
			this.chkdelivery = new System.Windows.Forms.CheckBox();
			this.chkpickup = new System.Windows.Forms.CheckBox();
			this.chkpaywhenclaim = new System.Windows.Forms.CheckBox();
			this.btnsaveprint = new System.Windows.Forms.Button();
			this.btncancel = new System.Windows.Forms.Button();
			this.btndelete = new System.Windows.Forms.Button();
			this.btnsave = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.btnCustomerSearch = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.Services.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnCustomerSearch);
			this.groupBox1.Controls.Add(this.dtdueDate);
			this.groupBox1.Controls.Add(this.dtrecieveDate);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtname);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtjoborder);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(21, 77);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(834, 93);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Transaction Information";
			// 
			// dtdueDate
			// 
			this.dtdueDate.Location = new System.Drawing.Point(610, 52);
			this.dtdueDate.Name = "dtdueDate";
			this.dtdueDate.Size = new System.Drawing.Size(200, 23);
			this.dtdueDate.TabIndex = 9;
			this.dtdueDate.Value = new System.DateTime(2013, 2, 2, 18, 46, 42, 0);
			// 
			// dtrecieveDate
			// 
			this.dtrecieveDate.Location = new System.Drawing.Point(610, 23);
			this.dtrecieveDate.Name = "dtrecieveDate";
			this.dtrecieveDate.Size = new System.Drawing.Size(200, 23);
			this.dtrecieveDate.TabIndex = 8;
			this.dtrecieveDate.Value = new System.DateTime(2013, 2, 2, 18, 46, 34, 0);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(500, 47);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Due Date:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(501, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Received Date:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtname
			// 
			this.txtname.Location = new System.Drawing.Point(143, 47);
			this.txtname.Name = "txtname";
			this.txtname.Size = new System.Drawing.Size(258, 23);
			this.txtname.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(28, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Customer Name: ";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtjoborder
			// 
			this.txtjoborder.Location = new System.Drawing.Point(143, 21);
			this.txtjoborder.Name = "txtjoborder";
			this.txtjoborder.Size = new System.Drawing.Size(258, 23);
			this.txtjoborder.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(33, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Job Order:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbservices
			// 
			this.cmbservices.FormattingEnabled = true;
			this.cmbservices.Location = new System.Drawing.Point(71, 27);
			this.cmbservices.Name = "cmbservices";
			this.cmbservices.Size = new System.Drawing.Size(190, 23);
			this.cmbservices.TabIndex = 2;
			// 
			// Services
			// 
			this.Services.Controls.Add(this.button1);
			this.Services.Controls.Add(this.txtkilo);
			this.Services.Controls.Add(this.label8);
			this.Services.Controls.Add(this.txtnoitems);
			this.Services.Controls.Add(this.label7);
			this.Services.Controls.Add(this.cmbcategory);
			this.Services.Controls.Add(this.label5);
			this.Services.Controls.Add(this.label6);
			this.Services.Controls.Add(this.cmbservices);
			this.Services.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Services.Location = new System.Drawing.Point(21, 182);
			this.Services.Name = "Services";
			this.Services.Size = new System.Drawing.Size(278, 187);
			this.Services.TabIndex = 3;
			this.Services.TabStop = false;
			this.Services.Text = "Services";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(186, 156);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// txtkilo
			// 
			this.txtkilo.Location = new System.Drawing.Point(71, 105);
			this.txtkilo.Name = "txtkilo";
			this.txtkilo.Size = new System.Drawing.Size(100, 23);
			this.txtkilo.TabIndex = 10;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(32, 108);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 23);
			this.label8.TabIndex = 9;
			this.label8.Text = "Kilos:";
			// 
			// txtnoitems
			// 
			this.txtnoitems.Location = new System.Drawing.Point(71, 79);
			this.txtnoitems.Name = "txtnoitems";
			this.txtnoitems.Size = new System.Drawing.Size(100, 23);
			this.txtnoitems.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(3, 82);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(71, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "# of Items:";
			// 
			// cmbcategory
			// 
			this.cmbcategory.FormattingEnabled = true;
			this.cmbcategory.Location = new System.Drawing.Point(71, 53);
			this.cmbcategory.Name = "cmbcategory";
			this.cmbcategory.Size = new System.Drawing.Size(190, 23);
			this.cmbcategory.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(9, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Services:";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(4, 52);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 23);
			this.label6.TabIndex = 3;
			this.label6.Text = "Category:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(317, 194);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(538, 197);
			this.dataGridView1.TabIndex = 4;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.groupBox2.Controls.Add(this.btnsearch);
			this.groupBox2.Controls.Add(this.txtsearch);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(21, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(831, 54);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Search";
			// 
			// btnsearch
			// 
			this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnsearch.FlatAppearance.BorderSize = 0;
			this.btnsearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnsearch.Location = new System.Drawing.Point(415, 18);
			this.btnsearch.Name = "btnsearch";
			this.btnsearch.Size = new System.Drawing.Size(24, 24);
			this.btnsearch.TabIndex = 4;
			this.btnsearch.UseVisualStyleBackColor = false;
			// 
			// txtsearch
			// 
			this.txtsearch.Location = new System.Drawing.Point(143, 22);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new System.Drawing.Size(258, 23);
			this.txtsearch.TabIndex = 3;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(33, 24);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 2;
			this.label9.Text = "Job Order:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtamtdue
			// 
			this.txtamtdue.Location = new System.Drawing.Point(736, 400);
			this.txtamtdue.Name = "txtamtdue";
			this.txtamtdue.Size = new System.Drawing.Size(119, 20);
			this.txtamtdue.TabIndex = 9;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Red;
			this.label10.Location = new System.Drawing.Point(646, 400);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(93, 18);
			this.label10.TabIndex = 8;
			this.label10.Text = "Amount Due:";
			// 
			// txtamttender
			// 
			this.txtamttender.Location = new System.Drawing.Point(736, 452);
			this.txtamttender.Name = "txtamttender";
			this.txtamttender.Size = new System.Drawing.Size(119, 20);
			this.txtamttender.TabIndex = 11;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label11.Location = new System.Drawing.Point(612, 452);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(124, 18);
			this.label11.TabIndex = 10;
			this.label11.Text = "Amount Tender:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtchange
			// 
			this.txtchange.Location = new System.Drawing.Point(736, 499);
			this.txtchange.Name = "txtchange";
			this.txtchange.Size = new System.Drawing.Size(119, 20);
			this.txtchange.TabIndex = 13;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label12.Location = new System.Drawing.Point(643, 499);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(93, 18);
			this.label12.TabIndex = 12;
			this.label12.Text = "Change:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.chk15discount);
			this.groupBox3.Controls.Add(this.chk10discount);
			this.groupBox3.Controls.Add(this.chksameday);
			this.groupBox3.Controls.Add(this.chk24rush);
			this.groupBox3.Controls.Add(this.chkdelivery);
			this.groupBox3.Controls.Add(this.chkpickup);
			this.groupBox3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.groupBox3.Location = new System.Drawing.Point(317, 400);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(319, 99);
			this.groupBox3.TabIndex = 14;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Additional Charges";
			// 
			// chk15discount
			// 
			this.chk15discount.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chk15discount.Location = new System.Drawing.Point(157, 64);
			this.chk15discount.Name = "chk15discount";
			this.chk15discount.Size = new System.Drawing.Size(127, 24);
			this.chk15discount.TabIndex = 17;
			this.chk15discount.Text = "15% Discount";
			this.chk15discount.UseVisualStyleBackColor = true;
			// 
			// chk10discount
			// 
			this.chk10discount.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chk10discount.Location = new System.Drawing.Point(157, 43);
			this.chk10discount.Name = "chk10discount";
			this.chk10discount.Size = new System.Drawing.Size(127, 24);
			this.chk10discount.TabIndex = 16;
			this.chk10discount.Text = "10% Discount";
			this.chk10discount.UseVisualStyleBackColor = true;
			// 
			// chksameday
			// 
			this.chksameday.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chksameday.Location = new System.Drawing.Point(157, 22);
			this.chksameday.Name = "chksameday";
			this.chksameday.Size = new System.Drawing.Size(127, 24);
			this.chksameday.TabIndex = 15;
			this.chksameday.Text = "Same Day Rush";
			this.chksameday.UseVisualStyleBackColor = true;
			// 
			// chk24rush
			// 
			this.chk24rush.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chk24rush.Location = new System.Drawing.Point(6, 64);
			this.chk24rush.Name = "chk24rush";
			this.chk24rush.Size = new System.Drawing.Size(148, 24);
			this.chk24rush.TabIndex = 2;
			this.chk24rush.Text = "24 Hour Rush Service";
			this.chk24rush.UseVisualStyleBackColor = true;
			// 
			// chkdelivery
			// 
			this.chkdelivery.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkdelivery.Location = new System.Drawing.Point(6, 43);
			this.chkdelivery.Name = "chkdelivery";
			this.chkdelivery.Size = new System.Drawing.Size(83, 24);
			this.chkdelivery.TabIndex = 1;
			this.chkdelivery.Text = "Delivery";
			this.chkdelivery.UseVisualStyleBackColor = true;
			// 
			// chkpickup
			// 
			this.chkpickup.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkpickup.Location = new System.Drawing.Point(6, 22);
			this.chkpickup.Name = "chkpickup";
			this.chkpickup.Size = new System.Drawing.Size(68, 24);
			this.chkpickup.TabIndex = 0;
			this.chkpickup.Text = "Pick Up";
			this.chkpickup.UseVisualStyleBackColor = true;
			// 
			// chkpaywhenclaim
			// 
			this.chkpaywhenclaim.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkpaywhenclaim.Location = new System.Drawing.Point(736, 424);
			this.chkpaywhenclaim.Name = "chkpaywhenclaim";
			this.chkpaywhenclaim.Size = new System.Drawing.Size(125, 24);
			this.chkpaywhenclaim.TabIndex = 15;
			this.chkpaywhenclaim.Text = "Pay when Claim";
			this.chkpaywhenclaim.UseVisualStyleBackColor = true;
			// 
			// btnsaveprint
			// 
			this.btnsaveprint.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsaveprint.Location = new System.Drawing.Point(18, 559);
			this.btnsaveprint.Name = "btnsaveprint";
			this.btnsaveprint.Size = new System.Drawing.Size(99, 23);
			this.btnsaveprint.TabIndex = 16;
			this.btnsaveprint.Text = "Save && Print";
			this.btnsaveprint.UseVisualStyleBackColor = true;
			// 
			// btncancel
			// 
			this.btncancel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncancel.Location = new System.Drawing.Point(646, 559);
			this.btncancel.Name = "btncancel";
			this.btncancel.Size = new System.Drawing.Size(99, 23);
			this.btncancel.TabIndex = 17;
			this.btncancel.Text = "Cancel";
			this.btncancel.UseVisualStyleBackColor = true;
			this.btncancel.Click += new System.EventHandler(this.BtncancelClick);
			// 
			// btndelete
			// 
			this.btndelete.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btndelete.Location = new System.Drawing.Point(764, 559);
			this.btndelete.Name = "btndelete";
			this.btndelete.Size = new System.Drawing.Size(91, 23);
			this.btndelete.TabIndex = 18;
			this.btndelete.Text = "Delete";
			this.btndelete.UseVisualStyleBackColor = true;
			// 
			// btnsave
			// 
			this.btnsave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsave.Location = new System.Drawing.Point(121, 559);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(99, 23);
			this.btnsave.TabIndex = 19;
			this.btnsave.Text = "Save";
			this.btnsave.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(736, 475);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(119, 20);
			this.textBox1.TabIndex = 21;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Maroon;
			this.label13.Location = new System.Drawing.Point(646, 475);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(90, 18);
			this.label13.TabIndex = 20;
			this.label13.Text = "Balance:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Blue;
			this.label14.Location = new System.Drawing.Point(54, 400);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(116, 23);
			this.label14.TabIndex = 22;
			this.label14.Text = "Add/Edit CheckList";
			// 
			// btnCustomerSearch
			// 
			this.btnCustomerSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnCustomerSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCustomerSearch.FlatAppearance.BorderSize = 0;
			this.btnCustomerSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnCustomerSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnCustomerSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCustomerSearch.Location = new System.Drawing.Point(417, 45);
			this.btnCustomerSearch.Name = "btnCustomerSearch";
			this.btnCustomerSearch.Size = new System.Drawing.Size(24, 24);
			this.btnCustomerSearch.TabIndex = 10;
			this.btnCustomerSearch.UseVisualStyleBackColor = false;
			// 
			// LaundryNewView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.ClientSize = new System.Drawing.Size(884, 612);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.btnsave);
			this.Controls.Add(this.btndelete);
			this.Controls.Add(this.btncancel);
			this.Controls.Add(this.btnsaveprint);
			this.Controls.Add(this.chkpaywhenclaim);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.txtchange);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtamttender);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtamtdue);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Services);
			this.Controls.Add(this.groupBox1);
			this.Name = "LaundryNewView";
			this.Text = "LaundryNewView";
			this.Load += new System.EventHandler(this.LaundryNewViewLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.Services.ResumeLayout(false);
			this.Services.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCustomerSearch;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnsave;
		private System.Windows.Forms.Button btndelete;
		private System.Windows.Forms.DateTimePicker dtrecieveDate;
		private System.Windows.Forms.DateTimePicker dtdueDate;
		private System.Windows.Forms.Button btncancel;
		private System.Windows.Forms.Button btnsaveprint;
		private System.Windows.Forms.CheckBox chkpaywhenclaim;
		private System.Windows.Forms.CheckBox chksameday;
		private System.Windows.Forms.CheckBox chk10discount;
		private System.Windows.Forms.CheckBox chk15discount;
		private System.Windows.Forms.CheckBox chkpickup;
		private System.Windows.Forms.CheckBox chkdelivery;
		private System.Windows.Forms.CheckBox chk24rush;
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
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbcategory;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox Services;
		private System.Windows.Forms.ComboBox cmbservices;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtjoborder;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtname;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}

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
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbservices = new System.Windows.Forms.ComboBox();
			this.Services = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cmbcategory = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox7 = new System.Windows.Forms.CheckBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.Services.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox4);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(21, 77);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(730, 93);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Transaction Information";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(424, 47);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(154, 23);
			this.textBox4.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(314, 44);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Due Date:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(424, 21);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(154, 23);
			this.textBox3.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(315, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Received Date:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(143, 47);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(154, 23);
			this.textBox2.TabIndex = 3;
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
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(143, 21);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(154, 23);
			this.textBox1.TabIndex = 1;
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
			this.cmbservices.Size = new System.Drawing.Size(158, 23);
			this.cmbservices.TabIndex = 2;
			// 
			// Services
			// 
			this.Services.Controls.Add(this.button1);
			this.Services.Controls.Add(this.textBox6);
			this.Services.Controls.Add(this.label8);
			this.Services.Controls.Add(this.textBox5);
			this.Services.Controls.Add(this.label7);
			this.Services.Controls.Add(this.cmbcategory);
			this.Services.Controls.Add(this.label5);
			this.Services.Controls.Add(this.label6);
			this.Services.Controls.Add(this.cmbservices);
			this.Services.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Services.Location = new System.Drawing.Point(21, 182);
			this.Services.Name = "Services";
			this.Services.Size = new System.Drawing.Size(256, 209);
			this.Services.TabIndex = 3;
			this.Services.TabStop = false;
			this.Services.Text = "Services";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(154, 160);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(71, 105);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(100, 23);
			this.textBox6.TabIndex = 10;
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
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(71, 79);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 23);
			this.textBox5.TabIndex = 7;
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
			this.cmbcategory.Size = new System.Drawing.Size(158, 23);
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
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.textBox7);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(21, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(727, 54);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Search";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(419, 21);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Search";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(143, 22);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(258, 23);
			this.textBox7.TabIndex = 3;
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
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(736, 400);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(119, 20);
			this.textBox8.TabIndex = 9;
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
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(736, 452);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(119, 20);
			this.textBox9.TabIndex = 11;
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
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(736, 478);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(119, 20);
			this.textBox10.TabIndex = 13;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label12.Location = new System.Drawing.Point(643, 478);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(93, 18);
			this.label12.TabIndex = 12;
			this.label12.Text = "Change:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.checkBox6);
			this.groupBox3.Controls.Add(this.checkBox5);
			this.groupBox3.Controls.Add(this.checkBox4);
			this.groupBox3.Controls.Add(this.checkBox3);
			this.groupBox3.Controls.Add(this.checkBox2);
			this.groupBox3.Controls.Add(this.checkBox1);
			this.groupBox3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.groupBox3.Location = new System.Drawing.Point(317, 400);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(319, 99);
			this.groupBox3.TabIndex = 14;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Additional Charges";
			// 
			// checkBox6
			// 
			this.checkBox6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox6.Location = new System.Drawing.Point(157, 64);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(127, 24);
			this.checkBox6.TabIndex = 17;
			this.checkBox6.Text = "15% Discount";
			this.checkBox6.UseVisualStyleBackColor = true;
			// 
			// checkBox5
			// 
			this.checkBox5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox5.Location = new System.Drawing.Point(157, 43);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(127, 24);
			this.checkBox5.TabIndex = 16;
			this.checkBox5.Text = "10% Discount";
			this.checkBox5.UseVisualStyleBackColor = true;
			// 
			// checkBox4
			// 
			this.checkBox4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox4.Location = new System.Drawing.Point(157, 22);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(127, 24);
			this.checkBox4.TabIndex = 15;
			this.checkBox4.Text = "Same Day Rush";
			this.checkBox4.UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			this.checkBox3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox3.Location = new System.Drawing.Point(6, 64);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(148, 24);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "24 Hour Rush Service";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox2.Location = new System.Drawing.Point(6, 43);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(83, 24);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Delivery";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			this.checkBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(6, 22);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(68, 24);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Pick Up";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox7
			// 
			this.checkBox7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox7.Location = new System.Drawing.Point(736, 424);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.Size = new System.Drawing.Size(125, 24);
			this.checkBox7.TabIndex = 15;
			this.checkBox7.Text = "Pay when Claim";
			this.checkBox7.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(687, 559);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 16;
			this.button3.Text = "Print";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(780, 559);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 17;
			this.button4.Text = "Cancel";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// LaundryNewView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ClientSize = new System.Drawing.Size(884, 612);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.checkBox7);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.textBox10);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.textBox9);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.textBox8);
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
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.CheckBox checkBox7;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.CheckBox checkBox6;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbcategory;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox Services;
		private System.Windows.Forms.ComboBox cmbservices;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}

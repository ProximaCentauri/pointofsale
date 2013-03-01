/*
 * Created by SharpDevelop.
 * User: vo185003
 * Date: 3/1/2013
 * Time: 3:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NJournals.Core.Views
{
	partial class CompanyInfoView
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
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtname = new System.Windows.Forms.TextBox();
			this.txtaddress = new System.Windows.Forms.TextBox();
			this.txtcontact = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label7 = new System.Windows.Forms.Label();
			this.rdbinactive = new System.Windows.Forms.RadioButton();
			this.rdbactive = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtmodel = new System.Windows.Forms.TextBox();
			this.txtprinter = new System.Windows.Forms.TextBox();
			this.btnclose = new System.Windows.Forms.Button();
			this.btnsave = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(24, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Contact Info:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(24, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Address:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(24, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Name:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtname
			// 
			this.txtname.Location = new System.Drawing.Point(130, 18);
			this.txtname.Name = "txtname";
			this.txtname.Size = new System.Drawing.Size(414, 22);
			this.txtname.TabIndex = 5;
			// 
			// txtaddress
			// 
			this.txtaddress.Location = new System.Drawing.Point(130, 52);
			this.txtaddress.Multiline = true;
			this.txtaddress.Name = "txtaddress";
			this.txtaddress.Size = new System.Drawing.Size(414, 43);
			this.txtaddress.TabIndex = 6;
			// 
			// txtcontact
			// 
			this.txtcontact.Location = new System.Drawing.Point(130, 106);
			this.txtcontact.Name = "txtcontact";
			this.txtcontact.Size = new System.Drawing.Size(414, 22);
			this.txtcontact.TabIndex = 7;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtcontact);
			this.groupBox1.Controls.Add(this.txtaddress);
			this.groupBox1.Controls.Add(this.txtname);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(672, 173);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Company Information";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(290, 21);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Current Printer";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.listBox1);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.rdbinactive);
			this.groupBox2.Controls.Add(this.rdbactive);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.txtmodel);
			this.groupBox2.Controls.Add(this.txtprinter);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(12, 222);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(672, 210);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Printer Settings";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 14;
			this.listBox1.Location = new System.Drawing.Point(24, 47);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(241, 144);
			this.listBox1.TabIndex = 15;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(24, 18);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 14;
			this.label7.Text = "Installed Printers";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// rdbinactive
			// 
			this.rdbinactive.Location = new System.Drawing.Point(396, 156);
			this.rdbinactive.Name = "rdbinactive";
			this.rdbinactive.Size = new System.Drawing.Size(104, 24);
			this.rdbinactive.TabIndex = 13;
			this.rdbinactive.Text = "In-active";
			this.rdbinactive.UseVisualStyleBackColor = true;
			// 
			// rdbactive
			// 
			this.rdbactive.Checked = true;
			this.rdbactive.Location = new System.Drawing.Point(319, 156);
			this.rdbactive.Name = "rdbactive";
			this.rdbactive.Size = new System.Drawing.Size(71, 24);
			this.rdbactive.TabIndex = 12;
			this.rdbactive.TabStop = true;
			this.rdbactive.Text = "Active";
			this.rdbactive.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(290, 130);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 11;
			this.label5.Text = "Printer Status";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(299, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 10;
			this.label1.Text = "Printer Model";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtmodel
			// 
			this.txtmodel.Location = new System.Drawing.Point(312, 105);
			this.txtmodel.Name = "txtmodel";
			this.txtmodel.Size = new System.Drawing.Size(232, 22);
			this.txtmodel.TabIndex = 9;
			// 
			// txtprinter
			// 
			this.txtprinter.Location = new System.Drawing.Point(312, 47);
			this.txtprinter.Name = "txtprinter";
			this.txtprinter.Size = new System.Drawing.Size(232, 22);
			this.txtprinter.TabIndex = 8;
			// 
			// btnclose
			// 
			this.btnclose.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnclose.Location = new System.Drawing.Point(481, 451);
			this.btnclose.Name = "btnclose";
			this.btnclose.Size = new System.Drawing.Size(75, 23);
			this.btnclose.TabIndex = 8;
			this.btnclose.Text = "Close";
			this.btnclose.UseVisualStyleBackColor = true;
			// 
			// btnsave
			// 
			this.btnsave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsave.Location = new System.Drawing.Point(387, 451);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(75, 23);
			this.btnsave.TabIndex = 9;
			this.btnsave.Text = "Save";
			this.btnsave.UseVisualStyleBackColor = true;
			// 
			// CompanyInfoView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.ClientSize = new System.Drawing.Size(696, 495);
			this.Controls.Add(this.btnsave);
			this.Controls.Add(this.btnclose);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "CompanyInfoView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CompanyInfoView";
			this.Load += new System.EventHandler(this.CompanyInfoViewLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TextBox txtmodel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton rdbactive;
		private System.Windows.Forms.RadioButton rdbinactive;
		private System.Windows.Forms.Button btnsave;
		private System.Windows.Forms.Button btnclose;
		private System.Windows.Forms.TextBox txtprinter;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtcontact;
		private System.Windows.Forms.TextBox txtaddress;
		private System.Windows.Forms.TextBox txtname;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
	}
}

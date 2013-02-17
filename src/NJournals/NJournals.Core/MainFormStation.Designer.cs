using System;
//using System.Design;
//using System.Windows.Forms;
//using NJournals.Core.MainFormStation;
//using NJournals.Core.MainFormStation;
//using NJournals.Core.MainFormStation;


/*
 * Created by SharpDevelop.
 * User: vo185003
 * Date: 1/25/2013
 * Time: 7:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NJournals.Core
{
	partial class MainFormStation
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblcustomerList = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.lbllaundryConfig = new System.Windows.Forms.Label();
			this.lbllaundryReports = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lbllaundryClaim = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblRefReports = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblRefClaim = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblRefNew = new System.Windows.Forms.Label();
			this.lstOpenWindows = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lbllaundryNew = new System.Windows.Forms.Label();
			this.lblRefConfig = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.lblcustomerList);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.lbllaundryConfig);
			this.panel1.Controls.Add(this.lbllaundryReports);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.lbllaundryClaim);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.lblRefReports);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.lblRefClaim);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.lblRefNew);
			this.panel1.Controls.Add(this.lstOpenWindows);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.lbllaundryNew);
			this.panel1.Controls.Add(this.lblRefConfig);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(196, 572);
			this.panel1.TabIndex = 2;
			// 
			// lblcustomerList
			// 
			this.lblcustomerList.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblcustomerList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblcustomerList.Location = new System.Drawing.Point(-1, 53);
			this.lblcustomerList.Name = "lblcustomerList";
			this.lblcustomerList.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.lblcustomerList.Size = new System.Drawing.Size(192, 32);
			this.lblcustomerList.TabIndex = 10;
			this.lblcustomerList.Text = "CUSTOMER LIST";
			this.lblcustomerList.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.lblcustomerList.MouseLeave += new System.EventHandler(this.label_mouseleave);
			this.lblcustomerList.MouseHover += new System.EventHandler(this.label_mousehover);
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label11.ForeColor = System.Drawing.Color.Red;
			this.label11.Location = new System.Drawing.Point(2, 487);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(191, 1);
			this.label11.TabIndex = 24;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label12.ForeColor = System.Drawing.Color.Red;
			this.label12.Location = new System.Drawing.Point(1, 448);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(191, 1);
			this.label12.TabIndex = 25;
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label10.ForeColor = System.Drawing.Color.Red;
			this.label10.Location = new System.Drawing.Point(2, 409);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(191, 1);
			this.label10.TabIndex = 24;
			// 
			// lbllaundryConfig
			// 
			this.lbllaundryConfig.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbllaundryConfig.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbllaundryConfig.Location = new System.Drawing.Point(0, 452);
			this.lbllaundryConfig.Name = "lbllaundryConfig";
			this.lbllaundryConfig.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.lbllaundryConfig.Size = new System.Drawing.Size(191, 32);
			this.lbllaundryConfig.TabIndex = 16;
			this.lbllaundryConfig.Text = "CONFIGURATION";
			this.lbllaundryConfig.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.lbllaundryConfig.MouseLeave += new System.EventHandler(this.label_mouseleave);
			this.lbllaundryConfig.MouseHover += new System.EventHandler(this.label_mousehover);
			// 
			// lbllaundryReports
			// 
			this.lbllaundryReports.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbllaundryReports.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbllaundryReports.Location = new System.Drawing.Point(1, 413);
			this.lbllaundryReports.Name = "lbllaundryReports";
			this.lbllaundryReports.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.lbllaundryReports.Size = new System.Drawing.Size(191, 32);
			this.lbllaundryReports.TabIndex = 15;
			this.lbllaundryReports.Text = "REPORTS";
			this.lbllaundryReports.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.lbllaundryReports.MouseLeave += new System.EventHandler(this.label_mouseleave);
			this.lbllaundryReports.MouseHover += new System.EventHandler(this.label_mousehover);
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label9.ForeColor = System.Drawing.Color.Red;
			this.label9.Location = new System.Drawing.Point(3, 370);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(191, 1);
			this.label9.TabIndex = 23;
			// 
			// lbllaundryClaim
			// 
			this.lbllaundryClaim.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbllaundryClaim.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbllaundryClaim.Location = new System.Drawing.Point(1, 374);
			this.lbllaundryClaim.Name = "lbllaundryClaim";
			this.lbllaundryClaim.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.lbllaundryClaim.Size = new System.Drawing.Size(191, 32);
			this.lbllaundryClaim.TabIndex = 14;
			this.lbllaundryClaim.Text = "CLAIM";
			this.lbllaundryClaim.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.lbllaundryClaim.MouseLeave += new System.EventHandler(this.label_mouseleave);
			this.lbllaundryClaim.MouseHover += new System.EventHandler(this.label_mousehover);
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label8.ForeColor = System.Drawing.Color.Red;
			this.label8.Location = new System.Drawing.Point(1, 279);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(191, 1);
			this.label8.TabIndex = 22;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(2, 240);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(191, 1);
			this.label5.TabIndex = 18;
			// 
			// lblRefReports
			// 
			this.lblRefReports.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblRefReports.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRefReports.Location = new System.Drawing.Point(1, 205);
			this.lblRefReports.Name = "lblRefReports";
			this.lblRefReports.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.lblRefReports.Size = new System.Drawing.Size(191, 32);
			this.lblRefReports.TabIndex = 11;
			this.lblRefReports.Text = "REPORTS";
			this.lblRefReports.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.lblRefReports.MouseLeave += new System.EventHandler(this.label_mouseleave);
			this.lblRefReports.MouseHover += new System.EventHandler(this.label_mousehover);
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label7.ForeColor = System.Drawing.Color.Red;
			this.label7.Location = new System.Drawing.Point(1, 201);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(191, 1);
			this.label7.TabIndex = 20;
			// 
			// lblRefClaim
			// 
			this.lblRefClaim.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblRefClaim.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRefClaim.Location = new System.Drawing.Point(1, 166);
			this.lblRefClaim.Margin = new System.Windows.Forms.Padding(1, 0, 3, 0);
			this.lblRefClaim.Name = "lblRefClaim";
			this.lblRefClaim.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.lblRefClaim.Size = new System.Drawing.Size(192, 32);
			this.lblRefClaim.TabIndex = 10;
			this.lblRefClaim.Text = "RETURN/PAYMENT";
			this.lblRefClaim.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.lblRefClaim.MouseLeave += new System.EventHandler(this.label_mouseleave);
			this.lblRefClaim.MouseHover += new System.EventHandler(this.label_mousehover);
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.label6.ForeColor = System.Drawing.Color.Red;
			this.label6.Location = new System.Drawing.Point(1, 162);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(191, 1);
			this.label6.TabIndex = 19;
			// 
			// label4
			// 
			this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(0, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(166, 23);
			this.label4.TabIndex = 17;
			this.label4.Text = "Company Logo HERE";
			// 
			// lblRefNew
			// 
			this.lblRefNew.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblRefNew.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRefNew.Location = new System.Drawing.Point(1, 127);
			this.lblRefNew.Name = "lblRefNew";
			this.lblRefNew.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.lblRefNew.Size = new System.Drawing.Size(192, 32);
			this.lblRefNew.TabIndex = 9;
			this.lblRefNew.Text = "NEW";
			this.lblRefNew.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.lblRefNew.MouseLeave += new System.EventHandler(this.label_mouseleave);
			this.lblRefNew.MouseHover += new System.EventHandler(this.label_mousehover);
			// 
			// lstOpenWindows
			// 
			this.lstOpenWindows.BackColor = System.Drawing.SystemColors.Control;
			this.lstOpenWindows.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lstOpenWindows.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lstOpenWindows.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstOpenWindows.FormattingEnabled = true;
			this.lstOpenWindows.ItemHeight = 14;
			this.lstOpenWindows.Location = new System.Drawing.Point(0, 414);
			this.lstOpenWindows.Name = "lstOpenWindows";
			this.lstOpenWindows.Size = new System.Drawing.Size(192, 154);
			this.lstOpenWindows.TabIndex = 0;
			this.lstOpenWindows.SelectedIndexChanged += new System.EventHandler(this.lstOpenWindows_SelectedIndexChange);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
			this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(-2, 510);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(196, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Open window(s)";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbllaundryNew
			// 
			this.lbllaundryNew.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbllaundryNew.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbllaundryNew.Location = new System.Drawing.Point(1, 335);
			this.lbllaundryNew.Name = "lbllaundryNew";
			this.lbllaundryNew.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.lbllaundryNew.Size = new System.Drawing.Size(191, 32);
			this.lbllaundryNew.TabIndex = 13;
			this.lbllaundryNew.Text = "NEW";
			this.lbllaundryNew.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.lbllaundryNew.MouseLeave += new System.EventHandler(this.label_mouseleave);
			this.lbllaundryNew.MouseHover += new System.EventHandler(this.label_mousehover);
			// 
			// lblRefConfig
			// 
			this.lblRefConfig.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblRefConfig.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRefConfig.Location = new System.Drawing.Point(1, 244);
			this.lblRefConfig.Name = "lblRefConfig";
			this.lblRefConfig.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
			this.lblRefConfig.Size = new System.Drawing.Size(191, 32);
			this.lblRefConfig.TabIndex = 12;
			this.lblRefConfig.Text = "CONFIGURATION";
			this.lblRefConfig.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.lblRefConfig.MouseLeave += new System.EventHandler(this.label_mouseleave);
			this.lblRefConfig.MouseHover += new System.EventHandler(this.label_mousehover);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(147)))), ((int)(((byte)(152)))));
			this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(-2, 299);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(200, 33);
			this.label2.TabIndex = 3;
			this.label2.Text = "LAUNDRY";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(147)))), ((int)(((byte)(152)))));
			this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(-2, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(198, 33);
			this.label1.TabIndex = 2;
			this.label1.Text = "REFILLING";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MainFormStation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(997, 572);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.IsMdiContainer = true;
			this.Name = "MainFormStation";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainFormStation";
			this.Load += new System.EventHandler(this.MainFormStationLoad);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblcustomerList;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblRefNew;
		private System.Windows.Forms.Label lblRefClaim;
		private System.Windows.Forms.Label lblRefReports;
		private System.Windows.Forms.Label lblRefConfig;
		private System.Windows.Forms.Label lbllaundryNew;
		private System.Windows.Forms.Label lbllaundryClaim;
		private System.Windows.Forms.Label lbllaundryReports;
		private System.Windows.Forms.Label lbllaundryConfig;
		private System.Windows.Forms.ListBox lstOpenWindows;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		
		
		
		
		
		
	}
}

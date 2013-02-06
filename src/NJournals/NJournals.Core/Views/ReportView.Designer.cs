/*
 * Created by SharpDevelop.
 * User: vo185003
 * Date: 1/25/2013
 * Time: 9:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NJournals.Core.Views
{
	partial class ReportView
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
            this.btnLaundryRunReport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLaundryReportTypes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.laundryReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LaundryDateFromPicker = new System.Windows.Forms.DateTimePicker();
            this.LaundryDateToPicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLaundryCustomer = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbLaundryCustomer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LaundryDateToPicker);
            this.groupBox1.Controls.Add(this.LaundryDateFromPicker);
            this.groupBox1.Controls.Add(this.btnLaundryRunReport);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbLaundryReportTypes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(86, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Information";
            // 
            // btnLaundryRunReport
            // 
            this.btnLaundryRunReport.Location = new System.Drawing.Point(277, 146);
            this.btnLaundryRunReport.Name = "btnLaundryRunReport";
            this.btnLaundryRunReport.Size = new System.Drawing.Size(75, 23);
            this.btnLaundryRunReport.TabIndex = 6;
            this.btnLaundryRunReport.Text = "Run Report";
            this.btnLaundryRunReport.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "To:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "From:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbLaundryReportTypes
            // 
            this.cmbLaundryReportTypes.FormattingEnabled = true;
            this.cmbLaundryReportTypes.Location = new System.Drawing.Point(131, 17);
            this.cmbLaundryReportTypes.Name = "cmbLaundryReportTypes";
            this.cmbLaundryReportTypes.Size = new System.Drawing.Size(199, 23);
            this.cmbLaundryReportTypes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report Type:";
            // 
            // laundryReportViewer
            // 
            this.laundryReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.laundryReportViewer.Location = new System.Drawing.Point(37, 212);
            this.laundryReportViewer.Name = "laundryReportViewer";
            this.laundryReportViewer.Size = new System.Drawing.Size(820, 316);
            this.laundryReportViewer.TabIndex = 1;
            // 
            // LaundryDateFromPicker
            // 
            this.LaundryDateFromPicker.Location = new System.Drawing.Point(130, 81);
            this.LaundryDateFromPicker.Name = "LaundryDateFromPicker";
            this.LaundryDateFromPicker.Size = new System.Drawing.Size(200, 23);
            this.LaundryDateFromPicker.TabIndex = 7;
            // 
            // LaundryDateToPicker
            // 
            this.LaundryDateToPicker.Location = new System.Drawing.Point(130, 114);
            this.LaundryDateToPicker.Name = "LaundryDateToPicker";
            this.LaundryDateToPicker.Size = new System.Drawing.Size(200, 23);
            this.LaundryDateToPicker.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Customer:";
            // 
            // cmbLaundryCustomer
            // 
            this.cmbLaundryCustomer.FormattingEnabled = true;
            this.cmbLaundryCustomer.Location = new System.Drawing.Point(131, 48);
            this.cmbLaundryCustomer.Name = "cmbLaundryCustomer";
            this.cmbLaundryCustomer.Size = new System.Drawing.Size(199, 23);
            this.cmbLaundryCustomer.TabIndex = 10;
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(892, 566);
            this.Controls.Add(this.laundryReportViewer);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReportView";
            this.Text = "ReportView";
            this.Load += new System.EventHandler(this.ReportView_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbLaundryReportTypes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnLaundryRunReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer laundryReportViewer;
        private System.Windows.Forms.ComboBox cmbLaundryCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker LaundryDateToPicker;
        private System.Windows.Forms.DateTimePicker LaundryDateFromPicker;
	}
}

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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateToPicker = new System.Windows.Forms.DateTimePicker();
            this.dateFromPicker = new System.Windows.Forms.DateTimePicker();
            this.btnRunReport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbReportTypes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LaundryDaySummaryDataEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LaundryDaySummaryDataEntityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCustomers);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateToPicker);
            this.groupBox1.Controls.Add(this.dateFromPicker);
            this.groupBox1.Controls.Add(this.btnRunReport);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbReportTypes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(86, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Information";
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCustomers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(131, 48);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(199, 23);
            this.cmbCustomers.TabIndex = 10;
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
            // dateToPicker
            // 
            this.dateToPicker.Location = new System.Drawing.Point(130, 114);
            this.dateToPicker.Name = "dateToPicker";
            this.dateToPicker.Size = new System.Drawing.Size(200, 23);
            this.dateToPicker.TabIndex = 8;
            // 
            // dateFromPicker
            // 
            this.dateFromPicker.CustomFormat = "mm/dd/yyyy hh:mm:ss";
            this.dateFromPicker.Location = new System.Drawing.Point(130, 81);
            this.dateFromPicker.Name = "dateFromPicker";
            this.dateFromPicker.Size = new System.Drawing.Size(200, 23);
            this.dateFromPicker.TabIndex = 7;
            // 
            // btnRunReport
            // 
            this.btnRunReport.Location = new System.Drawing.Point(277, 161);
            this.btnRunReport.Name = "btnRunReport";
            this.btnRunReport.Size = new System.Drawing.Size(75, 23);
            this.btnRunReport.TabIndex = 6;
            this.btnRunReport.Text = "Run Report";
            this.btnRunReport.UseVisualStyleBackColor = true;
            this.btnRunReport.Click += new System.EventHandler(this.BtnRunReportClick);
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
            // cmbReportTypes
            // 
            this.cmbReportTypes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbReportTypes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbReportTypes.FormattingEnabled = true;
            this.cmbReportTypes.Location = new System.Drawing.Point(131, 17);
            this.cmbReportTypes.Name = "cmbReportTypes";
            this.cmbReportTypes.Size = new System.Drawing.Size(199, 23);
            this.cmbReportTypes.TabIndex = 1;
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
            // LaundryDaySummaryDataEntityBindingSource
            // 
            this.LaundryDaySummaryDataEntityBindingSource.DataSource = typeof(NJournals.Common.DataEntities.LaundryHeaderDataEntity);
            // 
            // reportViewer
            // 
            this.reportViewer.AutoScroll = true;
            this.reportViewer.Location = new System.Drawing.Point(38, 245);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(818, 297);
            this.reportViewer.TabIndex = 1;
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(892, 566);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReportView";
            this.Text = "ReportView";
            this.Load += new System.EventHandler(this.ReportView_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LaundryDaySummaryDataEntityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rptBindingSource)).EndInit();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbReportTypes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnRunReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateToPicker;
        private System.Windows.Forms.DateTimePicker dateFromPicker;
        private System.Windows.Forms.BindingSource LaundryDaySummaryDataEntityBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource rptBindingSource;
	}
}

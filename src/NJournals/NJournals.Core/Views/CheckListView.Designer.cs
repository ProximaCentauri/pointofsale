/*
 * Created by SharpDevelop.
 * User: vo185003
 * Date: 2/4/2013
 * Time: 9:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NJournals.Core.Views
{
	partial class CheckListView
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnsave = new System.Windows.Forms.Button();
			this.btnsaveprint = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txttotal = new System.Windows.Forms.TextBox();
			this.btncancel = new System.Windows.Forms.Button();
			this.dgvCheckList = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvCheckList)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(89, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(154, 20);
			this.textBox1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Job Order:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnsave
			// 
			this.btnsave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsave.Location = new System.Drawing.Point(126, 505);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(58, 23);
			this.btnsave.TabIndex = 21;
			this.btnsave.Text = "Save";
			this.btnsave.UseVisualStyleBackColor = true;
			this.btnsave.Click += new System.EventHandler(this.BtnsaveClick);
			// 
			// btnsaveprint
			// 
			this.btnsaveprint.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsaveprint.Location = new System.Drawing.Point(16, 505);
			this.btnsaveprint.Name = "btnsaveprint";
			this.btnsaveprint.Size = new System.Drawing.Size(99, 23);
			this.btnsaveprint.TabIndex = 20;
			this.btnsaveprint.Text = "Save && Print";
			this.btnsaveprint.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label2.Location = new System.Drawing.Point(3, 429);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 23);
			this.label2.TabIndex = 22;
			this.label2.Text = "Total Items:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txttotal
			// 
			this.txttotal.Location = new System.Drawing.Point(77, 429);
			this.txttotal.Name = "txttotal";
			this.txttotal.Size = new System.Drawing.Size(66, 20);
			this.txttotal.TabIndex = 23;
			// 
			// btncancel
			// 
			this.btncancel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncancel.Location = new System.Drawing.Point(194, 505);
			this.btncancel.Name = "btncancel";
			this.btncancel.Size = new System.Drawing.Size(58, 23);
			this.btncancel.TabIndex = 24;
			this.btncancel.Text = "Cancel";
			this.btncancel.UseVisualStyleBackColor = true;
			// 
			// dgvCheckList
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCheckList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvCheckList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCheckList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1,
									this.Column2,
									this.Column3});
			this.dgvCheckList.Location = new System.Drawing.Point(12, 61);
			this.dgvCheckList.Name = "dgvCheckList";
			this.dgvCheckList.Size = new System.Drawing.Size(240, 341);
			this.dgvCheckList.TabIndex = 25;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "";
			this.Column1.Name = "Column1";
			this.Column1.Width = 25;
			// 
			// Column2
			// 
			this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
			this.Column2.HeaderText = "Item Name";
			this.Column2.Name = "Column2";
			this.Column2.Width = 120;
			// 
			// Column3
			// 
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
			this.Column3.HeaderText = "Item #";
			this.Column3.Name = "Column3";
			this.Column3.Width = 50;
			// 
			// CheckListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.ClientSize = new System.Drawing.Size(264, 567);
			this.Controls.Add(this.dgvCheckList);
			this.Controls.Add(this.btncancel);
			this.Controls.Add(this.txttotal);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnsave);
			this.Controls.Add(this.btnsaveprint);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "CheckListView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "CheckListView";
			this.Load += new System.EventHandler(this.CheckListViewLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvCheckList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
		private System.Windows.Forms.DataGridView dgvCheckList;
		private System.Windows.Forms.Button btncancel;
		private System.Windows.Forms.TextBox txttotal;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnsaveprint;
		private System.Windows.Forms.Button btnsave;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
	}
}

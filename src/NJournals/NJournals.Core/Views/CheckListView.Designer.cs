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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.txtjonumber = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnok = new System.Windows.Forms.Button();
			this.btnokprint = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txttotal = new System.Windows.Forms.TextBox();
			this.dgvCheckList = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnDeleteCheckList = new System.Windows.Forms.Button();
			this.btnSaveCheckList = new System.Windows.Forms.Button();
			this.btncancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvCheckList)).BeginInit();
			this.SuspendLayout();
			// 
			// txtjonumber
			// 
			this.txtjonumber.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txtjonumber.Enabled = false;
			this.txtjonumber.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtjonumber.Location = new System.Drawing.Point(89, 24);
			this.txtjonumber.Name = "txtjonumber";
			this.txtjonumber.Size = new System.Drawing.Size(154, 24);
			this.txtjonumber.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Job Order:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnok
			// 
			this.btnok.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnok.Location = new System.Drawing.Point(123, 561);
			this.btnok.Name = "btnok";
			this.btnok.Size = new System.Drawing.Size(83, 23);
			this.btnok.TabIndex = 21;
			this.btnok.Text = "OK";
			this.btnok.UseVisualStyleBackColor = true;
			// 
			// btnokprint
			// 
			this.btnokprint.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnokprint.Location = new System.Drawing.Point(7, 561);
			this.btnokprint.Name = "btnokprint";
			this.btnokprint.Size = new System.Drawing.Size(99, 23);
			this.btnokprint.TabIndex = 20;
			this.btnokprint.Text = "OK && Print";
			this.btnokprint.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label2.Location = new System.Drawing.Point(125, 501);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 23);
			this.label2.TabIndex = 22;
			this.label2.Text = "Total Items:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txttotal
			// 
			this.txttotal.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttotal.Location = new System.Drawing.Point(222, 501);
			this.txttotal.Name = "txttotal";
			this.txttotal.Size = new System.Drawing.Size(66, 24);
			this.txttotal.TabIndex = 23;
			this.txttotal.Text = "0";
			// 
			// dgvCheckList
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvCheckList.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvCheckList.Size = new System.Drawing.Size(276, 423);
			this.dgvCheckList.TabIndex = 25;
			this.dgvCheckList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvchecklist_cellclick);
			this.dgvCheckList.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvChecklist_cellvalidating);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "";
			this.Column1.Name = "Column1";
			this.Column1.Width = 25;
			// 
			// Column2
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
			this.Column2.HeaderText = "Item Name";
			this.Column2.Name = "Column2";
			this.Column2.Width = 130;
			// 
			// Column3
			// 
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
			this.Column3.HeaderText = "Item #";
			this.Column3.Name = "Column3";
			this.Column3.Width = 78;
			// 
			// btnDeleteCheckList
			// 
			this.btnDeleteCheckList.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDeleteCheckList.FlatAppearance.BorderSize = 0;
			this.btnDeleteCheckList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnDeleteCheckList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnDeleteCheckList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteCheckList.Location = new System.Drawing.Point(294, 147);
			this.btnDeleteCheckList.Name = "btnDeleteCheckList";
			this.btnDeleteCheckList.Size = new System.Drawing.Size(35, 23);
			this.btnDeleteCheckList.TabIndex = 27;
			this.btnDeleteCheckList.UseVisualStyleBackColor = true;
			// 
			// btnSaveCheckList
			// 
			this.btnSaveCheckList.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSaveCheckList.FlatAppearance.BorderSize = 0;
			this.btnSaveCheckList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnSaveCheckList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnSaveCheckList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveCheckList.Location = new System.Drawing.Point(294, 118);
			this.btnSaveCheckList.Name = "btnSaveCheckList";
			this.btnSaveCheckList.Size = new System.Drawing.Size(35, 23);
			this.btnSaveCheckList.TabIndex = 26;
			this.btnSaveCheckList.UseVisualStyleBackColor = true;
			// 
			// btncancel
			// 
			this.btncancel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncancel.Location = new System.Drawing.Point(212, 561);
			this.btncancel.Name = "btncancel";
			this.btncancel.Size = new System.Drawing.Size(83, 23);
			this.btncancel.TabIndex = 28;
			this.btncancel.Text = "Cancel";
			this.btncancel.UseVisualStyleBackColor = true;
			this.btncancel.Click += new System.EventHandler(this.BtncancelClick);
			// 
			// CheckListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.ClientSize = new System.Drawing.Size(341, 612);
			this.Controls.Add(this.btncancel);
			this.Controls.Add(this.btnDeleteCheckList);
			this.Controls.Add(this.btnSaveCheckList);
			this.Controls.Add(this.dgvCheckList);
			this.Controls.Add(this.txttotal);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnok);
			this.Controls.Add(this.btnokprint);
			this.Controls.Add(this.txtjonumber);
			this.Controls.Add(this.label1);
			this.Name = "CheckListView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "CheckListView";
			this.Load += new System.EventHandler(this.CheckListViewLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvCheckList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btncancel;
		private System.Windows.Forms.Button btnSaveCheckList;
		private System.Windows.Forms.Button btnDeleteCheckList;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
		private System.Windows.Forms.DataGridView dgvCheckList;
		private System.Windows.Forms.TextBox txttotal;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnokprint;
		private System.Windows.Forms.Button btnok;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtjonumber;
	}
}

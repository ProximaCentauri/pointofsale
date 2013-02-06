/*
 * Created by SharpDevelop.
 * User: user
 * Date: 1/31/2013
 * Time: 12:10 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace NJournals.Core.Views
{
	partial class LaundryConfigurationView
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvPriceScheme = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dgvCategory = new System.Windows.Forms.DataGridView();
			this.btnAddPriceScheme = new System.Windows.Forms.Button();
			this.btnEditPriceScheme = new System.Windows.Forms.Button();
			this.btnDeletePriceScheme = new System.Windows.Forms.Button();
			this.btnDeleteServices = new System.Windows.Forms.Button();
			this.btnEditServices = new System.Windows.Forms.Button();
			this.btnAddServices = new System.Windows.Forms.Button();
			this.btnDeleteCategory = new System.Windows.Forms.Button();
			this.btnEditCategory = new System.Windows.Forms.Button();
			this.btnAddCategory = new System.Windows.Forms.Button();
			this.dgvServices = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvPriceScheme)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(168)))), ((int)(((byte)(188)))));
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(25, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(789, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Price Scheme";
			// 
			// dgvPriceScheme
			// 
			this.dgvPriceScheme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPriceScheme.Location = new System.Drawing.Point(25, 45);
			this.dgvPriceScheme.Name = "dgvPriceScheme";
			this.dgvPriceScheme.Size = new System.Drawing.Size(789, 149);
			this.dgvPriceScheme.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(168)))), ((int)(((byte)(188)))));
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(25, 203);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(789, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Services";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(168)))), ((int)(((byte)(188)))));
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(25, 393);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(789, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Category";
			// 
			// dgvCategory
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn1,
									this.dataGridViewTextBoxColumn2});
			this.dgvCategory.Location = new System.Drawing.Point(25, 419);
			this.dgvCategory.Name = "dgvCategory";
			this.dgvCategory.Size = new System.Drawing.Size(789, 131);
			this.dgvCategory.TabIndex = 5;
			// 
			// btnAddPriceScheme
			// 
			this.btnAddPriceScheme.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddPriceScheme.FlatAppearance.BorderSize = 0;
			this.btnAddPriceScheme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnAddPriceScheme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnAddPriceScheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddPriceScheme.Location = new System.Drawing.Point(820, 64);
			this.btnAddPriceScheme.Name = "btnAddPriceScheme";
			this.btnAddPriceScheme.Size = new System.Drawing.Size(35, 23);
			this.btnAddPriceScheme.TabIndex = 6;
			this.btnAddPriceScheme.UseVisualStyleBackColor = true;
			// 
			// btnEditPriceScheme
			// 
			this.btnEditPriceScheme.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditPriceScheme.FlatAppearance.BorderSize = 0;
			this.btnEditPriceScheme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnEditPriceScheme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnEditPriceScheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditPriceScheme.Location = new System.Drawing.Point(820, 93);
			this.btnEditPriceScheme.Name = "btnEditPriceScheme";
			this.btnEditPriceScheme.Size = new System.Drawing.Size(35, 23);
			this.btnEditPriceScheme.TabIndex = 7;
			this.btnEditPriceScheme.UseVisualStyleBackColor = true;
			// 
			// btnDeletePriceScheme
			// 
			this.btnDeletePriceScheme.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDeletePriceScheme.FlatAppearance.BorderSize = 0;
			this.btnDeletePriceScheme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnDeletePriceScheme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnDeletePriceScheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeletePriceScheme.Location = new System.Drawing.Point(820, 122);
			this.btnDeletePriceScheme.Name = "btnDeletePriceScheme";
			this.btnDeletePriceScheme.Size = new System.Drawing.Size(35, 23);
			this.btnDeletePriceScheme.TabIndex = 8;
			this.btnDeletePriceScheme.UseVisualStyleBackColor = true;
			// 
			// btnDeleteServices
			// 
			this.btnDeleteServices.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDeleteServices.FlatAppearance.BorderSize = 0;
			this.btnDeleteServices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnDeleteServices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnDeleteServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteServices.Location = new System.Drawing.Point(820, 304);
			this.btnDeleteServices.Name = "btnDeleteServices";
			this.btnDeleteServices.Size = new System.Drawing.Size(35, 23);
			this.btnDeleteServices.TabIndex = 11;
			this.btnDeleteServices.UseVisualStyleBackColor = true;
			// 
			// btnEditServices
			// 
			this.btnEditServices.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditServices.FlatAppearance.BorderSize = 0;
			this.btnEditServices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnEditServices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnEditServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditServices.Location = new System.Drawing.Point(820, 275);
			this.btnEditServices.Name = "btnEditServices";
			this.btnEditServices.Size = new System.Drawing.Size(35, 23);
			this.btnEditServices.TabIndex = 10;
			this.btnEditServices.UseVisualStyleBackColor = true;
			// 
			// btnAddServices
			// 
			this.btnAddServices.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddServices.FlatAppearance.BorderSize = 0;
			this.btnAddServices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnAddServices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnAddServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddServices.Location = new System.Drawing.Point(820, 246);
			this.btnAddServices.Name = "btnAddServices";
			this.btnAddServices.Size = new System.Drawing.Size(35, 23);
			this.btnAddServices.TabIndex = 9;
			this.btnAddServices.UseVisualStyleBackColor = true;
			// 
			// btnDeleteCategory
			// 
			this.btnDeleteCategory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDeleteCategory.FlatAppearance.BorderSize = 0;
			this.btnDeleteCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnDeleteCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteCategory.Location = new System.Drawing.Point(820, 489);
			this.btnDeleteCategory.Name = "btnDeleteCategory";
			this.btnDeleteCategory.Size = new System.Drawing.Size(35, 23);
			this.btnDeleteCategory.TabIndex = 14;
			this.btnDeleteCategory.UseVisualStyleBackColor = true;
			// 
			// btnEditCategory
			// 
			this.btnEditCategory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditCategory.FlatAppearance.BorderSize = 0;
			this.btnEditCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnEditCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnEditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditCategory.Location = new System.Drawing.Point(820, 460);
			this.btnEditCategory.Name = "btnEditCategory";
			this.btnEditCategory.Size = new System.Drawing.Size(35, 23);
			this.btnEditCategory.TabIndex = 13;
			this.btnEditCategory.UseVisualStyleBackColor = true;
			// 
			// btnAddCategory
			// 
			this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddCategory.FlatAppearance.BorderSize = 0;
			this.btnAddCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnAddCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddCategory.Location = new System.Drawing.Point(820, 431);
			this.btnAddCategory.Name = "btnAddCategory";
			this.btnAddCategory.Size = new System.Drawing.Size(35, 23);
			this.btnAddCategory.TabIndex = 12;
			this.btnAddCategory.UseVisualStyleBackColor = true;
			// 
			// dgvServices
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn3,
									this.dataGridViewTextBoxColumn4});
			this.dgvServices.Location = new System.Drawing.Point(25, 229);
			this.dgvServices.Name = "dgvServices";
			this.dgvServices.Size = new System.Drawing.Size(789, 151);
			this.dgvServices.TabIndex = 15;
			// 
			// dataGridViewTextBoxColumn3
			// 
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewTextBoxColumn3.HeaderText = "Service Name";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Width = 300;
			// 
			// dataGridViewTextBoxColumn4
			// 
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridViewTextBoxColumn4.HeaderText = "Service Description";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.Width = 450;
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewTextBoxColumn1.HeaderText = "Category Name";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Width = 300;
			// 
			// dataGridViewTextBoxColumn2
			// 
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewTextBoxColumn2.HeaderText = "Category Description";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Width = 450;
			// 
			// LaundryConfigurationView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.ClientSize = new System.Drawing.Size(884, 562);
			this.Controls.Add(this.dgvServices);
			this.Controls.Add(this.btnDeleteCategory);
			this.Controls.Add(this.btnEditCategory);
			this.Controls.Add(this.btnAddCategory);
			this.Controls.Add(this.btnDeleteServices);
			this.Controls.Add(this.btnEditServices);
			this.Controls.Add(this.btnAddServices);
			this.Controls.Add(this.btnDeletePriceScheme);
			this.Controls.Add(this.btnEditPriceScheme);
			this.Controls.Add(this.btnAddPriceScheme);
			this.Controls.Add(this.dgvCategory);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dgvPriceScheme);
			this.Controls.Add(this.label1);
			this.Name = "LaundryConfigurationView";
			this.Text = "LaundryConfigurationView";
			this.Load += new System.EventHandler(this.LaundryConfigurationFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvPriceScheme)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridView dgvServices;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.Button btnAddCategory;
		private System.Windows.Forms.Button btnEditCategory;
		private System.Windows.Forms.Button btnDeleteCategory;
		private System.Windows.Forms.Button btnAddServices;
		private System.Windows.Forms.Button btnEditServices;
		private System.Windows.Forms.Button btnDeleteServices;
		private System.Windows.Forms.Button btnDeletePriceScheme;
		private System.Windows.Forms.Button btnEditPriceScheme;
		private System.Windows.Forms.Button btnAddPriceScheme;
		private System.Windows.Forms.DataGridView dgvCategory;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvPriceScheme;
		private System.Windows.Forms.Label label1;
		
		

	}
}

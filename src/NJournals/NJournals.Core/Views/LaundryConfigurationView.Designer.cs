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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvPriceScheme = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dgvCategory = new System.Windows.Forms.DataGridView();
			this.btnAddPriceScheme = new System.Windows.Forms.Button();
			this.btnSavePriceScheme = new System.Windows.Forms.Button();
			this.btnDeletePriceScheme = new System.Windows.Forms.Button();
			this.btnDeleteServices = new System.Windows.Forms.Button();
			this.btnSaveServices = new System.Windows.Forms.Button();
			this.btnDeleteCategory = new System.Windows.Forms.Button();
			this.btnSaveCategory = new System.Windows.Forms.Button();
			this.dgvServices = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvPriceScheme)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(25, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(789, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Price Scheme";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dgvPriceScheme
			// 
			this.dgvPriceScheme.AllowUserToAddRows = false;
			this.dgvPriceScheme.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPriceScheme.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvPriceScheme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPriceScheme.Cursor = System.Windows.Forms.Cursors.Default;
			this.dgvPriceScheme.Location = new System.Drawing.Point(25, 45);
			this.dgvPriceScheme.Name = "dgvPriceScheme";
			this.dgvPriceScheme.Size = new System.Drawing.Size(789, 220);
			this.dgvPriceScheme.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(25, 279);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(789, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Services";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(25, 468);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(789, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Category";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dgvCategory
			// 
			this.dgvCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCategory.Location = new System.Drawing.Point(25, 494);
			this.dgvCategory.Name = "dgvCategory";
			this.dgvCategory.Size = new System.Drawing.Size(789, 186);
			this.dgvCategory.TabIndex = 5;
			this.dgvCategory.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellValueChanged);
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
			this.btnAddPriceScheme.Click += new System.EventHandler(this.BtnAddPriceSchemeClick);
			// 
			// btnSavePriceScheme
			// 
			this.btnSavePriceScheme.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSavePriceScheme.FlatAppearance.BorderSize = 0;
			this.btnSavePriceScheme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnSavePriceScheme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnSavePriceScheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSavePriceScheme.Location = new System.Drawing.Point(820, 93);
			this.btnSavePriceScheme.Name = "btnSavePriceScheme";
			this.btnSavePriceScheme.Size = new System.Drawing.Size(35, 23);
			this.btnSavePriceScheme.TabIndex = 7;
			this.btnSavePriceScheme.UseVisualStyleBackColor = true;
			this.btnSavePriceScheme.Click += new System.EventHandler(this.BtnSavePriceSchemeClick);
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
			this.btnDeletePriceScheme.Click += new System.EventHandler(this.BtnDeletePriceSchemeClick);
			// 
			// btnDeleteServices
			// 
			this.btnDeleteServices.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDeleteServices.FlatAppearance.BorderSize = 0;
			this.btnDeleteServices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnDeleteServices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnDeleteServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteServices.Location = new System.Drawing.Point(820, 338);
			this.btnDeleteServices.Name = "btnDeleteServices";
			this.btnDeleteServices.Size = new System.Drawing.Size(35, 23);
			this.btnDeleteServices.TabIndex = 11;
			this.btnDeleteServices.UseVisualStyleBackColor = true;
			this.btnDeleteServices.Click += new System.EventHandler(this.BtnDeleteServicesClick);
			// 
			// btnSaveServices
			// 
			this.btnSaveServices.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSaveServices.FlatAppearance.BorderSize = 0;
			this.btnSaveServices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnSaveServices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnSaveServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveServices.Location = new System.Drawing.Point(820, 309);
			this.btnSaveServices.Name = "btnSaveServices";
			this.btnSaveServices.Size = new System.Drawing.Size(35, 23);
			this.btnSaveServices.TabIndex = 10;
			this.btnSaveServices.UseVisualStyleBackColor = true;
			this.btnSaveServices.Click += new System.EventHandler(this.BtnSaveServicesClick);
			// 
			// btnDeleteCategory
			// 
			this.btnDeleteCategory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDeleteCategory.FlatAppearance.BorderSize = 0;
			this.btnDeleteCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnDeleteCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteCategory.Location = new System.Drawing.Point(820, 528);
			this.btnDeleteCategory.Name = "btnDeleteCategory";
			this.btnDeleteCategory.Size = new System.Drawing.Size(35, 23);
			this.btnDeleteCategory.TabIndex = 14;
			this.btnDeleteCategory.UseVisualStyleBackColor = true;
			this.btnDeleteCategory.Click += new System.EventHandler(this.BtnDeleteCategoryClick);
			// 
			// btnSaveCategory
			// 
			this.btnSaveCategory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSaveCategory.FlatAppearance.BorderSize = 0;
			this.btnSaveCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnSaveCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnSaveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveCategory.Location = new System.Drawing.Point(820, 499);
			this.btnSaveCategory.Name = "btnSaveCategory";
			this.btnSaveCategory.Size = new System.Drawing.Size(35, 23);
			this.btnSaveCategory.TabIndex = 13;
			this.btnSaveCategory.UseVisualStyleBackColor = true;
			this.btnSaveCategory.Click += new System.EventHandler(this.BtnSaveCategoryClick);
			// 
			// dgvServices
			// 
			this.dgvServices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvServices.Location = new System.Drawing.Point(25, 305);
			this.dgvServices.Name = "dgvServices";
			this.dgvServices.Size = new System.Drawing.Size(789, 151);
			this.dgvServices.TabIndex = 15;
			this.dgvServices.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServices_CellValueChanged);
			// 
			// LaundryConfigurationView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.ClientSize = new System.Drawing.Size(884, 712);
			this.Controls.Add(this.dgvServices);
			this.Controls.Add(this.btnDeleteCategory);
			this.Controls.Add(this.btnSaveCategory);
			this.Controls.Add(this.btnDeleteServices);
			this.Controls.Add(this.btnSaveServices);
			this.Controls.Add(this.btnDeletePriceScheme);
			this.Controls.Add(this.btnSavePriceScheme);
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
		private System.Windows.Forms.DataGridView dgvServices;		
		private System.Windows.Forms.Button btnSaveCategory;
		private System.Windows.Forms.Button btnDeleteCategory;
		private System.Windows.Forms.Button btnSaveServices;
		private System.Windows.Forms.Button btnDeleteServices;
		private System.Windows.Forms.Button btnDeletePriceScheme;
		private System.Windows.Forms.Button btnSavePriceScheme;
		private System.Windows.Forms.Button btnAddPriceScheme;
		private System.Windows.Forms.DataGridView dgvCategory;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvPriceScheme;
		private System.Windows.Forms.Label label1;
		
		

	}
}

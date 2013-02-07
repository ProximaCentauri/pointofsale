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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvPriceScheme = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dgvCategory = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAddPriceScheme = new System.Windows.Forms.Button();
			this.btnEditPriceScheme = new System.Windows.Forms.Button();
			this.btnDeletePriceScheme = new System.Windows.Forms.Button();
			this.btnDeleteServices = new System.Windows.Forms.Button();
			this.btnSaveServices = new System.Windows.Forms.Button();
			this.btnDeleteCategory = new System.Windows.Forms.Button();
			this.btnSaveCategory = new System.Windows.Forms.Button();
			this.dgvServices = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ServiceDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Services = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.Category = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPriceScheme.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvPriceScheme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPriceScheme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Services,
									this.Category,
									this.Description,
									this.Price});
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
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn1,
									this.dataGridViewTextBoxColumn2});
			this.dgvCategory.Location = new System.Drawing.Point(25, 419);
			this.dgvCategory.Name = "dgvCategory";
			this.dgvCategory.Size = new System.Drawing.Size(789, 131);
			this.dgvCategory.TabIndex = 5;
			// 
			// dataGridViewTextBoxColumn1
			// 
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridViewTextBoxColumn1.HeaderText = "Category Name";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Width = 300;
			// 
			// dataGridViewTextBoxColumn2
			// 
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridViewTextBoxColumn2.HeaderText = "Category Description";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Width = 450;
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
			this.btnDeleteServices.Location = new System.Drawing.Point(820, 262);
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
			this.btnSaveServices.Location = new System.Drawing.Point(820, 233);
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
			this.btnDeleteCategory.Location = new System.Drawing.Point(820, 453);
			this.btnDeleteCategory.Name = "btnDeleteCategory";
			this.btnDeleteCategory.Size = new System.Drawing.Size(35, 23);
			this.btnDeleteCategory.TabIndex = 14;
			this.btnDeleteCategory.UseVisualStyleBackColor = true;
			// 
			// btnSaveCategory
			// 
			this.btnSaveCategory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSaveCategory.FlatAppearance.BorderSize = 0;
			this.btnSaveCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnSaveCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnSaveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveCategory.Location = new System.Drawing.Point(820, 424);
			this.btnSaveCategory.Name = "btnSaveCategory";
			this.btnSaveCategory.Size = new System.Drawing.Size(35, 23);
			this.btnSaveCategory.TabIndex = 13;
			this.btnSaveCategory.UseVisualStyleBackColor = true;
			// 
			// dgvServices
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ID,
									this.ServiceName,
									this.ServiceDescription});
			this.dgvServices.Location = new System.Drawing.Point(25, 229);
			this.dgvServices.Name = "dgvServices";
			this.dgvServices.Size = new System.Drawing.Size(789, 151);
			this.dgvServices.TabIndex = 15;
			this.dgvServices.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServices_CellValueChanged);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.Visible = false;
			// 
			// ServiceName
			// 
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ServiceName.DefaultCellStyle = dataGridViewCellStyle9;
			this.ServiceName.HeaderText = "Service Name";
			this.ServiceName.Name = "ServiceName";
			this.ServiceName.Width = 300;
			// 
			// ServiceDescription
			// 
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ServiceDescription.DefaultCellStyle = dataGridViewCellStyle10;
			this.ServiceDescription.HeaderText = "Service Description";
			this.ServiceDescription.Name = "ServiceDescription";
			this.ServiceDescription.Width = 450;
			// 
			// Services
			// 
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Services.DefaultCellStyle = dataGridViewCellStyle1;
			this.Services.HeaderText = "Services";
			this.Services.Name = "Services";
			this.Services.Width = 175;
			// 
			// Category
			// 
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
			this.Category.DefaultCellStyle = dataGridViewCellStyle2;
			this.Category.HeaderText = "Category";
			this.Category.Name = "Category";
			this.Category.Width = 175;
			// 
			// Description
			// 
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
			this.Description.DefaultCellStyle = dataGridViewCellStyle3;
			this.Description.HeaderText = "Description";
			this.Description.Name = "Description";
			this.Description.Width = 300;
			// 
			// Price
			// 
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold);
			this.Price.DefaultCellStyle = dataGridViewCellStyle4;
			this.Price.HeaderText = "Price";
			this.Price.Name = "Price";
			// 
			// LaundryConfigurationView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.ClientSize = new System.Drawing.Size(884, 562);
			this.Controls.Add(this.dgvServices);
			this.Controls.Add(this.btnDeleteCategory);
			this.Controls.Add(this.btnSaveCategory);
			this.Controls.Add(this.btnDeleteServices);
			this.Controls.Add(this.btnSaveServices);
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
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
		private System.Windows.Forms.DataGridViewTextBoxColumn Description;
		private System.Windows.Forms.DataGridViewComboBoxColumn Category;
		private System.Windows.Forms.DataGridViewComboBoxColumn Services;
		private System.Windows.Forms.DataGridViewTextBoxColumn ServiceDescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridView dgvServices;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.Button btnSaveCategory;
		private System.Windows.Forms.Button btnDeleteCategory;
		private System.Windows.Forms.Button btnSaveServices;
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

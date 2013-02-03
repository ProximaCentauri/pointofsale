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
	partial class ConfigurationView
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
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.btnAddPriceScheme = new System.Windows.Forms.Button();
			this.btnEditPriceScheme = new System.Windows.Forms.Button();
			this.btnDeletePriceScheme = new System.Windows.Forms.Button();
			this.btnDeleteServices = new System.Windows.Forms.Button();
			this.btnEditServices = new System.Windows.Forms.Button();
			this.btnAddServices = new System.Windows.Forms.Button();
			this.btnDeleteCategory = new System.Windows.Forms.Button();
			this.btnEditCategory = new System.Windows.Forms.Button();
			this.btnAddCategory = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
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
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(25, 45);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(789, 149);
			this.dataGridView1.TabIndex = 1;
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
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(25, 229);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(789, 149);
			this.dataGridView2.TabIndex = 3;
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
			// dataGridView3
			// 
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Location = new System.Drawing.Point(25, 419);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.Size = new System.Drawing.Size(789, 131);
			this.dataGridView3.TabIndex = 5;
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
			// ConfigurationView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.ClientSize = new System.Drawing.Size(884, 562);
			this.Controls.Add(this.btnDeleteCategory);
			this.Controls.Add(this.btnEditCategory);
			this.Controls.Add(this.btnAddCategory);
			this.Controls.Add(this.btnDeleteServices);
			this.Controls.Add(this.btnEditServices);
			this.Controls.Add(this.btnAddServices);
			this.Controls.Add(this.btnDeletePriceScheme);
			this.Controls.Add(this.btnEditPriceScheme);
			this.Controls.Add(this.btnAddPriceScheme);
			this.Controls.Add(this.dataGridView3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Name = "ConfigurationView";
			this.Text = "LaundryConfigurationView";
			this.Load += new System.EventHandler(this.LaundryConfigurationFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnAddCategory;
		private System.Windows.Forms.Button btnEditCategory;
		private System.Windows.Forms.Button btnDeleteCategory;
		private System.Windows.Forms.Button btnAddServices;
		private System.Windows.Forms.Button btnEditServices;
		private System.Windows.Forms.Button btnDeleteServices;
		private System.Windows.Forms.Button btnDeletePriceScheme;
		private System.Windows.Forms.Button btnEditPriceScheme;
		private System.Windows.Forms.Button btnAddPriceScheme;
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		
		

	}
}

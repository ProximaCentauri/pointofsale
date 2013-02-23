/*
 * Created by SharpDevelop.
 * User: user
 * Date: 2/10/2013
 * Time: 6:11 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NJournals.Core.Views
{
	partial class RefillingConfigurationView
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
			this.dgvProductType = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.btnDeleteProduct = new System.Windows.Forms.Button();
			this.btnSaveProduct = new System.Windows.Forms.Button();
			this.dgvRefillInventory = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.btnDeleteInv = new System.Windows.Forms.Button();
			this.btnSaveInv = new System.Windows.Forms.Button();
			this.btnAddInv = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvRefillInventory)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvProductType
			// 
			this.dgvProductType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProductType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvProductType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProductType.Location = new System.Drawing.Point(12, 59);
			this.dgvProductType.Name = "dgvProductType";
			this.dgvProductType.Size = new System.Drawing.Size(789, 186);
			this.dgvProductType.TabIndex = 7;
			this.dgvProductType.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductType_CellValueChanged);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(12, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(789, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Products";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnDeleteProduct
			// 
			this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDeleteProduct.FlatAppearance.BorderSize = 0;
			this.btnDeleteProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnDeleteProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteProduct.Location = new System.Drawing.Point(807, 107);
			this.btnDeleteProduct.Name = "btnDeleteProduct";
			this.btnDeleteProduct.Size = new System.Drawing.Size(35, 23);
			this.btnDeleteProduct.TabIndex = 16;
			this.btnDeleteProduct.UseVisualStyleBackColor = false;
			this.btnDeleteProduct.Click += new System.EventHandler(this.BtnDeleteProductClick);
			// 
			// btnSaveProduct
			// 
			this.btnSaveProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnSaveProduct.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSaveProduct.FlatAppearance.BorderSize = 0;
			this.btnSaveProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnSaveProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnSaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveProduct.Location = new System.Drawing.Point(807, 76);
			this.btnSaveProduct.Name = "btnSaveProduct";
			this.btnSaveProduct.Size = new System.Drawing.Size(35, 23);
			this.btnSaveProduct.TabIndex = 15;
			this.btnSaveProduct.UseVisualStyleBackColor = false;
			this.btnSaveProduct.Click += new System.EventHandler(this.BtnSaveProductClick);
			// 
			// dgvRefillInventory
			// 
			this.dgvRefillInventory.AllowUserToAddRows = false;
			this.dgvRefillInventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvRefillInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvRefillInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRefillInventory.Location = new System.Drawing.Point(12, 291);
			this.dgvRefillInventory.Name = "dgvRefillInventory";
			this.dgvRefillInventory.Size = new System.Drawing.Size(789, 186);
			this.dgvRefillInventory.TabIndex = 18;
			this.dgvRefillInventory.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRefillInventory_CellValueChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(151)))), ((int)(((byte)(166)))));
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(12, 265);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(789, 23);
			this.label1.TabIndex = 17;
			this.label1.Text = "Inventory";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnDeleteInv
			// 
			this.btnDeleteInv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnDeleteInv.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDeleteInv.FlatAppearance.BorderSize = 0;
			this.btnDeleteInv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnDeleteInv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnDeleteInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteInv.Location = new System.Drawing.Point(807, 360);
			this.btnDeleteInv.Name = "btnDeleteInv";
			this.btnDeleteInv.Size = new System.Drawing.Size(35, 23);
			this.btnDeleteInv.TabIndex = 20;
			this.btnDeleteInv.UseVisualStyleBackColor = false;
			this.btnDeleteInv.Click += new System.EventHandler(this.BtnDeleteInvClick);
			// 
			// btnSaveInv
			// 
			this.btnSaveInv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnSaveInv.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSaveInv.FlatAppearance.BorderSize = 0;
			this.btnSaveInv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnSaveInv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnSaveInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveInv.Location = new System.Drawing.Point(807, 328);
			this.btnSaveInv.Name = "btnSaveInv";
			this.btnSaveInv.Size = new System.Drawing.Size(35, 23);
			this.btnSaveInv.TabIndex = 19;
			this.btnSaveInv.UseVisualStyleBackColor = false;
			this.btnSaveInv.Click += new System.EventHandler(this.BtnSaveInvClick);
			// 
			// btnAddInv
			// 
			this.btnAddInv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnAddInv.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddInv.FlatAppearance.BorderSize = 0;
			this.btnAddInv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnAddInv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnAddInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddInv.Location = new System.Drawing.Point(807, 297);
			this.btnAddInv.Name = "btnAddInv";
			this.btnAddInv.Size = new System.Drawing.Size(35, 23);
			this.btnAddInv.TabIndex = 21;
			this.btnAddInv.UseVisualStyleBackColor = false;
			this.btnAddInv.Click += new System.EventHandler(this.BtnAddInvClick);
			// 
			// RefillingConfigurationView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.ClientSize = new System.Drawing.Size(884, 712);
			this.Controls.Add(this.btnAddInv);
			this.Controls.Add(this.btnDeleteInv);
			this.Controls.Add(this.btnSaveInv);
			this.Controls.Add(this.dgvRefillInventory);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnDeleteProduct);
			this.Controls.Add(this.btnSaveProduct);
			this.Controls.Add(this.dgvProductType);
			this.Controls.Add(this.label3);
			this.Name = "RefillingConfigurationView";
			this.Text = "RefillingConfigurationView";
			this.Load += new System.EventHandler(this.RefillingConfigurationFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvProductType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvRefillInventory)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnAddInv;
		private System.Windows.Forms.Button btnSaveInv;
		private System.Windows.Forms.Button btnDeleteInv;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvRefillInventory;
		private System.Windows.Forms.Button btnSaveProduct;
		private System.Windows.Forms.Button btnDeleteProduct;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dgvProductType;
	}
}

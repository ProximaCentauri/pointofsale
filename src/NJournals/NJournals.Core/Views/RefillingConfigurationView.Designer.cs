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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvProductType = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.btnDeleteProduct = new System.Windows.Forms.Button();
			this.btnSaveProduct = new System.Windows.Forms.Button();
			this.dgvRefillInventory = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvRefillInventory)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvProductType
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProductType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvProductType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.dgvProductType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProductType.Location = new System.Drawing.Point(12, 59);
			this.dgvProductType.Name = "dgvProductType";
			this.dgvProductType.Size = new System.Drawing.Size(789, 186);
			this.dgvProductType.TabIndex = 7;
			this.dgvProductType.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductType_CellValueChanged);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(168)))), ((int)(((byte)(188)))));
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(12, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(789, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Products";
			// 
			// btnDeleteProduct
			// 
			this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDeleteProduct.FlatAppearance.BorderSize = 0;
			this.btnDeleteProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnDeleteProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteProduct.Location = new System.Drawing.Point(807, 100);
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
			this.btnSaveProduct.Location = new System.Drawing.Point(807, 71);
			this.btnSaveProduct.Name = "btnSaveProduct";
			this.btnSaveProduct.Size = new System.Drawing.Size(35, 23);
			this.btnSaveProduct.TabIndex = 15;
			this.btnSaveProduct.UseVisualStyleBackColor = false;
			this.btnSaveProduct.Click += new System.EventHandler(this.BtnSaveProductClick);
			// 
			// dgvRefillInventory
			// 
			this.dgvRefillInventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.dgvRefillInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRefillInventory.Location = new System.Drawing.Point(12, 291);
			this.dgvRefillInventory.Name = "dgvRefillInventory";
			this.dgvRefillInventory.Size = new System.Drawing.Size(789, 186);
			this.dgvRefillInventory.TabIndex = 18;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(168)))), ((int)(((byte)(188)))));
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(12, 265);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(789, 23);
			this.label1.TabIndex = 17;
			this.label1.Text = "Inventory";
			// 
			// RefillingConfigurationView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.ClientSize = new System.Drawing.Size(884, 712);
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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvRefillInventory;
		private System.Windows.Forms.Button btnSaveProduct;
		private System.Windows.Forms.Button btnDeleteProduct;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dgvProductType;
	}
}

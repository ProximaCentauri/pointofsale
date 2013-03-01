/*
 * Created by SharpDevelop.
 * User: vo185003
 * Date: 3/1/2013
 * Time: 4:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NJournals.Core.Views
{
	partial class LaundryChargesView
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
			this.dgvCharges = new System.Windows.Forms.DataGridView();
			this.btnDeleteCharges = new System.Windows.Forms.Button();
			this.btnSaveCharges = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvCharges)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCharges
			// 
			this.dgvCharges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCharges.Location = new System.Drawing.Point(12, 35);
			this.dgvCharges.Name = "dgvCharges";
			this.dgvCharges.Size = new System.Drawing.Size(331, 209);
			this.dgvCharges.TabIndex = 0;
			// 
			// btnDeleteCharges
			// 
			this.btnDeleteCharges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnDeleteCharges.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDeleteCharges.FlatAppearance.BorderSize = 0;
			this.btnDeleteCharges.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnDeleteCharges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnDeleteCharges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteCharges.Location = new System.Drawing.Point(349, 76);
			this.btnDeleteCharges.Name = "btnDeleteCharges";
			this.btnDeleteCharges.Size = new System.Drawing.Size(35, 23);
			this.btnDeleteCharges.TabIndex = 18;
			this.btnDeleteCharges.UseVisualStyleBackColor = false;
			this.btnDeleteCharges.Click += new System.EventHandler(this.BtnDeleteChargesClick);
			// 
			// btnSaveCharges
			// 
			this.btnSaveCharges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnSaveCharges.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSaveCharges.FlatAppearance.BorderSize = 0;
			this.btnSaveCharges.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnSaveCharges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.btnSaveCharges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveCharges.Location = new System.Drawing.Point(349, 45);
			this.btnSaveCharges.Name = "btnSaveCharges";
			this.btnSaveCharges.Size = new System.Drawing.Size(35, 23);
			this.btnSaveCharges.TabIndex = 17;
			this.btnSaveCharges.UseVisualStyleBackColor = false;
			this.btnSaveCharges.Click += new System.EventHandler(this.BtnSaveChargesClick);
			// 
			// LaundryChargesView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.ClientSize = new System.Drawing.Size(410, 316);
			this.Controls.Add(this.btnDeleteCharges);
			this.Controls.Add(this.btnSaveCharges);
			this.Controls.Add(this.dgvCharges);
			this.Name = "LaundryChargesView";
			this.Text = "LaundryAdditionalChargesView";
			((System.ComponentModel.ISupportInitialize)(this.dgvCharges)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnSaveCharges;
		private System.Windows.Forms.Button btnDeleteCharges;
		private System.Windows.Forms.DataGridView dgvCharges;
	}
}

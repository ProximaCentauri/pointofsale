/*
 * Created by SharpDevelop.
 * User: vo185003
 * Date: 1/21/2013
 * Time: 7:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NJournals.Core.Views
{
	partial class SearchItemView
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
			this.cmbsearch = new System.Windows.Forms.ComboBox();
			this.txtdata = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnok = new System.Windows.Forms.Button();
			this.btncancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbsearch
			// 
			this.cmbsearch.FormattingEnabled = true;
			this.cmbsearch.Location = new System.Drawing.Point(74, 21);
			this.cmbsearch.Name = "cmbsearch";
			this.cmbsearch.Size = new System.Drawing.Size(136, 21);
			this.cmbsearch.TabIndex = 0;
			// 
			// txtdata
			// 
			this.txtdata.Location = new System.Drawing.Point(230, 21);
			this.txtdata.Name = "txtdata";
			this.txtdata.Size = new System.Drawing.Size(166, 20);
			this.txtdata.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(410, 18);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(29, 23);
			this.button1.TabIndex = 2;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(26, 61);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(666, 244);
			this.dataGridView1.TabIndex = 3;
			// 
			// btnok
			// 
			this.btnok.Location = new System.Drawing.Point(463, 337);
			this.btnok.Name = "btnok";
			this.btnok.Size = new System.Drawing.Size(75, 23);
			this.btnok.TabIndex = 4;
			this.btnok.Text = "OK";
			this.btnok.UseVisualStyleBackColor = true;
			// 
			// btncancel
			// 
			this.btncancel.Location = new System.Drawing.Point(553, 337);
			this.btncancel.Name = "btncancel";
			this.btncancel.Size = new System.Drawing.Size(75, 23);
			this.btncancel.TabIndex = 5;
			this.btncancel.Text = "Cancel";
			this.btncancel.UseVisualStyleBackColor = true;
			// 
			// SearchItemView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(719, 384);
			this.Controls.Add(this.btncancel);
			this.Controls.Add(this.btnok);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtdata);
			this.Controls.Add(this.cmbsearch);
			this.Name = "SearchItemView";
			this.Text = "Search";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btncancel;
		private System.Windows.Forms.Button btnok;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtdata;
		private System.Windows.Forms.ComboBox cmbsearch;
	}
}

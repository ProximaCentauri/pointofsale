/*
 * Created by SharpDevelop.
 * User: user
 * Date: 1/31/2013
 * Time: 12:36 AM
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
			this.button3 = new System.Windows.Forms.Button();
			this.EditPriceScheme = new System.Windows.Forms.Button();
			this.AddPriceScheme = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(820, 102);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(35, 23);
			this.button3.TabIndex = 13;
			this.button3.Text = "Remove";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// EditPriceScheme
			// 
			this.EditPriceScheme.Location = new System.Drawing.Point(820, 73);
			this.EditPriceScheme.Name = "EditPriceScheme";
			this.EditPriceScheme.Size = new System.Drawing.Size(35, 23);
			this.EditPriceScheme.TabIndex = 12;
			this.EditPriceScheme.Text = "Edit";
			this.EditPriceScheme.UseVisualStyleBackColor = true;
			// 
			// AddPriceScheme
			// 
			this.AddPriceScheme.Location = new System.Drawing.Point(820, 44);
			this.AddPriceScheme.Name = "AddPriceScheme";
			this.AddPriceScheme.Size = new System.Drawing.Size(35, 23);
			this.AddPriceScheme.TabIndex = 11;
			this.AddPriceScheme.Text = "Add";
			this.AddPriceScheme.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(25, 44);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(789, 215);
			this.dataGridView1.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Teal;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(25, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(789, 23);
			this.label1.TabIndex = 9;
			this.label1.Text = "Price Scheme";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(820, 358);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(35, 23);
			this.button1.TabIndex = 18;
			this.button1.Text = "Remove";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(820, 329);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(35, 23);
			this.button2.TabIndex = 17;
			this.button2.Text = "Edit";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(820, 300);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(35, 23);
			this.button4.TabIndex = 16;
			this.button4.Text = "Add";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(25, 300);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(789, 214);
			this.dataGridView2.TabIndex = 15;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Teal;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(25, 275);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(789, 23);
			this.label2.TabIndex = 14;
			this.label2.Text = "Product";
			// 
			// RefillingConfigurationView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 562);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.EditPriceScheme);
			this.Controls.Add(this.AddPriceScheme);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Name = "RefillingConfigurationView";
			this.Text = "RefillingConfigurationView";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button AddPriceScheme;
		private System.Windows.Forms.Button EditPriceScheme;
		private System.Windows.Forms.Button button3;
	}
}

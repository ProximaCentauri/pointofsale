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
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.AddPriceScheme = new System.Windows.Forms.Button();
			this.EditPriceScheme = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			this.SuspendLayout();
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
			this.label2.BackColor = System.Drawing.Color.Teal;
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
			this.label3.BackColor = System.Drawing.Color.Teal;
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
			// AddPriceScheme
			// 
			this.AddPriceScheme.Location = new System.Drawing.Point(820, 44);
			this.AddPriceScheme.Name = "AddPriceScheme";
			this.AddPriceScheme.Size = new System.Drawing.Size(35, 23);
			this.AddPriceScheme.TabIndex = 6;
			this.AddPriceScheme.Text = "Add";
			this.AddPriceScheme.UseVisualStyleBackColor = true;
			// 
			// EditPriceScheme
			// 
			this.EditPriceScheme.Location = new System.Drawing.Point(820, 73);
			this.EditPriceScheme.Name = "EditPriceScheme";
			this.EditPriceScheme.Size = new System.Drawing.Size(35, 23);
			this.EditPriceScheme.TabIndex = 7;
			this.EditPriceScheme.Text = "Edit";
			this.EditPriceScheme.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(820, 102);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(35, 23);
			this.button3.TabIndex = 8;
			this.button3.Text = "Remove";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(820, 287);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(35, 23);
			this.button4.TabIndex = 11;
			this.button4.Text = "Remove";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(820, 258);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(35, 23);
			this.button5.TabIndex = 10;
			this.button5.Text = "Edit";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(820, 229);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(35, 23);
			this.button6.TabIndex = 9;
			this.button6.Text = "Add";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(820, 477);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(35, 23);
			this.button7.TabIndex = 14;
			this.button7.Text = "Remove";
			this.button7.UseVisualStyleBackColor = true;
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(820, 448);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(35, 23);
			this.button8.TabIndex = 13;
			this.button8.Text = "Edit";
			this.button8.UseVisualStyleBackColor = true;
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(820, 419);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(35, 23);
			this.button9.TabIndex = 12;
			this.button9.Text = "Add";
			this.button9.UseVisualStyleBackColor = true;
			// 
			// LaundryConfigurationView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 562);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.EditPriceScheme);
			this.Controls.Add(this.AddPriceScheme);
			this.Controls.Add(this.dataGridView3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Name = "LaundryConfigurationView";
			this.Text = "LaundryConfigurationView";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button EditPriceScheme;
		private System.Windows.Forms.Button AddPriceScheme;
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
	}
}

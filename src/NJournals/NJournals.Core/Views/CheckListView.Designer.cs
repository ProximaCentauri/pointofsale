/*
 * Created by SharpDevelop.
 * User: vo185003
 * Date: 2/4/2013
 * Time: 9:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NJournals.Core.Views
{
	partial class CheckListView
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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnsave = new System.Windows.Forms.Button();
			this.btnsaveprint = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(89, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(154, 20);
			this.textBox1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Job Order:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnsave
			// 
			this.btnsave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsave.Location = new System.Drawing.Point(126, 505);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(58, 23);
			this.btnsave.TabIndex = 21;
			this.btnsave.Text = "Save";
			this.btnsave.UseVisualStyleBackColor = true;
			// 
			// btnsaveprint
			// 
			this.btnsaveprint.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsaveprint.Location = new System.Drawing.Point(16, 505);
			this.btnsaveprint.Name = "btnsaveprint";
			this.btnsaveprint.Size = new System.Drawing.Size(99, 23);
			this.btnsaveprint.TabIndex = 20;
			this.btnsaveprint.Text = "Save && Print";
			this.btnsaveprint.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label2.Location = new System.Drawing.Point(3, 429);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 23);
			this.label2.TabIndex = 22;
			this.label2.Text = "Total Items:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(77, 429);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(66, 20);
			this.textBox8.TabIndex = 23;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(194, 505);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(58, 23);
			this.button1.TabIndex = 24;
			this.button1.Text = "Cancel";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// listView1
			// 
			listViewItem1.Checked = true;
			listViewItem1.StateImageIndex = 1;
			this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
									listViewItem1});
			this.listView1.Location = new System.Drawing.Point(16, 71);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(227, 335);
			this.listView1.TabIndex = 25;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// CheckListView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
			this.ClientSize = new System.Drawing.Size(264, 567);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnsave);
			this.Controls.Add(this.btnsaveprint);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "CheckListView";
			this.Text = "CheckListView";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnsaveprint;
		private System.Windows.Forms.Button btnsave;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
	}
}

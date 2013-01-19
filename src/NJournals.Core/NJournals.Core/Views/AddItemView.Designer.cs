/*
 * Created by SharpDevelop.
 * User: matt
 * Date: 1/19/2013
 * Time: 9:58 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NJournals.Core.Views
{
	partial class AddItemView
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
			this.btnsave = new System.Windows.Forms.Button();
			this.btncancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnsave
			// 
			this.btnsave.Location = new System.Drawing.Point(242, 301);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(75, 23);
			this.btnsave.TabIndex = 0;
			this.btnsave.Text = "Save";
			this.btnsave.UseVisualStyleBackColor = true;
			this.btnsave.Click += new System.EventHandler(this.BtnsaveClick);
			// 
			// btncancel
			// 
			this.btncancel.Location = new System.Drawing.Point(323, 301);
			this.btncancel.Name = "btncancel";
			this.btncancel.Size = new System.Drawing.Size(75, 23);
			this.btncancel.TabIndex = 1;
			this.btncancel.Text = "Cancel";
			this.btncancel.UseVisualStyleBackColor = true;
			// 
			// AddItemView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(404, 336);
			this.Controls.Add(this.btncancel);
			this.Controls.Add(this.btnsave);
			this.Name = "AddItemView";
			this.Text = "AddItemView";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btncancel;
		private System.Windows.Forms.Button btnsave;
	}
}

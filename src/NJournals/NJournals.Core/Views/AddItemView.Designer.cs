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
			this.components = new System.ComponentModel.Container();
			this.btnsave = new System.Windows.Forms.Button();
			this.btncancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtbarcode = new System.Windows.Forms.TextBox();
			this.itemViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button4 = new System.Windows.Forms.Button();
			this.txtGeneric = new System.Windows.Forms.TextBox();
			this.txtCategory = new System.Windows.Forms.TextBox();
			this.cmbGeneric = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cmdCategory = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtRack = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnremove = new System.Windows.Forms.Button();
			this.btnadd = new System.Windows.Forms.Button();
			this.txtQty2 = new System.Windows.Forms.TextBox();
			this.txtQty1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtunit = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtsellingprice = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtmarkup = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtbuyprice = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.itemViewModelBindingSource)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnsave
			// 
			this.btnsave.Location = new System.Drawing.Point(347, 368);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(75, 23);
			this.btnsave.TabIndex = 0;
			this.btnsave.Text = "Save";
			this.btnsave.UseVisualStyleBackColor = true;
			this.btnsave.Click += new System.EventHandler(this.BtnsaveClick);
			// 
			// btncancel
			// 
			this.btncancel.Location = new System.Drawing.Point(428, 368);
			this.btncancel.Name = "btncancel";
			this.btncancel.Size = new System.Drawing.Size(75, 23);
			this.btncancel.TabIndex = 1;
			this.btncancel.Text = "Cancel";
			this.btncancel.UseVisualStyleBackColor = true;
			this.btncancel.Click += new System.EventHandler(this.BtncancelClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(10, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Barcode";
			// 
			// txtbarcode
			// 
			this.txtbarcode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemViewModelBindingSource, "Barcode", true));
			this.txtbarcode.Location = new System.Drawing.Point(106, 21);
			this.txtbarcode.Name = "txtbarcode";
			this.txtbarcode.Size = new System.Drawing.Size(203, 20);
			this.txtbarcode.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.txtGeneric);
			this.groupBox1.Controls.Add(this.txtCategory);
			this.groupBox1.Controls.Add(this.cmbGeneric);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.cmdCategory);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtRack);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtname);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtbarcode);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(492, 159);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "General";
			// 
			// button4
			// 
			this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Location = new System.Drawing.Point(458, 102);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(21, 21);
			this.button4.TabIndex = 14;
			this.button4.UseVisualStyleBackColor = true;
			// 
			// txtGeneric
			// 
			this.txtGeneric.Location = new System.Drawing.Point(318, 101);
			this.txtGeneric.Name = "txtGeneric";
			this.txtGeneric.Size = new System.Drawing.Size(133, 20);
			this.txtGeneric.TabIndex = 13;
			// 
			// txtCategory
			// 
			this.txtCategory.Location = new System.Drawing.Point(318, 73);
			this.txtCategory.Name = "txtCategory";
			this.txtCategory.Size = new System.Drawing.Size(133, 20);
			this.txtCategory.TabIndex = 12;
			// 
			// cmbGeneric
			// 
			this.cmbGeneric.FormattingEnabled = true;
			this.cmbGeneric.Location = new System.Drawing.Point(106, 99);
			this.cmbGeneric.Name = "cmbGeneric";
			this.cmbGeneric.Size = new System.Drawing.Size(203, 21);
			this.cmbGeneric.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(10, 99);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Generic";
			// 
			// cmdCategory
			// 
			this.cmdCategory.FormattingEnabled = true;
			this.cmdCategory.Location = new System.Drawing.Point(106, 72);
			this.cmdCategory.Name = "cmdCategory";
			this.cmdCategory.Size = new System.Drawing.Size(203, 21);
			this.cmdCategory.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(10, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Category";
			// 
			// txtRack
			// 
			this.txtRack.Location = new System.Drawing.Point(106, 126);
			this.txtRack.Name = "txtRack";
			this.txtRack.Size = new System.Drawing.Size(203, 20);
			this.txtRack.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(10, 126);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Rack";
			// 
			// txtname
			// 
			this.txtname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemViewModelBindingSource, "Name", true));
			this.txtname.Location = new System.Drawing.Point(106, 47);
			this.txtname.Name = "txtname";
			this.txtname.Size = new System.Drawing.Size(203, 20);
			this.txtname.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(10, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Name";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnremove);
			this.groupBox2.Controls.Add(this.btnadd);
			this.groupBox2.Controls.Add(this.txtQty2);
			this.groupBox2.Controls.Add(this.txtQty1);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Location = new System.Drawing.Point(12, 177);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(492, 50);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Stock";
			// 
			// btnremove
			// 
			this.btnremove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnremove.FlatAppearance.BorderSize = 0;
			this.btnremove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnremove.Location = new System.Drawing.Point(276, 19);
			this.btnremove.Name = "btnremove";
			this.btnremove.Size = new System.Drawing.Size(15, 19);
			this.btnremove.TabIndex = 11;
			this.btnremove.UseVisualStyleBackColor = true;
			// 
			// btnadd
			// 
			this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnadd.FlatAppearance.BorderSize = 0;
			this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnadd.Location = new System.Drawing.Point(249, 20);
			this.btnadd.Name = "btnadd";
			this.btnadd.Size = new System.Drawing.Size(20, 22);
			this.btnadd.TabIndex = 10;
			this.btnadd.UseVisualStyleBackColor = true;
			// 
			// txtQty2
			// 
			this.txtQty2.Location = new System.Drawing.Point(193, 18);
			this.txtQty2.Name = "txtQty2";
			this.txtQty2.Size = new System.Drawing.Size(45, 20);
			this.txtQty2.TabIndex = 9;
			// 
			// txtQty1
			// 
			this.txtQty1.Location = new System.Drawing.Point(106, 19);
			this.txtQty1.Name = "txtQty1";
			this.txtQty1.Size = new System.Drawing.Size(79, 20);
			this.txtQty1.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(6, 18);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 7;
			this.label6.Text = "Quantity";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtunit);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.txtsellingprice);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.txtmarkup);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.txtbuyprice);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Location = new System.Drawing.Point(12, 233);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(492, 127);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Price";
			// 
			// txtunit
			// 
			this.txtunit.Location = new System.Drawing.Point(106, 97);
			this.txtunit.Name = "txtunit";
			this.txtunit.Size = new System.Drawing.Size(203, 20);
			this.txtunit.TabIndex = 13;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(10, 94);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 12;
			this.label9.Text = "Unit";
			// 
			// txtsellingprice
			// 
			this.txtsellingprice.Location = new System.Drawing.Point(106, 71);
			this.txtsellingprice.Name = "txtsellingprice";
			this.txtsellingprice.Size = new System.Drawing.Size(203, 20);
			this.txtsellingprice.TabIndex = 11;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(10, 71);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 10;
			this.label10.Text = "Selling Price";
			// 
			// txtmarkup
			// 
			this.txtmarkup.Location = new System.Drawing.Point(106, 45);
			this.txtmarkup.Name = "txtmarkup";
			this.txtmarkup.Size = new System.Drawing.Size(203, 20);
			this.txtmarkup.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(10, 45);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 8;
			this.label7.Text = "Mark-up %";
			// 
			// txtbuyprice
			// 
			this.txtbuyprice.Location = new System.Drawing.Point(106, 19);
			this.txtbuyprice.Name = "txtbuyprice";
			this.txtbuyprice.Size = new System.Drawing.Size(203, 20);
			this.txtbuyprice.TabIndex = 7;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(10, 19);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 6;
			this.label8.Text = "Buy Price";
			// 
			// button3
			// 
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(469, 87);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(19, 22);
			this.button3.TabIndex = 14;
			this.button3.UseVisualStyleBackColor = true;
			// 
			// AddItemView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(523, 397);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btncancel);
			this.Controls.Add(this.btnsave);
			this.Name = "AddItemView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Item";
			this.Load += new System.EventHandler(this.AddItemViewLoad);
			((System.ComponentModel.ISupportInitialize)(this.itemViewModelBindingSource)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox txtCategory;
		private System.Windows.Forms.TextBox txtGeneric;
		private System.Windows.Forms.TextBox txtQty1;
		private System.Windows.Forms.TextBox txtQty2;
		private System.Windows.Forms.Button btnadd;
		private System.Windows.Forms.Button btnremove;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtbuyprice;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtmarkup;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtsellingprice;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtunit;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmdCategory;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbGeneric;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtname;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtRack;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtbarcode;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource itemViewModelBindingSource;
		private System.Windows.Forms.Button btncancel;
		private System.Windows.Forms.Button btnsave;
	}
}

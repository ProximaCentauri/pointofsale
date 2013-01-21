/*
 * Created by SharpDevelop.
 * User: matt
 * Date: 1/19/2013
 * Time: 9:27 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using NJournals.Common.Util;
using NJournals.Common.DataEntities;
using NJournals.Core.Models;
using System.Collections.Generic;

namespace NJournals.Core
{
	partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Sales = new System.Windows.Forms.TabPage();
            this.EditSales = new System.Windows.Forms.TabPage();
            this.Payment = new System.Windows.Forms.TabPage();
            this.Report = new System.Windows.Forms.TabPage();
            this.Inventory = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Configuration = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Inventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Sales);
            this.tabControl1.Controls.Add(this.EditSales);
            this.tabControl1.Controls.Add(this.Payment);
            this.tabControl1.Controls.Add(this.Report);
            this.tabControl1.Controls.Add(this.Inventory);
            this.tabControl1.Controls.Add(this.Configuration);
            this.tabControl1.HotTrack = true;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabControl1.ItemSize = new System.Drawing.Size(30, 125);
            this.tabControl1.Location = new System.Drawing.Point(0, 69);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(974, 495);
            this.tabControl1.TabIndex = 7;
            // 
            // Sales
            // 
            this.Sales.ImageKey = "sales.jpg";
            this.Sales.Location = new System.Drawing.Point(129, 4);
            this.Sales.Margin = new System.Windows.Forms.Padding(0);
            this.Sales.Name = "Sales";
            this.Sales.Size = new System.Drawing.Size(841, 487);
            this.Sales.TabIndex = 0;
            this.Sales.UseVisualStyleBackColor = true;
            // 
            // EditSales
            // 
            this.EditSales.ImageKey = "editsales.png";
            this.EditSales.Location = new System.Drawing.Point(129, 4);
            this.EditSales.Margin = new System.Windows.Forms.Padding(0);
            this.EditSales.Name = "EditSales";
            this.EditSales.Size = new System.Drawing.Size(841, 487);
            this.EditSales.TabIndex = 1;
            this.EditSales.UseVisualStyleBackColor = true;
            // 
            // Payment
            // 
            this.Payment.ImageKey = "payment.png";
            this.Payment.Location = new System.Drawing.Point(129, 4);
            this.Payment.Name = "Payment";
            this.Payment.Padding = new System.Windows.Forms.Padding(3);
            this.Payment.Size = new System.Drawing.Size(841, 487);
            this.Payment.TabIndex = 2;
            this.Payment.UseVisualStyleBackColor = true;
            // 
            // Report
            // 
            this.Report.ImageKey = "reports.png";
            this.Report.Location = new System.Drawing.Point(129, 4);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(841, 487);
            this.Report.TabIndex = 3;
            this.Report.UseVisualStyleBackColor = true;
            // 
            // Inventory
            // 
            this.Inventory.Controls.Add(this.button3);
            this.Inventory.Controls.Add(this.button2);
            this.Inventory.Controls.Add(this.dataGridView1);
            this.Inventory.Controls.Add(this.button1);
            this.Inventory.Controls.Add(this.Add);
            this.Inventory.Controls.Add(this.textBox1);
            this.Inventory.Controls.Add(this.comboBox1);
            this.Inventory.ImageKey = "inventory.png";
            this.Inventory.Location = new System.Drawing.Point(129, 4);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(841, 487);
            this.Inventory.TabIndex = 4;
            this.Inventory.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(651, 304);
            this.dataGridView1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(242, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // Configuration
            // 
            this.Configuration.ImageKey = "configuration.jpg";
            this.Configuration.Location = new System.Drawing.Point(129, 4);
            this.Configuration.Name = "Configuration";
            this.Configuration.Size = new System.Drawing.Size(841, 487);
            this.Configuration.TabIndex = 5;
            this.Configuration.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "configuration.jpg");
            this.imageList1.Images.SetKeyName(1, "editSales.png");
            this.imageList1.Images.SetKeyName(2, "inventory.png");
            this.imageList1.Images.SetKeyName(3, "payment.png");
            this.imageList1.Images.SetKeyName(4, "reports.png");
            this.imageList1.Images.SetKeyName(5, "sales.jpg");
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::NJournals.Core.Properties.Resources.delete1;
            this.button3.Location = new System.Drawing.Point(676, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 29);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::NJournals.Core.Properties.Resources.edit;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(681, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 28);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::NJournals.Core.Properties.Resources.search;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(440, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 26);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.BackgroundImage = global::NJournals.Core.Properties.Resources.add;
            this.Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Location = new System.Drawing.Point(403, 37);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(26, 26);
            this.Add.TabIndex = 2;
            this.Add.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(983, 598);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "NJournals.Core";
            this.tabControl1.ResumeLayout(false);
            this.Inventory.ResumeLayout(false);
            this.Inventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TabPage Configuration;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TabPage Inventory;
		private System.Windows.Forms.TabPage Report;
		private System.Windows.Forms.TabPage Payment;
		private System.Windows.Forms.TabPage EditSales;
		private System.Windows.Forms.TabPage Sales;
		private System.Windows.Forms.TabControl tabControl1;
		
		
		void BtnAddClick(object sender, System.EventArgs e)
		{			
			ItemCategoryDataEntity itemCategory = new ItemCategoryDataEntity { CategoryName = txtAdd.Text };
			ItemCategoryDao categoryDao = new ItemCategoryDao();
			categoryDao.Save(itemCategory);			
		}
		
		void BtnDisplayClick(object sender, System.EventArgs e)
		{
			ItemCategoryDao categoryDao = new ItemCategoryDao();
			ItemCategoryDataEntity itemCategory = categoryDao.GetByName(txtAdd.Text);
			lblDisplay.Text = itemCategory.CategoryName;
		}
		
		void BtnAddGenClick(object sender, System.EventArgs e)
		{
			//ItemGenericDataEntity itemGeneric = new ItemGenericDataEntity { GenericName = txtAdd.Text };
			//ItemGenericDao genericDao = new ItemGenericDao();
			//genericDao.Save(itemGeneric);
			ItemCategoryDao categoryDao = new ItemCategoryDao();
			ItemGenericDao genericDao = new ItemGenericDao();
	
			ItemDataEntity itemData = new ItemDataEntity{
				Name = "item6",
				Category = categoryDao.GetByName("Med2"),
				Generic = genericDao.GetByName("Gen1"),
				Description = "this is a test item",
				Unit = "box",
				Rack = "A1"
			};
			ItemDao itemDao = new ItemDao();
			itemDao.Save(itemData);
		}
		
		void BtnDisplayGenClick(object sender, System.EventArgs e)
		{
			//ItemGenericDao genericDao = new ItemGenericDao();
			//ItemGenericDataEntity itemGeneric = genericDao.GetByName(txtAdd.Text);
			//lblDisplay.Text = itemGeneric.GenericName;
			
			ItemDao itemDao = new ItemDao();
			ItemDataEntity itemData = itemDao.GetByName("item6");
			lblDisplay.Text = itemData.Generic.GenericName;
		}

        private System.Windows.Forms.ImageList imageList1;
	}
}

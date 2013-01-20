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
			this.button1 = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDisplay = new System.Windows.Forms.Button();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.txtAdd = new System.Windows.Forms.TextBox();
			this.btnAddGen = new System.Windows.Forms.Button();
			this.btnDisplayGen = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(206, 227);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(185, 31);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "button2";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
			// 
			// btnDisplay
			// 
			this.btnDisplay.Location = new System.Drawing.Point(185, 73);
			this.btnDisplay.Name = "btnDisplay";
			this.btnDisplay.Size = new System.Drawing.Size(75, 23);
			this.btnDisplay.TabIndex = 2;
			this.btnDisplay.Text = "button3";
			this.btnDisplay.UseVisualStyleBackColor = true;
			this.btnDisplay.Click += new System.EventHandler(this.BtnDisplayClick);
			// 
			// lblDisplay
			// 
			this.lblDisplay.Location = new System.Drawing.Point(33, 72);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(100, 23);
			this.lblDisplay.TabIndex = 3;
			this.lblDisplay.Text = "label1";
			// 
			// txtAdd
			// 
			this.txtAdd.Location = new System.Drawing.Point(46, 31);
			this.txtAdd.Name = "txtAdd";
			this.txtAdd.Size = new System.Drawing.Size(100, 20);
			this.txtAdd.TabIndex = 4;
			// 
			// btnAddGen
			// 
			this.btnAddGen.Location = new System.Drawing.Point(185, 118);
			this.btnAddGen.Name = "btnAddGen";
			this.btnAddGen.Size = new System.Drawing.Size(75, 23);
			this.btnAddGen.TabIndex = 5;
			this.btnAddGen.Text = "button2";
			this.btnAddGen.UseVisualStyleBackColor = true;
			this.btnAddGen.Click += new System.EventHandler(this.BtnAddGenClick);
			// 
			// btnDisplayGen
			// 
			this.btnDisplayGen.Location = new System.Drawing.Point(185, 147);
			this.btnDisplayGen.Name = "btnDisplayGen";
			this.btnDisplayGen.Size = new System.Drawing.Size(75, 23);
			this.btnDisplayGen.TabIndex = 6;
			this.btnDisplayGen.Text = "button3";
			this.btnDisplayGen.UseVisualStyleBackColor = true;
			this.btnDisplayGen.Click += new System.EventHandler(this.BtnDisplayGenClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.btnDisplayGen);
			this.Controls.Add(this.btnAddGen);
			this.Controls.Add(this.txtAdd);
			this.Controls.Add(this.lblDisplay);
			this.Controls.Add(this.btnDisplay);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "NJournals.Core";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnDisplayGen;
		private System.Windows.Forms.Button btnAddGen;
		private System.Windows.Forms.TextBox txtAdd;
		private System.Windows.Forms.Label lblDisplay;
		private System.Windows.Forms.Button btnDisplay;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button button1;
		
		
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
			ItemGenericDataEntity itemGeneric = new ItemGenericDataEntity { GenericName = txtAdd.Text };
			ItemGenericDao genericDao = new ItemGenericDao();
			genericDao.Save(itemGeneric);
		}
		
		void BtnDisplayGenClick(object sender, System.EventArgs e)
		{
			ItemGenericDao genericDao = new ItemGenericDao();
			ItemGenericDataEntity itemGeneric = genericDao.GetByName(txtAdd.Text);
			lblDisplay.Text = itemGeneric.GenericName;
		}
	}
}

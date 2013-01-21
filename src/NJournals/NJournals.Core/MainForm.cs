/*
 * Created by SharpDevelop.
 * User: matt
 * Date: 1/19/2013
 * Time: 9:27 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows;
using NJournals.Common.Util;
using NJournals.Common.DataEntities;
using NJournals.Core.Models;
using NJournals.Core.Views;
namespace NJournals.Core
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

            //RenderOptions.SetBitmapScalingMode(this, BitmapScalingMode.);
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			MessageService.Attach(new MessageBoxMessageProvider());	
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			AddItemView m_addItemView = new AddItemView(new ItemDao());
			m_addItemView.ShowDialog();
		}
		
		
	}
}

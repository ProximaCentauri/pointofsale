/*
 * Created by SharpDevelop.
 * User: matt
 * Date: 1/19/2013
 * Time: 9:58 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using NJournals.Common.Interfaces;
using NJournals.Common.ViewModels;
namespace NJournals.Core.Views
{
	/// <summary>
	/// Description of AddItemView.
	/// </summary>
	public partial class AddItemView : Form, IAddItemView
	{
		public AddItemView()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void ShowItem(ItemViewModel itemViewModel){
			itemViewModelBindingSource.DataSource = itemViewModel;
		}
		
		public void ReadUserInput(){
			
		}
		
		public void ShowError(string message){
			
		}			
		
		void BtnsaveClick(object sender, EventArgs e)
		{
			
			
		}
		
		void BtncancelClick(object sender, EventArgs e)
		{
			this.Close();
		}
		

	}
}

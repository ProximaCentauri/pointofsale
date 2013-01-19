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
using NJournals.Core.Presenter;
using NJournals.Core.Models;
using NJournals.Common.Util;
namespace NJournals.Core.Views
{
	/// <summary>
	/// Description of AddItemView.
	/// </summary>
	public partial class AddItemView : Form, IAddItemView
	{
		private AddItemPresenter m_presenter;
		public AddItemView(IItemDao p_itemDao)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			m_presenter = new AddItemPresenter(this, p_itemDao);
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		//TODO: Attach MessageService with MessageboxProvider
		
		public void ShowItem(ItemViewModel itemViewModel){
			itemViewModelBindingSource.DataSource = itemViewModel;
		}
		
		public void ReadUserInput(){
			itemViewModelBindingSource.EndEdit();
		}
		
		public void ShowError(string message){
			MessageService.ShowError(message, "Error in Adding Item");
			                         
		}			
		
		void BtnsaveClick(object sender, EventArgs e)
		{
			m_presenter.SaveClicked();
		}
		
		void BtncancelClick(object sender, EventArgs e)
		{
			m_presenter.CancelClicked();
		}
		

	}
}

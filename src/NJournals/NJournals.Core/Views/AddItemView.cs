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
using System.Collections.Generic;
using NJournals.Common.DataEntities;

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
		
		void setImages(){
			Resource.setImage(this.btnadd, System.IO.Directory.GetCurrentDirectory() + "/images/add2.png");
			Resource.setImage(this.btnadd, System.IO.Directory.GetCurrentDirectory() + "/images/remove.png");
		}
		
		public void SetAllCategories(List<ItemCategoryDataEntity> categories){
			foreach(ItemCategoryDataEntity category in categories){
				this.cmdCategory.Items.Add(category.CategoryName);
			}
		}
		
		public void SetAllGenerics(List<ItemGenericDataEntity> generics){
			foreach(ItemGenericDataEntity generic in generics){
				this.cmbGeneric.Items.Add(generic.GenericName);
			}			
		}
		
		void AddItemViewLoad(object sender, EventArgs e)
		{
			setImages();
			m_presenter.SetAllCategories();
			m_presenter.SetAllGenerics();
		}
	}
}

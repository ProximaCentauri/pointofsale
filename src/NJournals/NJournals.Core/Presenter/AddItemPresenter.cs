/*
 * Created by SharpDevelop.
 * User: matt
 * Date: 1/19/2013
 * Time: 10:09 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NJournals.Common.Interfaces;
using NJournals.Common.ViewModels;
using NJournals.Core.Models;
using NJournals.Common.DataEntities;
using NJournals.Common.Util;
using System.Collections.Generic;
namespace NJournals.Core.Presenter
{
	/// <summary>
	/// Description of AddItemPresenter.
	/// </summary>
	public class AddItemPresenter
	{
		
		private IAddItemView m_view;
		private IItemDao m_itemDao;
		private ItemViewModel m_viewModel;
		private ItemCategoryDao m_itemCategoryDao;
		private ItemGenericDao m_itemGenericDao;
		
		public AddItemPresenter(IAddItemView p_view, IItemDao p_itemDao)
		{
			m_view = p_view;
			m_itemDao = p_itemDao;
			
			ItemDataEntity itemDataEntity = new ItemDataEntity();
			ItemViewModel itemViewModel = new ItemViewModel(itemDataEntity);
			
			m_itemCategoryDao = new ItemCategoryDao();
			m_itemGenericDao = new ItemGenericDao();
			
			m_viewModel = itemViewModel;
			m_view.ShowItem(m_viewModel);
		}
		
		public void SaveClicked(){
			m_view.ReadUserInput();	
			
			ItemDataEntity itemDataEntity = m_viewModel.ItemDataEntity;
			MessageService.ShowInfo(itemDataEntity.Barcode + "    " + itemDataEntity.Name);
			ItemDataEntity dublicateExist = IsDublicateofExisting(itemDataEntity);
			if (dublicateExist != null){
				m_itemDao.Save(itemDataEntity);
				m_view.Close();
			}else
				m_view.ShowError(string.Format("Item '{0}' already exist", itemDataEntity.Name));
		}
		
		public ItemDataEntity IsDublicateofExisting(ItemDataEntity newItemDataEntity){
			ItemDataEntity duplicateItemDataEntity = 
				m_itemDao.GetByName(newItemDataEntity.Name);
			return duplicateItemDataEntity;				
		}
		
		public void SetAllCategories(){
			List<ItemCategoryDataEntity> categories = m_itemCategoryDao.GetAllItems() as List<ItemCategoryDataEntity>;
			m_view.SetAllCategories(categories);			
		}
		
		public void SetAllGenerics(){
			List<ItemGenericDataEntity> generics = m_itemGenericDao.GetAllItems() as List<ItemGenericDataEntity>;
			m_view.SetAllGenerics(generics);
		}
		
		public void CancelClicked(){
			m_view.Close();
		}
	}
}

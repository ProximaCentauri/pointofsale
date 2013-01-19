﻿/*
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
using NJournals.Common;

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
		
		public AddItemPresenter(IAddItemView p_view, IItemDao p_itemDao)
		{
			m_view = p_view;
			m_itemDao = p_itemDao;
			
			ItemDataEntity itemDataEntity = m_itemDao.CreateItemDataEntity();
			ItemViewModel itemViewModel = new ItemViewModel(itemDataEntity);
			
			m_viewModel = itemViewModel;
			m_view.ShowItem(m_viewModel);
		}
	}
}
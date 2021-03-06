﻿/*
 * Created by SharpDevelop.
 * User: matt
 * Date: 1/19/2013
 * Time: 10:01 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NJournals.Common.ViewModels;
using System.Collections.Generic;
using NJournals.Common.DataEntities;
namespace NJournals.Common.Interfaces
{
	/// <summary>
	/// Description of IAddItemView.
	/// </summary>
	public interface IAddItemView
	{
		void ShowItem(ItemViewModel customerViewModel);
        void ReadUserInput();
        void ShowError(string message);
        void SetAllCategories(List<ItemCategoryDataEntity> categories);
        void SetAllGenerics(List<ItemGenericDataEntity> generics);
        void Close();
	}
}

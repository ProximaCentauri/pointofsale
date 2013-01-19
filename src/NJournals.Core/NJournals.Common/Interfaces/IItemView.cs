/*
 * Created by SharpDevelop.
 * User: matt
 * Date: 1/19/2013
 * Time: 10:52 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using NJournals.Common.ViewModels;
	
namespace NJournals.Common.Interfaces
{
	/// <summary>
	/// Description of IItemView.
	/// </summary>
	public interface IItemView
	{
		void ShowItems(IEnumerable<ItemViewModel> itemViewModelList);
	}
}

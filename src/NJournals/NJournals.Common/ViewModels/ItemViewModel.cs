/*
 * Created by SharpDevelop.
 * User: matt
 * Date: 1/19/2013
 * Time: 10:02 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NJournals.Common;
using System.Collections.Generic;
namespace NJournals.Common.ViewModels
{
	/// <summary>
	/// Description of ItemViewModel.
	/// </summary>
	public class ItemViewModel
	{
		
		private readonly ItemDataEntity m_itemDataEntity;
		public ItemViewModel(ItemDataEntity p_itemDataEntity)
		{
			this.m_itemDataEntity = p_itemDataEntity;
		}
		
		public int Barcode{
			get{return m_itemDataEntity.Barcode;}
			set{m_itemDataEntity.Barcode=value;}
		}
		
		public string Name{
			get{return m_itemDataEntity.Name;}
			set{m_itemDataEntity.Name=value;}
		}
		
		public List<ItemCategoryDataEntity> Categories{
			get{return m_itemDataEntity.Categories;}
			set{m_itemDataEntity.Categories=value;}
		}
		
		public List<ItemGenericDataEntity> Generics{
			get{return m_itemDataEntity.Generics;}
			set{m_itemDataEntity.Generics=value;}
		}
		
		public string Rack{
			get{return m_itemDataEntity.Rack;}
			set{m_itemDataEntity.Rack=value;}
		}
		
		public int Quantity{
			get{return m_itemDataEntity.Quantity;}
			set{m_itemDataEntity.Quantity=value;}
		}
		
		public double Price{
			get{return m_itemDataEntity.Price;}
			set{m_itemDataEntity.Price=value;}
		}
		
		public string MarkUp{
			get{return m_itemDataEntity.MarkUp;}
			set{m_itemDataEntity.MarkUp=value;}
		}
		
		public double SellingPrice{
			get{return m_itemDataEntity.SellingPrice;}
			set{m_itemDataEntity.SellingPrice=value;}
		}
		
		public string Unit{
			get{return m_itemDataEntity.Unit;}
			set{m_itemDataEntity.Unit=value;}
		}
		
		public ItemDataEntity ItemDataEntity{
			get{return m_itemDataEntity;}
		}
	}
}

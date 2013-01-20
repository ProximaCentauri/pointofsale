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
using NJournals.Common.DataEntities;
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
		
		public string Barcode{
			get{return m_itemDataEntity.Barcode;}
			set{m_itemDataEntity.Barcode=value;}
		}
		
		public string Name{
			get{return m_itemDataEntity.Name;}
			set{m_itemDataEntity.Name=value;}
		}
		
		public ItemCategoryDataEntity Category{
			get{return m_itemDataEntity.Category;}
			set{m_itemDataEntity.Category=value;}
		}
		
		public ItemGenericDataEntity Generic{
			get{return m_itemDataEntity.Generic;}
			set{m_itemDataEntity.Generic=value;}
		}
		
		/*public List<ItemCategoryDataEntity> Categories{
			get{return m_itemDataEntity.Categories;}
			set{m_itemDataEntity.Categories=value;}
		}
		
		public List<ItemGenericDataEntity> Generics{
			get{return m_itemDataEntity.Generics;}
			set{m_itemDataEntity.Generics=value;}
		}*/
		
		public string Rack{
			get{return m_itemDataEntity.Rack;}
			set{m_itemDataEntity.Rack=value;}
		}
		
		public int QtyStock{
			get{return m_itemDataEntity.QtyStock;}
			set{m_itemDataEntity.QtyStock=value;}
		}
		
		public double BuyPrice{
			get{return m_itemDataEntity.BuyPrice;}
			set{m_itemDataEntity.BuyPrice=value;}
		}
		
		public double Markup{
			get{return m_itemDataEntity.Markup;}
			set{m_itemDataEntity.Markup=value;}
		}
		
		public double SellPrice{
			get{return m_itemDataEntity.SellPrice;}
			set{m_itemDataEntity.SellPrice=value;}
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

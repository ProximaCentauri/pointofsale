/*
 * Created by SharpDevelop.
 * User: matt
 * Date: 1/19/2013
 * Time: 10:02 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
	
namespace NJournals.Common
{
	/// <summary>
	/// Description of ItemDataEntity.
	/// </summary>
	public class ItemDataEntity
	{
		public ItemDataEntity()
		{
		}
		
		int barcode;
		
		public int Barcode {
			get { return barcode; }
			set { barcode = value; }
		}
		string name;
		
		public string Name {
			get { return name; }
			set { name = value; }
		}
		List<ItemCategoryDataEntity> categories = new List<ItemCategoryDataEntity>();
		
		public List<ItemCategoryDataEntity> Categories {
			get { return categories; }
			set { categories = value; }
		}
		List<ItemGenericDataEntity> generics = new List<ItemGenericDataEntity>();
		
		public List<ItemGenericDataEntity> Generics {
			get { return generics; }
			set { generics = value; }
		}
		string rack;
		
		public string Rack {
			get { return rack; }
			set { rack = value; }
		}
		int quantity;
		
		public int Quantity {
			get { return quantity; }
			set { quantity = value; }
		}
		double price;
		
		public double Price {
			get { return price; }
			set { price = value; }
		}
		string markup;
		
		public string MarkUp {
			get { return markup; }
			set { markup = value; }
		}
		double sellingPrice;
		
		public double SellingPrice {
			get { return sellingPrice; }
			set { sellingPrice = value; }
		}
		string unit;
		
		public string Unit {
			get { return unit; }
			set { unit = value; }
		}
		
	}
}

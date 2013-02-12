﻿/*
 * Created by SharpDevelop.
 * User: user
 * Date: 2/10/2013
 * Time: 11:06 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NJournals.Common.Interfaces;
using NJournals.Core.Models;
using NJournals.Common.DataEntities;
using System.Collections.Generic;

namespace NJournals.Core.Presenter
{
	/// <summary>
	/// Description of RefillingConfigurationViewPresenter.
	/// </summary>
	public class RefillingConfigurationViewPresenter
	{
		IRefillingConfigurationView m_view;
		IRefillProductTypeDao m_productTypeDao;
		
		public RefillingConfigurationViewPresenter(IRefillingConfigurationView p_view)
		{
			this.m_view = p_view;
			this.m_productTypeDao = new RefillProductTypeDao();
		}
		
		public void SetAllRefillProductType()
		{
			List<RefillProductTypeDataEntity> productTypes = m_productTypeDao.GetAllItems() as List<RefillProductTypeDataEntity>;
			m_view.SetAllRefillProductType(productTypes);
		}
		
		public void SaveOrUpdateProductType(List<RefillProductTypeDataEntity> productTypes)
		{
			foreach(RefillProductTypeDataEntity productType in productTypes)
			{
				m_productTypeDao.SaveOrUpdate(productType);
			}
		}
		
		public void DeleteProductType(RefillProductTypeDataEntity productType)
		{
			m_productTypeDao.Delete(productType);
		}
	}
}
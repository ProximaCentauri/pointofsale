/*
 * Created by SharpDevelop.
 * User: vo185003
 * Date: 3/1/2013
 * Time: 8:57 PM
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
	/// Description of LaundryChargesViewPresenter.
	/// </summary>
	public class LaundryChargesViewPresenter
	{
		ILaundryChargesView m_view;
		ILaundryChargeDao m_laundryChargeDao;
		
		public LaundryChargesViewPresenter(ILaundryChargesView p_view)
		{
			this.m_view = p_view;
			m_laundryChargeDao = new LaundryChargeDao();
		}
		
		public void SetAllLaundryCharges()
		{
			List<LaundryChargeDataEntity> charges = m_laundryChargeDao.GetAllItems() as List<LaundryChargeDataEntity>;
			m_view.SetAllLaundryCharges(charges);
		}
		
		public void SaveOrUpdateCharge(List<LaundryChargeDataEntity> charges)
		{
			try
			{
				foreach(LaundryChargeDataEntity charge in charges)
				{
					m_laundryChargeDao.SaveOrUpdate(charge);
				}
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}		
	}
}

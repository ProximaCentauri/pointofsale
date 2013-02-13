/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 2/13/2013
 * Time: 11:44 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using NHibernate.Linq;
using NJournals.Common.DataEntities;

namespace NJournals.Common.Interfaces
{
	/// <summary>
	/// Description of ILaundryPaymentDetailDao.
	/// </summary>
	public interface ILaundryPaymentDetailDao
	{
		void SaveOrUpdate(LaundryPaymentDetailDataEntity p_payment);
		IEnumerable<LaundryPaymentDetailDataEntity> GetAllItems();
		
		void Delete(LaundryPaymentDetailDataEntity p_payment);
		void Update(LaundryPaymentDetailDataEntity p_payment);
	}
}

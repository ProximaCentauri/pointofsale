/*
 * Created by SharpDevelop.
 * User: vo185003
 * Date: 3/1/2013
 * Time: 8:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NJournals.Common.DataEntities;
using System.Collections.Generic;

namespace NJournals.Common.Interfaces
{
	/// <summary>
	/// Description of ILaundryChargesView.
	/// </summary>
	public interface ILaundryChargesView : IView
	{
		void SetAllLaundryCharges(List<LaundryChargeDataEntity> charges);
		void SetAllValidLaundryCharges(List<LaundryChargeDataEntity> charges);
	}
}

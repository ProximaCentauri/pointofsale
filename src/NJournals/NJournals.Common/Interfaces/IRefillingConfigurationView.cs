/*
 * Created by SharpDevelop.
 * User: user
 * Date: 2/10/2013
 * Time: 11:03 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NJournals.Common.DataEntities;
using System.Collections.Generic;

namespace NJournals.Common.Interfaces
{
	/// <summary>
	/// Description of IRefillingConfigurationView.
	/// </summary>
	public interface IRefillingConfigurationView : IView
	{
		void SetAllRefillProductType(List<RefillProductTypeDataEntity> products);
		void SetAllRefillInventory(List<RefillInventoryHeaderDataEntity> refillInvs);
	}
}

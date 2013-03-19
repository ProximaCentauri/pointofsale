/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 3/18/2013
 * Time: 8:10 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using NJournals.Common.DataEntities;
namespace NJournals.Common.LREventArgs
{
	/// <summary>
	/// Description of LaundryRefillEventArgs.
	/// </summary>
	public class LaundryRefillEventArgs
	{
		public LaundryRefillEventArgs()
		{
		}
	}
	
	public class ChecklistEventArgs : EventArgs{
		List<string> m_checklist = new List<string>();
		
		public List<string> Checklist {
			get { return m_checklist; }
			set { m_checklist = value; }
		}
		
		public ChecklistEventArgs(List<string> p_checklist){
			this.m_checklist = p_checklist;	
		}
	}
	
	public class ChargeListEventArgs : EventArgs{
		List<LaundryChargeDataEntity> m_charges = new List<LaundryChargeDataEntity>();
		
		public List<LaundryChargeDataEntity> Charges {
			get { return m_charges; }
			set { m_charges = value; }
		}
		
		public ChargeListEventArgs(List<LaundryChargeDataEntity> p_charges){
			this.m_charges = p_charges;
		}	
	}
}

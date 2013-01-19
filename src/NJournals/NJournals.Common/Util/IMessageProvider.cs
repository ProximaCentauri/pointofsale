/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 8/13/2012
 * Time: 9:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NJournals.Common.Util
{
	/// <summary>
	/// Description of IMessageProvider.
	/// </summary>
	public interface IMessageProvider
	{
	
		void ShowInfo(string message, string caption);
	
		void ShowError(string message, string caption);
	
		void ShowWarning(string message, string caption);
		bool ShowYesNo(string message, string caption);
	}
}

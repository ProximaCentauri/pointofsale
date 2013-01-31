/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 1/31/2013
 * Time: 3:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NJournals.Common.Interfaces
{
	/// <summary>
	/// Description of IView.
	/// </summary>
	public interface IView
	{
		event EventHandler TitleChanged;
		
		event EventHandler ViewClose;
		
		event EventHandler ViewShow;
		
		void ShowView();
		
		void CloseView();
		
		void SetTitle(string title);
		
		string GetTitle();
	}
}

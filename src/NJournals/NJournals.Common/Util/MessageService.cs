/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 8/13/2012
 * Time: 9:07 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NJournals.Common.Util
{
	/// <summary>
	/// Description of MessageService.
	/// </summary>
	public sealed class MessageService
	{
	
		public MessageService()
		{
		}
	
	
		static IMessageProvider provider;
		public static void Attach(IMessageProvider provider)
		{
			MessageService.provider = provider;
		}
	
		public static void ShowInfo(string message)
		{
			ShowInfo(message, "Information");
		}
	
		public static void ShowInfo(string message, string caption)
		{
			if (provider == null) {
				throw new ArgumentNullException("MessageProvider");
			}
			provider.ShowInfo(message, caption);
			LogHelper.Log(message, LogType.INFO, false);
		}
	
		public static void ShowError(string message, string caption, Exception ex)
		{
			if (provider == null) {
				throw new ArgumentNullException("MessageProvider");
			}
			provider.ShowError(message, caption);
			LogHelper.Log(ex.ToString(), LogType.ERR, false);
		}
	
		public static void ShowError(string message, Exception ex)
		{
			ShowError(message, "Error", ex);	
		}
	
		public static void ShowWarning(string message)
		{
			ShowWarning(message, "Warning");
		}
	
		public static void ShowWarning(string message, string caption)
		{
			if (provider == null) {
				throw new ArgumentNullException("MessageProvider");
			}
			provider.ShowWarning(message, caption);
			LogHelper.Log(message, LogType.WARNING, false);
		}
	
		public static bool ShowYesNo(string message)
		{
			return ShowYesNo(message, "Question");
		}
	
		public static bool ShowYesNo(string message, string caption)
		{
			if (provider == null) {
				throw new ArgumentNullException("MessageProvider");
			}
			return provider.ShowYesNo(message, caption);
		}
	}
}

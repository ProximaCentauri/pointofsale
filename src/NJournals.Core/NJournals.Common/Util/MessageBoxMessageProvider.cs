/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 8/13/2012
 * Time: 9:06 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace NJournals.Common.Util
{
	/// <summary>
	/// Description of MessageBoxMessageProvider.
	/// </summary>
	public class MessageBoxMessageProvider : IMessageProvider
	{
		public void ShowInfo(string message, string caption)
		{
			MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	
		public void ShowError(string message, string caption)
		{
			MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	
		public void ShowWarning(string message, string caption)
		{
			MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
	
		public bool ShowYesNo(string message, string caption)
		{
			return MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
		}
	}
}

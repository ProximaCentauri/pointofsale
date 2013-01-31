/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 1/31/2013
 * Time: 3:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using NJournals.Common.Interfaces;
namespace NJournals.Common.Gui
{
	/// <summary>
	/// Description of BaseForm.
	/// </summary>
	public partial class BaseForm : Form, IView
	{
		public BaseForm()
		{
			InitializeComponent();
		}
		
		delegate void StringEventHandler(string text);
		
		public event EventHandler TitleChanged;
		
		public event EventHandler ViewClose;
		
		public event EventHandler ViewShow;
		
		public void ShowView()
		{
			OnViewShow(null);
		}
		
		public virtual void CloseView()
		{
			OnViewClose(null);
		}
		
		public void SetTitle(string title)
		{
			if (InvokeRequired) {
				Invoke(new StringEventHandler(SetTitle), new object[] { title });
			} else {
				this.Text = title;
				OnTitleChanged(null);
			}
		}
		
		public string GetTitle()
		{
			return this.Text;
		}
		
		protected virtual void OnViewShow(EventArgs e)
		{
			if (ViewShow != null) {
				ViewShow(this, e);
			}
		}
		
		protected virtual void OnTitleChanged(EventArgs e)
		{
			if (TitleChanged != null) {
				TitleChanged(this, e);
			}
		}
		
		protected virtual void OnViewClose(EventArgs e)
		{
			if (ViewClose != null) {
				ViewClose(this, e);
			}
		}
	}
}

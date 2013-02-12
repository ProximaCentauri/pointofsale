/*
 * Created by SharpDevelop.
 * User: user
 * Date: 2/12/2013
 * Time: 8:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using NJournals.Common.Util;
using NJournals.Common.Gui;

namespace NJournals.Core.Views
{
	/// <summary>
	/// Description of RefillReturnPaymentView.
	/// </summary>
	public partial class RefillReturnPaymentView : BaseForm
	{
		public RefillReturnPaymentView()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void RefillReturnPaymentViewLoad(object sender, EventArgs e)
		{
			setButtonImages();
		}
		
		void setButtonImages()
		{			
			Resource.setImage(this.btnCustomerSearch, System.IO.Directory.GetCurrentDirectory() + "/images/search.png");
		}
	}
}

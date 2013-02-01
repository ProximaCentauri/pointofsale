/*
 * Created by SharpDevelop.
 * User: matt
 * Date: 1/19/2013
 * Time: 9:27 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using NJournals.Core.Presenter;
using NJournals.Common.Util;
namespace NJournals.Core
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			NHibernateHelper.OpenSession();
			MainFormStation mainFormStation = new MainFormStation();
			MainFormStationPresenter presenter = new MainFormStationPresenter(mainFormStation);
			Application.Run(mainFormStation);
		}
		
	}
}

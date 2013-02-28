/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/28/2013
 * Time: 11:47 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using NJournals.Common.DataEntities;
using System.Text;

namespace NJournals.Common.Util
{
	/// <summary>
	/// Description of PrintService.
	/// </summary>
	public sealed class PrintService
	{
		public PrintService()
		{
		}
		
		public static void Print()
		{
			
		}
		
		public static void PrintClaimSlip(LaundryHeaderDataEntity header)
		{
			// FIXME
			StringBuilder sb = new StringBuilder();
			sb.Append(Convert.ToChar(27) + "a" + Convert.ToChar(49));						
			sb.AppendLine("LAUNDRYPRO GARMENT CARE");
			sb.AppendLine("TETH'S SATELLITE MARKET");
			sb.AppendLine("M.L. QUEZON AVE. MAGUIKAY");
			sb.AppendLine("MANDAUE CITY");
			sb.AppendLine("# (032) 4127045 # (0906) 5429986");
			sb.AppendLine("");
			sb.AppendLine("");
			sb.AppendLine("CLAIM SLIP");
			sb.Append(Convert.ToChar(27) + "a" + Convert.ToChar(48));
			sb.AppendLine("SO#: 1234");
			sb.AppendLine("CUSTOMER: MAGIS");
			sb.AppendLine("DATE RECEIVED: " + DateTime.Now.Date);
			sb.AppendLine("DATE DUE: 1234" + DateTime.Now.Date);
			sb.AppendLine("");
			
			sb.AppendLine("#OF ITEMS" + Convert.ToChar(29) + "C" + Convert.ToChar(2) + Convert.ToChar(50)			             
			          + "KLS" + Convert.ToChar(9) + "ITEM" + Convert.ToChar(9) + "TOTAL");
			sb.AppendLine("27" + Convert.ToChar(9) + "5" + Convert.ToChar(9) + "WDFAG" + Convert.ToChar(9) +"135");
			sb.AppendLine("");
			sb.AppendLine("");
			sb.AppendLine("");
			sb.Append(Convert.ToChar(27) + "a" + Convert.ToChar(49));
			sb.AppendLine("27 ITEMS");
			sb.Append(Convert.ToChar(27) + "a" + Convert.ToChar(50));
			sb.AppendLine("TOTAL: 135");
			sb.AppendLine("DEPOSI: 100");
			sb.AppendLine("BALANCE: 35");
			sb.AppendLine("");
			sb.AppendLine("");
			sb.Append(Convert.ToChar(27) + "a" + Convert.ToChar(49));
			sb.AppendLine("THIS IS NOT AN OFFICIAL RECEIPT.");
			sb.AppendLine("");
			sb.AppendLine("WE THANK YOU FOR YOUR BUSINESS!");
			sb.AppendLine("");
			sb.AppendLine("");
			sb.Append(Convert.ToChar(29) + "V" + Convert.ToChar(66) + Convert.ToChar(0));			
			PrinterSettings ps = new PrinterSettings();
			ps.PrinterName = "POS80";
	    	// Allow the user to select a printer.
	    	//PrintDialog pd  = new PrintDialog();
	    	//pd.PrinterSettings = new PrinterSettings();
		  //  if( DialogResult.OK == pd.ShowDialog() )
		  //  {
		        // Send a printer-specific to the printer.
		        RawPrinterHelper.SendStringToPrinter(ps.PrinterName, sb.ToString());
		 //   }
		}
			
	}
}

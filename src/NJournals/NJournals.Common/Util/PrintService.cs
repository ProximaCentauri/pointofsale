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
using System.Collections.Generic;
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
		
		static PrinterSettings ps = null;
		private static void SetPrinter(short copies)
		{								
			foreach(string printer in PrinterSettings.InstalledPrinters)
			{
				if(printer.ToUpper().Equals("POS80"))
				{
					ps = new PrinterSettings();
					ps.PrinterName = "POS80";	
					ps.Copies = copies;					
					break;
				}
			}			  				    		
		}
		
		public static bool PrintLaundrySlip(LaundryHeaderDataEntity header, short copies)
		{
			try{
				SetPrinter(copies);
				if (ps == null) return false;
				
				StringBuilder sb = new StringBuilder();
				PrintClaimSlip(ref sb, header);			
				if(header.JobChecklistEntities.Count > 0)
				{
					PrintCheckList(ref sb, header);
				}
				
				RawPrinterHelper.SendStringToPrinter(ps.PrinterName, sb.ToString());
				
				sb = new StringBuilder();				
				PrintTag(ref sb, header);
				ps.Copies = 1;
				RawPrinterHelper.SendStringToPrinter(ps.PrinterName, sb.ToString());
				return true;				
			}
			catch(Exception ex)
			{
				throw ex;
			}			
		}
			
		public static bool PrintCheckList(LaundryHeaderDataEntity header, short copies)
		{
			try
			{
				SetPrinter(copies);
				if (ps == null) return false;
				
				StringBuilder sb = new StringBuilder();
				PrintCheckList(ref sb, header);
				RawPrinterHelper.SendStringToPrinter(ps.PrinterName, sb.ToString());
				return true;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		
		public static bool PrintRefillSlip(RefillHeaderDataEntity header, short copies)
		{
			try{
				SetPrinter(copies);
				if (ps == null) return false;
				
				StringBuilder sb = new StringBuilder();
				PrintRefillOrderSlip(ref sb, header);				
				
				RawPrinterHelper.SendStringToPrinter(ps.PrinterName, sb.ToString());								
				return true;				
			}
			catch(Exception ex)
			{
				throw ex;
			}			
		}
				
		
		private static void PrintClaimSlip(ref StringBuilder sb, LaundryHeaderDataEntity header)
		{						
			PrintHeader(ref sb);
			sb.Append(SetFontSize(2));
			sb.AppendLine("CLAIM SLIP");
			sb.Append(SetFontSize(0));
			sb.AppendLine("");
			sb.Append(SetAlignment("LEFT"));
			sb.AppendLine("SO#: " + header.LaundryHeaderID.ToString());
			sb.AppendLine("CUSTOMER: " + header.Customer.Name.ToUpper());
			sb.AppendLine("DATE RECEIVED: " + header.ReceivedDate.ToShortDateString());
			sb.AppendLine("DATE DUE: " + header.DueDate.ToShortDateString());
			sb.AppendLine("");
			
			sb.Append(Convert.ToChar(27) + "D" + Convert.ToChar(12));				
			sb.Append("#OF ITEMS" + Convert.ToChar(9) + "KLS" + Convert.ToChar(9) + "ITEM" + Convert.ToChar(9) + "TOTAL");				
			
			foreach(LaundryDetailDataEntity detail in header.DetailEntities)
			{
				string[] itemArr = detail.Service.Name.Split(' ');
				string item = "";
				foreach(string st in itemArr)
				{
					if(!st.Equals("-")){
					   	item += st.Substring(0,1); 
					}
				}
				item += "-";
				itemArr = detail.Category.Name.Split(' ');
				foreach(string st in itemArr){
					item += st.Substring(0,1);
				}
				
				sb.AppendLine(detail.ItemQty.ToString() + Convert.ToChar(9) +
				              detail.Kilo.ToString() + Convert.ToChar(9) +
				              item.ToUpper() + Convert.ToChar(9) +
				              detail.Amount.ToString("N2")) ;					
			}
			sb.AppendLine("");
			sb.AppendLine("");
			sb.Append(SetAlignment("CENTER"));
			sb.AppendLine(header.TotalItemQty.ToString() + " ITEMS");										
			sb.Append(SetAlignment("RIGHT"));
			sb.AppendLine("TOTAL: " + header.TotalAmountDue.ToString("N2"));
			sb.AppendLine("DEPOSIT: " + header.TotalPayment.ToString("N2"));
			sb.AppendLine("BALANCE: " + (header.TotalAmountDue - header.TotalPayment).ToString("N2"));
			PrintFooter(ref sb);
			sb.Append(CutPaper());	
									
		}
		
		private static void PrintTag(ref StringBuilder sb, LaundryHeaderDataEntity header)
		{
			sb.Append(SetAlignment("CENTER"));
			sb.Append(SetFontSize(3));
			sb.AppendLine(header.Customer.Name.ToUpper());
			sb.Append(SetFontSize(2));
			sb.AppendLine(header.LaundryHeaderID.ToString());
			sb.Append(SetFontSize(0));;
			sb.AppendLine("");
			sb.AppendLine("");
			sb.Append(CutPaper());
		}
				
		private static void PrintCheckList(ref StringBuilder sb, LaundryHeaderDataEntity header)
	    {
	      	sb.Append(SetAlignment("CENTER"));			
	      	sb.Append(SetFontSize(2));
	      	sb.AppendLine("CHECKLIST");	      		      	
	      	sb.Append(SetFontSize(0));
	      	sb.AppendLine("");
			sb.Append(SetAlignment("LEFT"));
			sb.AppendLine("SO#: " + header.LaundryHeaderID.ToString());
			sb.AppendLine("CUSTOMER: " + header.Customer.Name);			
			sb.AppendLine("");
			
			sb.Append(Convert.ToChar(27) + "D" + Convert.ToChar(12));				
			sb.Append("ITEM" + Convert.ToChar(9) + "QTY");
			
			foreach(LaundryJobChecklistDataEntity checklist in header.JobChecklistEntities)
			{				
				sb.AppendLine(checklist.Checklist.Name.ToUpper() + Convert.ToChar(9) +
				              checklist.Qty.ToString());							
			}
			sb.AppendLine("");
			sb.AppendLine("");
			sb.Append(SetAlignment("CENTER"));
			sb.AppendLine(header.TotalItemQty.ToString() + " ITEMS");	
			sb.AppendLine("");
			sb.AppendLine("******************************");
			sb.AppendLine("");
			sb.AppendLine("");
			sb.Append(CutPaper());	
	    }
		
		private static void PrintRefillOrderSlip(ref StringBuilder sb, RefillHeaderDataEntity header)
		{			
			PrintHeader(ref sb);
			sb.Append(SetFontSize(2));
			sb.AppendLine("ORDER SLIP");
			sb.Append(SetFontSize(0));
			sb.AppendLine("");			
			sb.Append(SetAlignment("LEFT"));
			sb.AppendLine("SO#: " + header.RefillHeaderID.ToString());
			sb.AppendLine("CUSTOMER: " + header.Customer.Name.ToUpper());
			sb.AppendLine("DATE RECEIVED: " + header.Date.ToShortDateString());
			sb.AppendLine("TRANSACTION TYPE: " + header.TransactionType.Name.ToUpper());			
			sb.AppendLine("");
			
			sb.Append(Convert.ToChar(27) + "D" + Convert.ToChar(12));				
			sb.Append("#OF ITEMS" + Convert.ToChar(9) + "ITEM" + Convert.ToChar(9) + "TOTAL");				
			
			int storebottle = 0;
			int storecap = 0;
			foreach(RefillDetailDataEntity detail in header.DetailEntities)
			{
				string[] itemArr = detail.ProductType.Name.Split(' ');
				string item = "";
				foreach(string st in itemArr)
				{
					item += st.Substring(0,1); 
				}			
				
				sb.AppendLine(detail.Qty.ToString() + Convert.ToChar(9) +				              
				              item.ToUpper() + Convert.ToChar(9) +
				              detail.Amount.ToString("N2")) ;	
				storebottle += detail.StoreBottleQty;
				storecap += detail.StoreCapQty;				
			}
			sb.AppendLine("");
			sb.AppendLine("");
			sb.Append(SetAlignment("CENTER"));
			sb.AppendLine(header.TotalQty.ToString() + " ITEMS");										
			sb.Append(SetAlignment("LEFT"));	
			sb.AppendLine("STORE BOTTLE: " + storebottle);
			sb.AppendLine("STORE CAP: " + storebottle);
			sb.AppendLine("");
			sb.Append(SetAlignment("RIGHT"));
			sb.AppendLine("");
			sb.AppendLine("TOTAL: " + header.AmountDue.ToString("N2"));
			sb.AppendLine("DEPOSIT: " + header.AmountTender.ToString("N2"));
			sb.AppendLine("BALANCE: " + (header.AmountDue - header.AmountTender).ToString("N2"));
			PrintFooter(ref sb);
			sb.Append(CutPaper());	
		}
		
		private static string SetAlignment(string align)
		{
			switch(align.ToUpper())
			{
				case "LEFT":
					return Convert.ToChar(27) + "a" + Convert.ToChar(48);
				case "RIGHT":
					return Convert.ToChar(27) + "a" + Convert.ToChar(50);
				case "CENTER":
					return Convert.ToChar(27) + "a" + Convert.ToChar(49);
			default:
				return Convert.ToChar(27) + "a" + Convert.ToChar(48); // align left
			}
		}
		
		private static string CutPaper()
		{
			return (Convert.ToChar(29) + "V" + Convert.ToChar(66) + Convert.ToChar(0));
		}
		
		private static string SetFontSize(short size)
		{
			switch(size)
			{
				case 0:
					return (Convert.ToChar(29) + "!" + Convert.ToChar(0));
				case 1:
					return (Convert.ToChar(29) + "!" + Convert.ToChar(16));
				case 2:
					return (Convert.ToChar(29) + "!" + Convert.ToChar(32));
				case 3:
					return (Convert.ToChar(29) + "!" + Convert.ToChar(48));
				case 4:
					return (Convert.ToChar(29) + "!" + Convert.ToChar(64));
				default:
					return (Convert.ToChar(29) + "!" + Convert.ToChar(0));
			}
		}
		
		private static void PrintHeader(ref StringBuilder sb)
		{
			sb.Append(SetAlignment("CENTER"));
			sb.AppendLine("LAUNDRYPRO GARMENT CARE");
			sb.AppendLine("TETH'S SATELLITE MARKET");
			sb.AppendLine("M.L. QUEZON AVE. MAGUIKAY");
			sb.AppendLine("MANDAUE CITY");
			sb.AppendLine("# (032) 4127045 # (0906) 5429986");
			sb.AppendLine("");
			sb.AppendLine("");
		}
		
		private static void PrintFooter(ref StringBuilder sb)
		{
			sb.AppendLine("");
			sb.AppendLine("");
			sb.Append(SetAlignment("CENTER"));
			sb.AppendLine("THIS IS NOT AN OFFICIAL RECEIPT.");
			sb.AppendLine("");
			sb.AppendLine("WE THANK YOU FOR YOUR BUSINESS!");
			sb.AppendLine("");
			sb.AppendLine("");
		}
	}
}

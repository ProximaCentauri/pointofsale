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
		private static void SetPrinter(PrinterDataEntity printer)
		{				
			// todo:			
			if(printer == null) return;
			
			ps = new PrinterSettings();
			ps.PrinterName = printer.Name;  		
			return;
		}
		
		public static bool PrintLaundrySlip(PrinterDataEntity printer, LaundryHeaderDataEntity header, CompanyDataEntity company)
		{
			try{
				SetPrinter(printer);
				if (ps == null) return false;
				
				StringBuilder sb = new StringBuilder();
				PrintClaimSlip(ref sb, header, company);							
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
			
		public static bool PrintCheckList(LaundryHeaderDataEntity header, PrinterDataEntity printer)
		{
			try
			{
				SetPrinter(printer);
				if (ps == null) return false;
				
				StringBuilder sb = new StringBuilder();
				sb.Append(SetAlignment("CENTER"));			
		      	sb.Append(SetFontSize(2));
		      	sb.AppendLine("CHECKLIST");	      		      	
		      	sb.Append(SetFontSize(0));
		      	sb.AppendLine("");
				sb.Append(SetAlignment("LEFT"));
				sb.AppendLine("SO#:      " + header.LaundryHeaderID.ToString());	
				sb.AppendLine("CUSTOMER: " + header.Customer.Name);			
				sb.AppendLine("DATE:     " + header.ReceivedDate.ToShortDateString());
				sb.AppendLine("");

				sb.Append(SetAlignment("CENTER"));				
				sb.Append("  ITEM               # OF ITEMS");
				sb.AppendLine("");				
				int qty = 0;
				foreach(LaundryJobChecklistDataEntity checklist in header.JobChecklistEntities)
				{											
					sb.AppendLine(SetAlignment("CENTER") + "  " + FormatStringAlignment(checklist.Checklist.Name.ToUpper(),"LEFT") + 
					              FormatStringAlignment(checklist.Qty.ToString(), "RIGHT"));
					qty += checklist.Qty;
				}
				sb.AppendLine("");
				sb.AppendLine("");
				sb.Append(SetAlignment("CENTER"));
				sb.AppendLine("LISTED "+ qty.ToString() +" of " +header.TotalItemQty.ToString() + " ITEMS");
				sb.AppendLine("");
				sb.AppendLine("******************************");
				sb.AppendLine("");
				sb.AppendLine("");
				sb.Append(CutPaper());	
				
				RawPrinterHelper.SendStringToPrinter(ps.PrinterName, sb.ToString());
				return true;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
		
		public static bool PrintRefillSlip(PrinterDataEntity printer, RefillHeaderDataEntity header, CompanyDataEntity company)
		{
			try{
				SetPrinter(printer);
				if (ps == null) return false;
				
				StringBuilder sb = new StringBuilder();
				PrintRefillOrderSlip(ref sb, header,company);				
				
				RawPrinterHelper.SendStringToPrinter(ps.PrinterName, sb.ToString());								
				return true;				
			}
			catch(Exception ex)
			{
				throw ex;
			}			
		}
				
		
		private static void PrintClaimSlip(ref StringBuilder sb, LaundryHeaderDataEntity header, CompanyDataEntity company)
		{									
			string[] itemArr;
			string item;
			
			PrintHeader(ref sb, company);
			sb.Append(SetFontSize(2));
			sb.AppendLine("CLAIM SLIP");
			sb.Append(SetFontSize(0));
			sb.AppendLine("");
			sb.Append(SetAlignment("LEFT"));
			sb.AppendLine("SO# :           " + header.LaundryHeaderID.ToString());
			sb.AppendLine("CUSTOMER :      " + header.Customer.Name.ToUpper());
			sb.AppendLine("DATE RECEIVED : " + header.ReceivedDate.ToShortDateString());
			sb.AppendLine("DATE DUE :      " + header.DueDate.ToShortDateString());
			sb.AppendLine("");
				
			sb.AppendLine("#OF ITEMS      KLS.        " + SetAlignment("RIGHT") + 
		         "ITEM           TOTAL");		
	
			foreach(LaundryDetailDataEntity detail in header.DetailEntities)
			{
				itemArr = detail.Service.Name.Split(' ');				
				item ="";
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
							
				sb.AppendLine(SetAlignment("LEFT") + "  " + FormatStringAlignment(detail.ItemQty.ToString(), "LEFT")  + FormatStringAlignment(detail.Kilo.ToString(),"LEFT"));
				sb.AppendLine(SetAlignment("RIGHT") + FormatStringAlignment(item,"RIGHT") + FormatStringAlignment(detail.Amount.ToString("N2"),"RIGHT"));
											
			}
			sb.AppendLine("");
			sb.AppendLine("");
			sb.Append(SetAlignment("CENTER"));
			sb.AppendLine(header.TotalItemQty.ToString() + " ITEMS");										
			sb.Append(SetAlignment("RIGHT"));
			sb.AppendLine("");
			sb.AppendLine("");				
			
			sb.AppendLine("  TOTAL: " + FormatStringAlignment(header.TotalAmountDue.ToString("N2"),"RIGHT"));
			sb.AppendLine("DEPOSIT: " + FormatStringAlignment(header.TotalPayment.ToString("N2"),"RIGHT"));
			sb.AppendLine("BALANCE: " + FormatStringAlignment((header.TotalAmountDue - header.TotalPayment).ToString("N2"),"RIGHT"));
			PrintFooter(ref sb);
			sb.Append(CutPaper());	
									
		}
		
		private static void PrintTag(ref StringBuilder sb, LaundryHeaderDataEntity header)
		{
			sb.Append(SetAlignment("CENTER"));
			sb.Append(SetFontSize(5));
			sb.AppendLine(header.Customer.Name.ToUpper());
			sb.Append(SetFontSize(4));
			sb.AppendLine(header.LaundryHeaderID.ToString());
			sb.Append(SetFontSize(0));;
			sb.AppendLine("");
			sb.AppendLine("");
			sb.Append(CutPaper());
		}					
		
		private static void PrintRefillOrderSlip(ref StringBuilder sb, RefillHeaderDataEntity header,CompanyDataEntity company)
		{			
			string[] itemArr;
			string item = "";
			
			PrintHeader(ref sb,company);
			sb.Append(SetFontSize(2));
			sb.AppendLine("ORDER SLIP");
			sb.Append(SetFontSize(0));
			sb.AppendLine("");			
			sb.Append(SetAlignment("LEFT"));
			sb.AppendLine("SO# :              " + header.RefillHeaderID.ToString());
			sb.AppendLine("CUSTOMER :         " + header.Customer.Name.ToUpper());
			sb.AppendLine("DATE RECEIVED :    " + header.Date.ToShortDateString());
			sb.AppendLine("TRANSACTION TYPE : " + header.TransactionType.Name.ToUpper());			
			sb.AppendLine("");
			
			sb.AppendLine("#OF ITEMS             " + SetAlignment("CENTER") + 
		         "ITEM             TOTAL");
			int storebottle = 0;
			int storecap = 0;
			foreach(RefillDetailDataEntity detail in header.DetailEntities)
			{
				itemArr = detail.ProductType.Name.Split(' ');
				item = "";
				foreach(string st in itemArr)
				{
					if(st.Equals("at")){						
						item += "@";
						continue;
					}
					item += st;
				}							
				sb.AppendLine(SetAlignment("LEFT") + "  " + FormatStringAlignment(detail.Qty.ToString(),"LEFT"));
				sb.AppendLine(SetAlignment("RIGHT") + FormatStringAlignment(item,"RIGHT") + FormatStringAlignment(detail.Amount.ToString("N2"),"LEFT"));				             			              		
				storebottle += detail.StoreBottleQty;
				storecap += detail.StoreCapQty;				
			}
			sb.AppendLine("");
			sb.AppendLine("");
			sb.Append(SetAlignment("CENTER"));
			sb.AppendLine(header.TotalQty.ToString() + " ITEMS");										
			sb.Append(SetAlignment("LEFT"));
			sb.AppendLine("");
			sb.AppendLine("   STORE CAP: " + storecap);			
			sb.AppendLine("STORE BOTTLE: " + storebottle);		
			sb.AppendLine("");
			sb.Append(SetAlignment("RIGHT"));
			
			sb.AppendLine("  TOTAL: " + FormatStringAlignment(header.AmountDue.ToString("N2"),"RIGHT"));
			sb.AppendLine("DEPOSIT: " + FormatStringAlignment(header.AmountTender.ToString("N2"),"RIGHT"));
			sb.AppendLine("BALANCE: " + FormatStringAlignment((header.AmountDue - header.AmountTender).ToString("N2"),"RIGHT"));
						
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
				case 5:
					return (Convert.ToChar(29) + "!" + Convert.ToChar(72));
				case 6:
					return (Convert.ToChar(29) + "!" + Convert.ToChar(88));
				default:
					return (Convert.ToChar(29) + "!" + Convert.ToChar(0));
			}
		}
		
		private static void PrintHeader(ref StringBuilder sb, CompanyDataEntity company)
		{
			sb.Append(SetAlignment("CENTER"));
			sb.Append(SetFontSize(1));
			sb.AppendLine(company.Name.ToUpper());
			sb.Append(SetFontSize(0));			
			
			string[] tempArr = company.Address.Split(' ');
			string address="";
			for(int i=0;i<tempArr.Length;i++)
			{
				address+=tempArr[i] + " ";
				if(i%3==0){
					sb.AppendLine(address.ToUpper());
					address="";
				}
			}						
			tempArr=null;
			tempArr = company.ContactNumber.Split(';');
			string contactNum="";
			for(int i=0;i<tempArr.Length;i++)
			{
				contactNum += "# " + tempArr[i] + " ";
			}
			sb.AppendLine(contactNum);
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
		
		private static string FormatStringAlignment(string temp, string align)
		{
			int cnt = 13;
			if(align == "RIGHT"){
				cnt = 18;
			}
			for(int i=temp.Length; i<cnt; i++)
			{			
				if(align == "RIGHT"){
					temp = " " + temp;					
				}
				else{
					temp += " ";
				}
			}	
			return temp;			
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NJournals.Common.Constants
{
    public static class ReportConstants
    {
		public const string  SALES_REPORT				        = "Sales Report";
		public const string UNCLAIMED_ITEMS_REPORT		        = "Unclaimed Items Report";
		public const string UNPAID_TRANSACTIONS_REPORT	        = "Unpaid Transactions Report";
		public const string CLAIMED_ITEMS_REPORT		        = "Claimed Items Report";	
		public const string INVENTORY_REPORT			        = "Inventory Report";
		
		public const string LAUNDRY_WINDOW				        = "Laundry Report";
		public const string REFILL_WINDOW				        = "Refilling Report";

        public const string DS_LAUNDRYDAYSUMMARY                = "NJournals_Common_DataEntities_LaundryDaySummaryDataEntity";
        public const string DS_LAUNDRYHEADER                    = "NJournals_Common_DataEntities_LaundryHeaderDataEntity";
        public const string ES_SALESREPORT                      = "NJournals.Core.Reports.SalesReport.rdlc";
        public const string ES_UNCLAIMED_ITEMS_REPORT           = "NJournals.Core.Reports.UnclaimedItemsReport.rdlc";
        public const string ES_LAUNDRYHEADER_SALESREPORT        = "NJournals.Core.Reports.SalesLaundryHeaderReport.rdlc";
    
			
    }
}

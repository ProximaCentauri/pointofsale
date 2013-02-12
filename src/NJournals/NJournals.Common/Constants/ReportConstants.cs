using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NJournals.Common.Constants
{
    public static class ReportConstants
    {
		public const string SALES_REPORT				        = "Sales Report";
		public const string UNCLAIMED_ITEMS_REPORT		        = "Unclaimed Items Report";
		public const string UNPAID_TRANSACTIONS_REPORT	        = "Unpaid Transactions Report";
		public const string CLAIMED_ITEMS_REPORT		        = "Claimed Items Report";	
		public const string INVENTORY_REPORT			        = "Inventory Report";
		public const string CUSTINVENTORY_REPORT				= "Customer Inventory Report";
			
		public const string LAUNDRY_WINDOW				        = "Laundry Report";
		public const string REFILL_WINDOW				        = "Refilling Report";

        public const string DS_LAUNDRYDAYSUMMARY                = "NJournals_Common_DataEntities_LaundryDaySummaryDataEntity";
        public const string DS_LAUNDRYHEADER                    = "NJournals_Common_DataEntities_LaundryHeaderDataEntity";
        public const string ES_LAUNDRY_SALES_REPORT             = "NJournals.Core.Reports.LaundrySalesReport.rdlc";
        public const string ES_LAUNDRY_UNCLAIMEDITEMS_REPORT    = "NJournals.Core.Reports.LaundryUnclaimedItemsReport.rdlc";
        public const string ES_LAUNDRY_CLAIMEDITEMS_REPORT      = "NJournals.Core.Reports.LaundryClaimedItemsReport.rdlc";
        public const string ES_LAUNDRY_UNPAIDTRANSACTIONS_REPORT= "NJournals.Core.Reports.LaundryUnpaidTransactionsReport.rdlc";

        
        public const string DS_REFILLDAYSUMMARY					= "NJournals_Common_DataEntities_RefillDaySummaryDataEntity";
        public const string DS_REFILLHEADER						= "NJournals_Common_DataEntities_RefillHeaderDataEntity";
        public const string DS_REFILLINVENTORY					= "NJournals_Common_DataEntities_RefillInventoryReportDataEntity";
        public const string DS_REFILLCUSTINVENTORY				= "NJournals_Common_DataEntities_RefillCustomerInventoryDataEntity";
        public const string ES_REFILL_SALES_REPORT              = "NJournals.Core.Reports.RefillSalesReport.rdlc";      
        public const string ES_REFILL_UNPAIDTRANSACTIONS_REPORT = "NJournals.Core.Reports.RefillUnpaidTransactionsReport.rdlc"; 	
        public const string ES_REFILL_INVENTORY_REPORT			= "NJournals.Core.Reports.RefillInventoryReport.rdlc";
        public const string ES_REFILL_CUSTINVENTORY_REPORT		= "NJournals.Core.Reports.RefillCustomerInventoryReport.rdlc";
    }
}

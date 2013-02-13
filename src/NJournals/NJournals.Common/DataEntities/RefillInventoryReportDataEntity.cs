/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/9/2013
 * Time: 12:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;


namespace NJournals.Common.DataEntities
{
    /// <summary>
    /// Description of RefillInventoryHeaderDataEntity.
    /// </summary>
    public class RefillInventoryReportDataEntity
    {
        public virtual string Name { get; set; }
        public virtual DateTime DayStamp { get; set; }
        public virtual int HeaderTotalQty { get; set; }
        public virtual int HeaderQtyOnHand { get; set; }
        public virtual int HeaderQtyReleased { get; set; }
        public virtual int TotalAdded { get; set; }
        public virtual int TotalRemoved { get; set; }
        public virtual int DetailQtyOnHand { get; set; }
        public virtual int DetailTotalQty { get; set; }
        public virtual int DetailQtyReleased { get; set; }
    }
}

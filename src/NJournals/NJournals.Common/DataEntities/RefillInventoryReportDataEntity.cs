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
        public virtual int TotalQty { get; set; }
        public virtual int QtyOnHand { get; set; }
        public virtual int QtyReleased { get; set; }
        public virtual int TotalAdded { get; set; }
        public virtual int TotalRemoved { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuoteFastMVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class CDC_WorkOrder_Products
    {
        public int WO_ProductID { get; set; }
        public Nullable<int> WorkOrderID { get; set; }
        public string BundleName { get; set; }
        public string Description { get; set; }
        public Nullable<double> Quantity { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<double> TotalHours { get; set; }
        public Nullable<double> Total { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ProductType { get; set; }
        public Nullable<bool> IsWorkOrderProduct { get; set; }
    }
}

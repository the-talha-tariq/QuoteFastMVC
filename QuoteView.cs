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
    
    public partial class QuoteView
    {
        public int QuoteID { get; set; }
        public string QuoteNumber { get; set; }
        public string QuoteHeader { get; set; }
        public string QuoteDescription { get; set; }
        public int CRM_CompanyID { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public int LastUser { get; set; }
        public Nullable<int> Status { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime ModifyDate { get; set; }
        public int SalesPerson1 { get; set; }
        public int CRM_BillingID { get; set; }
        public int CRM_ShippingID { get; set; }
        public string StatusText { get; set; }
        public string CompanyName { get; set; }
        public string LastUserName { get; set; }
        public string SalesPersonName { get; set; }
        public string SalesPersonName2 { get; set; }
        public Nullable<int> SalesPerson2 { get; set; }
        public string sitename { get; set; }
    }
}

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
    
    public partial class CDC_QuoteTerm
    {
        public int CDC_QuoteTermID { get; set; }
        public int QuoteID { get; set; }
        public Nullable<System.DateTime> TermStartDate { get; set; }
        public Nullable<System.DateTime> TermEndDate { get; set; }
        public Nullable<System.DateTime> SnowStartDate { get; set; }
        public Nullable<decimal> Markup { get; set; }
        public Nullable<int> Applications { get; set; }
        public Nullable<int> TotalAnnualCost { get; set; }
        public Nullable<int> SnowPmts { get; set; }
        public Nullable<int> SnowAmt { get; set; }
    
        public virtual CDC_Quote CDC_Quote { get; set; }
    }
}
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
    
    public partial class QuoteLog
    {
        public int LogID { get; set; }
        public int QuoteID { get; set; }
        public string Comment { get; set; }
        public string IP { get; set; }
        public Nullable<int> OldStatus { get; set; }
        public Nullable<int> NewStatus { get; set; }
        public string LastModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}

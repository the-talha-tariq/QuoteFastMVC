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
    
    public partial class QuoteData
    {
        public int QuoteDataID { get; set; }
        public Nullable<int> QuoteID { get; set; }
        public Nullable<int> QuoteColumnID { get; set; }
        public string Value { get; set; }
    
        public virtual Quote Quote { get; set; }
        public virtual QuoteColumn QuoteColumn { get; set; }
    }
}

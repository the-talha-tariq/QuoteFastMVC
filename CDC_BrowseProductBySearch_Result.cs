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
    
    public partial class CDC_BrowseProductBySearch_Result
    {
        public int CDC_ProductID { get; set; }
        public string VendorName { get; set; }
        public string VendorSKU { get; set; }
        public string ManufacturerName { get; set; }
        public string ManufacturerPartNumber { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<decimal> ListPrice { get; set; }
        public Nullable<decimal> SellPrice { get; set; }
        public Nullable<bool> TaxableCode { get; set; }
        public Nullable<double> LaborPerUnit { get; set; }
        public bool IsDefaultProduct { get; set; }
        public int CDC_DepartmentID { get; set; }
        public Nullable<bool> IsGuaranteed { get; set; }
        public string ProductType { get; set; }
        public string ClientDescription { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> LastModified { get; set; }
        public Nullable<int> DefaultItemTypeID { get; set; }
    }
}
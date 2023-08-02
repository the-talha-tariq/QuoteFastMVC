using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuoteFastMVC.Models
{
    public class SearchModel
    {
        public int QuoteID { get; set; }
        public string QuoteNumber { get; set; }
        public string QuoteHeader { get; set; }
        public string QuoteDescription { get; set; }
        public int CRM_CompanyID { get; set; }
        public int? IsDeleted { get; set; }
        public int LastUser { get; set; }
        public int Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public int SalesPerson1 { get; set; }
        public int CRM_BillingID { get; set; }
        public int CRM_ShippingID { get; set; }
        public string StatusText { get; set; }
        public string CompanyName { get; set; }
        public string LastUserName { get; set; }
        public string SalesPersonName { get; set; }
        public string SalesPersonName2 { get; set; }
        public int? SalesPerson2 { get; set; }
        public string SiteName { get; set; }
    }
}
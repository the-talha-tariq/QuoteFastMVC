using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuoteFastMVC.Models
{
    public class QuoteInformation
    {
        public int QuoteID { get; set; }
        public string QuoteHeader { get; set; }
        public string QuoteDescription { get; set; }
        public int? SalesPerson1 { get; set; }
        public int? SalesPerson2 { get; set; }
        public string SalesPerson1Name { get; set; }
        public string SalesPerson2Name { get; set; }
        public string OpeningDeclaration { get; set; }
        public int? Status { get; set; }
        public string StatusValue { get; set; }
        public int? CompanyAddressID { get; set; }
        public List<Address> CompanyAddressName { get; set; }
        public List<Address> SiteAddress { get; set; }
        public int CompanyNameID { get; set; }
        public string CompanyName { get; set; }
        public int? BidType { get; set; }
        public int? CrewSize { get; set; }
        public string PreferedMethod{ get; set; }
        public string IsCompanyTaxable { get; set; }
        public bool? ShowDollarTotals { get; set; }
        public int CRMShippingID { get; set; }
        public int CRMBillingID { get; set; }
        public List<int> CRMAddressID { get; set; }
        public string BillingName { get; set; }
        public string BillingAddress1 { get; set; }
        public string BillingAddress2 { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingZip { get; set; }
        public string BillingPhone { get; set; }
        public string BillingPhoneExtension { get; set; }
        public string BillingPhoneComments { get; set; }
        public string BillingEmail { get; set; }
        public string ShippingSiteName { get; set; }
        public string ShippingName { get; set; }
        public string ShippingAddress1 { get; set; }
        public string ShippingAddress2 { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingState { get; set; }
        public string ShippingZip { get; set; }
        public string ShippingPhone { get; set; }
        public string ShippingPhoneExtension { get; set; }
        public string ShippingPhoneComments { get; set; }
        public string ShippingEmail { get; set; }
        public string VerbalAcceptance { get; set; }
        public string TaxId { get; set; }
    }
}
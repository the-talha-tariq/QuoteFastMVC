using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuoteFastMVC.Models
{
    public class Address
    {
        public int CRMAddressID { get; set; }
        public int CRMComapnyID { get; set; }
        public string ContactName { get; set; }
        public string FullAddress { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string PhoneExtension { get; set; }
        public string PhoneExtension2 { get; set; }
        public string Email { get; set; }
        public string SiteName { get; set; }
        public bool? IsActive { get; set; }
        public string ContactComments { get; set; }
    }
}
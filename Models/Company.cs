using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace QuoteFastMVC.Models
{
    public class Company
    {

        public string Name { get; set; }
        public int CompanyID { get; set; }
        public int LicenseID { get; set; }
        public bool Taxable { get; set; }
        public string TaxIDNumber { get; set; }
        public bool? IsActive { get; set; }
        public int? OwnerID { get; set; }
        public bool LockBox { get; set; }
    }
}
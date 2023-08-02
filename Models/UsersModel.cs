using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuoteFastMVC.Models
{
    public class UsersModel
    {
        public int UserID { get; set; }
        public int LicenseeID { get; set; }
        public string Aspnet_UserId{ get; set; }
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public string EmailAddres{ get; set; }
        public string CDC_SalesCode{ get; set; }
        public string Address{ get; set; }
        public string City{ get; set; }
        public string Zip{ get; set; }
        public string State{ get; set; }
        public string Phone{ get; set; }
        public string Fax{ get; set; }
        public string Branch{ get; set; }
        public string Position{ get; set; }
        public string SignatureImageLocation{ get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}
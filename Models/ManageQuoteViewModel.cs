using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuoteFastMVC.Models
{
    public class ManageQuoteViewModel
    {
        public IList<Company> Companies { get; set; }
        public IList<Address> Addresses { get; set; }
        public IList<UsersModel> Users1{ get; set; }
        public IList<UsersModel> Users2{ get; set; }
        public IList<SearchModel> SearchModels { get; set; }
    }
}
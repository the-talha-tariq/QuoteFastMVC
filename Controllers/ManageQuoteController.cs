using QuoteFastMVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuoteFastMVC.Controllers
{
    public class ManageQuoteController : Controller
    {
        // GET: ManageQuote
        public ActionResult Index()
        {
            ManageQuoteViewModel vmlist = new ManageQuoteViewModel();

            List<Company> companyList = new List<Company>();
            List<UsersModel> userList = new List<UsersModel>();

            using (QuoteFastEntities db = new QuoteFastEntities())
            {
                var data = db.CRM_Company.ToList();

                foreach (var item in data)
                {
                    Company company = new Company();
                    company.CompanyID = item.CRMCompanyID;
                    company.LicenseID = item.LicenseeID;
                    company.Name = item.CompanyName;
                    company.Taxable = item.Taxable;
                    company.IsActive = item.IsActive;
                    company.OwnerID = item.OwnerUserID;
                    company.TaxIDNumber = item.TaxIDNumber;
                    companyList.Add(company);
                }
                var data2 = db.Users.ToList();
                foreach (var item2 in data2)
                {
                    UsersModel user = new UsersModel();
                    user.UserID = item2.UserID;
                    user.LicenseeID = item2.LicenseeID;
                    ////user.Aspnet_UserId = item2.aspnet_UserId;
                    user.FirstName = item2.FirstName;
                    user.LastName = item2.LastName;
                    user.EmailAddres = item2.EmailAddress;
                    user.CDC_SalesCode = item2.CDC_SalesCode;
                    user.Address = item2.Address;
                    user.City = item2.City;
                    user.Zip = item2.Zip;
                    user.State = item2.State;
                    user.Phone = item2.Phone;
                    user.Fax = item2.Fax;
                    user.Branch = item2.Branch;
                    user.Position = item2.Position;
                    user.SignatureImageLocation = item2.signatureImageLocation;
                    userList.Add(user);
                }

                vmlist.Users1 = userList;
                vmlist.Users2 = userList;
                vmlist.Companies = companyList;
                vmlist.Addresses = new List<Address>();
                vmlist.SearchModels = new List<SearchModel>();
                //if (TempData["criteria"] != null)
                //{
                //    var criteriaPass = new SqlParameter("@criteria", TempData["criteria"].ToString());
                //    var UserId = new SqlParameter("@UserId", 1);
                //    var result = db.Database.SqlQuery<SearchModel>("EXEC CDC_BrowseQuoteBySearchNew @criteria,@UserId", criteriaPass, UserId).ToList();
                //    vmlist.SearchModels = result;
                //}
            }
            return View(vmlist);
        }

        [HttpPost]
        public ActionResult GetSite(int id)
        {
            ManageQuoteViewModel vmlist = new ManageQuoteViewModel();
            List<Address> addressList = new List<Address>();
            QuoteFastEntities db = new QuoteFastEntities();
            if (id != -1)
            {
                List<CRM_Address> crm_address = db.CRM_Address.Where(x => x.CRMCompanyID == id).ToList();
                if(crm_address != null)
                {
                    foreach (var item in crm_address)
                    {
                        Address address = new Address();
                        address.CRMAddressID = item.CRMAddressID;
                        address.CRMComapnyID = item.CRMCompanyID;
                        address.ContactName = item.ContactName;
                        address.Address1 = item.Address1;
                        address.Address2 = item.Address2;
                        address.City = item.City;
                        address.State = item.State;
                        address.Zip = item.Zip;
                        address.Phone = item.Phone;
                        address.PhoneExtension = item.Phone2Extension;
                        address.Email = item.Email;
                        address.SiteName = item.SiteName;
                        address.IsActive = item.IsActive;
                        address.ContactComments = item.ContactComments;
                        addressList.Add(address);
                    }
                }
            }
            return Json(addressList, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult Search(string Companies, string Addresses, string Users1, string Users2, string quoteNumber, string quoteHeader, string status, string age)
        {
            ManageQuoteViewModel vmlist = new ManageQuoteViewModel();
            DateTime newdt = new DateTime();
            string criteria = "";
            //Companies
            if (Companies != "")
            {
                criteria = "where CRM_CompanyID =" + Companies;
            }
            //quoteNumber
            if (quoteNumber != "")
            {
                if (!string.IsNullOrEmpty(criteria))
                {
                    criteria = criteria + " and QuoteNumber like '%" + quoteNumber + "%'";
                }
                else
                {
                    criteria = "where QuoteNumber like '%" + quoteNumber + "%'";
                }
            }
            //Users1
            if (Users1 != "")
            {
                if (!string.IsNullOrEmpty(criteria))
                {
                    criteria = criteria + " and SalesPerson1 ='" + Users1 + "'";
                }
                else
                {
                    criteria = "where SalesPerson1 ='" + Users1 + "'";
                }
            }
            //Users2
            if (Users2 != "")
            {
                if (!string.IsNullOrEmpty(criteria))
                {
                    criteria = criteria + " and SalesPerson2 ='" + Users2 + "'";
                }
                else
                {
                    criteria = "where SalesPerson2 ='" + Users2 + "'";
                }
            }
            //status
            if (status != "")
            {
                if (!string.IsNullOrEmpty(criteria))
                {
                    if (status == "124")
                    {
                        criteria = criteria + " and Status in (1,2,4)";
                    }
                    else if (status == "1234")
                    {
                        criteria = criteria + " and Status in (1,2,3,4)";
                    }
                    else
                        criteria = criteria + " and Status ='" + status + "'";
                }
                else
                {
                    if (status == "124")
                    {
                        criteria = "where Status in (1,2,4)";
                    }
                    else if (status == "1234")
                    {
                        criteria = "where Status in (1,2,3,4)";
                    }
                    else
                        criteria = "where Status ='" + status + "'";
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(criteria))
                {
                    criteria = criteria + " and Status in (1,2,3,4)";
                }
                else
                {
                    criteria = "where Status in (1,2,3,4)";
                }
            }
            //age
            if (age == "30")
            {
                newdt = DateTime.Now.AddDays(-30);
            }
            else if (age == "60")
            {
                newdt = DateTime.Now.AddDays(-60);
            }
            else if (age == "90")
            {
                newdt = DateTime.Now.AddDays(-90);
            }
            else if (age == "365")
            {
                DateTime date = DateTime.Now.AddDays(-365);
                newdt = date;
            }

            if (!string.IsNullOrEmpty(criteria))
            {
                if (age == "4")
                {

                }
                else
                    criteria = criteria + " and ModifyDate >='" + newdt + "'";
            }
            else
            {
                if (age == "4")
                {

                }
                else
                    criteria = "where ModifyDate >='" + newdt + "'";
            }
            //quoteHeader
            if (!string.IsNullOrEmpty(quoteHeader))
            {
                if (!string.IsNullOrEmpty(criteria))
                {
                    criteria = criteria + " and QuoteHeader like '%" + quoteHeader + "%'";
                }
                else
                {
                    criteria = "where QuoteHeader like '%" + quoteHeader + "%'";
                }
            }


            if (!string.IsNullOrEmpty(criteria))
            {
                criteria = criteria + " and (IsDeleted is null or IsDeleted <> 1)";
            }
            else
            {
                criteria = "where (IsDeleted is null or IsDeleted <> 1)";
            }
            //Addresses
            if (Addresses != "")
            {
                if (!string.IsNullOrEmpty(criteria))
                {
                    criteria = criteria + " and CRM_ShippingID ='" + Addresses + "'";
                }
                else
                {
                    criteria = "where CRM_ShippingID ='" + Addresses + "'";
                }
            }
            //TempData["criteria"] = criteria;
            QuoteFastEntities db = new QuoteFastEntities();
            var criteriaPass = new SqlParameter("@criteria", criteria);
            var UserId = new SqlParameter("@UserId", 1);
            var result = db.Database.SqlQuery<SearchModel>("EXEC CDC_BrowseQuoteBySearchNew @criteria,@UserId", criteriaPass, UserId).ToList();
            vmlist.SearchModels = result;
            return PartialView("_SearchResult",vmlist);
        }
        public ActionResult Edit(int id)
        {   
            QuoteFastEntities db = new QuoteFastEntities();
            var quote=db.CDC_Quote.Where(x => x.QuoteID == id).ToList();
            List<QuoteInformation> quoteInfoList = new List<QuoteInformation>();
            List<Company> companyList = new List<Company>();
            List<UsersModel> userList = new List<UsersModel>();
            QuoteInformationViewModel vmquotelist = new QuoteInformationViewModel();
            foreach (var item in quote)
            {
                QuoteInformation quoteInfo = new QuoteInformation();
                quoteInfo.QuoteID = item.QuoteID;
                quoteInfo.QuoteHeader = item.QuoteHeader;
                quoteInfo.QuoteDescription = item.QuoteDescription;
                quoteInfo.SalesPerson1 = item.SalesPerson1;
                var user = db.Users.Where(x => x.UserID == quoteInfo.SalesPerson1).ToList();
                foreach (var name1 in user)
                {
                    if (user != null)
                    {
                        string firstName = name1.FirstName;
                        string lastName = name1.LastName;
                        quoteInfo.SalesPerson1Name = firstName + " " + lastName;
                    }
                }
                quoteInfo.SalesPerson2 = item.SalesPerson2;
                var user2 = db.Users.Where(x => x.UserID == quoteInfo.SalesPerson2).ToList();
                foreach (var name2 in user2)
                {
                    if (user2 != null)
                    {
                        string firstName = name2.FirstName;
                        string lastName = name2.LastName;
                        quoteInfo.SalesPerson2Name = firstName + " " + lastName;
                    }
                }
                quoteInfo.Status = item.Status;
                if(quoteInfo.Status==1)
                {
                    quoteInfo.StatusValue = "New/InUse";
                }
                else if(quoteInfo.Status==2)
                {
                    quoteInfo.StatusValue = "Send To Client";
                }
                else if(quoteInfo.Status==3)
                {
                    quoteInfo.StatusValue = "Accepted";
                }
                else if (quoteInfo.Status == 4)
                {
                    quoteInfo.StatusValue = "Rejected";
                }
                quoteInfo.CompanyNameID = item.CRM_CompanyID;
                var companyName = db.CRM_Company.Where(x => x.CRMCompanyID == quoteInfo.CompanyNameID).ToList();
                foreach (var cname in companyName)
                {
                    quoteInfo.CompanyName = cname.CompanyName;
                }
                quoteInfo.CompanyAddressID = item.CRM_CompanyID;
                List<CRM_Address> crm_address = db.CRM_Address.Where(x => x.CRMCompanyID == quoteInfo.CompanyAddressID).ToList();
                quoteInfo.CompanyAddressName = new List<Address>();
                foreach (var list in crm_address)
                {
                    Address addresses = new Address();
                    addresses.FullAddress = quoteInfo.CompanyName +" - " + list.ContactName;
                    addresses.CRMAddressID = list.CRMAddressID;
                    addresses.ContactName = list.ContactName;
                    addresses.Address1 = list.Address1;
                    addresses.Address2 = list.Address2;
                    addresses.City = list.City;
                    addresses.State = list.State;
                    addresses.Zip = list.Zip;
                    addresses.Phone = list.Phone;
                    addresses.Phone2 = list.Phone2;
                    addresses.PhoneExtension = list.PhoneExtension;
                    addresses.PhoneExtension2 = list.Phone2Extension;
                    addresses.ContactComments = list.ContactComments;
                    addresses.Email = list.Email;
                    quoteInfo.CompanyAddressName.Add(addresses);
                }
                quoteInfo.OpeningDeclaration = item.OpeningDeclaration;
                quoteInfo.BidType = item.CDC_BidType;
                quoteInfo.CrewSize = item.CDC_CrewSize;
                quoteInfo.ShowDollarTotals = item.ShowDollarTotals;
                quoteInfo.CRMBillingID = item.CRM_BillingID;
                quoteInfo.CRMShippingID = item.CRM_ShippingID;
                quoteInfo.BillingName = item.BillingName;
                quoteInfo.BillingAddress1 = item.BillingAddress1;
                quoteInfo.BillingAddress2 = item.BillingAddress2;
                quoteInfo.BillingCity = item.BillingCity;
                quoteInfo.BillingState = item.BillingState;
                quoteInfo.BillingZip = item.BillingZip;
                quoteInfo.BillingPhone = item.BillingPhone;
                quoteInfo.BillingPhoneExtension = item.BillingPhoneExtension;
                quoteInfo.BillingPhoneComments = item.BillingPhoneComments;
                quoteInfo.ShippingSiteName = item.SiteName;
                quoteInfo.ShippingName = item.ShippingName;
                quoteInfo.ShippingAddress1 = item.ShippingAddress1;
                quoteInfo.ShippingAddress2 = item.ShippingAddress2;
                quoteInfo.ShippingCity = item.ShippingCity;
                quoteInfo.ShippingEmail = item.ShippingEmail;
                quoteInfo.ShippingState = item.ShippingState;
                quoteInfo.ShippingZip = item.ShippingZip;
                quoteInfo.ShippingPhone = item.ShippingPhone;
                quoteInfo.ShippingPhoneComments = item.ShippingPhoneComments;
                quoteInfo.ShippingPhoneExtension = item.ShippingPhoneExtension;
                var addressIdList = db.CRM_Address.Where(x => x.CRMCompanyID == quoteInfo.CompanyNameID).ToList();
                quoteInfo.CRMAddressID = new List<int>();
                foreach (var addressList in addressIdList)
                {
                    var add = addressList.CRMAddressID;
                    quoteInfo.CRMAddressID.Add(add);
                }
                quoteInfoList.Add(quoteInfo);
            }

            var data = db.CRM_Company.ToList();
            foreach (var item in data)
            {
                Company company = new Company();
                company.CompanyID = item.CRMCompanyID;
                company.LicenseID = item.LicenseeID;
                company.Name = item.CompanyName;
                company.Taxable = item.Taxable;
                company.IsActive = item.IsActive;
                company.OwnerID = item.OwnerUserID;
                company.TaxIDNumber = item.TaxIDNumber;
                companyList.Add(company);
            }

            var data2 = db.Users.ToList();
            foreach (var item2 in data2)
            {
                UsersModel user = new UsersModel();
                user.UserID = item2.UserID;
                user.LicenseeID = item2.LicenseeID;
                ////user.Aspnet_UserId = item2.aspnet_UserId;
                user.FirstName = item2.FirstName;
                user.LastName = item2.LastName;
                user.EmailAddres = item2.EmailAddress;
                user.CDC_SalesCode = item2.CDC_SalesCode;
                user.Address = item2.Address;
                user.City = item2.City;
                user.Zip = item2.Zip;
                user.State = item2.State;
                user.Phone = item2.Phone;
                user.Fax = item2.Fax;
                user.Branch = item2.Branch;
                user.Position = item2.Position;
                user.SignatureImageLocation = item2.signatureImageLocation;
                userList.Add(user);
            }
            vmquotelist.QuoteInformations = quoteInfoList;
            vmquotelist.Users1 = userList;
            vmquotelist.Users2= userList;
            vmquotelist.Companies=companyList;
            return View(vmquotelist);
        }
        [HttpPost]
        public ActionResult Save(QuoteInformationViewModel model,string Users1,string Users2,string bidType,string preferedWay,bool? showDollar,string taxId,string Companies)
        {
            QuoteFastEntities db = new QuoteFastEntities();
            var quoteInfo = model.QuoteInformations[0];
            //var saveList = db.CDC_Quote.Where(x => x.QuoteID == quoteInfo.QuoteID).ToList();
            var item = db.CDC_Quote.FirstOrDefault(x => x.QuoteID == quoteInfo.QuoteID);
            //foreach (var item in saveList)
            //{
                
                item.QuoteHeader = quoteInfo.QuoteHeader;
                item.QuoteDescription = quoteInfo.QuoteDescription;
                if(Users1!="")
                {
                    item.SalesPerson1 = Convert.ToInt32(Users1);
                }
                if (Users2 != "")
                {
                    item.SalesPerson2 = Convert.ToInt32(Users2);
                }
                item.OpeningDeclaration = quoteInfo.OpeningDeclaration;
                item.CDC_BidType = Convert.ToInt32(bidType);
                item.CDC_CrewSize = quoteInfo.CrewSize;
                item.PmCommunication = preferedWay;
                if(showDollar==null)
                {
                    item.ShowDollarTotals = false;
                }
                else
                {
                    item.ShowDollarTotals = showDollar;
                }
                item.TaxIDNumber = taxId;
                item.CRM_BillingID = quoteInfo.CRMBillingID;
                if(quoteInfo.CRMShippingID==-4)
                {
                    item.CRM_ShippingID = quoteInfo.CRMBillingID;
                }
                item.BillingName = quoteInfo.BillingName;
                item.BillingAddress1 = quoteInfo.BillingAddress1;
                item.BillingAddress2 = quoteInfo.BillingAddress2;
                item.BillingCity = quoteInfo.BillingCity;
                item.BillingState = quoteInfo.BillingState;
                item.BillingZip = quoteInfo.BillingZip;
                item.BillingPhone = quoteInfo.BillingPhone;
                item.BillingPhoneExtension = quoteInfo.BillingPhoneExtension;
                item.BillingPhoneComments = quoteInfo.BillingPhoneComments;
                item.SiteName = quoteInfo.ShippingSiteName;
                item.ShippingName = quoteInfo.ShippingName;
                item.ShippingAddress1 = quoteInfo.ShippingAddress1;
                item.ShippingAddress2 = quoteInfo.ShippingAddress2;
                item.ShippingCity = quoteInfo.ShippingCity;
                item.ShippingEmail = quoteInfo.ShippingEmail;
                item.ShippingState = quoteInfo.ShippingState;
                item.ShippingZip = quoteInfo.ShippingZip;
                item.ShippingPhone = quoteInfo.ShippingPhone;
                item.ShippingPhoneComments = quoteInfo.ShippingPhoneComments;
                item.ShippingPhoneExtension = quoteInfo.ShippingPhoneExtension;
                if (Companies != "")
                {
                    item.CRM_CompanyID = Convert.ToInt32(Companies);
                }
                db.SaveChanges();
            //}
            

            return RedirectToAction("Index");
        }
    }
}
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
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.CDC_Quote = new HashSet<CDC_Quote>();
            this.CDC_Quote1 = new HashSet<CDC_Quote>();
            this.CDC_Quote2 = new HashSet<CDC_Quote>();
            this.CDC_SecretaryRelationship = new HashSet<CDC_SecretaryRelationship>();
            this.CDC_SecretaryRelationship1 = new HashSet<CDC_SecretaryRelationship>();
            this.CRM_Address = new HashSet<CRM_Address>();
            this.CRM_Company = new HashSet<CRM_Company>();
            this.UserLicenseAgreements = new HashSet<UserLicenseAgreement>();
        }
    
        public int UserID { get; set; }
        public int LicenseeID { get; set; }
        public System.Guid aspnet_UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string CDC_SalesCode { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string State { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Branch { get; set; }
        public string Position { get; set; }
        public string signatureImageLocation { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CDC_Quote> CDC_Quote { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CDC_Quote> CDC_Quote1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CDC_Quote> CDC_Quote2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CDC_SecretaryRelationship> CDC_SecretaryRelationship { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CDC_SecretaryRelationship> CDC_SecretaryRelationship1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRM_Address> CRM_Address { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRM_Company> CRM_Company { get; set; }
        public virtual Licensee Licensee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserLicenseAgreement> UserLicenseAgreements { get; set; }
    }
}

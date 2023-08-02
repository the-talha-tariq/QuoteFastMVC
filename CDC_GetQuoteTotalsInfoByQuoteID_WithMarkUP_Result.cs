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
    
    public partial class CDC_GetQuoteTotalsInfoByQuoteID_WithMarkUP_Result
    {
        public int QuoteID { get; set; }
        public string QuoteNumber { get; set; }
        public int QuoteNumberCounter { get; set; }
        public int CRM_CompanyID { get; set; }
        public string QuoteHeader { get; set; }
        public string OpeningDeclaration { get; set; }
        public int SalesPerson1 { get; set; }
        public Nullable<int> SalesPerson2 { get; set; }
        public int LastUser { get; set; }
        public int CRM_BillingID { get; set; }
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
        public int CRM_ShippingID { get; set; }
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
        public System.DateTime CreateDate { get; set; }
        public System.DateTime ModifyDate { get; set; }
        public System.DateTime ExpirationDate { get; set; }
        public Nullable<decimal> ShippingCost { get; set; }
        public Nullable<double> Discount { get; set; }
        public Nullable<double> TaxRate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> Status { get; set; }
        public string InternalComments { get; set; }
        public Nullable<bool> ShowDollarTotals { get; set; }
        public Nullable<double> CDC_MaintenanceRate { get; set; }
        public Nullable<double> CDC_FlowersRate { get; set; }
        public Nullable<double> CDC_LandscapeRate { get; set; }
        public Nullable<int> CDC_QuoteType { get; set; }
        public Nullable<double> CDC_SalesAllocationPct { get; set; }
        public Nullable<double> CDC_DefaultMarkupRate { get; set; }
        public Nullable<int> CDC_CrewSize { get; set; }
        public Nullable<double> CDC_CleanupInefficiencyRate { get; set; }
        public Nullable<double> CDC_TravelTimeRate { get; set; }
        public Nullable<double> CDC_NurseryRate { get; set; }
        public Nullable<double> CDC_TractorRate { get; set; }
        public Nullable<int> CDC_BidType { get; set; }
        public Nullable<int> CDC_AccountStatus { get; set; }
        public Nullable<double> CDC_DesignFeeRate { get; set; }
        public double CDC_ExtraFeeRate { get; set; }
        public Nullable<double> CDC_TotalMarkupRate { get; set; }
        public Nullable<int> CDC_NumApplications { get; set; }
        public Nullable<System.DateTime> LastModified { get; set; }
        public Nullable<bool> CDC_ExtraFeeInc { get; set; }
        public Nullable<bool> IncludeOptionalItems { get; set; }
        public string CDC_NumApplicationsText { get; set; }
        public string CDC_PerApplicationText { get; set; }
        public string CDC_AdditionalItemsText { get; set; }
        public Nullable<double> CDC_Cleanup_Hrs { get; set; }
        public Nullable<double> CDC_Travel_Hrs { get; set; }
        public Nullable<double> CDC_Nursery_Hrs { get; set; }
        public Nullable<double> CDC_Tractor_Hrs { get; set; }
        public Nullable<double> CDC_Yards_Debris { get; set; }
        public double CDC_YardsDebrisRate { get; set; }
        public Nullable<bool> ShowBundlePrices { get; set; }
        public Nullable<System.DateTime> SentToClientDate { get; set; }
        public string CDC_MiscText1 { get; set; }
        public Nullable<decimal> CDC_MiscValue1 { get; set; }
        public string CDC_MiscText2 { get; set; }
        public Nullable<decimal> CDC_MiscValue2 { get; set; }
        public string CDC_MiscText3 { get; set; }
        public Nullable<decimal> CDC_MiscValue3 { get; set; }
        public double CDC_DefaultSubcontractMarkupRate { get; set; }
        public Nullable<double> CDC_LawncareRate { get; set; }
        public Nullable<double> CDC_SnowRate { get; set; }
        public string SiteName { get; set; }
        public Nullable<double> CDC_Chipper_Hrs { get; set; }
        public Nullable<double> CDC_ChipperRate { get; set; }
        public Nullable<int> CDC_RateCategoryID { get; set; }
        public Nullable<int> BillingPhoneTypeID { get; set; }
        public string BillingPhone2 { get; set; }
        public string BillingPhone2Extension { get; set; }
        public string BillingPhone2Comments { get; set; }
        public Nullable<int> BillingPhone2TypeID { get; set; }
        public Nullable<int> ShippingPhoneTypeID { get; set; }
        public string ShippingPhone2 { get; set; }
        public string ShippingPhone2Extension { get; set; }
        public string ShippingPhone2Comments { get; set; }
        public Nullable<int> ShippingPhone2TypeID { get; set; }
        public string QuoteDescription { get; set; }
        public Nullable<int> BaseQuoteID { get; set; }
        public string TaxIDNumber { get; set; }
        public Nullable<decimal> AddedMoney { get; set; }
        public string CC_SecretariesEmailAddresses { get; set; }
        public Nullable<int> CDC_DesignerInitialsID { get; set; }
        public Nullable<bool> HideOpeningDeclaration { get; set; }
        public Nullable<double> CDC_OHSubRate { get; set; }
        public Nullable<bool> ShowItemSellPrice { get; set; }
        public Nullable<bool> ShowTotalSellPrice { get; set; }
        public Nullable<int> CDC_SnowPmt { get; set; }
        public Nullable<bool> VerbalApproval { get; set; }
        public string ShippingEmailSecond { get; set; }
        public string BillingEmailSecond { get; set; }
        public string PmCommunication { get; set; }
    }
}

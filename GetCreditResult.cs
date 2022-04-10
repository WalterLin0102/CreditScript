using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditScriptDotNet5
{
    public class GetCreditResult
    {
        /// <summary>0:成功, 非0:失敗</summary>
        [Newtonsoft.Json.JsonProperty("rtnCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RtnCode { get; set; }

        [Newtonsoft.Json.JsonProperty("msg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Msg { get; set; }

        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public GetCreditRatingResultResp Data { get; set; }
    }
    public partial class GetCreditRatingResultResp
    {
        /// <summary>申請日期</summary>
        [Newtonsoft.Json.JsonProperty("applyIdType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApplyIdType { get; set; }

        /// <summary>自然人/法人 I / C</summary>
        [Newtonsoft.Json.JsonProperty("identityType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IdentityType { get; set; }

        /// <summary>CifNo</summary>
        [Newtonsoft.Json.JsonProperty("cifNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CifNo { get; set; }

        /// <summary>身分別</summary>
        [Newtonsoft.Json.JsonProperty("identificationType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IdentificationType { get; set; }

        /// <summary>統編</summary>
        [Newtonsoft.Json.JsonProperty("idNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IdNo { get; set; }

        /// <summary>名</summary>
        [Newtonsoft.Json.JsonProperty("firstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        /// <summary>姓</summary>
        [Newtonsoft.Json.JsonProperty("lastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName { get; set; }

        /// <summary>供應商代碼</summary>
        [Newtonsoft.Json.JsonProperty("dealerCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DealerCode { get; set; }

        /// <summary>供應商</summary>
        [Newtonsoft.Json.JsonProperty("dealerName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DealerName { get; set; }

        /// <summary>代理商業務員代號</summary>
        [Newtonsoft.Json.JsonProperty("agentCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AgentCode { get; set; }

        /// <summary>代理商業務員名稱</summary>
        [Newtonsoft.Json.JsonProperty("agentName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AgentName { get; set; }

        /// <summary>承作公司別</summary>
        [Newtonsoft.Json.JsonProperty("companyId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int CompanyId { get; set; }

        /// <summary>產品參數</summary>
        [Newtonsoft.Json.JsonProperty("productCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProductCode { get; set; }

        /// <summary>產品名稱</summary>
        [Newtonsoft.Json.JsonProperty("productName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProductName { get; set; }

        /// <summary>產品 Version</summary>
        [Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Version { get; set; }

        /// <summary>報價類別</summary>
        [Newtonsoft.Json.JsonProperty("quotesType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string QuotesType { get; set; }

        /// <summary>幣別</summary>
        [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>供應商來源</summary>
        [Newtonsoft.Json.JsonProperty("dealerSource", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DealerSource { get; set; }

        /// <summary>目的</summary>
        [Newtonsoft.Json.JsonProperty("purposeNBC", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PurposeNBC { get; set; }

        /// <summary>還款期數(月)</summary>
        [Newtonsoft.Json.JsonProperty("tenureMonth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TenureMonth { get; set; }

        /// <summary>還款頻率</summary>
        [Newtonsoft.Json.JsonProperty("paymentFrequency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PaymentFrequency { get; set; }

        /// <summary>還款時機</summary>
        [Newtonsoft.Json.JsonProperty("paymentTiming", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PaymentTiming { get; set; }

        /// <summary>還款期限是否月底</summary>
        [Newtonsoft.Json.JsonProperty("paymentDueatMonthEnd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? PaymentDueatMonthEnd { get; set; }

        /// <summary>中租Sales Account</summary>
        [Newtonsoft.Json.JsonProperty("submissionApplicantId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SubmissionApplicantId { get; set; }

        /// <summary>申請部門代碼</summary>
        [Newtonsoft.Json.JsonProperty("deptId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeptId { get; set; }

        /// <summary>審查經辦</summary>
        [Newtonsoft.Json.JsonProperty("creditOfficer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreditOfficer { get; set; }

        /// <summary>審查經辦部門</summary>
        [Newtonsoft.Json.JsonProperty("creditOfficerDept", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreditOfficerDept { get; set; }

        /// <summary>申請日期</summary>
        [Newtonsoft.Json.JsonProperty("applyDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ApplyDate { get; set; }

        /// <summary>審查案件核准日</summary>
        [Newtonsoft.Json.JsonProperty("approvalDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ApprovalDate { get; set; }

        /// <summary>浮動利率</summary>
        [Newtonsoft.Json.JsonProperty("interestFlatRate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? InterestFlatRate { get; set; }

        /// <summary>審查系統流程結束後要產生的一組Refno,馬來西亞申請自動扣款使用</summary>
        [Newtonsoft.Json.JsonProperty("autoDebitReferenceNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AutoDebitReferenceNo { get; set; }

        /// <summary>取核決階段的 FinanceAmount</summary>
        [Newtonsoft.Json.JsonProperty("approvalFinanceAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ApprovalFinanceAmount { get; set; }

        /// <summary>取核決階段的 TotalAmount</summary>
        [Newtonsoft.Json.JsonProperty("approvalTotalAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ApprovalTotalAmount { get; set; }

        /// <summary>AnnualPercentageRate</summary>
        [Newtonsoft.Json.JsonProperty("annualPercentageRate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AnnualPercentageRate { get; set; }

        /// <summary>內部報酬率</summary>
        [Newtonsoft.Json.JsonProperty("normalIRR", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NormalIRR { get; set; }

        /// <summary>內部報酬率</summary>
        [Newtonsoft.Json.JsonProperty("realIRR", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RealIRR { get; set; }

        /// <summary>淨現值</summary>
        [Newtonsoft.Json.JsonProperty("npv", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Npv { get; set; }

        /// <summary>供應商發票類型</summary>
        [Newtonsoft.Json.JsonProperty("dealerInvoiceType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DealerInvoiceType { get; set; }

        /// <summary>是否有稅金</summary>
        [Newtonsoft.Json.JsonProperty("vat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Vat { get; set; }

        /// <summary>稅額</summary>
        [Newtonsoft.Json.JsonProperty("vatAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? VatAmount { get; set; }

        /// <summary>稅金負擔方</summary>
        [Newtonsoft.Json.JsonProperty("vatPaindby", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VatPaindby { get; set; }

        /// <summary>AutoLife保險</summary>
        [Newtonsoft.Json.JsonProperty("autolife", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Autolife { get; set; }

        /// <summary>AutoLife保額</summary>
        [Newtonsoft.Json.JsonProperty("autolifeSumIssured", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AutolifeSumIssured { get; set; }

        /// <summary>非三方交易才有此欄位</summary>
        [Newtonsoft.Json.JsonProperty("refinancing", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Refinancing { get; set; }

        /// <summary>結算合同</summary>
        [Newtonsoft.Json.JsonProperty("settlementContract", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SettlementContract { get; set; }

        [Newtonsoft.Json.JsonProperty("creditRemark", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CreditRemark { get; set; }

        [Newtonsoft.Json.JsonProperty("advancePayments", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Advance AdvancePayments { get; set; }

        [Newtonsoft.Json.JsonProperty("customerIndivisual", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerIndivisual CustomerIndivisual { get; set; }

        [Newtonsoft.Json.JsonProperty("customerCorporate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerCorporate CustomerCorporate { get; set; }

        /// <summary>保證人 - 自然人</summary>
        [Newtonsoft.Json.JsonProperty("guarantorPersonIndividual", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<GuarantorPersonIndividualVM> GuarantorPersonIndividual { get; set; }

        /// <summary>保證人 - 法人</summary>
        [Newtonsoft.Json.JsonProperty("guarantorPersonCorporate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<GuarantorPersonCorporateVM> GuarantorPersonCorporate { get; set; }

        [Newtonsoft.Json.JsonProperty("guarantors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Guarantors> Guarantors { get; set; }

        [Newtonsoft.Json.JsonProperty("contactPersons", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ContactPersons> ContactPersons { get; set; }

        [Newtonsoft.Json.JsonProperty("fees", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Fee> Fees { get; set; }

        [Newtonsoft.Json.JsonProperty("incentives", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Incentives> Incentives { get; set; }

        [Newtonsoft.Json.JsonProperty("insurances", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<InSurances> Insurances { get; set; }

        [Newtonsoft.Json.JsonProperty("paymentSchedule", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<PaymentSchedule> PaymentSchedule { get; set; }

        [Newtonsoft.Json.JsonProperty("securityAssetMovables", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SecurityAssetMovables> SecurityAssetMovables { get; set; }

        [Newtonsoft.Json.JsonProperty("securityAssetRealEstates", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SecurityAssetRealEstates> SecurityAssetRealEstates { get; set; }

        [Newtonsoft.Json.JsonProperty("securityAssetVehicles", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SecurityAssetVehicles> SecurityAssetVehicles { get; set; }
    }
    public partial class Advance
    {
        /// <summary>預收期款</summary>
        [Newtonsoft.Json.JsonProperty("advancePayment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AdvancePayment { get; set; }

        /// <summary>預收期款</summary>
        [Newtonsoft.Json.JsonProperty("prepaidRental", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PrepaidRental { get; set; }

        /// <summary>保證金</summary>
        [Newtonsoft.Json.JsonProperty("securityDeposit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SecurityDeposit { get; set; }

        /// <summary>供應商暫扣款金額</summary>
        [Newtonsoft.Json.JsonProperty("dealerRetention", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DealerRetention { get; set; }

        /// <summary>履約後第n期撥付</summary>
        [Newtonsoft.Json.JsonProperty("disburseMonth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? DisburseMonth { get; set; }

        /// <summary>是否限定客戶一定要使用Auto Debit繳款</summary>
        [Newtonsoft.Json.JsonProperty("mustAutoDebit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MustAutoDebit { get; set; }


    }
    public partial class GuarantorPersonIndividualVM
    {
        [Newtonsoft.Json.JsonProperty("seqNo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int SeqNo { get; set; }

        [Newtonsoft.Json.JsonProperty("idNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IdNo { get; set; }

        [Newtonsoft.Json.JsonProperty("identificationType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IdentificationType { get; set; }

        [Newtonsoft.Json.JsonProperty("mobilePhone1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MobilePhone1 { get; set; }

        [Newtonsoft.Json.JsonProperty("mobilePhone2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MobilePhone2 { get; set; }

        [Newtonsoft.Json.JsonProperty("email", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Email { get; set; }

        [Newtonsoft.Json.JsonProperty("firstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        [Newtonsoft.Json.JsonProperty("lastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName { get; set; }

        [Newtonsoft.Json.JsonProperty("firstNameForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstNameForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("lastNameForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastNameForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("birthdate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Birthdate { get; set; }

        [Newtonsoft.Json.JsonProperty("gender", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Gender { get; set; }

        [Newtonsoft.Json.JsonProperty("nationality", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Nationality { get; set; }

        [Newtonsoft.Json.JsonProperty("maritalStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MaritalStatus { get; set; }

        [Newtonsoft.Json.JsonProperty("race", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Race { get; set; }

        [Newtonsoft.Json.JsonProperty("registeredAddressLevel1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddressLevel1 { get; set; }

        [Newtonsoft.Json.JsonProperty("registeredAddressLevel2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddressLevel2 { get; set; }

        [Newtonsoft.Json.JsonProperty("registeredAddressLevel3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddressLevel3 { get; set; }

        [Newtonsoft.Json.JsonProperty("registeredAddressLevel4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddressLevel4 { get; set; }

        [Newtonsoft.Json.JsonProperty("registeredAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddress { get; set; }

        [Newtonsoft.Json.JsonProperty("registeredAddressLevel1ForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddressLevel1ForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("registeredAddressLevel2ForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddressLevel2ForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("registeredAddressLevel3ForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddressLevel3ForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("registeredAddressLevel4ForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddressLevel4ForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("registeredAddressForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddressForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("residentialStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResidentialStatus { get; set; }

        [Newtonsoft.Json.JsonProperty("contactAddressLevel1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddressLevel1 { get; set; }

        [Newtonsoft.Json.JsonProperty("contactAddressLevel2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddressLevel2 { get; set; }

        [Newtonsoft.Json.JsonProperty("contactAddressLevel3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddressLevel3 { get; set; }

        [Newtonsoft.Json.JsonProperty("contactAddressLevel4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddressLevel4 { get; set; }

        [Newtonsoft.Json.JsonProperty("contactAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddress { get; set; }

        [Newtonsoft.Json.JsonProperty("contactAddressLevel1ForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddressLevel1ForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("contactAddressLevel2ForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddressLevel2ForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("contactAddressLevel3ForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddressLevel3ForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("contactAddressLevel4ForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddressLevel4ForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("contactAddressForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddressForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("telephone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Telephone { get; set; }

        [Newtonsoft.Json.JsonProperty("lengthOfResidence", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LengthOfResidence { get; set; }

        [Newtonsoft.Json.JsonProperty("cifNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CifNo { get; set; }

        [Newtonsoft.Json.JsonProperty("workAddressLevel1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkAddressLevel1 { get; set; }

        [Newtonsoft.Json.JsonProperty("workAddressLevel2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkAddressLevel2 { get; set; }

        [Newtonsoft.Json.JsonProperty("workAddressLevel3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkAddressLevel3 { get; set; }

        [Newtonsoft.Json.JsonProperty("workAddressLevel4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkAddressLevel4 { get; set; }

        [Newtonsoft.Json.JsonProperty("workAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkAddress { get; set; }

        [Newtonsoft.Json.JsonProperty("workPhone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkPhone { get; set; }

        [Newtonsoft.Json.JsonProperty("workEmail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkEmail { get; set; }

        [Newtonsoft.Json.JsonProperty("workFaxNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkFaxNo { get; set; }

        /// <summary>職業</summary>
        [Newtonsoft.Json.JsonProperty("occupation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Occupation { get; set; }

        /// <summary>職位</summary>
        [Newtonsoft.Json.JsonProperty("position", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Position { get; set; }

        [Newtonsoft.Json.JsonProperty("lengthOfEmployment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LengthOfEmployment { get; set; }

        [Newtonsoft.Json.JsonProperty("employerName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EmployerName { get; set; }

        [Newtonsoft.Json.JsonProperty("monthlyIncome", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MonthlyIncome { get; set; }

        [Newtonsoft.Json.JsonProperty("workingInSingapore", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? WorkingInSingapore { get; set; }

        [Newtonsoft.Json.JsonProperty("educationLevel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EducationLevel { get; set; }

        [Newtonsoft.Json.JsonProperty("spouseName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SpouseName { get; set; }

        [Newtonsoft.Json.JsonProperty("registeredPhone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredPhone { get; set; }

        [Newtonsoft.Json.JsonProperty("contactPhone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactPhone { get; set; }

        [Newtonsoft.Json.JsonProperty("oldIdNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OldIdNo { get; set; }

        [Newtonsoft.Json.JsonProperty("idExpiryDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? IdExpiryDate { get; set; }

        [Newtonsoft.Json.JsonProperty("idIssueDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? IdIssueDate { get; set; }

        /// <summary>公職身分</summary>
        [Newtonsoft.Json.JsonProperty("civilServant", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CivilServant { get; set; }

        /// <summary>法定關係</summary>
        [Newtonsoft.Json.JsonProperty("legalPosition", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LegalPosition { get; set; }


    }
    public partial class GuarantorPersonCorporateVM
    {
        [Newtonsoft.Json.JsonProperty("seqNo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int SeqNo { get; set; }

        [Newtonsoft.Json.JsonProperty("idNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IdNo { get; set; }

        [Newtonsoft.Json.JsonProperty("identificationType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IdentificationType { get; set; }

        [Newtonsoft.Json.JsonProperty("mobilePhone1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MobilePhone1 { get; set; }

        [Newtonsoft.Json.JsonProperty("mobilePhone2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MobilePhone2 { get; set; }

        [Newtonsoft.Json.JsonProperty("email", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Email { get; set; }

        [Newtonsoft.Json.JsonProperty("nationality", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Nationality { get; set; }

        [Newtonsoft.Json.JsonProperty("telephone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Telephone { get; set; }

        [Newtonsoft.Json.JsonProperty("customerName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerName { get; set; }

        [Newtonsoft.Json.JsonProperty("customerNameForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerNameForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("dateofIncorporation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateofIncorporation { get; set; }

        [Newtonsoft.Json.JsonProperty("registeredAddressLevel1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddressLevel1 { get; set; }

        [Newtonsoft.Json.JsonProperty("registeredAddressLevel2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddressLevel2 { get; set; }

        [Newtonsoft.Json.JsonProperty("registeredAddressLevel3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddressLevel3 { get; set; }

        [Newtonsoft.Json.JsonProperty("registeredAddressLevel4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddressLevel4 { get; set; }

        [Newtonsoft.Json.JsonProperty("registeredAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddress { get; set; }

        [Newtonsoft.Json.JsonProperty("registeredAddressLevel1ForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddressLevel1ForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("registeredAddressLevel2ForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddressLevel2ForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("registeredAddressLevel3ForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddressLevel3ForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("registeredAddressLevel4ForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddressLevel4ForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("registeredAddressForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddressForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("residentialStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResidentialStatus { get; set; }

        [Newtonsoft.Json.JsonProperty("contactAddressLevel1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddressLevel1 { get; set; }

        [Newtonsoft.Json.JsonProperty("contactAddressLevel2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddressLevel2 { get; set; }

        [Newtonsoft.Json.JsonProperty("contactAddressLevel3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddressLevel3 { get; set; }

        [Newtonsoft.Json.JsonProperty("contactAddressLevel4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddressLevel4 { get; set; }

        [Newtonsoft.Json.JsonProperty("contactAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddress { get; set; }

        [Newtonsoft.Json.JsonProperty("contactAddressLevel1ForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddressLevel1ForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("contactAddressLevel2ForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddressLevel2ForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("contactAddressLevel3ForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddressLevel3ForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("contactAddressLevel4ForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddressLevel4ForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("contactAddressForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddressForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("companyContactPhone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CompanyContactPhone { get; set; }

        [Newtonsoft.Json.JsonProperty("greditLine", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GreditLine { get; set; }

        [Newtonsoft.Json.JsonProperty("responsiblePersonRegAddressLevel1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResponsiblePersonRegAddressLevel1 { get; set; }

        [Newtonsoft.Json.JsonProperty("responsiblePersonRegAddressLevel2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResponsiblePersonRegAddressLevel2 { get; set; }

        [Newtonsoft.Json.JsonProperty("responsiblePersonRegAddressLevel3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResponsiblePersonRegAddressLevel3 { get; set; }

        [Newtonsoft.Json.JsonProperty("responsiblePersonRegAddressLevel4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResponsiblePersonRegAddressLevel4 { get; set; }

        [Newtonsoft.Json.JsonProperty("responsiblePersonRegAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResponsiblePersonRegAddress { get; set; }

        [Newtonsoft.Json.JsonProperty("responsiblePersonContactAddressLevel1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResponsiblePersonContactAddressLevel1 { get; set; }

        [Newtonsoft.Json.JsonProperty("responsiblePersonContactAddressLevel2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResponsiblePersonContactAddressLevel2 { get; set; }

        [Newtonsoft.Json.JsonProperty("responsiblePersonContactAddressLevel3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResponsiblePersonContactAddressLevel3 { get; set; }

        [Newtonsoft.Json.JsonProperty("responsiblePersonContactAddressLevel4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResponsiblePersonContactAddressLevel4 { get; set; }

        [Newtonsoft.Json.JsonProperty("responsiblePersonContactAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResponsiblePersonContactAddress { get; set; }

        [Newtonsoft.Json.JsonProperty("responsiblePersonContactAddressLevel1ForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResponsiblePersonContactAddressLevel1ForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("responsiblePersonContactAddressLevel2ForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResponsiblePersonContactAddressLevel2ForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("responsiblePersonContactAddressLevel3ForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResponsiblePersonContactAddressLevel3ForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("responsiblePersonContactAddressLevel4ForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResponsiblePersonContactAddressLevel4ForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("responsiblePersonContactAddressForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResponsiblePersonContactAddressForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("responsiblePersonIDNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResponsiblePersonIDNo { get; set; }

        [Newtonsoft.Json.JsonProperty("responsiblePersonBirthDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ResponsiblePersonBirthDate { get; set; }

        [Newtonsoft.Json.JsonProperty("responsiblePersonName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResponsiblePersonName { get; set; }

        [Newtonsoft.Json.JsonProperty("responsiblePersonNameForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResponsiblePersonNameForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("registerPhone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisterPhone { get; set; }

        [Newtonsoft.Json.JsonProperty("contactPhone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactPhone { get; set; }

        [Newtonsoft.Json.JsonProperty("registeredCompanyPhoneNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredCompanyPhoneNo { get; set; }

        [Newtonsoft.Json.JsonProperty("responsiblePersonEducationLevel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResponsiblePersonEducationLevel { get; set; }

        [Newtonsoft.Json.JsonProperty("responsiblePersonMaritalStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResponsiblePersonMaritalStatus { get; set; }

        [Newtonsoft.Json.JsonProperty("responsiblePersonSpouseName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResponsiblePersonSpouseName { get; set; }

        [Newtonsoft.Json.JsonProperty("responsiblePersonRegisteredPhone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResponsiblePersonRegisteredPhone { get; set; }

        [Newtonsoft.Json.JsonProperty("cifNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CifNo { get; set; }

        [Newtonsoft.Json.JsonProperty("payUpCapital", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PayUpCapital { get; set; }

        [Newtonsoft.Json.JsonProperty("industry", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Industry { get; set; }

        [Newtonsoft.Json.JsonProperty("responsiblePersonOldIdNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResponsiblePersonOldIdNo { get; set; }

        [Newtonsoft.Json.JsonProperty("isEastMY", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsEastMY { get; set; }

        [Newtonsoft.Json.JsonProperty("position", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Position { get; set; }

        [Newtonsoft.Json.JsonProperty("responsiblePersonGender", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResponsiblePersonGender { get; set; }

        [Newtonsoft.Json.JsonProperty("civilServant", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CivilServant { get; set; }

        [Newtonsoft.Json.JsonProperty("monthlyIncome", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MonthlyIncome { get; set; }

        [Newtonsoft.Json.JsonProperty("lengthOfResidence", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LengthOfResidence { get; set; }

        [Newtonsoft.Json.JsonProperty("responsiblePersonContactPhone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResponsiblePersonContactPhone { get; set; }

        [Newtonsoft.Json.JsonProperty("legalPosition", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LegalPosition { get; set; }

        [Newtonsoft.Json.JsonProperty("relation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Relation { get; set; }
    }
    public partial class Guarantors
    {
        /// <summary>自然人/法人 I/C</summary>
        [Newtonsoft.Json.JsonProperty("identityType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IdentityType { get; set; }

        /// <summary>CifNo</summary>
        [Newtonsoft.Json.JsonProperty("cifNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CifNo { get; set; }

        /// <summary>統編</summary>
        [Newtonsoft.Json.JsonProperty("idNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IdNo { get; set; }

        /// <summary>身分類型</summary>
        [Newtonsoft.Json.JsonProperty("identificationType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IdentificationType { get; set; }

        /// <summary>名</summary>
        [Newtonsoft.Json.JsonProperty("firstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        /// <summary>姓</summary>
        [Newtonsoft.Json.JsonProperty("lastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName { get; set; }

        /// <summary>名 - ForOther</summary>
        [Newtonsoft.Json.JsonProperty("firstNameForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstNameForOther { get; set; }

        /// <summary>姓 - ForOther</summary>
        [Newtonsoft.Json.JsonProperty("lastNameForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastNameForOther { get; set; }

        /// <summary>客戶名稱</summary>
        [Newtonsoft.Json.JsonProperty("customerName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerName { get; set; }

        /// <summary>客戶名稱 - ForOther</summary>
        [Newtonsoft.Json.JsonProperty("customerNameForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerNameForOther { get; set; }

        /// <summary>法律地位</summary>
        [Newtonsoft.Json.JsonProperty("legalPosition", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LegalPosition { get; set; }

        /// <summary>關係</summary>
        [Newtonsoft.Json.JsonProperty("relationship", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Relationship { get; set; }

        /// <summary>手機號碼</summary>
        [Newtonsoft.Json.JsonProperty("mobilePhone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MobilePhone { get; set; }

        /// <summary>備註</summary>
        [Newtonsoft.Json.JsonProperty("remark", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Remark { get; set; }
    }
    public partial class ContactPersons
    {
        /// <summary>名</summary>
        [Newtonsoft.Json.JsonProperty("firstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        /// <summary>姓</summary>
        [Newtonsoft.Json.JsonProperty("lastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastName { get; set; }

        /// <summary>名 - ForOther</summary>
        [Newtonsoft.Json.JsonProperty("firstNameForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstNameForOther { get; set; }

        /// <summary>姓 - ForOther</summary>
        [Newtonsoft.Json.JsonProperty("lastNameForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastNameForOther { get; set; }

        /// <summary>關係</summary>
        [Newtonsoft.Json.JsonProperty("relationship", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Relationship { get; set; }

        /// <summary>電話1</summary>
        [Newtonsoft.Json.JsonProperty("telephoneNo1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TelephoneNo1 { get; set; }

        /// <summary>電話2</summary>
        [Newtonsoft.Json.JsonProperty("telephoneNo2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TelephoneNo2 { get; set; }

        /// <summary>手機號碼1</summary>
        [Newtonsoft.Json.JsonProperty("mobilePhone1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MobilePhone1 { get; set; }

        /// <summary>手機號碼2</summary>
        [Newtonsoft.Json.JsonProperty("mobilePhone2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MobilePhone2 { get; set; }
    }
    public partial class Incentives
    {
        /// <summary>獎勵類型</summary>
        [Newtonsoft.Json.JsonProperty("incentiveType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IncentiveType { get; set; }

        /// <summary>獎勵比例</summary>
        [Newtonsoft.Json.JsonProperty("rate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Rate { get; set; }

        /// <summary>收據證明</summary>
        [Newtonsoft.Json.JsonProperty("proveofReceipt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProveofReceipt { get; set; }

        /// <summary>收據證明</summary>
        [Newtonsoft.Json.JsonProperty("receiptType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReceiptType { get; set; }

        /// <summary>預扣稅</summary>
        [Newtonsoft.Json.JsonProperty("ewt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Ewt { get; set; }

        /// <summary>獎勵金額</summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Amount { get; set; }

        /// <summary>獎勵金額+税</summary>
        [Newtonsoft.Json.JsonProperty("amountIncludeTax", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AmountIncludeTax { get; set; }
    }
    public partial class InSurances
    {
        /// <summary>保險類型</summary>
        [Newtonsoft.Json.JsonProperty("insuranceType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InsuranceType { get; set; }

        /// <summary>客戶收取保費</summary>
        [Newtonsoft.Json.JsonProperty("chargedPremium", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double ChargedPremium { get; set; }

        /// <summary>實際支付保費</summary>
        [Newtonsoft.Json.JsonProperty("actualPremium", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double ActualPremium { get; set; }

        /// <summary>財務-Insurance</summary>
        [Newtonsoft.Json.JsonProperty("finance", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Finance { get; set; }

        /// <summary>扣除-Insurance</summary>
        [Newtonsoft.Json.JsonProperty("deduct", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Deduct { get; set; }


    }
    public partial class SecurityAssetMovables
    {
        [Newtonsoft.Json.JsonProperty("subSeqId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int SubSeqId { get; set; }

        /// <summary>擔保品性質</summary>
        [Newtonsoft.Json.JsonProperty("assetProperty", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AssetProperty { get; set; }

        /// <summary>擔保品類型</summary>
        [Newtonsoft.Json.JsonProperty("assetType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AssetType { get; set; }

        /// <summary>擔保品類別</summary>
        [Newtonsoft.Json.JsonProperty("assetCategory", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AssetCategory { get; set; }

        /// <summary>目的</summary>
        [Newtonsoft.Json.JsonProperty("purpose", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Purpose { get; set; }

        /// <summary>動產名稱</summary>
        [Newtonsoft.Json.JsonProperty("assetName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AssetName { get; set; }

        /// <summary>功能</summary>
        [Newtonsoft.Json.JsonProperty("assetFunction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AssetFunction { get; set; }

        /// <summary>品牌</summary>
        [Newtonsoft.Json.JsonProperty("brand", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Brand { get; set; }

        /// <summary>型號</summary>
        [Newtonsoft.Json.JsonProperty("model", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Model { get; set; }

        /// <summary>製造年份</summary>
        [Newtonsoft.Json.JsonProperty("manufactureYear", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ManufactureYear { get; set; }

        /// <summary>原產地</summary>
        [Newtonsoft.Json.JsonProperty("countryOfOrigin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CountryOfOrigin { get; set; }

        /// <summary>單價</summary>
        [Newtonsoft.Json.JsonProperty("unitPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UnitPrice { get; set; }

        /// <summary>數量</summary>
        [Newtonsoft.Json.JsonProperty("qty", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Qty { get; set; }

        /// <summary>總價</summary>
        [Newtonsoft.Json.JsonProperty("totalPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalPrice { get; set; }

        /// <summary>市場價格</summary>
        [Newtonsoft.Json.JsonProperty("marketPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MarketPrice { get; set; }

        /// <summary>地點</summary>
        [Newtonsoft.Json.JsonProperty("assetLocation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AssetLocation { get; set; }

        /// <summary>安裝GPS</summary>
        [Newtonsoft.Json.JsonProperty("gpsInstallation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GpsInstallation { get; set; }

        /// <summary>購買動產價格備註</summary>
        [Newtonsoft.Json.JsonProperty("remarkForAssetPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RemarkForAssetPrice { get; set; }

        /// <summary>是否有擔保價值</summary>
        [Newtonsoft.Json.JsonProperty("hasCollateralValue", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool HasCollateralValue { get; set; }

        /// <summary>備註</summary>
        [Newtonsoft.Json.JsonProperty("remark", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Remark { get; set; }

        [Newtonsoft.Json.JsonProperty("securityAssetMovablesFees", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SecurityAssetMovablesFee> SecurityAssetMovablesFees { get; set; }
    }
    public partial class SecurityAssetMovablesFee
    {
        /// <summary>費用項目</summary>
        [Newtonsoft.Json.JsonProperty("item", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Item { get; set; }

        /// <summary>收取金額</summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Amount { get; set; }

        /// <summary>付款方式</summary>
        [Newtonsoft.Json.JsonProperty("payment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Payment { get; set; }


    }
    public partial class SecurityAssetRealEstates
    {
        [Newtonsoft.Json.JsonProperty("subSeqId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int SubSeqId { get; set; }

        /// <summary>擔保品性質</summary>
        [Newtonsoft.Json.JsonProperty("assetProperty", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AssetProperty { get; set; }

        /// <summary>擔保品類型</summary>
        [Newtonsoft.Json.JsonProperty("assetType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AssetType { get; set; }

        /// <summary>擔保品類別</summary>
        [Newtonsoft.Json.JsonProperty("assetCategory", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AssetCategory { get; set; }

        /// <summary>目的</summary>
        [Newtonsoft.Json.JsonProperty("purpose", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Purpose { get; set; }

        /// <summary>擁有者</summary>
        [Newtonsoft.Json.JsonProperty("owner", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Owner { get; set; }

        /// <summary>房地產地址</summary>
        [Newtonsoft.Json.JsonProperty("address", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>土地寬度-公尺</summary>
        [Newtonsoft.Json.JsonProperty("landSizeWidthM", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LandSizeWidthM { get; set; }

        /// <summary>建築物寬度-公尺</summary>
        [Newtonsoft.Json.JsonProperty("buildingSizeWidthM", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BuildingSizeWidthM { get; set; }

        /// <summary>房地產購買價格</summary>
        [Newtonsoft.Json.JsonProperty("purchasePrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PurchasePrice { get; set; }

        /// <summary>房地產市場價格</summary>
        [Newtonsoft.Json.JsonProperty("marketPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MarketPrice { get; set; }

        /// <summary>抵押支票</summary>
        [Newtonsoft.Json.JsonProperty("mortgageCheck", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MortgageCheck { get; set; }

        /// <summary>是否有擔保價值</summary>
        [Newtonsoft.Json.JsonProperty("hasCollateralValue", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool HasCollateralValue { get; set; }

        /// <summary>備註</summary>
        [Newtonsoft.Json.JsonProperty("remark", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Remark { get; set; }

        [Newtonsoft.Json.JsonProperty("securityAssetRealEstateFee", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SecurityAssetRealEstateFee> SecurityAssetRealEstateFee { get; set; }
    }
    public partial class SecurityAssetRealEstateFee
    {
        /// <summary>費用項目</summary>
        [Newtonsoft.Json.JsonProperty("item", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Item { get; set; }

        /// <summary>收取金額</summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Amount { get; set; }

        /// <summary>付款方式</summary>
        [Newtonsoft.Json.JsonProperty("payment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Payment { get; set; }


    }
    public partial class SecurityAssetVehicles
    {
        [Newtonsoft.Json.JsonProperty("subSeqId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int SubSeqId { get; set; }

        /// <summary>/// &lt;summary&gt;
        /// 擔保品性質
        /// &lt;/summary&gt;</summary>
        [Newtonsoft.Json.JsonProperty("assetProperty", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AssetProperty { get; set; }

        /// <summary>擔保品類型</summary>
        [Newtonsoft.Json.JsonProperty("assetType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AssetType { get; set; }

        /// <summary>擔保品類別</summary>
        [Newtonsoft.Json.JsonProperty("assetCategory", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AssetCategory { get; set; }

        /// <summary>目的</summary>
        [Newtonsoft.Json.JsonProperty("purpose", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Purpose { get; set; }

        /// <summary>品牌</summary>
        [Newtonsoft.Json.JsonProperty("brand", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Brand { get; set; }

        /// <summary>型號</summary>
        [Newtonsoft.Json.JsonProperty("model", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Model { get; set; }

        /// <summary>車輛類型</summary>
        [Newtonsoft.Json.JsonProperty("vehicleType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VehicleType { get; set; }

        /// <summary>車身型態</summary>
        [Newtonsoft.Json.JsonProperty("bodyType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BodyType { get; set; }

        /// <summary>交易類型</summary>
        [Newtonsoft.Json.JsonProperty("transaction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Transaction { get; set; }

        /// <summary>製造日期</summary>
        [Newtonsoft.Json.JsonProperty("dateManufacture", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateManufacture { get; set; }

        /// <summary>製造日期與案件到期年份之間的年數</summary>
        [Newtonsoft.Json.JsonProperty("cap", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Cap { get; set; }

        /// <summary>製造國家</summary>
        [Newtonsoft.Json.JsonProperty("manufacturerNationality", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ManufacturerNationality { get; set; }

        /// <summary>排氣量</summary>
        [Newtonsoft.Json.JsonProperty("displacement", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Displacement { get; set; }

        /// <summary>變速方式</summary>
        [Newtonsoft.Json.JsonProperty("transmission", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Transmission { get; set; }

        /// <summary>動力種類</summary>
        [Newtonsoft.Json.JsonProperty("gasoline", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Gasoline { get; set; }

        /// <summary>顏色</summary>
        [Newtonsoft.Json.JsonProperty("vehicleColor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VehicleColor { get; set; }

        /// <summary>牌照類型</summary>
        [Newtonsoft.Json.JsonProperty("licenseType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LicenseType { get; set; }

        /// <summary>座位數</summary>
        [Newtonsoft.Json.JsonProperty("seats", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Seats { get; set; }

        /// <summary>噸數</summary>
        [Newtonsoft.Json.JsonProperty("ton", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Ton { get; set; }

        /// <summary>車牌號碼</summary>
        [Newtonsoft.Json.JsonProperty("plateNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlateNo { get; set; }

        /// <summary>引擎編號</summary>
        [Newtonsoft.Json.JsonProperty("engineNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EngineNo { get; set; }

        /// <summary>外殼編號</summary>
        [Newtonsoft.Json.JsonProperty("chassisNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChassisNo { get; set; }

        /// <summary>車輛註冊編號</summary>
        [Newtonsoft.Json.JsonProperty("vehicleRegNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VehicleRegNo { get; set; }

        /// <summary>購買價格</summary>
        [Newtonsoft.Json.JsonProperty("purchasePrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PurchasePrice { get; set; }

        /// <summary>業務估價</summary>
        [Newtonsoft.Json.JsonProperty("salesAppraisalPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SalesAppraisalPrice { get; set; }

        /// <summary>配件</summary>
        [Newtonsoft.Json.JsonProperty("accessories", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Accessories { get; set; }

        /// <summary>購買價格備註</summary>
        [Newtonsoft.Json.JsonProperty("remarkforVehiclePrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RemarkforVehiclePrice { get; set; }

        /// <summary>首付</summary>
        [Newtonsoft.Json.JsonProperty("downPayment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DownPayment { get; set; }

        /// <summary>保險</summary>
        [Newtonsoft.Json.JsonProperty("insurance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Insurance { get; set; }

        /// <summary>安裝GPS</summary>
        [Newtonsoft.Json.JsonProperty("gpsInstallation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GpsInstallation { get; set; }

        /// <summary>登記類型</summary>
        [Newtonsoft.Json.JsonProperty("registrationType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegistrationType { get; set; }

        /// <summary>DLType</summary>
        [Newtonsoft.Json.JsonProperty("dLtype", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DLtype { get; set; }

        /// <summary>DLNo</summary>
        [Newtonsoft.Json.JsonProperty("dlNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DlNo { get; set; }

        /// <summary>備註</summary>
        [Newtonsoft.Json.JsonProperty("remark", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Remark { get; set; }

        /// <summary>是否有擔保價值</summary>
        [Newtonsoft.Json.JsonProperty("hasCollateralValue", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool HasCollateralValue { get; set; }

        /// <summary>車輛使用人</summary>
        [Newtonsoft.Json.JsonProperty("carUser", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CarUser { get; set; }

        [Newtonsoft.Json.JsonProperty("securityAssetVehicleFee", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SecurityAssetVehicleFee> SecurityAssetVehicleFee { get; set; }
    }
    public partial class SecurityAssetVehicleFee
    {
        /// <summary>費用項目</summary>
        [Newtonsoft.Json.JsonProperty("item", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Item { get; set; }

        /// <summary>收取金額</summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Amount { get; set; }

        /// <summary>付款方式</summary>
        [Newtonsoft.Json.JsonProperty("payment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Payment { get; set; }
    }
    public partial class CustomerIndivisual
    {
        /// <summary>客戶電話2</summary>
        [Newtonsoft.Json.JsonProperty("mobilePhone2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MobilePhone2 { get; set; }

        /// <summary>住家電話</summary>
        [Newtonsoft.Json.JsonProperty("telephone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Telephone { get; set; }

        /// <summary>RegisteredAddressLevel 1</summary>
        [Newtonsoft.Json.JsonProperty("registeredAddressLevel1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddressLevel1 { get; set; }

        /// <summary>RegisteredAddressLevel 2</summary>
        [Newtonsoft.Json.JsonProperty("registeredAddressLevel2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddressLevel2 { get; set; }

        /// <summary>RegisteredAddressLevel 3</summary>
        [Newtonsoft.Json.JsonProperty("registeredAddressLevel3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddressLevel3 { get; set; }

        /// <summary>RegisteredAddressLevel 4</summary>
        [Newtonsoft.Json.JsonProperty("registeredAddressLevel4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddressLevel4 { get; set; }

        /// <summary>RegisteredAddress 地址</summary>
        [Newtonsoft.Json.JsonProperty("registeredAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddress { get; set; }

        /// <summary>RegisteredAddressLevel 1</summary>
        [Newtonsoft.Json.JsonProperty("registeredAddressLevel1ForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddressLevel1ForOther { get; set; }

        /// <summary>RegisteredAddressLevel 2</summary>
        [Newtonsoft.Json.JsonProperty("registeredAddressLevel2ForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddressLevel2ForOther { get; set; }

        /// <summary>RegisteredAddressLevel 3</summary>
        [Newtonsoft.Json.JsonProperty("registeredAddressLevel3ForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddressLevel3ForOther { get; set; }

        /// <summary>RegisteredAddressLevel 4</summary>
        [Newtonsoft.Json.JsonProperty("registeredAddressLevel4ForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddressLevel4ForOther { get; set; }

        /// <summary>RegisteredAddress 地址</summary>
        [Newtonsoft.Json.JsonProperty("registeredAddressForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegisteredAddressForOther { get; set; }

        /// <summary>聯絡地址Level 1</summary>
        [Newtonsoft.Json.JsonProperty("contactAddressLevel1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddressLevel1 { get; set; }

        /// <summary>聯絡地址Level 2</summary>
        [Newtonsoft.Json.JsonProperty("contactAddressLevel2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddressLevel2 { get; set; }

        /// <summary>聯絡地址Level 3</summary>
        [Newtonsoft.Json.JsonProperty("contactAddressLevel3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddressLevel3 { get; set; }

        /// <summary>聯絡地址Level 4</summary>
        [Newtonsoft.Json.JsonProperty("contactAddressLevel4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddressLevel4 { get; set; }

        /// <summary>聯絡地址</summary>
        [Newtonsoft.Json.JsonProperty("contactAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddress { get; set; }

        /// <summary>聯絡地址Level 1</summary>
        [Newtonsoft.Json.JsonProperty("contactAddressLevel1ForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddressLevel1ForOther { get; set; }

        /// <summary>聯絡地址Level 2</summary>
        [Newtonsoft.Json.JsonProperty("contactAddressLevel2ForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddressLevel2ForOther { get; set; }

        /// <summary>聯絡地址Level 3</summary>
        [Newtonsoft.Json.JsonProperty("contactAddressLevel3ForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddressLevel3ForOther { get; set; }

        /// <summary>聯絡地址Level 4</summary>
        [Newtonsoft.Json.JsonProperty("contactAddressLevel4ForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddressLevel4ForOther { get; set; }

        /// <summary>聯絡地址</summary>
        [Newtonsoft.Json.JsonProperty("contactAddressForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContactAddressForOther { get; set; }

        /// <summary>電子郵件</summary>
        [Newtonsoft.Json.JsonProperty("email", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Email { get; set; }

        [Newtonsoft.Json.JsonProperty("workAddressLevel1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkAddressLevel1 { get; set; }

        [Newtonsoft.Json.JsonProperty("workAddressLevel2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkAddressLevel2 { get; set; }

        [Newtonsoft.Json.JsonProperty("workAddressLevel3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkAddressLevel3 { get; set; }

        [Newtonsoft.Json.JsonProperty("workAddressLevel4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkAddressLevel4 { get; set; }

        [Newtonsoft.Json.JsonProperty("workAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkAddress { get; set; }

        [Newtonsoft.Json.JsonProperty("workPhone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkPhone { get; set; }

        [Newtonsoft.Json.JsonProperty("workFaxNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkFaxNo { get; set; }

        [Newtonsoft.Json.JsonProperty("workEmail", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkEmail { get; set; }

        /// <summary>職業</summary>
        [Newtonsoft.Json.JsonProperty("occupation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Occupation { get; set; }

        /// <summary>職位</summary>
        [Newtonsoft.Json.JsonProperty("position", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Position { get; set; }

        [Newtonsoft.Json.JsonProperty("lengthOfEmployment", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int LengthOfEmployment { get; set; }

        [Newtonsoft.Json.JsonProperty("employerName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EmployerName { get; set; }

        [Newtonsoft.Json.JsonProperty("monthlyIncome", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double MonthlyIncome { get; set; }

        [Newtonsoft.Json.JsonProperty("workingInSingapore", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? WorkingInSingapore { get; set; }

        /// <summary>公務身分</summary>
        [Newtonsoft.Json.JsonProperty("civilServant", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CivilServant { get; set; }


    }
    public partial class CustomerCorporate
    {
        /// <summary>客戶名稱</summary>
        [Newtonsoft.Json.JsonProperty("customerName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerName { get; set; }

        /// <summary>公司註冊地 Level 1</summary>
        [Newtonsoft.Json.JsonProperty("companyRegAddressLevel1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CompanyRegAddressLevel1 { get; set; }

        /// <summary>公司註冊地 Level 2</summary>
        [Newtonsoft.Json.JsonProperty("companyRegAddressLevel2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CompanyRegAddressLevel2 { get; set; }

        /// <summary>公司註冊地 Level 3</summary>
        [Newtonsoft.Json.JsonProperty("companyRegAddressLevel3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CompanyRegAddressLevel3 { get; set; }

        /// <summary>公司註冊地 Level 4</summary>
        [Newtonsoft.Json.JsonProperty("companyRegAddressLevel4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CompanyRegAddressLevel4 { get; set; }

        /// <summary>公司註冊地 地址</summary>
        [Newtonsoft.Json.JsonProperty("companyRegAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CompanyRegAddress { get; set; }

        /// <summary>公司聯絡地址 Level 1</summary>
        [Newtonsoft.Json.JsonProperty("companyContactAddressLevel1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CompanyContactAddressLevel1 { get; set; }

        /// <summary>公司聯絡地址 Level 2</summary>
        [Newtonsoft.Json.JsonProperty("companyContactAddressLevel2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CompanyContactAddressLevel2 { get; set; }

        /// <summary>公司聯絡地址 Level 3</summary>
        [Newtonsoft.Json.JsonProperty("companyContactAddressLevel3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CompanyContactAddressLevel3 { get; set; }

        /// <summary>公司聯絡地址 Level 4</summary>
        [Newtonsoft.Json.JsonProperty("companyContactAddressLevel4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CompanyContactAddressLevel4 { get; set; }

        /// <summary>公司聯絡地址</summary>
        [Newtonsoft.Json.JsonProperty("companyContactAddress", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CompanyContactAddress { get; set; }

        /// <summary>客戶電話2</summary>
        [Newtonsoft.Json.JsonProperty("mobilePhone2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MobilePhone2 { get; set; }


    }
    public partial class Fee
    {
        /// <summary>費用項目</summary>
        [Newtonsoft.Json.JsonProperty("item", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Item { get; set; }

        /// <summary>費用收取對象</summary>
        [Newtonsoft.Json.JsonProperty("paidBy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PaidBy { get; set; }

        /// <summary>收取金額</summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Amount { get; set; }

        [Newtonsoft.Json.JsonProperty("finance", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Finance { get; set; }

        [Newtonsoft.Json.JsonProperty("deduct", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Deduct { get; set; }

        /// <summary>付款週期</summary>
        [Newtonsoft.Json.JsonProperty("payment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Payment { get; set; }


    }
    public partial class PaymentSchedule
    {
        /// <summary>erm 序號，從1開始編</summary>
        [Newtonsoft.Json.JsonProperty("term", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Term { get; set; }

        /// <summary>每月支付(不含保險)</summary>
        [Newtonsoft.Json.JsonProperty("monthlyPaymentExcludeInsurance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MonthlyPaymentExcludeInsurance { get; set; }

        /// <summary>每月支付</summary>
        [Newtonsoft.Json.JsonProperty("monthlyPayment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MonthlyPayment { get; set; }

        /// <summary>支付日期</summary>
        [Newtonsoft.Json.JsonProperty("payDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? PayDate { get; set; }


    }
}

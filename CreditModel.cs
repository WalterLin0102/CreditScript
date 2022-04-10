using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditScriptDotNet5.XXX
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class CustomerIndivisual
    {
        [Newtonsoft.Json.JsonProperty("mobilePhone2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string MobilePhone2 { get; set; }

        [Newtonsoft.Json.JsonProperty("telephone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Telephone { get; set; }

        [Newtonsoft.Json.JsonProperty("registeredAddressStateKH", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string RegisteredAddressStateKH { get; set; }

        [Newtonsoft.Json.JsonProperty("registeredAddressCityKH", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string RegisteredAddressCityKH { get; set; }

        [Newtonsoft.Json.JsonProperty("registeredAddressDistrictKH", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string RegisteredAddressDistrictKH { get; set; }

        [Newtonsoft.Json.JsonProperty("registeredAddressStreetKH", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string RegisteredAddressStreetKH { get; set; }

        [Newtonsoft.Json.JsonProperty("contactAddressStateKH", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string ContactAddressStateKH { get; set; }

        [Newtonsoft.Json.JsonProperty("contactAddressCityKH", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string ContactAddressCityKH { get; set; }

        [Newtonsoft.Json.JsonProperty("contactAddressDistrictKH", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string ContactAddressDistrictKH { get; set; }

        [Newtonsoft.Json.JsonProperty("contactAddressStreetKH", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string ContactAddressStreetKH { get; set; }

        [Newtonsoft.Json.JsonProperty("email", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Email { get; set; }

        [Newtonsoft.Json.JsonProperty("workAddressLevel1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkAddressLevel1 { get; set; }

        [Newtonsoft.Json.JsonProperty("workAddressLevel2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkAddressLevel2 { get; set; }

        [Newtonsoft.Json.JsonProperty("workAddressLevel3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkAddressLevel3 { get; set; }

        [Newtonsoft.Json.JsonProperty("workAddressLevel4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkAddressLevel4 { get; set; }

        [Newtonsoft.Json.JsonProperty("workAddressLevel5", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkAddressLevel5 { get; set; }

        [Newtonsoft.Json.JsonProperty("workPhoneNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkPhoneNo { get; set; }

        [Newtonsoft.Json.JsonProperty("workFaxNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WorkFaxNo { get; set; }

        [Newtonsoft.Json.JsonProperty("employerName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EmployerName { get; set; }

        [Newtonsoft.Json.JsonProperty("occupation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Occupation { get; set; }

        [Newtonsoft.Json.JsonProperty("civilServant", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CivilServant { get; set; }

        [Newtonsoft.Json.JsonProperty("position", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Position { get; set; }

        [Newtonsoft.Json.JsonProperty("lengthOfEmployment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? LengthOfEmployment { get; set; }

        [Newtonsoft.Json.JsonProperty("monthlyIncome", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MonthlyIncome { get; set; }

        [Newtonsoft.Json.JsonProperty("workingInSingapore", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? WorkingInSingapore { get; set; }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class CustomerCorporate
    {
        [Newtonsoft.Json.JsonProperty("customerName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string CustomerName { get; set; }

        [Newtonsoft.Json.JsonProperty("companyRegAddressState", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string CompanyRegAddressState { get; set; }

        [Newtonsoft.Json.JsonProperty("companyRegAddressCity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string CompanyRegAddressCity { get; set; }

        [Newtonsoft.Json.JsonProperty("companyRegAddressDistrict", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string CompanyRegAddressDistrict { get; set; }

        [Newtonsoft.Json.JsonProperty("companyRegAddressStreet", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string CompanyRegAddressStreet { get; set; }

        [Newtonsoft.Json.JsonProperty("companyContactAddressState", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string CompanyContactAddressState { get; set; }

        [Newtonsoft.Json.JsonProperty("companyContactAddressCity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string CompanyContactAddressCity { get; set; }

        [Newtonsoft.Json.JsonProperty("companyContactAddressDistrict", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string CompanyContactAddressDistrict { get; set; }

        [Newtonsoft.Json.JsonProperty("companyContactAddressStreet", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string CompanyContactAddressStreet { get; set; }

        [Newtonsoft.Json.JsonProperty("mobilephone2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Mobilephone2 { get; set; }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Guarantor
    {
        [Newtonsoft.Json.JsonProperty("identityType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string IdentityType { get; set; }

        [Newtonsoft.Json.JsonProperty("cifNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string CifNo { get; set; }

        [Newtonsoft.Json.JsonProperty("idNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string IdNo { get; set; }

        [Newtonsoft.Json.JsonProperty("identificationType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string IdentificationType { get; set; }

        [Newtonsoft.Json.JsonProperty("firstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string FirstName { get; set; }

        [Newtonsoft.Json.JsonProperty("lastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string LastName { get; set; }

        [Newtonsoft.Json.JsonProperty("legalPosition", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string LegalPosition { get; set; }

        [Newtonsoft.Json.JsonProperty("relationship", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Relationship { get; set; }

        [Newtonsoft.Json.JsonProperty("mobilePhone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string MobilePhone { get; set; }

        [Newtonsoft.Json.JsonProperty("remark", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Remark { get; set; }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ContactPerson
    {
        [Newtonsoft.Json.JsonProperty("cifNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string CifNo { get; set; }

        [Newtonsoft.Json.JsonProperty("firstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string FirstName { get; set; }

        [Newtonsoft.Json.JsonProperty("firstNameForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string FirstNameForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("lastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string LastName { get; set; }

        [Newtonsoft.Json.JsonProperty("lastNameForOther", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string LastNameForOther { get; set; }

        [Newtonsoft.Json.JsonProperty("relationship", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Relationship { get; set; }

        [Newtonsoft.Json.JsonProperty("telephone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Telephone { get; set; }

        [Newtonsoft.Json.JsonProperty("mobilePhone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string MobilePhone { get; set; }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Fee
    {
        [Newtonsoft.Json.JsonProperty("item", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Item { get; set; }

        [Newtonsoft.Json.JsonProperty("paidBy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string PaidBy { get; set; }

        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double Amount { get; set; }

        [Newtonsoft.Json.JsonProperty("finance", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public bool Finance { get; set; }

        [Newtonsoft.Json.JsonProperty("deduct", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public bool Deduct { get; set; }

        [Newtonsoft.Json.JsonProperty("payment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Payment { get; set; }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Insurance
    {
        [Newtonsoft.Json.JsonProperty("insuranceType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string InsuranceType { get; set; }

        [Newtonsoft.Json.JsonProperty("chargedPremium", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double ChargedPremium { get; set; }

        [Newtonsoft.Json.JsonProperty("actualPremium", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double ActualPremium { get; set; }

        [Newtonsoft.Json.JsonProperty("finance", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public bool Finance { get; set; }

        [Newtonsoft.Json.JsonProperty("deduct", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Deduct { get; set; }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Incentive
    {
        [Newtonsoft.Json.JsonProperty("incentiveType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string IncentiveType { get; set; }

        [Newtonsoft.Json.JsonProperty("rate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double Rate { get; set; }

        [Newtonsoft.Json.JsonProperty("proveofReceipt", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public bool ProveofReceipt { get; set; }

        [Newtonsoft.Json.JsonProperty("receiptType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string ReceiptType { get; set; }

        [Newtonsoft.Json.JsonProperty("ewt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Ewt { get; set; }

        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double Amount { get; set; }

        [Newtonsoft.Json.JsonProperty("amountIncludeTax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double AmountIncludeTax { get; set; }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class PaymentSchedule
    {
        [Newtonsoft.Json.JsonProperty("term", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public int Term { get; set; }

        [Newtonsoft.Json.JsonProperty("paydate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public System.DateTimeOffset Paydate { get; set; }

        [Newtonsoft.Json.JsonProperty("monthlyPaymentExcludeInsurance", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double MonthlyPaymentExcludeInsurance { get; set; }

        [Newtonsoft.Json.JsonProperty("monthlyPayment", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double MonthlyPayment { get; set; }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class SecurityAssetVchicleFee
    {
        [Newtonsoft.Json.JsonProperty("item", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Item { get; set; }

        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double Amount { get; set; }

        [Newtonsoft.Json.JsonProperty("payment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Payment { get; set; }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class SecurityAssetVchicle
    {
        [Newtonsoft.Json.JsonProperty("subSeqId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string SubSeqId { get; set; }

        [Newtonsoft.Json.JsonProperty("assetProperty", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string AssetProperty { get; set; }

        [Newtonsoft.Json.JsonProperty("assetType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string AssetType { get; set; }

        [Newtonsoft.Json.JsonProperty("assetCategory", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string AssetCategory { get; set; }

        [Newtonsoft.Json.JsonProperty("colleteralForAply", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string ColleteralForAply { get; set; }

        [Newtonsoft.Json.JsonProperty("purpose", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Purpose { get; set; }

        [Newtonsoft.Json.JsonProperty("brand", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Brand { get; set; }

        [Newtonsoft.Json.JsonProperty("model", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Model { get; set; }

        [Newtonsoft.Json.JsonProperty("vehicleType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string VehicleType { get; set; }

        [Newtonsoft.Json.JsonProperty("bodyType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string BodyType { get; set; }

        [Newtonsoft.Json.JsonProperty("transaction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Transaction { get; set; }

        [Newtonsoft.Json.JsonProperty("dateManufacture", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public System.DateTimeOffset DateManufacture { get; set; }

        [Newtonsoft.Json.JsonProperty("age", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public int Age { get; set; }

        [Newtonsoft.Json.JsonProperty("cap", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public int Cap { get; set; }

        [Newtonsoft.Json.JsonProperty("manufacturerNationality", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string ManufacturerNationality { get; set; }

        [Newtonsoft.Json.JsonProperty("displacement", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double Displacement { get; set; }

        [Newtonsoft.Json.JsonProperty("transmission", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Transmission { get; set; }

        [Newtonsoft.Json.JsonProperty("gasoline", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Gasoline { get; set; }

        [Newtonsoft.Json.JsonProperty("vehicleColor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string VehicleColor { get; set; }

        [Newtonsoft.Json.JsonProperty("licenseType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string LicenseType { get; set; }

        [Newtonsoft.Json.JsonProperty("seats", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public int Seats { get; set; }

        [Newtonsoft.Json.JsonProperty("ton", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double Ton { get; set; }

        [Newtonsoft.Json.JsonProperty("platNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string PlatNo { get; set; }

        [Newtonsoft.Json.JsonProperty("engineNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string EngineNo { get; set; }

        [Newtonsoft.Json.JsonProperty("classicNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string ClassicNo { get; set; }

        [Newtonsoft.Json.JsonProperty("vehicleRegNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string VehicleRegNo { get; set; }

        [Newtonsoft.Json.JsonProperty("purchasePrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string PurchasePrice { get; set; }

        [Newtonsoft.Json.JsonProperty("salesAppraisalPrice", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double SalesAppraisalPrice { get; set; }

        [Newtonsoft.Json.JsonProperty("accessories", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public int Accessories { get; set; }

        [Newtonsoft.Json.JsonProperty("remarkforVehiclePrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string RemarkforVehiclePrice { get; set; }

        [Newtonsoft.Json.JsonProperty("downPayment", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double DownPayment { get; set; }

        [Newtonsoft.Json.JsonProperty("regFee", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double RegFee { get; set; }

        [Newtonsoft.Json.JsonProperty("chattelFee", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double ChattelFee { get; set; }

        [Newtonsoft.Json.JsonProperty("bpkbCheckingAndBlocking", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double BpkbCheckingAndBlocking { get; set; }

        [Newtonsoft.Json.JsonProperty("handlingFee", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double HandlingFee { get; set; }

        [Newtonsoft.Json.JsonProperty("insurance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Insurance { get; set; }

        [Newtonsoft.Json.JsonProperty("gpsInstallation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string GpsInstallation { get; set; }

        [Newtonsoft.Json.JsonProperty("securityAssetVchicleFee", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public System.Collections.Generic.ICollection<SecurityAssetVchicleFee> SecurityAssetVchicleFee { get; set; }

        [Newtonsoft.Json.JsonProperty("registrationType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string RegistrationType { get; set; }

        [Newtonsoft.Json.JsonProperty("dLtype", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string DLtype { get; set; }

        [Newtonsoft.Json.JsonProperty("dlNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string DlNo { get; set; }

        [Newtonsoft.Json.JsonProperty("remark", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Remark { get; set; }

        [Newtonsoft.Json.JsonProperty("carUser", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string CarUser { get; set; }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class SecurityAssetMovableFee
    {
        [Newtonsoft.Json.JsonProperty("item", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Item { get; set; }

        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double Amount { get; set; }

        [Newtonsoft.Json.JsonProperty("payment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Payment { get; set; }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class SecurityAssetMovable
    {
        [Newtonsoft.Json.JsonProperty("subSeqId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string SubSeqId { get; set; }

        [Newtonsoft.Json.JsonProperty("assetProperty", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string AssetProperty { get; set; }

        [Newtonsoft.Json.JsonProperty("assetType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string AssetType { get; set; }

        [Newtonsoft.Json.JsonProperty("assetCategory", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string AssetCategory { get; set; }

        [Newtonsoft.Json.JsonProperty("colleteralForAply", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string ColleteralForAply { get; set; }

        [Newtonsoft.Json.JsonProperty("purpose", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Purpose { get; set; }

        [Newtonsoft.Json.JsonProperty("assetName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string AssetName { get; set; }

        [Newtonsoft.Json.JsonProperty("assetFunction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string AssetFunction { get; set; }

        [Newtonsoft.Json.JsonProperty("brand", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Brand { get; set; }

        [Newtonsoft.Json.JsonProperty("model", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Model { get; set; }

        [Newtonsoft.Json.JsonProperty("manufactureYear", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public int ManufactureYear { get; set; }

        [Newtonsoft.Json.JsonProperty("countryofOrigin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string CountryofOrigin { get; set; }

        [Newtonsoft.Json.JsonProperty("unitPrice", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double UnitPrice { get; set; }

        [Newtonsoft.Json.JsonProperty("qty", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public int Qty { get; set; }

        [Newtonsoft.Json.JsonProperty("totalPrice", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double TotalPrice { get; set; }

        [Newtonsoft.Json.JsonProperty("marketPrice", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double MarketPrice { get; set; }

        [Newtonsoft.Json.JsonProperty("assetLocation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string AssetLocation { get; set; }

        [Newtonsoft.Json.JsonProperty("gpsinstallation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Gpsinstallation { get; set; }

        [Newtonsoft.Json.JsonProperty("securityAssetMovableFee", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public System.Collections.Generic.ICollection<SecurityAssetMovableFee> SecurityAssetMovableFee { get; set; }

        [Newtonsoft.Json.JsonProperty("remarkforAssetPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string RemarkforAssetPrice { get; set; }

        [Newtonsoft.Json.JsonProperty("remark", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Remark { get; set; }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class SecurityAssetRealEstateFee
    {
        [Newtonsoft.Json.JsonProperty("item", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Item { get; set; }

        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double Amount { get; set; }

        [Newtonsoft.Json.JsonProperty("payment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Payment { get; set; }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class SecurityAssetRealEstate
    {
        [Newtonsoft.Json.JsonProperty("subSeqId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string SubSeqId { get; set; }

        [Newtonsoft.Json.JsonProperty("assetProperty", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string AssetProperty { get; set; }

        [Newtonsoft.Json.JsonProperty("assetType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string AssetType { get; set; }

        [Newtonsoft.Json.JsonProperty("assetCategory", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string AssetCategory { get; set; }

        [Newtonsoft.Json.JsonProperty("colleteralForAply", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string ColleteralForAply { get; set; }

        [Newtonsoft.Json.JsonProperty("purpose", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Purpose { get; set; }

        [Newtonsoft.Json.JsonProperty("owner", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Owner { get; set; }

        [Newtonsoft.Json.JsonProperty("address", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Address { get; set; }

        [Newtonsoft.Json.JsonProperty("landSizeWidthM", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double LandSizeWidthM { get; set; }

        [Newtonsoft.Json.JsonProperty("buildingSizeWidthM", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double BuildingSizeWidthM { get; set; }

        [Newtonsoft.Json.JsonProperty("purchasePrice", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double PurchasePrice { get; set; }

        [Newtonsoft.Json.JsonProperty("marketPrice", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double MarketPrice { get; set; }

        [Newtonsoft.Json.JsonProperty("mortgageCheck", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string MortgageCheck { get; set; }

        [Newtonsoft.Json.JsonProperty("securityAssetRealEstateFee", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public System.Collections.Generic.ICollection<SecurityAssetRealEstateFee> SecurityAssetRealEstateFee { get; set; }

        [Newtonsoft.Json.JsonProperty("remark", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Remark { get; set; }


    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class CreditModel
    {
        [Newtonsoft.Json.JsonProperty("caseNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string CaseNo { get; set; }

        [Newtonsoft.Json.JsonProperty("applyIDType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string ApplyIDType { get; set; }

        [Newtonsoft.Json.JsonProperty("identityType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string IdentityType { get; set; }

        [Newtonsoft.Json.JsonProperty("cifNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string CifNo { get; set; }

        [Newtonsoft.Json.JsonProperty("identificationType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string IdentificationType { get; set; }

        [Newtonsoft.Json.JsonProperty("idNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string IdNo { get; set; }

        [Newtonsoft.Json.JsonProperty("firstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string FirstName { get; set; }

        [Newtonsoft.Json.JsonProperty("lastName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string LastName { get; set; }

        [Newtonsoft.Json.JsonProperty("dealerCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string DealerCode { get; set; }

        [Newtonsoft.Json.JsonProperty("dealerName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string DealerName { get; set; }

        [Newtonsoft.Json.JsonProperty("agentCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string AgentCode { get; set; }

        [Newtonsoft.Json.JsonProperty("agentName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string AgentName { get; set; }

        [Newtonsoft.Json.JsonProperty("companyId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public int CompanyId { get; set; }

        [Newtonsoft.Json.JsonProperty("productCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string ProductCode { get; set; }

        [Newtonsoft.Json.JsonProperty("productName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string ProductName { get; set; }

        [Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public int Version { get; set; }

        [Newtonsoft.Json.JsonProperty("quotesType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string QuotesType { get; set; }

        [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Currency { get; set; }

        [Newtonsoft.Json.JsonProperty("dealerSource", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string DealerSource { get; set; }

        [Newtonsoft.Json.JsonProperty("purpostNBC", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string PurpostNBC { get; set; }

        [Newtonsoft.Json.JsonProperty("tenureMonth", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public int TenureMonth { get; set; }

        [Newtonsoft.Json.JsonProperty("paymentFrequency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string PaymentFrequency { get; set; }

        [Newtonsoft.Json.JsonProperty("paymentTiming", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string PaymentTiming { get; set; }

        [Newtonsoft.Json.JsonProperty("paymentDueatMonthEnd", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public bool PaymentDueatMonthEnd { get; set; }

        [Newtonsoft.Json.JsonProperty("submussionApplicantID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string SubmussionApplicantID { get; set; }

        [Newtonsoft.Json.JsonProperty("deptID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public int DeptID { get; set; }

        [Newtonsoft.Json.JsonProperty("creditOfficer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string CreditOfficer { get; set; }

        [Newtonsoft.Json.JsonProperty("creditOfficerDept", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public int CreditOfficerDept { get; set; }

        [Newtonsoft.Json.JsonProperty("applyDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public System.DateTimeOffset ApplyDate { get; set; }

        [Newtonsoft.Json.JsonProperty("approvalDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public System.DateTime ApprovalDate { get; set; }

        [Newtonsoft.Json.JsonProperty("interestFlatRate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double InterestFlatRate { get; set; }

        [Newtonsoft.Json.JsonProperty("autoDebitReferenceNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string AutoDebitReferenceNo { get; set; }

        [Newtonsoft.Json.JsonProperty("approvalFinanceAmount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double ApprovalFinanceAmount { get; set; }

        [Newtonsoft.Json.JsonProperty("approvalTotalAmount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double ApprovalTotalAmount { get; set; }

        [Newtonsoft.Json.JsonProperty("annualPercentageRate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double AnnualPercentageRate { get; set; }

        [Newtonsoft.Json.JsonProperty("normalIRR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double NormalIRR { get; set; }

        [Newtonsoft.Json.JsonProperty("realIRR", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double RealIRR { get; set; }

        [Newtonsoft.Json.JsonProperty("npv", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double Npv { get; set; }

        [Newtonsoft.Json.JsonProperty("dealerInvoiceType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string DealerInvoiceType { get; set; }

        [Newtonsoft.Json.JsonProperty("vat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string Vat { get; set; }

        [Newtonsoft.Json.JsonProperty("vatAmount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double VatAmount { get; set; }

        [Newtonsoft.Json.JsonProperty("vaTpaidby", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string VaTpaidby { get; set; }

        [Newtonsoft.Json.JsonProperty("autolife", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public bool Autolife { get; set; }

        [Newtonsoft.Json.JsonProperty("autolifeSumIsured", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double AutolifeSumIsured { get; set; }

        [Newtonsoft.Json.JsonProperty("refinancing", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public bool Refinancing { get; set; }

        [Newtonsoft.Json.JsonProperty("mustAutoDebit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public bool MustAutoDebit { get; set; }

        [Newtonsoft.Json.JsonProperty("settlementContract", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string SettlementContract { get; set; }

        [Newtonsoft.Json.JsonProperty("advancePayment", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double AdvancePayment { get; set; }

        [Newtonsoft.Json.JsonProperty("prepaidRental", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double PrepaidRental { get; set; }

        [Newtonsoft.Json.JsonProperty("securityDeposit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double SecurityDeposit { get; set; }

        [Newtonsoft.Json.JsonProperty("dealerRetention", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double DealerRetention { get; set; }

        [Newtonsoft.Json.JsonProperty("disburseMonth", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public int DisburseMonth { get; set; }

        [Newtonsoft.Json.JsonProperty("totalPayableAmount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double TotalPayableAmount { get; set; }

        [Newtonsoft.Json.JsonProperty("profitInterestInvoiceAmount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double ProfitInterestInvoiceAmount { get; set; }

        [Newtonsoft.Json.JsonProperty("profitInterestInvoiceTax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public double ProfitInterestInvoiceTax { get; set; }

        [Newtonsoft.Json.JsonProperty("creditRemark", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Include)]
        public string CreditRemark { get; set; }

        [Newtonsoft.Json.JsonProperty("customerIndivisual", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerIndivisual CustomerIndivisual { get; set; }

        [Newtonsoft.Json.JsonProperty("customerCorporate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerCorporate CustomerCorporate { get; set; }

        [Newtonsoft.Json.JsonProperty("guarantor", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Guarantor> Guarantor { get; set; }

        [Newtonsoft.Json.JsonProperty("contactPerson", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ContactPerson> ContactPerson { get; set; }

        [Newtonsoft.Json.JsonProperty("fee", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Fee> Fee { get; set; }

        [Newtonsoft.Json.JsonProperty("insurance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Insurance> Insurance { get; set; }

        [Newtonsoft.Json.JsonProperty("incentive", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<Incentive> Incentive { get; set; }

        [Newtonsoft.Json.JsonProperty("paymentSchedule", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<PaymentSchedule> PaymentSchedule { get; set; }

        [Newtonsoft.Json.JsonProperty("securityAssetVchicle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SecurityAssetVchicle> SecurityAssetVchicle { get; set; }

        [Newtonsoft.Json.JsonProperty("securityAssetMovable", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SecurityAssetMovable> SecurityAssetMovable { get; set; }

        [Newtonsoft.Json.JsonProperty("securityAssetRealEstate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SecurityAssetRealEstate> SecurityAssetRealEstate { get; set; }


    }
}

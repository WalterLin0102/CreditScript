using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditScriptDotNet5
{
    public class WriteOffReq
    {
        /// <summary>公司別</summary>
        [Newtonsoft.Json.JsonProperty("companyId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int CompanyId { get; set; }

        /// <summary>幣別</summary>
        [Newtonsoft.Json.JsonProperty("currencyName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CurrencyName { get; set; }

        /// <summary>客戶統編</summary>
        [Newtonsoft.Json.JsonProperty("custNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustNo { get; set; }

        /// <summary>契約編號</summary>
        [Newtonsoft.Json.JsonProperty("contractNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContractNo { get; set; }

        /// <summary>客戶編號</summary>
        [Newtonsoft.Json.JsonProperty("cifNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CifNo { get; set; }

        /// <summary>來源系統代碼</summary>
        [Newtonsoft.Json.JsonProperty("sourceType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int SourceType { get; set; }

        /// <summary>暫收款鎖定KEY</summary>
        [Newtonsoft.Json.JsonProperty("tmpCrdtLockId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TmpCrdtLockId { get; set; }

        /// <summary>查詢人員</summary>
        [Newtonsoft.Json.JsonProperty("userNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UserNo { get; set; }

        /// <summary>證件類別</summary>
        [Newtonsoft.Json.JsonProperty("identificationType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IdentificationType { get; set; }

        /// <summary>是否為伊斯蘭案件</summary>
        [Newtonsoft.Json.JsonProperty("islamic", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Islamic { get; set; }

        /// <summary>是否模糊查詢</summary>
        [Newtonsoft.Json.JsonProperty("fuzzySearch", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool FuzzySearch { get; set; }


    }
    public class WriteOffRsult
    {
        [Newtonsoft.Json.JsonProperty("rtnCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RtnCode { get; set; }

        [Newtonsoft.Json.JsonProperty("msg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Msg { get; set; }

        [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public GetArCrdtResp Data { get; set; }
    }
    public partial class GetArCrdtResp
    {
        /// <summary>暫收款餘額筆數(若無則為0，無後續欄位)</summary>
        [Newtonsoft.Json.JsonProperty("tempBalanceNo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int TempBalanceNo { get; set; }

        /// <summary>暫收款餘額清單</summary>
        [Newtonsoft.Json.JsonProperty("tempBalanceList", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<TempBalanceListResp> TempBalanceList { get; set; }


    }
    public partial class TempBalanceListResp
    {
        /// <summary>暫收款餘額</summary>
        [Newtonsoft.Json.JsonProperty("tempBalance", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double TempBalance { get; set; }

        /// <summary>暫收日期</summary>
        [Newtonsoft.Json.JsonProperty("tempDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TempDate { get; set; }

        /// <summary>暫收款KEY值</summary>
        [Newtonsoft.Json.JsonProperty("tempKey", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int TempKey { get; set; }

        /// <summary>說明</summary>
        [Newtonsoft.Json.JsonProperty("remark", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Remark { get; set; }

        /// <summary>AR_Type</summary>
        [Newtonsoft.Json.JsonProperty("arType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ArType { get; set; }

        /// <summary>AR_Type說明</summary>
        [Newtonsoft.Json.JsonProperty("arTypeRemark", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ArTypeRemark { get; set; }

        /// <summary>幣別</summary>
        [Newtonsoft.Json.JsonProperty("currencyName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CurrencyName { get; set; }

        /// <summary>契約編號</summary>
        [Newtonsoft.Json.JsonProperty("contractNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContractNo { get; set; }

        /// <summary>客戶編號</summary>
        [Newtonsoft.Json.JsonProperty("cifNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CifNo { get; set; }

        /// <summary>客戶名稱</summary>
        [Newtonsoft.Json.JsonProperty("custName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustName { get; set; }

        /// <summary>客戶統編</summary>
        [Newtonsoft.Json.JsonProperty("custNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustNo { get; set; }

        /// <summary>是否為伊斯蘭案件</summary>
        [Newtonsoft.Json.JsonProperty("islamic", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Islamic { get; set; }


    }
}

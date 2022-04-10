using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CreditScriptDotNet5
{
    public class AmendingAssignInital
    {
        [JsonPropertyName("caseNo")]
        public string CaseNo { get; set; }
        [JsonPropertyName("isInitial")]
        public bool IsInitial { get; set; }
        [JsonPropertyName("cap")]
        public int Cap { get; set; }
    }

    public class AmendingAssignReq
    {
        public string CaseNo { get; set; }
        public bool IsInitial { get; set; }
        public int CreditAuditId { get; set; }
        public string UserNo { get; set; }
        public string StageId { get; set; }
        public int RoleId { get; set; }

        /// <summary>車齡+貸款時間</summary>
        [Newtonsoft.Json.JsonProperty("cap", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Cap { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditScriptDotNet5
{
    public class Individual
    {
        public string CifNo { get; set; }
        public string IdentificationTypeId { get; set; }
        public string IdentityNo { get; set; }
        public bool IsUsed { get; set; }
    }
    public class Corporate
    {
        public string CifNo { get; set; }
        public string IdentificationTypeId { get; set; }
        public string IdentityNo { get; set; }
        public string OperatorIdentificationTypeId { get; set; }
        public string OperatorIdentityNo { get; set; }
        public bool IsUsed { get; set; }
    }
}

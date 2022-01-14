using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditScriptDotNet5
{
    public class ApiSetting
    {
        public RequestBody request { get; set; }
        public ResponseBody response { get; set; }
    }
    public class RequestBody
    {
        public string uri { get; set; }
        public string method { get; set; }
        public Dictionary<string, string> queries { get; set; }
    }
    public class ResponseBody
    {
        public FileBody file { get; set; }
    }
    public class FileBody
    {
        public string name { get; set; }
        public string charset { get; set; } = "UTF8";
    }
}

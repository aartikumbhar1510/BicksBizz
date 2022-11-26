using NPOI.SS.Formula.Functions;
using System.Runtime.Serialization;
using System.Xml.Linq;

namespace bricksnetcoreapi.Common
{
    public class CustomMessage
    {
        [DataMember(Name = "IsSuccess")]
        public bool IsSuccess { get; set; }

        [DataMember(Name = "ReturnMessage")]
        public string? ReturnMessage { get; set; }

        [DataMember(Name = "Data")]
        public T? Data { get; set; }
    }
}

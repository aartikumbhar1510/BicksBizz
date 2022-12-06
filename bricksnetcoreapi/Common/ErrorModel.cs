using Newtonsoft.Json;

namespace bricksnetcoreapi.Common
{
    public class ErrorModel
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this); 
        }
    }
}

namespace bricksnetcoreapi.Middleware
{
    public class ExceptionDetail
    {
        public string? ExceptionType { get; set; }
        public string? ExceptionDetails { get; set; }
        public string? MethodName { get; set; }
        public int StatusCode { get; set; }
    }
}

using bricksnetcoreapi.Models;
using System.Net;

namespace bricksnetcoreapi.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public ExceptionMiddleware(RequestDelegate next, ILogger logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var ctx = new BricksBizBdContext();
            try
            {
                   await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError("Something went wrong :{ex}");
               var result =  InsertExcetionDetails(context, ex);
                ctx.Add(result);
                ctx.SaveChanges();


            }
        }

        private async Task InsertExcetionDetails(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            ExceptionDetail exception = new ExceptionDetail()
            {
                ExceptionType = ex.InnerException.ToString(),
                ExceptionDetails = ex.StackTrace,
                StatusCode = (int)HttpStatusCode.InternalServerError,
                MethodName =context.Request.Method.ToString()

            };             

        }
    }
}

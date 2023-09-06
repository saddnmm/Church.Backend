using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text.Json;
using Church.Application.Common.Exceptions;

namespace Church.WebApi.Middleware
{
    public class CustomExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _requestDelegate;

        public CustomExceptionHandlerMiddleware(RequestDelegate requestDelegate) =>
            _requestDelegate = requestDelegate;

        public async Task Invoke(HttpContext content)
        {
            try
            {
                await _requestDelegate(content);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(content, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context,
            Exception exception)
        {
            var code = HttpStatusCode.InternalServerError;
            var result = string.Empty;
            switch (exception)
            {
                case ValidationException validationException:
                    code = HttpStatusCode.BadRequest;
                    result = JsonSerializer.Serialize(validationException);
                    break;
                case NotFoundException directoryNotFoundException:
                    code = HttpStatusCode.NotFound;
                    break;             
            }
            
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;
            if(result == string.Empty)
            {
                result = JsonSerializer.Serialize(new { err = exception.Message });
            }

            return context.Response.WriteAsync(result);
        }
    }
}

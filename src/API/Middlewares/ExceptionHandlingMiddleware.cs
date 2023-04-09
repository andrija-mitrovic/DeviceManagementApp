using API.Helpers;
using Application.Common.Constants;
using System.Text.Json;

namespace API.Middlewares
{
    internal sealed class ExceptionHandlingMiddleware : IMiddleware
    {
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware(ILogger<ExceptionHandlingMiddleware> logger)
        {
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong: {ex}");
                await HandleExceptionAsync(context, ex);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = AppConstants.APPLICATION_JSON;

            var problem = ProblemDetailsGenerator.Generate(exception);

            string json = JsonSerializer.Serialize(problem);

            await context.Response.WriteAsync(json);
        }
    }
}

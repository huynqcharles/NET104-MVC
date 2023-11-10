namespace Middleware_and_Request_Pipeline.CustomMiddlewares
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<LoggingMiddleware> _logger;

        public LoggingMiddleware(RequestDelegate next, ILogger<LoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Log request infor
            _logger.LogInformation($"Resquest: {context.Request.Method} {context.Request.Path}");

            await _next(context);

            // Log response infor
            _logger.LogInformation($"Response: {context.Response.StatusCode}");
        }
    }
}

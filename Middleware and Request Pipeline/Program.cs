// Tạo một đối tượng builder để cấu hình WebApplication
using Middleware_and_Request_Pipeline.CustomMiddlewares;

var builder = WebApplication.CreateBuilder(args);
// Tạo một đối tượng WebApplication
var app = builder.Build();

app.UseMiddleware<LoggingMiddleware>();

app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Middleware 1");
    await next(context);
});

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Middleware 2");
});

// Chạy WebApplication
app.Run();

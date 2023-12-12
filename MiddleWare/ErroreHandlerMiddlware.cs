using FullTrailning.Common;

namespace FullTrailning.MiddleWare;

public class ErroreHandlerMiddlware
{
    private readonly RequestDelegate _next;

    public ErroreHandlerMiddlware(RequestDelegate next)
    {
        _next = next;
    }

    private async Task Invoke (HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);
        }
        catch (Exception ex)
        {
            var error = new Error(DateTime.Now, ex.Message , 500);
            return;
        }
    }
}

public static class HeaderCheckerHandlerExtensions
{
    public static IApplicationBuilder UseHeaderCheckerHandler(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ErroreHandlerMiddlware>();
    }
}

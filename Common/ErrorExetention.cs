using Newtonsoft.Json;

namespace FullTrailning.Common;

public static class ErrorExetention
{
    public static async Task ErrorHandler(this HttpContext context, Error error )
    {
        context.Response.StatusCode = error.StatusCode;
        context.Response.Headers.Add("Content-Type", "application/json");

        await context.Response.WriteAsync(JsonConvert.SerializeObject(error));
    }

}

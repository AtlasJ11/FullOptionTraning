using Newtonsoft.Json;

namespace FullTrailning.Common;

public static class ErrorExetention
{
    public static async Task ErrorHandler(this HttpContext context, object error , int statuscode)
    {
        context.Response.StatusCode = statuscode;
        context.Response.Headers.Add("Content-Type", "application/json");

        await context.Response.WriteAsync(JsonConvert.SerializeObject(error));
    }

}

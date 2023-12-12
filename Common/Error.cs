namespace FullTrailning.Common;

public class Error
{
    public Error(DateTime time, string message , int statusCode)
    {
        DateTime = time;
        Message = message;
        StatusCode = statusCode;
    }

    public DateTime DateTime { get; set; }
    public string Message { get; set; }
    public int StatusCode { get; set; }
}

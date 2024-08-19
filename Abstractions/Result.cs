using System.Net;

namespace GM.Result.Abstractions;
public abstract class Result
{
    public bool IsSuccessful { get; protected set; }
    public HttpStatusCode StatusCode { get; protected set; }

    protected Result(bool isSuccessful, HttpStatusCode statusCode)
    {
        IsSuccessful = isSuccessful;
        StatusCode = statusCode;
    }
}

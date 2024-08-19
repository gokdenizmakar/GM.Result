using System.Net;

namespace GM.Result.Results;
public sealed class SuccessResult<T> : Abstractions.Result
{
    public T? Data { get; }

    private SuccessResult(T data, HttpStatusCode statusCode = HttpStatusCode.OK)
        : base(true, statusCode)
    {
        Data = data;
    }

    public static SuccessResult<T> Create(T data, HttpStatusCode statusCode = HttpStatusCode.OK)
    {
        return new SuccessResult<T>(data, statusCode);
    }
}
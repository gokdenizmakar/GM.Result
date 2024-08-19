using System.Net;

namespace GM.Result.Results;
public class FailureResult : Abstractions.Result
{
    public IReadOnlyList<string> ErrorMessages { get; }

    private FailureResult(List<string> errorMessages, HttpStatusCode statusCode)
        : base(false, statusCode)
    {
        ErrorMessages = errorMessages;
    }

    private FailureResult(string errorMessage, HttpStatusCode statusCode)
        : this(new List<string> { errorMessage }, statusCode)
    {
    }

    public static FailureResult Create(List<string> errorMessages, HttpStatusCode statusCode)
    {
        return new FailureResult(errorMessages, statusCode);
    }

    public static FailureResult Create(string errorMessage, HttpStatusCode statusCode)
    {
        return new FailureResult(errorMessage, statusCode);
    }
}
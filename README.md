# GM.Result

`GM.Result` is a simple, flexible result management library designed for use in .NET applications, especially in REST APIs. It provides standardized classes to handle both success and failure cases in a uniform way, making your API responses consistent and maintainable.

## Features

- **SuccessResult<T>**: Represents successful API responses, carrying data of type `T`.
- **FailureResult**: Represents failed API responses with detailed error messages.
- Uses **HttpStatusCode** to represent the status of operations, ensuring proper HTTP response codes.

## Installation

Install the `GM.Result` library via NuGet Package Manager:

```bash
dotnet add package GM.Result
```

## Usage in REST APIs

Use SuccessResult<T> to return successful results from your API actions:

```csharp
using GM.Result.Results;
using Microsoft.AspNetCore.Mvc;
using System.Net;

[ApiController]
[Route("api/[controller]")]
public class SampleController : ControllerBase
{
    [HttpGet]
    public IActionResult GetData()
    {
        var data = new { Name = "John Doe", Age = 30 };
        var result = SuccessResult<object>.Create(data, HttpStatusCode.OK);
        return Ok(result);
    }

    [HttpGet("error")]
    public IActionResult GetError()
    {
        var errorMessage = "Something went wrong";
        var result = FailureResult.Create(errorMessage, HttpStatusCode.BadRequest);
        return BadRequest(result);
    }
}
```

### Example JSON Responses
Success Response:

```json
{
    "isSuccessful": true,
    "statusCode": 200,
    "data": {
        "name": "John Doe",
        "age": 30
    }
}
```

### Failure Response:

```json
{
    "isSuccessful": false,
    "statusCode": 400,
    "errorMessages": [
        "Something went wrong"
    ]
}
```

## License
This project is licensed under the MIT License - see the LICENSE file for details.
using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace Karooooo.DriverPlanning.Presentation.Endpoints
{
    public class HelloRequest
    {
        public string Name { get; set; }
    }

    public class HelloResponse
    {
        public string Message { get; set; }
    }

    [HttpPost("/hello")]
    [AllowAnonymous]
    public class HelloEndpoint: Endpoint<HelloRequest, HelloResponse>
    {
       private readonly ILogger<HelloEndpoint> _logger;
        public HelloEndpoint(ILogger<HelloEndpoint> logger)
        {
            _logger = logger;
        }

        public override async Task HandleAsync(HelloRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Hello {Name}", request.Name);

            await SendAsync(new HelloResponse { Message = $"Hello, {request.Name}!" }, cancellation: cancellationToken);
        }
    }
}

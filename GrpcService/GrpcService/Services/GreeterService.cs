using Grpc.Core;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace GrpcService
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }

        public override async Task GetPwTalks(GetPwTalksRequest request, IServerStreamWriter<GetPwTalksResponse> response, ServerCallContext serverCall)
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(1000);
                await response.WriteAsync(new GetPwTalksResponse { Talk = $"GRPC {i}" });
            }
        }

    }
}

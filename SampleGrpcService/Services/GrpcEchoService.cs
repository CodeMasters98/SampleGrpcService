using Grpc.Core;
using SampleGrpcService.Protos;

namespace SampleGrpcService.Services
{
    public class GrpcEchoService : EchoService.EchoServiceBase
    {
        public override Task<EchoResponse> SayHello(EchoRequest request, ServerCallContext context)
        {
            return Task.FromResult(new EchoResponse()
            {
                Message = $"Hi From {request.Name}"
            });
        }
    }
}

using SampleGrpcService.Services;

namespace SampleGrpcService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Add services to the container.
            builder.Services.AddGrpc(option =>
            {
                option.EnableDetailedErrors = true;
                option.MaxReceiveMessageSize = 1 * 1024 * 1024; //1 MB default: 4Mb
                option.MaxSendMessageSize = 1 * 1024 * 1024; //1 MB default: no limit
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.MapGrpcService<GreeterService>();
            app.MapGrpcService<GrpcEchoService>();
            app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

            app.Run();
        }
    }
}
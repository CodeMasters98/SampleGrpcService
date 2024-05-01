using Grpc.Net.Client;
using SampleGrpcService.Protos;

namespace SampleGrpcService.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string address = "";
            var channel = GrpcChannel.ForAddress(address);

            var client = new EchoService.EchoServiceClient(channel);

            Console.WriteLine("Please enter your name?");
            string name = Console.ReadLine();
            var response = client.SayHello(new EchoRequest() { Name = name });
            Console.WriteLine(response.Message);
        }
    }
}

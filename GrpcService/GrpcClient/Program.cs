using Grpc.Core;
using Grpc.Net.Client;
using GrpcService;
using System;
using System.Threading.Tasks;

namespace GrpcClient
{
    static class Program
    {
        static async Task Main()
        {

            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);
           
            
            var reply = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient Message" });
            Console.WriteLine("Greeting: " + reply.Message);
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();

            using var call = client.GetPwTalks(new GetPwTalksRequest { Day = 2 });
            while (await call.ResponseStream.MoveNext())
            {
                Console.WriteLine("Greeting: " + call.ResponseStream.Current.Talk);
            }


        }
    }
}

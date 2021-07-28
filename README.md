# grpc-hello-world-dotnet

Projeto de exemplo de uso da tecnologia gRPC. Foi criado um servidor web e um cliente do tipo console ambos com .Net.

## Criando Server

    dotnet new grpc -n server-name

## Criando Client

    dotnet new console -n client-name

### Configurando proto file

![image](resources/config-proto.png)

## Configurando Client

### Adicionando referência do server

![image](resources/add-service.png)

![image](resources/select-proto-file.png)

![image](resources/auto-install-lib.png)

## Como rodar

Adicionar os dois projetos a inicialização da solução (ou rodar ambos separados).

![image](resources/server-and-client.png)

## Como criar outros métodos

### No Server

- Adicionar método rpc dentro do arquivo [greet.proto](GrpcService/GrpcClient/../GrpcService/Protos/greet.proto) 
- Buildar a aplicação para gerar o contrato automaticamente
- Expor o método em uma classe de serviço como essa [GreeterService](GrpcService/GrpcService/Services/GreeterService.cs)

### No client

- Criar client e chamar os métodos definidos em contrato

        using var channel = GrpcChannel.ForAddress("https://localhost:5001");
        var client = new Greeter.GreeterClient(channel);

        // metodo A
        var reply = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient Message" });
        Console.WriteLine("Greeting: " + reply.Message);
        Console.WriteLine("Press any key to exit ...");
        Console.ReadKey();

        // metodo B (stream)
        using var call = client.GetPwTalks(new GetPwTalksRequest { Day = 2 });
        while (await call.ResponseStream.MoveNext())
        {
            Console.WriteLine("Greeting: " + call.ResponseStream.Current.Talk);
        }

## Fonte

COGNIZANT SOFTVISION Youtube by [Building a gRPC service with .NET Core](https://youtu.be/5jsp1pN9nVg)

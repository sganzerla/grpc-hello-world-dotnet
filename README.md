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

## Fonte

COGNIZANT SOFTVISION Youtube by [Building a gRPC service with .NET Core](https://youtu.be/5jsp1pN9nVg)

# grpc-hello-world-dotnet

## Criando Server

    dotnet new grpc -n Backend
    mv .\Backend\Protos\ .\ 

Alterar o path do Protobuf no projeto `Backend.csproj` para um nível acima na hierarquia de diretórios.

    <Project Sdk="Microsoft.NET.Sdk.Web">
    <PropertyGroup>
        <TargetFramework>net6.0</TargetFramework>
        <Nullable>enable</Nullable>
        <ImplicitUsings>enable</ImplicitUsings>
    </PropertyGroup>


    <ItemGroup>
        <Protobuf Include="..\Protos\greet.proto" GrpcServices="Server" />
    </ItemGroup>


    <ItemGroup>
        <PackageReference Include="Grpc.AspNetCore" Version="2.40.0" />
    </ItemGroup>
    </Project>

## Criando Client

    dotnet new web -n Frontend
    


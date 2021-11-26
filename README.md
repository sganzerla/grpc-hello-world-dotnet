# grpc-hello-world-dotnet

## Criando Server

    dotnet new grpc -F net5.0 -n Backend
    mv .\Backend\Protos\ .\ 

Alterar o path no `<ItemGroup>` do Protobuf no projeto `Backend.csproj` para um nível acima na hierarquia de diretórios.

    <Project Sdk="Microsoft.NET.Sdk.Web">

    <PropertyGroup>
        <TargetFramework>net5.0</TargetFramework>
    </PropertyGroup>

    <ItemGroup>
        <Protobuf Include="..\Proto\greet.proto" GrpcServices="Server" Link="Protos\greet.proto" />

        <PackageReference Include="Grpc.AspNetCore" Version="$(GrpcDotNetPackageVersion)" />
    </ItemGroup>

    </Project>

## Criando Client

    dotnet new web -n Frontend


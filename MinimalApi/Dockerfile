# Use uma imagem base do .NET SDK para buildar o projeto
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copiar e restaurar dependências
COPY *.csproj ./
RUN dotnet restore

# Copiar todos os arquivos e buildar o projeto
COPY . ./
RUN dotnet publish -c Release -o out

# Use uma imagem base do .NET runtime para rodar a aplicação
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

# Expor a porta para a Minimal API
EXPOSE 8081

# Configurar a execução do projeto
ENTRYPOINT ["dotnet", "MinimalApi.dll"]

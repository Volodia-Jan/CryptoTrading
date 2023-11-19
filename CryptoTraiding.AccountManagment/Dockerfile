FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["CryptoTraiding.AccountManagment.API/CryptoTraiding.AccountManagment.API.csproj", "CryptoTraiding.AccountManagment.API/"]
COPY ["AccountManagement.Domain/AccountManagement.Domain.csproj", "AccountManagement.Domain/"]
COPY ["AccountManagement.Infrastructure/AccountManagement.Infrastructure.csproj", "AccountManagement.Infrastructure/"]
RUN dotnet restore "CryptoTraiding.AccountManagment.API/CryptoTraiding.AccountManagment.API.csproj"
COPY . .
WORKDIR "/src/CryptoTraiding.AccountManagment.API"
RUN dotnet build "CryptoTraiding.AccountManagment.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CryptoTraiding.AccountManagment.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CryptoTraiding.AccountManagment.API.dll"]

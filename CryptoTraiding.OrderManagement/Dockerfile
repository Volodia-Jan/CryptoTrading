FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["CryptoTraiding.OrderManagement/CryptoTraiding.OrderManagement.csproj", "CryptoTraiding.OrderManagement/"]
COPY ["OrderManagement.Infrastructure/OrderManagement.Infrastructure.csproj", "OrderManagement.Infrastructure/"]
COPY ["OrderManagement.Domain/OrderManagement.Domain.csproj", "OrderManagement.Domain/"]
RUN dotnet restore "CryptoTraiding.OrderManagement/CryptoTraiding.OrderManagement.csproj"
COPY . .
WORKDIR "/src/CryptoTraiding.OrderManagement"
RUN dotnet build "CryptoTraiding.OrderManagement.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CryptoTraiding.OrderManagement.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CryptoTraiding.OrderManagement.dll"]

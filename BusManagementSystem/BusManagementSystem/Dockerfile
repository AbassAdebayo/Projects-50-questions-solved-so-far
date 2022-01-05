FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["BusManagementSystem/BusManagementSystem.csproj", "BusManagementSystem/"]
RUN dotnet restore "BusManagementSystem/BusManagementSystem.csproj"
COPY . .
WORKDIR "/src/BusManagementSystem"
RUN dotnet build "BusManagementSystem.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BusManagementSystem.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BusManagementSystem.dll"]

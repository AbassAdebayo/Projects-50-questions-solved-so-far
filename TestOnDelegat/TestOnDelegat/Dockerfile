FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["TestOnDelegat/TestOnDelegat.csproj", "TestOnDelegat/"]
RUN dotnet restore "TestOnDelegat/TestOnDelegat.csproj"
COPY . .
WORKDIR "/src/TestOnDelegat"
RUN dotnet build "TestOnDelegat.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestOnDelegat.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestOnDelegat.dll"]

﻿FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Indexer/Indexer.csproj", "Indexer/"]
RUN dotnet restore "Indexer/Indexer.csproj"
COPY . .
WORKDIR "/src/Indexer"
RUN dotnet build "Indexer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Indexer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Indexer.dll"]

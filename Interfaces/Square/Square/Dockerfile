FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Square/Square.csproj", "Square/"]
RUN dotnet restore "Square/Square.csproj"
COPY . .
WORKDIR "/src/Square"
RUN dotnet build "Square.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Square.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Square.dll"]

FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["MyDelegate/MyDelegate.csproj", "MyDelegate/"]
RUN dotnet restore "MyDelegate/MyDelegate.csproj"
COPY . .
WORKDIR "/src/MyDelegate"
RUN dotnet build "MyDelegate.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyDelegate.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyDelegate.dll"]

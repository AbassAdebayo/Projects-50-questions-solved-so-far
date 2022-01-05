FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Class Human/Class Human.csproj", "Class Human/"]
RUN dotnet restore "Class Human/Class Human.csproj"
COPY . .
WORKDIR "/src/Class Human"
RUN dotnet build "Class Human.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Class Human.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Class Human.dll"]

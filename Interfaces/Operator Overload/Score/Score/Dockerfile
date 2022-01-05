FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Score/Score.csproj", "Score/"]
RUN dotnet restore "Score/Score.csproj"
COPY . .
WORKDIR "/src/Score"
RUN dotnet build "Score.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Score.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Score.dll"]

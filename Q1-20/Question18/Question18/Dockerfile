FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Question18/Question18.csproj", "Question18/"]
RUN dotnet restore "Question18/Question18.csproj"
COPY . .
WORKDIR "/src/Question18"
RUN dotnet build "Question18.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Question18.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Question18.dll"]

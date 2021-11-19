FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Question17/Question17.csproj", "Question17/"]
RUN dotnet restore "Question17/Question17.csproj"
COPY . .
WORKDIR "/src/Question17"
RUN dotnet build "Question17.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Question17.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Question17.dll"]

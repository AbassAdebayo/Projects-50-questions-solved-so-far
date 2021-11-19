FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Question6/Question6.csproj", "Question6/"]
RUN dotnet restore "Question6/Question6.csproj"
COPY . .
WORKDIR "/src/Question6"
RUN dotnet build "Question6.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Question6.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Question6.dll"]

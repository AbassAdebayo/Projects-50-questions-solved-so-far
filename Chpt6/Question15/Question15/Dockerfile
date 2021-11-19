FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Question15/Question15.csproj", "Question15/"]
RUN dotnet restore "Question15/Question15.csproj"
COPY . .
WORKDIR "/src/Question15"
RUN dotnet build "Question15.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Question15.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Question15.dll"]

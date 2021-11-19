FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Question12A/Question12A.csproj", "Question12A/"]
RUN dotnet restore "Question12A/Question12A.csproj"
COPY . .
WORKDIR "/src/Question12A"
RUN dotnet build "Question12A.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Question12A.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Question12A.dll"]

FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Question13/Question13.csproj", "Question13/"]
RUN dotnet restore "Question13/Question13.csproj"
COPY . .
WORKDIR "/src/Question13"
RUN dotnet build "Question13.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Question13.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Question13.dll"]

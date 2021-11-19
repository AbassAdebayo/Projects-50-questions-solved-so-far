FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Question16/Question16.csproj", "Question16/"]
RUN dotnet restore "Question16/Question16.csproj"
COPY . .
WORKDIR "/src/Question16"
RUN dotnet build "Question16.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Question16.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Question16.dll"]

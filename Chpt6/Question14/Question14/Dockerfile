FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Question14/Question14.csproj", "Question14/"]
RUN dotnet restore "Question14/Question14.csproj"
COPY . .
WORKDIR "/src/Question14"
RUN dotnet build "Question14.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Question14.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Question14.dll"]

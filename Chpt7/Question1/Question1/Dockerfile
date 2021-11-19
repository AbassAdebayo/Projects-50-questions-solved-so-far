FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Question1/Question1.csproj", "Question1/"]
RUN dotnet restore "Question1/Question1.csproj"
COPY . .
WORKDIR "/src/Question1"
RUN dotnet build "Question1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Question1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Question1.dll"]

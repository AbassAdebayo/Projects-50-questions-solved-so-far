FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Question12/Question12.csproj", "Question12/"]
RUN dotnet restore "Question12/Question12.csproj"
COPY . .
WORKDIR "/src/Question12"
RUN dotnet build "Question12.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Question12.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Question12.dll"]

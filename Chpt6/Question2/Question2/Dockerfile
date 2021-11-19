FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Question2/Question2.csproj", "Question2/"]
RUN dotnet restore "Question2/Question2.csproj"
COPY . .
WORKDIR "/src/Question2"
RUN dotnet build "Question2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Question2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Question2.dll"]

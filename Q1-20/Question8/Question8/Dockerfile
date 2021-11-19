FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Question8/Question8.csproj", "Question8/"]
RUN dotnet restore "Question8/Question8.csproj"
COPY . .
WORKDIR "/src/Question8"
RUN dotnet build "Question8.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Question8.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Question8.dll"]

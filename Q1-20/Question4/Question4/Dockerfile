FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Question4/Question4.csproj", "Question4/"]
RUN dotnet restore "Question4/Question4.csproj"
COPY . .
WORKDIR "/src/Question4"
RUN dotnet build "Question4.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Question4.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Question4.dll"]

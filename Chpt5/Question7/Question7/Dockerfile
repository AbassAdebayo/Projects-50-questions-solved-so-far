FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Question7/Question7.csproj", "Question7/"]
RUN dotnet restore "Question7/Question7.csproj"
COPY . .
WORKDIR "/src/Question7"
RUN dotnet build "Question7.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Question7.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Question7.dll"]

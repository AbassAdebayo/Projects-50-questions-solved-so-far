FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Question11/Question11.csproj", "Question11/"]
RUN dotnet restore "Question11/Question11.csproj"
COPY . .
WORKDIR "/src/Question11"
RUN dotnet build "Question11.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Question11.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Question11.dll"]

FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Question10/Question10.csproj", "Question10/"]
RUN dotnet restore "Question10/Question10.csproj"
COPY . .
WORKDIR "/src/Question10"
RUN dotnet build "Question10.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Question10.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Question10.dll"]

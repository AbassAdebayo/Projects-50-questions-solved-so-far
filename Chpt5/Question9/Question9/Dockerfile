FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Question9/Question9.csproj", "Question9/"]
RUN dotnet restore "Question9/Question9.csproj"
COPY . .
WORKDIR "/src/Question9"
RUN dotnet build "Question9.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Question9.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Question9.dll"]

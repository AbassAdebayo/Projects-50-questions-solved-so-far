FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Question19/Question19.csproj", "Question19/"]
RUN dotnet restore "Question19/Question19.csproj"
COPY . .
WORKDIR "/src/Question19"
RUN dotnet build "Question19.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Question19.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Question19.dll"]

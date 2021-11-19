FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Question5/Question5.csproj", "Question5/"]
RUN dotnet restore "Question5/Question5.csproj"
COPY . .
WORKDIR "/src/Question5"
RUN dotnet build "Question5.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Question5.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Question5.dll"]

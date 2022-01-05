FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["QUIZ/QUIZ.csproj", "QUIZ/"]
RUN dotnet restore "QUIZ/QUIZ.csproj"
COPY . .
WORKDIR "/src/QUIZ"
RUN dotnet build "QUIZ.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "QUIZ.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "QUIZ.dll"]

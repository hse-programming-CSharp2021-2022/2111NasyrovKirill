FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["homework32.csproj", "./"]
RUN dotnet restore "homework32.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "homework32.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "homework32.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "homework32.dll"]

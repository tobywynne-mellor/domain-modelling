FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["Domain Modelling/Domain Modelling.fsproj", "Domain Modelling/"]
RUN dotnet restore "Domain Modelling/Domain Modelling.fsproj"
COPY . .
WORKDIR "/src/Domain Modelling"
RUN dotnet build "Domain Modelling.fsproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Domain Modelling.fsproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Domain Modelling.dll"]

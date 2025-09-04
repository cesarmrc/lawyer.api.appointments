FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
ENV DOTNET_ENVIRONMENT=Docker
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["lawyer.api.appointments.webapi/lawyer.api.appointments.webapi.csproj", "lawyer.api.appointments.webapi/"]
COPY ["lawyer.api.appointments.application/lawyer.api.appointments.application.csproj", "lawyer.api.appointments.application/"]
COPY ["lawyer.api.appointments.domain/lawyer.api.appointments.domain.csproj", "lawyer.api.appointments.domain/"]
COPY ["lawyer.api.appointments.datastore.mssql/lawyer.api.appointments.datastore.mssql.csproj", "lawyer.api.appointments.datastore.mssql/"]
RUN dotnet restore "lawyer.api.appointments.webapi/lawyer.api.appointments.webapi.csproj"
COPY . .
WORKDIR "/src/lawyer.api.appointments.webapi"
RUN dotnet build "./lawyer.api.appointments.webapi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./lawyer.api.appointments.webapi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "lawyer.api.appointments.webapi.dll"]

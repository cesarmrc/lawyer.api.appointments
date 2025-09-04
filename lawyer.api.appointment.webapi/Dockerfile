FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
ENV DOTNET_ENVIRONMENT=Docker
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["lawyer.api.appointment.webapi/lawyer.api.appointment.webapi.csproj", "lawyer.api.appointment.webapi/"]
COPY ["lawyer.api.appointment.application/lawyer.api.appointment.application.csproj", "lawyer.api.appointment.application/"]
COPY ["lawyer.api.appointment.domain/lawyer.api.appointment.domain.csproj", "lawyer.api.appointment.domain/"]
COPY ["lawyer.api.appointment.datastore.mssql/lawyer.api.appointment.datastore.mssql.csproj", "lawyer.api.appointment.datastore.mssql/"]
RUN dotnet restore "lawyer.api.appointment.webapi/lawyer.api.appointment.webapi.csproj"
COPY . .
WORKDIR "/src/lawyer.api.appointment.webapi"
RUN dotnet build "./lawyer.api.appointment.webapi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./lawyer.api.appointment.webapi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "lawyer.api.appointment.webapi.dll"]

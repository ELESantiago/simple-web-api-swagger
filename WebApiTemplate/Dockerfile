FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["WebApiTemplate/WebApiTemplate.csproj", "WebApiTemplate/"]
RUN dotnet restore "WebApiTemplate/WebApiTemplate.csproj"
COPY . .
WORKDIR "/src/WebApiTemplate"
RUN dotnet build "WebApiTemplate.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebApiTemplate.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApiTemplate.dll"]
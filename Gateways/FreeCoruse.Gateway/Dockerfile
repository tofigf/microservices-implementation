FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim as build
WORKDIR /app
EXPOSE 80

COPY  Gateways/FreeCoruse.Gateway/*.csproj  Gateways/FreeCoruse.Gateway/
RUN dotnet restore Gateways/FreeCoruse.Gateway/*.csproj
COPY . .
RUN dotnet publish Gateways/FreeCoruse.Gateway/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","FreeCoruse.Gateway.dll" ]
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR webapp

EXPOSE 80
EXPOSE 5001

# COPY PROJECT FILES
COPY ./*.csproj ./
RUN dotnet restore

# COPY OTHER FILES
COPY . .
RUN dotnet publish -c Release -o out

# BUILD IMAGE
FROM mcr.microsoft.com/dotnet/sdk:8.0
WORKDIR /webapp
COPY --from=build /webapp/out .
ENTRYPOINT ["dotnet", "MyWebApi.dll"]

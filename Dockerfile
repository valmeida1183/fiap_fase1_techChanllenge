# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy csproj files and restore dependencies
COPY ["01_WebApi/01_WebApi.csproj", "01_WebApi/"]
COPY ["Application/02_Application.csproj", "Application/"]
COPY ["03_Core/03_Core.csproj", "03_Core/"]
COPY ["04_Infraestructure/04_Infraestructure.csproj", "04_Infraestructure/"]

RUN dotnet restore "01_WebApi/01_WebApi.csproj"

# Copy the rest of the source code
COPY . .

# Build the application
RUN dotnet build "01_WebApi/01_WebApi.csproj" -c Release -o /app/build

# Publish stage
FROM build AS publish
RUN dotnet publish "01_WebApi/01_WebApi.csproj" -c Release -o /app/publish

# Final stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .

# Expose ports
EXPOSE 8080
EXPOSE 8081

# Set environment variables
ENV ASPNETCORE_URLS=http://+:8080;https://+:8081
ENV ASPNETCORE_ENVIRONMENT=Development
ENV ASPNETCORE_HTTP_PORTS=8080
ENV ASPNETCORE_HTTPS_PORTS=8081
ENV ASPNETCORE_Kestrel__Certificates__Default__Path=/app/cert/cert.pfx
ENV ASPNETCORE_Kestrel__Certificates__Default__Password=password123

# Create certificate
RUN apt-get update && \
    apt-get install -y openssl && \
    mkdir -p /app/cert && \
    openssl req -x509 -newkey rsa:4096 -keyout /app/cert/key.pem -out /app/cert/cert.pem -days 365 -nodes -subj "/CN=localhost" && \
    openssl pkcs12 -export -out /app/cert/cert.pfx -inkey /app/cert/key.pem -in /app/cert/cert.pem -passout pass:password123

ENTRYPOINT ["dotnet", "01_WebApi.dll"]
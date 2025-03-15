# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy solution and project files
COPY ["01_WebApi/01_WebApi.csproj", "01_WebApi/"]
COPY ["Application/02_Application.csproj", "Application/"]
COPY ["03_Core/03_Core.csproj", "03_Core/"]
COPY ["04_Infraestructure/04_Infraestructure.csproj", "04_Infraestructure/"]

# Restore dependencies
RUN dotnet restore "01_WebApi/01_WebApi.csproj"

# Copy the rest of the source code
COPY . .

# Build and publish
RUN dotnet publish "01_WebApi/01_WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Install EF Core tools
RUN dotnet tool install --global dotnet-ef --version 8.0.11

# Runtime stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
COPY --from=build /root/.dotnet/tools /root/.dotnet/tools
ENV PATH="$PATH:/root/.dotnet/tools"

# Copy source code for migrations
COPY ["04_Infraestructure", "/src/04_Infraestructure"]
COPY ["03_Core", "/src/03_Core"]
COPY ["01_WebApi/appsettings.json", "/src/01_WebApi/appsettings.json"]

# Install Zabbix Agent
RUN apt-get update && apt-get install -y wget gnupg2 && \
    wget https://repo.zabbix.com/zabbix/6.4/debian/pool/main/z/zabbix-release/zabbix-release_6.4-1+debian12_all.deb && \
    dpkg -i zabbix-release_6.4-1+debian12_all.deb && \
    apt-get update && \
    apt-get install -y zabbix-agent && \
    rm -rf /var/lib/apt/lists/*

# Configure Zabbix Agent
COPY zabbix_agentd.conf /etc/zabbix/zabbix_agentd.conf

# Create entrypoint script
COPY entrypoint.sh /app/entrypoint.sh
RUN chmod +x /app/entrypoint.sh

# Expose port 8080
EXPOSE 8080

# Expose Zabbix agent port
EXPOSE 10051

ENTRYPOINT ["/app/entrypoint.sh"]
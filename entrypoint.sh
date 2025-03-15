#!/bin/bash
set -e

# Wait for SQL Server to be ready
echo "Waiting for SQL Server to be ready..."
sleep 10

# Run migrations
echo "Running database migrations..."
cd /src
dotnet ef database update --project 04_Infraestructure --startup-project 04_Infraestructure

# Start Zabbix agent in foreground mode (but run it in background)
## Ensure that logfile exists
echo "Ensure Zabbix agent logfile exists..."
mkdir -p /var/log/zabbix
chown -R zabbix:zabbix /var/log/zabbix
echo "Starting Zabbix agent..."
mkdir -p /var/run/zabbix
chown -R zabbix:zabbix /var/run/zabbix
/usr/sbin/zabbix_agentd -f &

# Start the application
echo "Starting application..."
cd /app
exec dotnet 01_WebApi.dll

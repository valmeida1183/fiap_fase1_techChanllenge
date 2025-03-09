#!/bin/bash
set -e

# Wait for SQL Server to be ready
echo "Waiting for SQL Server to be ready..."
sleep 10

# Run migrations
echo "Running database migrations..."
cd /src
dotnet ef database update --project 04_Infraestructure --startup-project 04_Infraestructure

# Start the application
echo "Starting application..."
cd /app
exec dotnet 01_WebApi.dll
#!/bin/bash
set -e

until /root/.dotnet/tools/dotnet-ef database update --project 04_Infraestructure --startup-project 04_Infraestructure; do
    >&2 echo "SQL Server is starting up or not ready - retrying in 5 seconds..."
    sleep 5
done

>&2 echo "SQL Server is up - executing command"
exec "$@"

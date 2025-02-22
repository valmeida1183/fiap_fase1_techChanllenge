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

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# Set environment variables
ENV ASPNETCORE_URLS=http://+:80
ENV ASPNETCORE_ENVIRONMENT=Production

# Expose port 80
EXPOSE 80

ENTRYPOINT ["dotnet", "01_WebApi.dll"]
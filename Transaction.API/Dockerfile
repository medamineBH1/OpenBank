# Use the ASP.NET runtime image as the base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0-nanoserver-1809 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Use the .NET SDK image to build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0-nanoserver-1809 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copy the project file and restore dependencies
COPY ["Transaction.API/Transaction.API.csproj", "Transaction.API/"]
RUN dotnet restore "Transaction.API/Transaction.API.csproj"

# Copy the rest of the source code
COPY . .

# Build the project
WORKDIR "/src/Transaction.API"
RUN dotnet build "Transaction.API.csproj" -c ${BUILD_CONFIGURATION} -o /app/build

# Publish the project
FROM build AS publish
RUN dotnet publish "Transaction.API.csproj" -c ${BUILD_CONFIGURATION} -o /app/publish /p:UseAppHost=false

# Final stage: copy published output and set entry point
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Transaction.API.dll"]

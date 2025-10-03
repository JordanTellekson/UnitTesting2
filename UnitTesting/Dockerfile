# ----------------
# Build stage
# ----------------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy csproj and restore
COPY ["UnitTesting.csproj", "./"]
RUN dotnet restore "UnitTesting.csproj"

# Copy all files and publish
COPY . .
RUN dotnet publish "UnitTesting.csproj" -c Release -o /app/publish

# ----------------
# Runtime stage
# ----------------
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Expose HTTP port
ENV ASPNETCORE_URLS=http://+:9090
EXPOSE 9090

# Copy published files
COPY --from=build /app/publish .

# Run the app
ENTRYPOINT ["dotnet", "UnitTesting.dll"]
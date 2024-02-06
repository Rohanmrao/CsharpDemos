# The dockerfile for the project 

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# This line copies ass .csproj files from the local dir to the docker working dir
COPY *.csproj ./

# Restore all dotnet dependencies 
RUN dotnet restore

# Copy all the remaining files in local dir to the docker working dir
COPY . ./

# Publish the Release build and keep the files in folder dockerFinal/
RUN dotnet publish -c Release -o dockerFinal

# Pulling the aspnet runtime docker image 
FROM mcr.microsoft.com/dotnet/aspnet:8.0

WORKDIR /app

COPY --from=build /app/dockerFinal .

# Runs dotnet interfaceDemo.dll (which is inside bin/Release/)
ENTRYPOINT [ "dotnet", "interface.demo.dll" ]

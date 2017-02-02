# How to Get Started

## Prerequisits 

Make sure you have .NET Core and Docker installed and that Docker has at least 3.25gb of memory.

## Instructions

1. Run scripts/startup.sh in the terminal to download the latest MS SQL Docker image and start the container
2. In the CLI, run `dotnet ef migrations add MSSQL` to create a migration
3. Then run `dotnet ef database update`to update the database
4. Next, run `dotnet run` you should see a new blog url in the CLI output!
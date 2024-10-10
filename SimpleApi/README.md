dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL

dotnet tool install --global dotnet-ef

dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet ef migrations add Init

dotnet ef database update

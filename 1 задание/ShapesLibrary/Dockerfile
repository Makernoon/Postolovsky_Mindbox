FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

COPY . .
RUN dotnet restore && dotnet build --no-restore && dotnet test --no-restore --verbosity=normal

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "Shapes.dll"]
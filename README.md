# API de Artículos

API REST en ASP.NET Core con Entity Framework Core, AutoMapper y el patrón repositorio para gestionar artículos.

## Ejecutar

1. Configurar la cadena de conexión en `appsettings.json` (por defecto usa SQL Server LocalDB).
2. Aplicar las migraciones: `dotnet ef database update`
3. Iniciar: `dotnet run` y abrir `/swagger`.

MarcasAutosApi

Este proyecto es una API para gestionar las marcas de automóviles. Utiliza .NET Core y PostgreSQL como base de datos.

Requisitos

    NET 8.0 SDK
    Docker
    Docker Compose
    PostgreSQL
    Instalación y configuración

1. Descomprimir el Archivo .zip

2. Configurar la base de datos
Asegúrate de que tu archivo appsettings.json esté correctamente configurado con los detalles de la conexión a la base de datos. Un ejemplo de la sección de ConnectionStrings podría verse así:

{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Database=MarcasDB;Username=postgres;Password=tu_password"
  }
}

3. Levantar el entorno con Docker
4. Ejecutar Docker Compose
5. Aplicar migraciones

Después de que la base de datos esté en marcha, puedes aplicar las migraciones de la base de datos para crear las tablas necesarias:
    
   dotnet ef database update

6. Ejecutar la API: para ejecutar la API:

    dotnet run



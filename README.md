Proyecto Productos API

Este proyecto es una API desarrollada en .NET 8 con una base de datos en memoria y un script en Python para cargar datos automáticamente.

Requisitos

Antes de ejecutar el proyecto debes tener instalado:

.NET SDK 8.0.418

Python 3.14.3

Git


Clona el repositorio desde la rama main:

git clone <URL_DEL_REPOSITORIO>
cd productos-net-api
git checkout main

Ejecutar el proyecto (.NET)

Para iniciar la API ejecuta:

dotnet run

Después de iniciar el proyecto podrás acceder a:

Aplicación web
http://localhost:5207/index.html

Aquí podrás visualizar los productos.

Documentación Swagger
http://localhost:5207/swagger/index.html

Swagger permite probar las APIs manualmente.

El puerto 5207 es el puerto donde se ejecuta la aplicación.

Cargar datos con Python

Para cargar datos automáticamente:

Ejecuta primero la API:

dotnet run

Abre otra terminal en la carpeta del proyecto.

Ejecuta:

python carga_productos.py

Este script insertará productos en la base de datos temporal.

Ver los datos

Después de ejecutar el script, actualiza la página:

http://localhost:5207/index.html

Ahí podrás ver los productos cargados.

Base de datos

Este proyecto usa:

Base de datos en memoria (InMemory)

Los datos se eliminan cuando se detiene la aplicación.
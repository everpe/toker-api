Esta es una API desarrollada en ASP.NET Core (.NET 9) que permite gestionar contactos. Incluye las siguientes funcionalidades:

Crear contactos a través de una solicitud HTTP POST.
Consultar los contactos almacenados mediante una solicitud HTTP GET.
Simular el envío de un mensaje de bienvenida al guardar un contacto, imprimiéndolo en los logs.
La API está diseñada siguiendo los principios de Clean Architecture, utilizando CQRS, MediatR, FluentValidation, y Entity Framework Core con una base de datos en memoria (InMemory).

Requisitos
Para ejecutar este proyecto, necesitas:

.NET SDK 9 instalado en tu máquina (puedes descargarlo desde aquí).
Una herramienta para probar APIs como Postman, Swagger o cURL.
Configuración y Ejecución
Clona este repositorio:

bash
Copiar código
git clone https://github.com/everpe/toker-api.git
cd toker-api
Ejecuta la API:

bash
Copiar código
dotnet run
Accede a la documentación Swagger:

La API estará disponible en: https://localhost:7131/swagger/index.html.
En Swagger podrás visualizar y probar los endpoints.


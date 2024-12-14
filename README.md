Esta es una API desarrollada en ASP.NET Core (.NET 9) que permite gestionar contactos. Incluye las siguientes funcionalidades:

Crear contactos a través de una solicitud HTTP POST.
Consultar los contactos almacenados mediante una solicitud HTTP GET.
Simular el envío de un mensaje de bienvenida al guardar un contacto, imprimiéndolo en los logs.
La API está diseñada siguiendo los principios de Clean Architecture, utilizando CQRS, MediatR, FluentValidation, y Entity Framework Core con una base de datos en memoria (InMemory).

Requisitos
Para ejecutar este proyecto, necesitas:

.NET SDK 9 instalado en tu máquina (puedes descargarlo desde aquí).
Una herramienta para probar APIs como Postman, Swagger o cURL.
Conar repo
git clone https://github.com/everpe/toker-api.git
cd toker-api
Ejecuta la API:
bash
dotnet run

Accede a la documentación Swagger:
ENDPOINTS
POST /api/Contact
Descripción: Crea un contacto.

Cuerpo de la solicitud (JSON):
json
{
  "name": "Juan Pérez",
  "phoneNumber": "123456789"
}

Respuesta (JSON):
json
{
  "message": "Mensaje de bienvenida enviado a Juan Pérez al número 123456789",
  "data": {
    "id": 1,
    "name": "Juan Pérez",
    "phoneNumber": "123456789"
  }
}

Simulación de mensaje: Al guardar el contacto, la API imprime en los logs el siguiente mensaje:
Mensaje de bienvenida enviado a Juan Pérez al número 123456789

GET /api/Contact
Descripción: Obtiene todos los contactos almacenados.
Respuesta ejemplo(JSON):
json
Copiar código
[
  {
    "id": 1,
    "name": "Juan Pérez",
    "phoneNumber": "123456789"
  },
  {
    "id": 2,
    "name": "Ana Gómez",
    "phoneNumber": "987654321"
  }
]


La API estará disponible en: https://localhost:7131/swagger/index.html.
En Swagger podrás visualizar y probar los endpoints o usar una herramienta externa como postman.


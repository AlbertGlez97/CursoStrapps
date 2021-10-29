https://dapper-tutorial.net/step-by-step-tutorial
1- Creamos el proyecto: dotnet new mvc -o MvcDapper
2- Agregamos certificado de confianza: dotnet dev-certs https --trust
3- Agregamos Custumer.cs en la carpeta Models
4- Agregamos CustumerControllers.cs en la carpeta Controllers que sera nuestro controlador 
5- Agregar using Microsoft.Extensions.Configuration, System.Data, System.Data.SqlClient, Dapper
6- Agregamos el paquete que nos ofrece nuget.org "dotnet add package System.Data.SqlClient --version 4.8.3", "dotnet add package Dapper --version 2.0.90"
7- Agregamos en Startup.cs en el metodo ConfigureServices la siguiente linea de codigo "services.AddSingleton<IConfiguration>(Configuration);"
8- Creamos nuestra Vista, en Views creamos la carpeta Customer que se tiene que llamar igual que nuestro controlador y agregamos una vista que se llame Index, igual que nuestro metodo IActionResult.
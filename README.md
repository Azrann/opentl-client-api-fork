# opentl-client-api-fork

Copia histórica de OpenTl.ClientApi.

<!-- BEGIN project-context -->

## Antigüedad y evidencia

**Año de referencia de esta versión: 2018.** Se toma el archivo de código o configuración más reciente con una fecha histórica recuperable; no se ha podido confirmar la fecha exacta de creación.

- Archivo más reciente datable: **2018-06-14**, [`Telegram/OpenTl.ClientApi-master/tests/OpenTl.ClientApi.MtProto.UnitTests/Services/RequestSenderService.cs`](OpenTl.ClientApi/tests/OpenTl.ClientApi.MtProto.UnitTests/Services/RequestSenderService.cs); fecha de modificación conservada.
- Primer registro del repositorio Git original que contiene este código: **2018-06-10**. Puede corresponder a una importación; no prueba cuándo se escribió por primera vez.
- Dependencia fechada más reciente entre las comprobadas: [OpenTl.Schema 1.76.61](https://www.nuget.org/packages/OpenTl.Schema/1.76.61), publicada el **2018-04-19** (versión declarada), en [`Telegram/OpenTl.ClientApi-master/src/OpenTl.ClientApi.MtProto/OpenTl.ClientApi.MtProto.csproj`](OpenTl.ClientApi/src/OpenTl.ClientApi.MtProto/OpenTl.ClientApi.MtProto.csproj).
- Referencia adicional: destino `netcoreapp2.0` en [`Telegram/OpenTl.ClientApi-master/samples/OpenTl.ClientApi.SampeApp/OpenTl.ClientApi.SampeApp.csproj`](OpenTl.ClientApi/samples/OpenTl.ClientApi.SampeApp/OpenTl.ClientApi.SampeApp.csproj); su [versión estable se publicó el 2017-08-14](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core). Es una pista de generación tecnológica; pudieron existir versiones preliminares anteriores.

La publicación de una dependencia sitúa la configuración conservada a partir de esa versión, si la referencia es válida. Una actualización de paquetes puede ser mucho más reciente que el inicio del proyecto. No se restauraron paquetes para comprobarlo.

## Por qué merece la pena mirarlo

La biblioteca separa API de cliente, transporte, sesión y servicios MTProto. Es interesante recorrer el límite entre una operación de aplicación y la infraestructura que prepara y envía una petición del protocolo.

Puntos de entrada al código:

- [`src/OpenTl.ClientApi/ClientFactory.cs`](OpenTl.ClientApi/src/OpenTl.ClientApi/ClientFactory.cs)
- [`src/OpenTl.ClientApi/ISessionStore.cs`](OpenTl.ClientApi/src/OpenTl.ClientApi/ISessionStore.cs)
- [`src/OpenTl.ClientApi.MtProto`](OpenTl.ClientApi/src/OpenTl.ClientApi.MtProto/)

<!-- END project-context -->

## Contenido

| Directorio | Función |
| --- | --- |
| [`OpenTl.ClientApi/`](OpenTl.ClientApi/) | [![Build status](https://ci.appveyor.com/api/projects/status/nh3ek3735uqscqhx/branch/master?svg=true)](https://ci.appveyor.com/project/vik_borisov/opentl-clientapi/branch/master) [![Prod version](https://img.shields.io/nuget/v/OpenTl.ClientApi.svg?st |

Derivación importada de OpenTl/OpenTl.ClientApi. Se conserva LICENSE. El historial local anterior no se publica.

## Requisitos y preparación

.NET, NuGet y clientes Telegram.

Esta es una copia histórica. Consultar los archivos de proyecto y los README de cada componente para sus versiones y dependencias. Restaurar NuGet/npm desde la carpeta correspondiente; las bibliotecas internas pueden necesitar reconstrucción. Preparar las bases de datos y los servicios externos con cuentas propias.

Soluciones conservadas:

- `OpenTl.ClientApi/OpenTl.ClientApi.sln`

## Configuración y seguridad

Los secretos originales se han eliminado o sustituido por `REPLACE_WITH_YOUR_VALUE`. Buscar este marcador antes de ejecutar y aportar los valores mediante configuración local o variables de entorno. Las sesiones, claves privadas, certificados de firma, bases de datos, registros, perfiles de despliegue y paquetes binarios no se publican. El `.gitignore` protege estos archivos locales.

Se publica un historial nuevo: los commits antiguos permanecen únicamente en la copia local original. Los valores de ejemplo no permiten conectarse a los servicios originales.

## Estado de validación

Se realizó una revisión estática y un escaneo de secretos antes de publicar. No se ejecutaron aplicaciones, operaciones de trading, despliegues ni pruebas que contacten servicios externos. No se garantiza la compilación con herramientas actuales. Algunos proyectos necesitan dependencias históricas y activos que no están incluidos.

## Licencias y procedencia

Se conservan las licencias y atribuciones de terceros presentes en el código. No se añade una licencia global a los componentes que no la tenían. Esta importación conserva fuentes locales y no afirma ser una versión actual del proyecto original.

Proyecto de procedencia: [código original](https://github.com/OpenTl/OpenTl.ClientApi). Esta es una importación independiente de la copia local, con historial nuevo.

**Languages:** [English](README.md) · [Español](README.es.md)

# OpenTl.ClientApi

[![Build status](https://ci.appveyor.com/api/projects/status/nh3ek3735uqscqhx/branch/master?svg=true)](https://ci.appveyor.com/project/vik_borisov/opentl-clientapi/branch/master)
[![Prod version](https://img.shields.io/nuget/v/OpenTl.ClientApi.svg?style=flat&colorB=brightgreen&label=prod%20version)](https://www.nuget.org/packages/OpenTl.ClientApi/)
[![Dev version](https://img.shields.io/myget/opentl/v/OpenTl.ClientApi.svg?style=flat&label=dev%20version)](https://www.myget.org/feed/opentl/package/nuget/OpenTl.ClientApi)
[![Telegram group](https://img.shields.io/badge/TELEGRAM-GROUP-green.svg)](https://t.me/vik_borisov_tlib)
[![Stars tracker](https://img.shields.io/badge/STARS-TRACKER-blue.svg)](https://seladb.github.io/StarTrack-js/?u=OpenTl&r=OpenTl.ClientApi)
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/cb64069dc0f247829dc01d3e8bb87999)](https://www.codacy.com/app/OpenTl/OpenTl.ClientApi?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=OpenTl/OpenTl.ClientApi&amp;utm_campaign=Badge_Grade)


The Api client library that implements the MtProto 2.0 protocol is supported by .Net 4.6 and the dotnet core >= 1.6.
Suitable for the realization of clients for work with servers that support the MtProto protocol, such as Telegram

It's a perfect fit for any developer who would like to send data directly to Telegram users or write own custom Telegram client.

**We are used the 76th schema layer**

:star2: If you :heart: library, please star it! :star2:

<!-- BEGIN project-context -->

## Antigüedad y evidencia

**Año de referencia de esta versión: 2018.** Se toma el archivo de código o configuración más reciente con una fecha histórica recuperable; no se ha podido confirmar la fecha exacta de creación.

- Archivo más reciente datable: **2018-06-14**, [`Telegram/OpenTl.ClientApi-master/tests/OpenTl.ClientApi.MtProto.UnitTests/Services/RequestSenderService.cs`](tests/OpenTl.ClientApi.MtProto.UnitTests/Services/RequestSenderService.cs); fecha de modificación conservada.
- Primer registro del repositorio Git original que contiene este código: **2018-06-10**. Puede corresponder a una importación; no prueba cuándo se escribió por primera vez.
- Dependencia fechada más reciente entre las comprobadas: [OpenTl.Schema 1.76.61](https://www.nuget.org/packages/OpenTl.Schema/1.76.61), publicada el **2018-04-19** (versión declarada), en [`Telegram/OpenTl.ClientApi-master/src/OpenTl.ClientApi.MtProto/OpenTl.ClientApi.MtProto.csproj`](src/OpenTl.ClientApi.MtProto/OpenTl.ClientApi.MtProto.csproj).
- Referencia adicional: destino `netcoreapp2.0` en [`Telegram/OpenTl.ClientApi-master/samples/OpenTl.ClientApi.SampeApp/OpenTl.ClientApi.SampeApp.csproj`](samples/OpenTl.ClientApi.SampeApp/OpenTl.ClientApi.SampeApp.csproj); su [versión estable se publicó el 2017-08-14](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core). Es una pista de generación tecnológica; pudieron existir versiones preliminares anteriores.

La publicación de una dependencia sitúa la configuración conservada a partir de esa versión, si la referencia es válida. Una actualización de paquetes puede ser mucho más reciente que el inicio del proyecto. No se restauraron paquetes para comprobarlo.

## Por qué merece la pena mirarlo

La biblioteca separa API de cliente, transporte, sesión y servicios MTProto. Es interesante recorrer el límite entre una operación de aplicación y la infraestructura que prepara y envía una petición del protocolo.

Puntos de entrada al código:

- [`src/OpenTl.ClientApi/ClientFactory.cs`](src/OpenTl.ClientApi/ClientFactory.cs)
- [`src/OpenTl.ClientApi/ISessionStore.cs`](src/OpenTl.ClientApi/ISessionStore.cs)
- [`src/OpenTl.ClientApi.MtProto`](src/OpenTl.ClientApi.MtProto/)

<!-- END project-context -->

## How do I add this to my project?

Install via NuGet

```
	> Install-Package OpenTl.ClientApi
```

## Feature request

If you want the desired function to appear in the library faster - [create feature request](http://feathub.com/OpenTl/OpenTl.ClientApi), the more votes it gets, the higher the priority

[![Feature Requests](http://feathub.com/OpenTl/OpenTl.ClientApi?format=svg)](http://feathub.com/OpenTl/OpenTl.ClientApi)

## [Library Documentation](https://opentl.github.io/OpenTl.ClientApi/)

## [Quick Start](https://github.com/OpenTl/OpenTl.ClientApi/wiki/Quick-Start)

## [Schema Documentation](https://opentl.github.io/OpenTl.Schema/api/)

## [Code of Conduct](./CODE_OF_CONDUCT.md)

### Nothing helps

Ask your question at telegram group or create an issue in project bug tracker.

**Attach following information**:

* Full problem description and exception message
* Stack-trace
* Your code that runs in to this exception

Without information listen above your issue will be closed.

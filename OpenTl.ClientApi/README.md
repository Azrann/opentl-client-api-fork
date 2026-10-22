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

## Historical dates and evidence

**Reference year for this version: 2018.** This uses the most recent source or configuration file with a recoverable historical date; the exact creation date could not be confirmed.

- Most recent datable file: **2018-06-14**, [`Telegram/OpenTl.ClientApi-master/tests/OpenTl.ClientApi.MtProto.UnitTests/Services/RequestSenderService.cs`](tests/OpenTl.ClientApi.MtProto.UnitTests/Services/RequestSenderService.cs); preserved modification timestamp.
- First record in the original Git repository containing this code: **2018-06-10**. This may be an import and does not establish when the code was first written.
- Most recently published dependency among those checked: [OpenTl.Schema 1.76.61](https://www.nuget.org/packages/OpenTl.Schema/1.76.61), published on **2018-04-19** (declared version), in [`Telegram/OpenTl.ClientApi-master/src/OpenTl.ClientApi.MtProto/OpenTl.ClientApi.MtProto.csproj`](src/OpenTl.ClientApi.MtProto/OpenTl.ClientApi.MtProto.csproj).
- Additional reference: target `netcoreapp2.0` in [`Telegram/OpenTl.ClientApi-master/samples/OpenTl.ClientApi.SampeApp/OpenTl.ClientApi.SampeApp.csproj`](samples/OpenTl.ClientApi.SampeApp/OpenTl.ClientApi.SampeApp.csproj); its [stable release was published on 2017-08-14](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core). This indicates the technology generation; earlier preview releases may have existed.

A dependency's publication places the preserved configuration at or after that version, if the reference is valid. Package updates may be much newer than the project's beginnings. Packages were not restored to verify this.

## Why this is worth exploring

The library separates client API, transport, session, and MTProto services. Explore the boundary between an application operation and the infrastructure that prepares and sends a protocol request.

Code entry points:

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

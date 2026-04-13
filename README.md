# Introduction

[![deprecated](https://img.shields.io/badge/status-DEPRECATED-red?style=flat-square)](DEPRECATED.md) **This package is deprecated and will be removed on June 30, 2026.**

## See Also

This package has been superseded by [`nuget-ai`](https://github.com/italbytz/nuget-ai).

The [Hexagonal Architecture](https://web.archive.org/web/20180822100852/http://alistair.cockburn.us/Hexagonal+architecture), also known as the Ports and Adapters pattern, is a design approach that emphasizes separation of concerns by isolating the core application logic from external systems like databases, user interfaces, or APIs. This is achieved through the use of "ports" (interfaces) and "adapters" (implementations), enabling easier testing, maintainability, and flexibility in swapping external dependencies without affecting the core logic.

This repository provides C# ports for Evolutionary Algorithms inspired by [FrEAK](https://sourceforge.net/projects/freak427/). The NuGet package is called [Italbytz.Ports.Algorithms.EA](https://www.nuget.org/packages/Italbytz.Ports.Algorithms.EA) and offers a [docfx](https://italbytz.github.io/nuget-ports-algorithms-ea/) page. Implementations are in the NuGet package [Italbytz.Adapters.Algorithms.EA](https://www.nuget.org/packages/Italbytz.Adapters.Algorithms.EA) (Source: [nuget-adapters-algorithms-ea](https://github.com/Italbytz/nuget-adapters-algorithms-ea)).
 


# Getting Started

[nuget-adapters-algorithms-ea](https://github.com/Italbytz/nuget-adapters-algorithms-ea) contains a set of unit tests demonstrating the use of the provided ports and adapters.

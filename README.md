# 🚀 100 Days of Code — Learning .NET Ecosystem

[![Challenge Progress](https://img.shields.io/badge/Progress-Day%201%20%2F%20100-blue?style=for-the-badge&logo=dotnet)](https://github.com)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=for-the-badge)](LICENSE)
[![.NET Version](https://img.shields.io/badge/.NET-9.0%20%2F%2010.0-purple?style=for-the-badge&logo=dotnet)](https://dotnet.microsoft.com/)

Bem-vindo ao meu repositório do desafio **#100DaysOfCode** focado em dominar o ecossistema **.NET e C#**. 

O objetivo deste projeto é construir uma jornada prática e progressiva, partindo dos fundamentos da linguagem C# e da CLI até a construção de arquiteturas distribuídas, microsserviços, mensageria e testes automatizados.

---

## 🎯 Objetivos do Desafio

- [ ] Dominar a sintaxe moderna do C# (Records, Pattern Matching, Async/Await, LINQ).
- [ ] Construir APIs RESTful robustas com ASP.NET Core e Entity Framework Core.
- [ ] Implementar padrões de arquitetura corporativa (**Clean Architecture**, **CQRS**, **Repository Pattern**).
- [ ] Garantir qualidade com testes unitários e de integração (**xUnit**, **FluentAssertions**, **Testcontainers**).
- [ ] Trabalhar com mensageria e sistemas resilientes (**RabbitMQ**, **MassTransit**, **Polly**, **Redis**).
- [ ] Conteinerizar e orquestrar microsserviços usando **Docker**, **YARP** e **PostgreSQL**.

---

## 🗺️ Trilha de Projetos & Fases

| Fase | Título | Projetos Principais | Dias | Status |
| :---: | :--- | :--- | :---: | :---: |
| **01** | **Sintaxe C#, CLI & LINQ** | CLI Logger & Engine de Validação Assíncrona | 001 - 015 | 🟡 Em andamento |
| **02** | **APIs RESTful & EF Core** | API CRUD com EF Core & Auth JWT/Identity | 016 - 040 | ⚪ Não iniciado |
| **03** | **Clean Architecture & Testes** | E-Commerce CQRS (MediatR) + Suíte de Testes (xUnit) | 041 - 065 | ⚪ Não iniciado |
| **04** | **Mensageria & Real-time** | Worker Services (RabbitMQ/MassTransit) & SignalR + Redis | 066 - 085 | ⚪ Não iniciado |
| **05** | **Microsserviços & Cloud Native** | API Gateway (YARP), Resilience (Polly) & Docker Compose | 086 - 100 | ⚪ Não iniciado |

---

## 🛠️ Tech Stack & Ferramentas

* **Linguagem & Framework:** C# 13, .NET SDK (LTS)
* **Web APIs & Gateways:** ASP.NET Core Web API, Minimal APIs, YARP
* **Persistência & ORM:** Entity Framework Core, Dapper, PostgreSQL, SQL Server
* **Mensageria & Cache:** RabbitMQ, MassTransit, Redis, SignalR
* **Testes:** xUnit, FluentAssertions, NSubstitute, WebApplicationFactory
* **DevOps & Ferramentas:** Docker, Docker Compose, Git, VS Code / JetBrains Rider

---

## 📅 Diário de Bordo (Daily Log)

<details>
<summary><b>Fase 1: Sintaxe C#, CLI e LINQ (Dias 001 – 015)</b></summary>

### Day 001: [Título curto do que fez no dia]
- **Aprendizado:** Setup do ambiente, criação da estrutura da CLI e primeiros comandos
- **Commit/Código:** [`phaseo1-fundamentals/LogViewerCLI`](./phaseo1-fundamentals/)
- **Anotações:** Aprendi sobre a inicialização de projetos via `.NET CLI` e declaração de *top-level statements*.

### Day 002: [Título]
- **Aprendizado:** ...
- **Commit/Código:** ...

</details>

<details>
<summary><b>Fase 2: APIs RESTful, EF Core e Autenticação (Dias 016 – 040)</b></summary>

*(Log em breve)*

</details>

<details>
<summary><b>Fase 3: Arquitetura Limpa, Testes e CQRS (Dias 041 – 065)</b></summary>

*(Log em breve)*

</details>

<details>
<summary><b>Fase 4: Mensageria, Caching e Real-time (Dias 066 – 085)</b></summary>

*(Log em breve)*

</details>

<details>
<summary><b>Fase 5: Microsserviços, Docker e Capstone (Dias 086 – 100)</b></summary>

*(Log em breve)*

</details>

---

## 📂 Estrutura do Repositório

```text
100-days-of-dotnet/
├── docs/                   # Diagramas, anotações de arquitetura e resumos
├── src/
│   ├── Phase01-Fundamentals/
│   ├── Phase02-WebAPI-EFCore/
│   ├── Phase03-CleanArchitecture/
│   ├── Phase04-Messaging-Realtime/
│   └── Phase05-Microservices/
├── tests/                  # Projetos de testes unitários e de integração
├── .gitignore
├── LICENSE
└── README.md

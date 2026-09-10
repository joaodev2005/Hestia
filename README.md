# 🏨 Hestia

Sistema de agendamento de hotel desenvolvido em .NET 10 com MediatR, RabbitMQ, Redis e SQL Server.

## 🚀 Stack

- .NET 10
- ASP.NET Core
- Entity Framework Core + SQL Server
- MediatR
- FluentValidation
- RabbitMQ
- Redis
- Google Gmail API / Google Calendar API
- Docker
- xUnit + Moq + FluentAssertions + Testcontainers

## 📦 Estrutura

- `Hestia.Domain` – Entidades POCOs, Enums, Interfaces
- `Hestia.Application` – MediatR (Commands, Queries, Handlers, Validators, Behaviors)
- `Hestia.Infrastructure` – EF Core, RabbitMQ, Redis, Google
- `Hestia.Api` – Controllers, Middleware
- `Hestia.Worker` – Consumers RabbitMQ, Background Service
- `Hestia.Exception` – Exceções customizadas + mensagens

## 🏃 Como rodar

```bash
docker-compose up -d
dotnet run --project src/Hestia.Api
dotnet run --project src/Hestia.Worker

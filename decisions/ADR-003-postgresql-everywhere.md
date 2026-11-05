# ADR-003: PostgreSQL locally and in production

| | |
|---|---|
| Date | 2026-11-05 |
| Status | **Accepted** |
| Refines | [ADR-002](ADR-002-switch-to-aspnet-core-blazor.md) (database choice) |
| IPERKA phase | Decide |

## Context

[ADR-002](ADR-002-switch-to-aspnet-core-blazor.md) planned SQLite for local development and PostgreSQL once the app is hosted. The Blazor template that was used to create the project came with SQL Server LocalDB instead.

Following the original plan would have meant two database switches: LocalDB → SQLite → PostgreSQL. Entity Framework Core migrations are specific to a database provider, so using different databases locally and in production would also mean maintaining two sets of migrations, or discovering provider differences only after deployment.

## Decision

The app uses **PostgreSQL in every environment**, from local development to production.

| Area | Choice |
|---|---|
| Local database | PostgreSQL 18, installed on the development machine |
| Hosted database | PostgreSQL (provider decided together with hosting, week 4) |
| EF Core provider | `Npgsql.EntityFrameworkCore.PostgreSQL` |
| Local credentials | .NET User Secrets; `appsettings.json` contains the connection string without a password |

## Alternatives considered

| Option | Why not chosen |
|---|---|
| Keep SQL Server LocalDB | Works locally, but hosted SQL Server is more expensive and LocalDB only runs on Windows |
| SQLite locally, PostgreSQL hosted (original plan) | Two switches, two sets of migrations, differences found late |
| Hosted PostgreSQL for development too | No local install, but needs an internet connection and makes experiments on shared data risky |

## Consequences

**Positive**
- One database, one set of migrations, no surprises when going online
- PostgreSQL is free, open source and offered by almost every hosting provider
- pgAdmin allows inspecting the data while learning

**Negative / risks**
- PostgreSQL has to be installed on every development machine. Mitigation: setup steps documented in the implementation notes
- A forgotten local password requires a reset. Mitigation: passwords are stored in a password manager

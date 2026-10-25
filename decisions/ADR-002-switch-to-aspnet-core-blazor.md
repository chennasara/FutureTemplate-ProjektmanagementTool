# ADR-002: Dedicated web app with ASP.NET Core and Blazor

| | |
|---|---|
| Date | 2026-10-24 |
| Status | **Accepted** |
| Supersedes | [ADR-001](ADR-001-notion-as-first-prototype.md) |
| IPERKA phase | Decide |

## Context

[ADR-001](ADR-001-notion-as-first-prototype.md) chose Notion for the first prototype. While planning it in detail, three things became clear:

1. **Core needs hit Notion's limits.** Group work needs real accounts, project membership and permissions. In Notion this depends on guest limits and sharing settings that students would have to configure themselves.
2. **The long-term goal is adaptation for schools.** Schools will need their own templates, roles and possibly central administration. A Notion template cannot provide this, and updates would not reach copies that were already duplicated.
3. **Learning and portfolio goals.** The author is an apprentice ICT specialist working with C# daily. A web app built with the same technology shows relevant skills far better than a no-code template.

The platform evaluation had defined triggers for re-evaluation. "Central account management needed" and "multi-level roles and permissions needed" were the relevant ones here.

## Decision

The product is built as a **dedicated web app with ASP.NET Core and Blazor**:

| Area | Choice |
|---|---|
| Frontend and backend | ASP.NET Core with Blazor |
| Authentication | ASP.NET Core Identity (never self-built) |
| Data access | Entity Framework Core |
| Database | SQLite locally, PostgreSQL when hosted |
| IDE | Visual Studio |

Working title: **Guidance by FutureTemplates**.

## Alternatives considered

| Option | Why not chosen |
|---|---|
| Keep Notion | Fast, but cannot deliver accounts, permissions and school adaptation |
| Browser-only web app without backend (local storage, file export) | Little effort, but no group collaboration – the core need |
| JavaScript stack (e.g. React + Node.js) | Would require learning a new language and ecosystem within the timeframe |
| Low-code (Power Apps) | Licensing and IT administration dependence, hard to distribute to individuals |

## Consequences

**Positive**
- Full control over accounts, roles, user experience and future school-specific versions
- One language (C#) for frontend and backend, building on existing knowledge
- Strong portfolio piece for applications from January 2027

**Negative / risks**
- Much higher effort than a template. Mitigation: a deliberately small walking skeleton by 31 December 2026 (see [roadmap](../docs/08_roadmap.md))
- Responsibility for hosting, security and personal data. Mitigation: Identity for authentication, no real student data before a privacy concept exists, membership checks on every data access
- Hosting costs for .NET are higher than for static sites. Decision on a provider by week 4


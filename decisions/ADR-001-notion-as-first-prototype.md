# ADR-001: Notion as platform for the first prototype

| | |
|---|---|
| Date | 2026-09-26 |
| Status | **Superseded** by [ADR-002](ADR-002-switch-to-aspnet-core-blazor.md) |
| IPERKA phase | Decide |

## Context

A platform had to be chosen for the first working prototype of a project management system for school and study projects. It needed to be usable without a paid subscription, easy to distribute, and buildable by one person alongside an apprenticeship.

## Decision

The first prototype was to be built as a **Notion template**.

## Alternatives considered

A weighted utility analysis with eleven criteria (100 points maximum) compared five options:

| Rank | Platform | Score |
|---:|---|---:|
| 1 | Notion | 87 |
| 2 | Coda | 82 |
| 3 | Custom web app | 77 |
| 4 | Airtable | 71 |
| 5 | Microsoft Power Apps | 64 |

Full analysis: [research/01_platform_evaluation.md](../research/01_platform_evaluation.md)

## Consequences

- Low development effort, fast feedback from test users
- Dependence on Notion's free-plan limits: no editable automations, one native chart, limited guests, no own user or role management (see [archive](../archive/notion-concept/notion_free_plan_limitations.md))
- Group collaboration only possible within Notion's sharing model

## Why it was superseded

See [ADR-002](ADR-002-switch-to-aspnet-core-blazor.md).

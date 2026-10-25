# Architecture Decision Records

Important decisions are documented as short Architecture Decision Records (ADRs). Each record explains the context, the decision, the alternatives considered and the consequences, so that later readers can understand *why* the project looks the way it does.

## Index

| ADR | Title | Date | Status |
|---|---|---|---|
| [ADR-001](ADR-001-notion-as-first-prototype.md) | Notion as platform for the first prototype | 2026-09-26 | Superseded by ADR-002 |
| [ADR-002](ADR-002-switch-to-aspnet-core-blazor.md) | Dedicated web app with ASP.NET Core and Blazor | 2026-10-24 | Accepted |

## Status values

| Status | Meaning |
|---|---|
| Proposed | Under discussion, not yet decided |
| Accepted | Decided and valid |
| Superseded | Replaced by a later ADR (linked) |
| Deprecated | No longer relevant, not replaced |

## Template

New ADRs are numbered consecutively and named `ADR-XXX-short-title.md`.

```markdown
# ADR-XXX: Title

| | |
|---|---|
| Date | YYYY-MM-DD |
| Status | Proposed |
| IPERKA phase | Decide |

## Context
What is the situation and why does a decision need to be made?

## Decision
What was decided?

## Alternatives considered
Which options were evaluated and why were they not chosen?

## Consequences
What becomes easier or harder because of this decision?
```

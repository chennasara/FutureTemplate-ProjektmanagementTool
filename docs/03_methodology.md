# Methodology

| | |
|---|---|
| Current IPERKA phase | Inform |
| Status | In Progress |

## IPERKA

The project follows **IPERKA**, a six-phase project model widely taught in Swiss vocational education. It is complemented by agile elements: a Kanban board for daily work, continuous prioritisation, and short weekly retrospectives.

| Phase | German | Application in this project | Documentation |
|---|---|---|---|
| Inform | Informieren | Analyse the problem, target groups and needs | [Project overview](01_project_overview.md), [research](../research/) |
| Plan | Planen | Define requirements, architecture and schedule | [Requirements](02_requirements.md), [system design](04_system_design.md), [roadmap](08_roadmap.md) |
| Decide | Entscheiden | Compare options and justify choices | [Decision records](../decisions/README.md) |
| Implement | Realisieren | Build the web app in small increments | [Implementation](05_implementation.md) |
| Verify | Kontrollieren | Check requirements with test cases and real users | [Testing](06_testing.md) |
| Review | Auswerten | Assess goals and document learnings | [Limitations and learnings](07_limitations_and_learnings.md) |

The same model is used inside the app: it guides students through the phases of their own projects.

## Working agreements

- **Weekly rhythm:** about 10 hours per week; additional hours count as buffer.
- **Scope first:** if a week is not enough, scope is cut before quality.
- **Idea list:** new ideas are collected and only reviewed after milestone M3.
- **Status labels:** *Proposed → Planned → In Progress → Implemented → Tested*. A feature is only *Tested* once its test cases pass.
- **Decisions:** every important decision gets an ADR.
- **Change log:** [CHANGELOG.md](../CHANGELOG.md) is updated weekly.

## Git workflow

| Rule | Reason |
|---|---|
| `main` is protected; changes only via pull request | `main` always shows a working, reviewed state |
| Branch names describe their purpose: `feature/…`, `fix/…`, `docs/…` | The history is easy to follow |
| Squash merge, linear history | One clear commit per change on `main` |
| Small, frequent commits with clear messages | Progress is traceable |
| From week 3: a build check must pass before merging | Broken code never reaches `main` |

## Use of AI

Claude (Anthropic) supports the project as coordinator, reviewer and mentor. AI-assisted changes are made on branches, marked as co-authored, and merged only after my own review. The application code is written by me; AI gives hints, explanations and code reviews.

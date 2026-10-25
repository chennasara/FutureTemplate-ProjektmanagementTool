# Guidance by FutureTemplates

**A project management web app that helps students plan, run and finish school and study projects, without needing a training course first.**

> **Status:** Information phase · walking skeleton planned for 31 December 2026
> This repository documents the whole development process, from research to release. Features are only marked as *Implemented* or *Tested* once they actually are.

---

## The problem

Students at vocational schools, baccalaureate schools, universities of applied sciences and universities regularly work on projects, often in small groups and under deadlines. Tasks, deadlines, responsibilities and documents end up scattered across chats, files and tools. Existing project management software is built for companies and is usually too heavy for a school project.

**Guidance** brings the essentials into one place and guides students through a proven project process (IPERKA), so they learn *how* to approach a project while they work on it.

## Planned scope

### Walking skeleton (by 31 December 2026)

| Feature | Description | Status |
|---|---|---|
| Accounts | Register, sign in, sign out | Planned |
| Projects | Create and edit projects; only members can see a project | Planned |
| Group members | Add existing accounts to a project | Planned |
| Kanban board | Tasks with status *To do*, *In progress*, *Done* and a responsible person | Planned |
| Submission checklist | Customisable checklist of deliverables per project | Planned |

### Later (after validation)

Planned-vs-actual timeline, templates for specific schools and project types, notifications and email invitations, teacher view, school licences. These are only prioritised once the survey results and first tests are in.

## Tech stack

| Layer | Technology |
|---|---|
| Frontend | Blazor (C# components with HTML/CSS) |
| Backend | ASP.NET Core |
| Authentication | ASP.NET Core Identity |
| Data access | Entity Framework Core |
| Database | SQLite (local), PostgreSQL (hosted) |
| IDE | Visual Studio |
| Hosting | to be decided (see [roadmap](docs/08_roadmap.md)) |

## Approach

The project follows the Swiss **IPERKA** model, complemented by agile elements such as a Kanban board, continuous prioritisation and short retrospectives.

| Phase | Focus | Documentation |
|---|---|---|
| **I**nform | Problem, target groups, research | [Project overview](docs/01_project_overview.md), [research](research/) |
| **P**lan | Requirements, architecture, roadmap | [Requirements](docs/02_requirements.md), [system design](docs/04_system_design.md), [roadmap](docs/08_roadmap.md) |
| **E**ntscheiden (Decide) | Justified decisions | [Decision records](decisions/README.md) |
| **R**ealisieren (Implement) | Building the app | [Implementation](docs/05_implementation.md) |
| **K**ontrollieren (Verify) | Tests with real users | [Testing](docs/06_testing.md) |
| **A**uswerten (Review) | Results and learnings | [Limitations and learnings](docs/07_limitations_and_learnings.md) |

More on the method: [docs/03_methodology.md](docs/03_methodology.md)

## Key decisions

| ADR | Decision | Status |
|---|---|---|
| [ADR-001](decisions/ADR-001-notion-as-first-prototype.md) | Build the first prototype as a Notion template | Superseded |
| [ADR-002](decisions/ADR-002-switch-to-aspnet-core-blazor.md) | Build a dedicated web app with ASP.NET Core and Blazor | Accepted |

The original Notion concept is kept in the [archive](archive/notion-concept/) to show how the project evolved.

## Repository structure

```text
├── docs/        Project documentation along the IPERKA phases
├── research/    Platform evaluation, user survey, analysis of school requirements
├── decisions/   Architecture decision records (ADRs)
├── archive/     Earlier concepts that were replaced (Notion)
├── CHANGELOG.md Weekly change log
└── LICENSE      All rights reserved
```

## Working with AI

I use Claude (Anthropic) as a coordinator, reviewer and mentor: for planning, research, documentation, and for explanations and code reviews. Changes suggested by Claude are made on separate branches and only reach `main` through a pull request that I review and merge myself. Commits created with Claude's help are marked as co-authored. The application code is written by me, with Claude giving hints and reviews.

## Privacy

Survey and test data are never published in this repository. Only anonymised, aggregated results are documented. Details: [research/03_data_collection_and_privacy.md](research/03_data_collection_and_privacy.md)

## About me

**Sara Chenna**, Founder of FutureTemplates
Apprentice ICT specialist (Informatikerin EFZ), specialising in platform development.

Besides this project, I create and sell Notion productivity templates under FutureTemplates.

- LinkedIn: [linkedin.com/in/sara-chenna](https://www.linkedin.com/in/sara-chenna)

## Licence

© 2026 Sara Chenna. All rights reserved. The code and documentation may be viewed on GitHub but may not be copied, modified, distributed or used commercially without written permission. See [LICENSE](LICENSE).

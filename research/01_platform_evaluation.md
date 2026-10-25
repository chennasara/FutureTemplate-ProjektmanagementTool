# Platform Evaluation

| | |
|---|---|
| IPERKA phase | Inform |
| Status | Completed |
| Research date | 26 September 2026 |
| Owner | Sara Chenna |
| Decision subject | Platform for the first working prototype |
| Result at the time | Notion ([ADR-001](../decisions/ADR-001-notion-as-first-prototype.md)) |

> **Note (24 October 2026):** This decision was revised. The project is now built as a web app with ASP.NET Core and Blazor (see [ADR-002](../decisions/ADR-002-switch-to-aspnet-core-blazor.md)). This evaluation is kept unchanged as part of the decision history.

## 1. Question

> Which platform is best suited to build and test an understandable, adaptable and sellable project management system for school and study projects with reasonable effort?

The decision concerned the first working prototype, not necessarily the long-term technical solution.

## 2. Options

| Option | Type | Reason for inclusion |
|---|---|---|
| Notion | No-code workspace and template platform | Planned development environment at the time; high design freedom for templates |
| Coda | Document-based no-code platform | Combines documents, tables, formulas, buttons and automations |
| Airtable | No-code database and app platform | Strong relational data, views, interfaces and automations |
| Microsoft Power Apps | Low-code app platform | Relevant for schools using Microsoft 365 |
| Custom web app | Individually developed application | Full control over features, UI and business model |

Ready-made project management products (Trello, Asana, Microsoft Planner, ClickUp) were not part of this evaluation because they cannot be turned into an own product.

## 3. Scoring

Each platform was rated from 1 (very poorly suited) to 5 (very well suited).

```text
Weighted score = rating / 5 × weight
```

Maximum total: 100 points.

## 4. Criteria

| ID | Criterion | Weight | Rationale |
|---|---|---:|---|
| `PLAT-001` | Ease of use for the target group | 10 % | Usable without long onboarding |
| `PLAT-002` | Distribution and sales | 10 % | Easy to hand over to users |
| `PLAT-003` | Free basic use | 10 % | No mandatory subscription for students |
| `PLAT-004` | Documentation and content | 10 % | Knowledge, templates and learnings in one place |
| `PLAT-005` | Data model | 10 % | Link projects, tasks, people and milestones |
| `PLAT-006` | Formulas and automation | 10 % | Progress, task points, recurring processes |
| `PLAT-007` | Design freedom | 10 % | UI and process tailored to the target group |
| `PLAT-008` | Collaboration | 5 % | Small groups can work together |
| `PLAT-009` | Mobile use | 5 % | Key information on a smartphone |
| `PLAT-010` | Development and maintenance effort | 15 % | Built and maintained by one person |
| `PLAT-011` | Operations and legal effort | 5 % | Hosting, accounts, security, data processing |
| | **Total** | **100 %** | |

## 5. Ratings

| Criterion | Weight | Notion | Coda | Airtable | Power Apps | Custom web app |
|---|---:|---:|---:|---:|---:|---:|
| Ease of use | 10 % | 5 | 3 | 3 | 2 | 5 |
| Distribution and sales | 10 % | 5 | 4 | 3 | 2 | 5 |
| Free basic use | 10 % | 5 | 3 | 4 | 2 | 2 |
| Documentation and content | 10 % | 5 | 5 | 2 | 3 | 5 |
| Data model | 10 % | 4 | 5 | 5 | 5 | 5 |
| Formulas and automation | 10 % | 3 | 5 | 4 | 5 | 5 |
| Design freedom | 10 % | 3 | 4 | 4 | 5 | 5 |
| Collaboration | 5 % | 4 | 4 | 4 | 4 | 5 |
| Mobile use | 5 % | 4 | 4 | 4 | 4 | 4 |
| Development and maintenance effort | 15 % | 5 | 4 | 3 | 2 | 1 |
| Operations and legal effort | 5 % | 4 | 4 | 4 | 2 | 1 |

## 6. Results

| Rank | Platform | Score | Assessment |
|---:|---|---:|---|
| 1 | Notion | **87/100** | Very well suited |
| 2 | Coda | **82/100** | Well to very well suited |
| 3 | Custom web app | **77/100** | Interesting long-term, too much effort at the time |
| 4 | Airtable | **71/100** | Technically suitable, less document-oriented |
| 5 | Microsoft Power Apps | **64/100** | Suited to institutional Microsoft environments |

## 7. Summary per option

**Notion:** Pages and databases in one system, many views, formulas, relations and rollups, templates can be duplicated and sold. Limits: no editable automations on the free plan, guest and file limits, one native chart, no own user management, no central updates for duplicated templates.

**Coda:** Strong formulas and automations, app-like documents. Limits: free shared documents limited to 50 objects and 1,000 rows, less known among students.

**Airtable:** Powerful relational data and interfaces. Limits: less suited to long-form documentation, free-plan limits on automations and records.

**Microsoft Power Apps:** Highly customisable, integrates with Microsoft 365. Limits: licensing depends on the school's plans, premium connectors cost extra, often requires IT administration.

**Custom web app:** Full control over UI, accounts, roles, automations and business model; central updates for all users. Limits: high effort for one person; hosting, security, backups and privacy must be handled in-house.

## 8. Defined triggers for re-evaluation

A custom web app was to be re-evaluated if, among others:

- several schools show concrete interest
- users need central account management
- multi-level roles and permissions become necessary
- updates must reach all customers at the same time
- Notion's automation is not sufficient for core processes
- tests show that Notion's UI significantly hinders the target group

Two of these triggers, central account management and roles/permissions, became relevant when planning group collaboration in detail. This led to [ADR-002](../decisions/ADR-002-switch-to-aspnet-core-blazor.md).

## 9. Reflection

The evaluation weighted development effort highest (15 %) and collaboration low (5 %). In hindsight, collaboration is the core need of group projects and should have been weighted higher. With collaboration and design freedom weighted more strongly, the custom web app would have ranked closer to the top. See [learnings](../docs/07_limitations_and_learnings.md).

## 10. Sources

**Notion**
- [Notion pricing](https://www.notion.com/pricing)
- [Database automations](https://www.notion.com/help/database-automations)
- [Database templates](https://www.notion.com/help/database-templates)
- [Forms](https://www.notion.com/help/forms)
- [Notion for education](https://www.notion.com/help/notion-for-education)

**Coda**
- [Coda pricing](https://coda.io/pricing)
- [Billing and Doc Makers](https://help.coda.io/hc/en-us/articles/39555725230989-Billing-and-pricing-basics)
- [Doc limits](https://help.coda.io/hc/en-us/articles/39555760015757-Overview-Doc-limits)
- [Automations](https://help.coda.io/hc/en-us/articles/39555778179853-Automations-in-Coda)

**Airtable**
- [Airtable pricing](https://airtable.com/pricing)
- [Plan overview](https://support.airtable.com/docs/airtable-plans)
- [Automations](https://support.airtable.com/docs/getting-started-with-airtable-automations)
- [Sharing interfaces](https://support.airtable.com/docs/managing-and-sharing-interfaces)

**Microsoft Power Apps**
- [Power Platform licensing](https://learn.microsoft.com/en-us/power-platform/admin/pricing-billing-skus)
- [Power Apps documentation](https://learn.microsoft.com/en-us/power-apps/)
- [Power Apps for education](https://learn.microsoft.com/en-us/microsoft-365/education/guide/1-addons/addons-powerapps)
- [Microsoft 365 Education](https://learn.microsoft.com/en-us/office365/servicedescriptions/office-365-platform-service-description/microsoft-365-education)

# System Design

| | |
|---|---|
| IPERKA phase | Plan |
| Status | Draft, will be detailed in week 2 |

## Architecture

Guidance is a single ASP.NET Core application. Blazor renders the user interface on the server; the browser only displays the result and sends user input back.

```text
Browser
   │  HTML / user input
   ▼
Blazor components (UI)          ← what users see: board, checklist, forms
   │
Services (business logic)       ← rules: who may see a project, how a task is saved
   │
Entity Framework Core           ← translates C# objects into database queries
   │
Database (SQLite / PostgreSQL)  ← where data is stored permanently

ASP.NET Core Identity           ← accounts, passwords, sign-in
```

**Why this structure:** the UI never talks to the database directly. All rules, especially "only members may see a project", live in one place, the services, and cannot be bypassed from the UI.

## Data model (first draft)

```text
User ──< ProjectMember >── Project ──< TaskItem
                              │
                              └──< ChecklistItem
```

| Entity | Main fields |
|---|---|
| User | provided by ASP.NET Core Identity (email, password hash) |
| Project | Id, Name, Description, SubmissionDate, CreatedAt |
| ProjectMember | ProjectId, UserId, JoinedAt |
| TaskItem | Id, ProjectId, Title, Status, DueDate, AssigneeId |
| ChecklistItem | Id, ProjectId, Title, IsDone, SortOrder |

`TaskItem` is used instead of `Task` to avoid a conflict with .NET's `System.Threading.Tasks.Task`.

## Security principles

- Sign-in and password storage only via ASP.NET Core Identity.
- Every service method that reads or changes project data first checks project membership.
- No personal data beyond email address and display name is stored in the walking skeleton.

## Open decisions

- Hosting provider (week 4) → will become an ADR
- Blazor render mode (server vs. WebAssembly) → will become an ADR in week 3

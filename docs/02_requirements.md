# Requirements

| | |
|---|---|
| IPERKA phase | Inform → Plan |
| Status | Draft, to be validated with survey results |

Requirements are written as user stories with acceptance criteria and prioritised with MoSCoW:

- **Must:** required for the walking skeleton
- **Should:** important, but not required for the walking skeleton
- **Could:** useful for a later extension
- **Won't:** not part of the current project scope

The draft below covers the walking skeleton. It will be checked and extended after the [user survey](../research/04_user_survey.md) has been evaluated (week 2).

## Functional requirements

### Accounts

| ID | User story | Priority | Status |
|---|---|---|---|
| `REQ-001` | As a student, I want to create an account so that my projects are saved. | Must | Proposed |
| `REQ-002` | As a student, I want to sign in and out so that only I can access my account. | Must | Proposed |

**Acceptance criteria**
- Registration requires an email address and a password that meets the password rules.
- Passwords are never stored in plain text (handled by ASP.NET Core Identity).
- After signing out, protected pages are no longer accessible.

### Projects

| ID | User story | Priority | Status |
|---|---|---|---|
| `REQ-010` | As a student, I want to create a project with a name, description and submission date. | Must | Proposed |
| `REQ-011` | As a project member, I want to edit the project details. | Must | Proposed |
| `REQ-012` | As a student, I want to see a list of all projects I am a member of. | Must | Proposed |
| `REQ-013` | As a student, I want to see how many days remain until submission. | Should | Proposed |

**Acceptance criteria**
- A user only sees projects they are a member of (also when entering a URL directly).
- The creator of a project automatically becomes a member.

### Group members

| ID | User story | Priority | Status |
|---|---|---|---|
| `REQ-020` | As a project member, I want to add a classmate by their email address so that we can work together. | Must | Proposed |
| `REQ-021` | As a project member, I want to see who is in the project. | Must | Proposed |
| `REQ-022` | As a project member, I want to invite someone who has no account yet by email. | Could | Proposed |

**Acceptance criteria**
- Only existing accounts can be added in the walking skeleton.
- A clear message is shown if no account exists for the email address.

### Kanban board

| ID | User story | Priority | Status |
|---|---|---|---|
| `REQ-030` | As a project member, I want to create tasks with a title, due date and responsible person. | Must | Proposed |
| `REQ-031` | As a project member, I want to move tasks between *To do*, *In progress* and *Done*. | Must | Proposed |
| `REQ-032` | As a project member, I want to see overdue tasks highlighted. | Should | Proposed |
| `REQ-033` | As a student, I want to see only my own tasks. | Should | Proposed |

### Submission checklist

| ID | User story | Priority | Status |
|---|---|---|---|
| `REQ-040` | As a project member, I want a checklist of deliverables so that nothing is forgotten before submission. | Must | Proposed |
| `REQ-041` | As a project member, I want to add, rename and remove checklist items to match my school's requirements. | Must | Proposed |
| `REQ-042` | As a student, I want the checklist to start with typical deliverables (documentation, sources, reflection, presentation). | Should | Proposed |

### Later

| ID | User story | Priority | Status |
|---|---|---|---|
| `REQ-050` | Compare planned and actual progress on a timeline. | Could | Proposed |
| `REQ-051` | Show the current IPERKA phase of a project. | Could | Proposed |
| `REQ-052` | Document project closure, results and retrospective. | Could | Proposed |
| `REQ-053` | Teacher view for supervised projects. | Won't (this project) | Proposed |

## Non-functional requirements

| ID | Requirement | Priority | Status |
|---|---|---|---|
| `NFR-001` | Core tasks can be completed without training or a manual. | Must | Proposed |
| `NFR-002` | The app is usable on current desktop and mobile browsers. | Must | Proposed |
| `NFR-003` | Every data access checks project membership. | Must | Proposed |
| `NFR-004` | Authentication uses ASP.NET Core Identity. | Must | Proposed |
| `NFR-005` | No real student data is stored before the privacy concept is complete. | Must | Proposed |
| `NFR-006` | Pages load in under two seconds on a normal connection. | Should | Proposed |
| `NFR-007` | Text contrast and keyboard navigation meet WCAG 2.1 AA basics. | Should | Proposed |

## Traceability

| Need | Requirements |
|---|---|
| `NEED-001` Tasks captured centrally | REQ-030, REQ-031 |
| `NEED-002` Visible responsibilities | REQ-020, REQ-021, REQ-030 |
| `NEED-003` Deadlines in one place | REQ-010, REQ-013, REQ-032 |
| `NEED-005` Checklists | REQ-040, REQ-041, REQ-042 |
| `NEED-007` Desktop and mobile | NFR-002 |
| `NEED-011` No lengthy onboarding | NFR-001 |

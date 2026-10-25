# Project Overview

| | |
|---|---|
| Project | Guidance by FutureTemplates |
| Current IPERKA phase | Inform |
| Document status | In Progress |
| Project start | 18 September 2026 |
| Walking skeleton | 31 December 2026 |
| Last updated | 25 October 2026 |
| Owner | Sara Chenna |

> This document describes the background, target groups, goals and boundaries of the project. Features are only labelled *Implemented* or *Tested* once they have been built and verified.

---

## 1. Background

Students at vocational schools, baccalaureate schools, upper secondary schools, universities of applied sciences and universities regularly work on project assignments, group projects and final theses. They have to split up tasks, meet deadlines, organise documents and keep track of progress.

This information is usually spread across several apps, documents and chat groups, which makes it hard to see who is responsible for what, what is due next and where the project stands.

Guidance brings the essential tools for school and study projects into one clear environment. Beyond organising a single project, it should teach young users a structured way of working with tasks, deadlines, responsibilities and project phases.

## 2. Problem statement

Typical difficulties in school and study projects:

- Tasks, deadlines and documents are spread across several platforms.
- Agreements are made in different chat channels.
- Responsibilities within the group are not clearly recorded.
- Group members cannot see the current state of each other's tasks.
- There is no clear view of the current project phase.
- Delays against the original schedule are noticed too late.
- Required parts of a submission are forgotten.
- Existing project management tools are too complex for small school projects.
- Information is hard to access quickly on a phone.
- Students struggle to approach a project in a structured way.

**Central question**

> How can a clear and easy-to-understand web app support students in planning, running and reviewing their projects – without prior training?

## 3. Project goal

Design, build and test a web app for school and study projects that:

- supports a clear project process based on IPERKA
- shows tasks and responsibilities at a glance
- makes deadlines and submissions visible in one place
- makes collaboration in small groups easier
- provides checklists for typical deliverables
- shows project progress in an understandable way
- works on desktop and mobile
- can be used without technical knowledge or training
- can later be adapted to the needs of individual schools

Development happens step by step. Not every proposed feature is part of the first version.

## 4. Target groups

### 4.1 Primary

- Students at vocational schools (Berufsschule) and vocational baccalaureate schools (BMS)
- Students at upper secondary schools (Gymnasium)
- Apprentices in school and company projects
- Students at universities of applied sciences and universities
- Small student project groups

### 4.2 Secondary

- Teachers supervising projects
- Supervisors of final theses
- Schools and educational institutions
- Individuals organising small personal projects

Secondary groups are not part of the walking skeleton. Whether and how they are supported is decided after the requirements analysis.

## 5. Assumed needs

These needs were assumed at the start and are being validated through the [user survey](../research/04_user_survey.md) and later tests.

| ID | Assumed need | Status |
|---|---|---|
| `NEED-001` | Tasks are captured centrally and shown clearly. | To validate |
| `NEED-002` | Group members can see who is responsible for which task. | To validate |
| `NEED-003` | Deadlines and submissions are visible in one place. | To validate |
| `NEED-004` | Project progress can be seen quickly. | To validate |
| `NEED-005` | One-off and recurring checklists are supported. | To validate |
| `NEED-006` | Templates for typical school deliverables are available. | To validate |
| `NEED-007` | The app is easy to use on desktop and mobile. | To validate |
| `NEED-008` | Planned and actual progress can be compared. | To validate |
| `NEED-009` | Tasks can be weighted by effort or importance. | To validate |
| `NEED-010` | Project results and learnings can be documented. | To validate |
| `NEED-011` | The app can be used without lengthy onboarding. | To validate |

Derived requirements are documented in [02_requirements.md](02_requirements.md).

## 6. Scope

### 6.1 Walking skeleton (by 31 December 2026)

| Feature | Description | Status |
|---|---|---|
| Accounts | Register, sign in, sign out | Planned |
| Projects | Create, edit and view projects; only members have access | Planned |
| Group members | Add existing accounts to a project by email address (no email sending) | Planned |
| Kanban board | Tasks with status *To do*, *In progress*, *Done* and a responsible person | Planned |
| Submission checklist | Customisable checklist per project | Planned |

### 6.2 Possible extensions

| Feature | Status |
|---|---|
| Planned-vs-actual timeline | Proposed |
| Task points for weighting tasks | Proposed |
| Project phases (IPERKA) shown in the project | Proposed |
| Templates for specific schools and project types | Proposed |
| Email invitations and notifications | Proposed |
| Project closure with results and retrospective | Proposed |
| Teacher view | Proposed |
| School licence with central administration | Proposed |

## 7. Out of scope

- Managing large organisations or complex project portfolios
- Replacing chat or video conferencing tools
- Finance or accounting features
- Grading or binding rules for assessing school work
- Templates tailored to every individual school in the first version

## 8. Constraints

### 8.1 Functional
- The focus is on school and study projects.
- The first version must not be overloaded with pages, settings or features.
- Every planned feature is prioritised and checked for its benefit before it is built.

### 8.2 Technical
- ASP.NET Core with Blazor, ASP.NET Core Identity and Entity Framework Core (see [ADR-002](../decisions/ADR-002-switch-to-aspnet-core-blazor.md)).
- Authentication is never implemented manually.
- Every access to project data checks that the user is a member of the project.
- The app must be usable on current desktop and mobile browsers.
- Hosting must be affordable for a single developer.

### 8.3 Organisational
- The project is designed, built and documented by Sara Chenna alongside an apprenticeship.
- Time budget: about 10 hours per week.
- Development follows the IPERKA model.
- Potential users are involved in the requirements analysis and in testing.
- Planned, implemented and tested features are clearly separated.
- Public documentation contains no confidential or unnecessary personal data.

## 9. Assumptions

- Users have a device with a current browser and an internet connection.
- The app is mainly used for small individual and group projects.
- Users have little to average technical knowledge.
- Key project information should be accessible on a smartphone.
- Users are willing to keep their tasks up to date.
- Schools have different requirements that a general version cannot fully cover.

## 10. Roles

| Person | Role | Responsibility |
|---|---|---|
| Sara Chenna | Project owner, developer, test lead | Planning, decisions, implementation, documentation, testing |
| Volunteer testers | Test users | Usability, comprehensibility, functionality |
| Students | Potential users | Feedback on needs and practicality |
| Teachers | Possible stakeholders | Feedback on school requirements and project processes |

> Names of test persons are only published with explicit consent. Otherwise anonymised IDs are used.

## 11. Information gathering

| Method | Purpose | Status |
|---|---|---|
| [Platform evaluation](../research/01_platform_evaluation.md) | Compare platforms for the first prototype | Completed (superseded by ADR-002) |
| [Analysis of own project experience](../research/02_project_experience_analysis.md) | Derive needs from past projects | In Progress |
| [User survey](../research/04_user_survey.md) | Identify problems and desired features | In Progress (5 responses) |
| Interviews | Explore individual needs in depth | Planned |
| [Analysis of school requirements](../research/05_school_requirements_analysis.md) | Identify recurring deliverables | In Progress |

## 12. Preliminary success criteria

These criteria will be refined after the requirements analysis and linked to test cases in [06_testing.md](06_testing.md).

| ID | Criterion | Method | Status |
|---|---|---|---|
| `SC-001` | Testers can create a project without help. | Observation | Proposed |
| `SC-002` | Testers can create a task and assign it to a person. | Functional test | Proposed |
| `SC-003` | Testers can find their open tasks on their own. | Observation and timing | Proposed |
| `SC-004` | The current status of a task is visible to all group members. | Functional test | Proposed |
| `SC-005` | Core features work on desktop and smartphone. | Device test | Proposed |
| `SC-006` | A user cannot see projects they are not a member of. | Security test | Proposed |
| `SC-007` | Testers rate the app as easy to understand. | Final questionnaire | Proposed |
| `SC-008` | All must-have requirements pass their test cases. | Test log | Proposed |
| `SC-009` | Public documentation contains no personal data. | Privacy check | Proposed |

## 13. Test group

| Group | Count | Task |
|---|---:|---|
| Product testers | 4 | Test the app; two university students and two people in a final or project phase |
| Repository review | 1 | Review the GitHub repository for completeness and clarity |
| Survey review | 1 | Review the survey for clarity |

Across the group: one person with high, two with average and three with little or no technical knowledge. Testers use sample data only; minors are only included once the privacy concept is complete.

## 14. Privacy

Only data needed for the requirements analysis and testing is collected. Participation is voluntary. Raw data and email addresses are never published. Details: [research/03_data_collection_and_privacy.md](../research/03_data_collection_and_privacy.md)

Before real users create accounts, a privacy policy and terms of use under the Swiss Federal Act on Data Protection (FADP) are required. This is planned for January 2027.

## 15. Risks

| ID | Risk | Impact | Mitigation | Status |
|---|---|---|---|---|
| `RISK-001` | Scope grows too large. | Walking skeleton is not finished by December. | Fixed scope; new ideas go to an idea list and are reviewed after milestone M3. | Open |
| `RISK-002` | Web development is new territory. | Tasks take longer than planned. | Learning plan in week 1; reduce scope before reducing quality. | Open |
| `RISK-003` | Needs are based only on own assumptions. | Product does not match real demand. | Survey and tests with the target group. | Open |
| `RISK-004` | Security flaws in authentication or permissions. | Unauthorised access to project data. | ASP.NET Core Identity; membership check on every data access; security test case. | Open |
| `RISK-005` | Personal data is published or stored unnecessarily. | Privacy violation. | Sample data only during testing; anonymised results only. | Open |
| `RISK-006` | Hosting costs or effort are too high. | App cannot be shown online. | Decide on hosting by week 4; compare free and student offers. | Open |
| `RISK-007` | Test group is too small or too similar. | Limited validity of results. | Testers from different education levels. | Open |
| `RISK-008` | The name "Guidance" cannot be registered or is already in use. | Rebranding later. | Trademark check (swissreg, EUIPO) before public launch. | Open |

## 16. Open points

- Education levels of the four product testers
- Survey results and validated needs
- Hosting provider and costs
- Final product name (trademark check)
- Privacy policy and terms of use before public use
- Individual and school licence models

## 17. Exit criteria for the Inform phase

The Inform phase is complete when:

- the problem statement and primary target groups are confirmed
- the survey has been evaluated and needs are prioritised
- first requirements with unique IDs are documented
- measurable success criteria are defined
- privacy for survey and testing is prepared
- the platform decision is documented (done: ADR-002)

After that, the IPERKA phase **Plan** begins.

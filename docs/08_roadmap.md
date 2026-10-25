# Roadmap

| | |
|---|---|
| Last updated | 25 October 2026 |
| Status | Accepted |
| Time budget | about 10 hours per week; additional hours count as buffer |

## Goal by 31 December 2026

A working walking skeleton of **Guidance**, available online, that recruiters and testers can try from January 2027.

| Feature | Scope in the walking skeleton |
|---|---|
| Accounts | Register, sign in, sign out via ASP.NET Core Identity |
| Projects | Create, edit, view; only members can see a project |
| Group members | Add an existing account to a project by email address (no email sending) |
| Kanban board | Tasks with status *To do*, *In progress*, *Done* and a responsible person |
| Submission checklist | Customisable checklist per project |

Not in the walking skeleton: planned-vs-actual timeline, school templates, notifications, email invitations, school licence.

## Weekly plan

| Week | Dates | IPERKA | Goals |
|---|---|---|---|
| 1 | 26.10.–01.11. | Inform | Distribute the survey more widely; set up Visual Studio and run a first Blazor page locally |
| 2 | 02.–08.11. | Inform → Plan | Evaluate the survey; finalise user stories with MoSCoW in [02_requirements.md](02_requirements.md); refine the [data model](04_system_design.md) |
| 3 | 09.–15.11. | Decide → Implement | Project scaffold in the repository; EF Core with SQLite; registration and sign-in; build check on pull requests |
| 4 | 16.–22.11. | Implement | Create and edit projects including permission checks; decide on hosting |
| 5 | 23.–29.11. | Implement | Add group members; first version online |
| 6 | 30.11.–06.12. | Implement | Kanban board |
| 7 | 07.–13.12. | Implement | Submission checklist; prepare test cases |
| 8 | 14.–20.12. | Verify | Tests with 4 testers (sample data only); prioritise and fix issues |
| 9 | 21.–31.12. | Review | Remaining fixes; README, screenshots and learnings for applications; holiday buffer |

## Milestones

| ID | Milestone | Target date | Criterion |
|---|---|---|---|
| `M1` | Sign-in works | 15.11.2026 | Create account, sign in and sign out locally |
| `M2` | First version online | 29.11.2026 | Projects and members usable via a public URL |
| `M3` | Walking skeleton complete | 13.12.2026 | All five features implemented |
| `M4` | Ready for applications | 31.12.2026 | Tests evaluated, README and demo up to date |

## Rules

- If a week is not enough, scope is cut first, not quality.
- New ideas go to an idea list and are reviewed after `M3`.
- No real student data before the privacy concept is complete.
- Small, regular commits with clear messages.
- Weekly check-in: progress, deviations, next week.

## Open points

- Hosting provider and costs
- Final product name (trademark check on swissreg and EUIPO)

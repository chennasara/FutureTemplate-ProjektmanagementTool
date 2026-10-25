# Limitations and Learnings

| | |
|---|---|
| IPERKA phase | Review (updated continuously) |
| Status | In Progress |

## Known limitations of the walking skeleton

| Limitation | Reason | Planned handling |
|---|---|---|
| Members can only be added if they already have an account | Email sending is out of scope until December | Email invitations as a later extension |
| No teacher or school roles | Not needed for the first user group | Evaluate after tests and school feedback |
| No real student data | Privacy concept not yet complete | Privacy policy and terms planned for January 2027 |
| No offline use | Server-rendered Blazor needs a connection | Re-evaluate after tests |

## Learnings

### 2026-10 – Platform switch from Notion to a web app

**What happened:** A weighted evaluation chose Notion for the first prototype ([ADR-001](../decisions/ADR-001-notion-as-first-prototype.md)). When planning group collaboration in detail, the core needs – accounts, membership, permissions and later school adaptation – turned out to depend on exactly the areas where Notion's free plan is limited.

**What I learned:**
- An evaluation is only as good as its weighting. "Development effort" was weighted highest, which favoured no-code tools, while the decisive need – real collaboration – was weighted low.
- Defining triggers for re-evaluation in advance made it easy to justify the switch instead of just changing direction.
- Earlier research was not wasted: the analysis of school requirements, the survey and the IPERKA structure carry over directly.

Details: [ADR-002](../decisions/ADR-002-switch-to-aspnet-core-blazor.md)


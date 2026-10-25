# Testing

| | |
|---|---|
| IPERKA phase | Verify |
| Status | Planned (weeks 7–8) |

## Approach

| Level | What is tested | How |
|---|---|---|
| Unit tests | Business rules, e.g. membership checks | xUnit, run automatically on every pull request |
| Functional tests | Each must-have requirement | Test cases linked to requirement IDs |
| Security test | Users cannot access other users' projects | Manual test with two accounts and direct URLs |
| Usability tests | Comprehensibility without training | Observation of 4 testers with given tasks |
| Device tests | Desktop and smartphone | At least one browser each |

## Rules

- Testers only use sample data, never real school projects.
- Results are documented with anonymised tester IDs (`T01`–`T04`).
- Each test records: device, tested version, time needed, difficulties, suggestions.

## Test cases

Will be derived from [02_requirements.md](02_requirements.md) in week 7.

| ID | Requirement | Steps | Expected result | Result |
|---|---|---|---|---|
| | | | | |

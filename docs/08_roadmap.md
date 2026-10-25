# Roadmap

**Stand:** 25. Oktober 2026
**Status:** Proposed (Review durch Sara ausstehend)
**Zeitbudget:** ca. 10 Stunden pro Woche für die Webanwendung, zusätzliche Stunden gelten als Puffer

## Ziel bis 31. Dezember 2026

Ein funktionierender, online erreichbarer Durchstich der Webanwendung (Codename «Guidance»), den Recruiter ab Januar 2027 ausprobieren können.

| Funktion | Umfang im Durchstich |
|---|---|
| Registrieren und Anmelden | über ASP.NET Core Identity |
| Projekte | anlegen, bearbeiten, anzeigen; nur Mitglieder sehen ein Projekt |
| Gruppenmitglieder | bestehendes Konto per E-Mail-Adresse zu einem Projekt hinzufügen (ohne E-Mail-Versand) |
| Kanban-Board | Aufgaben mit Status Offen, In Arbeit, Erledigt und verantwortlicher Person |
| Abgabe-Checkliste | anpassbare Checkliste pro Projekt |

Nicht im Durchstich: Soll-Ist-Diagramm, Schulvorlagen, Benachrichtigungen, E-Mail-Einladungen, Schullizenz.

## Technik

ASP.NET Core, Blazor, ASP.NET Core Identity, Entity Framework Core (lokal SQLite, online PostgreSQL). Entwicklungsumgebung: Visual Studio. Hosting wird bis Woche 4 entschieden.

## Wochenplan

| Woche | Zeitraum | IPERKA | Ziele |
|---|---|---|---|
| 1 | 26.10.–01.11. | Informieren | Umfrage breiter verteilen; ADR-002 Plattformwechsel; README: Vision und Durchstich trennen; Entwicklungsumgebung einrichten, erste Blazor-Seite läuft lokal |
| 2 | 02.–08.11. | Informieren → Planen | Umfrage auswerten; User Stories mit Must/Should/Could in `02_requirements.md`; Datenmodell skizzieren (Benutzer, Projekt, Mitgliedschaft, Aufgabe, Checklistenpunkt) |
| 3 | 09.–15.11. | Entscheiden → Realisieren | Projektgerüst im Repository; EF Core mit SQLite; Registrieren und Anmelden |
| 4 | 16.–22.11. | Realisieren | Projekte anlegen und bearbeiten inklusive Berechtigungsprüfung; Hosting entscheiden |
| 5 | 23.–29.11. | Realisieren | Gruppenmitglieder hinzufügen; erste Version online stellen |
| 6 | 30.11.–06.12. | Realisieren | Kanban-Board |
| 7 | 07.–13.12. | Realisieren | Abgabe-Checkliste; Testfälle vorbereiten |
| 8 | 14.–20.12. | Kontrollieren | Tests mit 4 Testpersonen (nur Beispieldaten); Fehler priorisieren und beheben |
| 9 | 21.–31.12. | Auswerten | Restliche Fehler; README für Bewerbungen, Screenshots, Learnings; Feiertagspuffer |

## Meilensteine

| ID | Meilenstein | Ziel-Datum | Kriterium |
|---|---|---|---|
| `M1` | Anmeldung funktioniert | 15.11.2026 | Konto erstellen, anmelden, abmelden lokal möglich |
| `M2` | Erste Version online | 29.11.2026 | Projekte und Mitglieder über öffentliche URL nutzbar |
| `M3` | Durchstich vollständig | 13.12.2026 | Alle fünf Funktionen umgesetzt |
| `M4` | Bewerbungsbereit | 31.12.2026 | Tests ausgewertet, README und Demo aktuell |

## Nebenstränge (nicht Teil der 10 Stunden)

| Strang | Budget | Ziel |
|---|---|---|
| Notion IPERKA-Planer | einmalig | Gebaut am 24.10.2026; verkaufsbereit, sobald der Test im Free-Workspace bestanden ist |
| Instagram @futuretemplate | max. 2 h/Woche | Aufbau nach Content-Strategie, Inhalte gebündelt produzieren |

## Regeln

- Wenn eine Woche nicht reicht, wird zuerst der Umfang gekürzt, nicht die Qualität.
- Neue Ideen kommen in eine Ideenliste und werden erst nach `M3` geprüft.
- Keine echten Schülerdaten vor Abschluss des Datenschutzkonzepts.
- Kleine, regelmässige Commits mit klaren Nachrichten.
- Wöchentlicher Check-in mit der Koordinatorin: Stand, Abweichungen, nächste Woche.

## Offene Punkte

- Hosting-Anbieter und Kosten
- Endgültiger App-Name (Prüfung swissreg/EUIPO)
- Preis und Marketplace-Kategorie für den Notion IPERKA-Planer

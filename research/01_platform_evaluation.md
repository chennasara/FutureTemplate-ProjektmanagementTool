# Plattformevaluation für die Produktentwicklung

## Dokumentstatus

| Angabe | Wert |
|---|---|
| Bestandteil der IPERKA-Phase | Informieren |
| Status | Completed |
| Stand der Recherche | 26. September 2026 |
| Verantwortliche Person | Sara Chenna |
| Entscheidungsgegenstand | Plattform für den ersten funktionsfähigen Prototyp |
| Ausgewählte Plattform | Notion |

> Diese Evaluation untersucht, auf welcher Plattform das geplante
> Projektmanagement-System entwickelt werden soll.

## 1. Entscheidungsbedarf

Die Ausgangslage, Zielgruppen, Anforderungen und der vorgesehene Funktionsumfang sind in [`01_project_overview.md`](01_project_overview.md) dokumentiert.

Für den Übergang von der Informations- in die Planungsphase muss festgelegt werden, auf welcher technischen Grundlage der erste funktionsfähige Prototyp umgesetzt wird. Diese Evaluation dokumentiert ausschliesslich diese Plattformentscheidung.

## 2. Ziel der Evaluation

Die Evaluation soll folgende Frage beantworten:

> Welche Plattform eignet sich am besten, um mit vertretbarem Aufwand ein
> verständliches, anpassbares und verkaufbares Projektmanagement-System für
> schulische und studentische Projekte zu entwickeln und zu testen?

Die Entscheidung bezieht sich auf den ersten funktionsfähigen Prototyp und

nicht zwingend auf die langfristige technische Endlösung.

## 3. Untersuchte Optionen

| Option | Art der Lösung | Grund für die Aufnahme |
|---|---|---|
| Notion | No-Code-Workspace und Template-Plattform | Aktuell vorgesehene Entwicklungsumgebung und grosse Gestaltungsfreiheit für Vorlagen |
| Coda | Dokumentenbasierte No-Code-Plattform | Verbindet Dokumente, Tabellen, Formeln, Buttons und Automatisierungen |
| Airtable | No-Code-Datenbank und App-Plattform | Starke relationale Datenstrukturen, Ansichten, Interfaces und Automatisierungen |
| Microsoft Power Apps | Low-Code-App-Plattform | Interessant für Schulen mit Microsoft-365-Umgebung |
| eigene Webanwendung | individuell programmierte Anwendung | Maximale Kontrolle über Funktionen, Benutzeroberfläche und Geschäftsmodell |

## 4. Ausschluss anderer Projektmanagement-Produkte

Trello, Asana, Microsoft Planner und ClickUp sind fertige Projektmanagement-Produkte und werden in der separaten [`01_competitor_analysis.md`](01_competitor_analysis.md) betrachtet.

## 5. Bewertungssystem

Jede Plattform wird anhand einer Skala von 1 bis 5 bewertet.

| Bewertung | Bedeutung |
|---:|---|
| 1 | sehr schlecht geeignet |
| 2 | eher schlecht geeignet |
| 3 | teilweise geeignet |
| 4 | gut geeignet |
| 5 | sehr gut geeignet |

Die gewichtete Punktzahl wird wie folgt berechnet:

```text

Gewichtete Punktzahl = Bewertung / 5 × Gewichtung

```

Die maximal erreichbare Gesamtpunktzahl beträgt 100 Punkte.

## 6. Bewertungskriterien

| ID | Kriterium | Gewichtung | Begründung |
|---|---|---:|---|
| `PLAT-001` | Benutzerfreundlichkeit für die Zielgruppe | 10 % | Das Produkt soll ohne lange Einarbeitung verwendbar sein. |
| `PLAT-002` | Verteilung und Verkauf des Produkts | 10 % | Das Produkt soll einfach an Nutzerinnen und Nutzer übergeben werden können. |
| `PLAT-003` | kostenlose Grundnutzung | 10 % | Die Zielgruppe soll kein Pflichtabonnement benötigen. |
| `PLAT-004` | Dokumentation und Inhalte | 10 % | Projektwissen, Vorlagen und Learnings sollen zentral abgelegt werden. |
| `PLAT-005` | Datenmodell | 10 % | Projekte, Aufgaben, Personen und Meilensteine müssen verknüpft werden können. |
| `PLAT-006` | Formeln und Automatisierungen | 10 % | Fortschritt, Taskpoints und wiederkehrende Abläufe sollen unterstützt werden. |
| `PLAT-007` | Gestaltungsfreiheit | 10 % | Benutzeroberfläche und Projektablauf sollen zielgruppengerecht aufgebaut werden. |
| `PLAT-008` | Zusammenarbeit | 5 % | Kleine Projektgruppen sollen gemeinsam arbeiten können. |
| `PLAT-009` | mobile Nutzbarkeit | 5 % | Wichtige Informationen sollen über ein Smartphone erreichbar sein. |
| `PLAT-010` | Entwicklungs- und Wartungsaufwand | 15 % | Die erste Version wird von einer Person entwickelt und gepflegt. |
| `PLAT-011` | Betriebs- und Rechtsaufwand | 5 % | Hosting, Konten, Sicherheit und Datenverarbeitung sollen beherrschbar bleiben. |
|  | **Gesamt** | **100 %** |  |

## 7. Nutzwertanalyse

### 7.1 Bewertungen

| Kriterium | Gewichtung | Notion | Coda | Airtable | Power Apps | eigene Webanwendung |
|---|---:|---:|---:|---:|---:|---:|
| Benutzerfreundlichkeit für die Zielgruppe | 10 % | 5 | 3 | 3 | 2 | 5 |
| Verteilung und Verkauf des Produkts | 10 % | 5 | 4 | 3 | 2 | 5 |
| kostenlose Grundnutzung | 10 % | 5 | 3 | 4 | 2 | 2 |
| Dokumentation und Inhalte | 10 % | 5 | 5 | 2 | 3 | 5 |
| Datenmodell | 10 % | 4 | 5 | 5 | 5 | 5 |
| Formeln und Automatisierungen | 10 % | 3 | 5 | 4 | 5 | 5 |
| Gestaltungsfreiheit | 10 % | 3 | 4 | 4 | 5 | 5 |
| Zusammenarbeit | 5 % | 4 | 4 | 4 | 4 | 5 |
| mobile Nutzbarkeit | 5 % | 4 | 4 | 4 | 4 | 4 |
| Entwicklungs- und Wartungsaufwand | 15 % | 5 | 4 | 3 | 2 | 1 |
| Betriebs- und Rechtsaufwand | 5 % | 4 | 4 | 4 | 2 | 1 |

### 7.2 Gewichtete Ergebnisse

| Rang | Plattform | Punktzahl | Ergebnis |
|---:|---|---:|---|
| 1 | Notion | **87/100** | sehr gut geeignet |
| 2 | Coda | **82/100** | gut bis sehr gut geeignet |
| 3 | eigene Webanwendung | **77/100** | langfristig interessant, aktuell zu aufwendig |
| 4 | Airtable | **71/100** | technisch geeignet, aber weniger dokumentenorientiert |
| 5 | Microsoft Power Apps | **64/100** | für institutionelle Microsoft-Umgebungen geeignet |

Die Bewertungen stellen eine begründete Projekteinschätzung dar. Sie müssen

durch einen kleinen praktischen Test der wichtigsten Annahmen ergänzt werden.

## 8. Einzelbewertung

### 8.1 Notion

#### Geeignete Eigenschaften

- Seiten und Datenbanken können innerhalb eines Systems kombiniert werden.
- Tabellen-, Board-, Kalender-, Galerie- und Timeline-Ansichten unterstützen unterschiedliche Arbeitsweisen.
- Formeln, Relationen und Rollups ermöglichen verknüpfte Projektdaten.
- Datenbankvorlagen können für wiederkehrende Projektstrukturen verwendet werden.
- Formulare können mit Datenbanken verbunden werden.
- Templates können in andere Workspaces dupliziert und über den Marketplace angeboten werden.
- Web-, Desktop- und Mobile-Anwendungen sind verfügbar.
- Inhalte können als PDF, CSV oder HTML exportiert werden.

#### Einschränkungen

- Erweiterte Datenbankautomatisierungen sind im Free-Tarif nicht frei bearbeitbar.
- Gemeinsame Free-Workspaces besitzen Einschränkungen bei Mitgliedern und Blöcken.
- Die Anzahl der Gäste ist im Free-Tarif begrenzt.
- Dateien im Free-Tarif besitzen eine Grössenbegrenzung.
- Nur ein natives Diagramm kann im Free-Tarif kostenlos genutzt werden.
- Die Benutzeroberfläche kann nicht vollständig frei programmiert werden.
- Änderungen an der Originalvorlage werden nicht automatisch auf alle bereits duplizierten Kopien übertragen.

#### Bewertung

Notion eignet sich besonders gut für den ersten Prototyp, weil das Produkt aus

Projektmanagement, Vorlagen und Dokumentation besteht. Ein grosser Teil der

gewünschten Funktionen kann ohne klassische Softwareentwicklung umgesetzt und

mit Testpersonen früh überprüft werden.

### 8.2 Coda

#### Geeignete Eigenschaften

- kombiniert Dokumente mit Tabellen, Ansichten, Formeln und Buttons
- unterstützt umfangreiche Formeln und Automatisierungen
- ermöglicht appähnliche Dokumente
- bietet eine Vorlagengalerie
- verwendet ein Maker-Modell, bei dem in bezahlten Workspaces nur Doc Makers bezahlt werden
- Editoren und Betrachtende können in bezahlten Workspaces kostenlos mitarbeiten

#### Einschränkungen

- geteilte Dokumente im Free-Tarif sind auf 50 Objekte begrenzt
- geteilte Free-Dokumente sind auf 1'000 Tabellenzeilen begrenzt
- für die Zielgruppe weniger bekannt als Notion
- höhere Einarbeitungszeit bei komplexen Formeln und Automatisierungen
- Vertrieb und Vermarktung von Vorlagen besitzen eine kleinere Reichweite als im Notion-Ökosystem

#### Bewertung

Coda ist technisch eine starke Alternative und übertrifft Notion bei einigen

Automatisierungs- und Formelfunktionen. Die Grenzen geteilter kostenloser

Dokumente sind für ein wachsendes Projektmanagement-System jedoch relevant.

Die geringere Bekanntheit bei der Zielgruppe erhöht ausserdem den

Erklärungsaufwand.

### 8.3 Airtable

#### Geeignete Eigenschaften

- leistungsfähige relationale Datenbanken
- verschiedene Ansichten und Interfaces
- Formulare und Automatisierungen
- geeignet für strukturierte Daten und umfangreiche Auswertungen
- kostenloser Tarif für Einzelpersonen und sehr kleine Teams
- zeitlich begrenzte kostenlose Team-Angebote für berechtigte Studierende

#### Einschränkungen

- Dokumentation und längere Projektinhalte stehen weniger im Mittelpunkt
- die Bedienung wirkt stärker datenbank- als dokumentenorientiert
- Interfaces im Free-Tarif können nur mit verifizierten Airtable-Konten geteilt werden
- einzelne Automatisierungen, Datensätze und Erweiterungen besitzen Tariflimits
- für ein vollständiges Lern- und Projektsystem wären zusätzliche Erklärungen oder externe Dokumente erforderlich

#### Bewertung

Airtable eignet sich gut für das Datenmodell und strukturierte Auswertungen.

Für ein Produkt, das zusätzlich Vorlagen, Anleitungen, Projektdokumentation und

Learnings enthalten soll, ist Notion jedoch besser auf den geplanten

Gesamtzweck abgestimmt.

### 8.4 Microsoft Power Apps

#### Geeignete Eigenschaften

- weitgehend frei gestaltbare Low-Code-Anwendungen
- Anbindung an Microsoft 365, SharePoint, Teams und weitere Datenquellen
- umfangreiche Automatisierungen über Power Automate
- Benutzer- und Rechteverwaltung innerhalb einer Microsoft-Organisation
- interessant für Schulen mit einer zentral verwalteten Microsoft-Umgebung

#### Einschränkungen

- Lizenzierung hängt von Microsoft-365- und Power-Platform-Plänen ab
- Microsoft-365-Lizenzen enthalten nur eingeschränkte Power-Apps- und Power-Automate-Rechte
- Premium-Connectors und erweiterte Funktionen benötigen zusätzliche Lizenzen
- Einrichtung kann Unterstützung durch die IT-Administration der Schule erfordern
- Verkauf als einfach duplizierbares Produkt an Einzelpersonen ist schwieriger
- höherer Entwicklungs-, Test- und Supportaufwand

#### Bewertung

Power Apps ist interessant, wenn später eine konkrete Schule eine interne

Anwendung innerhalb ihrer Microsoft-Umgebung benötigt. Für ein allgemein

verkaufbares Produkt an einzelne Schülerinnen, Schüler und Studierende ist die

Lizenz- und Administrationsabhängigkeit aktuell zu gross.

### 8.5 Eigene Webanwendung

#### Geeignete Eigenschaften

- vollständige Kontrolle über Benutzeroberfläche und Benutzerführung
- eigene Benutzerkonten und Berechtigungsmodelle
- frei programmierbare Automatisierungen und Benachrichtigungen
- zentrale Aktualisierung für alle Nutzerinnen und Nutzer
- eigene Preis-, Lizenz- und Abonnementmodelle
- bessere langfristige Skalierbarkeit bei nachgewiesener Nachfrage
- keine Abhängigkeit von den Funktionsgrenzen einer No-Code-Plattform

#### Einschränkungen

- hoher Entwicklungsaufwand für eine Einzelperson
- Hosting, Datenbank, Authentifizierung und Backups müssen betrieben werden
- Sicherheitsupdates und Fehlerbehebungen müssen dauerhaft gewährleistet werden
- höhere Anforderungen an Datenschutz und technische Dokumentation
- zusätzliche Verantwortung für personenbezogene Daten
- Web- und Mobile-Oberflächen müssen selbst entwickelt und getestet werden
- Support und Betrieb verursachen wiederkehrende Kosten
- ein vollständiger Prototyp wäre deutlich später testbar

#### Bewertung

Eine eigene Webanwendung ist langfristig die flexibelste Option. Für die

aktuelle Projektphase wäre sie jedoch unverhältnismässig aufwendig. Zuerst

soll mit einem Notion-Prototyp geprüft werden, ob die Zielgruppe das Produkt

tatsächlich benötigt und welche Funktionen im Alltag verwendet werden.

## 9. Entscheidung

### 9.1 Ausgewählte Plattform

Der erste funktionsfähige Prototyp wird in **Notion** entwickelt.

**Entscheidungsstatus:** Accepted for MVP

### 9.2 Begründung

Notion wurde ausgewählt, weil:

1. die geplante Lösung Aufgabenverwaltung und Projektdokumentation verbindet
2. ein funktionsfähiger Prototyp mit überschaubarem Aufwand erstellt werden kann
3. das Produkt als duplizierbares Template verteilt und verkauft werden kann
4. die Zielgruppe kein zwingendes kostenpflichtiges Abonnement benötigt
5. Datenbanken, Relationen, Rollups und Formeln für die Kernfunktionen ausreichen
6. Vorlagen und Anleitungen direkt in das Produkt integriert werden können
7. Desktop- und Mobile-Anwendungen bereits vorhanden sind
8. Nutzerfeedback früh eingeholt werden kann, bevor hohe Entwicklungskosten entstehen

Notion besitzt nicht in jedem Kriterium die stärksten Funktionen. Die Plattform

bietet jedoch das beste Verhältnis zwischen Funktionsumfang, Entwicklungszeit,

Zugänglichkeit und Portfolio-Nutzen für die erste Version.

## 10. Bedingungen für eine spätere Neubeurteilung

Eine eigene Webanwendung wird erst geprüft, wenn der Notion-Prototyp klare Grenzen erreicht oder eine nachweisbare Nachfrage besteht.

Mögliche Auslöser sind:

- mehrere Schulen zeigen konkretes Kaufinteresse
- Nutzerinnen und Nutzer benötigen eine zentrale Kontenverwaltung
- mehrstufige Rollen und Berechtigungen werden zwingend erforderlich
- automatische Aktualisierungen müssen für alle Kundinnen und Kunden gleichzeitig erfolgen
- Notion-Automatisierungen reichen für zentrale Abläufe nicht mehr aus
- umfangreiche Benachrichtigungen werden benötigt
- das Produkt erreicht regelmässige Einnahmen, die Entwicklung und Betrieb finanzieren können
- Tests zeigen, dass die Notion-Bedienung die Zielgruppe wesentlich behindert

Das Erreichen eines einzelnen Auslösers führt noch nicht automatisch zur Neuentwicklung. Vorher ist eine separate Wirtschaftlichkeits- und Risikoanalyse erforderlich.

## 11. Auswirkungen auf die Planung

Durch die Plattformentscheidung gelten für die Planungsphase folgende Vorgaben:

- Die Informationsarchitektur wird innerhalb der Möglichkeiten von Notion geplant.
- Kernfunktionen müssen im kostenlosen Notion-Tarif nutzbar sein.
- kostenpflichtige Funktionen werden nur als optionale Erweiterungen behandelt.
- das System wird für Einzelpersonen und kleine Projektgruppen optimiert.
- die Anzahl der Seiten, Datenbanken und Eigenschaften wird bewusst begrenzt.
- mobile Ansichten werden von Beginn an berücksichtigt.
- Automatisierungen erhalten immer eine manuelle Alternative.
- vertrauliche Daten werden nicht für die Funktionsfähigkeit vorausgesetzt.
- technische Grenzen werden transparent dokumentiert.
- Anforderungen an eine spätere Webanwendung werden nicht in den MVP-Umfang aufgenommen.

## 12. Risiken der Entscheidung

| ID | Risiko | Auswirkung | Gegenmassnahme |
|---|---|---|---|
| `PLAT-RISK-001` | Notion ändert Funktionen oder Tarife. | Teile des Templates funktionieren nicht mehr wie dokumentiert. | Kernfunktionen regelmässig im Free-Tarif testen. |
| `PLAT-RISK-002` | Das Template wird zu komplex. | Die Zielgruppe benötigt trotz Vorlage eine lange Einarbeitung. | Funktionsumfang priorisieren und mit Testpersonen prüfen. |
| `PLAT-RISK-003` | Bereits duplizierte Templates erhalten keine zentralen Aktualisierungen. | Kundinnen und Kunden verwenden unterschiedliche Versionen. | Versions- und Update-Konzept entwickeln. |
| `PLAT-RISK-004` | Zusammenarbeit im Free-Tarif reicht nicht aus. | Grössere Gruppen können das Template nur eingeschränkt verwenden. | Zielgruppe begrenzen und Gastmodell dokumentieren. |
| `PLAT-RISK-005` | Benötigte Automatisierungen sind kostenpflichtig. | Kernabläufe funktionieren nicht für alle Nutzenden. | Manuelle oder buttonbasierte Alternativen einplanen. |
| `PLAT-RISK-006` | Eine Schule verlangt zentrale Administration. | Das Produkt kann institutionelle Anforderungen nicht erfüllen. | Schulversion später separat evaluieren. |
| `PLAT-RISK-007` | Die Zielgruppe bevorzugt bereits vorhandene Plattformen. | Geringe Nachfrage nach dem Template. | Nutzen und Nachfrage vor grosser Umsetzung testen. |

## 13. Abschlusskriterien der Plattformevaluation

Die Plattformevaluation gilt als abgeschlossen, weil:

- der Zweck der Plattform festgelegt wurde
- geeignete Plattformtypen identifiziert wurden
- ein gewichtetes Bewertungssystem angewendet wurde
- die fünf Optionen nachvollziehbar verglichen wurden
- technische und organisatorische Grenzen dokumentiert wurden
- eine Plattform für den ersten Prototyp ausgewählt wurde
- eine spätere Neubeurteilung anhand konkreter Auslöser vorgesehen ist

Damit ist die Plattformfrage für den ersten Prototyp ausreichend geklärt und

die Planung des Notion-Systems kann beginnen.

## 14. Quellen

### Notion

- [Notion – Tarife](https\://www\.notion.com/pricing)
- [Notion – Datenbankautomatisierungen](https\://www\.notion.com/help/database-automations)
- [Notion – Datenbankvorlagen](https\://www\.notion.com/help/database-templates)
- [Notion – Formulare](https\://www\.notion.com/help/forms)
- [Notion für Bildung](https\://www\.notion.com/help/notion-for-education)

### Coda

- [Coda – Tarife](https\://coda.io/pricing)
- [Coda – Abrechnung und Doc Makers](https\://help.coda.io/hc/en-us/articles/39555725230989-Billing-and-pricing-basics)
- [Coda – Dokumentlimits](https\://help.coda.io/hc/en-us/articles/39555760015757-Overview-Doc-limits)
- [Coda – Automatisierungen](https\://help.coda.io/hc/en-us/articles/39555778179853-Automations-in-Coda)

### Airtable

- [Airtable – Tarife](https\://airtable.com/pricing)
- [Airtable – Tarifübersicht](https\://support.airtable.com/docs/airtable-plans)
- [Airtable – Automatisierungen](https\://support.airtable.com/docs/getting-started-with-airtable-automations)
- [Airtable – Interfaces teilen](https\://support.airtable.com/docs/managing-and-sharing-interfaces)

### Microsoft Power Apps

- [Microsoft – Power Platform Lizenzübersicht](https\://learn.microsoft.com/en-us/power-platform/admin/pricing-billing-skus)
- [Microsoft – Power Apps Dokumentation](https\://learn.microsoft.com/en-us/power-apps/)
- [Microsoft – Power Apps für Bildung](https\://learn.microsoft.com/en-us/microsoft-365/education/guide/1-addons/addons-powerapps)
- [Microsoft – Microsoft 365 Education](https\://learn.microsoft.com/en-us/office365/servicedescriptions/office-365-platform-service-description/microsoft-365-education)

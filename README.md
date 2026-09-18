# FutureTemplate-ProjektmanagementTool
This repository documents the development of a structured project management system in Notion. It covers requirements, database architecture, workflows, technical decisions, testing, challenges, and key learnings while demonstrating my structured approach and technical understanding.

# Notion Project Management System

## 1. Projektbeschreibung

Ziel dieses Projekts ist die Entwicklung eines professionellen Projektmanagement-Tools in Notion. Das System soll nicht nur Aufgaben verwalten, sondern den vollständigen Ablauf eines Projekts strukturiert und nachvollziehbar abbilden.

Dazu gehören:

- Projektziele
- Anforderungen
- Aufgaben und Prioritäten
- Termine und Meilensteine
- Entscheidungen und Begründungen
- Probleme und Lösungen
- Tests und Feedback
- Projektergebnisse
- Learnings und Retrospektiven
- Screenshots, Dateien und weitere Nachweise

Das System soll für unterschiedliche Projektarten eingesetzt werden können, beispielsweise:

- Informatikprojekte
- Schulprojekte
- Notion-Produkte
- Business-Ideen
- persönliche Projekte

Ein weiteres Ziel besteht darin, die eigene Arbeitsweise nachvollziehbar zu dokumentieren.

---

## 2. Projektablauf

Jedes Projekt soll eine klare und nachvollziehbare Entwicklung zeigen:

> Ausgangslage → Ziel → Anforderungen → Planung → Umsetzung → Testing → Ergebnis → Learnings

Für die Entwicklung eines Notion-Produkts könnte der Ablauf beispielsweise so aussehen:

> Idee → Zielgruppe → Nutzerproblem → Anforderungen → Planung → Entwicklung → Testing → Veröffentlichung → Feedback → Verbesserung

Damit wird nicht nur das fertige Produkt dokumentiert, sondern auch der Weg dorthin.

---

## 3. Grundprinzip des Systems

Das Notion-System besteht aus drei Ebenen:

### 3.1 Systemebene

Die Systemebene enthält die zentralen Originaldatenbanken. In diesen Datenbanken werden alle Informationen gespeichert.

### 3.2 Arbeitsebene

Dashboards und Arbeitsbereiche zeigen gefilterte und sortierte Ansichten der zentralen Datenbanken.

### 3.3 Projektebene

Jede Projektseite zeigt nur die Aufgaben, Meilensteine, Entscheidungen und Dokumentationen, die zum jeweiligen Projekt gehören.

Die Informationen werden dadurch nicht mehrfach gespeichert. Ein Datensatz wird einmal in einer zentralen Datenbank angelegt und kann an mehreren Stellen angezeigt werden.

---

## 4. Datenbankkonzept

Die zentralen Datenbanken werden als eigene Notion-Seiten erstellt. Sie befinden sich in einem Systembereich und funktionieren gewissermassen im Hintergrund.

Auf Dashboards und Projektseiten werden verknüpfte Ansichten dieser Datenbanken eingefügt.

### Vorgesehene Datenbanken

| Datenbank | Zweck |
|---|---|
| Projekte | Verwaltung aller Projekte |
| Aufgaben | Aufgaben, Zuständigkeiten, Prioritäten und Termine |
| Meilensteine | Wichtige Projektetappen und Zieltermine |
| Anforderungen | Fachliche und technische Anforderungen |
| Entscheidungen | Entscheidungen, Alternativen und Begründungen |
| Probleme & Lösungen | Herausforderungen, Ursachen und Lösungen |
| Besprechungen | Sitzungen, Notizen und Vereinbarungen |
| Tests & Feedback | Testfälle, Ergebnisse und Rückmeldungen |
| Learnings | Erkenntnisse und Verbesserungsvorschläge |
| Nachweise | Screenshots, Dokumente und Projektergebnisse |

---

## 5. Weshalb zentrale Datenbanken verwendet werden

Die zentralen Datenbanken werden jeweils als vollständige Datenbank auf einer eigenen Seite erstellt.

Dieses Vorgehen bietet folgende Vorteile:

- Alle Informationen werden zentral gespeichert.
- Dieselben Daten können an mehreren Orten angezeigt werden.
- Daten müssen nicht doppelt erfasst werden.
- Ansichten können unterschiedlich gefiltert werden.
- Änderungen werden automatisch in allen Ansichten übernommen.
- Das System bleibt auch bei vielen Projekten übersichtlich.
- Projektübergreifende Auswertungen werden möglich.
- Das System kann später einfacher erweitert werden.

Inline-Datenbanken werden nur für kleine, einmalige Listen verwendet, die ausschliesslich auf einer bestimmten Seite benötigt werden.

Beispiele dafür sind:

- eine kleine Materialliste
- eine kurze Checkliste
- einmalige Projektnotizen
- projektspezifische Informationen ohne weitere Auswertung

---

## 6. Seitenstruktur des Notion-Templates

Notion verwendet keine klassischen Ordner wie Windows. Die Struktur wird mit Seiten und Unterseiten aufgebaut.

```text
PROJECT OS
│
├── 01 Dashboard
│   ├── Meine Aufgaben
│   ├── Aktive Projekte
│   ├── Nächste Meilensteine
│   ├── Offene Probleme
│   └── Schnellzugriff
│
├── 02 Projekte
│   ├── Alle Projekte
│   ├── Aktive Projekte
│   ├── Geplante Projekte
│   ├── Abgeschlossene Projekte
│   └── Projektarchiv
│
├── 03 Aufgaben
│   ├── Heute
│   ├── Diese Woche
│   ├── Überfällig
│   ├── Nach Priorität
│   └── Erledigt
│
├── 04 Planung
│   ├── Meilensteine
│   ├── Anforderungen
│   ├── Entscheidungen
│   └── Projekt-Roadmap
│
├── 05 Dokumentation
│   ├── Besprechungen
│   ├── Probleme & Lösungen
│   ├── Tests & Feedback
│   ├── Learnings
│   └── Dateien & Nachweise
│
├── 06 Portfolio
│   ├── Präsentierbare Projekte
│   ├── Projektergebnisse
│   └── Bewerbungsansicht
│
├── 07 Vorlagen
│   ├── Neue Projektvorlage
│   ├── Neue Aufgabe
│   ├── Neue Besprechung
│   ├── Neuer Testfall
│   └── Projektabschluss
│
└── 99 System
    ├── Projekte – Datenbank
    ├── Aufgaben – Datenbank
    ├── Meilensteine – Datenbank
    ├── Anforderungen – Datenbank
    ├── Entscheidungen – Datenbank
    ├── Probleme – Datenbank
    ├── Besprechungen – Datenbank
    ├── Tests & Feedback – Datenbank
    ├── Learnings – Datenbank
    └── Nachweise – Datenbank


--- 

Der Bereich `99 System` ist nicht vollständig unsichtbar. Er wird bewusst am Ende der Seitenstruktur platziert und kann zugeklappt werden. Im täglichen Gebrauch wird hauptsächlich mit den Dashboards und Projektseiten gearbeitet.

---

## 7. Zentrales Dashboard

Das Dashboard dient als Startseite des Systems. Es enthält verknüpfte Ansichten der zentralen Datenbanken.

| Dashboard-Bereich | Datenquelle | Filter |
|---|---|---|
| Meine Aufgaben | Aufgaben | Status ist nicht „Erledigt“ |
| Heute | Aufgaben | Fälligkeitsdatum ist heute |
| Überfällig | Aufgaben | Datum liegt vor heute und Status ist nicht „Erledigt“ |
| Aktive Projekte | Projekte | Status ist „Aktiv“ |
| Nächste Meilensteine | Meilensteine | Datum liegt in den nächsten 30 Tagen |
| Offene Probleme | Probleme | Status ist nicht „Gelöst“ |
| Letzte Entscheidungen | Entscheidungen | Sortierung nach Datum, neueste zuerst |

Das Dashboard zeigt dadurch jederzeit den aktuellen Stand aller laufenden Projekte.

---

## 8. Aufbau einer Projektseite

Jeder Eintrag in der Projektdatenbank besitzt eine eigene Projektseite.

Beispiel:

```text
SOULHEALINGDIARIES

Projektübersicht
├── Projektziel
├── Beschreibung
├── Zielgruppe
├── Startdatum
├── Enddatum
├── Status
├── Priorität
└── Fortschritt

Projektplanung
├── Aufgaben
├── Meilensteine
├── Anforderungen
└── Roadmap

Projektdokumentation
├── Entscheidungen
├── Probleme & Lösungen
├── Besprechungen
├── Tests & Feedback
└── Dateien & Nachweise

Projektabschluss
├── Projektergebnis
├── Zielerreichung
├── Screenshots
├── Learnings
├── Retrospektive
└── Portfolio-Zusammenfassung
```

Die eingebetteten Datenbankansichten werden jeweils nach dem aktuellen Projekt gefiltert.

Beispiel:

```text
Projekt = SoulHealingDiaries
```

Dadurch zeigt die Projektseite nur die Informationen, die tatsächlich zu diesem Projekt gehören.

---

## 9. Beziehungen zwischen den Datenbanken

Die Datenbanken werden über Relations miteinander verbunden.

```text
Projekte
├── Aufgaben
├── Meilensteine
├── Anforderungen
├── Entscheidungen
├── Probleme
├── Besprechungen
├── Tests
├── Learnings
└── Nachweise
```

Ein Aufgabeneintrag enthält beispielsweise eine Relation zur Projektdatenbank. Dadurch ist bekannt, zu welchem Projekt die Aufgabe gehört.

Rollups können anschliessend Informationen aus verbundenen Datenbanken zusammenfassen, beispielsweise:

- Anzahl aller Aufgaben
- Anzahl erledigter Aufgaben
- nächster Meilenstein
- Anzahl offener Probleme
- durchschnittlicher Testfortschritt

---

## 10. Auswertungen und Kennzahlen

Das System soll relevante Projektkennzahlen automatisch berechnen.

Geplante Kennzahlen:

- Projektfortschritt in Prozent
- Anzahl offener Aufgaben
- Anzahl erledigter Aufgaben
- Anzahl überfälliger Aufgaben
- verbleibende Projekttage
- nächster Meilenstein
- erreichte Meilensteine
- offene Probleme
- bestandene und nicht bestandene Tests

### Beispiel: Fortschritt in Prozent

Voraussetzungen:

- `Aufgaben gesamt` ist ein Rollup.
- `Erledigte Aufgaben` ist ein Rollup.

```notion
if(
  prop("Aufgaben gesamt") == 0,
  0,
  round(
    prop("Erledigte Aufgaben") /
    prop("Aufgaben gesamt") *
    100
  )
)
```

### Beispiel: Aufgabenstatus prüfen

```notion
if(
  prop("Status") == "Erledigt",
  "Abgeschlossen",
  if(
    prop("Fällig") < now(),
    "Überfällig",
    "Offen"
  )
)
```

### Beispiel: Verbleibende Projekttage

```notion
if(
  empty(prop("Enddatum")),
  0,
  dateBetween(prop("Enddatum"), now(), "days")
)
```

Die Formeln müssen an die verwendeten Eigenschaftsnamen und Datentypen angepasst werden.

---

## 11. Automatisierungen und externe Skripte

Einfache Berechnungen können direkt mit Notion-Formeln, Relations und Rollups umgesetzt werden.

Für komplexere Funktionen können später folgende Werkzeuge eingesetzt werden:

- Notion Automations
- Notion API
- JavaScript
- Python
- Make
- Zapier
- n8n

Mögliche Automatisierungen:

- automatische Erstellung von Standardaufgaben bei einem neuen Projekt
- Erinnerungen vor einem Meilenstein
- automatische Aktualisierung von Statusfeldern
- Auswertung des Projektfortschritts
- Erstellung regelmässiger Projektberichte
- Übertragung von Daten in externe Analysewerkzeuge
- Archivierung abgeschlossener Projekte
- Erkennung überfälliger Aufgaben

Code wird nicht direkt innerhalb einer normalen Notion-Seite ausgeführt. Codeschnipsel können dort dokumentiert werden. Für die tatsächliche Ausführung wird beispielsweise ein externes Skript benötigt, das über die Notion API auf die Datenbanken zugreift.

---

## 12. Dokumentation für Bewerbungen

Das Projektmanagement-System soll später ebenfalls als Nachweis der persönlichen Arbeitsweise dienen.

Für präsentierbare Projekte werden deshalb folgende Informationen dokumentiert:

- Ausgangslage und Problem
- Projektziel
- eigene Rolle
- Anforderungen
- Planung und Vorgehen
- eingesetzte Methoden
- wichtige Entscheidungen
- aufgetretene Probleme
- entwickelte Lösungen
- Tests und Resultate
- Projektergebnis
- persönliche Learnings
- Screenshots und weitere Nachweise

Dadurch kann später gezeigt werden:

> So plane, strukturiere, dokumentiere und verbessere ich ein Projekt.

Vertrauliche Informationen, Zugangsdaten sowie interne Daten von Unternehmen oder Kunden dürfen nicht öffentlich dokumentiert werden.

---

## 13. Geplante Umsetzung

Das System wird schrittweise aufgebaut.

### Phase 1: Grundsystem

- Seitenstruktur erstellen
- Projektdatenbank erstellen
- Aufgabendatenbank erstellen
- Beziehungen zwischen Projekten und Aufgaben einrichten
- zentrales Dashboard erstellen

### Phase 2: Projektplanung

- Meilensteine ergänzen
- Anforderungen dokumentieren
- Entscheidungsdatenbank erstellen
- Roadmap entwickeln

### Phase 3: Dokumentation

- Probleme und Lösungen erfassen
- Besprechungen dokumentieren
- Tests und Feedback ergänzen
- Learnings festhalten
- Nachweise sammeln

### Phase 4: Auswertungen

- Rollups einrichten
- Fortschritt berechnen
- überfällige Aufgaben erkennen
- Projektkennzahlen darstellen
- Dashboard optimieren

### Phase 5: Vorlagen und Automatisierung

- Projektvorlage erstellen
- Aufgabenvorlage erstellen
- Testfallvorlage erstellen
- Projektabschluss-Vorlage erstellen
- sinnvolle Automatisierungen ergänzen

### Phase 6: Portfolio-Ansicht

- präsentierbare Projekte auswählen
- vertrauliche Inhalte ausblenden
- Ergebnisse und Learnings zusammenfassen
- Bewerbungsansicht erstellen

---

## 14. Erwartetes Ergebnis

Am Ende soll ein übersichtliches, erweiterbares und benutzerfreundliches Projektmanagement-System entstehen.

Das System soll:

- verschiedene Projektarten unterstützen
- alle Projektdaten zentral speichern
- eine übersichtliche Arbeitsoberfläche bieten
- den Projektfortschritt automatisch auswerten
- Entscheidungen und Entwicklungen nachvollziehbar machen
- Probleme, Lösungen und Learnings dokumentieren
- als persönlicher Arbeitsnachweis verwendet werden können
- später um weitere Funktionen erweitert werden können
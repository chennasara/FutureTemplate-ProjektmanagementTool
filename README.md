# FutureTemplate-ProjektmanagementTool
This repository documents the development of a structured project management system in Notion. It covers requirements, database architecture, workflows, technical decisions, testing, challenges, and key learnings while demonstrating my structured approach and technical understanding.
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

Ein weiteres Ziel besteht darin, die eigene Arbeitsweise nachvollziehbar zu dokumentieren. Dadurch kann das System später als Nachweis bei Bewerbungen oder für ein persönliches Portfolio verwendet werden.

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
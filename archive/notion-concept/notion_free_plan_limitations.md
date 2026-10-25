# Einschränkungen des kostenlosen Notion-Tarifs

**Prüfstand:** 26. September 2026  
**Status:** In Progress

Das Projektmanagement-Template soll mit dem kostenlosen Notion-Tarif
grundsätzlich nutzbar sein. Deshalb werden die geplanten Funktionen in
drei Kategorien eingeteilt:

1. im kostenlosen Tarif nutzbar
2. im kostenlosen Tarif eingeschränkt nutzbar
3. im kostenlosen Tarif nicht verfügbar

Die Angaben basieren auf der offiziellen Dokumentation von Notion.
Da Notion seine Tarife und Funktionen ändern kann, müssen die
Kernfunktionen vor jeder veröffentlichten Version erneut geprüft werden.

## Im kostenlosen Tarif nutzbar

Die folgenden Funktionen können grundsätzlich ohne ein kostenpflichtiges
Notion-Abonnement umgesetzt werden.

| Funktion | Umsetzung im Template | Zu beachten |
|---|---|---|
| Projektseiten | Projekte können als Seiten oder Datenbankeinträge erfasst werden. | Keine wesentliche Einschränkung bei persönlicher Nutzung |
| Aufgabendatenbank | Aufgaben können zentral gespeichert und bearbeitet werden. | Eigenschaften müssen verständlich benannt werden |
| Kanban-Board | Aufgaben können nach Status gruppiert dargestellt werden. | Umsetzung über eine Board-Ansicht |
| Tabellenansicht | Aufgaben, Projekte und andere Inhalte können tabellarisch dargestellt werden. | Filter und Sortierungen sind möglich |
| Listenansicht | Inhalte können in einer vereinfachten Liste angezeigt werden. | Geeignet für übersichtliche Darstellungen |
| Galerieansicht | Projekte oder Vorlagen können als Karten angezeigt werden. | Vorschaubilder können zusätzlichen Speicher benötigen |
| Kalenderansicht | Termine und Aufgaben können anhand einer Datumseigenschaft angezeigt werden. | Jeder Eintrag benötigt eine gültige Datumseigenschaft |
| Timeline-Ansicht | Projekte, Phasen und Aufgaben können zeitlich dargestellt werden. | Für eine korrekte Darstellung werden Start- und Enddaten benötigt |
| Checklisten | Einmalige Checklisten können auf Seiten oder in Datenbanken erstellt werden. | Erledigte Punkte müssen manuell gepflegt werden |
| Datenbankvorlagen | Wiederkehrende Seitenstrukturen können als Vorlage gespeichert werden. | Änderungen an einer Vorlage verändern bestehende Einträge nicht automatisch |
| Wiederkehrende Datenbankvorlagen | Neue Einträge können regelmässig aus einer Vorlage erstellt werden. | Die Funktion muss im Free-Testkonto überprüft werden |
| Verantwortlichkeiten | Aufgaben können Personen zugewiesen werden. | Zugewiesene Personen benötigen Zugriff auf die entsprechende Seite |
| Filter | Ansichten können beispielsweise nach Person, Status oder Projekt gefiltert werden. | Filter müssen nach dem Duplizieren kontrolliert werden |
| Sortierung | Aufgaben können nach Termin, Priorität oder Taskpoints sortiert werden. | Die Sortierung ersetzt keine automatische Priorisierungsentscheidung |
| Taskpoints | Aufgaben können mit einer numerischen Gewichtung versehen werden. | Die Berechnungsmethode muss im Projekt definiert werden |
| Formeln | Fortschritt, Fristen und andere Werte können berechnet werden. | Komplexe Formeln müssen dokumentiert und getestet werden |
| Relationen | Verschiedene Datenbanken können miteinander verknüpft werden. | Fehlerhafte Beziehungen können mehrere Ansichten beeinflussen |
| Rollups | Verknüpfte Werte können zusammengefasst oder berechnet werden. | Abhängig von korrekt eingerichteten Relationen |
| Statusverwaltung | Aufgaben können beispielsweise als offen, in Bearbeitung oder erledigt markiert werden. | Statuswerte müssen einheitlich verwendet werden |
| Prioritäten | Aufgaben können nach einer definierten Priorität gekennzeichnet werden. | Prioritäten müssen von den Nutzenden gepflegt werden |
| Meilensteine | Wichtige Zwischenziele können als Datenbankeinträge verwaltet werden. | Verknüpfung mit Projekten und Terminen empfohlen |
| Ziele | Projektziele können dokumentiert und mit Aufgaben verknüpft werden. | Zielerreichung muss durch klare Kriterien definiert werden |
| Projektabschluss | Ergebnisse und Learnings können auf einer Abschlussseite dokumentiert werden. | Geeignete Abschlussvorlage erforderlich |
| Formulare | Informationen können über ein mit einer Datenbank verbundenes Formular erfasst werden. | Erstellung und Anpassung erfolgen über Desktop oder Web |
| mobile Nutzung | Seiten und Datenbanken können über die Notion-App verwendet werden. | Komplexe Dashboards können auf kleinen Bildschirmen unübersichtlich sein |
| Seitenfreigabe | Einzelne Seiten können mit anderen Personen geteilt werden. | Zugriffsrechte müssen korrekt eingerichtet werden |
| Export | Seiten und Datenbanken können als PDF, CSV oder HTML exportiert werden. | Ein Export kann nicht immer vollständig als Notion-System wiederhergestellt werden |
| öffentlicher Link | Seiten können über einen öffentlichen Link bereitgestellt werden. | Vertrauliche Inhalte und Freigabeeinstellungen müssen kontrolliert werden |

## Im kostenlosen Tarif eingeschränkt nutzbar

Die folgenden Funktionen sind grundsätzlich vorhanden, unterliegen aber
technischen, mengenmässigen oder organisatorischen Einschränkungen.

| Funktion | Einschränkung | Auswirkung auf das Projekt | Vorgesehener Umgang |
|---|---|---|---|
| Zusammenarbeit mit Gästen | Im Free-Tarif können höchstens zehn Gäste eingeladen werden. | Das Template eignet sich nur für kleine Projektgruppen. | Gruppenmitglieder als Gäste auf benötigte Seiten einladen |
| Zusammenarbeit mit Mitgliedern | Bei mehreren Workspace-Mitgliedern gilt im Free-Tarif ein Blocklimit. | Umfangreiche Team-Workspaces können das Limit erreichen. | Eine Person verwaltet den Workspace; andere arbeiten als Gäste mit |
| Dateiuploads | Hochgeladene Dateien dürfen im Free-Tarif höchstens 5 MB gross sein. | Grosse PDFs, Videos oder Projektdokumente können nicht direkt gespeichert werden. | Externe Links verwenden oder Dateien komprimieren |
| Diagramme | Im Free-Tarif kann nur ein Diagramm kostenlos genutzt werden. | Ein Dashboard mit mehreren nativen Diagrammen ist nicht möglich. | Ein zentrales Diagramm verwenden und weitere Werte als Formeln darstellen |
| Datenbank-Buttons | Buttons sind verfügbar, einzelne Aktionen sind jedoch kostenpflichtig. | Nicht jede geplante Aktion kann über einen Button ausgeführt werden. | Nur im Free-Tarif getestete Button-Aktionen verwenden |
| Benachrichtigungen | Erinnerungen, Erwähnungen und bestimmte Änderungen können Benachrichtigungen auslösen. | Frei definierbare Benachrichtigungsabläufe sind nicht möglich. | Grundlegende Erinnerungen und Erwähnungen verwenden |
| bestehende Datenbankautomatisierungen | Free-Nutzende können vorhandene Automatisierungen in einem Template verwenden, aber nicht bearbeiten. | Käuferinnen und Käufer können die Abläufe nicht an ihre Projekte anpassen. | Automatisierungen nicht als notwendige Kernfunktion verwenden |
| wiederkehrende Aufgaben | Wiederkehrende Einträge können über Datenbankvorlagen erstellt werden. | Daraus folgende Automatisierungen werden nicht automatisch ausgelöst. | Funktion einzeln testen und Einschränkung dokumentieren |
| Versionsverlauf | Frühere Seitenversionen sind nur für sieben Tage verfügbar. | Ältere Änderungen können nicht selbstständig wiederhergestellt werden. | Regelmässige Exporte und zusätzliche Sicherungen empfehlen |
| Papierkorb | Gelöschte Seiten bleiben nur für einen begrenzten Zeitraum wiederherstellbar. | Versehentlich gelöschte Inhalte können später verloren gehen. | Vor endgültigem Löschen eine Archivierung verwenden |
| Notion AI | Es stehen nur begrenzte kostenlose Testantworten zur Verfügung. | AI-Funktionen können nicht dauerhaft als Kernbestandteil angeboten werden. | Notion AI nicht für den Grundbetrieb voraussetzen |
| grosse Projektgruppen | Gästezahl, Zugriffsrechte und Blocklimits erschweren grössere Gruppen. | Das Produkt ist nicht für grosse Klassen oder Organisationen ausgelegt. | Zielgruppe auf Einzelpersonen und kleine Gruppen beschränken |
| Smartphone-Darstellung | Grundfunktionen sind verfügbar, komplexe Ansichten benötigen jedoch mehr Navigation. | Die mobile Bedienung kann weniger übersichtlich sein. | Mobile Ansichten separat gestalten und testen |
| Berechtigungen | Berechtigungen werden durch Notion und die Workspace-Struktur bestimmt. | Eine vollständig individuelle Rollenverwaltung ist nicht möglich. | Einfache Rollen und klare Freigabeanweisungen verwenden |
| Education-Plan | Berechtigte Studierende und Lehrpersonen können zusätzliche Funktionen kostenlos erhalten. | Nicht alle Zielpersonen besitzen eine berechtigte Bildungs-E-Mail-Adresse. | Das Template darf den Education-Plan nicht voraussetzen |

## Im kostenlosen Tarif nicht verfügbar

Die folgenden Funktionen können im Free-Tarif nicht eigenständig
erstellt oder ohne kostenpflichtige Funktionen vollständig umgesetzt
werden.

| Funktion | Grund | Konsequenz für das Projekt |
|---|---|---|
| frei konfigurierbare Datenbankautomatisierungen | Eigene Datenbankautomatisierungen sind grundsätzlich kostenpflichtigen Tarifen vorbehalten. | Sie dürfen nicht als notwendige Kernfunktion eingeplant werden. |
| automatische Archivierung nach sieben Tagen | Dafür wäre eine zeitgesteuerte Datenbankautomatisierung erforderlich. | Für die kostenlose Version wird eine manuelle oder buttonbasierte Lösung benötigt. |
| unbegrenzt viele native Diagramme | Im Free-Tarif steht nur ein Diagramm zur kostenlosen Nutzung zur Verfügung. | Das Dashboard darf nicht von mehreren nativen Diagrammen abhängig sein. |
| unbegrenzt grosse Dateiuploads | Der Free-Tarif begrenzt einzelne Uploads auf 5 MB. | Grosse Dateien müssen extern gespeichert oder komprimiert werden. |
| langfristiger Versionsverlauf | Der Free-Tarif bietet nur sieben Tage Seitenverlauf. | Eine langfristige Wiederherstellung über den Seitenverlauf ist nicht möglich. |
| vollständig anpassbare Automatisierungen durch Free-Nutzende | Bestehende Automatisierungen können verwendet, aber nicht bearbeitet werden. | Individuelle Automatisierungsregeln sind in der kostenlosen Version nicht möglich. |
| automatische Aktualisierung bereits duplizierter Templates | Änderungen an der ursprünglichen Vorlage werden nicht automatisch vollständig auf bestehende Kopien übertragen. | Aktualisierungen benötigen eine separate Update-Strategie. |
| eigene Benutzerverwaltung | Notion verwaltet Konten, Gäste, Mitglieder und Berechtigungen. | Das Template kann keine unabhängigen Benutzerkonten erstellen. |
| frei programmierbares Benachrichtigungssystem | Notion erlaubt im Free-Tarif keine vollständig individuell programmierten Benachrichtigungsabläufe. | Benachrichtigungen bleiben auf die verfügbaren Notion-Funktionen beschränkt. |
| garantierte Nutzung durch ganze Schulen | Der Free-Tarif ist nicht für grosse Organisationen mit umfassender Mitgliederverwaltung vorgesehen. | Eine Schulversion müsste separat konzipiert und tariflich geprüft werden. |

## Konsequenzen für die erste Version

Die erste Version des Templates soll vollständig ohne kostenpflichtige
Notion-Funktionen nutzbar sein.

Zum geplanten Kernumfang gehören deshalb:

- Projektübersicht
- Aufgabendatenbank
- Kanban-Board
- Kalender
- Timeline
- Checklisten
- Verantwortlichkeiten
- Status und Prioritäten
- Taskpoints
- Formeln
- Relationen und Rollups
- Meilensteine
- Ziele
- Projektabschluss
- Learnings
- ein zentrales Diagramm
- kurze Bedienungsanleitung

Folgende Funktionen werden für die erste Version zurückgestellt oder
durch einfachere Lösungen ersetzt:

- mehrere native Diagramme
- automatische Archivierung nach sieben Tagen
- komplexe Datenbankautomatisierungen
- frei konfigurierbare Benachrichtigungen
- umfangreiche Dateiablagen
- Zusammenarbeit in grossen Gruppen
- automatische Aktualisierung bereits duplizierter Templates

## Testanforderung

Alle Kernfunktionen müssen vor der Veröffentlichung in einem separaten
Workspace mit dem kostenlosen Notion-Tarif getestet werden.

Ein Test im Entwicklungs-Workspace allein reicht nicht aus, wenn dieser
einen Education-, Plus-, Business- oder Enterprise-Tarif verwendet.

Bei der Prüfung müssen mindestens folgende Punkte kontrolliert werden:

- Duplizierung des vollständigen Templates
- Erhalt aller Datenbanken und Beziehungen
- Funktionsfähigkeit der Formeln und Rollups
- Darstellung auf Desktop und Smartphone
- Einladung und Zugriff von Gästen
- Verhalten der Datenbankvorlagen
- Verfügbarkeit der verwendeten Buttons
- Verfügbarkeit des Diagramms
- Dateiupload unter Berücksichtigung der Grössenbegrenzung
- Export der wichtigsten Daten
- verständliche Hinweise bei kostenpflichtigen Zusatzfunktionen

## Quellen

- [Notion Pricing](https://www.notion.com/pricing)
- [Notion-Datenbanken](https://www.notion.com/help/create-a-database)
- [Datenbankansichten](https://www.notion.com/help/views-filters-and-sorts)
- [Kalenderansichten](https://www.notion.com/help/calendars)
- [Formeln](https://www.notion.com/help/formulas)
- [Relationen und Rollups](https://www.notion.com/help/relations-and-rollups)
- [Datenbankautomatisierungen](https://www.notion.com/help/database-automations)
- [Datenbank-Buttons](https://www.notion.com/help/database-buttons)
- [Diagramme](https://www.notion.com/help/charts)
- [Mitglieder und Gäste](https://www.notion.com/help/add-members-admins-guests-and-groups)
- [Dateien und Medien](https://www.notion.com/help/images-files-and-media)
- [Export von Notion-Inhalten](https://www.notion.com/help/export-your-content)
- [Notion für Bildung](https://www.notion.com/help/notion-for-education)
# BillShare
Domainname: BillShare
## Projektstruktur erstellen
### Schritt 1
Projektname überlegen und mit diesem Namen eine 'Solution' erstellen.
### Schritt 2
Eine Klassenbibliothek 'CommonBase' erstellen. In dieser Bibliothek werden alle Algorithmen, welche unabhängig vom Domain-Bereich sind, gesammelt.
### Schritt 3
Eine Klassenbibliothek für die Schnittstellen anlegen. Der Projektname wird wie folgt definiert: [Domainname].Contracts.
### Schritt 4
Eine Klassenbibliothek für die Geschäftslogic. In diesem Projekt werden alle GEschäftsprozesse gesammelt. Projektname wird wie folgt definiert: [Domainname].Logic
### Schritt 5
Erstellen einer Konsolenanwendung zum Testen der Struktur. Projekt wird wie folt definiert: [Domainname].ConApp
**Hinnweis**
### Schritt 6
Abhängigkeiten definieren.
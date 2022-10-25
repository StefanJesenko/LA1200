# Deer-club
## Projekt-Dokumentation

Parrot(Deer club): Pascal Oestrich, Keanu Koelewijn, Stefan Jesenko, Dorian Herzig, Lorenzo Lai

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|    25.10.22   | 1.1.0   | IPE = Informieren/ Planen/ Entscheiden |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Workshop

In unserem Projekt erstellen wir ein Programm, indem eine gerechte Workshop einteilung gelingen wird.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |      Muss           |   Funktional   | Als Nutzer erwarte ich, dass ich meine Workshops selber eintagen kann. |
| 2  |      Muss           |   Funktional   | Ich als Nutzer erwarte, dass ich die Namen der Teilnehmer selber eintragen kann. |
| 3  |       Muss          |    Funktional  |  Ich als Nutzer erwarte, dass ich die Priorität selber bestimmen kann, damit man die Teilnehmer nach den Prioritäten und anzahl Plätzen einteilenn kann. |
| 4  |        Muss         |   Funktional   | Ich als Nutzer erwarte, dass am Ende des Programms, die gegebenen Daten korrekt und gerecht eingeteilt wird. |
| 5  |    Muss             |  Funktional    | Ich als Nutzer erwarte, dass die Mindestangabe der Teilnehmer die Anzahl Workshops * 4 ist um die Mindestgrösse einzuhalten. |
| 6  |        Muss         |    Funktional  |  Ich als Nutzer erwarte, dass der Programm mit Fehler Eingaben umgehen kann. |
| 7  |          Muss       |  Funktional    |  Ich als Nutzer erwarte, dass ich abgefragt werde, nach jeden neuen Teilnehmer, ob ich einen weiteren Teilnehmer hinzufügen möchte, nachdem die Mindestanzahl erreicht wurde. |
| 8  |   Muss              |  Funktional    |  Ich als Nutzer erwarte, dass die Teilnehmer korret gleichmässig verteilt werden in die Workshops und das Resultat ausgegeben wird. |
| 9  |         Muss        |   Qualität   |  Ich als Nutzer erwarte, dass das Program übersichtliche Ausgaben hat. |
| 10  |         Kann        | Qualität      |  Ich als Nutzer erwarte, dass das Program ein einfaches und gutes Design hat. |
| 11  |    Kann             |    Rand  |  Das Programm wird mit Listen und Funktionen geschrieben. |
| ...  |                 |      |  |

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Programm wurde gestartet|         | Bitte drücken sie Enter Nach jeder eingabe eines Workshops, wenn sie keine mehr hinzufügen wollen geben sie bitte n ein. |
| 1.2  | Programm wurde gestartet|         | Bitte geben sie Workshop 1 ein:  |
| 1.3| Testfall 1.1             | Malen        |  Workshop Malen wurde hinzugefügt                 |
| 1.5 | Testfall 1.3             |  Enter       |Bitte geben sie Workshop 2 ein:                   |
| 2.1| Testfall 1.3             |   n      |Vorname und Nachname des Teilnehmers eingeben:       |
| 3.1 |Testfall 2.1  |  Pascal Oestrich| Bitte wählen sie einen Workshop für Priorität (1-3)|
| 6.1  | Testfall 1.3              | Buchstabensuppe        | Ungültige eingabe bitte versuchen sie es erneut|
| 7.1| genügend Teilnehmer eingegeben (mehr als 4 * Anzahl Workshops)|         |Möchten sie einen weiteren Teilnehmer hinzufügen? [y/n] |
| 8.1  | Testfall 7.1             | n        | (Eingeteilte Teilnehmer nach Workshop)                   |

### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |   25.10.2022    |     Lorenzo      |       Informieren / Userstory       |      1        |
| 1.B |    25.10.2022   |      Kenau     |        Informieren / Testfälle      |       0.5        |
| 1.C |    25.10.2022   |      Stefan     |        Informieren / PAP     |       0.75        |
| 1.D |    25.10.2022   |      Dorian     |        Überprüfen PAP    |       0.5        |
| 2.A |    25.10.2022   |      Pascal / Dorian     |        Planung     |       0.45        |
| 3.A |    25.10.2022   |      Alle    |        Entscheiden / Auswerten      |       1.5        |
| 3.B |    01.11.2022   |      Pascal   |        Teamplanung    |       1        |
| 4.A |    01.11.2022   |      Pascal / Stefan / Dorian   |        Coding    |       5        |
| 4.B |    01.11.2022   |      Dorian / Keanu / Lorzeno   |        List Informieren   |       1        |
| 4.C |    07.11.2022   |      Pascal   |        Teamplanung    |       1        |
| 4.B |    08.11.2022   |      Keanu / Lorenzo    |        Code überprüfen   |       2        |
| 5.A |    08.11.2022   |      Dorian    |        Testprotokoll   |       1        |
| 5.B |    08.11.2022   |      Dorian    |        Testen   |       1        |
| 6.A |    15.11.2022   |      Alle    |        Lernbericht / Dokumentation   |       5        |

Total Arbeitspakete: 21,7

45min = 1 Arbeitspaket



✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.

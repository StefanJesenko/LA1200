# Lern-Bericht
Parrot (Keanu Koelewijn, Lorenzo Lai, Pascal Oestrich, Stefan Jesenko)

## Einleitung

Wir haben im Lernatelier den Auftrag bekommen, ein Programm zu schreiben, mit dem wir Teilnehmer in Workshops einteilen können.

## Was haben wir gelernt?

Wir haben gelernt, wie man Listen in C# richtig verwenden können.

## Beschreibung

`Listen` sind Datentypen, die mehrere `Objekte` an einem Ort speichern können.
Eine `Liste` kann man gleich verwenden wie ein `Array`. Der Unterschied ist, dass man die Grösse einer `Liste` vorher nicht deklarieren muss.
`Listen` brauchen mehr Rechenleistung als `Arrays`, das ist aber bei kleinen Programmen nicht relevant.

```c#
allocation = new List<string>();
                foreach (string s in allocation)
                {
                    finalAllocation.Add(s);
                }
```
Die Liste hat wie ein Array einen Index, der bei 0 beginnt.
Durch die Methode `.Add` kann man `Objekte` zu einer Liste hinzufügen.


![image](https://user-images.githubusercontent.com/110892250/201868235-aef69660-1b64-4ef3-9bc7-fb9ff98fc0a9.png)


In diesem Bild sieht man, wie der User zuerst zwei Workshops eingibt und diese dann ausgegeben werden. Dabei ist der Workshop, der zuerst hinzugefügt wurde, ganz oben.

## Verifikation
**Text:** Er beschreibt die Funktionalität von `Listen`, der Unterschied zu den `Arrays` und warum man sie für kleinere Projekte benutzen sollte.

**Code ausschnitt** man kann die Funktionalität von `.Add` sehen.

**Abbildung 1:** Die Konsole zeigt, welche Eingabe (Workshop) zuerst gezeigt wird.

# Reflektion zum Arbeitsprozess

Was gut gelaufen ist:
- Wir hatten keine grossen Probleme, die Aufgaben aufzuteilen und konnten gut in der Gruppe zusammenarbeiten.


Was nicht gut gelaufen ist:
- Während dem Programmieren gab es dann Probleme bei der Kommunikation und wir konnten nicht sehr effizient programmieren.
- 

**VBV**:
Nächstes Mal werden wir uns beim Programmieren besser koordinieren und am Anfang genauer einteilen, wer was macht. Damit wir so effizient wie möglich programmieren können.

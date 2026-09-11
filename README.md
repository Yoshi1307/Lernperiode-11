# Lernperiode 11


## Fertiges Projekt
In dieser Lernperiode habe ich einen VokabelTrainer erstellt.Der VociTrainer ist eine einfache Desktop-Applikation, mit der Vokabeln zwischen Deutsch, Englisch und Französisch geübt werden können. Auf einer Startseite erhält man einen Überblick über die Applikation, während im Bereich "Wortliste" alle hinterlegten deutsch-englischen und deutsch-französischen Wortpaare angezeigt werden.

Im Bereich "Abfrage" kann zwischen Englisch und Französisch gewählt werden. Die Applikation zeigt dann ein deutsches Wort an, das in der gewählten Sprache übersetzt werden muss. 
Damit jedes Wort zuerst einmal abgefragt wird, bevor sich eines wiederholt, werden die Wörter pro Durchgang zufällig gemischt und erst nach einer vollständigen Runde neu gemischt. Falsch beantwortete Wörter werden zusätzlich gesammelt und in einer eigenen Fehler-Runde am Ende erneut abgefragt, bis sie richtig beantwortet wurden. Zusätzlich zeigt die Applikation einen laufenden Score für die richtig beantworteten englischen und französischen Wörter an.


<img width="480" height="784" alt="VociTrainer" src="https://github.com/user-attachments/assets/253ecdbd-68c2-4aa5-ba25-55782cf189fd" />


14.8 bis 11.9.2024

## Grob-Planung

1. Erklären Sie Ihre Projekt-Idee in einem Satz, als müssen Sie einen Investor davon überzeugen.
   Ich möchte einen Vokabeltrainer fürs Handy erstellen
3. Erklären Sie, welche technischen Herausforderungen Sie in Ihrem Projekt erwarten.
   Ich werde eine neue Technologie (Avalonia) erlernen für eine Mobileapplikattion.
4. Beschreiben Sie, welche nicht-technischen Aspekte Sie in diesem Projekt besonders üben möchten.
   UserStorys schreiben
5. Wie unterscheidet sich dieses Projekt von Ihrem Projekt in 335; und wo ergänzen sich diese Projekte?

## 14.8

- [X] Avalonia herunterladen
- [ ] Tutorial auf der Avalonia-Webseite durcharbeiten: https://docs.avaloniaui.net/docs/get-started/starter-tutorial
- [ ] Testprojekt zum Selber ausprobieren erstellen

Heute habe ich damit begonnen, mir ein Projekt zu überlegen, wobei ich mich auf einen Vokabeltrainer festgelegt habe. Danach habe ich anhand des Tutorials auf der Avalonia Seite Avalonia heruntergeladen. Ich hatte ein paar technische Probleme, weswegen es etwas länger gedauert hat. Danach habe ich das Tutorialprojekt auf der Seite gestartet und bin noch mittendrin.

## 21.8

- [X] Tutorial nächste 2 Kapitel abschliessen
- [X] Tutorial beenden
- [X] Testprojekt zum Selber ausprobieren erstellen

Heute habe ich als Erstes das Tutorial beendet. Dies kann man momentan nicht einsehen, weil ich die Dateien ersetzt habe. Dafür habe ich einen kleinen Vermögensrechner erstellt, wo man die Ein- und Ausgaben eingeben kann und sieht, wie viel Geld man noch übrig hat.

## 28.8

- [X] Als User möchte ich eine übersichtliche Startseite haben, damit ich mich einfach in der Anwendung zurechtfinde.
- [X] Als User möchte ich eine Liste mit den Wörtern sehen, damit ich die verfügbaren Wörter kennenlernen kann.
- [X] Als User möchte ich ein Wort abgefragt werden können, damit ich es übersetzen kann.

Heute habe ich zuerst ein kleines Startmenü gemacht, damit ich auswählen kann, was ich machen will. Im Menü kann man die ganze Zeit, ohne weitere Knöpfe zu drücken, zwischen den Seiten wechseln. Danach habe ich eine Wortliste mit 5 einfachen Englischwörtern hinzugefügt, für die ich am Ende eine Abfrage gestaltet habe. Dazwischen habe ich eine Anzeige der Wörter mit Übersetzung gemacht, dass man sich die Wörter zuerst anschauen kann. 

## 4.9
- [x] Als User möchte ich eine grössere Anzahl Wörter zum Abfragen haben, damit ich nicht nur die gleichen 5 Wörter üben muss.
- [x] Als User möchte ich eine andere Sprache zur Auswahl haben, damit ich nicht nur Englisch lernen muss.
- [x] Als User möchte ich beide Sprachen in der Wörterliste anzeigen lassen können.
- [ ] Als User möchte ich, dass jedes Wort zuerst einmal drankommt, bevor eines sich wiederholt, damit ich jedes Wort lernen kann, bevor es sich wiederholt

Heute habe ich zuerst neue Wörter hinzugefügt, die man lernen kann. Danach habe ich eine neue Liste hinzugefügt, mit Wörtern einer neuen Sprache (Französisch). Die neuen Wörter werden nun auch in der Wörterliste angezeigt. Im Abfrage-Tab hat man jetzt die Möglichkeit, zwischen den beiden Sprachen Englisch und Französisch auszuwählen. Wenn man auf Französisch stellt, werden die Wörter einfach noch nicht richtig korrigiert. Da es noch eine recht neue Technologie für mich ist, musste ich viel meiner Zeit verwenden, um zu recherchieren, wie man einzelne Dinge macht. Vor allem bei der Wörterliste musste ich lange suchen.

## 11.9
- [X] Als User möchte ich, dass die Französischen Wörter richtig korrigiert werden.
- [X] Als User möchte ich, dass jedes Wort zuerst einmal drankommt, bevor eines sich wiederholt, damit ich jedes Wort lernen kann, bevor es sich wiederholt.
- [X] Als User möchte ich, dass gezählt wird, wie viele Wörter ich richtig übersetzt habe.

Beim Lösen des ersten Arbeitspaketes musste ich die Funktion zum Überprüfen der Antwort anpassen und ein paar Variablen und Funktionen ergänzen. Jetzt korrigiert die App Englisch und Französisch. Danach habe ich hinzugefügt, dass Wörter sich nicht wiederholen bevor alle einmal dran waren. Anschliessen habe ich noch eine kleine Punkteanzeige hinzugefügt, die mitzählt, wie viel Wörter man richtig übersetzt hat. Die Punkte werden Pro Sprache angezeigt. Zum Schluss habe ich noch eine Fehlerrunde hinzugefügt. Also wenn alle Wörter einmal durch sind werden zuerst nochmal alle falschen abgefragt.

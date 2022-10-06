# Joker 🃏

In Österreich gibt es das Glücksspiel _Joker_. SpielerInnen können eine sechsstellige Zahl tippen, die aus sechs Ziffern jeweils zwischen 0 und 9 (beides inklusive) bestehen. Bei der Ziehung wird eine zufällige, ebenfalls sechsstellige Zahl gezogen. Je mehr Stellen man erraten hat, desto mehr Geld gewinnt man. In diesem Beispiel sollen Sie eine **vereinfachte Version** des Joker-Spiels programmieren (**vier- statt sechsstelliger Zahl**).

Die Aufgabe ist in mehrere Levels gegliedert. Level 0 ist die Mindestanforderung, die Sie für eine positive Note lösen müssten. Wenn Sie ein höheres Level schaffen, sammeln Sie bei dieser Test-Simulation bis zu zwei Bonuspunkte.

## Level 0

Schreiben Sie ein Programm mit folgender Funktion:

1. Löschen (_clear_) Sie am Beginn des Programms den Bildschirm.
2. Geben Sie auf der Konsole eine Aufforderung aus, dass die Benutzerin den Joker-Tipp (vierstellige Zahl) eingeben soll.
   1. Beispiel: _Please enter your tip (0000-9999):_
3. Lassen Sie den Joker-Tipp über die Konsole eingeben.
4. Ermitteln Sie mit dem Zufallsgenerator von .NET eine zufällige Joker-Zahl zwischen 0 und 9999 (beides inklusive).
5. Prüfen Sie, ob die Benutzerin die zufällig generierte Joker-Zahl mit der eingegebenen Zahl übereinstimmt.
   * Falls ja, geben Sie eine entsprechende Gratulationsnachricht aus (inkl. passendem Emoji-Sonderzeichen).
   * Falls nein, geben Sie eine entsprechende "leider nicht gewonnen"-Nachricht aus.
6. Geben Sie aus, was die richtige Zahl gewesen wäre.
   * Beispiel: _The correct number would have been 1234._
7. Pausieren Sie das Programm bis zum nächsten Tastendruck.
8. Löschen (_clear_) Sie vor Beendigung des Programms den Bildschirm.

## Level 1

Schreiben Sie ein Programm mit folgender Funktion:

1. Schritte 1 bis 4 sind ident mit Level 0.
2. Ermitteln Sie, wie viele Stellen **von links nach rechts** gelesen zwischen der zufällig generierten Joker-Zahl mit der eingegebenen Zahl übereinstimmen.
   1. Beispiel 1: Eingabe 1234, zufällige Joker-Zahl 1289 -> 2 Stellen stimmen überein
   2. Beispiel 2: Eingabe 3445, zufällige Joker-Zahl 4353 -> 0 Stellen stimmen überein
   3. Beispiel 3: Eingabe 1234, zufällige Joker-Zahl 1234 -> 4 Stellen stimmen überein
   4. Beispiel 4: Eingabe 0123 oder 123 (ohne führende Null), zufällige Joker-Zahl 156 (bzw. 0156) -> 2 Stellen stimmen überein
3. Falls 4 Stellen übereinstimmen, geben Sie eine entsprechende Gratulationsnachricht aus (inkl. passendem Emoji-Sonderzeichen).
4. Falls weniger als 4 Stellen übereinstimmen, geben Sie aus, wie viele Stellen die Benutzerin erraten hat.
5. Schritte 6 bis 8 sind ident mit Level 0.

Wer Level 1 schafft, bekommt einen Bonuspunkt.

## Level 2

Level 2 funktioniert wie Level 1, jedoch sind die übereinstimmenden Stellen **von rechts nach links** zu ermitteln.

* Beispiel 1: Eingabe 1234, zufällige Joker-Zahl 8974 -> 1 Stelle stimmt überein
* Beispiel 2: Eingabe 1234, zufällige Joker-Zahl 8934 -> 2 Stellen stimmen überein
* Beispiel 3: Eingabe 3445, zufällige Joker-Zahl 4353 -> 0 Stellen stimmen überein
* Beispiel 4: Eingabe 1234, zufällige Joker-Zahl 1234 -> 4 Stellen stimmen überein
* Beispiel 5: Eingabe 0123 oder 123 (ohne führende Null), zufällige Joker-Zahl 923 (bzw. 0923) -> 2 Stellen stimmen überein

Wer Level 2 schafft, bekommt zwei Bonuspunkte.

## Level 3

Dieses Level ist für jene, die Level 2 leicht schaffen und danach immer noch Zeit haben.

Level 3 funktioniert wie Level 2. Sie müssen jedoch nach der Eingabe des Joker-Tipps prüfen, ob es sich um eine Zahl zwischen 0 und 9999 handelt. Falls nicht, geben Sie eine entsprechende Meldung am Bildschirm aus. Die Ermittlung der Zufallszahl und die Prüfungen auf gleiche Stellen werden in diesem Fall nicht durchgeführt.

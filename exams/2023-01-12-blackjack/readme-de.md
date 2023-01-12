# Blackjack

## Einführung

[Blackjack](https://en.wikipedia.org/wiki/Blackjack) ist ein beliebtes Casino-Kartenspiel. In Europa wird das Spiel oft als [*17 und 4*](https://de.wikipedia.org/wiki/Siebzehn_und_Vier) bezeichnet.

Das Spiel wird mit den [üblichen 52 Karten](https://en.wikipedia.org/wiki/Playing_card) gespielt: Vier Farben (Pik, Herz, Karo und Kreuz), jeweils bestehend aus 13 Karten (Ass, 2, 3, 4, 5, 6, 7, 8, 9, 10, Bube, Dame und König):

![Playing Cards](cards.png)

Beim Blackjack hat jede Karte einen Wert:

* Der Wert der Karten zwischen 2 und 10 ist deren aufgedruckter Wert, also hat z.B. die Karte 2 hat den Wert 2.
* Bube, Dame und König haben alle einen Wert von 10.
* Ass hat einen Wert von 11. Es gibt jedoch einige Sonderregeln für Asse, zu denen wir später kommen.

Ihr Ziel beim Blackjack ist es, Karten zu ziehen, bis Sie einen Gesamtwert von 21 erreichen, aber **nicht** mehr als 21. Wenn der Gesamtwert Ihrer Karten höher als 21 ist, verlieren Sie. Das beste Kartenblatt beim Blackjack ist, wenn Sie mit zwei Karten (d. h. einer Kombination aus einer Karte mit dem Wert 10 plus einem Ass) genau 21 erhalten. Eine solche Hand wird *Blackjack* genannt.

In dieser Übung entwickeln wir eine Version eines Blackjack-Turniers mit vereinfachten Spielregeln. Ein/e SpielerIn spielt gegen den Computer, der die Rolle der Bank übernimmt. Der/die Spieler/In startet mit 100€. Wenn es der/dem SpielerIn gelingt, ihr Geld mindestens zu verdoppeln, gewinnt er/sie das Turnier. Wenn der/die SpielerIn das ganze Geld verliert, verliert er/sie das Turnier.

**Wichtiger Hinweis zu zufälligen Karten:** Das Mischen von Karten zu simulieren und zufällige Karten wie aus einem echten Kartenspiel zu verteilen, ist für diesen Kurs zu kompliziert. Daher können Sie in unserem Spiel *die Berechnung von Zufallskarten vereinfachen*. Holen Sie sich einfach einen zufälligen Wert zwischen z.B. 1 und 13 und weisen Sie jedem dieser Werte eine Karte zu (z. B. 1 ist Ass, 2 ist Zwei, 3 ist Drei, ..., 11 ist Bube, 12 ist Dame, 13 ist König). Sie können Farben (Pik, Herz, Karo und Kreuz) ignorieren.

## Methoden

In Ihrer Lösung **müssen** Sie Methoden verwenden, um Ihren Code zu strukturieren. Hier sind ein paar Vorschläge:

* `InitializeGame`: Wird in jeder Runde vor dem Zug des/der/die SpielerInIn und des Computers aufgerufen. Variablen (z. B. Gesamtkartenwert) werden in dieser Methode initialisiert.
* `HandoutRandomCard`: Verteilt eine zufällige Karte und berechnet ihren Wert.
* `PrintCard`: Drucken Sie die ausgegebene Karte und den gesamten Kartenwert auf dem Bildschirm aus.
* `AskForBet`: Fragt den/die BenutzerIn, wie viel Geld er/sie setzen möchte.

Diese Methoden sind nur Vorschläge. Wenn Sie möchten, können Sie weitere Methoden hinzufügen.

## Spielregeln – Mindestanforderungen

1. Zu Beginn des Turniers hat der/die SpielerIn 100€.
2. Das Spiel wird in Runden gespielt. Zu Beginn jeder Runde ist **der/die SpielerIn an der Reihe**.
    1. Der/die SpielerIn bekommt seine/ihre erste zufällige Karte. Der Computer druckt die Karte zusammen mit ihrem Wert auf dem Bildschirm aus.
    2. Nach der ersten Karte *muss* der/die SpielerIn einen Einsatz machen. Der Mindesteinsatz beträgt 10€, der Höchsteinsatz ist der Geldbetrag, den der/die SpielerIn übrig hat.
    3. Nachdem der Einsatz platziert wurde, erhält der/die SpielerIn eine zweite Karte und Ihr Programm gibt den *Gesamtwert* der Hand auf dem Bildschirm aus.
    4. Der/die SpielerIn kann nun entscheiden, ob er/sie eine zusätzliche Karte möchte. Wenn das der Fall ist, werden die neue Karte und der Gesamtwert der Hand auf dem Bildschirm gedruckt.
    5. Das Verteilen neuer Karten (Schritt 2.4) endet, wenn der/die SpielerIn entscheidet, dass er/sie keine zusätzlichen Karten möchte oder wenn der Gesamtwert der Karten größer als 21 ist. Im letzteren Fall hat der/die SpielerIn die Runde verloren und hat daher den Einsatz verloren.
3. Sobald der/die SpielerIn entschieden hat, keine Karten mehr zu nehmen, ist **der Computer an der Reihe**.
    1. Der Computer nimmt zufällige Karten, bis sein Gesamtkartenwert größer als 16 ist.
    2. Wenn der Gesamtkartenwert des Computers größer als 21 ist, hat der/die SpielerIn die Runde gewonnen und bekommt das Doppelte seines/ihres Einsatzes zurück. Wenn er/sie z.B. vor der Runde 50€ übrig hatte, 10€ gesetzt hat und gewinnt, hat er/sie am Ende der Runde 60€.
    3. Andernfalls gewinnt der Computer die Runde, wenn der Gesamtkartenwert größer ist als der Gesamtkartenwert des/der/die SpielerInIn. In diesem Fall hat der/die SpielerIn seinen/ihren Einsatz verloren. Wenn der Gesamtkartenwert des/der/die SpielerInIn höher ist, hat der/die SpielerIn die Runde gewonnen und erhält das Doppelte seines/ihres Einsatzes zurück.
    4. Wenn Computer und SpielerIn den gleichen Gesamtkartenwert haben, kommt es zu einem *Standoff* und der Einsatz wird zurückerstattet.
4. Am Ende jeder Runde **überprüft das System, ob das Turnier zu Ende ist**.
    1. Wenn der/die SpielerIn nicht genug Geld für den Mindesteinsatz übrig hat, hat er/sie das Turnier verloren und das Programm wird beendet.
    2. Wenn der/die SpielerIn das Startgeld mindestens verdoppelt hat, hat er/sie das Turnier gewonnen und das Programm endet.
    3. Wenn beides nicht der Fall ist, beginnt die nächste Runde (zurück zu Schritt 2).

Um Ihnen das Verständnis der Programmlogik zu erleichtern, finden Sie hier Flussdiagramme für den Zug des Spielers und den Zug des Computers:

* [SpielerIn ist am Zug](https://mermaid.live/edit#pako:eNptUl2P2jAQ_CurfSknhY8ESEh0orr2rupDW1Xlno7wYLBzRA02stft0Yj_XsfJcUCbl3jWM6PZ9da4UVxghs-a7bfweJ9LcN-CmKbvFTsI3eu1_3cGyGp5c_MPA_r9OXwqtaGPTPPlZyY5KEtQNCXYuNqq1Zw4XvFB0HJ4Z35CoTSsBYGVVFa3az2cN6g0IBUBKQWV-g2N6Svels_bYefpXLzbQmyU5JcBjK-dJ3hjedFXpUUDTH3nvLeulYb7_tiST7eOCwdhvOSbeLlqk51JV_9RSuWFD5K342oprz7tKKwhwetHRazyPrfDtZ7_YpUVMIco7AK1tPM0P5SV_IsytOyeonLnALr5NWB1Le3inCK29yejy6y93kPTZeFfZX-9BxjgTugdK7lboLoxytGNYidyzNyRi4LZinLM5dFRmSW1OMgNZqStCNDuOSNxXzK3ejvMClYZV90z-aTUBcasxhfMxuPBaBZNw8k4iqNREqZxgAfM-lGcDOLZbBJPwjSdRcn4GOAfbxEOkiScxmEUT9I0TOLR9PgX7nrwCw)
* [Computer ist am Zug](https://mermaid.live/edit#pako:eNp1k1FvmzAQx7_KyS9NJZIGkpiAqkzaOqkPe5jUapMW-uAEk6Aamxm7Wxbx3WvMDDS0PJ2P8-9__p99RnuRUhSjgyTlER7vEg7me1BEqi-iKLWicjJx0VUFj1ry6-t3qmA63YBbbLusIs-0gj2R6e1O3mw0VzkDJRRh8EKYprABHz-1vBHqs67UeSBu91lOA-wAgf-p7gnNJkOAk9F1oO-MnKj8mfNq24bwR3CQQvPUszw4UFXBjuyfIRV6xygcTdGOqqcxmIuOe58fTN0PwoZdNr1VV647iy-t6MW_Qc8dZ8A37vJUZNkYbZEtnv7WpPHzPZW-rO7mZYkXh-jNGZc5E-_JC3X5rQs8aBWteVbNGvjWueFOi_rKU3eiDwwYT-6bqJSbHDPxcHRGCvLKpgfD6vd9LNof_LJmMjELEFl71wYX8P_tRx4qqCxInpqnc26ICVJHWtAExSZMaUY0UwlKeG1KiVbi4cT3KFZSUw_pMiWK3uXEPLoCxRlhlcmWhP8S4s0axWf0F8WLxWy-Dlb-chHgYB76EfbQCcXTAIczvF4v8dKPonUQLmoP_bMIfxaG_gr7AV5GkR_i-ap-BYIUS0U)

## Erweiterte Spielregeln - Gewinnen mit Blackjack

Wie bereits erwähnt, ist ein *Blackjack* (d.h. 21 mit zwei Karten) die bestmögliche Hand. Ändern Sie die Logik Ihres Programms wie folgt:

* Wenn der/die SpielerIn einen Blackjack bekommt, gewinnt er/sie sofort die Runde. Der Computer spielt in dieser Runde nicht, da der Blackjack des/der SpielerIn nicht geschlagen werden kann.
* Im Falle eines Gewinns mit einem Blackjack erhält der/die SpielerIn seinen/ihren Einsatz plus Einsatz \* 1,5 zurück. Wenn er/sie z.B. vor der Runde 50€ übrig hatte, 10€ gesetzt hat und mit einem Blackjack gewinnt, hat er/sie am Ende der Runde 65€.
* Wenn der/die SpielerIn keinen Blackjack hat, der Computer aber einen, gewinnt der Computer die Runde. Auch wenn der/die SpielerIn ebenfalls einen Gesamtwert von 21 hat (z.B. mit den Karten Sechs, Fünf, Zehn), gewinnt der Computer mit dem Blackjack.

Ändern Sie Ihr Programm entsprechend.

## Erweiterte Spielregeln - Asse

Beim echten Blackjack gibt es eine komplexere Logik für Asse. Jedes Ass kann einen Wert von 11 **oder** 1 haben, was auch immer besser ist. Schauen wir uns ein Beispiel an:

* Der/die SpielerIn hat eine Zehn und eine Fünf.
* Als nächstes erhält er/sie ein Ass. Wenn das Ass mit einem Wert von 11 gezählt würde, hätte der/die SpielerIn 26 und würde die Runde verlieren. In einem solchen Fall zählt das Ass nur 1. Der Gesamtkartenwert beträgt also 16.

Hier ist ein weiteres Beispiel:

* Der/die SpielerIn hat ein Ass.
* Der/die SpielerIn erhält ein weiteres Ass. Das würde zu einem Gesamtwert von 22 führen. In diesem Fall zählt eines der Asse als 1 und der Gesamtkartenwert ist 12, nicht 22.

Ändern Sie Ihr Programm entsprechend.

## Beispielausgabe 1

Hier ein Ablauf eines Turniers. Achten Sie insbesondere auf das Spiel des Computers in Runde 1. Hier sieht man die Auswirkung der erweiterten Ass-Spielregel (siehe oben). Ohne Ass-Regel hätte der Computer schon nach der 3. Karte mehr als 21 (Ass, 2 und 9 ergibt 22).

```txt
*** WELCOME TO BLACKJACK ***

You have 100€ in your pocket. Try to double it!
You will lose if you have no money left

*** ROUND 1, you have 100€ left.

You have 5, hand value is 5.
How much do you want to bet? Bet must be >= 10€ and <= 100€. Press Enter for minimal bet. 20
You have King, hand value is 15. Do you want another card? (y/n) y
You have 6, hand value is 21.
Dealer's turn...
Dealer has Ace, hand value is 11.
Dealer has 2, hand value is 13.
Dealer has 9, hand value is 12.
Dealer has 10, hand value is 22.
Dealer busted, you won!

*** ROUND 2, you have 120€ left.

You have 10, hand value is 10.
How much do you want to bet? Bet must be >= 10€ and <= 120€. Press Enter for minimal bet. 50
You have King, hand value is 20. Do you want another card? (y/n) n

Dealer's turn...
Dealer has Ace, hand value is 11.
Dealer has 8, hand value is 19.
You win!

*** ROUND 3, you have 170€ left.

You have 5, hand value is 5.
How much do you want to bet? Bet must be >= 10€ and <= 170€. Press Enter for minimal bet. 
You have Jack, hand value is 15. Do you want another card? (y/n) n

Dealer's turn...
Dealer has 9, hand value is 9.
Dealer has Jack, hand value is 19.
Dealer wins!

*** ROUND 4, you have 160€ left.

You have 7, hand value is 7.
How much do you want to bet? Bet must be >= 10€ and <= 160€. Press Enter for minimal bet. 50
You have 3, hand value is 10. Do you want another card? (y/n) y
You have 10, hand value is 20. Do you want another card? (y/n) n

Dealer's turn...
Dealer has 7, hand value is 7.
Dealer has 2, hand value is 9.
Dealer has 8, hand value is 17.
You win!
You have 210€, you at least doubled your money!
```

## Beispielausgabe 2

Hier ein Ablauf eines Turniers. In Runde 1 hat der/die SpielerIn einen Blackjack und gewinnt sofort (erweiterte Spielregeln). In der Runde zwei hat der/die SpielerIn 21, der Computer aber einen Blackjack. Daher gewinnt der Computer.

```txt
*** WELCOME TO BLACKJACK ***

You have 100€ in your pocket. Try to double it!
You will lose if you have no money left

*** ROUND 1, you have 100€ left.

You have Ace, hand value is 11.
How much do you want to bet? Bet must be >= 10€ and <= 100€. Press Enter for minimal bet. 50
You have Jack, Blackjack! You won with Blackjack!

*** ROUND 2, you have 175.0€ left.

You have 10, hand value is 10.
How much do you want to bet? Bet must be >= 10€ and <= 175.0€. Press Enter for minimal bet. 75
You have 5, hand value is 15. Do you want another card? (y/n) y
You have 6, hand value is 21.
Dealer's turn...
Dealer has Ace, hand value is 11.
Dealer has King, Blackjack!
Dealer won with Blackjack!

*** ROUND 3, you have 100.0€ left.
...
```

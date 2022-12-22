# Parkscheinautomat

## Angabe

Um in der Linzer Innenstadt parken zu dürfen, muss vorher ein Parkschein bei einem entsprechenden Automaten gekauft werden. Eine Stunde parken kostet dabei genau einen Euro. Die minimale Parkdauer beträgt 30 Minuten und die maximale Parkdauer ist mit 90 Minuten festgelegt. Der Parkscheinautomat gibt *kein* Wechselgeld zurück.

Ein derartiger Automat ist von Dir wie folgt zu simulieren:

* Der Benutzer ist zu begrüßen und dann aufzufordern, gültige Münzen (5 Cents, 10 Cents, 20 Cents, 50 Cents, 1 Euro und 2 Euros) einzuwerfen. Nach dem Münzeinwurf berechnet das Programm die bereits bezahlte Parkdauer (Ausgabe im Format *Stunden:Minuten*) und fordert den Benutzer auf, eine weitere Münze einzuwerfen. Nur wenn die maximale Parkdauer bereits erreicht ist oder gar überschritten wurde, wird der Benutzer nicht mehr zum Münzeinwurf aufgefordert.

* Durch Eingabe des Zeichens *d* oder *D* beendet der Benutzer die Eingabe von Münzen und fordert den Ticketdruck an. Ist die Mindestparkdauer (30 Minuten) noch nicht erreicht, wird der Kunde aufgefordert, weitere Münzen einzuwerfen. Das Ticket wird in diesem Fall nicht "gedruckt".

* Als Ausgabe wird dem Kunden die Parkdauer mitgeteilt. Bei Überschreitung der maximalen Parkdauer bedankt sich der Automat für die "Spende".

## Anforderung

Bei der Umsetzung dieser Aufgabe musst du dein Programm in mehrere Methoden aufteilen. Folgende Methoden sind insbesondere wichtig:

* `PrintWelcome` zum Ausgeben der Begrüßungsnachricht.
* `EnterCoins` fordert den Benutzer auf, Münzen einzuwerfen und erlaubt dem Benutzer die Eingabe des Münzwerts bzw. von *d* oder *D* zum Drucken des Tickets.
* `AddParkingTime` erhöht die Parkzeit auf Grundlage der eingeworfenen Münzen.
* `PrintParkingTime` gibt die aktuelle Parkzeit im Format *Stunden:Minuten* aus.
* `PrintDonation` gibt die Höhe der "Spende" im Format *n Euros m Cents* (z.B. *1 Euro 95 Cents*) aus.

Natürlich kannst du weitere Methoden verwenden.

## Musterein- und Ausgaben

Hier einige Musterein- und Ausgaben des Programms. Beachte, dass die Ein- und Ausgaben möglichst exakt so erfolgen, wie in den Beispielen gezeigt.

### Normaler Ablauf

```txt
Parkscheinautomat mit Mindestparkdauer 30 Min und Höchstparkdauer 1:30 Stunden
Tarif pro Stunde: 1 Euro
Zulässige Münzen: 50 (Cents), 10 (Cents), 20 (Cents), 50 (Cents), 1 (Euro), 2 (Euro)
Parkschein drucken mit d oder D

Parkzeit bisher: 0:0
Ihre Eingabe: d
Mindesteinwurf 50 Cent, bisher haben Sie 0 Cent eingeworfen
Parkzeit bisher: 0:0
Ihre Eingabe: 20
Parkzeit bisher: 0:12
Ihre Eingabe: 10
Parkzeit bisher: 0:18
Ihre Eingabe: 5
Parkzeit bisher: 0:21
Ihre Eingabe: 50
Parkzeit bisher: 0:51
Ihre Eingabe: d

Sie dürfen 0:51 Stunden parken
```

### Überschreitung der maximalen Parkdauer

```txt
Parkscheinautomat mit Mindestparkdauer 30 Min und Höchstparkdauer 1:30 Stunden
Tarif pro Stunde: 1 Euro
Zulässige Münzen: 50 (Cents), 10 (Cents), 20 (Cents), 50 (Cents), 1 (Euro), 2 (Euro)
Parkschein drucken mit d oder D

Parkzeit bisher: 0:0
Ihre Eingabe: 1
Parkzeit bisher: 1:0
Ihre Eingabe: 20
Parkzeit bisher: 1:12
Ihre Eingabe: 20
Parkzeit bisher: 1:24
Ihre Eingabe: 5
Parkzeit bisher: 1:27
Ihre Eingabe: 2

Sie dürfen 1:30 Stunden parken
Danke für Ihre Spende von 1 Euro 95 Cent
```

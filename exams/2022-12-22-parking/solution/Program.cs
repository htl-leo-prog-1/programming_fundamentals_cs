const int MINDESTEINWURF = 50;
const int MAXIMALEINWURF = 150;
int summe = 0;
bool ticketDrucken = false;

PrintWelcome();
do
{
    Console.WriteLine($"Parkzeit bisher: {FormatParkingTime()}");
    ticketDrucken = EnterCoins();
}
while (summe < MAXIMALEINWURF && !ticketDrucken);  // Maximalparkzeit überschritten oder Drucken mit gültiger Parkzeit
Console.WriteLine();
Console.WriteLine($"Sie dürfen {FormatParkingTime()} Stunden parken");
PrintDonation();


void PrintWelcome()
{
    Console.WriteLine("Parkscheinautomat mit Mindestparkdauer 30 Min und Höchstparkdauer 1:30 Stunden");
    Console.WriteLine("Tarif pro Stunde: 1 Euro");
    Console.WriteLine("Zulässige Münzen: 5 (Cents), 10 (Cents), 20 (Cents), 50 (Cents), 1 (Euro), 2 (Euro)");
    Console.WriteLine("Parkschein drucken mit d oder D");
    Console.WriteLine();
}

bool EnterCoins()
{
    Console.Write("Ihre Eingabe: ");
    string eingabe = Console.ReadLine()!;
    bool drucken = false;

    // Also possible: if (eingabe is "d" or "D")
    if (eingabe == "d" || eingabe == "D") // Print ticket
    {
        if (summe < MINDESTEINWURF) // Mindesteinwurf 50 Cent
        {
            Console.WriteLine($"Mindesteinwurf 50 Cent, bisher haben Sie {summe} Cent eingeworfen");
        }
        else  // Parkzeit stimmt ==> Drucken ist möglich
        {
            drucken = true;
        }
    }
    else  // weiterer Einwurf
    {
        int einwurf = int.Parse(eingabe);
        // Also possible: if (einwurf is 5 or 10 or 20 or 50 or 100 or 200)
        if (einwurf == 5 || einwurf == 10 || einwurf == 20 || einwurf == 50 || einwurf == 1 || einwurf == 2)
        {
            AddParkingTime(einwurf);
        }
        else
        {
            Console.WriteLine("Bitte geben sie gültige Münzen ein!");
        }
    }

    return drucken;
}

void AddParkingTime(int einwurf)
{
    if (einwurf < 5) // 1 oder 2 Euro
    {
        einwurf *= 100; // in Cent umrechnen
    }

    summe += einwurf;
}

string FormatParkingTime()
{
    int zeitMinuten = Math.Min(summe, MAXIMALEINWURF) / 5 * 3;  // 5 Cent entsprechen 3 Minuten ==> keine Gleitkommaberechnung notwendig
    return $"{zeitMinuten / 60}:{zeitMinuten % 60}";
}

void PrintDonation()
{
    // Ausgabe mit Dankeschön für etwaige Spende
    if (summe > MAXIMALEINWURF) // Überzahlung der Maximalparkdauer
    {
        int ueberZahlung = summe - MAXIMALEINWURF;
        Console.WriteLine($"Danke für Ihre Spende von {ueberZahlung / 100} Euro {ueberZahlung % 100,2:d} Cent");
    }
}

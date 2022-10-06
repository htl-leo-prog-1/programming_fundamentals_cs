Console.Clear();

Console.Write("Please enter your Joker number (max. 4 digit number): ");
int userJoker = int.Parse(Console.ReadLine()!);

int joker = Random.Shared.Next(9_999);

Console.OutputEncoding = System.Text.Encoding.Default;

{
    // Level 0 - just find out if user has guessed the Joker
    if (userJoker == joker)
    {
        Console.WriteLine("Wow 🥳, you got the JOKER 🃏!");
    }
    else
    {
        Console.WriteLine("Sorry, no Joker 😢");
    }
}

{
    // Level 1 - Count number of correct digits from left
    int numberOfCorrectDigits = 0;
    if (joker / 1_000 == userJoker / 1_000)
    {
        if (joker / 100 == userJoker / 100)
        {
            if (joker / 10 == userJoker / 10)
            {
                if (joker == userJoker) { numberOfCorrectDigits = 4; }
                else numberOfCorrectDigits = 3;
            }
            else numberOfCorrectDigits = 2;
        }
        else numberOfCorrectDigits = 1;
    }

    if (numberOfCorrectDigits == 4)
    {
        Console.WriteLine("Wow 🥳, you got the JOKER 🃏!");
    }
    else
    {
        Console.WriteLine("You got " + numberOfCorrectDigits + " correct!");
    }
}

{
    // Level 2 - Count number of correct digits from right
    int numberOfCorrectDigits = 0;
    if (joker % 10 == userJoker % 10)
    {
        if (joker % 100 == userJoker % 100)
        {
            if (joker % 1_000 == userJoker % 1_000)
            {
                if (joker == userJoker) { numberOfCorrectDigits = 4; }
                else numberOfCorrectDigits = 3;
            }
            else numberOfCorrectDigits = 2;
        }
        else numberOfCorrectDigits = 1;
    }

    if (numberOfCorrectDigits == 4)
    {
        Console.WriteLine("Wow 🥳, you got the JOKER 🃏!");
    }
    else
    {
        Console.WriteLine("You got " + numberOfCorrectDigits + " correct!");
    }
}

Console.WriteLine("The correct Joker number would have been " + joker + ".");

Console.WriteLine("Press any key to continue");
Console.ReadKey();
Console.Clear();

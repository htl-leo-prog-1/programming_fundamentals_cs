const int FIVE_OF_A_KIND = 8;
const int FOUR_OF_A_KIND = 7;
const int FULL_HOUSE = 6;
const int STRAIGHT = 5;
const int THREE_OF_A_KIND = 4;
const int TWO_PAIRS = 3;
const int ONE_PAIR = 2;
const int BUST = 1;

int result = 0, player1Result = 0, player2Result = 0;

int dice1 = 0, dice2 = 0, dice3 = 0, dice4 = 0, dice5 = 0;
bool fixed1 = false, fixed2 = false, fixed3 = false, fixed4 = false, fixed5 = false;

Console.Clear();

Console.WriteLine("PLAYER 1:");
Console.WriteLine("=========");
Play();
player1Result = result;

Console.WriteLine("\nPLAYER 2:");
Console.WriteLine("=========");
Play();
player2Result = result;

Console.WriteLine("---");
DetermineWinner();

void Play()
{
    for (int i = 0; i < 3 && !(fixed1 && fixed2 && fixed3 && fixed4 && fixed5); i++)
    {
        if (i > 0) { Console.WriteLine("---"); }
        RollDices();
        Console.Write($"Dice roll #{i + 1} (out of 3): ");
        PrintDices();
        if (i < 2) { FixDices(); }
    }

    Console.WriteLine("---");
    SortDices();
    AnalyzeAndPrintResult();
}

void RollDices()
{
    if (!fixed1) { dice1 = Random.Shared.Next(1, 7); }
    if (!fixed2) { dice2 = Random.Shared.Next(1, 7); }
    if (!fixed3) { dice3 = Random.Shared.Next(1, 7); }
    if (!fixed4) { dice4 = Random.Shared.Next(1, 7); }
    if (!fixed5) { dice5 = Random.Shared.Next(1, 7); }
}

void PrintDices()
{
    Console.WriteLine($"{dice1}, {dice2}, {dice3}, {dice4}, {dice5}");
}

void FixDices()
{
    fixed1 = fixed2 = fixed3 = fixed4 = fixed5 = false;

    Console.WriteLine("Which dice do you want to fix/unfix? (1-5, or 'r' to roll the dices)");
    char input;
    do
    {
        input = Console.ReadKey(true).KeyChar;
        switch (input)
        {
            case '1': fixed1 = !fixed1; break;
            case '2': fixed2 = !fixed2; break;
            case '3': fixed3 = !fixed3; break;
            case '4': fixed4 = !fixed4; break;
            case '5': fixed5 = !fixed5; break;
            case 'r': break;
        }

        if (input != 'r')
        {
            if (!fixed1 && !fixed2 && !fixed3 && !fixed4 && !fixed5)
            {
                Console.WriteLine("No dice is fixed.");
            }
            else
            {
                Console.Write("Fixed: ");
                if (fixed1) { Console.Write("1 "); }
                if (fixed2) { Console.Write("2 "); }
                if (fixed3) { Console.Write("3 "); }
                if (fixed4) { Console.Write("4 "); }
                if (fixed5) { Console.Write("5 "); }
                Console.WriteLine();
            }
        }
    } while (input != 'r');
}

void SortDices()
{
    while (dice1 > dice2 || dice2 > dice3 || dice3 > dice4 || dice4 > dice5)
    {
        if (dice1 > dice2) { (dice1, dice2) = (dice2, dice1); }
        if (dice2 > dice3) { (dice2, dice3) = (dice3, dice2); }
        if (dice3 > dice4) { (dice3, dice4) = (dice4, dice3); }
        if (dice4 > dice5) { (dice4, dice5) = (dice5, dice4); }
    }
}

void AnalyzeAndPrintResult()
{
    if (dice1 == dice2 && dice1 == dice3 && dice1 == dice4 && dice1 == dice5)
    {
        Console.WriteLine("Five of a kind!");
        result = FIVE_OF_A_KIND;
    }
    else if ((dice1 == dice2 && dice1 == dice3 && dice1 == dice4)
        || (dice2 == dice3 && dice2 == dice4 && dice2 == dice5))
    {
        Console.WriteLine("Four of a kind!");
        result = FOUR_OF_A_KIND;
    }
    else if ((dice1 == dice2 && dice1 == dice3)
        || (dice2 == dice3 && dice2 == dice4)
        || (dice3 == dice4 && dice3 == dice5))
    {
        Console.WriteLine("Three of a kind!");
        result = THREE_OF_A_KIND;
    }
    else if ((dice1 == dice2 && dice3 == dice4)
        || (dice1 == dice2 && dice4 == dice5)
        || (dice2 == dice3 && dice4 == dice5))
    {
        Console.WriteLine("Two pairs!");
        result = TWO_PAIRS;
    }
    else if (dice1 == dice2 || dice2 == dice3 || dice3 == dice4 || dice4 == dice5)
    {
        Console.WriteLine("One pair!");
        result = ONE_PAIR;
    }
    else if (dice1 == dice2 - 1 && dice2 == dice3 - 1 && dice3 == dice4 - 1 && dice4 == dice5 - 1)
    {
        Console.WriteLine("Straight!");
        result = STRAIGHT;
    }
    else if ((dice1 == dice2 && dice3 == dice4 && dice3 == dice5) || (dice1 == dice2 && dice2 == dice3 && dice4 == dice5))
    {
        Console.WriteLine("Full House!");
        result = FULL_HOUSE;
    }
    else
    {
        Console.WriteLine("No pairs!");
        result = BUST;
    }
}

void DetermineWinner()
{
    if (player1Result == player2Result)
    {
        Console.WriteLine("It's a tie!");
    }
    else if (player1Result > player2Result)
    {
        Console.WriteLine("Player 1 wins!");
    }
    else
    {
        Console.WriteLine("Player 2 wins!");
    }
}
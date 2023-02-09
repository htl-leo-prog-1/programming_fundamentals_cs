const int MINIMAL_BET = 10;
const int INITIAL_MONEY = 100;

const int BET_EVEN = 1;
const int BET_ODD = 2;
const int BET_RED = 3;
const int BET_BLACK = 4;
const int BET_DOZEN = 5;
const int BET_SINGLE = 6;

int money = INITIAL_MONEY;
int betType = 0;
int singleNumber = 0;
int dozen = 0;
int bet = 0;

PrintWelcome();

do
{
    Console.WriteLine();
    Console.Write($"How much money do you want to bet (between {MINIMAL_BET} and {money})? ");
    bet = AskForNumber(MINIMAL_BET, money);

    AskForBetType();

    int randomNumber = Random.Shared.Next(0, 37);
    Console.WriteLine($"The random number is {randomNumber}.");

    EvaluateResult(randomNumber);
}
while (money >= MINIMAL_BET && money < INITIAL_MONEY * 2);


void PrintWelcome()
{
    Console.Clear();
    Console.WriteLine("*** WELCOME TO ROULETTE! ***");
    Console.WriteLine();
    Console.WriteLine("Play until you have lost or doubled your money.");
}

void AskForBetType()
{
    Console.WriteLine("What do you want to bet on?");
    Console.WriteLine($"{BET_EVEN}) Even");
    Console.WriteLine($"{BET_ODD}) Odd");
    Console.WriteLine($"{BET_RED}) Red");
    Console.WriteLine($"{BET_BLACK}) Black");
    Console.WriteLine($"{BET_DOZEN}) Dozen bet");
    Console.WriteLine($"{BET_SINGLE}) A single number");
    betType = AskForNumber(BET_EVEN, BET_SINGLE);

    if (betType == BET_SINGLE)
    {
        Console.WriteLine("Enter the number you want to bet on (0-36)");
        singleNumber = AskForNumber(0, 36);
    }
    else if (betType == BET_DOZEN)
    {
        Console.WriteLine("Enter the dozen you want to bet on (1-3)");
        dozen = AskForNumber(1, 3);
    }
}

int AskForNumber(int min, int max)
{
    bool validNumber = false;
    int number = 0;
    do
    {
        number = int.Parse(Console.ReadLine()!);
        validNumber = number >= min && number <= max;
        if (!validNumber)
        {
            Console.WriteLine("Invalid input, try again");
        }
    }
    while (!validNumber);
    return number;
}

void EvaluateResult(int randomNumber)
{
    int wonAmount = 0;
    switch (betType)
    {
        case BET_EVEN:
            if (randomNumber != 0 && randomNumber % 2 == 0) { wonAmount = bet; }
            break;
        case BET_ODD:
            if (randomNumber % 2 != 0) { wonAmount = bet; }
            break;
        case BET_RED:
        case BET_BLACK:
            bool isRed = randomNumber is 32 or 19 or 21 or 25 or 34 or 27 or 36 or 30
                    or 23 or 5 or 16 or 1 or 14 or 9 or 18 or 7 or 12 or 3;
            if (randomNumber != 0 && ((betType == BET_RED && isRed) || betType == BET_BLACK))
            {
                wonAmount = bet;
            }
            break;
        case BET_DOZEN:
            if (randomNumber != 0 && (randomNumber - 1) / 3 == dozen) { wonAmount = bet * 2; }
            break;
        case BET_SINGLE:
            if (randomNumber == singleNumber) { wonAmount = bet * 35; }
            break;
    }

    if (wonAmount > 0)
    {
        money += wonAmount;
        Console.Write($"You won {wonAmount}€! ");
    }
    else
    {
        money -= bet;
        Console.Write($"You lost {bet}€. ");
    }

    Console.WriteLine($"You now have {money}€.");
}
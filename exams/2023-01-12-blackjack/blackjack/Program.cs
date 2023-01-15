const int NUMBER_OF_CARDS = 13;

const int ACE = 1;
const int JACK = 11;
const int QUEEN = 12;
const int KING = 13;

const decimal STARTING_MONEY = 100;
const decimal MINIMAL_BET = 10;

int currentCard, currentCardValue, firstCard, secondCard, handValue, numberOfAces, round = 0;
bool hasBlackjack;
decimal money = STARTING_MONEY, bet;

Console.Clear();

Console.WriteLine("*** WELCOME TO BLACKJACK ***");
Console.WriteLine();
Console.WriteLine($"You have {money}€ in your pocket. Try to double it!");
Console.WriteLine("You will lose if you have no money left");

do
{
    bet = 0m;
    round++;
    Console.WriteLine($"\n*** ROUND {round}, you have {money}€ left.\n");

    InitializeGame();

    bool anotherCard = true;
    do
    {
        HandoutRandomCard();
        Console.Write("You have ");
        PrintCard();

        if (secondCard == -1)
        {
            Console.WriteLine();
            while (bet < MINIMAL_BET)
            {
                AskForBet();
            }
        }

        if (handValue < 21 && secondCard != -1)
        {
            Console.Write(" Do you want another card? (y/n) ");
            anotherCard = Console.ReadLine() == "y";
        }
    } while (handValue < 21 && anotherCard);

    if (handValue > 21)
    {
        Console.WriteLine(" You busted!");
        money -= bet;
    }
    else if (hasBlackjack)
    {
        Console.WriteLine(" You won with Blackjack!");
        money += bet * 1.5m;
    }
    else
    {
        int playerHandValue = handValue;

        InitializeGame();
        Console.WriteLine("\nDealer's turn...");

        do
        {
            HandoutRandomCard();

            Thread.Sleep(1000);
            Console.Write("Dealer has ");
            PrintCard();
            Console.WriteLine();
        } while (handValue < 17);

        if (handValue > 21)
        {
            Console.WriteLine("Dealer busted, you won!");
            money += bet;
        }
        else if (hasBlackjack)
        {
            Console.WriteLine("Dealer won with Blackjack!");
            money -= bet;
        }
        else
        {
            if (playerHandValue > handValue)
            {
                Console.WriteLine("You win!");
                money += bet;
            }
            else if (playerHandValue < handValue)
            {
                Console.WriteLine("Dealer wins!");
                money -= bet;
            }
            else
            {
                Console.WriteLine("Standoff, you get your money back!");
            }
        }
    }
}
while (money >= MINIMAL_BET && money < STARTING_MONEY * 2);

if (money == 0) { Console.WriteLine("You are broke, you lost!"); }
else { Console.WriteLine($"You have {money}€, you at least doubled your money!"); }

void InitializeGame()
{
    firstCard = -1;
    secondCard = -1;
    handValue = 0;
    numberOfAces = 0;
}

void HandoutRandomCard()
{
    currentCard = Random.Shared.Next(NUMBER_OF_CARDS) + 1;

    if (currentCard == ACE) { numberOfAces++; }

    hasBlackjack = false;
    if (firstCard == -1) { firstCard = currentCard; }
    else if (secondCard == -1)
    {
        secondCard = currentCard;
        if (numberOfAces == 1 && (firstCard >= JACK || secondCard >= JACK))
        {
            hasBlackjack = true;
        }
    }

    switch (currentCard)
    {
        case ACE: currentCardValue = 11; break;
        case JACK:
        case QUEEN:
        case KING: currentCardValue = 10; break;
        default: currentCardValue = currentCard; break;
    }

    handValue += currentCardValue;

    if (handValue > 21 && numberOfAces > 0)
    {
        handValue -= 10;
        numberOfAces--;
    }
}

void PrintCard()
{
    switch (currentCard)
    {
        case ACE: Console.Write("Ace"); break;
        case JACK: Console.Write("Jack"); break;
        case QUEEN: Console.Write("Queen"); break;
        case KING: Console.Write("King"); break;
        default: Console.Write(currentCard); break;
    }

    if (hasBlackjack) { Console.Write(", Blackjack!"); }
    else { Console.Write($", hand value is {handValue}."); }
}

void AskForBet()
{
    Console.Write($"How much do you want to bet? Bet must be >= {MINIMAL_BET}€ and <= {money}€. Press Enter for minimal bet. ");
    string betString = Console.ReadLine()!;
    if (betString == "") { bet = MINIMAL_BET; }
    else
    {
        bet = decimal.Parse(betString);
        if (bet < MINIMAL_BET || bet > money)
        {
            Console.WriteLine("Invalid bet!");
            bet = 0m;
        }
    }
}

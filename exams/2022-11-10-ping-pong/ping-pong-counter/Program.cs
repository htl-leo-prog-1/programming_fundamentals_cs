Console.Clear(); // This is optional
Console.ResetColor(); // This is optional

Console.Write("Please enter the match type: ");
Console.ForegroundColor = ConsoleColor.Red;
string matchType = Console.ReadLine()!;
Console.ResetColor();

int gamesForVictory = 0;
switch (matchType)
{
    case "short": gamesForVictory = 1; break;
    case "regular": gamesForVictory = 4; break;
    case "double": gamesForVictory = 3; break;
    case "custom": // Additional requirement
        do
        {
            Console.Write("How many games must be won to win the match: ");
            Console.ForegroundColor = ConsoleColor.Red;
            gamesForVictory = int.Parse(Console.ReadLine()!);
            Console.ResetColor();
        }
        while (gamesForVictory < 0 || gamesForVictory > 9 || gamesForVictory % 2 != 1);
        break;
    default: // Optional
        Console.WriteLine("Invalid match type!");
        break;
}

int gamesPlayer1 = 0, gamesPlayer2 = 0, pointsPlayer1 = 0, pointsPlayer2 = 0;
string scorer; // Additional requirement, can be int for minimum requirements
int service = Random.Shared.Next(1, 3); // Additional requirement
do
{
    // Additional requirement
    Console.WriteLine($"Player {service} has the service");

    Console.Write("Who has won the point: ");
    Console.ForegroundColor = ConsoleColor.Red;
    scorer = Console.ReadLine()!;
    Console.ResetColor();
    switch (scorer)
    {
        case "1":
            pointsPlayer1++;
            if (pointsPlayer1 == 11)
            {
                Console.WriteLine("Player 1 has won the game.\n");
                gamesPlayer1++;
                pointsPlayer1 = pointsPlayer2 = 0;
                service = Random.Shared.Next(1, 3); // Additional requirement
            }
            break;
        case "2":
            pointsPlayer2++;
            if (pointsPlayer2 == 11)
            {
                Console.WriteLine("Player 2 has won the game.\n");
                gamesPlayer2++;
                pointsPlayer1 = pointsPlayer2 = 0;
                service = Random.Shared.Next(1, 3); // Additional requirement
            }
            break;
    }

    Console.WriteLine($"Games: {gamesPlayer1}:{gamesPlayer2}, Points: {pointsPlayer1}:{pointsPlayer2}");

    // Additional requirement
    if ((pointsPlayer1 + pointsPlayer2) % 2 == 0)
    {
        if (service == 1) { service = 2; }
        else { service = 1; }
    }
}
while (scorer != "q" && gamesPlayer1 != gamesForVictory && gamesPlayer2 != gamesForVictory);

if (scorer != "q") // Additional requirement
{
    int winner = 0;
    if (gamesPlayer1 == gamesForVictory) { winner = 1; }
    else { winner = 2; }
    Console.WriteLine($"Congratulations, player {winner}, you have won the match!");
}

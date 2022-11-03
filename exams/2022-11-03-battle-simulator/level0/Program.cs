#region Constants
// Define constants for character role attributes
const int PIRATE_HEALTH = 20;
const int PIRATE_ATTACK = 3;
const int PIRATE_SPEED = 3;

const int STONE_CHEWER_HEALTH = 50;
const int STONE_CHEWER_ATTACK = 8;
const int STONE_CHEWER_SPEED = 1;

const int GHOST_WARRIOR_HEALTH = 20;
const int GHOST_WARRIOR_ATTACK = 2;
const int GHOST_WARRIOR_SPEED = 5;

// Define constants for UI
const string QUESTION = "What is the role of player ";
const string SELECTION = "Is it (p)irate, (s)tone chewer, or (g)host warrior? ";
#endregion

#region Character role of player 1
Console.WriteLine($"{QUESTION} 1?");
Console.Write(SELECTION);
string role1 = Console.ReadLine()!;
int health1 = 0, attack1 = 0, speed1 = 0;
switch (role1) 
{
    case "p":
    case "P":
        health1 = PIRATE_HEALTH;
        attack1 = PIRATE_ATTACK;
        speed1 = PIRATE_SPEED;
        break;
    case "s":
    case "S":
        health1 = STONE_CHEWER_HEALTH;
        attack1 = STONE_CHEWER_ATTACK;
        speed1 = STONE_CHEWER_SPEED;
        break;
    case "g":
    case "G":
        health1 = GHOST_WARRIOR_HEALTH;
        attack1 = GHOST_WARRIOR_ATTACK;
        speed1 = GHOST_WARRIOR_SPEED;
        break;
}
#endregion

#region Character role of player 2
// Important note:
// Currently, we need to copy the previous section for handling the second player's
// character role. In the near future, you will learn about methods. Once we know
// methods, we will be able greatly simplify this program.

Console.WriteLine($"{QUESTION} 2?");
Console.Write(SELECTION);
string role2 = Console.ReadLine()!;
int health2 = 0, attack2 = 0, speed2 = 0;
switch (role2) 
{
    case "p":
    case "P":
        health2 = PIRATE_HEALTH;
        attack2 = PIRATE_ATTACK;
        speed2 = PIRATE_SPEED;
        break;
    case "s":
    case "S":
        health2 = STONE_CHEWER_HEALTH;
        attack2 = STONE_CHEWER_ATTACK;
        speed2 = STONE_CHEWER_SPEED;
        break;
    case "g":
    case "G":
        health2 = GHOST_WARRIOR_HEALTH;
        attack2 = GHOST_WARRIOR_ATTACK;
        speed2 = GHOST_WARRIOR_SPEED;
        break;
}
#endregion

#region Battle simulation
// Repeat rounds until one player reaches health zero (or lower)
while (health1 > 0 && health2 > 0)
{
    // Player 2 attacks player 1
    int attacks = speed2;
    while (attacks > 0)
    {
        health1 -= attack2;
        attacks--;
    }

    // Player 1 attacks player 2
    attacks = speed1;
    while (attacks > 0)
    {
        health2 -= attack1;
        attacks--;
    }
}
#endregion

#region Determine battle outcome
if (health1 > 0)
{
    // Player 1 survived
    Console.WriteLine("Player 1 is the winner");
} else if (health2 > 0)
{
    // Player 2 survived
    Console.WriteLine("Player 2 is the winner");
} else 
{
    // Both players have lost -> draw
    Console.WriteLine("It is a draw");
}
#endregion

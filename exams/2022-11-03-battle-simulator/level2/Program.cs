#region Constants
// Define constants for character role attributes
const double PIRATE_HEALTH = 20;
const double PIRATE_ATTACK = 3;
const double PIRATE_ARMOR = 3;
const int PIRATE_SPEED = 3; // Speed determines number of hits, no need for floating-point value here

const double STONE_CHEWER_HEALTH = 50;
const double STONE_CHEWER_ATTACK = 8;
const double STONE_CHEWER_ARMOR = 10;
const int STONE_CHEWER_SPEED = 1;

const double GHOST_WARRIOR_HEALTH = 20;
const double GHOST_WARRIOR_ATTACK = 2;
const double GHOST_WARRIOR_ARMOR = 2;
const int GHOST_WARRIOR_SPEED = 5;

const double OUTWORLDER_HEALTH = 15;
const double OUTWORLDER_ATTACK = 1;
const double OUTWORLDER_ARMOR = 2;
const int OUTWORLDER_SPEED = 10;

const double MONSTER_KNIGHT_HEALTH = 15;
const double MONSTER_KNIGHT_ATTACK = 4;
const double MONSTER_KNIGHT_ARMOR = 3;
const int MONSTER_KNIGHT_SPEED = 3;

const double DARK_GOBLIN_HEALTH = 10;
const double DARK_GOBLIN_ATTACK = 1;
const double DARK_GOBLIN_ARMOR = 8;
const int DARK_GOBLIN_SPEED = 3;

// Define constants for UI
const string QUESTION = "What is the role of player ";
const string SELECTION = "Is it (p)irate, (s)tone chewer, (g)host warrior, (o)utworlder, (m)onster knight, or (d)ark goblin? ";
#endregion

#region Character role of player 1
Console.WriteLine($"{QUESTION} 1?");
Console.Write(SELECTION);
string role1 = Console.ReadLine()!;
double health1 = 0, attack1 = 0, armor1 = 0;
int speed1 = 0;
switch (role1) 
{
    case "p":
    case "P":
        health1 = PIRATE_HEALTH;
        attack1 = PIRATE_ATTACK;
        armor1 = PIRATE_ARMOR;
        speed1 = PIRATE_SPEED;
        break;
    case "s":
    case "S":
        health1 = STONE_CHEWER_HEALTH;
        attack1 = STONE_CHEWER_ATTACK;
        armor1 = STONE_CHEWER_ARMOR;
        speed1 = STONE_CHEWER_SPEED;
        break;
    case "g":
    case "G":
        health1 = GHOST_WARRIOR_HEALTH;
        attack1 = GHOST_WARRIOR_ATTACK;
        armor1 = GHOST_WARRIOR_ARMOR;
        speed1 = GHOST_WARRIOR_SPEED;
        break;
    case "o":
    case "O":
        health1 = OUTWORLDER_HEALTH;
        attack1 = OUTWORLDER_ATTACK;
        armor1 = OUTWORLDER_ARMOR;
        speed1 = OUTWORLDER_SPEED;
        break;
    case "m":
    case "M":
        health1 = MONSTER_KNIGHT_HEALTH;
        attack1 = MONSTER_KNIGHT_ATTACK;
        armor1 = MONSTER_KNIGHT_ARMOR;
        speed1 = MONSTER_KNIGHT_SPEED;
        break;
    case "d":
    case "D":
        health1 = DARK_GOBLIN_HEALTH;
        attack1 = DARK_GOBLIN_ATTACK;
        armor1 = DARK_GOBLIN_ARMOR;
        speed1 = DARK_GOBLIN_SPEED;
        break;
}
#endregion

#region Character role of player 2
Console.WriteLine($"{QUESTION} 2?");
Console.Write(SELECTION);
string role2 = Console.ReadLine()!;
double health2 = 0, attack2 = 0, armor2 = 0;
int speed2 = 0;
switch (role2) 
{
    case "p":
    case "P":
        health2 = PIRATE_HEALTH;
        attack2 = PIRATE_ATTACK;
        armor2 = PIRATE_ARMOR;
        speed2 = PIRATE_SPEED;
        break;
    case "s":
    case "S":
        health2 = STONE_CHEWER_HEALTH;
        attack2 = STONE_CHEWER_ATTACK;
        armor2 = STONE_CHEWER_ARMOR;
        speed2 = STONE_CHEWER_SPEED;
        break;
    case "g":
    case "G":
        health2 = GHOST_WARRIOR_HEALTH;
        attack2 = GHOST_WARRIOR_ATTACK;
        armor2 = GHOST_WARRIOR_ARMOR;
        speed2 = GHOST_WARRIOR_SPEED;
        break;
    case "o":
    case "O":
        health2 = OUTWORLDER_HEALTH;
        attack2 = OUTWORLDER_ATTACK;
        armor2 = OUTWORLDER_ARMOR;
        speed2 = OUTWORLDER_SPEED;
        break;
    case "m":
    case "M":
        health2 = MONSTER_KNIGHT_HEALTH;
        attack2 = MONSTER_KNIGHT_ATTACK;
        armor2 = MONSTER_KNIGHT_ARMOR;
        speed2 = MONSTER_KNIGHT_SPEED;
        break;
    case "d":
    case "D":
        health2 = DARK_GOBLIN_HEALTH;
        attack2 = DARK_GOBLIN_ATTACK;
        armor2 = DARK_GOBLIN_ARMOR;
        speed2 = DARK_GOBLIN_SPEED;
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
        double attack = (1d + Random.Shared.Next(-15, 15) / 100d) * attack2;
        double attackInArmor = Math.Min(armor1, attack);
        armor1 -= attackInArmor;
        health1 -= attack - attackInArmor;
        attacks--;
    }

    // Player 1 attacks player 2
    attacks = speed1;
    while (attacks > 0)
    {
        double attack = (1d + Random.Shared.Next(-15, 15) / 100d) * attack1;
        double attackInArmor = Math.Min(armor2, attack);
        armor2 -= attackInArmor;
        health2 -= attack - attackInArmor;
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

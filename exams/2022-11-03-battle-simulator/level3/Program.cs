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
#endregion

// Important note:
// Currently, we need to declare separate win counters for each character role.
// In the near future, you will learn about arrays. Once we know
// arrays, we will be able greatly simplify this program.

int battle = 0;
int winsPirate = 0, winsStoneChewer = 0, winsGhostWarrior = 0, winsOutworlder = 0, winsMonsterKnight = 0, winsDarkGoblin = 0;

// Loop over battles
while (battle < 10_000)
{
    // Increase battle counter
    battle++;

    #region Get random character roles
    // Determine two random character classes. Repeat generating random
    // roles until we have to different roles.
    int role1, role2;
    do
    {
        role1 = Random.Shared.Next(0, 6);
        role2 = Random.Shared.Next(0, 6);
    }
    while (role1 == role2);
    #endregion

    #region Role attributes of player 1
    double health1 = 0, attack1 = 0, armor1 = 0;
    int speed1 = 0;
    switch (role1)
    {
        case 0:
            health1 = PIRATE_HEALTH;
            attack1 = PIRATE_ATTACK;
            armor1 = PIRATE_ARMOR;
            speed1 = PIRATE_SPEED;
            break;
        case 1:
            health1 = STONE_CHEWER_HEALTH;
            attack1 = STONE_CHEWER_ATTACK;
            armor1 = STONE_CHEWER_ARMOR;
            speed1 = STONE_CHEWER_SPEED;
            break;
        case 2:
            health1 = GHOST_WARRIOR_HEALTH;
            attack1 = GHOST_WARRIOR_ATTACK;
            armor1 = GHOST_WARRIOR_ARMOR;
            speed1 = GHOST_WARRIOR_SPEED;
            break;
        case 3:
            health1 = OUTWORLDER_HEALTH;
            attack1 = OUTWORLDER_ATTACK;
            armor1 = OUTWORLDER_ARMOR;
            speed1 = OUTWORLDER_SPEED;
            break;
        case 4:
            health1 = MONSTER_KNIGHT_HEALTH;
            attack1 = MONSTER_KNIGHT_ATTACK;
            armor1 = MONSTER_KNIGHT_ARMOR;
            speed1 = MONSTER_KNIGHT_SPEED;
            break;
        case 5:
            health1 = DARK_GOBLIN_HEALTH;
            attack1 = DARK_GOBLIN_ATTACK;
            armor1 = DARK_GOBLIN_ARMOR;
            speed1 = DARK_GOBLIN_SPEED;
            break;
    }
    #endregion

    #region Role attributes of player 2
    double health2 = 0, attack2 = 0, armor2 = 0;
    int speed2 = 0;
    switch (role2)
    {
        case 0:
            health2 = PIRATE_HEALTH;
            attack2 = PIRATE_ATTACK;
            armor2 = PIRATE_ARMOR;
            speed2 = PIRATE_SPEED;
            break;
        case 1:
            health2 = STONE_CHEWER_HEALTH;
            attack2 = STONE_CHEWER_ATTACK;
            armor2 = STONE_CHEWER_ARMOR;
            speed2 = STONE_CHEWER_SPEED;
            break;
        case 2:
            health2 = GHOST_WARRIOR_HEALTH;
            attack2 = GHOST_WARRIOR_ATTACK;
            armor2 = GHOST_WARRIOR_ARMOR;
            speed2 = GHOST_WARRIOR_SPEED;
            break;
        case 3:
            health2 = OUTWORLDER_HEALTH;
            attack2 = OUTWORLDER_ATTACK;
            armor2 = OUTWORLDER_ARMOR;
            speed2 = OUTWORLDER_SPEED;
            break;
        case 4:
            health2 = MONSTER_KNIGHT_HEALTH;
            attack2 = MONSTER_KNIGHT_ATTACK;
            armor2 = MONSTER_KNIGHT_ARMOR;
            speed2 = MONSTER_KNIGHT_SPEED;
            break;
        case 5:
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

    if (health1 > 0)
    {
        // Player 1 survived
        switch (role1)
        {
            case 0: winsPirate++; break;
            case 1: winsStoneChewer++; break;
            case 2: winsGhostWarrior++; break;
            case 3: winsOutworlder++; break;
            case 4: winsMonsterKnight++; break;
            case 5: winsDarkGoblin++; break;
        }
    }
    else if (health2 > 0)
    {
        // Player 2 survived
        switch (role2)
        {
            case 0: winsPirate++; break;
            case 1: winsStoneChewer++; break;
            case 2: winsGhostWarrior++; break;
            case 3: winsOutworlder++; break;
            case 4: winsMonsterKnight++; break;
            case 5: winsDarkGoblin++; break;
        }
    }
}

// Print battle statistics
Console.WriteLine($"Pirate won {winsPirate} battles");
Console.WriteLine($"Stone Chewer won {winsStoneChewer} battles");
Console.WriteLine($"Ghost Warrior won {winsGhostWarrior} battles");
Console.WriteLine($"Outworlder won {winsOutworlder} battles");
Console.WriteLine($"Monster Knight won {winsMonsterKnight} battles");
Console.WriteLine($"Dark Goblin won {winsDarkGoblin} battles");
Console.WriteLine();

// Get highest win count
int maxWins = Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(winsPirate, winsStoneChewer), winsGhostWarrior), winsOutworlder), winsMonsterKnight), winsDarkGoblin);

// Print character role with highest win count
if (maxWins == winsPirate) { Console.Write("PIRATE"); }
else if (maxWins == winsStoneChewer) { Console.Write("STONE CHEWER"); }
else if (maxWins == winsGhostWarrior) { Console.Write("GHOST WARRIOR"); }
else if (maxWins == winsOutworlder) { Console.Write("OUTWORLDER"); }
else if (maxWins == winsMonsterKnight) { Console.Write("MONSTER KNIGHT"); }
else { Console.Write("DARK GOBLIN"); }
Console.WriteLine(" is the strongest character role!");

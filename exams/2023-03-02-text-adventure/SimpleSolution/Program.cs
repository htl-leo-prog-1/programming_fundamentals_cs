const int UNDEFINED = -1;
const int INTRO_SCENE = 0;
const int SHOW_SHADOW_FIGURE = 1;
const int SHOW_SKELETONS = 2;
const int HAUNTED_ROOM = 3;
const int CAMERA_SCENE = 4;
const int STRANGE_CREATURE = 5;
const int EXIT = 6;
int room = INTRO_SCENE;

const string PLEASE_VALID_OPTION = "Please enter a valid option.";
const string FOUND_EXIT = "You made it! You've found an exit.";

bool weapon = false;
bool goulAlive = true;

bool quit = false;

Console.WriteLine("Welcome to the Adventure Game!");
Console.WriteLine("==============================");

Console.WriteLine("As an avid traveler, you have decided to visit the Catacombs of Paris.");
Console.WriteLine("However, during your exploration, you find yourself lost.");
Console.WriteLine("You can choose to walk in multiple directions to find a way out.");

Console.WriteLine("Let's start with your name: ");
string name = Console.ReadLine()!;
Console.WriteLine($"Good luck, {name}.");

while (!quit)
{
    switch (room)
    {
        case INTRO_SCENE:
            IntroScene();
            break;
        case SHOW_SHADOW_FIGURE:
            ShowShadowFigure();
            break;
        case CAMERA_SCENE:
            CameraScene();
            break;
        case HAUNTED_ROOM:
            HauntedRoom();
            break;
        case SHOW_SKELETONS:
            ShowSkeletons();
            break;
        case STRANGE_CREATURE:
            StrangeCreature();
            break;
        case EXIT:
            quit = true;
            break;
        default:
            Console.WriteLine("Ups, you are in an unknown room.");
            quit = true;
            break;
    }
}

void IntroScene()
{
    Console.WriteLine("You are at a crossroads, and you can choose to go down any of the four hallways. Where would you like to go?");

    string userInput = "";
    room = UNDEFINED;
    while (room == UNDEFINED)
    {
        Console.WriteLine("Options: north/east/south/west");
        userInput = Console.ReadLine()!;
        switch (userInput)
        {
            case "west":
                room = SHOW_SHADOW_FIGURE;
                break;
            case "east":
                room = SHOW_SKELETONS;
                break;
            case "south":
                room = HAUNTED_ROOM;
                break;
            case "north":
                Console.WriteLine("You find that this door opens into a wall.");
                break;
            default:
                Console.WriteLine(PLEASE_VALID_OPTION);
                break;
        }
    }
}

void ShowShadowFigure()
{
    Console.WriteLine("You see a dark shadowy figure appear in the distance. You are creeped out. Where would you like to go?");
    
    string userInput = "";
    room = UNDEFINED;
    while (room == UNDEFINED)
    {
        Console.WriteLine("Options: north/east/south");
        userInput = Console.ReadLine()!;
        switch (userInput)
        {
            case "north":
                room = CAMERA_SCENE;
                break;
            case "south":
                Console.WriteLine("You find that this door opens into a wall.");
                break;
            case "east":
                room = INTRO_SCENE;
                break;
            default:
                Console.WriteLine(PLEASE_VALID_OPTION);
                break;
        }
    }
}

void CameraScene()
{
    Console.WriteLine("You see a camera that has been dropped on the ground. Someone has been here recently. Where would you like to go?");
    
    string userInput = "";
    room = UNDEFINED;
    while (room == UNDEFINED)
    {
        Console.WriteLine("Options: north/south");
        userInput = Console.ReadLine()!;
        switch (userInput)
        {
            case "north":
                Console.WriteLine(FOUND_EXIT);
                room = EXIT;
                break;
            case "south":
                room = SHOW_SHADOW_FIGURE;
                break;
            default:
                Console.WriteLine(PLEASE_VALID_OPTION);
                break;
        }
    }
}

void HauntedRoom()
{
    Console.WriteLine("You hear strange voices. You think you have awoken some of the dead. Where would you like to go?");
    
    string userInput = "";
    room = UNDEFINED;
    while (room == UNDEFINED)
    {
        Console.WriteLine("Options: north/east/west");
        userInput = Console.ReadLine()!;
        switch (userInput)
        {
            case "west":
                Console.WriteLine("Multiple goul-like creatures start emerging as you enter the room. You are killed.");
                room = EXIT;
                break;
            case "east":
                Console.WriteLine(FOUND_EXIT);
                room = EXIT;
                break;
            case "north":
                room = INTRO_SCENE;
                break;
            default:
                Console.WriteLine(PLEASE_VALID_OPTION);
                break;
        }
    }
}

void ShowSkeletons()
{
    Console.WriteLine("You see a wall of skeletons as you walk into the room. Someone is watching you. Where would you like to go?");
    
    string userInput = "";
    room = UNDEFINED;
    while (room == UNDEFINED)
    {
        Console.WriteLine("Options: north/east/west");
        userInput = Console.ReadLine()!;
        switch (userInput)
        {
            case "north":
                Console.Write("You find that this door opens into a wall.");
                if (!weapon)
                {
                    Console.WriteLine(" You open some of the drywall to discover a knife.");
                }
                else 
                {
                    Console.WriteLine();
                }
                weapon = true;
                userInput = "";
                break;
            case "west":
                room = INTRO_SCENE;
                break;
            case "east":
                room = STRANGE_CREATURE;
                break;
            default:
                Console.WriteLine(PLEASE_VALID_OPTION);
                break;
        }
    }
}

void StrangeCreature()
{
    if (goulAlive)
    {
        Console.WriteLine("A strange goul-like creature has appeared. You can either run or fight it. What would you like to do?");
    }
    else
    {
        Console.WriteLine("You see the goul-like creature that you killed earlier. What a relief! Where would you like to go?");
    }
    
    string userInput = "";
    room = UNDEFINED;
    while (room == UNDEFINED)
    {
        if (goulAlive)
        {
            Console.WriteLine("Options: flee/fight");
        }
        else
        {
            Console.WriteLine("Options: west/south");
        }
        userInput = Console.ReadLine()!;
        switch (userInput)
        {
            case "fight" when goulAlive:
                if (weapon)
                {
                    Console.WriteLine("You kill the goul with the knife you found earlier.");
                    goulAlive = false;
                }
                else 
                {
                    Console.WriteLine("The goul-like creature has killed you.");
                    room = EXIT;
                }
                break;
            case "west" when !goulAlive:
            case "flee" when goulAlive:
                room = SHOW_SKELETONS;
                break;
            case "south" when !goulAlive:
                Console.WriteLine(FOUND_EXIT);
                room = EXIT;
                break;
            default:
                Console.WriteLine(PLEASE_VALID_OPTION);
                break;
        }
    }
}
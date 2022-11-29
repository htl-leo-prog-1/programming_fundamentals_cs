Console.Clear();

double distance;
Console.Write("Type of run? (1) Marathon, (2) Half Marathon, (3) Custom ");
switch (Console.ReadLine()!)
{
    case "1": distance = 42.195; break;
    case "2": distance = 21.0975; break;
    case "3":
        do
        {
            Console.Write("Distance in km? ");
            distance = double.Parse(Console.ReadLine()!);
        }
        while (distance <= 0);
        break;
    default:
        Console.Write("Invalid input");
        return;
}

Console.Write("What is your time goal (in minutes)? ");
double timeGoal = double.Parse(Console.ReadLine()!);

double avgPace = timeGoal / distance;
Console.WriteLine($"Your average pace must be {avgPace} minutes/km.");
if (avgPace <= 2.7)
{
    Console.WriteLine("Warning: You will not be able to run that fast!");
}

bool reachedFinish;
do
{
    Console.Write("Did you already reached the finish (y/n)? ");
    reachedFinish = Console.ReadLine()! == "y";
    if (!reachedFinish)
    {
        double distanceSoFar;
        bool validDistance;
        do
        {
            Console.Write("Distance ran so far? ");
            distanceSoFar = double.Parse(Console.ReadLine()!);
            validDistance = distanceSoFar <= distance;
        }
        while (!validDistance);

        Console.Write("Elapsed time? ");
        double elapsedTime = double.Parse(Console.ReadLine()!);

        double avgPaceRemaining = (timeGoal - elapsedTime) / (distance - distanceSoFar);
        Console.WriteLine($"Your average pace will need to be {avgPaceRemaining} minutes/km.");
    }
}
while (!reachedFinish);

Console.Write("Total time? ");
double totalTime = double.Parse(Console.ReadLine()!);
double avgPaceTotal = totalTime / distance;
Console.WriteLine($"Your average pace was {avgPaceTotal} minutes/km.");


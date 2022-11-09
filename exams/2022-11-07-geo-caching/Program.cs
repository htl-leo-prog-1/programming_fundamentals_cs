// In the following variables we accumulate the total distance
// of all movements. We distinguish horizontal movement (west/east)
// and vertical movement (north/south). We work with floating-point numbers.
double horizontalDistance = 0d, verticalDistance = 0d, totalDistance = 0d;
string direction;

// In a loop, ask the user for movements
do
{
    bool inputIsValid;
    do
    {
        // First, the user enters the direction
        Console.Write("Direction (n/e/s/w) or q for quit? ");
        direction = Console.ReadLine()!;

        // If the user enters an invalid value (e.g. direction *x*, negative distance), 
        // print an error message and keep asking for a correct input until you get one.
        inputIsValid = direction is "n" or "e" or "s" or "w" or "q";
        // The following line would also be ok:
        // inputIsValid = direction == "n" && direction == "e" && direction == "s" && direction == "w" && direction == "q";
        if (!inputIsValid)
        {
            Console.WriteLine("Invalid direction! Try again...");
        }
    }
    while (!inputIsValid);

    // The user enters *q* (for *quit*) when asked for the direction if she has
    // entered all movements.
    if (direction != "q")
    {
        double distance;
        do
        {
            // Next, the user enters the distance in kilometers (e.g. *3* for 3km).
            // The distance is always a positive integer number.
            Console.Write("Distance (>= 0)? ");
            distance = double.Parse(Console.ReadLine()!);

            // If the user enters an invalid value (e.g. direction *x*, negative distance), 
            // print an error message and keep asking for a correct input until you get one.
            inputIsValid = distance >= 0d;
            if (!inputIsValid)
            {
                Console.WriteLine("Invalid distance! Try again...");
            }
        }
        while (!inputIsValid);

        // Aggregate distances.
        // Note that the sign indicates the direction:
        // * Vertically negative means North
        // * Vertically positive means South
        // * Horizontally negative means West
        // * Horizontally positive means East
        totalDistance += distance;
        switch (direction)
        {
            case "n": verticalDistance -= distance; break;
            case "e": horizontalDistance += distance; break;
            case "s": verticalDistance += distance; break;
            case "w": horizontalDistance -= distance; break;
        }
    }

}
while (direction != "q");

// Turn signs of distances into direction names
string horizontalDirection, verticalDirection;
if (horizontalDistance < 0d) { horizontalDirection = "West"; }
else { horizontalDirection = "East"; }
if (verticalDistance < 0d) { verticalDirection = "North"; }
else { verticalDirection = "South"; }

// Print results
Console.Write($"You have to go {Math.Abs(verticalDistance)}km {verticalDirection} ");
Console.WriteLine($"and {Math.Abs(horizontalDistance)}km {horizontalDirection} to find the treasure.");

Console.WriteLine($"You saved yourself a walking distance of {totalDistance - Math.Abs(verticalDistance) - Math.Abs(horizontalDistance)}km!");

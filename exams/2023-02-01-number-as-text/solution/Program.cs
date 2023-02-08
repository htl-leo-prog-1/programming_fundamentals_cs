// input receives the user's input as a string. It will be parsed
// to an int later if the user did not enter "quit".
string input;
do
{
    // Ask the user for a number.
    Console.Write("Enter a number: ");
    input = Console.ReadLine()!;

    // Only process the input if the user did not dcide to "quit".
    if (input != "quit")
    {
        // Parse the input to an int.
        int number = int.Parse(input);

        // Print the number in long text. Note that for demonstration purposes,
        // this code prints the result for each level of the requirements.
        Console.WriteLine($"DigitIntoLongText: {DigitIntoLongText(number)}");
        Console.WriteLine($"NumberIntoLongTextLevel1: {NumberIntoLongTextLevel1(number)}");
        Console.WriteLine($"NumberIntoLongTextLevel2: {NumberIntoLongTextLevel2(number)}");
        Console.WriteLine($"NumberIntoLongTextLevel3: {NumberIntoLongTextLevel3(number)}");
        Console.WriteLine($"NumberIntoLongTextLevel4: {NumberIntoLongTextLevel4(number)}");
        Console.WriteLine($"NumberIntoLongTextLevel5: {NumberIntoLongTextLevel5(number)}");
    }
}
while (input != "quit"); // Stop the loop if the user entered "quit".

string DigitIntoLongText(int number)
{
    // Note the use of a switch expression to turn a digit into a string.
    return number switch
    {
        0 => "zero",
        1 => "one",
        2 => "two",
        3 => "three",
        4 => "four",
        5 => "five",
        6 => "six",
        7 => "seven",
        8 => "eight",
        9 => "nine",
        _ => "not a digit"
    };
}

string NumberIntoLongTextLevel1(int number)
{
    // For numbers less than 10, we can just use the DigitIntoLongText method
    // that we already wrote (see above)
    if (number < 10) { return DigitIntoLongText(number); }

    // Again, we use a switch expression to turn a number into a string.
    return number switch
    {
        10 => "ten",
        11 => "eleven",
        12 => "twelve",
        13 => "thirteen",
        15 => "fifteen",
        18 => "eighteen",
        <= 19 => $"{DigitIntoLongText(number % 10)}teen",
        _ => "not a valid number"
    };
}

string NumberIntoLongTextLevel2(int number)
{
    // For numbers less than 20, we can just use the NumberIntoLongTextLevel1 method
    // that we already wrote (see above).
    if (number < 20) { return NumberIntoLongTextLevel1(number); }

    // Turn the left digit of the number into a string.
    string result = (number / 10) switch
    {
        2 => "twenty",
        3 => "thirty",
        4 => "forty",
        5 => "fifty",
        8 => "eighty",
        _ => $"{DigitIntoLongText(number / 10)}ty"
    };

    // If the right digit is not zero, add it to the result. If the right
    // digit is zero, we don't need to add anything (e.g. "twenty" instead of "twentyzero").
    if (number % 10 != 0)
    {
        result += DigitIntoLongText(number % 10);
    }

    return result;
}

string NumberIntoLongTextLevel3(int number)
{
    // For numbers less than 100, we can just use the NumberIntoLongTextLevel2 method
    // that we already wrote (see above).
    if (number < 100) { return NumberIntoLongTextLevel1(number); }
    if (number > 999) { return "not a valid number"; }

    // Turn the left digit of the number into a string.
    string result = $"{DigitIntoLongText(number / 100)}hundred";

    // If the right number is not zero, add it to the result.
    if (number % 100 != 0)
    {
        result += NumberIntoLongTextLevel2(number % 100);
    }

    return result;
}

string NumberIntoLongTextLevel4(int number)
{
    // For numbers less than 1_000, we can just use the NumberIntoLongTextLevel3 method
    // that we already wrote (see above).
    if (number < 1_000) { return NumberIntoLongTextLevel3(number); }
    if (number > 9_999) { return "not a valid number"; }

    // Turn the left digit of the number into a string.
    string result = $"{DigitIntoLongText(number / 1000)}thousand";

    // If the right number is not zero, add it to the result.
    if (number % 1000 != 0)
    {
        result += NumberIntoLongTextLevel3(number % 1000);
    }

    return result;
}

string NumberIntoLongTextLevel5(int number)
{
    string result = "";
    if (number < 0)
    {
        // If the number is negative, add "minus" to the result and
        // make the number positive.
        result = "minus";
        number *= -1;
    }

    // Convert the now always positive number to a string by using
    // the NumberIntoLongTextLevel4 method that we already wrote (see above).
    return $"{result}{NumberIntoLongTextLevel4(number)}";
}

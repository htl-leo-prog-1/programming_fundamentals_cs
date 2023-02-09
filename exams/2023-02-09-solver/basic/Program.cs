// Note that we add a code block around our main method. All methods
// are OUTSIDE of this code block. That means that the methods
// cannot access the variables of our main method. This is considered
// to be good practice in C#.
//
// Note that once you have more experience, you do not need the explicit 
// code block anymore. You will automatically avoid global variables.
// From now on, you MUST write code like this to learn how to avoid
// global variables.
{
    // Ask the user to enter a formula, e.g. 1+2-3+4-5
    Console.Write("Enter a formula: ");
    var formula = Console.ReadLine()!;

    // Evaluate the formula
    var result = Evaluate(formula);
    Console.WriteLine($"The result is {result}");
}

int Evaluate(string formula)
{
    // The result is initially 0
    var result = 0;

    // Remove all spaces from the formula
    formula = formula.Replace(" ", "");
    if (formula == "")
    {
        // According to the specification, the result of an empty formula is 0
        return 0;
    }

    // Op is the operator that will be applied to the next number.
    // In this case, we are modifying the value of the formula parameter if the
    // formula starts with a minus (e.g. "-10+20") or a plus (e.g. "+10-20").
    char op = '+';
    if (formula[0] is '+' or '-')
    {
        op = formula[0];
        formula = formula.Substring(1);
    }

    // We evaluate the formula from left to right. We look for the next
    // operator, and then we evaluate the left side of the operator.
    // indexOfNextOperator will be the index of the next operator
    // inside the formula string. If there is no next operator, it will be -1.
    int indexOfNextOperator;
    do
    {
        // Find next operator.
        indexOfNextOperator = FindIndexOfNextOperator(formula);
        if (indexOfNextOperator == -1)
        {
            // There is no next operator. The rest of the formula is the last number.
            // Therefore, we try to aggregate the last number with the result.
            result = Aggregate(result, op, formula);
        }
        else
        {
            // There is a next operator. The left side of the operator 
            // is the next number. Example: If formula was "10+20-30", 
            // the left side of the first operator is "10".
            var left = formula.Substring(0, indexOfNextOperator);

            // Try to aggregate the next number with the result.
            result = Aggregate(result, op, left);

            // The next operator will be applied to the next number.
            op = formula[indexOfNextOperator];

            // Remove the left side of the operator and the operator 
            // itself from the formula. Example: If formula was "10+20-30" before,
            // it will be "20-30" after the next line.
            formula = formula.Substring(indexOfNextOperator + 1);
        }
    }
    while (indexOfNextOperator != -1);

    return result;
}

int FindIndexOfNextOperator(string formula)
{
    // Find the index of the next operator. If there is no next operator,
    // return -1.
    var indexOfPlus = formula.IndexOf('+');
    var indexOfMinus = formula.IndexOf('-');
    if (indexOfPlus == -1) { return indexOfMinus; }
    if (indexOfMinus == -1) { return indexOfPlus; }
    return Math.Min(indexOfPlus, indexOfMinus);
}

int Aggregate(int result, char op, string numberAsString)
{
    var number = int.Parse(numberAsString);

    // Apply the operator to the result and the number
    switch (op)
    {
        case '-': result -= number; break;
        default: result += number; break;
    }

    return result;
}

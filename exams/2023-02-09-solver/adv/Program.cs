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
    // Note the use of an out parameter here. This is a common pattern in C#.
    // It allows us to return a value and an error code at the same time.
    // In this case, the error code is a boolean. If the formula is valid, the
    // result will be set to the result of the formula, and the method will
    // return true. If the formula is invalid, the result will be set to 0, and
    // the method will return false.
    //
    //  ↓ return value       ↓ out parameter
    if (TryEvaluate(formula, out var result))
    {
        Console.WriteLine($"The result is {result}");
    }
    else
    {
        Console.WriteLine("Invalid formula");
    }
}

bool TryEvaluate(string formula, out int result)
{
    // The result is initially 0
    result = 0;

    // Remove all spaces from the formula
    formula = formula.Replace(" ", "");
    if (formula == "")
    {
        // According to the specification, the result of an empty formula is 0
        return true;
    }

    // Op is the operator that will be applied to the next number.
    // Note that we are using a ref parameter here. This is a common pattern
    // in C#. It allows us to modify the value of a parameter inside a method.
    // In this case, we are modifying the value of the formula parameter if the
    // formula starts with a minus (e.g. "-10+20") or a plus (e.g. "+10-20").
    //
    //       ↓ return value     ↓ ref parameter
    var op = GetInitialOperator(ref formula);

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
            // Note that we are using a ref parameter again. It means that
            // TryAggregate can modify the value of the result parameter AND 
            // return a value indicating success or failure at the same time.
            //
            //   ↓ return value   ↓ ref parameter
            if (!TryAggregate(ref result, op, formula)) { return false; }
        }
        else
        {
            // There is a next operator. The left side of the operator 
            // is the next number. Example: If formula was "10+20-30", 
            // the left side of the first operator is "10".
            var left = formula.Substring(0, indexOfNextOperator);

            // Try to aggregate the next number with the result.
            // Note the ref parameter again!
            if (!TryAggregate(ref result, op, left)) { return false; }

            // The next operator will be applied to the next number.
            op = formula[indexOfNextOperator];

            // Remove the left side of the operator and the operator 
            // itself from the formula. Example: If formula was "10+20-30" before,
            // it will be "20-30" after the next line.
            formula = formula.Substring(indexOfNextOperator + 1);
        }
    }
    while (indexOfNextOperator != -1);

    // If we reach this point, the formula is valid.
    return true;
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

char GetInitialOperator(ref string formula)
{
    char op;
    if (formula.StartsWith("-"))
    {
        // If the formula starts with a minus (e.g. "-10+20"), we need 
        // to apply the minus operator to the first number.
        op = '-';

        // Remove the minus from the formula. We have already remembered
        // that we need to apply the minus operator to the first number.
        formula = formula.Substring(1);
    }
    else
    {
        // If the formula does not start with a minus, we need to apply
        // the plus operator to the first number.
        op = '+';

        // If the formula starts with a plus (e.g. "+10-20"), we can remove it.
        // We have already remembered that we need to apply the plus operator
        // to the first number.
        if (formula.StartsWith("+")) { formula = formula.Substring(1); }
    }

    return op;
}

bool TryAggregate(ref int result, char op, string numberAsString)
{
    // Note that in this exercise we do NOT use int.Parse. Instead, we use
    // int.TryParse. TryParse does not only give us the number, but also
    // tells us if the string was a valid number or not. If the string was
    // not a valid number, TryParse will return false, and we will return
    // false from this method as well.
    //
    //   ↓ return value               ↓ out parameter
    if (!int.TryParse(numberAsString, out var number))
    {
        return false;
    }

    // Apply the operator to the result and the number
    switch (op)
    {
        case '-': result -= number; break;
        case '+': result += number; break;
        default:
            // If the operator is neither a minus nor a plus, the formula is invalid.
            return false;
    }

    // If we reach this point, the formula is valid.
    return true;
}

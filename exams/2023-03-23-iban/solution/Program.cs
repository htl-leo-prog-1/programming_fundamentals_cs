// If we have less than two arguments, we have an error, independent of the command.
if (args.Length < 2)
{
    Console.WriteLine("Too few arguments");
    return;
}

switch (args[0])
{
    case "build":
        PerformBuildCommand();
        break;
    case "analyze":
        PerformAnalyzing();
        break;
    default:
        Console.WriteLine("Invalid command, must be 'build' or 'analyze'");
        break;
}

void PerformBuildCommand()
{
    // The "build" command requires three arguments
    if (args.Length != 3)
    {
        Console.WriteLine("Too few arguments");
        return;
    }

    if (args[1].Length != 4)
    {
        Console.WriteLine("Bank code has wrong length, must contain 4 digits");
        return;
    }

    if (!IsOnlyDigits(args[1]))
    {
        Console.WriteLine("Bank code must only contain digits");
        return;
    }

    if (args[2].Length != 6)
    {
        Console.WriteLine("Account number has wrong length, must contain 6 digits");
        return;
    }

    if (!IsOnlyDigits(args[2]))
    {
        Console.WriteLine("Account number must only contain digits");
        return;
    }

    Console.WriteLine(BuildIban(args[1], args[2]));
}

void PerformAnalyzing()
{
    // The "analyze" command requires two arguments
    if (args.Length != 2)
    {
        Console.WriteLine("Too few arguments");
        return;
    }

    if (args[1].Length != 15)
    {
        Console.WriteLine("Wrong length of IBAN");
        return;
    }

    if (!args[1].StartsWith("NO"))
    {
        Console.WriteLine("Wrong country code, we currently only support 'NO'");
        return;
    }

    if (!IsOnlyDigits(args[1].Substring(2)))
    {
        Console.WriteLine("IBAN contains invalid characters");
        return;
    }

    if (args[1][14] != '7')
    {
        Console.WriteLine("Wrong national check digit, we currently only support '7'");
        return;
    }

    if (!AnalyzeIban(args[1], out string bankCode, out string accountNumber))
    {
        Console.WriteLine("Invalid checksum");
        return;
    }

    Console.WriteLine($"Bank code: {bankCode}");
    Console.WriteLine($"Account number: {accountNumber}");
}

/// <summary>
/// Analyzes an IBAN and returns the bank code and account number
/// </summary>
/// <param name="iban">The IBAN to analyze</param>
/// <param name="bankCode">The bank code</param>
/// <param name="accountNumber">The account number</param>
/// <returns>True if the IBAN is valid, false otherwise</returns>
bool AnalyzeIban(string iban, out string bankCode, out string accountNumber)
{
    bankCode = iban.Substring(4, 4);
    accountNumber = iban.Substring(8, 6);

    long mod = CalculateModulus(bankCode, accountNumber, int.Parse(iban.Substring(2, 2)));
    return mod == 1;
}

/// <summary>
/// Builds an IBAN from a bank code and an account number
/// </summary>
string BuildIban(string bankCode, string accountNumber)
{
    return $"NO{CalculateChecksum(bankCode, accountNumber)}{bankCode}{accountNumber}7";
}

/// <summary>
/// Checks if a string only contains digits
/// </summary>
/// <param name="input">The string to check</param>
/// <returns>True if the string only contains digits, false otherwise</returns>
bool IsOnlyDigits(string input)
{
    for (int i = 0; i < input.Length; i++)
    {
        if (!char.IsDigit(input[i]))
        {
            return false;
        }
    }
    return true;
}

/// <summary>
/// Calculates the checksum for a bank code and an account number
/// </summary>
long CalculateChecksum(string bankCode, string accountNumber)
{
    return 98 - CalculateModulus(bankCode, accountNumber);
}

/// <summary>
/// Calculates the modulus for a bank code, an account number and a checksum
/// </summary>
long CalculateModulus(string bankCode, string accountNumber, int checksum = 0)
{
    long result = long.Parse(bankCode) % 97;
 
    result *= Power(6);
    result += long.Parse(accountNumber);
    result %= 97;
 
    result *= 10;
    result += 7;
    result %= 97;
 
    result *= Power(4);
    result += 2324;
    result %= 97;
 
    result *= Power(2);
    result += checksum;
    result %= 97;
 
    return result;
}

/// <summary>
/// Calculates 10 to the power of exponent
/// </summary>
long Power(int exponent)
{
    long result = 1;
    for (int i = 0; i < exponent; i++)
    {
        result *= 10;
    }
    return result;
}
double resistorValue, tolerance;
if (args[0].Length != 15 && args[0].Length != 19)
{
    Console.WriteLine("Invalid input length. Please provide 4 or 5 color bands.");
    return;
}

if (args[0][3] != '-' || args[0][7] != '-' || args[0][11] != '-' || (args[0].Length == 19 && args[0][15] != '-'))
{
    Console.WriteLine("Invalid input format. Please use a hyphen (-) to separate color codes.");
    return;
}

if (args[0].Length == 15)
{
    Get4Colors(args[0], out string band1, out string band2, out string band3, out string band4);
    if (!TryDecode4ColorBands(band1, band2, band3, band4, out resistorValue, out tolerance)) { return; }
}
else
{
    Get5Colors(args[0], out string band1, out string band2, out string band3, out string band4, out string band5);
    if (!TryDecode5ColorBands(band1, band2, band3, band4, band5, out resistorValue, out tolerance)) { return; }
}
Console.WriteLine($"Resistor value: {resistorValue} Ohms, tolerance: {tolerance}%");

void Get4Colors(string input, out string band1, out string band2, out string band3, out string band4)
{
    band1 = input.Substring(0, 3);
    band2 = input.Substring(4, 3);
    band3 = input.Substring(8, 3);
    band4 = input.Substring(12, 3);
}

void Get5Colors(string input, out string band1, out string band2, out string band3, out string band4, out string band5)
{
    band1 = input.Substring(0, 3);
    band2 = input.Substring(4, 3);
    band3 = input.Substring(8, 3);
    band4 = input.Substring(12, 3);
    band5 = input.Substring(16, 3);
}

bool TryConvertColorToDigit(string resistorColor, out double resistorValue)
{
    switch (resistorColor)
    {
        case "Bla": resistorValue = 0; break;
        case "Bro": resistorValue = 1; break;
        case "Red": resistorValue = 2; break;
        case "Ora": resistorValue = 3; break;
        case "Yel": resistorValue = 4; break;
        case "Gre": resistorValue = 5; break;
        case "Blu": resistorValue = 6; break;
        case "Vio": resistorValue = 7; break;
        case "Gra": resistorValue = 8; break;
        case "Whi": resistorValue = 9; break;
        default: resistorValue = -1; return false;
    }

    return true;
}

bool TryGetMultiplierFromColor(string multiplierColor, out double multiplier)
{
    switch (multiplierColor)
    {
        case "Bla": multiplier = 1; break;
        case "Bro": multiplier = 10; break;
        case "Red": multiplier = 100; break;
        case "Ora": multiplier = 1_000; break;
        case "Yel": multiplier = 10_000; break;
        case "Gre": multiplier = 100_000; break;
        case "Blu": multiplier = 1_000_000; break;
        case "Vio": multiplier = 10_000_000; break;
        case "Gra": multiplier = 100_000_000; break;
        case "Whi": multiplier = 1_000_000_000; break;
        case "Gol": multiplier = 0.1; break;
        case "Sil": multiplier = 0.01; break;
        default: multiplier = -1; return false;
    }

    return true;
}

bool TryGetToleranceFromColor(string toleranceColor, out double tolerance)
{
    switch (toleranceColor)
    {
        case "Bro": tolerance = 1; break;
        case "Red": tolerance = 2; break;
        case "Gre": tolerance = 0.5; break;
        case "Blu": tolerance = 0.25; break;
        case "Vio": tolerance = 0.1; break;
        case "Gra": tolerance = 0.05; break;
        case "Gol": tolerance = 5; break;
        case "Sil": tolerance = 10; break;
        default: tolerance = -1; return false;
    }

    return true;
}

bool TryDecode4ColorBands(string band1, string band2, string band3, string band4, out double resistorValue, out double tolerance)
{
    double firstDigit, secondDigit, multiplier;
    if (!TryConvertColorToDigit(band1, out firstDigit) || !TryConvertColorToDigit(band2, out secondDigit)
        || !TryGetMultiplierFromColor(band3, out multiplier) || !TryGetToleranceFromColor(band4, out tolerance))
    {
        Console.WriteLine("Invalid color code. Please use valid color codes.");
        resistorValue = -1;
        tolerance = -1;
        return false;
    }

    resistorValue = (firstDigit * 10 + secondDigit) * multiplier;
    return true;
}

bool TryDecode5ColorBands(string band1, string band2, string band3, string band4, string band5, out double resistorValue, out double tolerance)
{
    double firstDigit, secondDigit, thirdDigit, multiplier;
    if (!TryConvertColorToDigit(band1, out firstDigit) || !TryConvertColorToDigit(band2, out secondDigit)
        || !TryConvertColorToDigit(band3, out thirdDigit) || !TryGetMultiplierFromColor(band4, out multiplier)
        || !TryGetToleranceFromColor(band5, out tolerance))
    {
        Console.WriteLine("Invalid color code. Please use valid color codes.");
        resistorValue = -1;
        tolerance = -1;
        return false;
    }

    resistorValue = (firstDigit * 100 + secondDigit * 10 + thirdDigit) * multiplier;
    return true;
}
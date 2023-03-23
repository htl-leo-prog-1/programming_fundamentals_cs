double resistorValue, tolerance;
if (args[0].Length == 15)
{
    Get4Colors(args[0], out string band1, out string band2, out string band3, out string band4);
    Decode4ColorBands(band1, band2, band3, band4, out resistorValue, out tolerance);
}
else
{
    Get5Colors(args[0], out string band1, out string band2, out string band3, out string band4, out string band5);
    Decode5ColorBands(band1, band2, band3, band4, band5, out resistorValue, out tolerance);
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

double ConvertColorToDigit(string resistorColor)
{
    return resistorColor switch
    {
        "Bla" => 0,
        "Bro" => 1,
        "Red" => 2,
        "Ora" => 3,
        "Yel" => 4,
        "Gre" => 5,
        "Blu" => 6,
        "Vio" => 7,
        "Gra" => 8,
        "Whi" => 9,
        _ => -1
    };
}

double GetMultiplierFromColor(string multiplierColor)
{
    return multiplierColor switch
    {
        "Bla" => 1,
        "Bro" => 10,
        "Red" => 100,
        "Ora" => 1_000,
        "Yel" => 10_000,
        "Gre" => 100_000,
        "Blu" => 1_000_000,
        "Vio" => 10_000_000,
        "Gol" => 0.1,
        "Sil" => 0.01,
        _ => -1
    };
}

double GetToleranceFromColor(string toleranceColor)
{
    return toleranceColor switch
    {
        "Bro" => 1,
        "Red" => 2,
        "Gre" => 0.5,
        "Blu" => 0.25,
        "Vio" => 0.1,
        "Gra" => 0.05,
        "Gol" => 5,
        "Sil" => 10,
        _ => -1
    };
}

double Decode4ColorBands(string band1, string band2, string band3, string band4, out double resistorValue, out double tolerance)
{
    resistorValue = ConvertColorToDigit(band1) * 10 + ConvertColorToDigit(band2);
    resistorValue *= GetMultiplierFromColor(band3);
    tolerance = GetToleranceFromColor(band4);
    return resistorValue;
}

void Decode5ColorBands(string band1, string band2, string band3, string band4, string band5, out double resistorValue, out double tolerance)
{
    resistorValue = ConvertColorToDigit(band1) * 100 + ConvertColorToDigit(band2) * 10 + ConvertColorToDigit(band3);
    resistorValue *= GetMultiplierFromColor(band4);
    tolerance = GetToleranceFromColor(band5);
}
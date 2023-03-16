# Resistor Color Code Decoder

## Introduction

Create a command line application in C# that decodes [color bands on resistors](https://www.electronics-tutorials.ws/resistor/res_2.html) and calculates the resistor value and tolerance.

Here is an image illustrating how to calculate resistor values and tolerances from color bands:

![Resistor value calculation](https://www.digikey.at/-/media/Images/Marketing/Resources/Calculator/resistor-color-chart.png?la=en-AT&ts=4db603f5-4e9b-4759-84b7-21a04d18b1a8)

Here are the values for each color as a table:

| Color  | Digit |    Multiplier | Tolerance |
| ------ | ----: | ------------: | --------: |
| Black  |     0 |             1 |           |
| Brown  |     1 |            10 |       ±1% |
| Red    |     2 |           100 |       ±2% |
| Orange |     3 |         1,000 |           |
| Yellow |     4 |        10,000 |           |
| Green  |     5 |       100,000 |     ±0.5% |
| Blue   |     6 |     1,000,000 |    ±0.25% |
| Violet |     7 |    10,000,000 |     ±0.1% |
| Gray   |     8 |   100,000,000 |    ±0.05% |
| White  |     9 | 1,000,000,000 |           |
| Gold   |       |           0.1 |       ±5% |
| Silver |       |          0.01 |      ±10% |

You can decode color bands [with an online resistor calculator](https://www.digikey.at/en/resources/conversion-calculators/conversion-calculator-resistor-color-code).

## Level 0: Basic Requirements

* Handle only resistors with 4 color bands.
* Read the color bands as a command line argument (e.g., `Gre-Blu-Yel-Gol` for Green, Blue, Yellow, and Gold).
* Decode the color bands using the standard resistor color code chart (see above).
* Calculate the resistance value and tolerance of the resistor.
* Display the result to the user.
* No error handling necessary (will be added later)

Implement the following methods as part of your solution:

* `ConvertColorToDigit`: Receives a color (e.g. `Gre` for green) and returns the corresponding digit.
* `GetMultiplierFromColor`: Works similarly to `ConvertColorToDigit`, but returns the multiplier instead of the digit.
* `GetToleranceFromColor`: Works similarly to `ConvertColorToDigit`, but outputs the tolerance instead of the digit.
* `Decode4ColorBands`: Receives 4 colors as input parameters and outputs the corresponding resistor value and tolerance.
  * Tip: Use `out` parameters to output both resistor value and tolerance.

### Example 1

* Input: `Bro-Blu-Ora-Gol`
* Expected outcome:
  * Resistance: 16,000Ω
  * Tolerance: ±5%
* Explanation: Brown (1), Blue (6), Orange (x10^3 multiplier), Gold (±5% tolerance)

### Example 2

* Input: `Red-Gre-Bro-Sil`
* Expected outcome:
  * Resistance: 250Ω
  * Tolerance: ±10%
* Explanation: Red (2), Green (5), Brown (x10^1 multiplier), Silver (±10% tolerance)

## Level 1: Resistors With Five Bands

* Add support for resistors with 5 color bands.
* Automatically recognize the number of color bands provided as input (tip: Check the length of the command line argument).
* Adjust your code to handle both 4 and 5 color band resistors.

Add the following method as part of your solution:

* `Decode5ColorBands`: Receives 5 colors as input parameters and outputs the corresponding resistor value and tolerance.

### Example 3

* Input: `Yel-Vio-Blu-Gre-Bro`
* Expected outcome:
  * Resistance: 47,600,000Ω
  * Tolerance: ±1%
* Explanation: Yellow (4), Violet (7), Blue (6), Green (x10^5 multiplier), Brown (±1% tolerance)

### Example 4

* Input: `Whi-Gre-Ora-Gol-Sil`
* Expected outcome:
  * Resistance: 95.3Ω
  * Tolerance: ±10%
* Explanation: White (9), Green (5), Orange (3), Gold (x10^-1 multiplier), Silver (±10% tolerance)

## Level 2: Error Handling

* Add proper error handling that prints a meaningful error message in case of structurally wrong input or wrong colors.
* Display a meaningful error message if the input format is incorrect or unsupported.
* Test your application thoroughly to ensure it works correctly for both 4-band and 5-band resistors.

Change the existing methods to the `Try...`-pattern as part of your solution:

* `TryConvertColorToDigit`: Receives a color (e.g. `Gr` for green) and outputs the corresponding digit. If the color is unknown or has no assigned digit (e.g. gold), the method returns `false`, otherwise true.
* `TryGetMultiplierFromColor`: Works similarly to `TryConvertColorToDigit`, but outputs the multiplier instead of the digit.
* `TryGetToleranceFromColor`: Works similarly to `TryConvertColorToDigit`, but outputs the tolerance instead of the digit.
* `TryDecode4ColorBands`: Receives 4 colors as input parameters and outputs the corresponding resistor value and tolerance. If one of the colors is invalid, the method returns `false`, otherwise true.
* `TryDecode5ColorBands`: Receives 5 colors as input parameters and outputs the corresponding resistor value and tolerance. If one of the colors is invalid, the method returns `false`, otherwise true.

### Example 5

* Input: `Bro-Blu`
* Error message: *Invalid input length. Please provide 4 or 5 color bands.*
* Explanation: This input contains only 2 color bands, while the program expects 4 or 5 color bands.

### Example 6

* Input: `Bro-Blu-Ora-Pin-Gol`
* Error message: *Invalid color code. Please use valid color codes.*
* Explanation: This input contains an invalid color code 'Pin' (Pink), which is not part of the resistor color code chart.

### Example 7

* Input: `Bro-Blu-OraGol-`
* Error message: *Invalid input format. Please use a hyphen (-) to separate color codes.*
* Explanation: This input is missing a hyphen between 'Ora' (Orange) and 'Gol' (Gold), which makes it difficult to parse the color bands correctly.

### Example 8

* Input: `Bro-Blu-Gol-Gol-Sil`
* Error message: *Invalid color code. Please use valid color codes.*
* Explanation: This input has Gold as one of the significant digit or multiplier bands, which is not valid according to the resistor color code chart.

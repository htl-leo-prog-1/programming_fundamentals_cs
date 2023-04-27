# <span translate="no">Arrays</span>

![Array Index Start at Zero](https://media.makeameme.org/created/array-index-start.jpg)


## What Are Arrays?

* Arrays <!-- .element: class="fragment" --> can **store multiple variables** of the same type.
* The <!-- .element: class="fragment" --> **length** of an array is **fixed**.
  * Once created, the length of an array cannot change
  * You can change the value of each item in the array, but you cannot add or remove values
* There <!-- .element: class="fragment" --> are single-dimensional, multi-dimensional, and jagged arrays in C#
  * We will start with single-dimensional arrays, you will learn about other arrays later
* Read <!-- .element: class="fragment" --> [more](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/)
  * ⚠️ This documentation requires quite a bit of base knowledge about programming.
  * It's not particularly beginner-friendly. Once you will have gotten more experience, it will be a good reference.


## Working With Arrays

### Declare <!-- .element: class="fragment" --> Variable As Array

```cs
int[] numbers; // Array of integers
float[] floatingPointNumbers; // Array of floats
string[] words; // Array of strings
```
<!-- .element: class="fragment" -->

### Creating <!-- .element: class="fragment" --> Arrays

```cs
int[] numbers;
numbers = new int[5]; // Creates an array that can hold five integers.
                      // Note: By default, all values are zero.

// or shorter:
var numbers = new int[5];
```
<!-- .element: class="fragment" -->


## Working With Arrays

### Initialize <!-- .element: class="fragment" --> Array

```cs
var numbers = new int[] { 1, 2, 3, 4, 5 }; // Array of five integers with given initial values
var words = new string[] { "the", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };
```
<!-- .element: class="fragment" -->

### Access <!-- .element: class="fragment" --> Array Values

> Array index **starts at zero, not 1**
<!-- .element: class="fragment" -->

```cs
var words = new string[] { "the", "quick", "red", "fox", "jumps", "over", "the", "lazy", "dog" };
Console.WriteLine(words[0]); // Prints "the"
words[2] = "brown"; // Sets third element of array to "brown"
Console.WriteLine(words[2]); // Prints "brown"
```
<!-- .element: class="fragment" -->


## Important &nbsp;<span translate="no">Array</span>-Functions and Properties

> Full list see [`Array` documentation](https://docs.microsoft.com/en-us/dotnet/api/system.array)

| Function/Property | Description |
|---|---|
| <span translate="no">[Length](https://docs.microsoft.com/en-us/dotnet/api/system.array.length?view=net-6.0)</span> | Returns length of the array |
| <span translate="no">[Array.IndexOf](https://docs.microsoft.com/en-us/dotnet/api/system.array.indexof), [Array.LastIndexOf](https://docs.microsoft.com/en-us/dotnet/api/system.array.lastindexof?view=net-6.0)</span> | Returns index of given value in the array |
| <span translate="no">[Array.Sort](https://docs.microsoft.com/en-us/dotnet/api/system.array.sort)</span> | Sorts the array |


## Example: Random Numbers

* Requirements:
  * Create 10 random numbers between 1 and 100 (inclusive)
  * Store the random numbers in an array
  * Sort the array ascending
  * Print all numbers in the sorted array

```cs[|1-2|4-8|10|12-16]
// Declare array, all elements will be set to zero
var randomNumbers = new int[10];

// Fill array with random numbers
for(var i = 0; i < randomNumbers.Length; i++)
{
    randomNumbers[i] = Random.Shared.Next(1, 101); // Set value of array element 
}

Array.Sort(randomNumbers); // Sort array

// Print all numbers
for(var i = 0; i < randomNumbers.Length; i++)
{
    Console.WriteLine(randomNumbers[i]); // Get value of array element
}
```
<!-- .element: class="fragment" -->


## Example: Statistical Analyzer

* Let <!-- .element: class="fragment" --> the user enter 15 numbers
  * Store the numbers in an array
* Calculate <!-- .element: class="fragment" --> and print the following values for all entered numbers<br/>(in this case, use of existing functions of .NET is not allowed):
  * Level 1
    * Sum
    * Minimum
    * Maximum
  * Level 2
    * [Arithmetic mean](https://en.wikipedia.org/wiki/Arithmetic_mean) (aka *average*)
    * [Median](https://en.wikipedia.org/wiki/Median)
  * Level 3
    * [Standard deviation](https://en.wikipedia.org/wiki/Standard_deviation)


## Example: It is Freezing Cold 🥶

* You <!-- .element: class="fragment" --> got a list of temperature readings recorded by a temperature sensor
  * -8, -6, 9, 18, 19, 12, -18, 3, -10, 21, 8, 20, 32, -13, 24, 5, 13, -14, 29, 7, -12, 17, 1, 33, -19, -9, 31, 34, 14, -4, -17, -7, 22, 6, 26, -11, -1, -3, 25, 10, -15, -16, 23, -2, 30, 15, 28, 35, 11, 16
* Store <!-- .element: class="fragment" --> the temperature readings in an array and print the temperature(s) closest to zero
  * If multiple values have the same distance to zero (e.g. 1 and -1), print all of them


## Example: Stock Wins/Losses 📈📉

* Here <!-- .element: class="fragment" --> are the stock prices for *GOOG* (Google) between Aug. 1st and Aug. 29th (closing values, without weekends) in chronological order ([source](https://www.wsj.com/market-data/quotes/GOOG/historical-prices))
  * 110.34, 111.30, 117.70, 114.70, 114.77, 115.07, 118.12, 120.86, 120.32, 122.51, 122.88, 122.65, 119.82, 120.65, 117.50, 118.14, 118.22, 118.87, 118.78, 115.90, 115.48
* Store <!-- .element: class="fragment" --> the stock prices in an array
* Find <!-- .element: class="fragment" --> out and print the *highest day-to-day loss* and *highest day-to-day win*
  * Example: Day-to-day win between day 0 and 1 is *111.30 - 110.34* which results in a win of *0.96*
  * Example: Day-to-day loss between day 2 and 3 is *114.70 - 117.70* which results in a loss of *3.0*


## Pro Tips

![Damn I'm good](https://c.tenor.com/sZI62CeEK8QAAAAC/robert-downey-jr-iron-man.gif)


## Splitting Strings

* You <!-- .element: class="fragment" --> can **split a string into an array**
  * Example: Get all words of *the quick brown fox jumps over the lazy dog* by splitting it by space
* Use <!-- .element: class="fragment" --> the [`String.Split`](https://docs.microsoft.com/en-us/dotnet/api/system.string.split) function

```cs[|2-4]
string source = "the quick brown fox jumps over the lazy dog";
                              ┌─────┐◄───────────── Split character
string[] words = source.Split(│ ' ' │);
                              └─────┘ 
Console.WriteLine($"The sentence has {words.Length} words");
Console.WriteLine("The words are");
for (var i = 0; i < words.Length; i++)
{
  Console.WriteLine($"\t- {words[i]}");
}
```
<!-- .element: class="fragment" -->


## Example: Statistical Analyzer

* Enhance the [*Statistical Analyzer*](#/10/6/1) you built before
* This time, let the user enter **as many numbers as she wants in a single line of text**
  * Numbers are separated using comma (*,*)
  * Example: `10,302,964,889,175,264,495,994,903,851,980,784,156,656,718`
* Do the same calculations as in the original *Statistical Analyzer*

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


## Example: CO² Chart

```txt
1946: 12.760.137 ######
1947: 17.630.039 ########
1948: 24.487.263 ############
1949: 26.574.257 #############
1950: 20.894.256 ##########
1951: 23.264.090 ###########
1952: 22.069.984 ###########
1953: 21.714.546 ##########
1954: 24.505.593 ############
1955: 29.069.986 ##############
...
1985: 54.366.320 ###########################
1986: 53.728.532 ##########################
2006: 76.796.491 ######################################
2007: 74.096.973 #####################################
2008: 73.472.267 ####################################
2009: 67.290.760 #################################
2010: 72.000.290 ####################################
2011: 69.888.739 ##################################
2012: 67.263.274 #################################
2013: 67.758.606 #################################
2014: 64.160.937 ################################
2015: 66.351.619 #################################
2016: 67.215.457 #################################
2017: 69.598.854 ##################################
2018: 66.565.408 #################################
2019: 67.962.416 #################################
2020: 60.634.876 ##############################
```


## Example: CO² Chart

* On <!-- .element: class="fragment" --> the next slide, you find Austria's CO² emissions in tons since 1946
  * [Source](https://ourworldindata.org/co2/country/austria)
  * Copy the data and put it into a *verbatim string* (`@"..."`)
  * Reason: Verbatim strings can contain multiple lines
* Split <!-- .element: class="fragment" --> the data into lines
  * Use `co2Data.Split('\n')`
  * ⚠️ Consider end of line sequence of *.cs* file
* For <!-- .element: class="fragment" --> each line:
  * Create <!-- .element: class="fragment" --> a separate method for processing each line
  * Split <!-- .element: class="fragment" --> each line into year and CO² emission
    * Use `line.Split(',')`
  * Convert <!-- .element: class="fragment" --> second array element into number
    * ⚠️ Don't use `int` for emissions as they are high numbers, use `long` instead ([read more](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types))
    * Use `long.Parse(data[1])`
  * Print <!-- .element: class="fragment" --> the year, the CO² emission as a number and a bar indicating the emission
    * For 80 million tons, the bar should have a length of 40 characters
    * Calculate length of bar for each CO² emission value: `long barLength = co2 * 40 / 80_000_000;`
    * 🔥 Tip: Generate a string with a repeated character: `string bar = new string('#', barLength);`


## Example: CO² Chart

[![](https://mermaid.ink/img/pako:eNp1U1Fv2jAQ_isn7wWmtEDoKEXaJo32jbaTmDRtCZqMc0msOXbkODCE-O87GwJs2h4Sn----77z-bxnwmTIZixXZitKbh18eUw1wNKR3UvCsurDzc0HWNZKuiT8oXFW6gK20pWQccfTVEvtDHBr-e7oVlJjswpcIcVTLHjjFuSflyh--tAfjv2LgcpYPKZ-PFAK7LAJmU86e80XxtS9HplgLCnW1hSWV_3-f5kIdMWlTaD6bI3ApvHgJDltguQqVHsVDvAX_BWIk2ezQaAzanIc8R7ehf99viuyZ3Tl33qXvgaFY6N8CHw3qfodcgucDjx_jS-9POvNjd6gdclp9ajuJnRbrdGGnC7qMz5xu0BdUClzrkSruENYk4YKTkpedwB4D8LE8BbuhjCA6fDHcBi-QHmmOXWUJL9RqclXK4nQm5EvJiJCX_0b8LPFhUMLFwEnq9OEnAkud-3bFe6632cRq9BWXGY0qHuPT5krscKUzcjM6aIbl7LoFAkbHyhRKQNbY1WWslQfiKetaVrxKZPOWDZztsWI8daZ5U6Lbn_EPEruh6tzKsMzpJQ9c7vaP5hCNo4IhdG5LLy_tYrcpXN1MxsMfPi2oHfQrm-FqQaNzPzrKjcPk8Eknkx5PMbJ_Zi_G48zsR49TPP4bpRn98NRzNnhELGa6-_GkH7OVYOH34ZePjU)](https://mermaid.live/edit#pako:eNp1U1Fv2jAQ_isn7wWmtEDoKEXaJo32jbaTmDRtCZqMc0msOXbkODCE-O87GwJs2h4Sn----77z-bxnwmTIZixXZitKbh18eUw1wNKR3UvCsurDzc0HWNZKuiT8oXFW6gK20pWQccfTVEvtDHBr-e7oVlJjswpcIcVTLHjjFuSflyh--tAfjv2LgcpYPKZ-PFAK7LAJmU86e80XxtS9HplgLCnW1hSWV_3-f5kIdMWlTaD6bI3ApvHgJDltguQqVHsVDvAX_BWIk2ezQaAzanIc8R7ehf99viuyZ3Tl33qXvgaFY6N8CHw3qfodcgucDjx_jS-9POvNjd6gdclp9ajuJnRbrdGGnC7qMz5xu0BdUClzrkSruENYk4YKTkpedwB4D8LE8BbuhjCA6fDHcBi-QHmmOXWUJL9RqclXK4nQm5EvJiJCX_0b8LPFhUMLFwEnq9OEnAkud-3bFe6632cRq9BWXGY0qHuPT5krscKUzcjM6aIbl7LoFAkbHyhRKQNbY1WWslQfiKetaVrxKZPOWDZztsWI8daZ5U6Lbn_EPEruh6tzKsMzpJQ9c7vaP5hCNo4IhdG5LLy_tYrcpXN1MxsMfPi2oHfQrm-FqQaNzPzrKjcPk8Eknkx5PMbJ_Zi_G48zsR49TPP4bpRn98NRzNnhELGa6-_GkH7OVYOH34ZePjU)



## Data For CO² Chart

```txt
1946,12760137
1947,17630039
1948,24487263
1949,26574257
1950,20894256
1951,23264090
1952,22069984
1953,21714546
1954,24505593
1955,29069986
1956,28204984
1957,29178806
1958,28086845
1959,27909903
1960,30784479
1961,31824045
1962,33864981
1963,36949060
1964,38896434
1965,38140552
1966,39208596
1967,39915572
1968,42297140
1969,44638407
1970,50631700
1971,52069098
1972,56071169
1973,60015526
1974,57294163
1975,54213685
1976,58203792
1977,55993691
1978,57226484
1979,61321326
1980,52024931
1981,55832893
1982,53565287
1983,51668238
1984,54214049
1985,54366320
1986,53728532
1987,57373914
1988,52937221
1989,53696289
1990,62140063
1991,65738192
1992,60236456
1993,60660781
1994,61034437
1995,64011231
1996,67355343
1997,67252097
1998,66886986
1999,65639881
2000,66138790
2001,70138688
2002,71942960
2003,77450503
2004,77667970
2005,79067961
2006,76796491
2007,74096973
2008,73472267
2009,67290760
2010,72000290
2011,69888739
2012,67263274
2013,67758606
2014,64160937
2015,66351619
2016,67215457
2017,69598854
2018,66565408
2019,67962416
2020,60634876
```

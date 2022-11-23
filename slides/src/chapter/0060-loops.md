# Loops

![Hypnotic](https://64.media.tumblr.com/5f507b2deaa1fedf531636ed8cd95dfa/61d92977df3924b4-59/s500x750/274e24800946c366e6b934f3abfdca5516d6f205.gifv)


## Video Lecture

<iframe width="560" height="315" src="https://www.youtube.com/embed/sQ48jTCPgqI" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>

[YouTube Playlist for course](https://youtube.com/playlist?list=PLhGL9p3BWHwsJN6kbQPOVZpEw2NXQXZQN)


## Types of Loops

* The <!-- .element: class="fragment" --> `do...while` statement
  * Executes code block *one or more* times
  * Condition is checked **after** first execution of code block
* The <!-- .element: class="fragment" --> `while` statement
  * Executes code block *zero or more* times
  * Condition is checked **before** first execution of code block
* The <!-- .element: class="fragment" --> `for` statement
  * Most flexible loop construct


## `do...while`

```cs[|2-9|8]
int i = 10;
┌──────────────────────────────────────────────┐◄────── LOOP
│ do                                           │
│ {                                            │
│   Console.WriteLine(i);                      │
│   i--;                                       │
│ }                                            │
│ while(i >= 0); ◄───────────────────────────────────── First check AFTER first execution of code block
└──────────────────────────────────────────────┘        

Console.WriteLine("Thank you and good night");
```


## `while`

```cs[|2-8|3]
int i = 10;
┌──────────────────────────────────────────────┐◄────── LOOP
│ while(i >= 0)  ◄───────────────────────────────────── First check BEFORE first execution of code block
│ {                                            │
│   Console.WriteLine(i);                      │
│   i--;                                       │
│ }                                            │
└──────────────────────────────────────────────┘        

Console.WriteLine("Thank you and good night");
```


## Exercise: `while` and `do..while` Loops

* Write <!-- .element: class="fragment" --> a program that generates the following outputs using loops
  * Solve each problem two times, first with a `while` and then with a `do..while` loop
* Level <!-- .element: class="fragment" --> 1 (relatively easy):
  * All numbers between 1 and 10:<br/>
    `1 2 3 4 5 6 7 8 9 10`
  * All numbers between 1 and 10 times 2:<br/>
    `2 4 6 8 10 12 14 16 18 20`
* Level <!-- .element: class="fragment" --> 2 (a bit harder):
  * All numbers between 0 and 20 that can be divided by 3 without a remainder:<br/>
    `0 3 6 9 12 15 18`
  * Sum of all numbers between 0 and 20 that can be divided by 3 without a remainder:<br/>
    `63`
* Level <!-- .element: class="fragment" --> 3 (can you make it?):
  * [Fibonacci sequence](https://en.wikipedia.org/wiki/Fibonacci_number) up to 34:<br/>
    `0 1 1 2 3 5 8 13 21 34`


## Tip: [WolframAlpha](https://www.wolframalpha.com/)

> [WolframAlpha](https://www.wolframalpha.com/) is a great website for math

* Enter <!-- .element: class="fragment" --> the following texts in WolframAlpha and see what you get
  * *1024 % 3*
  * *0 3 6 9 12 15 18*
  * *Fibonacci sequence*
  * *plot y = x ^ 2*  (note: `^` means *to the power of*)
  * *y = -3x + 21*


## Before, After - Does it Matter?

![Whatever](https://i.pinimg.com/originals/90/ed/c9/90edc9255ad708e15e88586eb7703007.gif)


## Example: `do...while` vs. `while`

```cs[|5]
const string QUIT = "quit";
const string QUESTION = $"Enter your name or type '{QUIT}' to exit:";
Console.WriteLine(QUESTION);
string name = Console.ReadLine()!;
while (name != QUIT) // Check name BEFORE first execution
{
    Console.WriteLine($"Hello {name}!");
    Console.WriteLine(QUESTION);
    name = Console.ReadLine()!;
}
```
<!-- .element: class="fragment" -->

```cs[|4,13]
const string QUIT = "quit";
const string QUESTION = $"Enter your name or type '{QUIT}' to exit:";
string name;
do
{
    Console.WriteLine(QUESTION);
    name = Console.ReadLine()!;
    if (name != QUIT)
    {
        Console.WriteLine($"Hello {name}!");
    }
}
while (name != QUIT); // Check name AFTER first execution
```
<!-- .element: class="fragment" -->


## Avoid repeating

See how we used constants in the previous example to avoid repeating literals?

![Don't make me repeat myself](https://memegenerator.net/img/instances/47652559/dont-make-me-repeat-myself.jpg)


## What is `$"...{<expr>}..."`?

* This <!-- .element: class="fragment" --> syntax is called **String Interpolation**
  * Prefix `$` before string
  * String can contain expressions (in curly braces `{...}`) that are evaluated and built into the resulting string
* Examples: <!-- .element: class="fragment" -->
  * `$"Enter your name or type '{QUIT}' to exit:"` is the same as <br/> `"Enter your name or type '" + QUIT + "' to exit:"`
  * `$"Hello {name}"` is the same as <br/> `"Hello " + name`
* Read <!-- .element: class="fragment" --> [more](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated)

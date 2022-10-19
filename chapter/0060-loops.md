# Loops

![Hypnotic](https://64.media.tumblr.com/5f507b2deaa1fedf531636ed8cd95dfa/61d92977df3924b4-59/s500x750/274e24800946c366e6b934f3abfdca5516d6f205.gifv)


## Video Lecture

<iframe width="560" height="315" src="https://www.youtube.com/embed/sQ48jTCPgqI" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyro<span translate="no">&nbsp;scope&nbsp;</span>; picture-in-picture" allowfullscreen></iframe>

[YouTube Playlist for course](https://youtube.com/playlist?list=PLhGL9p3BWHwsJN6kbQPOVZpEw2NXQXZQN)


## Types of Loops

* The <!-- .element: class="fragment" --> `do...while` <span translate="no">&nbsp;statement&nbsp;</span>
  * Executes code block *one or more* times
  * Condition is checked **after** first execution of code block
* The <!-- .element: class="fragment" --> `while` <span translate="no">&nbsp;statement&nbsp;</span>
  * Executes code block *zero or more* times
  * Condition is checked **before** first execution of code block
* The <!-- .element: class="fragment" --> `for` <span translate="no">&nbsp;statement&nbsp;</span>
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
  * `1 2 3 4 5 6 7 8 9 10`
  * All numbers between 1 and 10 times 2:<br/>
    `2 4 6 8 10 12 14 16 18 20`
* Level <!-- .element: class="fragment" --> 2 (a bit harder):
  * All numbers between 1 and 20 that can be divided by 3 without a remainder:<br/>
    `0 3 6 9 12 15 18`
  * Sum of all numbers between 1 and 20 that can be divided by 3 without a remainder:<br/>
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
  * String can contain <span translate="no">&nbsp;expressions&nbsp;</span> (in curly braces `{...}`) that are evaluated and built into the resulting string
* Examples: <!-- .element: class="fragment" -->
  * `$"Enter your name or type '{QUIT}' to exit:"` is the same as <br/> `"Enter your name or type '" + QUIT + "' to exit:"`
  * `$"Hello {name}"` is the same as <br/> `"Hello " + name`
* Read <!-- .element: class="fragment" --> [more](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated)


## The `for` Loop

```cs
for (int n = 0; n < 3; n++)
{
    Console.WriteLine(n);
}
```
<!-- .element: class="fragment" -->

```txt
            ┌────────────────────────────► Initialization
            │             ┌──────────────► Condition (boolean EXPRESSION)
            │             │          ┌───► Increment/decrement
      ┌─────┴─────┐   ┌───┴───┐   ┌──┴──┐
for ( │ int n = 0 │ ; │ n < 3 │ ; │ n++ │ )
┌─────┴───────────┴───┴───────┴───┴─────┴─────┐◄────── Repeated code block
│ {                                           │
│   Console.WriteLine(n);                     │
│ }                                           │
└─────────────────────────────────────────────┘
```
<!-- .element: class="fragment" -->

* Execution <!-- .element: class="fragment" --> order:
  * Initialization: <!-- .element: class="fragment" --> Evaluated **BEFORE condition**
  * Condition: <!-- .element: class="fragment" --> Evaluated **AFTER initialization** and **BEFORE each execution of code block**
  * Increment/decrement: <!-- .element: class="fragment" --> Executed **AFTER each execution of code block** and **BEFORE condition**


## The `for` Loop 💪

```cs
for (int n = 0; n < 3; n++)
{
    Console.WriteLine(i);
}
```

1. Declare <!-- .element: class="fragment" --> variable *n* and set it to *n = 0*.
2. Is <!-- .element: class="fragment" --> *n < 3*? Yes. So print value of *n* on the screen.
3. Increment <!-- .element: class="fragment" --> *n*, *n* is now *1*.
4. Is <!-- .element: class="fragment" --> *n < 3*? Yes. So print value of *n* on the screen.
5. Increment <!-- .element: class="fragment" --> *n*, *n* is now *2*.
6. Is <!-- .element: class="fragment" -->*n < 3*? Yes. So print value of *n* on the screen.
7. Increment <!-- .element: class="fragment" --> *n*, *n* is now *3*.
8. Is <!-- .element: class="fragment" --> *n < 3*? **No**. So end program.


## Exercise: `for` Loop

* Write <!-- .element: class="fragment" --> a program that generates the following outputs using `for`-loops
* Level <!-- .element: class="fragment" --> 1 (relatively easy):
  * All numbers between 1 and 10:<br/>
  * `1 2 3 4 5 6 7 8 9 10`
  * All numbers between 1 and 10 times 2:<br/>
    `2 4 6 8 10 12 14 16 18 20`
* Level <!-- .element: class="fragment" --> 2 (a bit harder):
  * All numbers between 1 and 20 that can be divided by 3 without a remainder:<br/>
    `0 3 6 9 12 15 18`
  * Sum of all numbers between 1 and 20 that can be divided by 3 without a remainder:<br/>
    `63`
* Level <!-- .element: class="fragment" --> 3 (can you make it?):
  * [Fibonacci sequence](https://en.wikipedia.org/wiki/Fibonacci_number) up to 34:<br/>
    `0 1 1 2 3 5 8 13 21 34`


## Exercise: Number Guessing Game 🎲

1. Generate <!-- .element: class="fragment" --> a random number between 0 (including) and 99 (including)
2. Ask <!-- .element: class="fragment" --> the user for a guess
3. Compare <!-- .element: class="fragment" --> guess with random number
   * If user's guess is **lower** than random number, print *Too Low*
   * If user's guess is **greater** than random number, print *Too High*
   * If user's guess is **equal** to random number, print *Correct*
4. Repeat <!-- .element: class="fragment" --> steps 2 and 3 until the user has guessed correctly
   * Once the user has guessed correctly, end the program


## Exercise: Number Guessing Game 🎲

Example output:

```txt
A random number between 0 and 99 has been chosen.
Please guess: 25
Too Low
Please guess: 64
Too High
Please guess: 51
Correct
```


## Exercise: Nested Loops, Level 1 😀

> Having loops inside of loops is quite common. We call this **nested loops**.

Example: Draw a square of 10 x 10 smiling faces <!-- .element: class="fragment" -->

```cs[|4|6]
// This enables emojis
Console.OutputEncoding = System.Text.Encoding.Default;

for (int y = 0; y < 15; y++)
{
    for (int x = 0; x < 15; x++)
    {
        Console.Write("😀");
    }

    Console.WriteLine();
}
```
<!-- .element: class="fragment" -->


## Exercise: Nested Loops, Level 2 😀🍕

<div class="container" data-markdown><div class="col" data-markdown>

* Change <!-- .element: class="fragment" --> the previous example
  * First line should consist of 😀
  * Second line should consist of 🍕
  * Third line should be 😀 again
  * Etc.

</div><div class="col" data-markdown>

![Loops different lines](images/loops-different-lines.png)
<!-- .element: class="fragment" -->

</div></div>


## Exercise: Nested Loops, Level 3 😀🍕

<div class="container" data-markdown><div class="col" data-markdown>

* Change <!-- .element: class="fragment" --> the previous example
  * First element should be 😀
  * Next element should be 🍕
  * Third element should be 😀 again
  * Etc.

</div><div class="col" data-markdown>

![Loops changing](images/loops-changing.png)
<!-- .element: class="fragment" -->

</div></div>


### Exercise: Speed Coding Challenge

![Speed Minion](https://media4.giphy.com/media/fBEMsUeGHdpsClFsxM/giphy.gif?cid=ecf05e47waysr97y1bx1rnzh4d9jj9iiu93459corz84xd71&rid=giphy.gif&ct=g)


### Exercise: Speed Coding Challenge

<div class="container" data-markdown><div class="col" data-markdown>

1. Text-based <!-- .element: class="fragment" --> animation
2. Character <!-- .element: class="fragment" --> starts in top left corner
3. Moves <!-- .element: class="fragment" --> in random direction<br/>(must not move out of screen)
   * No movement or ⬅️↖️⬆️↗️➡️↘️⬇️↙️
4. Wait <!-- .element: class="fragment" --> to slow down animation
5. Start <!-- .element: class="fragment" --> over with step 3
6. End <!-- .element: class="fragment" --> program when user presses a key

</div><div class="col" data-markdown>

![Dancing Star](images/dancing-star.gif)

</div></div>


### Exercise: Speed Coding Challenge

> Here is the code. Type it in and make it work as fast as you can! You are *not* allowed to copy/paste it!

```cs
const int SLEEP_TIME = 50; // Sleep time in milliseconds
const char ANIMATED_CHAR = '*';

// Hide cursor. Reduces flickering.
Console.CursorVisible = false;

// Clear console and write first * on position x=0/y=0.
// NOTE that after writing the first *, the new position is 1/0.
Console.Clear();
Console.Write(ANIMATED_CHAR);

// Let the process sleep for a while to make animation slower.
Thread.Sleep(SLEEP_TIME);

// Loop until the user presses any key.
while(!Console.KeyAvailable)
{
    // Write a Backspace and overwrite * with a space so that the * disappears.
    Console.Write("\b ");

    // Set default boundaries for random movement
    int xMinMovement = -1; // We can to left
    int xMaxMovement = 1; // We can to right
    int yMinMovement = -1; // We can to up
    int yMaxMovement = 1; // We can to down

    // Get cursor position.
    // NOTE that GetCursorPosition returns two values: left and top.
    (int left, int top) = Console.GetCursorPosition();

    // Correct cursor position. It is one off because we just wrote a space and that
    // moved the cursor one step forward in X direction.
    left--;

    if (left == 0)
    { 
        // If we are on the leftmost position, we cannot go left any further.
        xMinMovement = 0; 
    }

    if (left == Console.WindowWidth - 1)
    { 
        // If we are on the rightmost position, we cannot go right any further.
        xMaxMovement = 0; 
    }

    if (top == 0)
    { 
        // If we are on the topmost position, we cannot go up any further.
        yMinMovement = 0;
    }

    if (top == Console.WindowHeight - 1)
    { 
        // If we are on the bottommost position, we cannot go down any further.
        yMaxMovement = 0; 
    }

    // Calculate random movement within calculated boundaries.
    // NOTE that we have to add 1 to second parameter because the random value
    // will be LOWER than the second parameter, NOT lower or equal.
    int xMovement = Random.Shared.Next(xMinMovement, xMaxMovement + 1);
    int yMovement = Random.Shared.Next(yMinMovement, yMaxMovement + 1);

    // Go to new position and write *.
    Console.SetCursorPosition(left + xMovement, top + yMovement);
    Console.Write(ANIMATED_CHAR);

    // Let the process sleep for a while to make animation slower.
    Thread.Sleep(SLEEP_TIME);
}

// Enable cursor again.
Console.CursorVisible = true;
```


### Exercise: What We Have Learned

* Hide/show <!-- .element: class="fragment" --> cursor with `Console.CursorVisible`
* Put <!-- .element: class="fragment" --> process to sleep with `Thread.Sleep`
* Check <!-- .element: class="fragment" --> if the user pressed a key with `Console.KeyAvailable`
* Backspace <!-- .element: class="fragment" --> can be used to move cursor one to the left (`"\b"`)
* Some <!-- .element: class="fragment" --> functions return multiple values
  * Example: `(int left, int top) = Console.GetCursorPosition();`
* We <!-- .element: class="fragment" --> can get/set cursor position
  * `Console.GetCursorPosition`
  * `Console.SetCursorPosition`

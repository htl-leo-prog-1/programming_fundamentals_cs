# Loops

![Hypnothic](https://64.media.tumblr.com/5f507b2deaa1fedf531636ed8cd95dfa/61d92977df3924b4-59/s500x750/274e24800946c366e6b934f3abfdca5516d6f205.gifv)


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


## The `for` Loop

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


## Exercise: Number Guessing Game

1. Generate <!-- .element: class="fragment" --> a random number between 0 (including) and 99 (including)
2. Ask <!-- .element: class="fragment" --> the user for a guess
3. Compare <!-- .element: class="fragment" --> guess with random number
   * If user's guess is **lower** than random number, print *Too Low*
   * If user's guess is **greater** than random number, print *Too High*
   * If user's guess is **equal** to random number, print *Correct*
4. Repeat <!-- .element: class="fragment" --> steps 2 and 3 until the user has guessed correctly
   * Once the user has guessed correctly, end the program


## Exercise: Number Guessing Game

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

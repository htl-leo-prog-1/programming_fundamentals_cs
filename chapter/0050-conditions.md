# Conditions

![Not sure if or else](https://kodular-community.s3.dualstack.eu-west-1.amazonaws.com/original/3X/8/2/82ad1d18adb1aba033d9ee85b27e9e1ebea7f651.jpeg)


## The `if` <span translate="no">&nbsp;Statement&nbsp;</span>

* Only <!-- .element: class="fragment" --> executes a code block if a **condition** is true
  * `if (...) { ... }`
* With <!-- .element: class="fragment" --> the **else** clause, you can optionally specify an additional code block that should be executed if condition is false
  * `if (...) { ... } else { ... }`
* Here <!-- .element: class="fragment" --> is an example:

```cs [|1-4|6-8|9-13|14-19]
// The following line generates a random number out of 1, 2, 3, 4, 5, and 6.
// We have not talked about random numbers yet. 
// For the moment, trust me 😉. The code works.
var number = Random.Shared.Next(1, 7);

    ┌────────────┐◄──────────────────────────────────── Condition (is an EXPRESSION)
if (│ number > 3 │)
    └────────────┘
┌──────────────────────────────────────────────┐◄────── Block is executed if condition is TRUE
│{                                             │
│  Console.WriteLine("You had a 1, 2, or 3."); │
│}                                             │
└──────────────────────────────────────────────┘
else
┌──────────────────────────────────────────────┐◄────── Block is executed if condition is FALSE
│{                                             │
│  Console.WriteLine("You had a 4, 5, or 6."); │
│}                                             │
└──────────────────────────────────────────────┘
```
<!-- .element: class="fragment" -->


## Flowchart

<div class="mermaid">
  <pre>
    flowchart TD
      Start([Start]) --> Random[Get random number]
      Random --> GreaterThree{Is number > 3?}
      GreaterThree -- yes --> Low[/Print: You had a 1, 2, or 3./]
      GreaterThree -- no --> High[/Print: You had a 4, 5, or 6./]
      Low --> Stop([End])
      High --> Stop
  </pre>
</div>


## What is [`Random.Shared.Next`](https://docs.microsoft.com/en-us/dotnet/api/system.random.next#system-random-next(system-int32-system-int32))?

* Another <!-- .element: class="fragment" --> function from .NET
* Its <!-- .element: class="fragment" --> full name is `System.Random.Shared.Next`
* It <!-- .element: class="fragment" --> provides a random number
  * Similar to rolling a dice in a board game
  * You can specify the lower bounds (inclusive) and the upper bounds (exclusive)
* Pro <!-- .element: class="fragment" --> tip: Use [`Random.Shared.NextDouble`](https://docs.microsoft.com/en-us/dotnet/api/system.random.nextdouble) to get a random floating point number


## Example: Number Analyzer

<div class="mermaid">
  <pre>
    flowchart TD
      Start([Start]) --> Input[/Ask user for a number/]
      Input --> EvenCheck{number % 2 == 0?}
      EvenCheck -- yes --> Even[/Print: Even/]
      EvenCheck -- no --> Odd[/Print: Odd/]
      Even --> Stop([End])
      Odd --> Stop
  </pre>
</div>


## Example: Number Analyzer

Can you remember the *number analyzer* we did before? This time we implement it with an `if` <span translate="no">&nbsp;statement&nbsp;</span>.

```cs [|5-8|9-12]
Console.Write("Please enter a number: ");
int number = int.Parse(Console.ReadLine()!);

Console.Write("The number " + number + " is ");
if (number % 2 == 0)
{
  Console.Write("even");
}
else
{
  Console.Write("odd");
}
```


## Example: [🪨Rock 📃Paper ✂️Scissors](https://en.wikipedia.org/wiki/Rock_paper_scissors)

```cs [|1-4|6|7-11|12-16|17-21|23-24]
Console.Write("Player 1, choose rock (1), paper (2) or scissors (3): ");
int player1 = int.Parse(Console.ReadLine()!);
Console.Write("Player 2, choose rock (1), paper (2) or scissors (3): ");
int player2 = int.Parse(Console.ReadLine()!);

int winner = 0;
if (player1 == 1)
{
    if (player2 == 2) { winner = 2; } // Rock vs. paper
    else if (player2 == 3) { winner = 1; } // Rock vs. scissors
}
else if (player1 == 2)
{
    if (player2 == 1) { winner = 1; } // Paper vs. rock
    else if (player2 == 3) { winner = 2; } // Paper vs. scissors
}
else if (player1 == 3)
{
    if (player2 == 1) { winner = 2; } // Scissors vs. rock
    else if (player2 == 2) { winner = 1; } // Scissors vs. paper
}

if (winner == 0) { Console.WriteLine("No winner, repeat the game"); }
else { Console.WriteLine("Player " + winner + " wins"); }
```


## What You Learn From 🪨📃✂️ Example

* Code <!-- .element: class="fragment" --> block can be written...
  * ...in multiple lines
  * ...or in a single line (`if (...) { ... }`)
* An <!-- .element: class="fragment" --> `else` clause can be followed immediately by another `if`


## Using Constants to Make 🪨📃✂️ Code Cleaner

```cs [|1-7|14-31]
const int ROCK = 1;
const int PAPER = 2;
const int SCISSORS = 3;

const int DRAW = 0;
const int PLAYER1_WINS = 1;
const int PLAYER2_WINS = 2;

Console.Write("Player 1, choose rock (1), paper (2) or scissors (3): ");
int player1 = int.Parse(Console.ReadLine()!);
Console.Write("Player 2, choose rock (1), paper (2) or scissors (3): ");
int player2 = int.Parse(Console.ReadLine()!);

int winner = DRAW;
if (player1 == ROCK)
{
    if (player2 == PAPER) { winner = PLAYER2_WINS; } // Rock vs. paper
    else if (player2 == SCISSORS) { winner = PLAYER1_WINS; } // Rock vs. scissors
}
else if (player1 == PAPER)
{
    if (player2 == ROCK) { winner = PLAYER1_WINS; } // Paper vs. rock
    else if (player2 == SCISSORS) { winner = PLAYER2_WINS; } // Paper vs. scissors
}
else if (player1 == SCISSORS)
{
    if (player2 == ROCK) { winner = PLAYER2_WINS; } // Scissors vs. rock
    else if (player2 == PAPER) { winner = PLAYER1_WINS; } // Scissors vs. paper
}

if (winner == DRAW) { Console.WriteLine("No winner, repeat the game"); }
else { Console.WriteLine("Player " + winner + " wins"); }
```


## Exercise: 🪨📃✂️🦎🖖

> Build the enhanced version **Rock, Paper, Scissors, Lizard, Spock** from the popular TV series *The Big Bang Theory*

<iframe width="560" height="315" src="https://www.youtube.com/embed/_PUEoDYpUyQ" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyro<span translate="no">&nbsp;scope&nbsp;</span>; picture-in-picture" allowfullscreen></iframe>

[German version](https://youtu.be/4I3d9gKx_e4?t=20)


## Exercise: 🪨📃✂️🦎🖖

* The rules:
  * Scissors cuts Paper
  * Paper covers Rock
  * Rock crushes Lizard
  * Lizard poisons Spock
  * Spock smashes Scissors
  * Scissors decapitates Lizard
  * Lizard eats Paper
  * Paper disproves Spock
  * Spock vaporizes Rock
  * (and as it always has) Rock crushes Scissors

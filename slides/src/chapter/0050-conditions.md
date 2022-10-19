# Conditions

![Not sure if or else](https://kodular-community.s3.dualstack.eu-west-1.amazonaws.com/original/3X/8/2/82ad1d18adb1aba033d9ee85b27e9e1ebea7f651.jpeg)


## Video Lecture

<iframe width="560" height="315" src="https://www.youtube.com/embed/A5ABdS7qtpc" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>

[YouTube Playlist for course](https://youtube.com/playlist?list=PLhGL9p3BWHwsJN6kbQPOVZpEw2NXQXZQN)


## The `if` Statement

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

    ┌─────────────┐◄─────────────────────────────────── Condition (is an EXPRESSION)
if (│ number <= 3 │)
    └─────────────┘
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

[![](https://mermaid.ink/img/pako:eNptkc1OwzAQhF9l5VMrpQ1NStpG_FyKAIkDolyg6cGNN7GlxBs5DlVV5d2xQ4s4cPJ6Zr71yntiOQlkKSsqOuSSGwvv60wDbKyrR9vh2I1hMrmDN64F1dtHtGCGEnRX79HsfP7HHHKPBrlF8y4N4um5Pafg5hbi-95n_wYcAUdsB_CFDtvw1ShtU_igDiQXwGEWQBQAGYin4e4_XNNAP6lS_oPPA7ge8OSMu1eG_MZSM9o-aLEbe9njvzoLWI2m5kq4rzl5O2NWYo0ZS11ZkMHWZiw4O8PFGxKriuBAphIZy3Tv-nSNcNM-CGXJsLTgVYsB452lzVHnLLWmw0torXhpeP2bqogLdNCJ2WPjl1Sq1rqWOelClV7vTOVkaW3TpmHo7WmprOz205zqsFXCb1R-rZIwiZIlj2JMFjG_jmOR72erZRHNZ4VYXM0izvo-YA3Xn0SXAfpvHe2ubw)](https://mermaid.live/edit#pako:eNptkc1OwzAQhF9l5VMrpQ1NStpG_FyKAIkDolyg6cGNN7GlxBs5DlVV5d2xQ4s4cPJ6Zr71yntiOQlkKSsqOuSSGwvv60wDbKyrR9vh2I1hMrmDN64F1dtHtGCGEnRX79HsfP7HHHKPBrlF8y4N4um5Pafg5hbi-95n_wYcAUdsB_CFDtvw1ShtU_igDiQXwGEWQBQAGYin4e4_XNNAP6lS_oPPA7ge8OSMu1eG_MZSM9o-aLEbe9njvzoLWI2m5kq4rzl5O2NWYo0ZS11ZkMHWZiw4O8PFGxKriuBAphIZy3Tv-nSNcNM-CGXJsLTgVYsB452lzVHnLLWmw0torXhpeP2bqogLdNCJ2WPjl1Sq1rqWOelClV7vTOVkaW3TpmHo7WmprOz205zqsFXCb1R-rZIwiZIlj2JMFjG_jmOR72erZRHNZ4VYXM0izvo-YA3Xn0SXAfpvHe2ubw)


## What is [`Random.Shared.Next`](https://docs.microsoft.com/en-us/dotnet/api/system.random.next#system-random-next(system-int32-system-int32))?

* Another <!-- .element: class="fragment" --> function from .NET
* Its <!-- .element: class="fragment" --> full name is `System.Random.Shared.Next`
* It <!-- .element: class="fragment" --> provides a random number
  * Similar to rolling a dice in a board game
  * You can specify the lower bounds (inclusive) and the upper bounds (exclusive)
* Pro <!-- .element: class="fragment" --> tip: Use [`Random.Shared.NextDouble`](https://docs.microsoft.com/en-us/dotnet/api/system.random.nextdouble) to get a random floating point number


## Example: Number Analyzer

[![](https://mermaid.ink/img/pako:eNpVkV9rwjAUxb9KCAwUqtW6VS24MaYPe9rAPa31ITa3f7BNSnKjSOl3X1Jnx55y7zm_e8hNWppKDjSiWSUvacEUkq9tIgjZo61HcX8cxmQyeSbvojEY-6_6RIwGRTKpCCPC1EdQ_sEN9UTP7s4g3gpIT-3NJw8kIJsNmb10DhxsC5Mr6GEm9j9VKTDqm1voP1bIHv3gfCBt_Qf27h5lM4p3gh_GTrfAIFOP1qBqVnK7c-vchGIBNSQ0sqVdCTQm1Pt1-sYZBVSVJBepKp7QRHQ2xzScIex4iVLRKGOVBo8yg3J_FSmNUBm4Q9uS5YrVA1VJxsEOtRSvjXv9vNRoI1MpsjJ3ulGVlQvERke-7-xpXmJhjtNU1r4uufuq4rwO_TAIVyxYQLhcsKfFgqfH-XqVBY_zjC9n84DRrvNow8S3lPcLdD-oiKJ5)](https://mermaid.live/edit#pako:eNpVkV9rwjAUxb9KCAwUqtW6VS24MaYPe9rAPa31ITa3f7BNSnKjSOl3X1Jnx55y7zm_e8hNWppKDjSiWSUvacEUkq9tIgjZo61HcX8cxmQyeSbvojEY-6_6RIwGRTKpCCPC1EdQ_sEN9UTP7s4g3gpIT-3NJw8kIJsNmb10DhxsC5Mr6GEm9j9VKTDqm1voP1bIHv3gfCBt_Qf27h5lM4p3gh_GTrfAIFOP1qBqVnK7c-vchGIBNSQ0sqVdCTQm1Pt1-sYZBVSVJBepKp7QRHQ2xzScIex4iVLRKGOVBo8yg3J_FSmNUBm4Q9uS5YrVA1VJxsEOtRSvjXv9vNRoI1MpsjJ3ulGVlQvERke-7-xpXmJhjtNU1r4uufuq4rwO_TAIVyxYQLhcsKfFgqfH-XqVBY_zjC9n84DRrvNow8S3lPcLdD-oiKJ5)


## Example: Number Analyzer

Can you remember the *number analyzer* we did before? This time we implement it with an `if` statement.

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

<iframe width="560" height="315" src="https://www.youtube.com/embed/_PUEoDYpUyQ" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>

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


## Boolean Logical Operators

> Perform logical operations with *bool* operands

* AND <!-- .element: class="fragment" --> (`&&`)
  * Results in true if **both** operands are true
  * Example: `knobs == 2 && color == "gray"`
* OR <!-- .element: class="fragment" --> (`||`)
  * Results in true if **at least one** operand is true
  * Example: `knobs == 2 || length == 2`
* NOT <!-- .element: class="fragment" --> (`!`)
  * Logically **negates** operand
  * Example: `knobs == 2 && !(color == "gray")`


## Boolean Logical Operators

<div class="container" data-markdown><div class="col" data-markdown>

**AND**<!-- .element: class="fragment" -->

|       | true  | false |
|-------|-------|-------|
| true  | true  | false |
| false | false | false |
<!-- .element: class="fragment" -->

true && true == true,<br/>true && false == false,<br/>...<!-- .element: class="fragment" -->

</div><div class="col" data-markdown>

**OR**<!-- .element: class="fragment" -->

|       | true  | false |
|-------|-------|-------|
| true  | true  | true  |
| false | true  | false |
<!-- .element: class="fragment" -->

true || true == true,<br/>true || false == true,<br/>false || false == false,<br/>...<!-- .element: class="fragment" -->

</div></div>


## Examples: Boolean Logical Operators

<svg width="1024" height="500" viewbox="0 0 1850 900">
  <image href="images/bricks.png" height="768" width="1024" />
  <g>
    <rect class="lego-highlight" x="350" y="150" width="270" height="150" />
    <g transform="translate(1075, 50)">
      <text class="lego-code" x="0" y="0" font-size="40">knobs == 6 && color == "blue"</text>
    </g>
  </g><!-- .element: class="fragment fade-in-then-out" -->
  <g>
    <rect class="lego-highlight" x="70" y="350" width="230" height="180" />
    <rect class="lego-highlight" x="20" y="75" width="290" height="225" />
    <rect class="lego-highlight" x="360" y="470" width="320" height="220" />
    <rect class="lego-highlight" x="640" y="110" width="320" height="140" />
    <g transform="translate(1075, 100)">
      <text class="lego-code" x="0" y="0" font-size="40">knobs == 4 || color == "red"</text>
    </g>
  </g><!-- .element: class="fragment fade-in-then-out" -->
  <g>
    <rect class="lego-highlight" x="20" y="75" width="290" height="225" />
    <rect class="lego-highlight" x="360" y="470" width="320" height="220" />
    <g transform="translate(1075, 150)">
      <text class="lego-code" x="0" y="0" font-size="40">
        <tspan x="0">knobs >= 4</tspan>
        <tspan x="25" dy="1.2em">&& !(color == "blue")</tspan>
      </text>
    </g>
  </g><!-- .element: class="fragment fade-in-then-out" -->
  <g>
    <rect class="lego-highlight" x="420" y="350" width="150" height="120" />
    <rect class="lego-highlight" x="730" y="350" width="200" height="220" />
    <g transform="translate(1075, 250)">
      <text class="lego-code" x="0" y="0" font-size="40">
        <tspan x="0">knobs % 2 == 1</tspan>
        <tspan x="25" dy="1.2em">&& color == "gray"</tspan>
      </text>
    </g>
  </g><!-- .element: class="fragment fade-in-then-out" -->
  <g>
    <rect class="lego-highlight" x="630" y="260" width="150" height="140" />
    <g transform="translate(1075, 350)">
      <text class="lego-code" x="0" y="0" font-size="40">
        <tspan x="0">knobs % 2 == 0</tspan>
        <tspan x="25" dy="1.2em">&& color == "green"</tspan>
        <tspan x="25" dy="1.2em">&& knobs < 3</tspan>
      </text>
    </g>
  </g><!-- .element: class="fragment fade-in-then-out" -->
  <g>
    <rect class="lego-highlight" x="70" y="350" width="220" height="180" />
    <rect class="lego-highlight" x="20" y="75" width="290" height="210" />
    <rect class="lego-highlight" x="360" y="470" width="320" height="220" />
    <rect class="lego-highlight" x="640" y="110" width="320" height="140" />
    <rect class="lego-highlight" x="630" y="260" width="150" height="140" />
    <rect class="lego-highlight" x="350" y="150" width="270" height="130" />
    <rect class="lego-highlight" x="300" y="290" width="100" height="80" />
    <g transform="translate(1075, 500)">
      <text class="lego-code" x="0" y="0" font-size="40">
        <tspan x="0">color == "blue"</tspan>
        <tspan x="25" dy="1.2em">|| color == "green"</tspan>
        <tspan x="25" dy="1.2em">|| color == "red"</tspan>
      </text>
    </g>
  </g><!-- .element: class="fragment fade-in-then-out" -->
  <g>
    <rect class="lego-highlight" x="630" y="260" width="150" height="140" />
    <rect class="lego-highlight" x="300" y="290" width="100" height="80" />
    <g transform="translate(1075, 650)">
      <text class="lego-code" x="0" y="0" font-size="40">
        <tspan x="0">knobs < 3</tspan>
        <tspan x="25" dy="1.2em">&& !(color == "gray"</tspan>
        <tspan x="50" dy="1.2em">|| color == "red")</tspan>
      </text>
    </g>
  </g><!-- .element: class="fragment fade-in-then-out" -->
</svg>


## Exercise: Flat Evaluator 🏠

* You <!-- .element: class="fragment" --> are looking for a flat with...
  * ...a size of at least 100 square meters,
  * ...at least two bedrooms,
  * ...a balcony or a patio
* Write <!-- .element: class="fragment" --> a program where you ask the user for...
  * ...the size of the house,
  * ...the number of bedrooms,
  * ...whether the flat has a balcony or a patio<br/>
    (user should be able to enter 1 for *balcony*, 2 for *patio*, 3 for *none*, or 4 for *both*)
* Use <!-- .element: class="fragment" --> an `if` statement with boolean logical operators to find out if the flat fulfills your requirements
* Print <!-- .element: class="fragment" --> a corresponding message


## Exercise: Flat Evaluator 🏠

```cs[|9]
Console.Write("Size of the house in m²: ");
var size = int.Parse(Console.ReadLine()!);

Console.Write("Number of bedrooms: ");
var bedrooms = int.Parse(Console.ReadLine()!);

Console.Write("Does it have a balcony (1), patio (2), none (3), or both (4): ");
var balcPat = int.Parse(Console.ReadLine()!);
if (size >= 100 && bedrooms >= 2 && (balcPat == 1 || balcPat == 2 || balcPat == 4))
{
    Console.WriteLine("You should buy this flat!");
}
else
{
    Console.WriteLine("Sorry, no fit.");
}
```


## Exercise: Grade Calculator

> This exercise must be acquired from **GitHub**:<br/>[Classroom Link](https://classroom.github.com/a/dwjhqF74)

* In <!-- .element: class="fragment" --> this exercise you have to implement a *grade calculator*.
* Users <!-- .element: class="fragment" --> enter the points that they got on exams and on homework.
* Based <!-- .element: class="fragment" --> on that, you must calculate the grade.
* The <!-- .element: class="fragment" --> exercise is structured in levels. Try to solve as many as possible.


## Pro Tips

![Like a boss](https://c.tenor.com/TgDOSZ0PpNsAAAAd/zoolander-boss.gif)


## Patterns

> **Patterns** are super powerful in C# 💪
<!-- .element: class="fragment" -->

* Use <!-- .element: class="fragment" --> the `is` keyword
* For <!-- .element: class="fragment" --> now, just remember constant and relational pattern
  * `if (selection is 1 or 2) { ... }`
  * `if (grade is >= 1 and < 5) { ... }`
  * `if (input is 'a' or 'b' or 'c') { ... }`
  * `if (speed is >= 50 and not > 100) { ... }`
* You <!-- .element: class="fragment" --> will learn more patterns later in this course and in the upcoming years

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


## `do...while` vs. `while`

```cs[|4]
const string QUESTION = "Enter your name or type 'quit' to exit:";
Console.WriteLine(QUESTION);
string name = Console.ReadLine()!;
while (name != "quit") // Check name BEFORE first execution
{
    Console.WriteLine("Hello, " + name);
    Console.WriteLine(QUESTION);
    name = Console.ReadLine()!;
}
```
<!-- .element: class="fragment" -->

```cs[|2,11]
string name;
do
{
    Console.WriteLine("Enter your name or type 'quit' to exit:");
    name = Console.ReadLine()!;
    if (name != "quit")
    {
        Console.WriteLine("Hello, " + name);
    }
}
while (name != "quit"); // Check name AFTER first execution
```
<!-- .element: class="fragment" -->

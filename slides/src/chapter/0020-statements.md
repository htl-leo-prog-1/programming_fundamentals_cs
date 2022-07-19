# Statements and Literals


## Statements

![I'm gonna make a statement](https://c.tenor.com/Tfz1f4NJfWIAAAAC/im-gonna-make-a-statement-richard-williams.gif)


## Our Very First Program

```cs
┌────────────────────────────────────────────────────────────────┐
│// See https://aka.ms/new-console-template for more information ◄────── Comment line
└────────────────────────────────────────────────────────────────┘
┌────────────────────────────────────┐
│Console.WriteLine("Hello, World!"); ◄────── Statement
└────────────────────────────────────┘
```

* Use <!-- .element: class="fragment" --> **Comments**  to make sure you and other people understand the meaning of the code
  * Line comment starts at `//` and ends at the end of the line
  * For the programmer, not for the computer
  * Ignored by the compiler
* Statements <!-- .element: class="fragment" --> in C# **must** end with semicolon (*;*)
  * One or - for more complex statements - multiple lines


## What is `Console.WriteLine`?

* It <!-- .element: class="fragment" --> is a **Function** (we will learn a lot more about functions later)
* Prints <!-- .element: class="fragment" --> the given text on the screen and move to next line
  * Text must be in double quotes (*"*)
* There <!-- .element: class="fragment" --> is also `Console.Write` (without `Line`)
  * Also prints text on the screen, but does **not** move to next line

```cs
// The following three lines print three stars, each in a SEPARATE line.
Console.WriteLine("*");
Console.WriteLine("*");
Console.WriteLine("*");

// The following three lines print three stars in a SINGLE line (i.e. "***")
// because Write is used instead of WriteLine.
Console.Write("*");
Console.Write("*");
Console.Write("*");
```
<!-- .element: class="fragment" -->


## Exercise: Multiple Statements

> Write and run the following program:

```cs
// Print welcome message
Console.WriteLine("Hello, my name is Rainer");
Console.WriteLine("and I live in Leonding");

Console.WriteLine();  // Print an empty line

// Print goodbye message
Console.WriteLine("Thank you for using my program");
```

* How <!-- .element: class="fragment" --> many comment lines are in this program?
* How <!-- .element: class="fragment" --> many statements?


## Exercise: Recipe

> Write a program that prints a recipe on the screen

* Do **not** just copy the example on the next slides, create **your own** recipe
* Format the output nicely (e.g. use uppercase letter for headings)
* Try to use emoji characters where it makes sense
  * Tip: Put the following statement at the beginning of your program to make emojis work:

```cs
Console.OutputEncoding = System.Text.Encoding.Default;
```


## Example Recipe

```cs
// This enables emojis
Console.OutputEncoding = System.Text.Encoding.Default;

Console.WriteLine("CHEESE SANDWICH 🥪");
Console.WriteLine("==================");
Console.WriteLine();
Console.WriteLine("Ingredients:");
Console.WriteLine("🍞 1 slice of bread");
Console.WriteLine("🧀 1 slice of cheese");
Console.WriteLine("🍅 1 slice of tomato");
Console.WriteLine();
Console.WriteLine("How to prepare:");
Console.WriteLine("1. Put the cheese on the bread");
Console.WriteLine("2. Put the tomato on the cheese");
Console.WriteLine("3. If you like, put it in the oven 🔥 for 5 minutes at 160°C");
Console.WriteLine();

Console.WriteLine("Enjoy 🤤!");
```

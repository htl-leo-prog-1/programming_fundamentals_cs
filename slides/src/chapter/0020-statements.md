# Statements

![I'm gonna make a %73tatement](https://c.tenor.com/Tfz1f4NJfWIAAAAC/im-gonna-make-a-%73tatement-richard-williams.gif)


## Video Lecture

<iframe width="560" height="315" src="https://www.youtube.com/embed/Uk-Gyo1-JlA" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>

[YouTube Playlist for course](https://youtube.com/playlist?list=PLhGL9p3BWHwsJN6kbQPOVZpEw2NXQXZQN)


## Our Very First Program

The program we generated in the previous exercise looked like that:

```cs [|1-3|4-6]
┌────────────────────────────────────────────────────────────────┐
│// See https://aka.ms/new-console-template for more information ◄────── COMMENT line
└────────────────────────────────────────────────────────────────┘
┌────────────────────────────────────┐
│Console.WriteLine("Hello, World!"); ◄────── STATEMENT
└────────────────────────────────────┘
```

* We use <!-- .element: class="fragment" --> **Comments**  to make sure you and other people understand the meaning of our code
  * Comments start at `//` and end at the end of the line
  * Are for the programmers, not for the computer
  * The compiler ignores comments
* A <!-- .element: class="fragment" --> **Statement** is an action that your program should take
  * *Must* end with semicolon (`;`)
  * Can be in a single line or span multiple lines (for more complex scenarios)
  * Are executed one after the other (top to bottom)


## Exercise: Multiple Statements

> Write and run the following program:

```cs
// Print welcome message                                   
Console.WriteLine("Hello, my name is Rainer");             │ 
Console.WriteLine("and I live in Leonding");               │ Order of
                                                           │ execution
Console.WriteLine();  // Print an empty line               │ 
                                                           │
// Print goodbye message                                   ▼
Console.WriteLine("Thank you for using my program");       
```

* How <!-- .element: class="fragment" --> many **Comments** are in this program?
* How <!-- .element: class="fragment" --> many **Statements**?


## What is [`Console.WriteLine`](https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline#system-console-writeline(system-string))?

* It <!-- .element: class="fragment" --> is a **Function** provided by .NET
  * We will learn a lot more about functions later
* Its <!-- .element: class="fragment" --> full name is `System.Console.WriteLine`
  * You can leave out `System.` and just write `Console.WriteLine` in modern versions of C#
* Prints <!-- .element: class="fragment" --> the text on the screen and move to next line
  * Text must be in double quotes (`"`)
* There <!-- .element: class="fragment" --> is also `Console.Write` (without `Line`)
  * Does *not* move to next line

```cs [|1-4|6-10]
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


## Why "Console"?

Name comes from *consoles* with<br/>screen and keyboard used in the mid 20th century.

![Console](https://hanselmanblogcontent.azureedge.net/Windows-Live-Writer/23dece647ab5_14733/image_13b2c80d-a2d6-4429-8ca6-f053340897cc.png)

Read [*What's the difference between a console, a terminal, and a shell?*](https://www.hanselman.com/blog/whats-the-difference-between-a-console-a-terminal-and-a-shell)


## What if `Console.WriteLine` Doesn't Work?

* Its <!-- .element: class="fragment" --> full name is `System.Console.WriteLine`
* Some <!-- .element: class="fragment" --> older versions of C# and online development environment force you to use the full name
  * Option 1: Always write `System.Console...`
  * Option 2: Put `using System;` at the beginning of your program.
* You <!-- .element: class="fragment" --> will learn more about `using` and *namespaces* later

```cs
// Modern version of C#, System namespace is automatically available.
Console.Write("Hello ");
Console.WriteLine("World!");
```
<!-- .element: class="fragment" -->

```cs
// Works always. However, tedious as you have to write "System." over and over again.
System.Console.Write("Hello ");
System.Console.WriteLine("World!");
```
<!-- .element: class="fragment" -->

```cs[|1-2]
// Import namespace System
using System;

// Now you can leave out "System.". It will always work because we explicitely imported System.
Console.Write("Hello ");
Console.WriteLine("World!");
```
<!-- .element: class="fragment" -->


## Exercise: Recipe

> Write a program that prints a cooking recipe on the screen

* Create <!-- .element: class="fragment" --> *your own* recipe
  * Do *not* just copy the example on the next slides
* Format <!-- .element: class="fragment" --> the output nicely. Examples:
  * Use uppercase letters for headings
  * Underline headings with special characters like `=`, `*`, or `-`
  * Add [*ASCII Art*](https://patorjk.com/software/taag/#p=display&f=Big&t=Lasagne)
* Try <!-- .element: class="fragment" --> to use emoji characters where it makes sense
  * Tip: Put the following statement at the beginning of your program to make emojis work:

```cs
Console.OutputEncoding = System.Text.Encoding.Default;
```
<!-- .element: class="fragment" -->


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


## Pro Tips

![Like a boss](https://c.tenor.com/TgDOSZ0PpNsAAAAd/zoolander-boss.gif)


## Magic of `\n`

* Move <!-- .element: class="fragment" --> to the next line with `\n`
  * In fact, `\n` represents a *single* character
  * The `\` marks it to be an [*escape sequence* for special characters](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/#string-escape-sequences)
  * It is called the [*newline* character](https://en.wikipedia.org/wiki/Newline)
* Use <!-- .element: class="fragment" --> it to move to the next line *inside* of a string

```cs
// The following function call will print THREE lines
// because of \n inside the printed string
Console.WriteLine("Line 1\nLine 2\nLine 3");
//                       ^^      ^^
//                        |      |
//                        +------+--- New lines 
```
<!-- .element: class="fragment" -->


## Clear Screen 🚮

* You <!-- .element: class="fragment" --> can use `Console.Clear()` to clear the screen

```cs
Console.Clear();
Console.WriteLine("Hello World on a blank screen");
```
<!-- .element: class="fragment" -->


## Colors 🦄🌈

* You <!-- .element: class="fragment" --> can change text and background colors
  * Has to be done *before* `Console.WriteLine` or `Console.Clear`
* Reference <!-- .element: class="fragment" -->
  * `Console.BackgroundColor` for setting background color
  * `Console.ForegroundColor` for setting text color
  * [List of all available colors](https://docs.microsoft.com/en-us/dotnet/api/system.consolecolor)

```cs
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
Console.Write("My name is ");

Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Rainer");

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
Console.Write("!");
```
<!-- .element: class="fragment" -->

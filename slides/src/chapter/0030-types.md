# Literals, Constants, Variables, and Data Types

![Cause you just my type](https://media3.giphy.com/media/xTaWnRVrazwn9fOdwc/giphy.gif?cid=ecf05e47wu6k72jozly05v1chrlzgw4c7h8a6pm5ouqq1lzv&rid=giphy.gif&ct=g)


## Literals, Constants, Variables

* A <!-- .element: class="fragment" --> **Literal** is a value appearing in your program. Examples:
  * String literal: `"Hello World"`
  * Character literal: `'A'`
  * Integer literal: `42`
  * Floating point literal: `3.1415`
  * Boolean literal: `true`, `false`
* A <!-- .element: class="fragment" --> **Constant** is a symbolic name for a literal
  * The value of a constant *cannot* change!
  * The names of constants in C# are usually written in *UPPERCASE LETTERS*.
  * E.g. `const int ANSWER = 42;` or `const string GREETING = "Hello World";`
* A <!-- .element: class="fragment" --> **Variable** is a symbolic name whose value *can* change
  * The names of constants in C# are usually written in *lowercase letters*.
  * **Assignment**: Statement that assigns a value to a variable
  * E.g. `int answer = 42;` or `string greeting = "Hello World";`
* The <!-- .element: class="fragment" --> **data type** defines what values the constant or variable can contain
  * E.g. strings, integer numbers


## Confused?

![Confused](https://karolakarlson.com/wp-content/uploads/2017/03/confused-1.gif)

> Don't worry, examples will make it clearer!


## Literals

Let's use **Literals** of different types in a short program:

```cs [|1|2|4|8]
Console.Write("Take ");                    // "Take " is a String Literal
Console.Write(3);                          // 3 is an Integer Literal
Console.Write(" pizzas and bake it for ");
Console.Write(1.5);                        // 1.5 is a Floating Point Literal
Console.WriteLine(" minutes.");

Console.Write("Believe me, it is ");
Console.Write(true);                       // True is a Boolean Literal
Console.WriteLine(" that the pizza will be delicious!");
```


## Constants

Let's use **Constants** of different types in a short program:

```cs [|1-3|6,9-10|12-14]
// Let's define a String Constant for the address of our school. The address is
// very unlikely to change -> a constant is a good choice.
const string SCHOOL_ADDRESS = "Limesstraße 12-14, 4060 Leonding";

Console.Write("I go to school at ");
Console.WriteLine(SCHOOL_ADDRESS); // Here we use the constant

Console.Write("Please drive me to school at ");
Console.WriteLine(SCHOOL_ADDRESS); // Here we use the constant again.
                                   // We DO NOT have to repeat the school's address 👍

// Let's define an Integer Constant and use it
const int NUMBER_OF_STUDENTS = 31;
Console.Write(NUMBER_OF_STUDENTS);
Console.WriteLine(" students are in our class.");
```

> With constants, you can avoid repeating literal values over and over again.
<!-- .element: class="fragment" -->


## Variables

Let's use a **Variable** in a short program:

```cs [|2-3|9-11]
Console.Write("Please type in your name: ");
string name = Console.ReadLine()!; // Here we declare a variable called name 
                                   // and we assign it the value of the user input.
Console.Write("Your name is ");
Console.Write(name);               // Here we use the variable to print out the entered name.
Console.WriteLine();

Console.Write("Please type in the name of a friend: ");
name = Console.ReadLine()!;        // Here we let the user enter another name.
                                   // The value of name changes! Therefore, it has to be
                                   // a VARIABLE and cannot be a constant.
Console.Write("Your friend's name is ");
Console.Write(name);
```

> Don't worry about the `!` after `Console.ReadLine()`. You will learn later about that. Currently, just trust me 😜.
<!-- .element: class="fragment" -->


## What is [`Console.ReadLine`](https://docs.microsoft.com/en-us/dotnet/api/system.console.readline)?

* It <!-- .element: class="fragment" --> is a function provided by .NET like our good, old friend `Console.WriteLine`,
* Its <!-- .element: class="fragment" --> full name is `System.Console.ReadLine`
* Reads <!-- .element: class="fragment" --> a line of text from **Standard Input**
  * For now, *Standard Input* is the keyboard
  * Can be changed (you will learn more about that later)
* There <!-- .element: class="fragment" --> is also `Console.ReadKey` (`Key` instead of `Line`)
  * Reads a *single* character
  * Waits (i.e. pauses the program) until the user pressed a key


## Data Types

> C# has [a lot of data types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types). For now, you will need:

| Data Type | Description |
|-----------|-------------|
| [`string`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/reference-types#the-string-type) | Sequence of zero or more characters |
| [`char`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/char) | Single character |
| [`bool`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool) | Boolean value (`true` or `false`) |
| [`int`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types) | Integral numeric values (no decimal places) |
| [`float`, `double`, and `decimal`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types) | Floating point numeric values (general guideline: Use `double` for mathematical calculations, use `decimal` for monetary values) |


## String Parsing

* The <!-- .element: class="fragment" --> process of turning a string into another data type is called **Parsing**.
* Example <!-- .element: class="fragment" -->:
  * Ask the user to enter a number
  * The number you get is a `string`
  * You have to *parse* the string to get an `int` value with which you can do calculations
* Code: <!-- .element: class="fragment" --> `int myIntegerValue = int.Parse("42");`


## Important Operators

* For <!-- .element: class="fragment" --> numeric types: [Arithmetic Operators](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators)
  * Basic algorithmic operations (`+`, `-`, `/`, `*`)
  * Increment (`++`) and decrement (`--`)
  * Remainder (often referred to as *Modulo*) (`%`)
* To <!-- .element: class="fragment" --> compare values: [Comparison Operators](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/comparison-operators)
  * Relational operators (`>`, `<`, `>=`, `<=`)
  * Check if equal (`==`)
  * Check if not equal (`!=`)
* Not <!-- .element: class="fragment" --> all operators make sense for all types. Examples:
  * `+` for integer values 👍 - obviously works
  * `/` for string values 🤔 - makes no sense
  * `>` for boolean values 🤔 - also makes no sense


## Enough Theory - Show Me the Code

![Enough theory](https://i.giphy.com/13uaMxgBhGP9ba.gif)


## Example: Area Calculator

```cs [|1-2|5|8-9|13-14|16|18]
Console.BackgroundColor = ConsoleColor.Red;             // Note: Assignment
Console.ForegroundColor = ConsoleColor.White;           // Note: Assignment
Console.Clear();

Console.WriteLine("Welcome to the AREA CALCULATOR\n");  // Note: \n for additional empty line

Console.Write("Please enter the length of the room: ");
int length = int.Parse(Console.ReadLine()!);            // Note: Variable declaration and assignment
                                                        // Also note: Parsing
Console.Write("Please enter the width of the room: ");
int width = int.Parse(Console.ReadLine()!);

int area = length * width;                              // Note: Variable declaration and assignment
                                                        // Also note: Multiplication operator

Console.WriteLine("The area of the room is: " + area);  // Note: String concatination with + operator
Console.WriteLine("Press any key to exit.");
Console.ReadKey();                                      // Wait until user presses any key

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
Console.Clear();
```


## Example: Number Analyzer

```cs [|2|4|5-6|8-9|11-12]
Console.Write("Please enter a number: ");
int number = int.Parse(Console.ReadLine()!);

int remainder = number % 2;
bool isEvenNumber = remainder == 0;
Console.WriteLine("It is " + isEvenNumber + " that the number is even.");

bool isGreaterThanFive = number > 5;
Console.WriteLine("It is " + isGreaterThanFive + " that the number is greater than 5.");

number++;
Console.WriteLine("The next number is " + number);
```


## Example: Area Calculator For Circles

> Build an area calculator like before, but this time for circles, not rectangles

* Ask <!-- .element: class="fragment" --> the user for the radius of the circle.
* The <!-- .element: class="fragment" --> formula for calculating the area of a circle is `A = π * r²`
  * Use a *constant* for π and use the value 3.1415927
  * Pro tip: Use the pre-defined constant [`System.Math.PI`](https://docs.microsoft.com/en-us/dotnet/api/system.math.pi)
* Print <!-- .element: class="fragment" --> the area of the circle on the screen.


## Pro Tips

![We are very professional](https://www.meme-arsenal.com/memes/20c8fb489b732dc6ed6512c257f40924.jpg)


## Expressions

> We call calculations that result in a value of a certain type **Expressions**

* Expressions from previous examples:
  * `length * width` - result is a number
  * `number % 2` - result is a number
  * `remainder == 0` - result is a boolean value (`true` or `false`)
  * `number > 5` - result is a boolean value (`true` or `false`)
  * `"The next number is " + number` - result is a string
* As you can see, expressions do *not* end with a semicolon
* Expressions will become very important in more advanced code examples


## Don't Repeat Yourself (DRY)

![Don't make me repeat myself](https://memegenerator.net/img/instances/47652559/dont-make-me-repeat-myself.jpg)


## Don't Repeat Yourself (DRY)

> **Avoid repeating** the same code or data in your code!

Not good:

```cs

```

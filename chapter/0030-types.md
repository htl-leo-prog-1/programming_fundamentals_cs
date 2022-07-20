# Data Types

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
                                   // We do NOT have to repeat the school's address!

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


## Data Types

> C# has [a lot of data types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types). For now, you will need:

| Data Type | Description |
|-----------|-------------|
| [`string`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/reference-types#the-string-type) | Sequence of zero or more characters |
| [`char`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/char) | Single character |
| [`int`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types) | Integral numeric values (no decimal places) |
| [`float`, `double`, and `decimal`](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types) | Floating point numeric values (general guideline: Use `double` for mathematical calculations, use `decimal` for monetary values) |


## Important Operators

* For <!-- .element: class="fragment" --> numeric types: [Arithmetic Operators](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators)
  * Basic algorithmic operations (`+`, `-`, `/`, `*`)
  * Increment (`++`) and decrement (`--`)
  * Remainder (often referred to as *Modulo*) (`%`)
* To <!-- .element: class="fragment" --> compare values: [Comparison Operators](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/comparison-operators)
  * Relational operators (`>`, `<`, `>=`, `<=`)
  * Check if equal (`==`)
  * Check if not equal (`!=`)


## Confused Again?

![Confused](https://karolakarlson.com/wp-content/uploads/2017/03/confused-1.gif)

> Let's exercise to get a deeper understanding.



# <span translate="no">Strings</span>

![I'd cut my strings for you](https://y.yarn.co/7749d0d1-4d4c-4b0d-81dc-12f62ab108e6_text.gif)


## What Are &nbsp;<span translate="no">Strings</span>?

* A <!-- .element: class="fragment" --> string is an object whose value is **text**
  * Technically: A *collection of characters* (`char`)
* In <!-- .element: class="fragment" --> C#, Strings use [Unicode](https://home.unicode.org/)
  * Covers all the characters for all the writing systems of the world
  * Characters for symbols like [Domino Tiles](https://en.wikipedia.org/wiki/Domino_Tiles), [Music Symbols](https://unicode-table.com/en/blocks/musical-symbols/), Emojis, etc.
* Each <!-- .element: class="fragment" --> character is between two and four bytes long
  * See also [list of Unicode characters](https://en.wikipedia.org/wiki/List_of_Unicode_characters)


## Unicode: Really *All* Writing Systems?

Sorry, no Klingon 😜 - but [maybe in the future](http://klingon.wiki/En/Unicode)?

![Klingon](https://c.tenor.com/Uurx3yX0KxQAAAAC/jeffery-epstine-killeld-himself.gif)


## Creating &nbsp;<span translate="no">Strings</span>

```cs[|1-3|5-12|14-16|18-21]
// String constant
const string greeting = "Hello World";
Console.WriteLine(greeting);

// String variable
string helloInDifferentLanguages;
helloInDifferentLanguages = "Hallo";
Console.WriteLine(helloInDifferentLanguages);
helloInDifferentLanguages = "hi";
Console.WriteLine(helloInDifferentLanguages);
helloInDifferentLanguages = "bonjour";
Console.WriteLine(helloInDifferentLanguages);

// String concatination
const string anotherGreeting = greeting + "!!";
Console.WriteLine(anotherGreeting);

// String interpoliation
int result = 21 + 21;
string resultOutput = $"The result is {result}";
Console.WriteLine(resultOutput);
```


## Important &nbsp;<span translate="no">String</span>-Functions and Properties

> Full list see [`String` documentation](https://docs.microsoft.com/en-us/dotnet/api/system.string)

| Function/Property | Description |
|---|---|
| <span translate="no">[Length](https://docs.microsoft.com/en-us/dotnet/api/system.string.length)</span> | Returns length of string in characters |
| <span translate="no">[StartsWith](https://docs.microsoft.com/en-us/dotnet/api/system.string.startswith), [EndsWith](https://docs.microsoft.com/en-us/dotnet/api/system.string.endswith)</span> | Returns *true* if strings starts/ends with a given text |
| <span translate="no">[Contains](https://docs.microsoft.com/en-us/dotnet/api/system.string.contains)</span> | Returns *true* if the string contains a given text |
| <span translate="no">[IndexOf](https://docs.microsoft.com/en-us/dotnet/api/system.string.indexof), [LastIndexOf](https://docs.microsoft.com/en-us/dotnet/api/system.string.lastindexof)</span> | Returns index/last index of given text in string |
| <span translate="no">[IsNullOrEmpty](https://docs.microsoft.com/en-us/dotnet/api/system.string.isnullorempty)</span> | Returns *true* if string is empty or *null*<br/>(you will learn more about *null* later) |


## Important &nbsp;<span translate="no">String</span>-Functions and Properties

| Function/Property | Description |
|---|---|
| <span translate="no">[Replace](https://docs.microsoft.com/en-us/dotnet/api/system.string.replace)</span> | Returns a new string in which given text has been replaced by another text |
| <span translate="no">[Substring](https://docs.microsoft.com/en-us/dotnet/api/system.string.substring)</span> | Returns a substring (based on start end end index) of the text |
| <span translate="no">[ToLower](https://docs.microsoft.com/en-us/dotnet/api/system.string.tolower), [ToUpper](https://docs.microsoft.com/en-us/dotnet/api/system.string.toupper)</span> | Returns a new string where all characters are turned to lowercase/uppercase |
| <span translate="no">[Trim](https://docs.microsoft.com/en-us/dotnet/api/system.string.trim)</span> | Returns a new string in which all white-spaces were removed at the beginning and end |
| <span translate="no">[`==`](https://docs.microsoft.com/en-us/dotnet/api/system.string.op_equality), [`!=`](https://docs.microsoft.com/en-us/dotnet/api/system.string.op_inequality)</span> | Returns *true* if strings are equal/not equal |


## Example For Strings

> Type in the following program

Do **not** just copy it. This is also a typing exercise!

```cs
Console.WriteLine("Please enter a text, I will analyze it");
string input = Console.ReadLine()!;

if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("You did not enter anything");
}
else
{
    Console.WriteLine($"The string you entered is {input.Length} characters long");

    string lowercaseInput = input.ToLower();
    Console.WriteLine($"You input turned into lowercase letter is '{lowercaseInput}'");

    // Note: We use ToLower here to recognize Hello, hello, HELLO, and so on.
    if (lowercaseInput.StartsWith("hello"))
    {
        Console.WriteLine("You text seems to be a greeting because it starts with 'hello'");
    }

    if (input.EndsWith("!!"))
    {
        Console.WriteLine("You text seems to be important because it ends with '!!'");
    }

    // If you want, you can put your own name in the following line
    const string MY_NAME = "rainer";
    if (lowercaseInput.Contains(MY_NAME))
    {
        int indexOfName = lowercaseInput.IndexOf(MY_NAME);
        Console.WriteLine($"You text contains my name at character {indexOfName}");

        if (lowercaseInput.LastIndexOf(MY_NAME) != indexOfName)
        {
            Console.WriteLine("You text contains my name more than once");
        }

        string name = input.Substring(indexOfName, MY_NAME.Length);
        Console.WriteLine($"You wrote my name in the form {name}");
    }

    string replaced = input.Replace("a", "@");
    Console.WriteLine($"If I replace all a characters with @, your input becomes {replaced}");

    Console.WriteLine($"If I remove all white-spaces at the beginning and at the end, your input is {input.Trim()}");
}
```


## Example For Strings

* Run the program with the following inputs
  * *The quick brown fox jumps over the lazy dog*
  * *Hello Bob*
  * *Hello Rainer!!*
  * *Hello RAINER!!*
  * *Hello Rainer and welcome, Rainer!!*
  * *&nbsp;&nbsp;Hello Rainer!!&nbsp;&nbsp;*
  * Empty string
* Try to understand why the output is as it is


## Accessing Strings Character By Character

> You can access the character at index n using `myString[n]`

```cs[|6-7]
const string myName = "Rainer";

// Print each letter of my name in a separate line
for (int i = 0; i < myName.Length; i++)
{
  char currentChar = myName[i];
  Console.WriteLine(currentChar);
}
```


## ⚠️ Strings Are Read-Only in C#

* In <!-- .element: class="fragment" --> C#, strings **cannot be changed** after you built them
* If <!-- .element: class="fragment" --> you change it, you get a **changed copy** of the original string

```cs[|3-5|7-9|11-12]
string name = "Rainer";

// Note that the next line DOES NOT CHANGE the content 
// of the variable name as it is READ-ONLY.
name.ToLower();

// The next line works because the NEW STRING is assigned
// to the variable name.
name = name.ToLower();

// The following line does not work because it would alter the string
// name[0] = 'X';
```
<!-- .element: class="fragment" -->


## [Escape Sequences For Special Characters](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/#string-escape-sequences)

| Sequence | Meaning                           |
|----------|-----------------------------------|
| `\n`     | Newline, move cursor to next line |
| `\t`     | Tabulator                         |
| `\\`     | Backslash                         |
| `\"`     | Double quotes                     |
| `\'`     | Single quotes                     |

```cs
Console.WriteLine("Line1\nLine2"); // Two lines because of \n
Console.WriteLine("\tIndented text"); // Text indentation because of \t
Console.WriteLine("C:\\temp\\myfile.txt"); // A sample file name with backslashes in it
Console.WriteLine("This is \"great\" news"); // A text with double quotes
Console.WriteLine("What do you mean by \'funny\'?"); // A text with single quotes
```
<!-- .element: class="fragment" -->


## [`ToString()`](https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring)

> With `.ToString()`, you can turn every data type in C# in its string representation

```cs[|1-3|5-7|9-10]
// Turn a constant into a string
const int someNumber = 42;
string someNumberAsString = someNumber.ToString();

// Turn a variable into a string
int anotherNumber = 40 + 2;
string anotherNumberAsString = anotherNumber.ToString();

// Turn a literal into a string
string literalAsString = 42.ToString();
```
<!-- .element: class="fragment" -->


## Exercise: Word Counter

* Let <!-- .element: class="fragment" --> the user enter a sentence
* Count <!-- .element: class="fragment" --> the number of words in the sentence
  * Words are separated by a single space character
* Print <!-- .element: class="fragment" --> the number of words on the screen

This <!-- .element: class="fragment" --> is a sample output/input:

```txt
Please enter a sentence:
The HTL-Leonding is great! I love going to school there.
Your sentence has 10 words.
```
<!-- .element: class="fragment" -->


## Exercise: *Fizz Buzz* - Level 2

* Can <!-- .element: class="fragment" --> you remember *Fizz Buzz*?
  * Let's do it again, but in an enhanced form
* Print <!-- .element: class="fragment" --> all numbers **between 1 and 35** on the screen
  * Replace every number divisible by 3 or **that contains the digit 3** with the word *fizz*
  * Replace every number divisible by 5 or **that contains the digit 5** with the word *buzz*
  * Replace every number divisible by 3 *and* five or **that contains the digits 3 and 5** with *fizz buzz*
  * Separate elements with commas
* Put <!-- .element: class="fragment" -->the logic for turning each number in a string in a separate function<br/>
  `string ToFizzBuzzLevel2(int number) { ... }`
* Put <!-- .element: class="fragment" -->the logic for checking if string contains a digit in a separate function<br/>
  `bool ContainsDigit(int digit) { ... }`
* Required <!-- .element: class="fragment" --> output:<br/>
  `1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, Fizz, 14, Fizz Buzz, 16, 17, Fizz, 19, Buzz, Fizz, 22, Fizz, Fizz, Buzz, 26, Fizz, 28, 29, Fizz Buzz, Fizz, Fizz, Fizz, Fizz, Fizz Buzz`

# Arguments

![Good argument](https://media.tenor.com/yJJgQYoS0RMAAAAC/thats-a-damn-good-argument-pointing.gif)


## Command Line Arguments

* Programs <!-- .element: class="fragment" --> can receive arguments in the command line
  * You can pass no arguments, one argument, or multiple arguments
* Example <!-- .element: class="fragment" -->

```txt
┌─────────────── Command      
│     ┌───────── Command Line Argument
│     │
▼     ▼
mkdir mySubfolder
```
<!-- .element: class="fragment" -->


## Arguments in .NET

* Pass <!-- .element: class="fragment" --> command line arguments to .NET programs by putting them after `dotnet run`
  * Example: `dotnet run 12 abc`
  * `12` and `abc` are the command line arguments that your .NET program will receive
* Command <!-- .element: class="fragment" --> line arguments in .NET are always strings
* Inside <!-- .element: class="fragment" --> of your .NET program, access command line arguments with `args`

```cs[|1-5|7-8|10-11]
// Check if at least two arguments are present
if (args.Length < 2)
{
  Console.WriteLine("Too few arguments. Pass at least two arguments.");
}

// Get first argument
string firstArgument = args[0];

// Get second argument
string secondArgument = args[1];
```
<!-- .element: class="fragment" -->


## Passing Arguments to Debugger

Add arguments to *.vscode/launch.json*

![Passing arguments to the debugger](images/debugger-args.png)

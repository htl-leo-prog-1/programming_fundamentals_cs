# Let's Learn to Code

# 👩‍💻👨‍💻

Programming Course @ HTL Leonding


## We Program in C#

![C Sharp musical note](https://upload.wikimedia.org/wikipedia/commons/thumb/0/02/Music_C_sharp.svg/480px-Music_C_sharp.svg.png)


## We Program in C#

> A **Programming Language** is the language we use to tell the computer what we want it to do

* We <!-- .element: class="fragment" --> use the programming language **[C#](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/)**
  * The *C* comes from the classical programming language [C](https://en.wikipedia.org/wiki/C_(programming_language))
  * The *#* comes from the chromatic sign (*Kreuz*-[Vorzeichen](https://de.wikipedia.org/wiki/Vorzeichen_(Musik))) in music (is called *Sharp* in English)
* C# <!-- .element: class="fragment" --> is one of the top 10 most popular programming languages ([source](https://survey.stackoverflow.co/2022/#most-popular-technologies-language))


## Our Platform is *.NET*

![.NET Bot Surfing](https://hot33331.github.io/assets/img/dotnet-bot-surfing.png)


## Our Platform is *.NET*

* A <!-- .element: class="fragment" --> **Platform** offers all the tools you need to build and run software
* We <!-- .element: class="fragment" --> use the **[.NET Platform](https://dotnet.microsoft.com/en-us/)**
  * Free, [Open Source Software](https://en.wikipedia.org/wiki/Open-source_software)
  * Runs on many types of computers (e.g. Windows, Linux, Mac, Android, iOS, etc.)
* .NET <!-- .element: class="fragment" --> works with many programming languages
  * In this course we use C#
  * Other .NET languages would be for instance *F#* or *Visual Basic*


## What Do We Need to Get Started?

![Let's get started](https://c.tenor.com/r3XdvPsAV3kAAAAC/despicable-me-minions.gif)


## What Do We Need to Get Started?

* An <!-- .element: class="fragment" --> **Editor** to type in the code
  * Examples: [vim](https://www.vim.org/), [Notepad++](https://notepad-plus-plus.org/), [Visual Studio Code](https://code.visualstudio.com/), [Visual Studio](https://visualstudio.microsoft.com/)
  * We will start with *Notepad* and switch to *Visual Studio Code* later
* A <!-- .element: class="fragment" --> **Shell** where we can type commands
  * Examples: [cmd](https://en.wikipedia.org/wiki/Cmd.exe), [Windows Terminal](https://apps.microsoft.com/store/detail/windows-terminal/9N0DX20HK701), [bash](https://en.wikipedia.org/wiki/Bash_(Unix_shell))
* The <!-- .element: class="fragment" --> **C# Compiler** to turn our code into machine-readable programs
  * Is part of the [*.NET SDK*](https://dotnet.microsoft.com/en-us/download) (Software Development Kit)
* Installed <!-- .element: class="fragment" --> **[.NET Runtime](https://dotnet.microsoft.com/en-us/download)** to run our program
  * Note: *.NET Runtime* is included in the *.NET SDK*


## How to Practice Without .NET Installed

* Sometimes <!-- .element: class="fragment" --> you might need to practice and you are on a computer without .NET
  * E.g. your parents' computer, a computer in a public library, etc.
* You <!-- .element: class="fragment" --> can use **Online Development Environments** for C#. Examples:
  * <span translate="no">[.NET Fiddle](https://dotnetfiddle.net/)</span>
  * [sharplab.io](https://sharplab.io/)
  * [Microsoft's .NET In-Browser Tutorial](https://dotnet.microsoft.com/en-us/learn/dotnet/in-browser-tutorial/1)
* ⚠️ <!-- .element: class="fragment" --> Be careful regarding C# and .NET versions
  * Some online development environments are not up to date
  * Some are specific for trying out preview versions
  * So, online development environments shouldn't be your primary development tool


## Enough Theory

![Enough theory](https://i.giphy.com/13uaMxgBhGP9ba.gif)


## Enough Theory

* Create <!-- .element: class="fragment" --> an **empty folder** where you want to store your program
* Open <!-- .element: class="fragment" --> a **Shell**. This is how you can do it on Windows:
  ![Open a shell](/images/StartShell.gif)


## Enough Theory

* Which <!-- .element: class="fragment" --> version of .NET is installed on your computer?
  * In your shell, type in: `dotnet --version`
  * Do you get an error? Install the latest version of the [.NET SDK](https://dotnet.microsoft.com/en-us/download)
* Create <!-- .element: class="fragment" --> your first C# program
  * Type in: `dotnet new console`
* Look <!-- .element: class="fragment" --> at what has been created
  * Type in: `dir`
* Take <!-- .element: class="fragment" --> a look at the code and try to guess what it will do
  * Type in: `type Program.cs`
* Compile <!-- .element: class="fragment" --> the program
  * Type in: `dotnet build`
* Run <!-- .element: class="fragment" --> the program
  * Type in: `dotnet run`


## Exercise: Change the Message

> Change the message that is printed on the screen

* Open *Program.cs* in any editor that you have on your computer
  * If you have nothing else, a program called *Notepad* is installed on every Windows computer
* Try to change the message
  * Only change the text *inside* of the double quotes, do *not* remove them!
* Run the program again and see whether your message is printed
  * To run, type in: `dotnet run`


## Well done 👍

![Coffee into code](https://media4.giphy.com/media/SXxI9NlwvYiY3bRsck/giphy.gif?cid=790b761173bba9e799b0d66a53e5d1740ff081d372bbfe3a&rid=giphy.gif&ct=g)

# <span translate="no">Files</span>

![Where are my files?](https://memegenerator.net/img/instances/59291900.jpg)


## What Are Files?

* Computer <!-- .element: class="fragment" --> store data persistently in **files**
  * There are many different types of files (e.g. text files, image files, audio files, etc.)
* Files <!-- .element: class="fragment" --> are organized in **folders**
  * Put logically related files in a common folder
  * Folders can contain sub-folders, so they form a **folder hierarchy**
  * The folder you are currently in is called the **current working directory**
* File <!-- .element: class="fragment" --> names consist of the name of the file, a dot, and the **file extension**
  * The extension of a file indicates the file type
  * Examples: *poem.txt*, *music.mp3*, *MyProgram.cs*


## Managing Files

* Most <!-- .element: class="fragment" --> people use graphical tools to manage their files and folders
  * Windows: [*File Explorer*](https://support.microsoft.com/en-us/windows/find-and-open-file-explorer-ef370130-1cca-9dc5-e0df-2f7416fe1cb1)
  * MacOS: [*Finder*](https://support.apple.com/en-us/HT201732)
  * Linux: Various [*File Managers*](https://www.fosslinux.com/47970/linux-file-managers.htm)
* As <!-- .element: class="fragment" --> developers, we often manage files and folders in our **Terminal**
  * [Windows Command Prompt cheat sheet](http://www.cs.columbia.edu/~sedwards/classes/2015/1102-fall/Command%20Prompt%20Cheatsheet.pdf)
  * [Bash cheat sheet](https://github.com/RehanSaeed/Bash-Cheat-Sheet) (Linux)
  * [Mac Terminal Command cheat sheet](https://www.makeuseof.com/tag/mac-terminal-commands-cheat-sheet/) (MacOS)


## Case Sensitivity

> Under Linux, file and folder names are **case sensitive**, under Windows not -> **always** use correct casing

![Oh no](https://monophy.com/media/xl3B9B6bjqjUNDJCod/monophy.gif)


## Reading and Writing Files in C#

| Function | Description |
|---|---|
| [`File.ReadAllText`](https://docs.microsoft.com/en-us/dotnet/api/system.io.file.readalltext) | Opens a text file, reads all the text in the file, and then closes the file |
| [`File.WriteAllText`](https://docs.microsoft.com/en-us/dotnet/api/system.io.file.writealltext) | Creates a new file, write the contents to the file, and then closes the file. If the target file already exists, it is overwritten |
| [`File.ReadAllLines`](https://docs.microsoft.com/en-us/dotnet/api/system.io.file.readalllines) | Opens a text file, reads all lines of the file into a string array, and then closes the file |
| [`File.WriteAllLines`](https://docs.microsoft.com/en-us/dotnet/api/system.io.file.writealllines) | Creates a new file, writes one or more strings to the file, and then closes the file |

Full list of file functions see [documentation](https://docs.microsoft.com/en-us/dotnet/api/system.io.file?view=net-6.0#methods)


## Example: Song Text 🎶 From File

* Store <!-- .element: class="fragment" --> the text of the Michael Jackson song *Billie Jean* in a text file
  * Text can be found on the following slide
* Write <!-- .element: class="fragment" --> a C# program that reads the text file and print its content on the screen
  * First implementation must be done with `File.ReadAllText`
  * Second implementation must be done with `File.ReadAllLines`


## Example: Song Text 🎶 From File

Lyrics of *Billie Jean* (Michael Jackson) ([source](https://www.google.com/search?q=billie+jean+lyrics))

```txt
She was more like a beauty queen from a movie scene
I said don't mind, but what do you mean, I am the one
Who will dance on the floor in the round?
She said I am the one, who will dance on the floor in the round

She told me her name was Billie Jean, as she caused a scene
Then every head turned with eyes that dreamed of being the one
Who will dance on the floor in the round

People always told me be careful of what you do
And don't go around breaking young girls' hearts
And mother always told me be careful of who you love
And be careful of what you do 'cause the lie becomes the truth

Billie Jean is not my lover
She's just a girl who claims that I am the one
But the kid is not my son
She says I am the one, but the kid is not my son

For forty days and forty nights
The law was on her side
But who can stand when she's in demand
Her schemes and plans
'Cause we danced on the floor in the round
So take my strong advice, just remember to always think twice
(Do think twice, do think twice)

She told my baby we'd danced 'til three, then she looked at me
Then showed a photo my baby cried his eyes were like mine (oh, no)
'Cause we danced on the floor in the round, baby

People always told me be careful of what you do
And don't go around breaking young girls' hearts
She came and stood right by me
Just the smell of sweet perfume
This happened much too soon
She called me to her room

Billie Jean is not my lover
She's just a girl who claims that I am the one
But the kid is not my son

Billie Jean is not my lover
She's just a girl who claims that I am the one
But the kid is not my son
She says I am the one, but the kid is not my son

She says I am the one, but the kid is not my son

Billie Jean is not my lover
She's just a girl who claims that I am the one
But the kid is not my son
She says I am the one, but the kid is not my son

She says I am the one
You know what you did, (she says he is my son) breaking my heart babe
She says I am the one

Billie Jean is not my lover
Billie Jean is not my lover
Billie Jean is not my lover
Billie Jean is not my lover (don't Billie Jean)
Billie Jean is not my lover
Billie Jean is not my lover
```


## Example: Song Text 🎶 From File

### *ReadAllText* <!-- .element: class="fragment" -->

```cs[]
var fileContent = File.ReadAllText("billie-jean.txt");
Console.WriteLine(fileContent);
```
<!-- .element: class="fragment" -->

### *ReadAllLines* <!-- .element: class="fragment" -->

```cs[]
var fileContent = File.ReadAllLines("billie-jean.txt");
for (int i = 0; i < fileContent.Length; i++)
{
    Console.WriteLine(fileContent[i]);
}
```
<!-- .element: class="fragment" -->


## End of Line Sequence: [LF vs. CR/LF](https://developer.mozilla.org/en-US/docs/Glossary/CRLF)

<div class="container" data-markdown><div class="col" data-markdown>

* On Linux <!-- .element: class="fragment" -->, the end of each line in a text file is typically marked with a *single* character
  * ***line feed*** (short LF, 0x0A, `\n`)
* On Windows <!-- .element: class="fragment" -->, lines typically end with *two* characters
  * ***carriage return*** (short CR, 0x0D, `\r`) **and** *line feed* (LF)
* You <!-- .element: class="fragment" --> can change the end of line sequence e.g. in VSCode:

![CR/LF in VSCode](images/crlf-vscode.png)
<!-- .element: class="fragment" -->

</div><div class="col" data-markdown>

![CR/LF](https://hanselmanblogcontent.azureedge.net/Windows-Live-Writer/175d48b87c0a_148AC/theCRLFWALL_3.png)

</div></div>


## What's `await`?

```cs[|1-3]
         ┌───────┐
var fc = │ await │ File.ReadAllTextAsync("song.txt");
         └───────┘ 
Console.WriteLine(fc);
```

* In <!-- .element: class="fragment" --> the documentation and in samples you often find calls to file functions in conjunction with `await`
  * See code sample to the right
* This <!-- .element: class="fragment" --> is called **asynchronous programming**
  * You will learn more about it later
  * To keep things simple, I recommend not using `await` yet. However, if you really want, you can.

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


## Example: CO² Chart

```txt
1946: 12.760.137 ######
1947: 17.630.039 ########
1948: 24.487.263 ############
1949: 26.574.257 #############
1950: 20.894.256 ##########
1951: 23.264.090 ###########
1952: 22.069.984 ###########
1953: 21.714.546 ##########
1954: 24.505.593 ############
1955: 29.069.986 ##############
...
1985: 54.366.320 ###########################
1986: 53.728.532 ##########################
2006: 76.796.491 ######################################
2007: 74.096.973 #####################################
2008: 73.472.267 ####################################
2009: 67.290.760 #################################
2010: 72.000.290 ####################################
2011: 69.888.739 ##################################
2012: 67.263.274 #################################
2013: 67.758.606 #################################
2014: 64.160.937 ################################
2015: 66.351.619 #################################
2016: 67.215.457 #################################
2017: 69.598.854 ##################################
2018: 66.565.408 #################################
2019: 67.962.416 #################################
2020: 60.634.876 ##############################
```


## Example: CO² Chart

* On <!-- .element: class="fragment" --> the next slide, you find Austria's CO² emissions in tons since 1946
  * [Source](https://ourworldindata.org/co2/country/austria)
  * Store the data in a file on your disk
* Read <!-- .element: class="fragment" --> the data from the file into your C# program
  * You need the data in an array.
  * Each array element represents a line in the file.
  * To get the data, you can use [`File.ReadAllLines`](https://learn.microsoft.com/en-us/dotnet/api/system.io.file.readalllines#system-io-file-readalllines(system-string)).
* For <!-- .element: class="fragment" --> each line:
  * Create <!-- .element: class="fragment" --> a separate method for processing each line
  * Split <!-- .element: class="fragment" --> each line into year and CO² emission
    * Use `line.Split(',')`
  * Convert <!-- .element: class="fragment" --> second array element into number
    * ⚠️ Don't use `int` for emissions as they are high numbers, use `long` instead ([read more](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types))
    * Use `long.Parse(data[1])`
  * Print <!-- .element: class="fragment" --> the year, the CO² emission as a number and a bar indicating the emission
    * For 80 million tons, the bar should have a length of 40 characters
    * Calculate length of bar for each CO² emission value: `long barLength = co2 * 40 / 80_000_000;`
    * 🔥 Tip: Generate a string with a repeated character: `string bar = new string('#', barLength);`


## Example: CO² Chart

[![](https://mermaid.ink/img/pako:eNp1U1Fv2jAQ_isn7wWmtEDoKEXaJo32jbaTmDRtCZqMc0msOXbkODCE-O87GwJs2h4Sn----77z-bxnwmTIZixXZitKbh18eUw1wNKR3UvCsurDzc0HWNZKuiT8oXFW6gK20pWQccfTVEvtDHBr-e7oVlJjswpcIcVTLHjjFuSflyh--tAfjv2LgcpYPKZ-PFAK7LAJmU86e80XxtS9HplgLCnW1hSWV_3-f5kIdMWlTaD6bI3ApvHgJDltguQqVHsVDvAX_BWIk2ezQaAzanIc8R7ehf99viuyZ3Tl33qXvgaFY6N8CHw3qfodcgucDjx_jS-9POvNjd6gdclp9ajuJnRbrdGGnC7qMz5xu0BdUClzrkSruENYk4YKTkpedwB4D8LE8BbuhjCA6fDHcBi-QHmmOXWUJL9RqclXK4nQm5EvJiJCX_0b8LPFhUMLFwEnq9OEnAkud-3bFe6632cRq9BWXGY0qHuPT5krscKUzcjM6aIbl7LoFAkbHyhRKQNbY1WWslQfiKetaVrxKZPOWDZztsWI8daZ5U6Lbn_EPEruh6tzKsMzpJQ9c7vaP5hCNo4IhdG5LLy_tYrcpXN1MxsMfPi2oHfQrm-FqQaNzPzrKjcPk8Eknkx5PMbJ_Zi_G48zsR49TPP4bpRn98NRzNnhELGa6-_GkH7OVYOH34ZePjU)](https://mermaid.live/edit#pako:eNp1U1Fv2jAQ_isn7wWmtEDoKEXaJo32jbaTmDRtCZqMc0msOXbkODCE-O87GwJs2h4Sn----77z-bxnwmTIZixXZitKbh18eUw1wNKR3UvCsurDzc0HWNZKuiT8oXFW6gK20pWQccfTVEvtDHBr-e7oVlJjswpcIcVTLHjjFuSflyh--tAfjv2LgcpYPKZ-PFAK7LAJmU86e80XxtS9HplgLCnW1hSWV_3-f5kIdMWlTaD6bI3ApvHgJDltguQqVHsVDvAX_BWIk2ezQaAzanIc8R7ehf99viuyZ3Tl33qXvgaFY6N8CHw3qfodcgucDjx_jS-9POvNjd6gdclp9ajuJnRbrdGGnC7qMz5xu0BdUClzrkSruENYk4YKTkpedwB4D8LE8BbuhjCA6fDHcBi-QHmmOXWUJL9RqclXK4nQm5EvJiJCX_0b8LPFhUMLFwEnq9OEnAkud-3bFe6632cRq9BWXGY0qHuPT5krscKUzcjM6aIbl7LoFAkbHyhRKQNbY1WWslQfiKetaVrxKZPOWDZztsWI8daZ5U6Lbn_EPEruh6tzKsMzpJQ9c7vaP5hCNo4IhdG5LLy_tYrcpXN1MxsMfPi2oHfQrm-FqQaNzPzrKjcPk8Eknkx5PMbJ_Zi_G48zsR49TPP4bpRn98NRzNnhELGa6-_GkH7OVYOH34ZePjU)


## Data For CO² Chart

```txt
1946,12760137
1947,17630039
1948,24487263
1949,26574257
1950,20894256
1951,23264090
1952,22069984
1953,21714546
1954,24505593
1955,29069986
1956,28204984
1957,29178806
1958,28086845
1959,27909903
1960,30784479
1961,31824045
1962,33864981
1963,36949060
1964,38896434
1965,38140552
1966,39208596
1967,39915572
1968,42297140
1969,44638407
1970,50631700
1971,52069098
1972,56071169
1973,60015526
1974,57294163
1975,54213685
1976,58203792
1977,55993691
1978,57226484
1979,61321326
1980,52024931
1981,55832893
1982,53565287
1983,51668238
1984,54214049
1985,54366320
1986,53728532
1987,57373914
1988,52937221
1989,53696289
1990,62140063
1991,65738192
1992,60236456
1993,60660781
1994,61034437
1995,64011231
1996,67355343
1997,67252097
1998,66886986
1999,65639881
2000,66138790
2001,70138688
2002,71942960
2003,77450503
2004,77667970
2005,79067961
2006,76796491
2007,74096973
2008,73472267
2009,67290760
2010,72000290
2011,69888739
2012,67263274
2013,67758606
2014,64160937
2015,66351619
2016,67215457
2017,69598854
2018,66565408
2019,67962416
2020,60634876
```

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
  * On the next slide, you find the most important commands for file and folder management


## File Management Cheat Sheet

| Command                               | Description                                                                   |
|---------------------------------------|-------------------------------------------------------------------------------|
| `cd my-folder`                        | Change current working directory to<br/>the *my-folder* sub-directory         |
| `cd ..`                               | Move the current working directory one<br/>folder up in the folder hierarchy  |
| `cd` (Windows),<br/>`pwd` (Linux)     | Print current working directory                                               |
| `mkdir myfolder`                      | Make a new folder called *my-folder* under<br/> the current working directory |
| `type poem.txt`                       | Print content of text file *poem.txt* on the screen                           |

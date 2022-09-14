# Tools

![Tools XKCD](https://imgs.xkcd.com/comics/tools.png)

Source: [xkcd.com](https://xkcd.com/), a huge source of funny tech and science comics


## KeePass

> Keep your online identities secure 🔒!

* Use <!-- .element: class="fragment" --> single sign-on wherever possible
  * Google identity, Microsoft account, GitHub account (more later), etc.
* Use <!-- .element: class="fragment" --> **Multi-Factor-Authentication** (MFA) wherever possible
  * SMS, fingerprint, face, etc.
* Store <!-- .element: class="fragment" --> all your passwords and other secrets in a **password keeper**
  * A good option is [*KeePass*](https://keepass.info/)
  * Have a **single, strong** password to open your password database
  * Let the password keeper **generate strong passwords** for you
  * **Never** use the same password on multiple sites

> Go and install [KeePass](https://keepass.info/)
<!-- .element: class="fragment" -->


## [Visual Studio Code](https://code.visualstudio.com) (short *VSCode*)

* In <!-- .element: class="fragment" --> this course, we will program with **Visual Studio Code**
  * Cross-platform (Windows, Linux, MacOS, [Browser](https://vscode.dev/))
  * Core is *Open Source Software* (OSS)
  * Lots of extensions to customize, extend, and personalize
* VSCode <!-- .element: class="fragment" --> works great for C# and .NET


## Your Job: Install VSCode

Go on and [install Visual Studio Code](https://code.visualstudio.com/docs/setup/setup-overview) on your computer.

![Wizard installs software](https://pbs.twimg.com/media/DNJ2KVUUIAAgkld?format=jpg&name=small) <!-- .element height="40%" width="40%" -->


## Recommended Extensions

<div class="container" data-markdown><div class="col" data-markdown>

* Must <!-- .element: class="fragment" --> have:
  * [C#](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)
  * [.NET Core Tools](https://marketplace.visualstudio.com/items?itemName=formulahendry.dotnet)
  * [Error Lens](https://marketplace.visualstudio.com/items?itemName=usernamehw.errorlens)
  * [C# XML Documentation Comments](https://marketplace.visualstudio.com/items?itemName=k--kato.docomment)
  * [Better Comments](https://marketplace.visualstudio.com/items?itemName=aaron-bond.better-comments)
  * [NuGet Package Manager GUI](https://marketplace.visualstudio.com/items?itemName=aliasadidev.nugetpackagemanagergui)
  * [EditorConfig for VS Code](https://marketplace.visualstudio.com/items?itemName=EditorConfig.EditorConfig)
  * [.NET Core Test Explorer](https://marketplace.visualstudio.com/items?itemName=formulahendry.dotnet-test-explorer)
* Optional <!-- .element: class="fragment" -->
  * [Code Spell Checker](https://marketplace.visualstudio.com/items?itemName=streetsidesoftware.code-spell-checker)
  * Choose a [great color theme](https://medium.com/quick-code/the-best-vs-code-themes-2022-9e9b648c4596) yourself...
  * ...or install great themes built by the community (e.g. [Material Theme](https://material-theme.site/))
  * [VSCode Icons](https://marketplace.visualstudio.com/items?itemName=vscode-icons-team.vscode-icons)
  * [TODO Highlight](https://marketplace.visualstudio.com/items?itemName=wayou.vscode-todo-highlight)
* Want <!-- .element: class="fragment" --> more? [Marketplace](https://marketplace.visualstudio.com/vscode)

</div><div class="col" data-markdown>

![VSCode with Extensions](https://dev-to-uploads.s3.amazonaws.com/uploads/articles/368q8h7a4buke0oaovz5.png)

</div></div>


## Your Job: Install Extensions

![This is your job](https://media.giphy.com/media/Obnxeh737Umpa/giphy.gif)


## VSCode Tip #1: Folder Management

* Create <!-- .element: class="fragment" --> **one folder dedicated to each course** on your computers hard disk
  * E.g. *C:\HTL\PRO* (Windows), */home/your.user/HTL/PRO* (Linux; replace *your.user* with your user's name)
* Create <!-- .element: class="fragment" --> a **subfolder for each exercise**
  * Consider a numbering schema (e.g. *0010-...*, *0020-...*)
  * E.g. *C:\HTL\PRO\0010-statements* (Windows), */home/your.user/HTL/PRO/0010-statements* (Linux)
* Whenever <!-- .element: class="fragment" --> you work on an exercise, **open the folder in VSCode**

<div class="container" data-markdown><div class="col" data-markdown>

![Open Folder](images/vscode-open-folder.png) <!-- .element height="75%" width="75%" -->
<!-- .element: class="fragment" -->

</div><div class="col" data-markdown>

![Open Folder from start screen](images/vscode-open-folder-startscreen.png) <!-- .element height="75%" width="75%" -->
<!-- .element: class="fragment" -->

</div></div>


## VSCode Tip #1: Folder Management

How to copy path from Explorer to VSCode?

<div class="container" data-markdown><div class="col" data-markdown>

![Explorer: Copy path](images/explorer-copy-path.gif)
<!-- .element: class="fragment" -->

</div><div class="col" data-markdown>

![Explorer: Copy as path](images/explorer-copy-as-path.png) <!-- .element height="60%" width="60%" -->
<!-- .element: class="fragment" -->

</div></div>


## VSCode Tip #2: Drag-n-Drop From Explorer

You can drag & drop files from/to explorer to/from VSCode

![Drag-and-drop from/to explorer](images/vscode-drag-drop-explorer.gif)


## VSCode Tip #3: Remember the Palette

![VSCode Open Palette](images/vscode-open-palette.png)

![VSCode Palette](images/vscode-palette.gif)
<!-- .element: class="fragment" -->


## VSCode Tip #4: Built-in Terminal

<div class="container" data-markdown><div class="col" data-markdown>

![VSCode Terminal](images/vscode-terminal.png)
<!-- .element: class="fragment" -->

* A <!-- .element: class="fragment" --> **terminal** is a command window where you can type in commands
  * Windows: E.g. *CMD*
  * Linux: E.g. *bash*
* Used <!-- .element: class="fragment" --> very frequently during programming with C#

</div><div class="col" data-markdown>

![VSCode New Terminal](images/vscode-new-terminal.gif)
<!-- .element: class="fragment" -->

</div></div>


## VSCode Tip #5: Keyboard Shortcuts ⌨️

> ⚡ They make you so much faster ⚡
<!-- .element: class="fragment" -->

* Keyboard <!-- .element: class="fragment" --> Shortcut [Poster for Windows](https://code.visualstudio.com/shortcuts/keyboard-shortcuts-windows.pdf)
* Keyboard <!-- .element: class="fragment" --> Shortcut [Poster for Linux](https://code.visualstudio.com/shortcuts/keyboard-shortcuts-Linux.pdf)

> 🖨️ them, put them beside you,<br/>ignore the 🐭, learn to ❤️ the ⌨️
<!-- .element: class="fragment" -->


## WinMerge

* Open Source tool to compare and merge files and folders
  * Very useful in many situations

> Go and install [WinMerge](https://winmerge.org/?lang=en)


## [GitHub](https://github.com)

<div class="container" data-markdown><div class="col" data-markdown>

* GitHub <!-- .element: class="fragment" --> is the one of the largest code repositories in the world
  * Home of many of many widely-used Open Source projects (e.g. [VSCode](https://github.com/microsoft/vscode), [Linux](https://github.com/torvalds/linux))
* We <!-- .element: class="fragment" --> are going to make use of GitHub a lot in this course
  * Starts in a few weeks

> Create a [GitHub user](https://github.com/signup)
<!-- .element: class="fragment" -->

> Install [GitHub Desktop](https://desktop.github.com/)
<!-- .element: class="fragment" -->

</div><div class="col" data-markdown>

![GitHub Octocat](images/octocat.png)

[Build Your Own Octocat](https://myoctocat.com/build-your-octocat/)

</div></div>


## Tools - We Are Ready to Code 🤩

![Fuiyoh!](https://c.tenor.com/89eNuq5ziYcAAAAC/fuiyoh-uncleroger.gif) <!-- .element height="50%" width="50%" -->

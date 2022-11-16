# Debugging

![First bug in computer](https://res.cloudinary.com/dtpgi0zck/image/upload/s--lymMLSW0--/c_fit,h_580,w_860/v1/EducationHub/photos/computer-bug.jpg)

[Image Source](https://education.nationalgeographic.org/resource/worlds-first-computer-bug)


## What is a Debugger?

* Program <!-- .element: class="fragment" --> used to test and spot errors in computer software
  * Indispensable tool for coding
* Debugger <!-- .element: class="fragment" --> can stop the program at specific locations or on specific conditions; examples:
  * Stop at line number
  * Stop at line number if variable has a certain value
  * Stop in case of an exception
* When <!-- .element: class="fragment" --> a program crashes, debuggers show the position of the error
  * Exceptions
* Debuggers <!-- .element: class="fragment" --> can run programs in a step-by-step mode
  * Useful e.g. for finding logic errors


## Debugging with Visual Studio Code

![Debug UI in VSCode](images/vscode-debugger.png)


## Prerequisites

* You <!-- .element: class="fragment" --> need to have the [*C# extension*](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) installed
* When <!-- .element: class="fragment" --> asked if you want to add *required assets to build and debug*, **say yes**!
  * This will add a folder *.vscode* to your project with important configuration data
  * Forgot to click yes? Simply close and reopen your folder, VSCode will ask again.

![Required assets](images/required-assets-debugging.png)
<!-- .element: class="fragment" -->


## Use Terminal During Debugging (1/2)

* If you want to use `Console.ReadLine` in the program to debug, switch to *integratedTerminal* in *launch.json*

![Switch to integrated terminal](images/integrated-terminal.png)


## Use Terminal During Debugging (2/2)

![Terminal during debugging](images/terminal-debugging.png)


## Tipps and Tricks for Debugging

* Start Debugging with **F5** or with *Start Debugging* button

![Start Debugging](images/start-debugging.png)


## Tipps and Tricks for Debugging

* Set <!-- .element: class="fragment" --> a breakpoint by clicking on red dot **or pressing F9** on the line you want to stop

![Setting a breakpoint](images/set-breakpoint.png)
<!-- .element: class="fragment" -->

* When <!-- .element: class="fragment" --> your program stopped on a breakpoint, you see values of local variables

![Local variables](images/debugging-local-vars.png)
<!-- .element: class="fragment" -->


## Tipps and Tricks for Debugging

* If <!-- .element: class="fragment" --> you hover over a variable name in the editor, you see its value when program has been stopped

![Hover over variable](images/hover-value.png)
<!-- .element: class="fragment" -->

* Continue <!-- .element: class="fragment" --> with program after breakpoint was hit with **F5**
  * Or *Continue* button in debugger control control bar
* Execute <!-- .element: class="fragment" --> next line in the program with **F10**
  * Or *Step Over* button in debugger control control bar
  * *F11* (*Step Into* button) will become important once we leared about methods


## Tipps and Tricks for Debugging

* You <!-- .element: class="fragment" --> can evaluate <span translate="no">&nbsp;expressions&nbsp;</span> using the *Watch* window

![Watch <span translate="no">&nbsp;expressions&nbsp;</span>](images/watch-expr.png)
<!-- .element: class="fragment" -->

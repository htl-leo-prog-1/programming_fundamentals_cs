# Code Blocks

![Curly Brace](https://i.kym-cdn.com/photos/images/facebook/002/374/702/714.png)

<span translate="no">Curly Brace</span>, from <span translate="no">&nbsp;[Cave Story](https://en.wikipedia.org/wiki/Cave_Story)</span>


## Video Lecture

<iframe width="560" height="315" src="https://www.youtube.com/embed/0kh5C5U2uhA" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>

[YouTube Playlist for course](https://youtube.com/playlist?list=PLhGL9p3BWHwsJN6kbQPOVZpEw2NXQXZQN)


## Grouping Code in Blocks

> Use **Curly Braces** to group *Statements* into blocks.

```cs [|1|3-8|10-15|17]
  Console.WriteLine("This stmt is at top-level");

┌───────────────────────────────────────────────┐
│ { ◄──────────────────────────────────────────────── Block starts here 
│   Console.WriteLine("This stmt is in");       │
│   Console.WriteLine("the first code block");  │
│ } ◄──────────────────────────────────────────────── Block ends here 
└───────────────────────────────────────────────┘

┌───────────────────────────────────────────────┐
│ {                                             │
│   Console.WriteLine("This stmt is in");       │
│   Console.WriteLine("the second code block"); │
│ }                                             │
└───────────────────────────────────────────────┘

Console.WriteLine("This stmt is at top-level again");
```


## Grouping Code in Blocks

> Blocks Can be Nested

```cs [|1-5,12-13|6-11]
┌─────────────────────────────────────────────────┐
│ { ◄──────────────────────────────────────────────── OUTER Block starts here 
│   Console.WriteLine("This stmt is in");         │
│   Console.WriteLine("the first code block");    │
│                                                 │
│  ┌───────────────────────────────────────────┐  │
│  │{ ◄──────────────────────────────────────────────── INNER Block STARTS here
│  │  Console.WriteLine("This stmt is in");    │  │
│  │  Console.WriteLine("the inner block");    │  │
│  │} ◄──────────────────────────────────────────────── INNER Block ENDS here
│  └───────────────────────────────────────────┘  │
│ } ◄──────────────────────────────────────────────── OUTER Block ends here 
└─────────────────────────────────────────────────┘
```


## Grouping Code in Blocks

> ⚠️ Pay **close attention** to not forget the closing `}`! ⚠️

Missing `}` are tricky to find!

![Code block error](images/CodeBlockError.png)
<!-- .element: class="fragment" -->


## Grouping Code in Blocks

> Proper **Indentation** makes spotting errors much easier

```cs [|2-4,7|5-6]
{
──►Console.WriteLine("This stmt is in");
──►Console.WriteLine("the first code block"); 
──►{
──► ─►Console.WriteLine("This stmt is in");
──► ─►Console.WriteLine("the inner block");
──►}
}
```


## Why Code Blocks?

![For what?](https://i.redd.it/c2hhyjljgks61.gif)


## Why Code Blocks?

* The <!-- .element: class="fragment" --> **visibility** of a variable is limited to a block
  * We say: The block is the **scope** of the variable
  * Variables are usable inside their block **and** in nested blocks

```cs [|1-6|8|10-12]
┌─────────────────────────────────────────────────┐
│ {                                               │
│   int answer = 42;  ◄────────────────────────────── Variable IS SCOPED to first code block
│   Console.WriteLine("The answer is " + answer); │
│ }                                               │
└─────────────────────────────────────────────────┘

Console.WriteLine("The answer is " + answer); ◄────── ⚠️💔 Does NOT work because variable answer IS NOT visible here

{
    Console.WriteLine("The answer is " + answer); ◄── ⚠️💔 Does NOT work because variable answer IS NOT visible here
}
```
<!-- .element: class="fragment" -->


## Why Code Blocks?

* You <!-- .element: class="fragment" --> can use the **same variable name in different code blocks**
  * You will have *different* variables although they have the *same name*
  * Reason: Different **scope** of the two variables

```cs [|4,12]
┌───────────────────────────────────────────────────────┐
│ {                                                     │
│   Console.Write("Please enter your name: ");          │
│   string name = Console.ReadLine()!; ◄────────────────── Variable SCOPED to first code block
│   Console.WriteLine("Your name is " + name);          │
│ }                                                     │
└───────────────────────────────────────────────────────┘

┌───────────────────────────────────────────────────────┐
│ {                                                     │
│   Console.Write("Enter your friend's name: ");        │
│   string name = Console.ReadLine()!; ◄────────────────── Variable SCOPED to second code block
│   Console.WriteLine("Your friend's name is " + name); │  This IS A DIFFERENT variable called `name`
│ }                                                     │
└───────────────────────────────────────────────────────┘
```
<!-- .element: class="fragment" -->


## Why Code Blocks?

* We <!-- .element: class="fragment" --> can add a **condition** to a code block
  * This is done with the `if` statement that you will learn about soon
  * The statements in the block will only be executed if the condition is true
* We <!-- .element: class="fragment" --> can repeat the execution of the block with a **loop**
  * There are multiple forms of loops, you will learn more about them soon
* We <!-- .element: class="fragment" --> can assign a name to a code blocks
  * Named code blocks are called **methods**
  * We can call methods wherever we need them in our code
  * You will learn more about methods later in this course


## Tell me more!

![Whaaat!?](https://c.tenor.com/VkvsmJYlumYAAAAC/whaat-huh.gif)

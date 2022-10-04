# Switch

![if or switch - confusion about what to choose](https://res.cloudinary.com/practicaldev/image/fetch/s--BnGuKNb1--/c_limit%2Cf_auto%2Cfl_progressive%2Cq_auto%2Cw_880/https://cdn.hashnode.com/res/hashnode/image/upload/v1636287323886/smiwyj8nh.png)


## `switch` <span translate="no">&nbsp;Statement&nbsp;</span> Is Kind of `if`

<div class="container" data-markdown><div class="col" data-markdown>

```cs[]
Console.Write("What is your grade? ");
int grade = int.Parse(Console.ReadLine()!);

if (grade == 1)
{
    Console.WriteLine("Wow, you are a genius!");
} else if (grade == 2 || grade == 3)
{
    Console.WriteLine("You are a good student!");
} else if (grade == 4)
{
    Console.WriteLine("You barely survivied.");
} else {
    Console.WriteLine("Sorry, you did not pass");
}
```
<!-- .element: class="fragment" -->

</div><div class="col" data-markdown>

```cs[]
Console.Write("What is your grade? ");
int grade = int.Parse(Console.ReadLine()!);

switch (grade)
{
    case 1:
        Console.WriteLine("Wow, you are a genius!");
        break;
    case 2:
    case 3:
        Console.WriteLine("You are a good student!");
        break;
    case 4:
        Console.WriteLine("You barely survivied.");
        break;
    default:
        Console.WriteLine("Sorry, you did not pass");
        break;
}
```
<!-- .element: class="fragment" -->

</div></div>

> Don't forget the **break**
<!-- .element: class="fragment" -->


## When to Use What?

* It <!-- .element: class="fragment" --> depends...
* Try <!-- .element: class="fragment" --> to choose the selection <span translate="no">&nbsp;statement&nbsp;</span> (`if` or `switch`) that is easier to understand in your case
  * Sometimes, both options are ok and it doesn't really matter


## Exercise: Calculator

* Let <!-- .element: class="fragment" --> the user enter two numbers
* Ask <!-- .element: class="fragment" --> the user for an operation that she wants to perform (+, -, \*, or \/)
* Perform <!-- .element: class="fragment" --> the selected operation and print the result
  * Use a `switch` <span translate="no">&nbsp;statement&nbsp;</span> or <span translate="no">&nbsp;expression&nbsp;</span> in your solution
* Example <!-- .element: class="fragment" --> output:

```txt
First value: 10
Second value: 15
Operation (+, -, *, or /): +
The result is 25
```
<!-- .element: class="fragment" -->


## Exercise: 🪨📃✂️🦎🖖

> Change *rock, paper, scissors, lizard, spock*<br/>from `if` to `switch`


## Pro Tips

![We are very professional](https://www.meme-arsenal.com/memes/20c8fb489b732dc6ed6512c257f40924.jpg)


## `switch` <span translate="no">&nbsp;Expressions&nbsp;</span>

> `switch` can also be used as an **<span translate="no">&nbsp;expression&nbsp;</span>**

<div class="container" data-markdown><div class="col" data-markdown>

```cs[]
Console.Write("What is your grade? ");
int grade = int.Parse(Console.ReadLine()!);

if (grade == 1)
{
    Console.WriteLine("Wow, you are a genius!");
} else if (grade is 2 or 3)
{
    Console.WriteLine("You are a good student!");
} else if (grade == 4)
{
    Console.WriteLine("You barely survivied.");
} else {
    Console.WriteLine("Sorry, you did not pass");
}
```

</div><div class="col" data-markdown>

```cs[|4-10]
Console.Write("What is your grade? ");
int grade = int.Parse(Console.ReadLine()!);

var message = grade switch
{
    1 => "Wow, you are a genius!",
    2 or 3 => "You are a good student!",
    4 => "You barely survivied.",
    _ => "Sorry, you did not pass"
};
Console.WriteLine(message);
```

</div></div>

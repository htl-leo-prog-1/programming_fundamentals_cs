# Functions

![Math dance](https://c.tenor.com/MjdDlyCEARcAAAAC/math-dance.gif)


## What is a Function?

> Assign a name to a code block
<!-- .element: class="fragment" -->

* Particularly <!-- .element: class="fragment" --> important if you need the block multiple times
  * Can you remember: Don't repeat yourself (DRY)
* Call <!-- .element: class="fragment" --> the code blick using the assigned name
* Other <!-- .element: class="fragment" --> names for functions are *methods* and *procedures*


## What is a Function?

```cs[|1-8|10-13]
  ┌──────────────────────────────────────────────────── Return type of the function
  │
┌─▼────────────────────────────────────────────┐◄────── Function definition
│void SayHello()                               │
│{                                             │
│  Console.WriteLine("Hello World!");          │
│}                                             │
└──────────────────────────────────────────────┘

┌───────────────┐◄───────────────────────────────────── Function call
│// Say hello   │
│SayHello();    │
└───────────────┘

// Say hello again using another function call
SayHello();
```


## What is `void`?

* Function <!-- .element: class="fragment" --> returned **void**
  * `void SayHello() { ... }`
* Means <!-- .element: class="fragment" --> that the function **does not return anything**
  * It has no return type
* You <!-- .element: class="fragment" --> will shortly see functions returning something useful


## Function With Return Value

```cs[|1-5|5-19|10-12|21-23]
  ┌────────────────────────── Return type of the function
  │
┌─▼──────────────┐◄────────── Function SIGNATURE
│bool IsSunday() │
├────────────────┴──────────────────────────────────────┐◄── Function BODY
│{                                                      │
│    // Check if today is a Sunday                      │
│    if (DateTime.Today.DayOfWeek == DayOfWeek.Sunday)  │
│    {                                                  │
│       ┌────────────────┐◄── End function execution, specify RETURN VALUE
│       │return true;    │                              │
│       └────────────────┘                              │
│    }                                                  │
│    else                                               │
│    {                                                  │
│        return false;                                  │
│    }                                                  │
│}                                                      │
└───────────────────────────────────────────────────────┘
 
┌────────────────┐◄────────── Call function and PROCESS RETURN VALUE
│if (IsSunday()) │
└────────────────┘
 {
     Console.WriteLine("Sunday, funday, better than a monday!");
 }
```


## What is `DateTime`?

* It <!-- .element: class="fragment" --> is a **Structure** provided by .NET
  * We will learn a lot more about structures later
* Its <!-- .element: class="fragment" --> full name is `System.DateTime`
* Represents <!-- .element: class="fragment" --> a point in time (i.e. date + time of day)
  * Provides useful methods for working with points in time
* Examples <!-- .element: class="fragment" -->:
  * Get the current date + time with `DateTime.Now`
  * Get the current date (with time 00:00:00) with `DateTime.Today`


## Function With Return Value

The <!-- .element: class="fragment" --> following code...

```cs
bool IsSunday()
{
    if (DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
    {
        return true;
    }
    else
    {
        return false;
    }
}
```
<!-- .element: class="fragment" -->

can <!-- .element: class="fragment" --> be written shorter:

```cs
bool IsSunday()
{
    return DateTime.Today.DayOfWeek == DayOfWeek.Sunday;
}
```
<!-- .element: class="fragment" -->


## Function With Parameter

```cs[|1-5|13-14]
                                ┌───────────────────────────────────── Function parameter
                                │
┌───────────────────────────────▼────────────┐
│double CalculateAreaOfCircle(double radius) │
└────────────────────────────────────────────┘
 {
    return Math.PI * radius * radius;
 }

 Console.Write("Please enter radius: ");
 double radius = double.Parse(Console.ReadLine()!);
                                   ┌─────────────────────────────┐◄─── Call function and PROCESS RETURN VALUE
 Console.WriteLine($"Circle area: {│CalculateAreaOfCircle(radius)│}");
                                   └─────────────────────────────┘
```


## Functions With Parameters

* A <!-- .element: class="fragment" --> function can have 0..n parameters
* The <!-- .element: class="fragment" --> parameter is like a local variable inside the function's code block
  * Remember what we leared about code blocks and **<span translate="no">&nbsp;scope&nbsp;</span>** of variables?
  * The <span translate="no">&nbsp;scope&nbsp;</span> of the parameter is the function's body
* By <!-- .element: class="fragment" --> default, parameters of basic data types (e.g. integer, floating point numbers, boolean) are **copied**
  * The function cannot change variables of the caller
  * This is called **call by value**
  * There is also *call by reference*, which we will learn more about later


## Function With Parameter

<svg style="height: 325px; width: 850px;">
  <defs>
    <marker id="arrowhead" markerWidth="10" markerHeight="7" refX="0" refY="3.5" orient="auto">
      <polygon points="0 0, 10 3.5, 0 7" />
    </marker>
  </defs>

  <g>
    <rect class="border" x="0" y="0" width="380" height="130"  />
    <g transform="translate(10, 20)">
      <text class="code" x="0" y="0" font-size="20" fill="black">
        <tspan x="0">int number1 = 17;</tspan>
        <tspan x="0" dy="1.2em">int number2 = 21;</tspan>
        <tspan x="0" dy="1.2em">&nbsp;</tspan>
        <tspan x="0" dy="1.2em">int largerNumber = <tspan class="highlight">GetLargest</tspan>(number1, number2);</tspan>
      </text>
    </g>
  </g>

  <g transform="translate(470, 63)">
    <text class="note" x="0" y="0" font-size="20" fill="black">Function <tspan class="code">GetLargest</tspan> is called.</text>
  </g><!-- .element: class="fragment" -->

  <g>
    <text class="note" x="340" y="15" font-size="20" fill="black">Caller</text>
  </g><!-- .element: class="fragment" -->

  <g transform="translate(70, 100)">
    <rect class="border" x="0" y="0" width="380" height="180"  />
    <g transform="translate(10, 20)">
      <text class="code" x="0" y="0" font-size="20" fill="black">
        <tspan x="0">int <tspan class="highlight">GetLargest</tspan>(int n1, int n2)</tspan>
        <tspan x="0" dy="1.2em">{</tspan>
        <tspan x="0" dy="1.2em">&nbsp;&nbsp;if (n1 > n2)</tspan>
        <tspan x="0" dy="1.2em">&nbsp;&nbsp;{</tspan>
        <tspan x="0" dy="1.2em">&nbsp;&nbsp;&nbsp;&nbsp;return n1;</tspan>
        <tspan x="0" dy="1.2em">&nbsp;&nbsp;}</tspan>
        <tspan x="0" dy="1.2em">&nbsp;&nbsp;else</tspan>
        <tspan x="0" dy="1.2em">&nbsp;&nbsp;{</tspan>
        <tspan x="0" dy="1.2em">&nbsp;&nbsp;&nbsp;&nbsp;return n2;</tspan>
        <tspan x="0" dy="1.2em">&nbsp;&nbsp;}</tspan>
        <tspan x="0" dy="1.2em">}</tspan>
      </text>
    </g>
  </g><!-- .element: class="fragment" -->

  <g transform="translate(70, 100)">
    <text class="note" x="340" y="15" font-size="20" fill="black">Callee</text>
  </g><!-- .element: class="fragment" -->

  <g transform="translate(235, 68)">
    <line x1="30" y1="0" x2="0" y2="35" marker-end="url(#arrowhead)" />
    <line x1="90" y1="0" x2="55" y2="35" marker-end="url(#arrowhead)" />
  </g><!-- .element: class="fragment" -->

  <g transform="translate(470, 92)">
    <text class="note" x="0" y="0" font-size="20" fill="black">Values are <tspan class="highlight">copied</tspan>. Data types <tspan class="highlight">must match</tspan>!</text>
  </g><!-- .element: class="fragment" -->

  <g transform="translate(470, 119)">
    <text class="note" x="0" y="0" font-size="20" fill="black">
      <tspan x="0"><tspan class="code">n1</tspan> and <tspan class="code">n2</tspan> are <tspan class="highlight">local variables</tspan> inside the function.</tspan>
      <tspan x="0" dy="1.2em">If we change them, <tspan class="code">number1</tspan> and <tspan class="code">number2</tspan> are <tspan class="highlight">not influenced</tspan>!</tspan>
    </text>
  </g><!-- .element: class="fragment" -->

  <g transform="translate(50, 0)">
    <line x1="55" y1="175" x2="0" y2="175" />
    <line x1="55" y1="230" x2="0" y2="230" />
    <line x1="0" y1="230" x2="0" y2="80" marker-end="url(#arrowhead)" />
  </g><!-- .element: class="fragment" -->

  <g transform="translate(470, 170)">
    <text class="note" x="0" y="0" font-size="20" fill="black">
      <tspan x="0">Return value is <tspan class="highlight">copied</tspan> into <tspan class="code">largerNumber</tspan>.</tspan>
    </text>
  </g><!-- .element: class="fragment" -->

</svg>

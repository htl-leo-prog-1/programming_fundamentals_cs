# Method Parameters

![Mixing table](https://cdn.pixabay.com/photo/2018/11/07/18/29/mixer-3800914_960_720.jpg)


## Method With Parameter

```cs[|1-5|12-14]
                                ┌───────────────────────────────────── Method parameter
                                │
┌───────────────────────────────▼────────────┐
│double CalculateAreaOfCircle(double radius) │
└────────────────────────────────────────────┘
 {
    return Math.PI * radius * radius;
 }

 Console.Write("Please enter radius: ");
 double radius = double.Parse(Console.ReadLine()!);
               ┌─────────────────────────────┐◄─────────────────────── Call method and PROCESS RETURN VALUE
 double area = │CalculateAreaOfCircle(radius)│;
               └─────────────────────────────┘
 Console.WriteLine($"Circle area: {area}");
```

Can <!-- .element: class="fragment" --> be written shorter (no need for variable):

```cs
 Console.WriteLine($"Circle area: {CalculateAreaOfCircle(radius)}");
```
<!-- .element: class="fragment" -->


## Methods With Parameters

* A <!-- .element: class="fragment" --> method can have 0..n parameters
* The <!-- .element: class="fragment" --> parameter is like a local variable inside the method's code block
  * Remember what we learned about code blocks and **<span translate="no">&nbsp;scope&nbsp;</span>** of variables?
  * The <span translate="no">&nbsp;scope&nbsp;</span> of the parameter is the method's body
* By <!-- .element: class="fragment" --> default, parameters of basic data types (e.g. integer, floating point numbers, bool) are **copied**
  * Changing parameter values does **not** change variables of the caller
  * This is called **call by value**
  * There is also *call by reference*, which we will learn more about later


## Method With Parameter

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
    <text class="note" x="0" y="0" font-size="20" fill="black">Method <tspan class="code">GetLargest</tspan> is called.</text>
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
      <tspan x="0"><tspan class="code">n1</tspan> and <tspan class="code">n2</tspan> are <tspan class="highlight">local variables</tspan> inside the method.</tspan>
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


## Quiz: What is the Output?

```cs
int number = 42;
int anotherNumber = 10;

int Add(int n1, int n2)
{
  int number = n1 + n2;
  return number;
}

int result = Add(number, anotherNumber);
Console.WriteLine($"{number} + {anotherNumber} = {result}");
```

* Result <!-- .element: class="fragment" --> is `42 + 10 = 52`
  * The variable `number` in `Add` is a new, local variable
  * It is **not** the same variable as `number` *outside* of `Add`
* Note: <!-- .element: class="fragment" --> We could make this shorter

```cs
int Add(int n1, int n2) => n1 + n2;
```
<!-- .element: class="fragment" -->


## Quiz: What is the Output?

```cs
int value = 42;

int Double(int value)
{
  value = value * 2;
  return value;
}

Console.WriteLine($"{Double(value)} is the double of {value}");
```

* Result <!-- .element: class="fragment" --> is `84 is the double of 42`
  * The parameter `value` in `Double` is a new, local variable
  * It is **not** the same variable as `value` *outside* of `Double`
* Note: <!-- .element: class="fragment" --> We could make this shorter

```cs
int Double(int value) => value * 2;
```
<!-- .element: class="fragment" -->


## Exercise: Max

* Write a method that returns the maximum value from two given integer parameters
  * Example method call: `int maximum = Max(100, 50);`
* Verify that the result is correct
  * Call the method with the following parameters
  * Print the parameters and the results on the screen
  * Check results for correctness

| Value 1 | Value 2 | Expected Result|
|--------:|--------:|---------------:|
| 100     | 50      | 100            |
| -10     | -20     | -10            |
| 5       | -1      | 5              |
| 42      | 42      | 42             |


## Exercise: Max

<div class="mermaid">
  <pre>
    flowchart TD
      Start([Max value1, value2]) --> Compare{value1 > value2}
      Compare -- yes --> V1[return value1]
      Compare -- no --> V2[return value2]
      V1 --> Stop([End])
      V2 --> Stop([End])
  </pre>
</div>


## Exercise: Min

* Copy the previously created method and change it so that it returns the minimum value
* Verify that the result is correct

| Value 1 | Value 2 | Expected Result|
|--------:|--------:|---------------:|
| 100     | 50      | 50             |
| -10     | -20     | -20            |
| 5       | -1      | -1             |
| 42      | 42      | 42             |


## Exercise: Advanced Max and Min

* Copy the previously created methods and change it so that they can handle **three** parameter values

| Value 1 | Value 2 | Value 3 | Expected Result Min | Expected Result Max |
|--------:|--------:|--------:|--------------------:|--------------------:|
| 100     | 50      | 0       | 0                   | 100                 |
| -10     | -20     | -30     | -30                 | -10                 |
| 5       | -1      | 10      | -1                  | 10                  |
| 42      | 42      | 42      | 42                  | 42                  |


## Exercise: *Fizz Buzz*

* Print <!-- .element: class="fragment" --> all numbers between 1 and 30 on the screen
  * Replace every number divisible by three with the word *fizz*
  * Replace every number divisible by five with the word *buzz*
  * Replace every number divisible by three *and* five with *fizz buzz*
  * Separate elements with commas
* Put <!-- .element: class="fragment" -->the logic for turning each number in a string in a separate function<br/>
  `string ToFizzBuzz(int number) { ... }`
* Required <!-- .element: class="fragment" --> output:<br/>
  `1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, Fizz Buzz, 16, 17, Fizz, 19, Buzz, Fizz, 22, 23, Fizz, Buzz, 26, Fizz, 28, 29, Fizz Buzz`


## Exercise: *Fizz Buzz*

<div class="mermaid scrollable">
  <pre>
    flowchart TD
      Start([ToFizzBuzz]) --> Fizz[fizz = number % 3\n]
      Fizz --> Buzz[buzz = number % 5]
      Buzz --> Continue1((1))
      Continue2((1)) --> CompareFizzBuzz{fizz && buzz}
      CompareFizzBuzz -- true --> ReturnFizzBuzz[return fizz buzz]
      CompareFizzBuzz -- false --> Continue3((2))
      Continue4((1)) --> CompareFizz{fizz}
      CompareFizz -- true --> ReturnFizz[return fizz]
      CompareFizz -- false --> CompareBuzz{buzz}
      CompareBuzz -- true --> ReturnBuzz[return buzz]
      CompareBuzz -- false --> ReturnNumber[return number.ToString]
  </pre>
</div>


## Tip: [rosettacode.org](https://rosettacode.org/)

* The <!-- .element: class="fragment" --> website [rosettacode.org](https://rosettacode.org/) contains sample code for a large number of coding problems
  * See [*Explore*-section](http://rosettacode.org/wiki/Category:Programming_Tasks)
* You <!-- .element: class="fragment" --> can find solutions in *many different programming languages*
  * Example: [Fizz Buzz](https://rosettacode.org/wiki/FizzBuzz)


## Exercise: Rectangle

* Write a method that draws a rectangle on the screen
* The method gets the following parameters:
  * `x`: X coordinate of the upper left corner
  * `y`: Y coordinate of the upper left corner
  * `width`: Width of the rectangle
  * `height`: Height of the rectangle
  * `strokeCharacter`: Character that should be used to draw rectangle (e.g. `*`)
* Tip: Use the functions for cursor positioning and screen output that we already learned
  * E.g. `Console.SetCursorPosition`, `Console.Write`, `Console.Clear`
  * Try `'\u2588'` as the stroke character and see what's going to happen


## Exercise: Advanced Rectangle

Call the rectangle method in a loop to create the following pattern:

```txt
██████████  ██████████  ██████████  ██████████  ██████████
█        █  █        █  █        █  █        █  █        █
█     ██████████  ██████████  ██████████  ██████████  ██████████
█     █  █  █  █  █  █  █  █  █  █  █  █  █  █  █  █  █  █     █
██████████  ██████████  ██████████  ██████████  ██████████     █
      █        █  █        █  █        █  █        █  █        █
      ██████████  ██████████  ██████████  ██████████  ██████████
```

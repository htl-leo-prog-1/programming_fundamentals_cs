# Reference Parameters

![References Everywhere](https://media.makeameme.org/created/references-references-everywhere-4o5235.jpg)


## *Call-by-Value* vs. *Call-by-Reference*

* So <!-- .element: class="fragment" --> far, you have learned that parameters are **copied** from caller to callee
  * If the callee changes the value of a parameter, that does not influence the caller
  * We call this principle: **call-by-value**
* However, <!-- .element: class="fragment" --> you can mark a parameter to be a **reference parameter**
  * Use the `ref`-keyword in function definition and function call
  * The caller sees changes of the value of a parameter done by the callee
  * We call this principle: **call-by-reference**

![What?](https://cdnext.funpot.net/bild/funpot0000149554/21/Haeaeae.gif?c=560d47e9ad)
<!-- .element: class="fragment" -->


## Examples

### Call-by-Value<!-- .element: class="fragment" -->

```cs[|3-4|3,4,9,10]
int myNumber = 1;

// Call by value -> parameter value is copied
void TryToChangeMyNumnber(int myNumber)
{
    myNumber++;
}

TryToChangeMyNumnber(myNumber);
Console.WriteLine(myNumber); // Will print "1" because of call-by-value
```
<!-- .element: class="fragment" -->

### Call-by-Reference<!-- .element: class="fragment" -->

```cs[|3-4|3,4,9,10]
int myNumber = 1;

// Call by reference -> reference to original variable is passed
void TryToChangeMyNumber(ref int myNumber)
{
    myNumber++;
}

TryToChangeMyNumber(ref myNumber);
Console.WriteLine(myNumber); // Will print "2" because of call-by-reference
```
<!-- .element: class="fragment" -->


## Call By Reference

<svg style="height: 325px; width: 850px;">
  <defs>
    <marker id="arrowhead2" markerWidth="10" markerHeight="7" refX="0" refY="3.5" orient="auto">
      <polygon points="0 0, 10 3.5, 0 7" />
    </marker>
  </defs>

  <g>
    <rect class="border" x="0" y="0" width="380" height="130"  />
    <g transform="translate(10, 20)">
      <text class="code" x="0" y="0" font-size="20" fill="black">
        <tspan x="0">int myNumber = 1;</tspan>
        <tspan x="0" dy="1.2em">&nbsp;</tspan>
        <tspan x="0" dy="1.2em"><tspan class="highlight">TryToChangeMyNumber</span>(ref myNumber);</tspan>
        <tspan x="0" dy="1.2em">&nbsp;</tspan>
        <tspan x="0" dy="1.2em">Console.WriteLine(myNumber);</tspan>
        <tspan x="0" dy="1.2em">// Prints "2" because of call-by-reference</tspan>
      </text>
    </g>
  </g>

  <g transform="translate(470, 40)">
    <text class="note" x="0" y="0" font-size="20" fill="black">
      <tspan x="0">Method <tspan class="code">TryToChangeMyNumber</tspan> is called.</tspan>
      <tspan x="0" dy="1.4em">Parameter <tspan class="code">myNumber</tspan> is passed <tspan class="highlight">by reference</tspan>.</tspan>
    </text>
  </g><!-- .element: class="fragment" -->

  <g transform="translate(154, 0)">
    <rect x="0" y="33" width="87" height="25" class="highlight" />
    <line x1="43" y1="14" x2="43" y2="33" />
    <line x1="43" y1="14" x2="-10" y2="14" marker-end="url(#arrowhead2)" />
  </g><!-- .element: class="fragment" -->

  <g transform="translate(70, 110)">
    <rect class="border" x="0" y="0" width="380" height="90"  />
    <g transform="translate(10, 20)">
      <text class="code" x="0" y="0" font-size="20" fill="black">
        <tspan x="0">void <tspan class="highlight">TryToChangeMyNumber</tspan>(ref int myNumber)</tspan>
        <tspan x="0" dy="1.2em">{</tspan>
        <tspan x="" dy="1.2em">&nbsp;&nbsp;myNumber++;</tspan>
        <tspan x="0" dy="1.2em">}</tspan>
      </text>
    </g>
  </g><!-- .element: class="fragment" -->

  <g transform="translate(154, 0)">
    <rect x="106" y="114" width="115" height="25" class="highlight" />
    <line x1="163" y1="14" x2="163" y2="114" />
    <line x1="163" y1="14" x2="55" y2="14" marker-end="url(#arrowhead2)" />
  </g><!-- .element: class="fragment" -->

  <g transform="translate(470, 120)">
    <text class="note" x="0" y="0" font-size="20" fill="black">
      <tspan x="0">Parameter <tspan class="code">myNumber</tspan> is a <tspan class="highlight">reference</tspan> to the</tspan>
      <tspan x="0" dy="1.4em"><tspan class="highlight">existing variable</tspan> of the caller.</tspan>
    </text>
  </g><!-- .element: class="fragment" -->

  <g transform="translate(100, 139)">
    <rect x="0" y="4" width="90" height="25" class="highlight" />
    <line x1="90" y1="18" x2="217" y2="18" />
    <line x1="217" y1="18" x2="217" y2="11" marker-end="url(#arrowhead2)" />
  </g><!-- .element: class="fragment" -->

  <g transform="translate(470, 160)">
    <text class="note" x="0" y="0" font-size="20" fill="black">
      <tspan x="0">Changes value of caller's <tspan class="code">myNumber</tspan> variable</tspan>
    </text>
  </g><!-- .element: class="fragment" -->

</svg>


## Special Reference Parameter: `out`

* Parameter <!-- .element: class="fragment" --> marked with *out* are a special kind of reference parameter
  * *out*-Parameters are also call-by-reference
  * Caller **and** callee have to use `out` keyword
* Callee <!-- .element: class="fragment" --> **must assign a value** to an *out*-parameter before returning to caller

```cs[|1-3,6|11-13]
                                         ┌─────┐◄──────────────── out keyword in method definition
bool TryDivide(int dividend, int divisor,│ out │ int result)
                                         └─────┘
{
  ...
  result = ...; // Callee must assign a value to out parameter before returning!
  ...
}

...
                    ┌─────┐◄───────────────────────────────────── out keyword in method call
if (TryDivide(x, y, │ out │ result))
                    └─────┘
{ ... }
```
<!-- .element: class="fragment" -->


## Special Reference Parameter: `out`

Example for `TryParse`:

```csharp
string input = "1234";
int number;

//                      +--- Note the out parameter here!
//                      v
if (int.TryParse(input, out number)) // DOES NOT CRASH if input contains an invalid number
{
    System.Console.WriteLine(number);
}
else
{
    System.Console.WriteLine("Sorry, this is not a number");
}
```


## *Out*-Parameter Example

```cs[|1,7-8,11-12|18-21]
bool TryDivide(int dividend, int divisor, out int result)
{
  if (divisor == 0) // Division by zero is not defined for int.
  {
    // Note: You MUST assign a value to the out parameter even if it is not used.
    // Try commenting out the following line to see the difference.
    result = 0;
    return false; // Return false to indicate that the division was not successful.
  }

  result = dividend / divisor;
  return true; // Return true to indicate success
}

const int x = 84;
const int y = 2; // Try changing this value to 0 and see what happens.
int result;
if (TryDivide(x, y, out result))
  { Console.WriteLine($"I can divide {x} by {y} and the result is {result}"); }
else
  { Console.WriteLine($"{x} cannot be divided by {y}"); }
```

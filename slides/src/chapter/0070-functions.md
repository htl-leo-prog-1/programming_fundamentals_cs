# Functions

![Math dance](https://c.tenor.com/MjdDlyCEARcAAAAC/math-dance.gif)


## What is a Function?

> Assign <!-- .element: class="fragment" --> a name to a code block

* Particularly <!-- .element: class="fragment" --> important if you need the block multiple times
  * Can you remember: Don't repeat yourself (DRY)
* Call <!-- .element: class="fragment" --> the code blick using the assigned name


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

* Function returned **void**
* `void` means that the function does not return anything
  * It has no return type
* You will see functions returning values shortly


## SVG

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

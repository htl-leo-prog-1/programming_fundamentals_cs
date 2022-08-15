# Methods

![WTF is this method doing](https://s3.memeshappen.com/memes/WTF-is-this-method-doing--meme-35116.jpg)


## What is a Method?

> Assign a name to a code block
<!-- .element: class="fragment" -->

* Particularly <!-- .element: class="fragment" --> important if you need the block multiple times
  * Can you remember: Don't repeat yourself (DRY)
* Call <!-- .element: class="fragment" --> the code blick using the assigned name
* Other <!-- .element: class="fragment" --> names for methods are *functions* and *procedures*
* Read <!-- .element: class="fragment" --> [more](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods)
  * ⚠️ This documentation requires quite a bit of base knowledge about programming.
  * It's not particularly beginner-friendly. Once you will have gotten more experience, it will be a good reference.


## What is a Method?

```cs[|1-8|10-13]
  ┌──────────────────────────────────────────────────── Return type of the method
  │
┌─▼────────────────────────────────────────────┐◄────── Method definition
│void SayHello()                               │
│{                                             │
│  Console.WriteLine("Hello World!");          │
│}                                             │
└──────────────────────────────────────────────┘

┌───────────────┐◄───────────────────────────────────── Method call
│// Say hello   │
│SayHello();    │
└───────────────┘

// Say hello again using another method call
SayHello();
```


## What is `void`?

* Method <!-- .element: class="fragment" --> returned **void**
  * `void SayHello() { ... }`
* Means <!-- .element: class="fragment" --> that the method **does not return anything**
  * It has no return type
* You <!-- .element: class="fragment" --> will shortly see methods returning something useful


## Method With Return Value

```cs[|1-5|5-17|10-12, 15|19-21]
  ┌───────────────────────────────────────────────────────── Return type of the method
  │
┌─▼──────────────┐◄───────────────────────────────────────── Method SIGNATURE
│bool IsSunday() │
├────────────────┴──────────────────────────────────────┐◄── Method BODY
│{                                                      │
│    // Check if today is a Sunday                      │
│    if (DateTime.Today.DayOfWeek == DayOfWeek.Sunday)  │
│    {                                                  │
│       ┌────────────────┐◄───────────────────────────────── End method execution, specify RETURN VALUE
│       │return true;    │                              │
│       └────────────────┘                              │
│    }                                                  │
│                                                       │
│    return false;                                      │
│}                                                      │
└───────────────────────────────────────────────────────┘
 
┌────────────────┐◄───────────────────────────────────────── Call method and PROCESS RETURN VALUE
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


## Method With Return Value

The <!-- .element: class="fragment" --> following code...

```cs
bool IsSunday()
{
    if (DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
    {
        return true;
    }

    return false;
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


## Pro Tips

![Trust me - I'm a professional](https://memegenerator.net/img/instances/63457725.jpg)


## <span translate="no">Expression-Bodied Methods</span>

> Single-line methods can be shortened.

```cs
bool IsSunday()
{
    return DateTime.Today.DayOfWeek == DayOfWeek.Sunday;
}
```
<!-- .element: class="fragment" -->

...can be written as:
<!-- .element: class="fragment" -->

```cs
bool IsSunday() => DateTime.Today.DayOfWeek == DayOfWeek.Sunday;
```
<!-- .element: class="fragment" -->

* Remove <!-- .element: class="fragment" --> `{ return` and `}`, add `=>`
* Choose <!-- .element: class="fragment" --> whatever form you prefer

# The `for` Loop

![Hypnotic](https://64.media.tumblr.com/5f507b2deaa1fedf531636ed8cd95dfa/61d92977df3924b4-59/s500x750/274e24800946c366e6b934f3abfdca5516d6f205.gifv)


## The `for` Loop

```cs
for (int n = 0; n < 3; n++)
{
    Console.WriteLine(n);
}
```
<!-- .element: class="fragment" -->

```txt
            ┌────────────────────────────► Initialization
            │             ┌──────────────► Condition (boolean EXPRESSION)
            │             │          ┌───► Increment/decrement
      ┌─────┴─────┐   ┌───┴───┐   ┌──┴──┐
for ( │ int n = 0 │ ; │ n < 3 │ ; │ n++ │ )
┌─────┴───────────┴───┴───────┴───┴─────┴─────┐◄────── Repeated code block
│ {                                           │
│   Console.WriteLine(n);                     │
│ }                                           │
└─────────────────────────────────────────────┘
```
<!-- .element: class="fragment" -->

* Execution <!-- .element: class="fragment" --> order:
  * Initialization: <!-- .element: class="fragment" --> Evaluated **BEFORE condition**
  * Condition: <!-- .element: class="fragment" --> Evaluated **AFTER initialization** and **BEFORE each execution of code block**
  * Increment/decrement: <!-- .element: class="fragment" --> Executed **AFTER each execution of code block** and **BEFORE condition**


## The `for` Loop 💪

```cs
for (int n = 0; n < 3; n++)
{
    Console.WriteLine(i);
}
```

1. Declare <!-- .element: class="fragment" --> variable *n* and set it to *n = 0*.
2. Is <!-- .element: class="fragment" --> *n < 3*? Yes. So print value of *n* on the screen.
3. Increment <!-- .element: class="fragment" --> *n*, *n* is now *1*.
4. Is <!-- .element: class="fragment" --> *n < 3*? Yes. So print value of *n* on the screen.
5. Increment <!-- .element: class="fragment" --> *n*, *n* is now *2*.
6. Is <!-- .element: class="fragment" -->*n < 3*? Yes. So print value of *n* on the screen.
7. Increment <!-- .element: class="fragment" --> *n*, *n* is now *3*.
8. Is <!-- .element: class="fragment" --> *n < 3*? **No**. So end program.


## Exercise: `for` Loop

* Write <!-- .element: class="fragment" --> a program that generates the following outputs using `for`-loops
* Level <!-- .element: class="fragment" --> 1 (relatively easy):
  * All numbers between 1 and 10:<br/>
  * `1 2 3 4 5 6 7 8 9 10`
  * All numbers between 1 and 10 times 2:<br/>
    `2 4 6 8 10 12 14 16 18 20`
* Level <!-- .element: class="fragment" --> 2 (a bit harder):
  * All numbers between 1 and 20 that can be divided by 3 without a remainder:<br/>
    `0 3 6 9 12 15 18`
  * Sum of all numbers between 1 and 20 that can be divided by 3 without a remainder:<br/>
    `63`
* Level <!-- .element: class="fragment" --> 3 (can you make it?):
  * [Fibonacci sequence](https://en.wikipedia.org/wiki/Fibonacci_number) up to 34:<br/>
    `0 1 1 2 3 5 8 13 21 34`


## Exercise: Nested Loops, Level 1 😀

> Having loops inside of loops is quite common. We call this **nested loops**.

Example: Draw a square of 15 x 15 smiling faces <!-- .element: class="fragment" -->

```cs[|4|6]
// This enables emojis
Console.OutputEncoding = System.Text.Encoding.Default;

for (int y = 0; y < 15; y++)
{
    for (int x = 0; x < 15; x++)
    {
        Console.Write("😀");
    }

    Console.WriteLine();
}
```
<!-- .element: class="fragment" -->


## Exercise: Nested Loops, Level 2 😀🍕

<div class="container" data-markdown><div class="col" data-markdown>

* Change <!-- .element: class="fragment" --> the previous example
  * First line should consist of 😀
  * Second line should consist of 🍕
  * Third line should be 😀 again
  * Etc.

</div><div class="col" data-markdown>

![Loops different lines](images/loops-different-lines.png)
<!-- .element: class="fragment" -->

</div></div>


## Exercise: Nested Loops, Level 3 😀🍕

<div class="container" data-markdown><div class="col" data-markdown>

* Change <!-- .element: class="fragment" --> the previous example
  * First element should be 😀
  * Next element should be 🍕
  * Third element should be 😀 again
  * Etc.

</div><div class="col" data-markdown>

![Loops changing](images/loops-changing.png)
<!-- .element: class="fragment" -->

</div></div>


## Exercise: Number Guessing Game 🎲

1. Generate <!-- .element: class="fragment" --> a random number between 0 (including) and 99 (including)
2. Ask <!-- .element: class="fragment" --> the user for a guess
3. Compare <!-- .element: class="fragment" --> guess with random number
   * If user's guess is **lower** than random number, print *Too Low*
   * If user's guess is **greater** than random number, print *Too High*
   * If user's guess is **equal** to random number, print *Correct*
4. Repeat <!-- .element: class="fragment" --> steps 2 and 3 until the user has guessed correctly
   * Once the user has guessed correctly, end the program
5. Different <!-- .element: class="fragment" --> loops!
   * First, implement the game using a `while` loop
   * Next, change your app to use a `for` loop


## Exercise: Number Guessing Game 🎲

Example output:

```txt
A random number between 0 and 99 has been chosen.
Please guess: 25
Too Low
Please guess: 64
Too High
Please guess: 51
Correct
```


### Exercise: Paddle Game

<div class="container" data-markdown><div class="col" data-markdown>

* We <!-- .element: class="fragment" --> build a paddle game.
* You <!-- .element: class="fragment" --> can move a paddle around with the cursor keys.
* You <!-- .element: class="fragment" --> have to keep a "ball" in the "air" using your paddle.
* If <!-- .element: class="fragment" --> it hits the bottom of the window, the program ends.
* Goals <!-- .element: class="fragment" --> of this exercise:
  * Typing exercise
  * Read existing code, understand it

</div><div class="col" data-markdown>

![Paddle game](images/paddle.gif)

</div></div>


### Exercise: Paddle Game

> Here is the code. Type it in and make it work as fast as you can! You are *not* allowed to copy/paste it!

```cs
// Make the cursor invisible to speed up rendering
Console.CursorVisible = false;

// Reset screen
Console.Clear();
Console.ResetColor();

// A bunch of constants to configure our game
const int PADDLE_WIDTH = 10;
const int PADDLE_DISTANCE_FROM_BOTTOM = 5;
const int PADDLE_SPEED = 3;
const int INITIAL_FRAMES_BETWEEN_BALL_MOVEMENTS = 750;

// Position of the paddle. It starts horizontally in the middle of the screen.
int paddlePosX = (Console.WindowWidth - PADDLE_WIDTH) / 2;
int paddlePosY = Console.WindowHeight - PADDLE_DISTANCE_FROM_BOTTOM;

// Position of the ball. It starts horizontally in the middle of the screen.
int ballPosX = Console.WindowWidth / 2;
int ballPosY = 1;

// Speed vector of the ball.
int speedVectorX = 1;
int speedVectorY = 1;
int framesBetweenBallMovements = INITIAL_FRAMES_BETWEEN_BALL_MOVEMENTS;

// Helper variable to count frames
int frameCount = 0;

// End program when ball hits bottom of the screen
while (ballPosY != Console.WindowHeight)
{
    // Draw the paddle
    Console.SetCursorPosition(0, paddlePosY);
    for (var i = 0; i < Console.WindowWidth; i++)
    {
        if (i >= paddlePosX && i <= paddlePosX + PADDLE_WIDTH) { Console.Write("="); }
        else { Console.Write(" "); }
    }

    // Every FRAMES_BETWEEN_BALL_MOVEMENTS frames, move the ball
    if (frameCount == framesBetweenBallMovements)
    {
        // Delete the ball from it's old position
        Console.SetCursorPosition(ballPosX, ballPosY);
        Console.Write(' ');

        // Move ball
        ballPosX += speedVectorX;
        ballPosY += speedVectorY;

        // Did ball hit top of window or paddle?
        if (ballPosY == 0 && speedVectorY < 0
            || (ballPosY == paddlePosY
                && ballPosX >= paddlePosX && ballPosX <= paddlePosX + PADDLE_WIDTH))
        {
            // Turn speed vector's Y component around
            speedVectorY *= -1;

            // Increase ball speed
            framesBetweenBallMovements = Math.Max(framesBetweenBallMovements - 10, 0);
        }

        // Did ball hit left or right of window
        if (ballPosX == 0 && speedVectorX < 0
            || ballPosX == Console.WindowWidth && speedVectorX > 0)
        {
            // Turn speed vector's X component around
            speedVectorX *= -1;
        }

        // Reset frame count
        frameCount = 0;
    }
    else
    {
        // Increment frame count
        frameCount++;
    }

    // Draw ball
    Console.SetCursorPosition(ballPosX, ballPosY);
    Console.Write('O');

    // Check if key is available
    if (Console.KeyAvailable)
    {
        // Key handling
        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.LeftArrow:
                if (paddlePosX > PADDLE_SPEED)
                {
                    paddlePosX -= PADDLE_SPEED;
                }
                break;
            case ConsoleKey.RightArrow:
                if (paddlePosX < Console.WindowWidth - PADDLE_WIDTH - PADDLE_SPEED)
                {
                    paddlePosX += PADDLE_SPEED;
                }
                break;
        }
    }
}

Console.Clear();
```


### Exercise: What We Have Learned

* Hide/show <!-- .element: class="fragment" --> cursor with `Console.CursorVisible`
* Check <!-- .element: class="fragment" --> if the user pressed a key with `Console.KeyAvailable`
* We <!-- .element: class="fragment" --> can get/set cursor position
  * `Console.GetCursorPosition`
  * `Console.SetCursorPosition`

# Solver

## Introduction

Your job is to implement a solver algorithm for simple mathematic formulas (e.g. *10+20-5*).

## Basic Requirements (Level 0)

* Ask the user to enter a formula.
  * You have to ignore/remove all spaces from the formula before evaluating it.
* You can assume that formulas adheres to the following rules:
  * A formula can be empty. In this case, the result must be zero.
  * A formula can consist of a single number (e.g. *10*). In this case, the result must be the number.
  * A formula can consist of a sequence of numbers with operators (`+` and `-`) between them (e.g. *10+20-5*). In this case, your program must calculate the result accordingly.
  * If the formula is not empty, contained numbers are always integers. You do not need to deal with floating-point numbers.
  * If the formula is not empty, you can assume that there is no operator at the beginning. You do not need to consider cases like *-10+20* and *+10-20*.
* Print the result of the formula evaluation on the screen.

As a first step, simply try to solve the problem. Do not care too much about methods and efficient programming style. Your first priority in this level is to come up with a working solution. You will have to clean up your code in the next level.

Here is some test data to verify your implementation:

| Input                  | Result |
| ---------------------- | -----: |
| (Empty)                |      0 |
| 0                      |      0 |
| 5                      |      5 |
| 10                     |     10 |
| 1+2                    |      3 |
| 1-2                    |     -1 |
| 100-50                 |     50 |
| 0+1000-500             |    500 |
| 0+1+2+3+4+5+6+7+8+9+10 |     55 |

## Level 1

Now it is time to clean up your code:

* Structure your algorithm into meaningful methods. Here is one suggestion (add additional, meaningful methods yourself):
  * `Evaluate`: This method takes the formula (`string`) as a parameter and returns the result (`int`).
* Add comments to your code so that it is easy to read and understand.
* Use descriptive variable names (e.g. `temp1` is *not* a good, descriptive variable name).
* *Avoid* global variables, write *pure* methods. That means that your methods get all they need through input parameters and return the result as return values.
* Exchange solutions with classmates and ask them for feedback. Can they easily read and understand your code? Think about their feedback and change the code accordingly. This process is called *code review*.

## Level 2

Add support for *unary operators* at the beginning of your formula. That means that formulas like *-10+20* and *+10-20* must be supported and lead to correct results.

The test data of level 0 still has to lead to correct results. Here is some additional test data to verify your implementation:

| Input  | Result |
| ------ | -----: |
| +1     |      1 |
| -10    |    -10 |
| -10+20 |     10 |
| +10-20 |    -10 |

## Level 3

**Note:** This requirement is really hard to implement. You need to know and understand programming concepts that we did not cover in the course yet (in particular recursive methods or data structures like lists or stacks).

* Add support for `*` and `/` operators.
* Multiplication and division have higher precedence than addition and subtraction.
* All operations must be done with integers. You do not need to deal with floating-point numbers.

The test data of levels 0 and 2 still has to lead to correct results. Here is some additional test data to verify your implementation:

| Input   | Result |
| ------- | -----: |
| 10/5    |      2 |
| 0*1000  |      0 |
| 2*3+4*5 |     26 |
| 10*5-5  |     45 |

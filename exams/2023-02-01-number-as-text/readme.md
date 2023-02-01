# Number Formatter

## Introduction

Your job is to write a program that can turn numbers into long text (e.g. 1 becomes *one*, 11 becomes *eleven*, 1234 becomes *onethousandtwohundredthirtyfour*).

## Level 0

Write a method `DigitIntoLongText`. It receives an input parameter `number` (data type `int`) that contains a value between 0 and 9. It returns the text for the number:

| Value | Text  |
| ----: | ----- |
|     0 | zero  |
|     1 | one   |
|     2 | two   |
|     3 | three |
|   ... | ...   |
|     9 | three |

Write a program where the user can enter a digit between 0 and 9. Call `DigitIntoLongText` and pass the entered digit as the input parameter. Print the result of the method on the screen. Repeat asking until the user enters *quit*.

## Level 1

Write a method `NumberIntoLongText`. It receives an input parameter `number` (data type `int`) that contains a value between 0 and 19. The return value for 0 to 9 must be the same as from `DigitIntoLongText`. Here are examples for numbers greater equal 10:

| Value | Text     |
| ----: | -------- |
|    10 | ten      |
|    11 | eleven   |
|    12 | twelve   |
|   ... | ...      |
|    18 | eighteen |
|    19 | nineteen |

**Important:** Use the existing method `DigitIntoLongText` inside `NumberIntoLongText` at least for values between 0 and 9.

## Level 2

Extend the method `NumberIntoLongText` so that it supports parameter values between 20 and 99. Here are examples for numbers greater equal 20:

| Value | Text       |
| ----: | ---------- |
|    20 | twenty     |
|    21 | twentyone  |
|    22 | twentytwo  |
|   ... | ...        |
|    30 | thirty     |
|    31 | thirtyone  |
|   ... | ...        |
|    98 | ninetyone  |
|    99 | ninetynine |

**Important:** Use the existing method `DigitIntoLongText` inside `NumberIntoLongText` where possible (e.g. *twentytwo* contains the word *two*, wich is the result of `DigitIntoLongText` for 2).

## Level 3

Extend the method `NumberIntoLongText` so that it supports parameter values between 100 and 999. Here are examples for numbers greater equal 100:

| Value | Text                   |
| ----: | ---------------------- |
|   100 | onehundred             |
|   101 | onehundredone          |
|   102 | onehundredtwo          |
|   ... | ...                    |
|   998 | ninehundredninetyeight |
|   999 | ninehundredninetynine  |

**Important:** Avoid duplicating code. Use the existing code as much as possible. If it makes sense, structure your code into additional helper methods. This hint applies to the following levels, too.

## Level 4

Extend the method `NumberIntoLongText` so that it supports parameter values between 1_000 and 9_999. Here are examples for numbers greater equal 1_000:

| Value | Text                               |
| ----: | ---------------------------------- |
|  1000 | onethrousand                       |
|  1001 | onethrousandone                    |
|   ... | ...                                |
|  9998 | ninethousandninehundredninetyeight |
|  9999 | ninethourandninehundredninetynine  |

## Level 5

Extend the method `NumberIntoLongText` so that it supports negative values in the same value range. Here are some examples for negative numbers:

| Value | Text             |
| ----: | ---------------- |
|    -1 | minusone         |
| -1000 | minusonethousand |
|   ... | ...              |

## Level n

Still too easy? Extend your code so that it supports even larger value ranges (e.g. -999_999_999 to 999_999_999).

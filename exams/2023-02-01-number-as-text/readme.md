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

Sample output:

```txt
Enter a number: 0
DigitIntoLongText: zero
Enter a number: 5
DigitIntoLongText: five
Enter a number: 9
DigitIntoLongText: nine
Enter a number: 10
DigitIntoLongText: not a digit
Enter a number: quit
```

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

Sample output:

```txt
Enter a number: 5
NumberIntoLongTextLevel1: five
Enter a number: 15
NumberIntoLongTextLevel1: fifteen
Enter a number: 99
NumberIntoLongTextLevel1: not a valid number
Enter a number: 19
NumberIntoLongTextLevel1: nineteen
Enter a number: quit
```

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

Sample output:

```txt
Enter a number: 15
NumberIntoLongTextLevel2: fifteen
Enter a number: 50
NumberIntoLongTextLevel2: fifty
Enter a number: 51
NumberIntoLongTextLevel2: fiftyone
Enter a number: 99
NumberIntoLongTextLevel2: ninetynine
Enter a number: 100
NumberIntoLongTextLevel2: not a valid number
Enter a number: quit
```

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

Sample output:

```txt
Enter a number: 100
NumberIntoLongTextLevel3: onehundred
Enter a number: 150
NumberIntoLongTextLevel3: onehundredfifty
Enter a number: 999
NumberIntoLongTextLevel3: ninehundredninetynine
Enter a number: 1000
NumberIntoLongTextLevel3: not a valid number
Enter a number: quit
```

## Level 4

Extend the method `NumberIntoLongText` so that it supports parameter values between 1_000 and 9_999. Here are examples for numbers greater equal 1_000:

| Value | Text                               |
| ----: | ---------------------------------- |
|  1000 | onethrousand                       |
|  1001 | onethrousandone                    |
|   ... | ...                                |
|  9998 | ninethousandninehundredninetyeight |
|  9999 | ninethourandninehundredninetynine  |

Sample output:

```txt
Enter a number: 1000
NumberIntoLongTextLevel4: onethousand
Enter a number: 5000
NumberIntoLongTextLevel4: fivethousand
Enter a number: 5001
NumberIntoLongTextLevel4: fivethousandone
Enter a number: 9999
NumberIntoLongTextLevel4: ninethousandninehundredninetynine
Enter a number: 10000
NumberIntoLongTextLevel4: not a valid number
Enter a number: quit
```

## Level 5

Extend the method `NumberIntoLongText` so that it supports negative values in the same value range. Here are some examples for negative numbers:

| Value | Text             |
| ----: | ---------------- |
|    -1 | minusone         |
| -1000 | minusonethousand |
|   ... | ...              |

Sample output:

```txt
Enter a number: 1000
NumberIntoLongTextLevel5: onethousand
Enter a number: -1000
NumberIntoLongTextLevel5: minusonethousand
Enter a number: -9999
NumberIntoLongTextLevel5: minusninethousandninehundredninetynine
Enter a number: 9999
NumberIntoLongTextLevel5: ninethousandninehundredninetynine
Enter a number: quit
```

## Level n

Still too easy? Extend your code so that it supports even larger value ranges (e.g. -999_999_999 to 999_999_999).

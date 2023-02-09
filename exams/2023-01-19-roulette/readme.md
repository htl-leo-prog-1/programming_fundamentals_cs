# Roulette

We implement a simplified [*Roulette*](https://en.wikipedia.org/wiki/Roulette) casino game.

![Roulette](./Roulette_casino.JPG)

Roulette is a casino game where the players try to guess where a ball lands on a roulette wheel (see image above). The roulette wheel has 37 numbers (0 to 36). Zero is a special number, it is neither red nor black. The red numbers are 32, 19, 21, 25, 34, 27, 36, 30, 23, 5, 16, 1, 14, 9, 18, 7, 12, 3. All other numbers between 1 and 36 are black.

The player in our game starts with 100€. In each round, the player can bet between 10€ and the amount of money the player currently has. The game ends if the player has doubled her money or has lost so much money that she does not even have enough money for the minimum bet (10€).

## Game Rules - Minimum Requirements

You must solve the following requirements to get a positive grade in this exam:

1. At the beginning of the game, the player has 100€.
2. The game is played in rounds.
   1. At the beginning of each round, the player can enter how much money she wants to bet.
   2. Next, the player decides what she wants to bet on. Possibilities are:
      * *Even*: The player bets that the ball will land on an even number. Note that 0 does not count as an even number.
      * *Odd*: The player bets that the ball will land on an odd number. Note that 0 does not count as an even number.
      * *Single*: The player can enter a single number on which she thinks the ball will land.
   3. The computer calculates a random value between 0 and 36 and prints it on the screen (in a real casino, this is where the ball would roll in the roulette wheel).
   4. The computer calculates whether the player has won.
      * If the player had an *Even* or *Odd* bet and won, she gets double her bet back.
      * If the player had a *Single* bet and won, she gets 36 times her bet back.
      * If the player lost, the bet amount is lost.
   5. The game ends if the player has at least doubled her money or does not have enough money for the minimum bet left.

You **must** use methods to structure your code and avoid code duplication in order to pass the exam. Here are some suggestions for methods you could consider:

* `PrintWelcome`: Prints a welcome messege on the screen.
* `AskForBetType`: Ask for bet type (even/odd, single) including bet-specific parameter (in case of a single bet, the number on which the player bets her money).
* `AskForNumber`: Helper method that asks the user to enter a number between a given minimum and maximum. Asking is done until the user enters a valid number.
* `EvaluateResult`: Checks if the user has won and calculates the new amount of money that the user has after the round.

You can implement these methods, but you are allowed to add additional ones and/or implement different ones. However, keep in mind that duplicated code must be avoided by using methods!

## Game Rules - Advanced

You can implement the following requirements to get better grades. The grade depends on the completeness and quality of the implementation of the following requirements:

* *Red* bet:
  * The player can bet that the ball lands on a *red* number. In case the player wins, she gets double her bet back.
* *Black* bet:
  * The player can bet that the ball lands on a *black* number. In case the player wins, she gets double her bet back.
* *Dozen* bet:
  * The player can enter the dozen in which she thinks the ball will land (1 for numbers 1 to 12, 2 for numbers 13 to 24, 3 for numbers 25 to 36). Note that zero is \*not\* covered by any of the three dozens! In case the player wins, she gets double three times her bet back.

## Sample Output (Advanced Rules)

```txt
*** WELCOME TO ROULETTE! ***

Play until you have lost or doubled your money.

How much money do you want to bet (between 10 and 100)? 10
What do you want to bet on?
1) Even
2) Odd
3) Red
4) Black
5) Dozen bet
6) A single number
1
The random number is 17.
You lost 10€. You now have 90€.

How much money do you want to bet (between 10 and 90)? 20
What do you want to bet on?
1) Even
2) Odd
3) Red
4) Black
5) Dozen bet
6) A single number
3
The random number is 3.
You won 20€! You now have 110€.

How much money do you want to bet (between 10 and 110)? 50
What do you want to bet on?
1) Even
2) Odd
3) Red
4) Black
5) Dozen bet
6) A single number
5
Enter the dozen you want to bet on (1-3)
1
The random number is 14.
You lost 50€. You now have 60€.

How much money do you want to bet (between 10 and 60)? 30
What do you want to bet on?
1) Even
2) Odd
3) Red
4) Black
5) Dozen bet
6) A single number
6
Enter the number you want to bet on (0-36)
0
The random number is 4.
You lost 30€. You now have 30€.

How much money do you want to bet (between 10 and 30)? 40
Invalid input, try again
30
What do you want to bet on?
1) Even
2) Odd
3) Red
4) Black
5) Dozen bet
6) A single number
1
The random number is 7.
You lost 30€. You now have 0€.
```

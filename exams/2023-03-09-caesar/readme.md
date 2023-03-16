# Caesar Cipher

## Introduction

In this exercise, you practice string and char methods by implementing a simple encryption algorithm: A [Caesar Cipher](https://ciphereditor.com/explore/caesar-cipher). Before you start coding, make yourself familiar with [how a Caesar Cipher works](https://en.wikipedia.org/wiki/Caesar_cipher).

## Technical Requirement

* Do **not** use any global variables.
* Write a method `Encrypt` that does the encryption (for levels 0, 2, and 3).
* Write a method `Decrypt` that does the decryption (for levels 1, 2, and 4).

## Basic Requirements: Encryption (Level 0)

Write a console app in which the user can enter a text. The text is encrypted by applying a Caesar Cipher with right shift 7:

| Plain text | Ciphertext |
| ---------: | ---------- |
|          a | h          |
|          b | i          |
|          c | j          |
|        ... | ...        |
|          s | z          |
|          t | a          |
|        ... | ...        |
|          A | H          |
|          B | I          |
|        ... | ...        |

Only encrypt letters (a..z, A..Z), leave all other characters as they are.

To test your app, encrypt some messages and use [https://ciphereditor.com/explore/caesar-cipher](https://ciphereditor.com/explore/caesar-cipher) to verify that they can be decrypted correctly.

## Decryption (Level 1)

Write a second console app that can reverse the process, i.e. decrypt text by applying a Caesar Cipher with *left* shift 7:

| Ciphertext | Plain text |
| ---------: | ---------- |
|          h | a          |
|          i | b          |
|          j | c          |
|        ... | ...        |
|          z | s          |
|          a | t          |
|        ... | ...        |
|          H | A          |
|          I | B          |
|        ... | ...        |

Only decrypt letters (a..z, A..Z), leave all other characters as they are.

To test your app, encrypt some messages with your encoding program. Then, decrypt the result with your decoding program. The result must be the original plaintext.

## Encryption and Decryption Using ASCII/UTF8 Codes (Level 2)

Try to rewrite your encryption and decryption app so that it works with any shift between 1 and 25. To do that, you need to work with the ASCII/UTF8 code of each character. Here is a description of how that works:

* Let's assume that we have to encrypt the letter *a* with *shift 3*.
* In C#, we can add the number 3 to `'a'`: `int shifted = c + shift;`. The result is the ASCII/UTF8 code of *d*, which is 68 because the ASCII/UTF8 code of *a* is 65.
* We can turn the ASCII/UTF8 code 68 into the character *d* by using `char.ConvertFromUtf32`: `char resultingChar = char.ConvertFromUtf32(shifted);`.

The process becomes a bit more complicated when the shift operation requires to start couting at the beginning of the alphabet. Here is an example:

* Let's assume that we have to encrypt the letter *z* with *shift 3*.
* `'z'` plus 3 equals 93 as the ASCII/UTF8 code of z is 90.
* The problem is that 93 is not a letter in ASCII/UTF8. It is in fact the character `]`. Therefore, we have to restart counting at the beginning of the alphabet. The resulting, encrypted character is `c` (which has the ASCII/UTF8 code 67).

Try to come up with a solution to this problem. Tip: The *modulo* operator (`%`) might be very useful 😉. If you are not sure why, don't worry. You can use an `if` condition, too.

## Vigenère Cipher Encryption (Level 3)

**Note:** This challenge is significantly more complex than levels 0, 1, and 2. We have covered everything you need in our lectures. However, the algorithm is not simple.

Write a new variant of your *encryption* program. This time, replace the Caesar Cipher with the [Vigenère Cipher](https://ciphereditor.com/explore/vigenere-cipher). Before you start coding, make yourself familiar with [how a Vigenère Cipher works](https://en.wikipedia.org/wiki/Vigen%C3%A8re_cipher).

To test your app, encrypt some messages and use [https://ciphereditor.com/explore/vigenere-cipher](https://ciphereditor.com/explore/vigenere-cipher) to verify that they can be decrypted correctly.

## Vigenère Cipher Decryption (Level 4)

Still not enough? Write a *decryption* program based on the Vigenère Cipher, too.

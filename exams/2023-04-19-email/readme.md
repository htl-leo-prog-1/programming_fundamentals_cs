# Email Parser

## Introduction

You work in a company with a large CRM (Customer Relationship Management) database. It contains a lot of email addresses. Unfortunately, many of them are incorrect. The data is a big mess. It is your job to implement a command-line helper tool that analyzes and verifies email addresses.

## Basic Requirements

* Implement a command-line application in C#.
* The application receives an email address as the command-line argument. If the program is called without any argument, it must print out an error message (*Missing email address, please try again*).
* Any uppercase letters (*A*-*Z*) must be converted to lowercase letters (*a*-*z*) before further processing.
* A valid email address (e.g. *r.stropek@htl-leonding.ac.at*) consists of the following parts:
  1. Email prefix (e.g. *r.stropek*)
  2. One *@* sign
  3. Domain (e.g. *htl-leonding.ac.at*)
* Your program must check email addresses based on the following rule set:
  * Email prefixes may contain lowercase letters (*a*-*z*), digits (*0*-*9*), underscores (*_*), periods (*.*), and dashes (*-*).
  * Domains may contain lowercase letters (*a*-*z*), digits (*0*-*9*), periods (*.*), and dashes (*-*).
* If the email address is invalid, your program must print out *Invalid email address: {email address}*
* If the email address is valid, your program must print out the email prefix and the domain. Here is some test data illustrating input and output:

    | Input                           | Output                                                                                              |
    | ------------------------------- | --------------------------------------------------------------------------------------------------- |
    | r.stropek@htl-leonding.ac.at    | Email r.stropek@htl-leonding.ac.at consists of prefix r.stropek and domain htl-leonding.ac.at       |
    | fred@flintstones.com            | Email fred@flintstones.com consists of prefix fred and domain flintstones.com                       |
    | magic_chris.w1z@wizzard-123.com | Email magic_chris.w1z@wizzard-123.com consists of prefix magic_chris.w1z and domain wizzard-123.com |
    | abc                             | Invalid email address: abc                                                                          |
    | abc@@def.com                    | Invalid email address: abc@@def.com                                                                 |
    | abc@def@ghi.com                 | Invalid email address: abc@def@ghi.com                                                              |
    | abc@                            | Invalid email address: abc@                                                                         |
    | @def.com                        | Invalid email address: @def.com                                                                     |
    | abc..d@efg.com                  | Email abc..d@efg.com consists of prefix abc..d and domain efg.com                                   |
    | abc@def.comm                    | Email abc@def.comm consists of prefix abc and domain def.comm                                       |

* You must implement and use a method `IsValidEmailAddress`. This method receives the email address from the command line argument as the input parameter and returns true if the address is valid according to the rules defined above, otherwise false.
* You must implement and use a method `AnalyzeEmailAddress`. This method receives the email address from the command line argument and returns the output (see table above) as a string.
* You can add additional methods if you want.

## Advanced Requirements

* Your application must be able to process **one or many email addresses** in the command-line. If the program is called without any argument, it must print out an error message (*Missing email address(es), please try again*).
* There are additional validation rules:
  * Prefix: An underscore, period, or dash must be followed by at least one letter or number.
  * Domain: The last portion of the domain must be at least two characters, for example: *.com*, *.org*, *.cc*

The input/output combinations shown above must still lead to the same result as before, **except** for the last two examples. They are now invalid:

| Input          | Output                                |
| -------------- | ------------------------------------- |
| abc..d@efg.com | Invalid email address: abc..d@efg.com |
| abc@def.comm   | Invalid email address: abc@def.comm   |
| abc@def.c      | Invalid email address: abc@def.c      |

# Find Your Rover

![Rover](https://mars.nasa.gov/imgs/general/layout/overview/MER_twins_white_cyc.png)

## Introduction

You work as an engineer in a space program. You are responsible for monitoring a [rover](https://mars.nasa.gov/mer/) that is currently on a discovery mission on a foreign planet. It is important that you always know the coordinates of the rover relative to the base station.

A few minutes ago you received a message from the astronauts in the base station that the rover is gone. Nobody knows where it is. That's bad, that is really bad!

Luckily, the rover sends a log of all its movements to you. You job is to find the rover's coordinates based on the movement log. You decide to write a program into which you will enter the movement log. The program must calculate the coordinates of the rover and print it on the screen.

**Important:** This is an exercise for practicing **string functions and methods**. Structure your program using methods! Ask your teachers if you are unsure whether your approach regarding the usage of methods makes sense.

## Level 0

* The movement log is a series of the characters `>`, `<`, `V`, and `^`.
  * `>` means that the rover moved 1 meter to the East.
  * `<` means that the rover moved 1 meter to the West.
  * `V` means that the rover moved 1 meter to the South.
  * `^` means that the rover moved 1 meter to the North.
* Validate the input of the user. If the input is empty or it consists of any characters other than the one mentioned above, ask for another input. Continue asking until the user enters a valid movement log.
* Once the input is valid, calculate the rover's coordinates. Print it on the screen as follows:

| Input             | Output                                            |
| ----------------- | ------------------------------------------------- |
| `>>>`             | `The rover is 3m to the East`                     |
| `>>>VVVVV`        | `The rover is 3m to the East and 5m to the South` |
| `<<<<<^^^`        | `The rover is 5m to the West and 3m to the North` |
| `<<VV<<^^^^>>>>>` | `The rover is 1m to the East and 2m to the North` |
| `>>><<<VVV^^^`    | `The rover is in the base station`                |

Write the code and make sure that **all** of the above test cases produce the correct result.

Here is the real movement log of the rover. Who is the first to come up with the correct solution?

```txt
^V>>VVVV^>^V<><>VV<<>VVVV^>>><<<^<^^<>^^>VV^<^^<><VVV^V^V^>^^<^>><<>>VV>V>V^V^>VV<V^>^>V>VV<>V^>^>VV<<^>V<^<<V<^>><^<<^<V^VV^^<<VV<>V^V>V>V>>^VVV^V<^^^V>>>^V^^>^><<V^<^^^>^^>>>^^V^V>^V^<^>^<VVVV<^^V<<>>^<>>^VVV<>V><><^>>>^>>^V>V<V<<^^^V><VV<<<V>V<VVV>^^<<<>>VV>^>^^<>V><>>><>><^>^VV^V><><V>^>V>><><^VV>>>^^V^VVV<V>^^V^V^>^^^>^^>^V^>><V>V^<V<V>V<V><<^V<VV^^>^^^<><><V>^VVVVV><><>>^V><>VV^<<>VV<<V<>>V^<>V<V<<^<^>^^>V>><>^>>>V<<>^<<>V<VVV^^<VV^V>^<^^V<^VV<<^V<V><V>VV>V><<<^<V>VV^<<>VV^><^V<V^<<VV^>><V
```

## Level 1

You anticipate that the astronauts will want to know how far the rover is away from the base station.

* Calculate and print the linear distance between the base station and the location of the rover. Use Pythagoras' theorem for that. Make sure that you do the calculation using floating-point numbers, not integers. Print the distance with two decimal places.
* Also calculate and print the [Manhattan distance](https://en.wikipedia.org/wiki/Taxicab_geometry) between the base station and the location of the rover.

| Input          | Output                                             |
| -------------- | -------------------------------------------------- |
| `>>>`          | `Linear distance = 3m, Manhattan distance = 3m`    |
| `>>>VVVVV`     | `Linear distance = 5.83m, Manhattan distance = 8m` |
| `>>><<<VVV^^^` | `Linear distance = 0m, Manhattan distance = 0m`    |

Write the code and make sure that **all** of the above test cases produce the correct result.

Apply your logic to the real movement log of the rover from level 0. Who is the first to come up with the correct solution?

## Level 2

**Note:** If you feel really comfortable with this example, you can skip level 2 and jump right to level 3.

A colleague of yours tells you that the movement log of newer rovers is more advanced. Unfortunately, the lost rover is one of the new models. Therefore, its movement log contains a single digit after each direction character indicating how many meters the rover moved in the given direction. Here are some examples:

| Input        | Output                                            |
| ------------ | ------------------------------------------------- |
| `>3`         | `The rover is 3m to the East`                     |
| `>3V5`       | `The rover is 3m to the East and 5m to the South` |
| `<5^3`       | `The rover is 5m to the West and 3m to the North` |
| `<2V2<2^4>5` | `The rover is 1m to the East and 2m to the North` |
| `>3<3V3^3`   | `The rover is in the base station`                |
| `>1>1V2^1`   | `The rover is 2m to the East and 1m to the South` |

* Change your program so that it handles the new movement log format.
* Do not just change the calculation logic. You have to change the input validation, too!

Write the code and make sure that **all** of the above test cases produce the correct result.

## Level 3

Oh no, it turns out that you lost not just one rover, but two! The second one is an old model using the original movement log format.

* Change your program so that it can handle the old and the new format.
* Do not just change the calculation logic. You have to change the input validation, too!

| Input           | Output                                            |
| --------------- | ------------------------------------------------- |
| `>3`            | `The rover is 3m to the East`                     |
| `>>2`           | `The rover is 3m to the East`                     |
| `>2>`           | `The rover is 3m to the East`                     |
| `>>>VVVVV`      | `The rover is 3m to the East and 5m to the South` |
| `<<3<^^2`       | `The rover is 5m to the West and 3m to the North` |
| `<<VV<2^4>>>>>` | `The rover is 1m to the East and 2m to the North` |
| `>>><3V3^^^`    | `The rover is in the base station`                |

Write the code and make sure that **all** of the above test cases produce the correct result. Additionally, all the test cases from levels 0, 1, and 2 must also still work.

Here is the real movement log of the rover. Who is the first to come up with the correct solution?

```txt
^2^3^^1^>6<4>VV3^8>^4^V^1^3V3>3<V<>V<8V^2^V>^<<V5^<9V<>^1VV7^6V>V<8<6VVV4V<^7V<6V^6^^>V3>8<VV>^VV^1^V5VV<1<VVV8<<4>8>>6<5V<<4>6>4<4V>^<6<<V3>4VV<>V6^^V><<V1^>2V^V6>^V7<V9>5>6>8>V3>V2><<8V3^^V2V5V1<^^5<>1<V^8<7>1^V5V5<<>1VV4<<<1<V8<3V2>1V^<V<6<>6>^7<<7>^V7VV<V5V>7<^^^V9<3VV5<4<^>9>1V2V5<<<1<9<6<<8^>^>>>6<1^V1^V>^4<^V1>V^7V4^1^5^2>V9^^1^<6<V<8>>8<3V5^>3<<V5V6^4>3>^^>>>4V3<7VV7><<8<2<<9V^<^<1V^<6^7<6<9V9<2>5>><2>2^2>>V1>6<^7<7>^<7>4V^>6>V^><V<7V8<^V^3>^^<^^1^6><1>V>^^V5>^<7>8>^1<V<1V7>2V1>V>^9>^5<9<2>6^9>4^4^<4^8^9<3^<V9>5^5V1V5>7V8<V^V^7<8^6V2><V7>2V>2>1V3<VV>8^9<2^3V5V3>3<>2^9<V^5>1<7<V^5^<7>^<4VV>6<^3>2>^6>>4>V3<3><>6V5^4^4<<2^4^8>5V^9^4V7>5>3<8>^>4>2V1>6<2<<6<V>2<8^VV<^1>^4<7><V3V4V<5>3^7<<>V2^5<>V^9^4^9>>1VV9>V3>5>>^VV9V3V2^V6><<^2<3<9>6
```

## Level 4

**Note:** This level is pretty hard to implement. We covered all you need for it in school. However, the algorithm is not simple.

You apply your program to a real movement log but you do not find the rover. You carefully analyze the the movement log and you recognize that after a movement character can not just follow a single digit, but a multi-digit number, too.

* Change your program so that it can handle the old and the new format.
* Do not just change the calculation logic. You have to change the input validation, too!

| Input         | Output                                              |
| ------------- | --------------------------------------------------- |
| `>30<40^^V50` | `The rover is 10m to the West and 48m to the South` |

Write the code and make sure that **all** of the above test cases produce the correct result. Additionally, all the test cases from 0, 1, 2, and 3 must also still work.

Here is the real movement log of the rover. Who is the first to come up with the correct solution?

```txt
^>>3VV^V>V74>67V>V^^26>>78^92^^^16^48^31>V>41<V85VV88V<V9<34^^28<V4>87V92>80^63>73<^23>93>^48V25VVV59V^<^^^70V<8VV<3>63>V73^30>>90>34V21V5>36<73<89<<>39^<44>80^61VV>28VV64>^<51>6>>^57<30V<12^VV8V<V72V41^20<75^78<34V>^55^9<V>93^^>19>62^70VV<34<4V<>^><50>^<<V37^67^^>><58V<83<V43V44<>41^><42>>V97^61<19^>88V30<>66<75>V>48<62^38>8^30<78V1>76<35V73>30V<VV55V<>69>24V>66>^2^<93<><><>79>22^^<56V87^>>69>38<<^^82<^79^><99V57<<32^>28<35<^>70^>1<V79<V85^93^V>^63V88<85^55<<82><1>6V2^>84^83>77^V>38<VVV^61<^82^V71V<59<>67<89V<5>>V78<<19>>^<<50^1^>>>^97>V7^<<22>21<<86^86V68<>^^28^33^>76V^V76^^>^86V^^>>86^^95<<97^>34V75V<<<52^83<93<59V28<>74<44^V<>41>^<>75<28>>20V97<^V77^V^^71V>^32<>V<<^62^^2^>29<52^V65<>^V16<>V60>74<51V<82V<47VV8V47<75^2^79<V66^50^90V<^77<V57V35<9^^^><66>26>85V54V73<49>^65>^29V^72<34V28>10<58<92^68^VV^90><^16>53V^90>41^>79^V45>31<<<38>48^89^48^52V17VV<76V^99^V>80^32V1<8<<^27^15^^<><90^33<V62V53>18>^<>V77^V>60>67>V45^>59<45>52^76>4<>64V6^V<15V^V84^37<69^31<<32>29V69V74<11^
```

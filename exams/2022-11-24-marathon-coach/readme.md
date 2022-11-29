# Marathon Coach

## Introduction

People who run a marathon or half marathon typically have a time goal (e.g. run marathon under 4 hours = 240 minutes). While running, they measure the time per kilometer. You have to write a software that helps keeping runners on track regarding their time goal.

## Requirements

Minimum requirements:

1. First, ask the user if she wants to run a marathon (42.195km) or a half marathon (21.0975km).
2. Next, ask the user for the time goal in minutes (e.g. 240 minutes).
3. Calculate the necessary average time per km and print it on the screen.
   1. Example: 240 minutes for 42.195km means 240 / 42.195 = 5.688 minutes/km
4. During running, the user can enter how far she already ran and how much time already elapsed. You have to calculate a new average speed based on that. Therefore, do the following steps in a loop:
   1. Ask the user if she has already reached the finish line. Exit the loop if she has reached the finish.
   2. Ask the user how many kilometers she has already run (e.g. 10)
   3. Ask the user how many minutes have already elapsed since starting (e.g. 60)
   4. Print the required average pace for the rest of the race. In our example, 42.195 - 10 = 32.195km and 240 - 60 = 180 minutes are remaining. So the new average pace is 180 / 32.195 = 5.591 minutes/km.
5. At the end, ask the user for her total time in minutes. Calculate the overall average pace in minutes/km and print it on the screen.

Additional requirements:

* Add a third option called *custom* besides marathon and half marathon. It should allow the user to enter the distance manually. So if the user selects *custom*, you have to ask her for the distance in km.
  * Make sure that the entered distance is a positive number lower than 200. If not, ask again until the user entered a valid number.
* Check the distance input in the loop (step 4.2 above): If the user enters a distance greater than the total distance, print an error and ask again until the user entered a valid distance.
* As of today, no human can run faster than 2.7 minutes/km on long-distance runs. If the calculated pace in step 3 above is lower than or equal 2.7 minutes/km, print a warning message (e.g. *You will not be able to run that fast*). The program should not stop if the warning message is displayed.

## Flowchart for Minimum Requirements

![Flowchart](./flowchart.png)

[Source](https://mermaid.live/edit#pako:eNqFlE2PmzAQhv_KyCdWIh84CSRIbRU1bS-Vuurm1KUHC0xildjINqumUf57jYm9wKYqB7DH43fsZ2a4oFwUFKXoIEl9hP0u42CeJ02kDgL7eXjo2WAyeQ87pjThOX2ebdUvaBSVUAoJkuQU9LmmWcYJL0CzE4WDIBUwDifGG03V7Gcn5iSs3kdS5dsXKsmBPhqN53beVERTqCvCOS2AdKtQm2Wj3n7gXS_ADIqb4E1_JGnDPErGtQ0ws8O76u6A3tlu_d7wIABHwsys1dz-M-NMHTsQrOxYHIkCSUl-NNKlXXeifoPd3g0vO1Z07jfnD9fO2XvCmarwtuiFW4G90KTaGwijROjWbum4wN7T87aW7cthBFy0KKrqX8C98H3ifdFX5C7Kjfq9EAPqfYFPvAgC83LoX6FwEYLSzAjJhnPGD4PSxCMk7rCmSDkoASWR5lqSngize_26u6Q3TOwWNx3XL-4SYYh8MXU4jkorUivadcIgnEXYL-DJwNenzeneaxPcS1ufZdeLPpQcZHB0hBm8RXC_g_CwhbDL5n8iv2kn7NL6rfwqRN3rKm9zHZdxFKITlUavMH-oS-uWIX2kBiZKzbCgJWkqnaGMX40rabR4OvMcpVo2NERNXRg2O0bMv-2E0pJUylhrwn8IMZij9IJ-o3SxmM7XeBUtFzjG8yTaxCE6o3SC42Qar9fLeBltNmucLK4h-mMlommSRKs4wvFys4mSeL66_gUONMHn)

## Sample Output/Input

```txt
Type of run? (1) Marathon, (2) Half Marathon, (3) Custom 1
What is your time goal (in minutes)? 240
Your average pace must be 5.6878777106292215 minutes/km.

Did you already reached the finish (y/n)? n
Distance ran so far? 10
Elapsed time? 60
Your average pace will need to be 5.59093026867526 minutes/km.

Did you already reached the finish (y/n)? y

Total time? 240
Your average pace was 5.6878777106292215 minutes/km.
```

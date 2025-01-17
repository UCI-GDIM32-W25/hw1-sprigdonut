[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
Notes/ideas:
- player
    - movement wasd
    - space for planting
    - count seeds remaining
- seed planting
    - check for seeds remaining before placing prefab
- prefab
    - empty object with sprite renderer?
- UI
    - pass seed count to ui

## Devlog
My original plan ended up being accurate to the code I wrote, minus one tidbit. Originally, I was going to subtract seeds remaining from the maximum seeds, but Professor Reid provided both a seedsLeft and seedsPlanted variable, so I just used both variables. Like planned: every time update() is run, it checks for the player pressing space. When it detects the input, it triggers plantSeed() to run, which then collects the position of the player and instantiates the plant prefab (which is just an empty game object with a sprite renderer as orginally planned) at the player's location. Then it updates seedsLeft and seedsPlanted, before passing them into PlantCountUI.UpdateSeeds(). I also took time to make sprites and flip the player sprite depending on the if A or D is pressed. The counter UI also has an extra 0 in front of the count for aesthetic purposes.


## Open-Source Assets
If you added any other outside assets, list them here!

## Prof comments
It's totally fine to implement things differently than I suggested!

> Originally, I was going to subtract seeds remaining from the maximum seeds, but Professor Reid provided both a seedsLeft and seedsPlanted variable, so I just used both variables

This is also a correct way to build this. I like that you also built some other things differently than the example project. You're always encouraged to do so as long as the Features section of the assignment are clearly present and grade-able.

I'm not sure what your HW2 break-down looked like, but you might want to be a little more specific in your breakdowns. I'm not grading the quality of your in-class activities for HW1 or HW2, but your project break-downs may be a graded part of future assignments :)

Please consider formatting your break-down activities with the hyphen '-' symbol as suggested above, and remove the prompts. This will make it a lot easier for me to read. See the [README formatting guide here](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).

[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

notes/ideas:
counters for seeds remaining
check for seeds remaining before placing prefab
prefab: empty object with sprite renderer?


## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.


My original plan ended up being accurate to the code I wrote, minus one tidbit. Originally, I was going to subtract seeds remaining from the maximum seeds, but Professor Reid provided both a seedsLeft and seedsPlanted variable, so I just used both variable as counters. Like planned: every time update() is run, it checks for the player pressing space. When it detects the input, it triggers plantSeed() to run, which then collects the position of the player and instantiates the plant prefab (which is just an empty game object with a sprite renderer as orginally planned) at the player's location. Then it updates seedsLeft and seedsPlanted, before passing them into PlantCountUI.UpdateSeeds(). I also took time to make sprites and flip the player sprite depending on the if A or D is pressed. The counter UI also has an extra 0 in front of the count for aesthetic purposes.


## Open-Source Assets
If you added any other outside assets, list them here!


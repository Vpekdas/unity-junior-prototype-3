# unity-junior-sound-and-effects-prototype-3

## Screenshots

https://github.com/user-attachments/assets/c6c8be7b-1e6d-4b66-a340-59bf4ca2b538

## Table of Contents
1. [Description](#description)
2. [Installation](#installation)
3. [Run](#run)
4. [Credits](#credits)
5. [Contributing](#contributing)
6. [License](#license)

## Description

This prototype is part of the Junior Programmer Pathway from Unity Learn. Its purpose is to teach the fundamentals of sounds and effects through scripting in C#.
Each prototype includes:
- A Learning section that guides you through building core features step by step.
- A Challenge section where you're given a broken or incomplete project to fix and extend, testing your understanding and problem-solving skills.

### Purpose

The objective of this prototype is to create two simple games:

- **Runner** : A basic side-scrolling runner game where the player must jump to dodge obstacles.
- **Going up** : A vertical runner game where the player moves upward to avoid obstacles.

#### Fixing problems (For Going up) : 

- The player can’t control the balloon -> The balloon should float up as the player presses spacebar.
- The background only moves when the game is over -> The background should move at start, then stop when the game is over.
- No objects are being spawned -> Make bombs or money objects spawn every few seconds.
- Fireworks appear to the side of the balloon -> Make the fireworks display at the balloon’s position.
- The background is not repeating properly -> Make the background repeat seamlessly.
- The balloon can float way too high -> Prevent the player from floating their balloon too high.
- The balloon can drop below the ground -> Make the balloon appear to bounce off of the ground, preventing it from leaving the bottom of the screen. There should be a sound effect when this happens, too!
  
## Controls

**Both Game**
| **Key** | **Action**|
|:-------:|----------------|
| `SPACE` | Jump / Float up|

### Technologies used

- **Unity** – Version 6000.0.47f1
- **C#** – Used for gameplay scripting
  
### Challenges and Future Features

There weren’t any major challenges during development, as I already had experience with creating seamless background scrolling.

## Installation

You can download pre-built releases for your supported operating system from the GitHub Releases page. Available builds include:
- macOS
- Windows
- Linux

## Run

To run the program, simply double-click the executable file for your operating system.

### MacOS

Unzip and open the .app file.

### Windows

Unzip and double-click the .exe file.

### Linux

```bash
chmod +x Prototype_3_Linux.x86_64
./Prototype_3_Linux.x86_64
```

### Web

Play on [browser](https://vpekdas.github.io/unity-junior-sound-and-effects-prototype-3)

## Credits

This project is based on the Unity **Junior Programmer Pathway** by Unity Learn.
Many thanks to the instructors for their excellent step-by-step video tutorials and guidance.

## Contributing

To report issues, please create an issue here:  [issue tracker](https://github.com/Vpekdas/unity-junior-sound-and-effects-prototype-3/issues).

If you'd like to contribute, please follow the steps outlined in [CONTRIBUTING.md](CONTRIBUTING.md).

## License

This project is licensed under the [MIT License](LICENSE).

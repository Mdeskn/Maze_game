# Maze Game Project

Welcome to the Maze Game Project! This project is a simple maze game developed using Unity and C#. Navigate through the maze, pick up the key, unlock the door, and win the game!

## Features
- Maze navigation with a kitty player character.
- Key pickup mechanic.
- Door unlocking to win the game.

## Technologies Used
- Unity 2D
- C#

## Directory Structure
- **Project Folder:** Contains all the project files, including scripts, scenes, and assets. This is where you'll find the Unity project files that you can open and modify in Unity Editor.
- **Build Folder:** Contains the build game executable along with its dependencies. This folder includes the executable file that users can run to play the game without needing to build it themselves.

## Setup Instructions
1. Clone the repository to your local machine.
2. Open the project in Unity.
3. Navigate to the `main.unity` scene.
4. Start playing and enjoy the game!

## How to Play
- Use the arrow keys to move the kitty player character.
- Navigate through the maze to find the key.
- Once you have the key, head to the door to unlock it and win the game.

## Code Overview
- `keycon.cs`: Controls the behavior of the key game object. Destroys the key when the kitty player character collides with it.
- `moveplayer.cs`: Controls the movement of the kitty player character. Detects collisions with the key and door, triggering gameplay events.

## Running the Game
- Simply run the built game executable from the `Build` folder to play the game.

## Contributing
- Contributions to the project are welcome! Fork the repository, make your changes, and submit a pull request.

## Credits
- Game created by **Maede Eskandari Borujerdi**.
- Assets used in the game are downloaded from Canva.com.

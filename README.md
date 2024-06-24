# Rock Paper Scissors Game Console Application

## Overview

This console application simulates the classic game of Rock Paper Scissors where a player competes against an AI opponent. The game continues until one player reaches 3 points. This project demonstrates basic object-oriented programming principles and includes unit tests for game logic verification.

## Features

- Single-player mode: Player vs AI.
- Interactive console-based gameplay.
- Exception handling for invalid inputs.
- Unit tests using Xunit for core game logic.

## Project Structure

- **Program.cs**: Contains the entry point (`Main` method) for starting the game.
- **RPSGame.cs**: Manages game flow, round logic (`PlayRound`, `DetermineWinner`), and final score display.
- **Player.cs**: Represents a player with properties (`Name`, `Score`) and a method (`ChooseMove`) to select moves.
- **RPS_GameTest**: Contains unit tests to verify game logic using Xunit.

## How to Play :sun_with_face:

- Run the application.
- The game will prompt you to choose Rock (R), Paper (P), or Scissors (S).
- The AI opponent will make a random move.
- Results are displayed after each round, showing who won the round or if it was a tie.
- The game continues until either the player or the AI reaches 3 points.

##
```
Welcome to Rock Paper Scissors Game

Your Score - 0
AI Score - 0
------------------------------------------------------

Please Enter
 [R] for Rock
 [P] for Paper
 [S] for Scissors

> r
AI chooses Paper
You lose

Your Score - 0
AI Score - 1
------------------------------------------------------

Please Enter
 [R] for Rock
 [P] for Paper
 [S] for Scissors

> p
AI chooses Scissors
You lose

Your Score - 0
AI Score - 2
------------------------------------------------------

Please Enter
 [R] for Rock
 [P] for Paper
 [S] for Scissors

> s
AI chooses Rock
You win this round!

Your Score - 1
AI Score - 2
------------------------------------------------------

Your Score - 1
AI Score - 2
------------------------------------------------------

Please Enter
 [R] for Rock
 [P] for Paper
 [S] for Scissors

> r
AI chooses Scissors
You win this round!

Your Score - 2
AI Score - 2
------------------------------------------------------

Your Score - 2
AI Score - 2
------------------------------------------------------

Please Enter
 [R] for Rock
 [P] for Paper
 [S] for Scissors

> p
AI chooses Rock
You win this round!

Your Score - 2
AI Score - 3

You lose. 2 - 3
```
## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
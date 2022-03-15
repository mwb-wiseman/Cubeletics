![Cubeletics Title.png](https://github.com/mwb-wiseman/Cubeletics/blob/main/GDD%20Images/Cubeletics%20Title.png "Cubeletics Title")

## Introduction

This document outlines the plan for the development of an obstacle course running game with curated levels. This project is being undertaken for technical learning purposes (C# language, Unity engine).

__Key Learning Objectives__

- Experience the game development process from start to finish.
- Explore the different functionalities of the Unity engine and UI.
- Carefully consider UX design and engage with user feedback.

***

## GAME DESIGN

#### High Concept

Cubeletics is a 3D, single-player game in which the player moves a cube left and right as it slides endlessly forwards to avoid obstacles and reach the end of each level.

#### Summary Overview

The player navigates through 3 curated levels by moving left and right while the cube they control slides forwards relentlessly. They accumulate score the further along the course they go, achieving a maximum 1000 points if they make it to the end of the level.

At the end of the level an overlay appears congratulating the player, and then the next level loads automatically. The levels will scale in difficulty as the player progresses - the first is essentially a tutorial, the second encourages the player to navigate between narrow gaps, and the third will require that they use their learned skills.

__Key Features__

- Curated level design
- Difficulty gradiant across the levels

#### Gameplay

__First Minutes__

_Main Menu_

Beneath the title is listed the controls for the game. At the bottom is a button to start the game, and in the top left is a button to exit the application.

_In-Game_

The player's cube immediately starts sliding forwards, and can be moved left and right by pressing the 'W' and 'S' keys respectively. At the top of the screen is a printout of the player's current score, which increases as they move forward.

If the player hits an obstacle or falls off the side of the course the level resets.

__Gameflow__

![Cubeletics Gameflow.png](https://github.com/mwb-wiseman/Cubeletics/blob/main/GDD%20Images/Cubeletics%20Gameflow.png "Cubeletics Gameflow Diagram")

__Victory Conditions__

Navigate your way to the end of each linear level without hitting any obstacles or falling off the sides of the course.

__Number of Players__

Single player.

#### Art

![Cubeletics Art 1.png](https://github.com/mwb-wiseman/Cubeletics/blob/main/GDD%20Images/Cubeletics%20Art%201.png "Cubeletics Art 1")

![Cubeletics Art 2.png](https://github.com/mwb-wiseman/Cubeletics/blob/main/GDD%20Images/Cubeletics%20Art%202.png "Cubeletics Art 2")

#### Technical Aspects

Game to be built in Unity for Windows PC, with potential for further iOS build.

***

## MARKETING

#### Target Audience

The simplistic design will ensure this game is accessible to a broad audience. The game is quite challenging to provide longevity to the limited scope of the game's size, which will enhance appeal for players that enjoy working towards a clearly defined goal through practice and repetition.

#### Competitors

Comparable games from the market are ZigZag and Temple Run. The main difference between these games and Cubeletics is that they feature a procedurally generated level design. This provides a less tailored experience - the 3 levels of Cubeletics will be designed with a difficulty gradiant to provide players with scaling difficulty and level design that trains them to be better at the game.

***

## DEVELOPMENT

#### Milestone Schedule

1. Set up basic scene – player cube, course platform
2. Automated cube movement
3. Player inputs for cube movement
4. Camera positioning to follow player
5. Add obstacles and implement collision interactions
6. Design first level (will be game's final level)
7. Score accumulation and UI
8. Game over scripts and reset functionality
9. Win-condition overlay
10. Menu design and implementation
11. Design tutorial level
12. Design intermediate level
13. Implement scene transitions

#### Resources

1 Junior Developer
Unity (Personal)

#### Schedule

| Time | Objective | Date completed |
| --- | --- | --- |
| Day 1 | Milestone 1 | 27/04/20 |
| Day 2 | Milestone 2 & 3 | 28/04/20 |
| Day 3 | Milestone 4 & 5 | 29/04/20 |
| Day 4 | Milestone 6 | 30/04/20 |
| Day 5 | Milestone 7 | 01/05/20 |
| Day 6 | Milestone 8 & 9 | 04/05/20 |
| Day 7 | Milestone 10 | 05/05/20 |
| Day 8 | Milestone 11 | 06/05/20 |
| Day 9 | Milestone 12 | 07/05/20 |
| Day 10 | Milestone 13 | 08/05/20 |


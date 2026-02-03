# HW4
## Devlog

Alejandra Perez She/Her

From what I understand, the Player script is the one that controls the game logic, as it is responsible for detecting collisions and therefore acts as the controller. It communicates with other scripts, for example the WallPoint script, which detects the player and sends an event to update the UI (which acts as the view). These scripts communicate with each other through events, which is a good method for creating games because it helps reduce bugs and keeps the code more organized. This communication between scripts is made possible through events and the Singleton pattern implemented in the UI.

## Open-Source Assets
If you added any other assets, list them here!
- [Brackey's Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - sound effects
- [2D pixel art seagull sprites](https://elthen.itch.io/2d-pixel-art-seagull-sprites) - seagull sprites
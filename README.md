# Scripting_exercise_U232496

In this project, I have implemented several features to enhance the game's entertainment and user experience:

- I added a heart animation that spawns whenever a sheep is destroyed.

- I implemented sound effects for key game events: sheep destruction, shooting a hay bale, and sheep dropping off the edge of the ground.

- I implemented a condition where, if three sheep reach the edge of the ground, the game ends and all active sheep are cleared from the scene.

- I added a UI system to count destroyed sheep (represented by hearts) and dropped sheep (represented by crosses).

- I activated the start screen with a different camera view, allowing the player to transition from the title scene to the game scene.

- I added an interactive effect to the Start and Quit buttons, changing their color to grey to provide visual feedback to the player.

Finally, I would like to clarify that I am aware the sheep appear upside down, which causes the heart animation to also play horizontally rather than vertically. This is due to the sheep's forward vector currently pointing horizontally instead of towards the up axis. I attempted to rotate the prefabs to fix this, but it interfered with the sheep's movement. I have prioritized gameplay functionality for this submission while keeping this known issue in mind for future corrections.

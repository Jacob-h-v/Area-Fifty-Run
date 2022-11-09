# Area-Fifty-Run

Mini-Project

Project Name: Area Fifty-Run
Name: JHV

Overview of the Game:
The game is inspired by PacMan in the sense that the player finds themselves in a maze, being hunted by NPCs without any real way to fight back other than to run away. Unlike the original PacMan games, however, the game is in a dimly lit 3D space with the player navigating in first person view through narrow corridors and open halls, where enemies are rarely visible before they’re already very close. The idea is that the player should use sound as an early warning that enemies are nearby before turning a corner. The win condition is to gather all of the pickups scattered throughout the maze without losing all three given lives.

The main parts of the game are:
Player – A dapper looking capsule, looks like a cocktail sausage with a beard.
Camera – Game is in 1st person view only. Camera follows the player’s movements.
Pickups – 15 meteor fragments are scattered throughout the maze. Collecting all of them wins the game.
Enemies – Alien hovercrafts, spawned in set locations around the map. They each have different patrol patterns, and chase the player if they get too close.
Play field – A dimly lit maze with open halls, narrow corridors and various nooks and crannies.
Lives – The player is provided with three lives. Game ends if all lives are lost.
Game features:
The (lack of) lighting and the maze-like structure of the map makes it hard to recognize locations, increasing replayability.
Enemy sound levels are based on distance.
The game keeps track of a score
Project Parts:
Scripts:
CollisionDetector – Handles any interactions that occur when the player touches a pickup or an enemy.
CursorLock – Simply hides the cursor and locks it to the center of the screen.
EnemyBehavior – Controls enemy patrol and chasing logic, aided by the NavMeshAgent.
IGMenu – Controls active states for in-game menus and has methods for each of the buttons in the menus. Also contains the GameWon method, which is called from the CollisionDetector script, once the last pickup is collected.
MenuButtons – Controls active state for menus in the “Main Menu” scene, and has methods for each of the buttons in those menus.
PickupRotator – Adds rotation on multiple axes to the pickups.
PlayerCamera – Controls the camera’s movement, and rotates the player object with the camera along the x axis.
ScoreHandler – Keeps track of player’s score and lives.
PlayerMotor – Uses input from the InputManager script to move the player using the Character Controller component. Also contains ground check and gravity calculations.
InputManager – takes values from Unity’s Input System and calls movement functionality in the PlayerMotor script.
PlayerInput (Input folder) – Is an auto-generated script used by Unity’s Input System.
Models & Prefabs:
All models and prefabs are created using unity’s primitives.
Materials:
lava-rock source - lava-rock material. (includes height map, normal map, occlusion). Also emissive.
clean concrete source - concrete floor. (includes height map, normal map, occlusion).
sci-fi wall source - damaged sci-fi wall. (includes normal map).
Remaining materials are regular unity materials. A few notable ones:
BeamMaterial: Transparent and emissive.
EnemyDisc & EnemyCapsule are both vaguely emissive.
(sprite) QuickBackground: Background for menu. Created using photoshop.
(sprite) successkidgame: Internet meme. Created using memegenerator .
Scenes:
Game has two scenes:
Main menu
Main game scene
Testing:
Game has been tested on Windows 10, 1080p resolution.

Time Management
Time it Took (in hours)
Setting up Unity and remote repo: 0.5
Research and conceptualization of game idea: 0.5
Building 3D models from scratch -UFO, player: 1
Implementing and troubleshooting Player movement: 2.5
Making camera movement controls and connecting it to player object: 0.75
Creating and animating(rotating) pickups: 0.5
Creating enemy object and its materials: 1.5
Building map using ProBuilder: 2
Searching for materials on AssetStore: 1
Learning and implementing lighting in unity: 4
Researching and implementing enemy behavior: 4.5
Setting up the navigation mesh and agent: 0.75
Setting up player collisions with enemies and pickups: 1
Implementing menus and score counter: 2
Creating sprites for menus: 0.5
Play testing and bug fixing: 1
Commenting code: 2
Compiling references: 1
Making readme (report): 3
All: 25.75


Used Resources:

Enemy behavior https://www.youtube.com/watch?v=ieyHlYp5SLQ&list=PLLB28ZSHWK52ZF65o4S7dCPn53ud65jIN&index=10&t=63s&ab_channel=DanCS

Player controls using Unity’s Input System  https://www.youtube.com/watch?v=rJqP5EesxLk&list=PLLB28ZSHWK52ZF65o4S7dCPn53ud65jIN&index=9&t=10s&ab_channel=NattyCreations

ProBuilder tutorial https://www.youtube.com/watch?v=YtzIXCKr8Wo&ab_channel=Brackeys

Lighting in Unity https://www.youtube.com/watch?v=VnG2gOKV9dw&ab_channel=Brackeys

Stomping Rock (Four Shots) by Alex Grohl https://pixabay.com/music/rock-stomping-rock-four-shots-111444/

Tense Detective Looped Drone by Daddy’s Music https://pixabay.com/music/pulses-tense-detective-looped-drone-10054/

Sci-fi alien UFO warble by AlaskaRobotics https://pixabay.com/sound-effects/sci-fi-alien-ufo-warble-86812/



# **Unity 2D Platformer Game**

Welcome to the **Unity 2D Platformer Game**! This project is a beginner-to-intermediate level game built with Unity, demonstrating core gameplay mechanics like character movement, jumping, platforms, and camera behavior.

## **Features**
- **Player Movement:** Smooth movement mechanics with jumping functionality.
- **Dynamic Camera:** Follows the player with boundaries to avoid showing empty space.
- **Platforms:** Includes standard platforms and pass-through platforms for jumping.
- **Hazards:** Dead zones that teleport back to ground when the player falls.
- **Expandable Design:** Easy to add new levels, enemies, and mechanics.

---

## **Getting Started**
### **Prerequisites**
- Unity (2021.3 or newer recommended)
- Git (if cloning the project from GitHub)

### **Cloning the Repository**
1. Clone the repository:
   ```bash
   git clone https://github.com/lerouxblond/platformer_2d.git
   ```
2. Open the project in Unity:
   - Open Unity Hub.
   - Click **Open Project** and navigate to the cloned directory.

---

## **Controls**
- **Move:** `A`/`D`
- **Jump:** Spacebar
- **Move Camera** `W`/`S`

---

## **Project Structure**
- **Assets/**
  - Contains all scripts, prefabs, scenes, and assets used in the project.
- **Scripts/**
  - `PlayerMovement.cs`: Handles player movement and jumping.
  - `PlayerInputHandler.cs`: Manages player input using the new Unity Input System.
  - `Player.cs`: Player class.
  - `CameraFollow.cs`: Controls camera movement and boundaries.
  - `DeadZone.cs`: Teleport back the player to the startspoint of the game scene.
  - `Startpoint.cs`: Init a start spawnpoint for the player and when he go in the deadzone.
  - `Checkpoint.cs`: Move the startpoint value when player cross it.
  - `OneWayPlatform`: check if player is under the platform and disable or enable the collider.
- **Scenes/**
  - `LevelScene`: The level scene for the game.
  - `TitleScene`: The title scene that load the level when start button is pressed.
  - `CreditScene`: The credit scene that load when player reach the end of the level.

---

## **Customization**
You can expand this project by:
1. Adding new levels:
   - Create a new scene and add it to the **Build Settings**.
2. Introducing enemies:
   - Create new enemy scripts and attach them to prefabs.
3. Enhancing mechanics:
   - Add new abilities, like double jumping or wall climbing.

---

## **Known Issues**
- The camera may show empty areas if the boundaries are not set correctly.
- Performance may drop slightly on lower-end systems with large scenes.

---
## **License**
This project is licensed under the [MIT License](LICENSE).

---

Thank you for watching my project!

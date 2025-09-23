# 30-Days-30-Games-Day-01-Skull-Collector

This is the first game from my "30 Days 30 Games" challenge, created on September 23, 2025.

## 🚀 About the Game
A simple 2D top-down game where you control a ghost and must collect all the skulls on the screen to win.

## 🎮 How to Play
* **WASD Keys:** Move the ghost up, down, left, and right.
* **Goal:** Collect all the skulls.

## 💡 Technical Details
* **Engine:** Unity
* **Core Mechanics:**
    * Player movement is handled with `Rigidbody2D.linearVelocity` in `FixedUpdate` for smooth physics interaction.
    * Collection is done using `OnTriggerEnter2D` to detect when the player collides with a skull.
    * UI state (game vs. end screen) is managed using `CanvasGroup` alpha and interactable properties.

## ▶️ Play the Game!
You can play the game in your browser on its itch.io page:
**[https://shanmukha.itch.io/ghostly-skull-collector]**

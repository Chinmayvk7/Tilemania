🎮 TileVania – Advanced 2D Platformer with Adaptive AI Enemies

🧩 Project Overview

TileVania is a 2D platformer built in Unity that combines precision platforming, responsive physics, and adaptive AI behavior.
The game features multiple handcrafted tile-based levels, interactive environments, and dynamically learning enemies that adjust their strategies using reinforcement learning principles.

It focuses on modular gameplay systems, fluid character control, and AI-driven decision-making, creating a polished and replayable experience.

🧠 Concepts & Systems Implemented

🧱 Tile-Based World & Tools

• Built multiple levels using Unity Tilemaps, Rule Tiles, and a custom Tile Palette for fast and consistent level creation.

• Applied Composite Colliders and layer-based collision masks for optimized terrain and environment interactions.

⚙️ Player Controller & Feel

• Integrated an Animator Finite State Machine (FSM) for animation blending and transitions.

• Added coyote time and jump buffering mechanics for enhanced control responsiveness.

🔫 Shooting Mechanic

• Implemented a projectile shooting system (left-click) using object pooling to optimize performance.

• Added cooldown management and ammo handling for tactical gameplay.

• Enabled precise hit detection synchronized with terrain and enemies.

🧩 Core Systems

• Created a Singleton GameSession for persistent score, lives, and state data across levels.

• Utilized ScriptableObjects for flexible configuration of player stats, enemy behavior, and item data.

• Built modular scripts for reusability and scalability across multiple levels.

💀 Gameplay Mechanics

• Developed coin pickup systems, patrolling enemies with edge detection and flipping, and dynamic hazard zones.

• Implemented a death and retry flow, ensuring clean state resets and seamless respawns.

🧭 UI & Persistence

• Designed a HUD that tracks score, lives, and progress in real-time.

• Managed scene transitions with fade-in/out animations.

• Saved gameplay data across sessions for continuous progression.

🎥 Polish & Feedback

• Integrated Cinemachine for smooth, adaptive camera movement.

• Ensured pixel-perfect visuals for a retro-inspired aesthetic.

• Added particle effects, audio SFX, and background music to enhance immersion.

🤖 AI Integration

🧠 AI Behavior Learning

• Designed and trained Reinforcement Learning (RL) agents that adjust patrol, chase, and avoidance behaviors based on real-time player movement.

• Used reward-based systems to guide agents toward optimal strategies for survival, pursuit, and obstacle avoidance.

🎯 Policy-Based Decision Making

• Implemented policy-based inference at runtime, enabling enemies to make adaptive, non-scripted decisions.

• Ensured unpredictability while maintaining fairness for engaging gameplay.

🔍 Debugging & Visualization

• Built visual debugging tools within the Unity Editor to track agent perception, rewards, and decision states in real-time.

💻 C# Programming Concepts Applied

• Object-Oriented Design: ScriptableObjects, Singletons, and modular component systems.

• Event Handling: Player inputs, collisions, and interaction triggers.

• Optimization: Object pooling for bullets, caching components for performance.

• AI Systems: Policy inference and adaptive decision-making models.

• State Management: Persistent data storage and game session tracking.

• Animation Control: Animator FSM with parameter-based transitions.

🧭 Gameplay Flow

🎮 Start Level → 🏃‍♂️ Run / Jump / Shoot → 👾 Enemy Encounters → 💰 Coin Pickups → ⚰️ Death / Retry → 🧠 AI Adapts Behavior

🕹️ Controls

A / ← Arrow - Move Left

D / → Arrow - Move Right

Space – Jump

Left Click – Shoot Projectile


🧰 Tools & Technologies Used

• Unity Engine (2D)

• C# Programming

• Tilemap & Rule Tile Systems

• Cinemachine (Camera System)

• Animator & FSM

• ScriptableObjects

• Reinforcement Learning Framework

• Particle System & Audio Components

🎯 Learning Outcomes

• Mastered Tilemap workflows for multi-level 2D design.

• Built responsive player controllers with advanced movement mechanics.

• Developed modular and reusable systems for scalable game logic.

• Implemented AI-driven behavior using reinforcement learning principles.

• Enhanced debugging and visualization skills for monitoring AI decisions.

• Refined game polish through cinematic cameras, SFX, and animation flow.

• Tile-based world & tools: Multiple levels built with Unity Tilemaps, Rule Tiles, and a custom Tile Palette for faster iteration.
• Optimized physics: Composite Colliders and layer-based collision masks for smooth, reliable gameplay.
• Player controller & feel: Physics-driven movement (run/jump/flip) with Animator FSM, plus coyote time & jump buffering for responsive control.
• Shooting mechanic: Left-click to fire projectiles with object pooling, cooldown/ammo handling, and hit detection synced with enemies and terrain.
• Core systems: Singleton GameSession, ScriptableObjects for configurable data, and modular scripts for easier reuse.
• Gameplay mechanics: Coin pickups, patrolling enemies (edge-detect & flip), hazards, and a clean dying/retry flow.
• UI & persistence: HUD for score/lives, scene transitions, and data saved across sessions.
• Polish: Cinemachine camera, pixel-perfect visuals, particle VFX, audio SFX & background music.
• Designed and trained RL agents that dynamically adjust their patrol, chase, and avoidance behaviors based on real-time player movements.
• Developed reward-driven systems to encourage agents to optimize survival, avoid spikes, and maximize strategic pursuit of the player.
• Implemented policy-based inference in runtime, enabling adaptive, non-scripted enemy decisions for unpredictable yet fair gameplay.
• Created visual debugging tools to monitor agent perception, rewards, and decision states in the Unity Editor.

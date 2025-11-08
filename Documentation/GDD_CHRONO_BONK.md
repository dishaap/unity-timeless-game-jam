# Game Design Document: Chrono-Bonk

**Version:** 1.0
**Date:** Game Jam 2024
**Team:** Nico (Lead Design), Disha (Lead Dev), Dima (Tech Art), Andy (Audio), jsynk (3D Generalist)
**Platform:** WebGL (Browser)
**Target Audience:** All Ages (4+)
**Genre:** ARPG / Survivor-like / Action
**Theme:** "Timeless"

---

## 1. Game Overview

### 1.1 Concept
**Chrono-Bonk** is a fast-paced, auto-attacking ARPG that merges the power fantasy of *Vampire Survivors* with the time-bending mechanic of *Superhot*. Players take on the role of an archaeologist who has stumbled into a cursed cavern where time itself becomes a weapon. The game features a cartoon-like art style inspired by *Clash Royale*, making it accessible and appealing to players of all ages.

### 1.2 Core Hook
**"Time only moves when you do."** This simple but powerful mechanic transforms every moment of stillness into a strategic decision. Players can pause the world around them to assess threats, plan their next move, or simply catch their breath—but standing still comes at a cost, as their "Time" (mana) slowly drains.

### 1.3 Elevator Pitch
*"You're an archaeologist exploring a lost cavern when you trigger an ancient curse. Now time itself is frozen—except when you move. Survive 5 minutes of relentless enemies, auto-loot powerful upgrades, and face the ultimate boss in this cartoon-styled ARPG where every step is a commitment."*

---

## 2. Core Mechanics

### 2.1 The "Timeless" Mechanic (Superhot Twist)
**Primary Mechanic:** Time is tied directly to player movement.

- **Moving (WASD):** Time runs at 100% speed. Enemies move, projectiles fly, combat rages.
- **Stopped:** Time slows to 10% speed. Enemies crawl, projectiles drift, the world nearly freezes.
- **The Catch:** The player's auto-attack cooldown, "Time" (mana) regeneration, and the 5-minute global timer are **immune** to time slowdown. They continue at full speed, allowing players to "charge up" while paused.

**Strategic Depth:**
- Players can pause to assess the battlefield
- Players can pause to let abilities recharge
- Players can pause to plan escape routes
- But standing still drains "Time" (mana), forcing movement

### 2.2 Auto-Attack System
**Zero Manual Combat:** All attacks are automatic.

- Player's main weapon (Whip, Boomerang, or Fireball Staff) automatically targets and attacks the nearest enemy
- No clicking, no button mashing—just movement
- Attack speed scales with "Haste" stat
- Damage scales with "Power" stat

### 2.3 Auto-Loot System
**Zero Inventory Management:** All loot is automatically picked up and equipped.

- Enemies drop loot on death (Weapons, Scrolls, Relics)
- Walking over loot instantly picks it up
- Items are automatically equipped to available slots
- If slots are full, oldest items are replaced (FIFO)
- Stat bonuses apply immediately—no menus, no pauses

### 2.4 Global Timer
**5-Minute Countdown:** A global timer counts down from 5:00 to 0:00.

- Timer is **immune** to time slowdown
- When timer reaches 0:00, a "Mega Wave" (Boss) is summoned
- Timer displayed prominently in UI
- Creates constant tension and urgency

---

## 3. Gameplay Loop

### 3.1 Pre-Game: Ultimate Skill Selection
At game start, player selects 1 of 3 "Ultimate Skills":

1. **Time Freeze:** Freezes all enemies in a radius for 5 seconds (scales with CC Power)
2. **Haste:** Increases attack speed by 50% for 10 seconds
3. **Summon Pet:** Spawns a friendly AI companion for 30 seconds

### 3.2 Main Loop (5 Minutes)
1. **Spawn:** Player spawns in the center of a large cavern arena
2. **Move & Fight:** Player moves with WASD, auto-attacks nearest enemies
3. **Strategic Pause:** Player can stop to assess threats, let abilities recharge
4. **Loot & Upgrade:** Defeated enemies drop loot, automatically picked up and equipped
5. **Escalate:** Enemy spawn rate gradually increases over 5 minutes
6. **Boss Wave:** At 0:00, boss spawns with additional enemies

### 3.3 Win/Lose Conditions
- **Win:** Defeat the boss after the 5-minute timer ends
- **Lose:** Player health reaches 0 (death)

---

## 4. Characters & Enemies

### 4.1 Player Character
**The Archaeologist:**
- Based on Indiana Jones and Lara Croft
- Cartoon-styled, all-ages friendly
- Starts with basic Whip weapon
- Can equip up to 3 weapons, 3 scrolls, and multiple relics

### 4.2 Enemies

**Skeleton (Ranged):**
- Throws rib cage as a boomerang attack
- Health: 50
- Speed: 3.0
- Range: Medium
- Drops: Common loot (70%), Uncommon (20%), Rare (8%), Antique (2%)

**Mummy (Melee):**
- Bite attack (close range)
- Bandage whip attack (medium range)
- Health: 75
- Speed: 2.5 (slower)
- Drops: Common loot (60%), Uncommon (25%), Rare (12%), Antique (3%)

**Scarab (Swarm):**
- Fast-moving swarm enemy
- Explodes on death (area damage)
- Health: 25
- Speed: 4.0 (fastest)
- Drops: Common loot (80%), Uncommon (15%), Rare (4%), Antique (1%)

**Boss (Pharaoh/Anubis):**
- Spawns at 5-minute mark
- Health: 500+
- Multiple attack patterns
- Drops: Guaranteed Antique rarity items

---

## 5. Weapons & Items

### 5.1 Weapons (3 Types)
Players can equip up to 3 weapons simultaneously:

1. **Whip** (Common)
   - Short-range, fast attacks
   - Starter weapon
   - Auto-attacks nearest enemy

2. **Boomerang** (Uncommon)
   - Medium-range, returns to player
   - Higher damage than Whip

3. **Fireball Staff** (Rare)
   - Long-range, area damage
   - Slower attack speed, higher damage

### 5.2 Scrolls (3 Slots)
Scrolls provide passive stat bonuses:

- **Scroll1 Slot:** Power Scroll (+10 Power)
- **Scroll2 Slot:** Haste Scroll (+0.5 Haste)
- **Scroll3 Slot:** CC Power Scroll (+0.2 CC Power)

**Rarity Tiers:**
- **Common (Grey):** +1 stat bonus
- **Uncommon (Green):** +2 stat bonuses
- **Rare (Blue):** +3 stat bonuses
- **Antique (Orange):** +3 stat bonuses + special effect

### 5.3 Relics (Socket System)
Relics provide percentage-based stat bonuses:

- Examples: +5% Haste, +5% Power, +10% Health
- Multiple relics can be socketed
- Rarity affects bonus magnitude
- Antique relics may have unique effects

---

## 6. Stats & Progression

### 6.1 Core Stats
- **Health:** Player's hit points (starts at 100)
- **Time (Mana):** Resource for ultimate skills (starts at 50, max 100)
  - Drains while time is slowed (standing still)
  - Regenerates while moving
- **Power:** Damage multiplier (starts at 10)
- **Haste:** Attack speed multiplier (starts at 1.0)
- **CC Power:** Crowd control duration multiplier (starts at 1.0)

### 6.2 Leveling System
- Max Level: 20
- XP gained from defeating enemies
- Each level provides stat increases
- Leveling happens automatically (no manual allocation)

### 6.3 Progression Feel
- **Early Game (0-2 min):** Slow spawns, easy enemies, basic loot
- **Mid Game (2-4 min):** Increased spawns, mixed enemy types, better loot
- **Late Game (4-5 min):** High spawn rate, all enemy types, rare loot
- **Boss Wave (5+ min):** Boss + additional enemies, guaranteed Antique loot

---

## 7. Art Style & Visual Design

### 7.1 Art Direction
**Cartoon-Styled, All-Ages Friendly:**
- Inspired by *Clash Royale* aesthetic
- Toon shader applied to all characters and environment
- Vibrant colors, clear silhouettes
- Exaggerated animations for readability

### 7.2 Environment
**Lost Cavern Setting:**
- Stylized Lost Cave environment pack
- Single large arena (no multiple rooms)
- Ancient Egyptian/archaeological theme
- Crystals, trees, fountains as world features
- Glowing path visualization for enemy movement
- Colored spawn/goal areas

### 7.3 Visual Effects
- **Combat:** Particle effects for all attacks (whip, boomerang, fireball)
- **Loot:** Sparkle effects on pickup
- **Death:** Toon-styled explosion/poof
- **Ultimate Skills:** Dramatic visual effects matching ability type
- **Time Slowdown:** Visual feedback (optional: color shift, particle trails)

---

## 8. Audio Design

### 8.1 Music
**Main Theme:**
- Egyptian-themed, high-energy
- Lo-fi beats or synth style (like *Vampire Survivors*)
- Matches the auto-battler pace
- Boss wave music transition (more intense)

### 8.2 Sound Effects
- **Combat:** Whip crack, boomerang whoosh, fireball explosion
- **Enemies:** Skeleton attack, mummy bite, scarab explosion
- **UI:** Auto-pickup sound, skill selection, player death
- **Ambient:** Cave atmosphere, echo effects

### 8.3 Audio Mixer
- Music group
- SFX group
- Ambient group
- Volume balancing for WebGL performance

---

## 9. Controls & Input

### 9.1 Player Controls
**Movement Only:**
- **WASD:** Move player character
- **No other inputs required** (all combat is automatic)

### 9.2 UI Interactions
- **Mouse Click:** Ultimate skill selection (pre-game)
- **Mouse Click:** Ultimate skill activation (during game, if needed)

### 9.3 Time Mechanic
- **Moving:** Time at 100% (normal speed)
- **Stopped:** Time at 10% (slow motion)
- Automatic—no button press required

---

## 10. User Interface

### 10.1 Pre-Game UI
**Ultimate Skill Selection:**
- Three large buttons
- One for each ultimate skill
- Visual preview of skill effect
- Click to select and start game

### 10.2 In-Game UI
**Minimal, Non-Intrusive:**

1. **Global Timer (Top Center):**
   - Large countdown (MM:SS format)
   - Changes color as time runs out (green → yellow → red)
   - Always visible

2. **Player Stats (Top Left):**
   - Health bar
   - Time (mana) bar
   - Current level/XP indicator

3. **Loot Notification (Center):**
   - Brief popup when item auto-equips
   - Shows item name and stat bonus
   - Fades out after 2 seconds

4. **Ultimate Skill Cooldown (Bottom Right):**
   - Shows cooldown for selected ultimate
   - Visual indicator when ready
   - Click to activate

**No Inventory Windows:** All management is automatic.

---

## 11. Technical Specifications

### 11.1 Platform
- **Target:** WebGL (Browser)
- **Build Format:** ZIP file for Itch.io
- **Compression:** Disabled (required for Itch.io)
- **Performance Target:** 60 FPS

### 11.2 Asset Requirements
- **Models:** FBX format, optimized for WebGL
- **Textures:** 512x512 or 1024x1024 max
- **Audio:** OGG Vorbis format
- **Shaders:** WebGL-compatible toon shader

### 11.3 Performance Considerations
- Single large arena (no scene loading)
- Optimized particle effects
- Material batching for draw call reduction
- Efficient enemy spawning/despawning

---

## 12. Game Balance

### 12.1 Difficulty Curve
**Progressive Escalation:**
- **0-1 min:** 1-2 enemies at a time, slow spawn rate
- **1-2 min:** 2-3 enemies, moderate spawn rate
- **2-3 min:** 3-4 enemies, faster spawn rate, mixed types
- **3-4 min:** 4-5 enemies, high spawn rate, all types
- **4-5 min:** 5-6 enemies, very high spawn rate
- **5+ min:** Boss + 3-4 additional enemies

### 12.2 Loot Economy
**Drop Rates:**
- **Common:** 70-80% (early game focus)
- **Uncommon:** 15-25% (mid game)
- **Rare:** 4-12% (late game)
- **Antique:** 1-3% (rare, boss guaranteed)

**Progression Feel:**
- Player should feel progressively stronger
- Loot drops frequently enough to maintain engagement
- Antique items feel special and impactful

### 12.3 Time (Mana) Economy
- **Drain Rate:** 10 Time/sec while stopped
- **Regen Rate:** 5 Time/sec while moving
- **Forces Movement:** Players cannot stay stopped indefinitely
- **Ultimate Costs:** 30-50 Time (forces strategic use)

---

## 13. Win/Lose Conditions

### 13.1 Victory
**Defeat the Boss:**
- Boss spawns at 5-minute mark
- Boss has high health (500+)
- Defeating boss triggers victory screen
- Player can continue playing (endless mode potential)

### 13.2 Defeat
**Player Death:**
- Health reaches 0
- Game over screen
- Option to restart
- Shows stats: time survived, enemies killed, items collected

---

## 14. Accessibility & All-Ages Design

### 14.1 Simplicity
- **One Input:** Movement only (WASD)
- **No Complex Systems:** Auto-everything (attack, loot, equip)
- **Clear Visual Feedback:** Large UI, clear indicators
- **Forgiving:** Time slowdown allows players to assess and react

### 14.2 Visual Clarity
- **Cartoon Style:** Non-threatening, friendly
- **Clear Silhouettes:** Easy to identify enemies
- **Color Coding:** Rarity tiers, UI elements
- **Large Text:** Readable at all screen sizes

### 14.3 Audio Feedback
- **Clear SFX:** Every action has audio feedback
- **Music:** Non-intrusive, enhances atmosphere
- **Volume Controls:** Adjustable (if time permits)

---

## 15. Post-Jam Potential

### 15.1 Stretch Features (If Time Permits)
- Multiple boss types
- More weapon variety
- Additional ultimate skills
- Endless mode (continue after boss)
- Leaderboard system
- Achievement system

### 15.2 Future Expansion Ideas
- Multiple arenas/environments
- Character customization
- More enemy types
- Co-op multiplayer (future consideration)
- Mobile port (touch controls)

---

## 16. Design Pillars

### 16.1 Core Principles
1. **Movement is Strategic:** Every step matters, every pause is a decision
2. **Zero Friction:** No menus, no inventory, no pauses—constant flow
3. **Power Fantasy:** Player feels progressively stronger
4. **Accessibility:** Simple controls, clear feedback, all-ages friendly
5. **Time as Resource:** Time slowdown is both tool and constraint

### 16.2 Player Experience Goals
- **Excitement:** Fast-paced action with strategic depth
- **Satisfaction:** Auto-loot provides constant positive feedback
- **Tension:** 5-minute timer creates urgency
- **Empowerment:** Player becomes stronger throughout the run
- **Clarity:** Always know what's happening and why

---

## 17. References & Inspiration

### 17.1 Game References
- **Vampire Survivors:** Auto-attack, auto-loot, power fantasy
- **Superhot:** Time moves when you move
- **Clash Royale:** Cartoon art style, all-ages appeal
- **Hades:** Fast-paced ARPG combat, clear visual feedback

### 17.2 Art References
- **Clash Royale:** Cartoon-styled characters, vibrant colors
- **Indiana Jones:** Archaeological theme, adventure feel
- **Tomb Raider:** Explorer aesthetic, ancient ruins

---

## 18. Success Metrics

### 18.1 MVP Goals
- [ ] Time mechanic works smoothly
- [ ] Auto-attack functional
- [ ] At least 1 enemy type working
- [ ] Loot system operational
- [ ] 5-minute timer functional
- [ ] Boss spawns correctly
- [ ] Game playable in browser

### 18.2 Quality Goals
- [ ] Smooth 60 FPS performance
- [ ] No major bugs
- [ ] Clear visual feedback
- [ ] Satisfying gameplay loop
- [ ] Polished presentation

---

## 19. Team Notes

### 19.1 Design Decisions
- All suggestions in this GDD are open to team discussion
- Team should agree on approach before major implementation
- Document any changes or deviations from this GDD

### 19.2 Technical Notes
- See `CHRONO_BONK_PLAN_UPDATED.md` for detailed technical implementation
- All systems must respect time slowdown mechanic
- WebGL compatibility is critical

---

## 20. Appendix: Terminology

- **Time (Mana):** Resource for ultimate skills, drains when stopped
- **Haste:** Attack speed multiplier stat
- **Power:** Damage multiplier stat
- **CC Power:** Crowd control duration multiplier
- **FIFO:** First In, First Out (loot replacement system)
- **Auto-Attack:** Automatic targeting and attacking of nearest enemy
- **Auto-Loot:** Automatic pickup and equipping of dropped items
- **Ultimate Skill:** Powerful ability selected at game start
- **Boss Wave:** Final challenge that spawns at 5-minute mark

---

**End of Game Design Document**

*This GDD serves as the creative vision for Chrono-Bonk. For technical implementation details, see `CHRONO_BONK_PLAN_UPDATED.md`.*

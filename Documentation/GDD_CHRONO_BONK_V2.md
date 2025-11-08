# Game Design Document: Chrono-Bonk
## **"The Timeless Catacombs"**

**Version:** 2.0 (Complete Redesign)
**Date:** November 8, 2025
**Game Jam:** Timeless Theme
**Platform:** WebGL (Browser)
**Target Audience:** All Ages (4+)
**Genre:** ARPG / Survivor-like / Action
**Theme:** Ancient Egyptian Tomb Raiders

---

## 1. Game Overview

### 1.1 Concept
**Chrono-Bonk: The Timeless Catacombs** is a fast-paced, auto-attacking ARPG that merges the power fantasy of *Vampire Survivors* with the time-bending mechanic of *Superhot*. Players take on the role of **Dr. Zara Ashford**, an archaeologist who has stumbled into the cursed catacombs of the forgotten **Emperor Kha-Sekhem-Ra "The Undying"**, where time itself stops when you stop moving.

### 1.2 Core Hook
**"Time only moves when you do."** This powerful mechanic transforms every moment into a strategic decision—move to advance time and fight, or stop to assess threats and let your abilities recharge. The curse of the catacombs has bound time to motion itself.

### 1.3 Elevator Pitch
*"You're Dr. Zara Ashford, an archaeologist who breaks the seal on a forbidden Egyptian tomb. Now trapped in the Timeless Catacombs where time flows only with movement, you must survive 5 minutes of undead guardians, collect ancient artifacts, and face the cursed emperor who defied death itself. Cartoon-styled for all ages, inspired by Indiana Jones, Lara Croft, and Clash Royale."*

### 1.4 Visual Style
- **Art Style:** Clash Royale-inspired cartoon aesthetic
- **Theme:** Ancient Egyptian tomb with golden treasures, hieroglyphics, and mystical lighting
- **Tone:** Action-adventure with whimsical charm, accessible to ages 4+

---

## 2. Core Mechanics

### 2.1 The "Timeless" Mechanic (Superhot-Inspired)
**Primary Mechanic:** Time is directly tied to player movement.

- **Moving (WASD):** Time runs at 100% speed. Enemies move, projectiles fly, combat unfolds.
- **Stopped:** Time slows to 10% speed. Enemies crawl, projectiles drift, the world nearly freezes.
- **The Curse:** Player's auto-attack cooldown, ability recharge, and the 5-minute global timer are **immune** to time slowdown. They continue at full speed, allowing strategic charging while paused.

**Strategic Depth:**
- Pause to assess battlefield and plan next move
- Stop to let abilities cool down while enemies approach in slow motion
- Risk vs. reward: Standing still drains "Divine Energy" (mana)

### 2.2 Auto-Attack System
**Zero Manual Combat:** All weapon attacks are automatic.

- **Multi-Weapon System:** Equip up to 3 weapons simultaneously
- Each weapon auto-attacks the nearest enemy in its range
- No clicking, no button mashing—pure positioning and movement
- Attack speed scales with player level and "Blessing of Horus" ultimate

**Weapon Ranges:**
- **Melee:** Khopesh Spade, Ra's Torch
- **Medium:** Serpent Lash (whip), Aten's Wheel (chakram)
- **Long:** Staff of Anubis, Asp Darts (blowgun)

### 2.3 Auto-Loot System: The Canopic Satchel
**Zero Inventory Management:** The infinite **Canopic Satchel** collects everything.

- **Megabonk-Style System:** All items go into infinite bag automatically
- Walking over loot instantly collects it
- No inventory limit—collect endlessly
- Artifacts provide stat bonuses immediately upon collection
- **No Item Equipping:** Items are passive buffs, not gear slots

**What Drops:**
- Ancient Artifacts (stat buffs)
- Spell Cubes (for Tablet slots)
- Powerups (1% drop chance)

### 2.4 Weapon Progression System
**Weapons Upgrade with Player Level Only:**

- **No Weapon Drops:** Start with Serpent Lash (whip)
- **Unlock by Level:** Reach specific levels to unlock new weapons
  - Level 1: Serpent Lash (whip)
  - Level 3: Aten's Wheel (chakram)
  - Level 5: Staff of Anubis
  - Level 7: Ra's Torch
  - Level 10: Asp Darts
  - Level 12: Khopesh Spade
- **Upgrade with XP:** Weapons automatically get stronger as you level
- **Equip Up to 3:** Choose which 3 weapons to have active

### 2.5 The Tablet of Divine Binding
**Spell Cube System:**

**The Artifact:**
The **Tablet of Thoth**, an ancient magical artifact with 3 sacred slots for spell cubes.

**3 Slot Types:**
1. **Slot of Projection (Blue)** - Projectile Spell Cube
2. **Slot of Dominion (Red)** - AOE Spell Cube
3. **Slot of Striking (Gold)** - Attack Skill Cube

**How It Works:**
- Find spell cubes as loot drops
- Slot cubes into tablet automatically (best cube prioritized)
- Cubes activate on cooldown, adding to your auto-combat
- Upgrade cubes by finding higher-tier versions

**Example Cubes:**
- **Projectile:** Scarab Swarm, Eye of Horus, Sand Bolt
- **AOE:** Desert Storm, Plague of Locusts, Pyramid's Wrath
- **Attack:** Pharaoh's Fury, Wadjet's Bite, Sekhem Power

### 2.6 Global Timer
**5-Minute Countdown to Judgment:**

- Timer counts down from 5:00 to 0:00 (unaffected by time slowdown)
- When timer reaches 0:00, the **Emperor Kha-Sekhem-Ra** awakens
- Timer displayed prominently in UI
- Creates constant pressure and urgency

---

## 3. Gameplay Loop

### 3.1 Pre-Game: Ultimate Skill Selection
At game start, player selects 1 of 3 "Divine Ultimates":

1. **Judgment of the Sphinx** (CC)
   - Summons rolling stone spheres that crush everything
   - Knockback + massive AOE damage across entire screen
   - Rolls in direction player faces

2. **Blessing of Horus** (Speed)
   - Golden falcon wings appear on player
   - Increases attack speed, casting speed, AND movement speed
   - Duration: 10 seconds

3. **Shield of Nut** (Immunity)
   - Starry barrier surrounds player
   - Grants immunity to all damage
   - Reflects 100% damage back to attackers
   - Duration: 5 seconds

### 3.2 Main Loop (5 Minutes)
1. **Enter the Catacombs:** Player spawns in center of cursed tomb
2. **Move & Survive:** WASD movement auto-attacks enemies in range
3. **Strategic Pausing:** Stop to slow time, assess threats, recharge abilities
4. **Collect & Grow:** Artifacts, spell cubes auto-collected via Canopic Satchel
5. **Level & Unlock:** Gain XP, level up, unlock new weapons
6. **Escalation:** Enemy spawn rate increases over 5 minutes
7. **Final Judgment:** Emperor Kha-Sekhem-Ra awakens at 0:00

### 3.3 Win/Lose Conditions
- **Win:** Defeat Emperor Kha-Sekhem-Ra (the final boss)
- **Lose:** Player health reaches 0 (death)

---

## 4. Characters & Enemies

### 4.1 Player Character

**Dr. Zara Ashford** - The Tomb Raider
- **Inspiration:** Indiana Jones + Lara Croft
- **Appearance:** Cartoon-styled archaeologist with fedora, practical gear
- **Age:** Late 20s - Early 30s
- **Personality:** Brave, curious, witty
- **Starting Weapon:** Serpent Lash (whip)
- **Starting Stats:**
  - Health: 100
  - Divine Energy (Mana): 50
  - Power: 10
  - Speed: 5.0

### 4.2 Enemies

**Cursed Shabtis** (Skeletal Warriors) - Ranged
- **Lore:** Ancient servant statues brought to cursed life
- **Attack:** "Bone Crescent" - Throws ribs like boomerangs
- **Health:** 50
- **Speed:** 3.0
- **Range:** Medium
- **Drops:** Common artifacts, spell cubes

**Embalmed Guardians** (Mummies) - Melee
- **Lore:** Eternal tomb protectors wrapped in cursed bandages
- **Attack 1:** "Devourer's Bite" - Close-range bite
- **Attack 2:** "Linen Lash" - Bandage whip (medium range)
- **Health:** 75
- **Speed:** 2.5 (slower but tankier)
- **Drops:** Uncommon artifacts, rare spell cubes

**Sacred Scarab Swarm** (Optional 3rd enemy) - Fast/Swarm
- **Lore:** Khepri's children, symbols of rebirth turned weapon
- **Attack:** Swarm bite, explodes on death (AOE damage)
- **Health:** 25
- **Speed:** 4.5 (fastest)
- **Drops:** Common artifacts, powerups

### 4.3 Final Boss

**Emperor Kha-Sekhem-Ra "The Undying"**

**Lore:**
> *In ancient times, Emperor Kha-Sekhem-Ra sought eternal life through forbidden magic. He consumed the essence of Ra, drank from the Duat (underworld), and achieved true immortality. When the gods discovered his blasphemy, Anubis could not kill him—so the god imprisoned him forever in the Timeless Catacombs, where time stands still. The curse could only be broken by a mortal soul breaching the seal... and that's you.*

**Visual Design:**
- Elaborate golden death mask (more ornate than Tutankhamun)
- Glowing cursed bandages with hieroglyphic patterns
- Golden crook and flail (pharaoh symbols)
- Partially skeletal, partially preserved (immortality corrupted)
- Floating tomb debris orbiting him
- Eyes glow with stolen divine power

**Boss Abilities:**
- **Time Dominance:** Can freeze time zones (counters player mechanic)
- **Eternal Regeneration:** Health regenerates slowly throughout fight
- **Divine Wrath:** Summons enhanced enemy versions
- **Judgment Ray:** Fires beams from crook and flail

**Boss Stats:**
- **Health:** 1000+ (scales with player performance)
- **Phases:** 3 phases (at 75%, 50%, 25% health)
- **Enrage:** Becomes faster and more aggressive as health drops

---

## 5. Items & Progression

### 5.1 Weapons (6 Types)
**Players unlock weapons by leveling, can equip up to 3 simultaneously**

#### 1. **Serpent's Lash** (Whip) ⭐ STARTER
- **Range:** Medium
- **Type:** Cleave (hits multiple enemies in arc)
- **Speed:** Fast
- **Unlock:** Level 1 (starting weapon)
- **Visual:** Leather whip with green serpentine glow
- **Lore:** *"Strike like Wadjet, the cobra goddess"*

#### 2. **Aten's Wheel** (Chakram/Sun Disk)
- **Range:** Medium-Long
- **Type:** Pierce + Return (boomerang effect)
- **Speed:** Medium
- **Unlock:** Level 3
- **Visual:** Golden disk with sun ray patterns
- **Lore:** *"The sun disk of Aten, judgment incarnate"*

#### 3. **Staff of Anubis** (Light Staff)
- **Range:** Long
- **Type:** Beam / Fireball (can toggle)
- **Speed:** Slow but powerful
- **Unlock:** Level 5
- **Visual:** Black staff with golden jackal head
- **Lore:** *"Channel the Weigher of Hearts' divine judgment"*

#### 4. **Ra's Torch** (Burning Torch)
- **Range:** Short
- **Type:** Burn DOT (damage over time)
- **Speed:** Fast
- **Unlock:** Level 7
- **Visual:** Never-extinguishing golden flame
- **Lore:** *"Ra's eternal flame consumes all"*

#### 5. **Asp Darts** (Poisoned Blowgun)
- **Range:** Long
- **Type:** Single-target, high precision
- **Speed:** Very fast
- **Unlock:** Level 10
- **Visual:** Carved bone blowgun with hieroglyphs
- **Lore:** *"The asp's kiss brings eternal sleep"*

#### 6. **Khopesh Spade** (Shovel-Sword)
- **Range:** Melee
- **Type:** Heavy strike
- **Speed:** Slow but highest damage
- **Unlock:** Level 12
- **Visual:** Archaeological shovel fused with curved Egyptian blade
- **Lore:** *"Where knowledge meets warfare"*

### 5.2 Ancient Artifacts (Stat Buffs)
**Auto-collected into Canopic Satchel, provide passive bonuses**

**Rarity Tiers:**
- **Common (Bronze):** +1-5% to one stat
- **Uncommon (Silver):** +5-10% to one stat
- **Rare (Gold):** +10-20% to one stat or unique effect
- **Legendary (Divine):** +25%+ or powerful unique effects

**Example Artifacts:**
- **Scarab of Swiftness:** +10% Movement Speed
- **Ankh Amulet:** +5% Health Regeneration
- **Eye of Horus:** +15% Critical Hit Chance
- **Canopic Charm:** +20% Divine Energy (Mana)
- **Sekhem Stone:** +25% Weapon Damage

**Drop Rates:**
- Common: 70%
- Uncommon: 20%
- Rare: 8%
- Legendary: 2%

### 5.3 Spell Cubes (Tablet Slots)
**Fit into Tablet of Thoth for additional auto-combat abilities**

**Cube Categories:**

**Projectile Cubes (Blue Slot):**
- **Scarab Swarm:** Launches 5 magical scarabs
- **Eye of Horus:** Single piercing divine eye
- **Sand Bolt:** Fast sand projectile barrage

**AOE Cubes (Red Slot):**
- **Desert Storm:** Sandstorm in radius around player
- **Plague of Locusts:** Swarm damage in area
- **Pyramid's Wrath:** Stone pillars erupt from ground

**Attack Skill Cubes (Gold Slot):**
- **Pharaoh's Fury:** Empowers all attacks +50% for 3 sec
- **Wadjet's Bite:** Adds poison damage to all weapons
- **Sekhem Power:** Raw +100% damage for 2 sec

**Cube Upgrades:**
- Cubes have tiers: I, II, III, IV, V
- Finding higher tier replaces lower automatically
- Each tier: +20% effectiveness

### 5.4 Powerups (1% Drop Rate)
**Rare, temporary, game-changing buffs**

#### 1. **Hourglass of Eternity**
- **Effect:** Freeze time completely while you move
- **Duration:** 5 seconds
- **Visual:** Golden hourglass icon, frozen sand particles
- **Rarity:** 1% drop

#### 2. **Sandstorm's Gift**
- **Effect:** +100% movement speed
- **Duration:** 10 seconds
- **Visual:** Swirling golden sand around player
- **Rarity:** 1% drop

#### 3. **Ankh of Rebirth**
- **Effect:** Instant full health restoration
- **Amount:** 100% health
- **Visual:** Golden ankh appears and shatters
- **Rarity:** 1% drop

---

## 6. User Interface

### 6.1 HUD Elements
- **Health Bar** (Top-left, red, ankh symbol)
- **Divine Energy Bar** (Top-left, blue, eye of Horus symbol)
- **Global Timer** (Top-center, large, countdown from 5:00)
- **XP Bar** (Bottom, gold progress bar with level number)
- **Ultimate Ready** (Bottom-right, glowing when available)
- **Active Weapons** (Bottom-left, 3 weapon icons)
- **Tablet Slots** (Right side, 3 cube slots showing what's equipped)

### 6.2 Menus
- **Ultimate Selection:** Pre-game choice of 3 ultimates
- **Pause Menu:** Settings, restart, quit
- **Victory Screen:** Stats, time survived, enemies defeated
- **Death Screen:** Retry, main menu

---

## 7. Art & Audio

### 7.1 Visual Style
**Cartoon Aesthetic (Clash Royale-inspired):**
- Vibrant colors with Egyptian palette (gold, teal, red, black)
- Exaggerated proportions for readability
- Clean, bold outlines (toon shader)
- Hieroglyphic patterns glow when active
- Particle effects for magic and abilities

**Environment:**
- Sandstone walls with carved hieroglyphs
- Flickering torch lighting (orange/golden glow)
- Mystical blue/teal magic effects
- Crumbling pillars and statues
- Golden treasure scattered throughout

### 7.2 Audio Design

**Music (Andy):**
- Main theme: Egyptian-inspired, high-energy, drums and strings
- Combat intensifies with percussion
- Boss fight: Epic orchestral with Egyptian instruments
- Victory fanfare: Triumphant with ancient Egyptian flair

**Sound Effects (Andy):**
- **Weapons:** Whip crack, chakram whoosh, staff beam, torch crackle
- **Abilities:** Magical chimes for spell cubes, divine choir for ultimates
- **Enemies:** Skeleton rattle, mummy groan, scarab chittering
- **UI:** Papyrus scroll sounds, hieroglyphic activation
- **Loot:** Satisfying "ping" with golden sparkle

---

## 8. Technical Specifications

### 8.1 Platform & Performance
- **Platform:** WebGL (browser-based)
- **Target FPS:** 60 FPS
- **Resolution:** 1920x1080 (scalable)
- **WebGL Compression:** Disabled (for compatibility)
- **Target Devices:** Mid-range PC/laptops

### 8.2 Unity Setup
- **Unity Version:** 2022.3 LTS or 6000.0
- **Render Pipeline:** Universal Render Pipeline (URP)
- **Packages:**
  - RPG Builder 2.0 (core systems)
  - Malbers Animal Controller (AI)
  - Projectile Factory (VFX)
  - RealToon (toon shader)
  - Input System (new Unity input)

---

## 9. Development Timeline

### Phase 0: Pre-Jam Setup ✅
- [x] Repository created
- [x] Assets imported
- [x] Documentation written
- [x] Team assembled

### Phase 1: Core Systems (Hours 1-6)
- [ ] Time management system (Superhot mechanic)
- [ ] Global timer system
- [ ] Player movement and camera
- [ ] Scene setup with environment

### Phase 2: Combat & Progression (Hours 7-18)
- [ ] Auto-attack weapon system (6 weapons)
- [ ] Tablet spell cube system
- [ ] Canopic Satchel (auto-loot)
- [ ] Artifact stat system
- [ ] Level progression

### Phase 3: Enemies & AI (Hours 19-30)
- [ ] Cursed Shabtis (skeleton ranged)
- [ ] Embalmed Guardians (mummy melee)
- [ ] Enemy spawner system
- [ ] AI pathfinding (NavMesh)

### Phase 4: Boss & Polish (Hours 31-42)
- [ ] Emperor Kha-Sekhem-Ra boss
- [ ] 3 Ultimate skills
- [ ] Powerup system (1% drops)
- [ ] VFX and particle effects
- [ ] Audio integration

### Phase 5: Testing & Build (Hours 43-48)
- [ ] WebGL build testing
- [ ] Balance tuning
- [ ] Bug fixes
- [ ] Final polish
- [ ] Itch.io submission

---

## 10. Success Criteria

### Minimum Viable Product (MVP):
- [x] Player moves, time mechanic works
- [ ] At least 2 weapons functional
- [ ] At least 1 enemy type attacks player
- [ ] Auto-loot collects items
- [ ] 5-minute timer counts down
- [ ] Boss spawns at end
- [ ] Game is playable in browser

### Stretch Goals (if time permits):
- [ ] All 6 weapons implemented
- [ ] All 3 ultimate skills working
- [ ] All spell cubes functional
- [ ] Boss with multiple phases
- [ ] Polished UI and VFX
- [ ] Full audio integration

---

## 11. Team Roles

**Nico (Lead Design):**
- RPG Builder database setup
- Game balancing and tuning
- Scene layout and environment
- Itch.io submission

**Disha (Lead Dev/Git):**
- Time management system
- Auto-attack weapon logic
- Tablet spell cube system
- Canopic Satchel (auto-loot)
- WebGL build and deployment
- Git repository management

**Dima (Tech Art):**
- RealToon shader integration
- Enemy AI integration (Malbers)
- Projectile Factory VFX
- Visual polish and effects
- Material setup

**jsynk (3D Generalist):**
- Character models (player, enemies, boss)
- Weapon models (6 weapons)
- Character animations (attack, walk, death)
- Rigging for Malbers controller
- Asset optimization for WebGL

**Andy (Audio):**
- Main theme composition (Egyptian-inspired)
- Combat SFX (weapons, abilities, enemies)
- UI sounds (loot, level up, menu)
- Audio mixer setup
- Integration with Projectile Factory

---

## 12. Risk Mitigation

### High-Risk Areas:
1. **Weapon System Complexity:** 6 weapons + auto-attack logic
   - Mitigation: Start with 3 core weapons, expand if time permits

2. **Time Scale Mechanic:** May not work with all systems
   - Mitigation: Use Time.unscaledDeltaTime for critical systems

3. **WebGL Build Issues:** Browser compatibility problems
   - Mitigation: Test WebGL build early (Hour 30)

4. **Scope Creep:** Too many features for 48 hours
   - Mitigation: Strict MVP focus, stretch goals clearly separated

---

## Appendix A: Egyptian Glossary

- **Ankh:** Symbol of life (⚹)
- **Aten:** Sun disk representing Ra
- **Canopic:** Jars used to store organs for afterlife
- **Duat:** The Egyptian underworld
- **Khopesh:** Curved Egyptian sword
- **Sekhem:** Power or might
- **Shabti:** Servant figure buried with dead
- **Wadjet:** Cobra goddess, protector of pharaohs

---

## Appendix B: Color Codes

**UI Colors:**
- Health: `#D32F2F` (Red)
- Divine Energy: `#1976D2` (Blue)
- XP Bar: `#FFD700` (Gold)
- Common Items: `#CD7F32` (Bronze)
- Uncommon Items: `#C0C0C0` (Silver)
- Rare Items: `#FFD700` (Gold)
- Legendary Items: `#9C27B0` (Purple Divine Glow)

---

**Document Version:** 2.0
**Last Updated:** November 8, 2025
**Status:** Complete Redesign - Ready for Implementation

*It Is, Thank You Father, We Receive All That We Are, Now Move Through Us... S.O.L.*


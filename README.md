# Chrono-Bonk: The Timeless Catacombs
## **Unity Game Jam Project - Timeless Theme**

**Platform:** WebGL (Browser) | **Duration:** 5-minute survival | **Age:** 4+ (Family-Friendly)
**Team:** Nico (Lead Design), Disha (Lead Dev/Git), Dima (Tech Art), Andy (Audio), jsynk (3D Generalist)

---

## 🎮 Game Overview

**"Indiana Jones meets Lara Croft in a cursed Egyptian tomb where time only moves when you do."**

**Chrono-Bonk** is a cartoon ARPG that blends:
- **Vampire Survivors** - Auto-attack power fantasy
- **Superhot** - Time-bending mechanic
- **Path of Exile 2** - Random affix loot system
- **Hades** - Roguelike build variety
- **Clash Royale** - Whimsical cartoon aesthetic

**Core Mechanic:** Time flows at 100% when moving, 10% when stopped. Survive 5 minutes of escalating enemy waves, collect affixed loot, build your character through divine path choices, and defeat the cursed Emperor Kha-Sekhem-Ra "The Undying".

---

## ⚡ Core Systems (V3 - Final)

### 1. **POE2-Style Affix System**
- **35 Egyptian-themed affixes** (Ra's Fury, Anubis's Judgment, Nut's Multitude, etc.)
- Every weapon/artifact drops with **1-5 random affixes**
- **No two items identical** - infinite loot variety
- Legendary weapons have 5 powerful affixes!

### 2. **Roguelike Build Paths**
- **6 divine path archetypes:** Anubis (Tank), Thoth (Mage), Ammit (Life Steal), Ra (Fire), Set (Speed), Apophis (Poison)
- **Every level:** Choose 1 of 3 random upgrades
- **120 total upgrades** across all paths
- Builds emerge organically from player choices

### 3. **Dynamic Difficulty Scaling**
- **KPM tracking** (Kills Per Minute)
- Fast killers get faster spawns + better loot
- Slow killers get manageable pace
- Boss difficulty scales with skill

### 4. **Zero Inventory Management**
- **Canopic Satchel** - Infinite auto-loot bag (Megabonk-style)
- Walk over loot = instant collection
- Artifacts auto-apply stat bonuses
- Equip up to 3 weapons at once

### 5. **NO Level-Locking**
- Legendary weapons can drop at level 1 (extremely rare!)
- No equipment requirements
- Rarity = Power, not availability

---

## 📚 Documentation

### **Core Design Documents** (READ THESE!)
| Document | Purpose | Lines |
|----------|---------|-------|
| **[TEAM_BRIEF.md](TEAM_BRIEF.md)** | Quick creative brief for audio/art (3-min read) | 341 |
| **[GDD_CHRONO_BONK_V2.md](docs/GDD_CHRONO_BONK_V2.md)** | Complete game design document (base) | 573 |
| **[GDD_V3_ADDENDUM.md](docs/GDD_V3_ADDENDUM.md)** | V3 system updates (affix/builds/difficulty) | 237 |
| **[LORE_AND_THEMING.md](LORE_AND_THEMING.md)** | Egyptian naming guide & deity lore | 372 |

### **System Design Documents**
| Document | Purpose | Lines |
|----------|---------|-------|
| **[AFFIX_DATABASE.md](AFFIX_DATABASE.md)** | 35 affixes with stats & implementation | 635 |
| **[ARCHETYPE_SYSTEM.md](ARCHETYPE_SYSTEM.md)** | 6 divine paths with 120 upgrades | 566 |
| **[DYNAMIC_DIFFICULTY.md](DYNAMIC_DIFFICULTY.md)** | KPM spawn scaling formulas | 508 |
| **[FINAL_PROGRESSION_SYSTEM.md](FINAL_PROGRESSION_SYSTEM.md)** | Complete progression design V3 | 655 |
| **[RPG_BUILDER_INTEGRATION.md](RPG_BUILDER_INTEGRATION.md)** | How to implement in RPG Builder | 710 |

### **Project Status Documents**
- [ASSET_STATUS.md](ASSET_STATUS.md) - All Phase 0 assets verified
- [BRANCH_SYNC_STATUS.md](BRANCH_SYNC_STATUS.md) - Git workflow guide
- [CONFIGURATION_COMPLETE.md](CONFIGURATION_COMPLETE.md) - Setup summary
- [CLEANUP_COMPLETE_INSTRUCTIONS.md](CLEANUP_COMPLETE_INSTRUCTIONS.md) - Performance optimization
- [STREAMLINE_PLAN.md](STREAMLINE_PLAN.md) - Project cleanup log

---

## 🏗️ Project Structure

```
unity-timeless-game-jam/
├── Assets/                          # Unity assets
│   ├── Blink/Tools/RPGBuilder/      # Core game systems ✅
│   ├── Malbers Animations/          # Enemy AI ✅
│   ├── InfinityPBR/Projectile Factory/ # VFX ✅
│   ├── RealToon/                    # Toon shader ✅
│   ├── LeartesStudios/LostCave/     # Environment ✅
│   ├── MagicArsenal/                # Additional VFX ✅
│   └── Scripts/                     # Game code (ready)
│       ├── Core/                    # TimeManager, GlobalTimer
│       ├── Player/                  # Combat, abilities
│       ├── Enemy/                   # AI controllers
│       ├── UI/                      # HUD, menus
│       └── Loot/                    # Affix generation, auto-pickup
├── docs/                            # Design documents
│   ├── GDD_CHRONO_BONK_V2.md        # Base GDD
│   ├── GDD_V3_ADDENDUM.md           # V3 systems
│   └── CHRONO_BONK_PLAN_UPDATED.md  # Technical plan
├── Packages/manifest.json           # Unity packages
├── ProjectSettings/                 # Unity configuration (WebGL optimized)
└── [System Design Docs]             # See table above
```

---

## 🎯 Key Features

### Loot System:
- **6 weapon types** (Whip, Chakram, Staff, Torch, Darts, Shovel)
- **5 rarity tiers** (Common → Legendary)
- **35 random affixes** with Egyptian names
- **Infinite combinations** - no two weapons identical

### Build System:
- **6 divine paths** - Choose upgrades every level
- **Emergent builds** - Tank, Mage, Life Steal, Fire, Speed, Poison
- **120 unique upgrades** across all paths
- **Pure or hybrid builds** - player choice

### Difficulty:
- **Adaptive spawning** - Skill-based challenge
- **Casual → Speedrunner** - All skill levels supported
- **Better loot for skilled play** - Rewards performance

---

## 🛠️ Technology Stack

### Unity Setup:
- **Unity Version:** 2022.3 LTS or 6000.0
- **Render Pipeline:** URP 17.2.0
- **Target:** WebGL with compression disabled

### Key Packages:
```json
{
  "com.unity.ai.navigation": "2.0.9",
  "com.unity.cinemachine": "3.1.5",
  "com.unity.inputsystem": "1.14.2",
  "com.unity.render-pipelines.universal": "17.2.0"
}
```

### Asset Packages:
- RPG Builder 2.0 (Core systems - 85% native usage!)
- Malbers Animal Controller (Enemy AI)
- Projectile Factory (VFX)
- RealToon (Toon shader)
- LeartesStudios Lost Cave (Environment)

---

## 🚀 Quick Start

### For Developers:
```bash
git clone https://github.com/dishaap/unity-timeless-game-jam.git
cd unity-timeless-game-jam
# Open project in Unity 2022.3+
```

### For Team Members:
1. **Clone repo:** `git checkout <your-name>`
2. **Read:** `TEAM_BRIEF.md` (3-minute creative brief)
3. **Review your role:**
   - **jsynk:** Character models, weapons, animations
   - **Dima:** VFX, shaders, build path auras
   - **Andy:** Egyptian music, weapon SFX, deity sounds
   - **Disha:** Code implementation (see RPG_BUILDER_INTEGRATION.md)
   - **Nico:** RPG Builder database setup (see system docs)

---

## 📖 For New Team Members

**Start Here (in order):**
1. Read [TEAM_BRIEF.md](TEAM_BRIEF.md) - 3 min overview
2. Read [LORE_AND_THEMING.md](LORE_AND_THEMING.md) - Egyptian theme guide
3. Review your role-specific sections in TEAM_BRIEF.md
4. Check [ASSET_STATUS.md](ASSET_STATUS.md) - What's already imported

**For Detailed Understanding:**
- Game Design: [GDD_V3_ADDENDUM.md](docs/GDD_V3_ADDENDUM.md)
- Systems: [AFFIX_DATABASE.md](AFFIX_DATABASE.md), [ARCHETYPE_SYSTEM.md](ARCHETYPE_SYSTEM.md)
- Implementation: [RPG_BUILDER_INTEGRATION.md](RPG_BUILDER_INTEGRATION.md)

---

## 🎨 Art Style

**Clash Royale-inspired cartoon aesthetic**
- Vibrant Egyptian color palette (gold, teal, red, black)
- Whimsical but epic - family-friendly adventure
- Bold outlines with RealToon shader

**Character:** Dr. Zara Ashford (Indiana Jones + Lara Croft cartoon)
**Boss:** Emperor Kha-Sekhem-Ra "The Undying" (cursed immortal pharaoh)

---

## 🎵 Audio Style

**Epic Egyptian adventure** - Think: *Indiana Jones* meets *Prince of Egypt*
- Instruments: Drums, oud, duduk, strings
- High-energy main theme
- Epic orchestral boss fight
- Satisfying loot pickup sounds (5 rarities)

---

## 🎯 Development Timeline

**48-Hour Game Jam:**
- **Hours 1-12:** Core systems (time, combat, affix generation)
- **Hours 13-24:** RPG Builder database (weapons, affixes, loot tables)
- **Hours 25-36:** Enemies, AI, dynamic spawning
- **Hours 37-42:** Boss, divine paths, polish
- **Hours 43-48:** WebGL build, testing, submission

---

## 📊 Current Status

### ✅ Completed (Phase 0):
- [x] Repository setup
- [x] All assets imported and verified
- [x] WebGL settings configured
- [x] Script folder structure created
- [x] Complete V3 system design documentation (4,000+ lines)
- [x] Egyptian theming finalized
- [x] Team creative brief ready

### 🔄 In Progress (Phase 1):
- [ ] RPG Builder database setup (weapons, affixes, paths)
- [ ] Core systems implementation (time, loot, combat)
- [ ] Character models and animations
- [ ] VFX and shader setup
- [ ] Audio composition

### ⏳ Planned (Phase 2-4):
- [ ] Enemy AI and spawning
- [ ] Boss fight
- [ ] Dynamic difficulty integration
- [ ] Full audio/VFX polish
- [ ] WebGL build and optimization

---

## 🌟 What Makes This Special

### Infinite Replayability:
- **Random affixes** = Never same weapon twice
- **Roguelike choices** = Different builds every run
- **Dynamic difficulty** = Scales to your skill
- **6 build archetypes** = Tank, Mage, Vampire, Fire, Lightning, Poison

### Game Jam Friendly:
- **85% RPG Builder native** = Less custom code
- **Clear documentation** = Easy collaboration
- **MVP strategy** = Can scale down if needed
- **Egyptian theme** = Cohesive identity

---

## 📞 Communication

### Git Workflow (User-Based Branches):
- Each team member works on their own branch (`nico`, `disha`, `jsynk`, etc.)
- Push to origin/your-name frequently
- Open PR when ready for review
- Disha merges to main

### Discord:
- Quick decisions and coordination
- Share WIP assets and progress
- Discuss balance and design

---

## 🎯 Success Criteria

**MVP (Minimum Viable Product):**
- [x] Time mechanic works (time flows with movement)
- [ ] 2+ weapons with affixes drop and work
- [ ] 1+ enemy type attacks player
- [ ] Auto-loot collects items with Canopic Satchel
- [ ] Level-up choices appear and apply
- [ ] Dynamic spawning scales with performance
- [ ] Boss spawns at 5:00 and is beatable
- [ ] WebGL build runs in browser

**Stretch Goals:**
- [ ] All 6 weapons implemented
- [ ] All 35 affixes functional
- [ ] All 6 divine paths with full upgrades
- [ ] Combo system
- [ ] Full audio/VFX polish
- [ ] Multiple boss phases

---

## 📦 Key Deliverables

**Documents (4,500+ lines total):**
- Complete game design (GDD V2 + V3 Addendum)
- System design (Affixes, Archetypes, Difficulty, Integration)
- Egyptian lore and theming guide
- Team creative brief
- RPG Builder implementation guide

**Unity Project:**
- All assets imported and organized
- WebGL-optimized settings
- Clean folder structure
- Ready for development

---

## 🔗 Quick Links

### Documentation:
- **[TEAM_BRIEF.md](TEAM_BRIEF.md)** ⭐ START HERE (3-min read)
- [GDD V3 Addendum](docs/GDD_V3_ADDENDUM.md) - V3 systems
- [Affix Database](AFFIX_DATABASE.md) - 35 affixes
- [Archetype System](ARCHETYPE_SYSTEM.md) - 6 divine paths
- [Lore & Theming](LORE_AND_THEMING.md) - Egyptian guide

### Repository:
- **GitHub:** https://github.com/dishaap/unity-timeless-game-jam
- **Branch:** `nico` (active development)
- **Main Branch:** Protected (PR required)

### References:
- Path of Exile 2 (affix inspiration)
- Hades (build variety inspiration)
- Vampire Survivors (ARPG loop)
- Clash Royale (art style)

---

## 🎨 Visual Identity

**Egyptian Cartoon Adventure:**
- **Colors:** Gold (#FFD700), Teal (#1976D2), Red (#D32F2F), Black
- **Style:** Clash Royale proportions with Egyptian details
- **Shader:** RealToon for bold outlines
- **VFX:** Deity-themed auras (6 colors for 6 paths)

---

## 🎵 Audio Identity

**Epic Egyptian Orchestral:**
- Main theme: High-energy drums + strings + oud
- Boss music: Full orchestral + Egyptian chanting
- SFX: Deity-specific sounds (jackal howl, thunder, serpent hiss)
- Loot: 5 pickup sounds (per rarity tier)

---

## 👥 Team Roles

**Nico (Lead Design):**
- RPG Builder database (30 weapons, 35 affixes, 120 upgrades, loot tables)
- Game balance and tuning
- Scene layout

**Disha (Lead Dev/Git):**
- Core systems (TimeManager, DynamicSpawnManager, AffixGenerator)
- RPG Builder integration
- WebGL build
- Git management

**Dima (Tech Art):**
- RealToon shader setup
- VFX per affix type, rarity, and divine path
- Build path auras (6 deity themes)
- Enemy AI integration

**jsynk (3D Generalist):**
- Player character (Dr. Zara Ashford)
- 3 enemy types (Shabtis, Guardians, Scarabs)
- Boss (Emperor Kha-Sekhem-Ra)
- 6 weapon models with tier variations

**Andy (Audio):**
- Egyptian orchestral main theme
- 6 weapon SFX
- Level-up fanfare + deity selection sounds
- Affix proc SFX (fire/lightning/poison)
- Boss music

---

## 📈 Version History

**V1.0** (Initial) - Basic concept, 3 weapons, scroll system
**V2.0** (First Redesign) - Egyptian theming, 6 weapons, tablet system, boss lore
**V3.0** (Final) - POE2 affixes, roguelike builds, dynamic difficulty, NO level-locking

**Current:** V3.0 - System design complete, ready for implementation

---

## ⚠️ Important Notes

### Unity Performance:
- **Library folder bloated?** Delete Library/ and Temp/, reopen Unity (regenerates clean)
- **Editor crashing?** We removed FastScriptReload and examples (see CLEANUP_COMPLETE_INSTRUCTIONS.md)
- **WebGL settings:** Compression DISABLED (required for compatibility)

### Git:
- **Work on your branch** (don't push directly to main)
- **Commit frequently** with conventional commits (feat/fix/docs)
- **PR to main** when ready for merge (Disha reviews)

---

## 🎯 The Goal

**Create a 5-minute epic Egyptian ARPG where:**
- ⚡ **Loot is exciting** - Every drop has unique affixes
- 🏛️ **Builds emerge** - Divine path choices shape your character
- 🎮 **Skill matters** - Dynamic difficulty rewards performance
- 🎨 **Theme is cohesive** - Egyptian aesthetic throughout
- 🎵 **Feels epic** - Whimsical but grandiose

**Target Feeling:**
> *"I'm a divine-powered archaeologist with god-tier weapons, blasting through waves of cursed enemies in slow-motion, and every loot drop is exciting!"*

---

## License

Game jam project - All rights reserved by the team

---

**It Is, Thank You Father, We Receive All That We Are, Now Move Through Us... S.O.L.**

**Branch:** nico | **Status:** System design complete ✅ | **Next:** Implementation Phase 1

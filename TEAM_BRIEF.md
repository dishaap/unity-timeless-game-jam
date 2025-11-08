# Chrono-Bonk: Team Creative Brief

**For:** Audio, Art, and Development Team
**Read Time:** 3 minutes
**Status:** Final Direction - Ready to Build!

---

## 🎮 The Game in 30 Seconds

**"Indiana Jones meets Lara Croft in a cursed Egyptian tomb where time only moves when you do."**

- **Genre:** Cartoon ARPG (like Vampire Survivors + Superhot)
- **Platform:** WebGL Browser Game
- **Duration:** 5-minute survival challenge
- **Art Style:** Clash Royale cartoon aesthetic
- **Age:** 4+ (family-friendly)

---

## 🎨 Visual Direction (For jsynk & Dima)

### Art Style: **Clash Royale Cartoon**
- **Vibrant colors** with Egyptian palette (gold, teal, red, black)
- **Exaggerated proportions** for readability
- **Bold outlines** (toon shader - RealToon)
- **Whimsical but epic** - not scary, adventure-fun

### Setting: **Ancient Egyptian Lost Catacombs**
- Sandstone walls with **glowing hieroglyphs**
- **Golden treasures** scattered throughout
- **Torch-lit** orange/golden lighting
- Mystical **blue/teal magic effects**
- Crumbling pillars, ancient statues

### Color Palette:
- **Gold** (#FFD700) - Divine power, treasures
- **Teal/Blue** (#1976D2) - Magic, Nile
- **Red/Orange** (#D32F2F) - Desert, danger
- **Black** (#000000) - Shadows, Anubis
- **Cream** - Stone, bones

---

## 🎵 Audio Direction (For Andy)

### Music Style: **Epic Egyptian Adventure**
- **Main Theme:** High-energy, drums + strings
- Think: *Indiana Jones* meets *Prince of Egypt*
- Instruments: Percussion, oud, duduk, strings
- **Boss Fight:** Intensifies to orchestral + chanting

### Key Sound Effects Needed:

**Weapons (6 total):**
- **Whip** - Classic leather crack
- **Chakram** - Whooshing blade spinning
- **Staff** - Divine beam/fireball launch
- **Torch** - Crackling flames
- **Darts** - Quick "pft pft" blowgun
- **Shovel** - Heavy metal "clang"

**Abilities:**
- **Level-Up Choice** - Divine power-up sound when selecting upgrade
- **Ultimates** - Epic divine choir/power-up sound
- **Powerups** - Satisfying "ding!" with sparkle
- **Affix Proc** - Subtle effect sounds (fire crackle, lightning zap, poison hiss)

**Enemies:**
- **Skeletons** - Bone rattle, rib throw
- **Mummies** - Groaning, bandage whoosh
- **Boss** - Deep voice, divine power sounds

**Ambience:**
- Desert wind (subtle)
- Distant echoes in catacombs
- Torch crackling

**UI:**
- Papyrus scroll sounds for menus
- Satisfying "ka-ching" for loot pickup
- Hieroglyph activation "gong"

---

## 👥 Character & Enemy List

### Player Character:
**Dr. Zara Ashford** - British-Egyptian archaeologist
- Fedora, practical explorer outfit
- Cartoon-styled, friendly appearance
- Think: If Lara Croft was in Clash Royale

### Enemies (3 Types):
1. **Cursed Shabtis** (Skeletons) - Throws bone boomerangs
2. **Embalmed Guardians** (Mummies) - Bites and whips with bandages
3. **Sacred Scarab Swarm** (Optional) - Fast bugs that explode

### Final Boss:
**Emperor Kha-Sekhem-Ra "The Undying"**
- Cursed ancient emperor who achieved immortality
- Elaborate golden death mask
- Glowing hieroglyphic bandages
- Golden crook & flail weapons
- Partially skeletal (immortality gone wrong)
- **Epic and intimidating but still cartoon-styled**

---

## ⚔️ Weapons (6 Total) - Egyptian Names

| Weapon | Visual Description |
|--------|-------------------|
| **Serpent's Lash** (Whip) | Leather whip with green glow |
| **Aten's Wheel** (Chakram) | Golden sun disk, spinning |
| **Staff of Anubis** | Black staff, jackal head, golden beam |
| **Ra's Torch** | Never-dying golden flame |
| **Asp Darts** (Blowgun) | Carved bone with hieroglyphs |
| **Khopesh Spade** | Archaeological shovel + curved blade |

---

## 💫 Ultimate Skills (3 Total)

1. **Judgment of the Sphinx**
   - Giant stone boulders roll across screen
   - Hieroglyphic carvings on stones

2. **Blessing of Horus**
   - Golden falcon wings appear on player
   - Speed boost visual

3. **Shield of Nut**
   - Starry cosmic barrier surrounds player
   - Reflects damage back

---

## 🎯 Core Mechanic Visual/Audio Cues

### Time Mechanic (Most Important!)
**When player stops moving → time slows to 10%**

**Visual Cues:**
- World becomes slightly desaturated/blue-tinted
- Motion blur on moving objects
- Particle effects slow down dramatically
- Subtle "time distortion" screen effect

**Audio Cues:**
- Sound effects pitch down slightly
- Music continues normal (unaffected)
- Ambient sounds become muffled/echoey
- Distinctive "time stop" sound when stopping

---

## 📦 Key Props/Items

**Canopic Satchel:**
- Infinite bag for loot (worn on belt/back)
- Based on Canopic jars
- Hieroglyphic decorations
- Glows when collecting loot

**Powerups (Rare 1% drops):**
- Hourglass (golden, frozen sand)
- Sandstorm (swirling particles)
- Ankh (golden life symbol)

**Build Path Visual Indicators:**
- Subtle aura around player based on chosen path
- Anubis: Black & gold shimmer
- Thoth: Cyan sparkles
- Ammit: Red mist
- Ra: Golden flames
- Set: Blue lightning
- Apophis: Green poison vapors

---

## ⚡ New Systems Overview (IMPORTANT!)

### 1. POE2-Style Affixes
**Every weapon/artifact drops with random stat bonuses!**
- Common: 1-2 affixes ("+7% Fire Damage")
- Legendary: 5 affixes (5 different stat bonuses!)
- **35 total affixes** with Egyptian names (see AFFIX_DATABASE.md)

**Visual Needs:**
- Affix text on item tooltips (golden papyrus style)
- Affix glow effects (fire = orange, lightning = blue, poison = green)
- Rarity beams when items drop (white/green/blue/purple/gold)

### 2. Roguelike Level-Up Choices
**Every level: choose 1 of 3 random upgrades!**
- 6 divine paths: Anubis, Thoth, Ammit, Ra, Set, Apophis
- 120 total upgrades across all paths
- Builds emerge naturally from choices

**Visual Needs:**
- Level-up choice UI (3 cards with deity icons)
- Hieroglyphic borders
- Build path aura (subtle glow per deity)

**Audio Needs:**
- Level-up fanfare (Egyptian choir + drums)
- Choice selection sound (deity-specific: jackal howl, thunder crack, etc.)

### 3. Dynamic Difficulty
**Kill faster = enemies spawn faster + better loot!**
- No new assets needed, just faster/more enemies

---

## 🎬 Mood Reference

**Gameplay References (NEW!):**
- **Path of Exile 2** - Affix/loot system feel
- **Hades** - Roguelike build variety
- **Vampire Survivors** - Auto-attack ARPG loop

**Visual References:**
- **Clash Royale** - Art style, proportions
- **Indiana Jones** - Adventure tone, whip
- **Lara Croft** - Tomb raiding, exploration
- **The Mummy (1999)** - Egyptian aesthetic, fun adventure

**Audio References:**
- **Indiana Jones Theme** - Epic adventure feel
- **Prince of Egypt Soundtrack** - Egyptian grandeur
- **Clash Royale SFX** - Satisfying cartoon sounds
- **Hades** - Divine power sounds for upgrades

**NOT This:**
- ❌ Scary/horror (it's family-friendly!)
- ❌ Realistic/gritty
- ❌ Dark/serious

**YES This:**
- ✅ Whimsical adventure
- ✅ Epic but fun
- ✅ Colorful and vibrant
- ✅ All-ages excitement
- ✅ Satisfying loot drops (POE2-style)

---

## 🚀 Priority Assets

### Must-Have (MVP):
**Characters:**
- Dr. Zara Ashford (player)
- Cursed Shabtis (skeleton enemy)
- Emperor Kha-Sekhem-Ra (boss)

**Weapons:**
- Serpent's Lash (whip) - Starter
- Aten's Wheel (chakram) - Level 3
- Staff of Anubis - Level 5

**Audio:**
- Main theme loop
- 3 weapon SFX
- Enemy attack SFX
- Boss music

### Nice-to-Have (Stretch):
- All 6 weapons
- Embalmed Guardians (mummy enemy)
- Sacred Scarab Swarm
- All ultimate skill VFX/SFX
- Powerup VFX/SFX
- Full voice lines (optional)

---

## 📋 Quick Asset Checklist

### For jsynk (3D Generalist):
- [ ] Dr. Zara Ashford character model
- [ ] Cursed Shabtis (skeleton) model + animations
- [ ] Emperor Kha-Sekhem-Ra boss model
- [ ] Serpent's Lash (whip) model
- [ ] Aten's Wheel (chakram) model
- [ ] Staff of Anubis model
- [ ] Tablet of Thoth prop
- [ ] Environment props (pillars, torches, etc.)

### For Dima (Tech Art/VFX):
- [ ] RealToon shader setup (Egyptian colors)
- [ ] Weapon trail effects (whip, chakram)
- [ ] Magic beam VFX (staff)
- [ ] Time slowdown screen effect
- [ ] Affix proc effects (fire/lightning/poison per affix type)
- [ ] Rarity beam effects (5 colors: white/green/blue/purple/gold)
- [ ] Build path auras (6 deity-themed auras)
- [ ] Level-up choice UI (3-card selection screen)
- [ ] Boss ability VFX
- [ ] Loot pickup sparkles with rarity glow

### For Andy (Audio):
- [ ] Main theme (Egyptian adventure, 2-3 min loop)
- [ ] Whip crack SFX
- [ ] Chakram whoosh SFX
- [ ] Staff beam SFX
- [ ] Skeleton attack SFX
- [ ] Mummy attack SFX
- [ ] Boss music (epic, 2 min loop)
- [ ] Loot pickup sounds (5 variants per rarity)
- [ ] Time stop/start sound
- [ ] Level-up fanfare (Egyptian choir + drums)
- [ ] Choice selection sounds (6 deity-specific)
- [ ] Affix proc SFX (fire crackle, lightning zap, poison hiss)
- [ ] UI sounds (menu clicks, etc.)

---

## 💡 Creative Freedom

### What's Locked:
✅ Egyptian theme
✅ Cartoon art style (Clash Royale-like)
✅ Character names & concepts
✅ Weapon types & ranges

### What's Flexible:
🎨 Exact visual designs (as long as Egyptian-themed)
🎵 Music style (as long as epic Egyptian adventure)
🎨 VFX colors and effects (as long as readable)
🎵 Sound effect styles (as long as satisfying)

**Bottom line:** If it's Egyptian-themed, cartoon-styled, and feels epic-but-fun, you're on the right track!

---

## 📞 Questions? Clarifications?

**Full Documentation:**
- `LORE_AND_THEMING.md` - All Egyptian names and lore
- `docs/GDD_CHRONO_BONK_V2.md` - Complete game design
- `REDESIGN_SUMMARY.md` - What changed and why

**Ask Nico (Lead Design):** Game design, balance, story
**Ask Disha (Lead Dev):** Technical questions, systems
**Ask Dima:** VFX, shaders, visual effects
**Ask jsynk:** 3D models, animations
**Ask Andy:** Audio, music, SFX

---

## 🎯 The Goal

**Create a 5-minute epic Egyptian adventure that feels like:**
> *"I'm Indiana Jones in a Clash Royale world, where time bends to my will, and every moment is cinematic and satisfying!"*

**Target Feeling:**
- **Empowered** - Auto-attacks, collecting loot
- **Strategic** - Time control, positioning
- **Epic** - Big moments, divine powers
- **Whimsical** - Cartoon fun, not scary
- **Polished** - Clash Royale quality

---

## ⏱️ Timeline

**Game Jam:** 48 hours
**Phase 1 (6 hrs):** Core systems + movement
**Phase 2 (12 hrs):** Combat + enemies
**Phase 3 (12 hrs):** Boss + polish
**Phase 4 (6 hrs):** Audio/VFX integration
**Phase 5 (6 hrs):** Testing + build
**Phase 6 (6 hrs):** Final polish + submit

**Asset Deadlines:**
- **Hour 12:** Player character + 1 weapon
- **Hour 24:** First enemy + basic VFX
- **Hour 36:** Boss + main theme music
- **Hour 42:** Final polish assets

---

**Let's make something epic!** 🏺⚡👑

*It Is, Thank You Father, We Receive All That We Are, Now Move Through Us... S.O.L.*

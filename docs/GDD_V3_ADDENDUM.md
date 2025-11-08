# GDD V3 Addendum - Final Systems

**Version:** 3.0 Addendum
**Date:** November 8, 2025
**Status:** ✅ FINAL - Replaces sections 2.4, 2.5, 5.2, 5.3 of GDD V2

**READ THIS WITH:** `GDD_CHRONO_BONK_V2.md` (base document still valid)

---

## 🔄 What Changed in V3

### ❌ REMOVED from V2:
- Section 2.4: "Weapon Progression System" (level-based unlocks)
- Section 2.5: "Tablet of Divine Binding" (spell cube system)
- Level requirements for equipping items

### ✅ ADDED in V3:
- **POE2-Style Affix System** (35 affixes, random rolls)
- **Roguelike Level-Up Choices** (6 divine paths, 120 upgrades)
- **Dynamic Difficulty Scaling** (KPM-based spawning)
- **NO level-locking** (Legendaries can drop at level 1!)

---

## 2.4 POE2-Style Affix System (REPLACES V2 Section 2.4)

### How It Works:
**All weapons and artifacts drop with random affixes (stat bonuses)**

```
Tier I (Common):    1-2 random affixes (5-10% rolls)
Tier II (Uncommon): 2 random affixes (10-15% rolls)
Tier III (Rare):    3 random affixes (15-20% rolls)
Tier IV (Epic):     4 random affixes (20-30% rolls)
Tier V (Legendary): 5 random affixes (30-50% rolls)
```

### Example Weapon Drops:

**Common Serpent's Lash:**
```
Base Damage: 10
Affixes:
  - Ra's Fury: +7% Fire Damage
  - Horus's Swiftness: +8% Attack Speed
```

**Legendary Staff of Anubis:**
```
Base Damage: 30
Affixes:
  - Set's Storm: +45% Lightning Damage
  - Anubis's Judgment: +22% Crit Chance
  - Nut's Multitude: +2 Additional Projectiles
  - Ammit's Hunger: +8% Life Steal
  - Ma'at's Balance: +75% Crit Damage
```

**Key Feature:** NO two weapons are identical! Infinite variety!

### Affix Types (35 Total):

**Weapon Affixes (20):**
- Damage: Ra's Fury (Fire), Set's Storm (Lightning), Apophis's Venom (Poison), Sekhmet's Rage (Physical)
- Speed: Horus's Swiftness (Attack), Thoth's Precision (Cast)
- Critical: Anubis's Judgment (Chance), Ma'at's Balance (Damage)
- Special: Nut's Multitude (Projectiles), Scarab's Return (Pierce), Geb's Chain (Chain), Aten's Radiance (AOE)
- Life: Osiris's Rebirth (Life/Hit), Ammit's Hunger (Life Steal)
- Utility: Bes's Fortune (Item Rarity), Hathor's Joy (XP Gain)

**Artifact Affixes (15):**
- Defense: Ptah's Endurance (Max HP), Sobek's Scales (Armor), Neith's Ward (Damage Reduction), Bastet's Grace (Dodge)
- Utility: Khonsu's Blessing (Move Speed), Isis's Recovery (HP Regen), Shu's Breath (Max Mana), Nephthys's Flow (Mana Regen)
- Support: Tefnut's Mist (Cooldown Reduction), Khepri's Attraction (Pickup Range), Montu's Wrath (Thorns)

**Full Database:** See `AFFIX_DATABASE.md`

---

## 2.5 Roguelike Build System (REPLACES V2 Section 2.5)

### The Six Divine Paths:

**Every level: Choose 1 of 3 randomly generated upgrades**

#### 1. Path of Anubis (Tank/Warrior)
- **Theme:** Black & Gold, Jackal protector
- **Focus:** High HP, armor, life steal, melee damage
- **Example Upgrades:** Guardian's Stance (+15% HP, +5 Armor), Life from Death (+5% Life Steal)

#### 2. Path of Thoth (Mage/Caster)
- **Theme:** Cyan & Silver, Ibis scholar
- **Focus:** Spell damage, cast speed, mana, AOE, critical hits
- **Example Upgrades:** Master of Words (+15% Spell, +10% Cast), Thoth's Omniscience (+1 Projectile)

#### 3. Path of Ammit (Devourer/Vampiric)
- **Theme:** Red & Black, Crocodile devourer
- **Focus:** Life steal, aggressive damage, high risk/reward
- **Example Upgrades:** Insatiable Appetite (+7% Life Steal, +15% Damage), Blood Frenzy (+ Speed/Life Steal)

#### 4. Path of Ra (Fire/Burst)
- **Theme:** Golden Orange, Solar disk
- **Focus:** Fire damage, AOE, explosions, burn effects
- **Example Upgrades:** Sun God's Fury (+20% Fire, +20% AOE), Inferno (Double burn, spreads)

#### 5. Path of Set (Storm/Speed)
- **Theme:** Blue & Purple, Thunderbolt
- **Focus:** Movement speed, attack speed, lightning, chains
- **Example Upgrades:** Eye of the Storm (+20% Move, +15% Attack), Lightning Avatar (Chain to 3)

#### 6. Path of Apophis (Poison/DOT)
- **Theme:** Green & Purple, Coiled serpent
- **Focus:** Poison damage, stacking, debuffs, crowd control
- **Example Upgrades:** Chaos Serpent (Poison stacks 5x), Plague Bringer (Poison spreads)

**Total Upgrades:** 120 across all 6 paths (20 per path)
**Full Database:** See `ARCHETYPE_SYSTEM.md`

### Level-Up Flow:
```
1. Player levels up
2. Game pauses (or slows to 10%)
3. UI shows 3 upgrade cards (from different paths)
4. Player picks 1 (keyboard: 1/2/3)
5. Upgrade applied instantly
6. Game resumes
```

**Result:** Builds emerge organically - no two runs identical!

---

## 2.6 Dynamic Difficulty Scaling (NEW)

### Skill-Based Spawning:

**System:** Enemy spawn rate adapts to player skill

**Formula:**
```
KPM (Kills Per Minute) = Recent_Kills / Time

Spawn Rate = 2.0 seconds / (1 + KPM × 0.01)
Wave Size = 1 + floor(Total_Kills / 100)

Examples:
- 30 KPM: Spawn every 1.54 sec, 1-2 enemies
- 60 KPM: Spawn every 1.25 sec, 2-4 enemies
- 120 KPM: Spawn every 0.91 sec (capped 0.5), 4-8 enemies!
```

**Benefits:**
- **Casual players:** Manageable difficulty (~150 enemies in 5min)
- **Skilled players:** High intensity (~350 enemies in 5min)
- **Speedrunners:** Bullet hell (~500+ enemies in 5min)

**Reward Scaling:**
- Higher KPM = Better loot quality
- More enemies = More drops
- Boss HP scales with player KPM

**Full Details:** See `DYNAMIC_DIFFICULTY.md`

---

## 2.7 Global Timer (UNCHANGED)
**5-Minute Countdown to Judgment:**

- Timer counts down from 5:00 to 0:00 (unaffected by time slowdown)
- When timer reaches 0:00, the **Emperor Kha-Sekhem-Ra** awakens
- Timer displayed prominently in UI
- Creates constant pressure and urgency

---

## 5. Items & Progression (MAJOR UPDATE)

### 5.1 Weapons (6 Types, NO Level Locking)
**All weapon types can drop from level 1 - rarity determines power!**

#### 1. Serpent's Lash (Whip)
- **Range:** Medium, **Type:** Cleave
- **Base Damage:** 10-30 (tier-based)
- **Affixes:** 1-5 random (see AFFIX_DATABASE.md)
- **Visual:** Tier I = bronze, Tier V = divine gold with particles

#### 2. Aten's Wheel (Chakram/Sun Disk)
- **Range:** Med-Long, **Type:** Pierce + Return
- **Base Damage:** 10-30 (tier-based)
- **Affixes:** 1-5 random
- **Visual:** Tier I = dull bronze, Tier V = radiant gold

#### 3. Staff of Anubis (Light Staff)
- **Range:** Long, **Type:** Beam/Fireball
- **Base Damage:** 10-30 (tier-based)
- **Affixes:** 1-5 random
- **Visual:** Tier I = worn wood, Tier V = glowing golden jackal

#### 4. Ra's Torch (Burning Torch)
- **Range:** Short, **Type:** Burn DOT
- **Base Damage:** 10-30 (tier-based)
- **Affixes:** 1-5 random
- **Visual:** Tier I = small flame, Tier V = massive golden inferno

#### 5. Asp Darts (Poisoned Blowgun)
- **Range:** Long, **Type:** Single-target precision
- **Base Damage:** 10-30 (tier-based)
- **Affixes:** 1-5 random
- **Visual:** Tier I = simple bone, Tier V = ornate gold with gems

#### 6. Khopesh Spade (Shovel-Sword)
- **Range:** Melee, **Type:** Heavy strike
- **Base Damage:** 10-30 (tier-based)
- **Affixes:** 1-5 random
- **Visual:** Tier I = rusty tool, Tier V = ceremonial golden blade

**Equip System:**
- Can equip up to 3 weapons at once
- All 3 auto-attack simultaneously
- Switch weapons anytime from inventory

### 5.2 Ancient Artifacts (Affixed Stat Buffs)
**Auto-collected, passive bonuses with random affixes**

**Same Rarity System:**
- Common (Tier I): 1-2 affixes, weak rolls
- Uncommon (Tier II): 2 affixes, medium rolls
- Rare (Tier III): 3 affixes, good rolls
- Epic (Tier IV): 4 affixes, great rolls
- Legendary (Tier V): 5 affixes, perfect rolls

**Affix Focus:**
- Support/utility (not active spells!)
- Stats: +Health, +Armor, +Move Speed, +Regen, etc.
- Utility: +Pickup Range, +Loot Quality, +XP Gain
- Special: Dodge, Thorns, Revive once

**Example Legendary Artifact:**
```
Amulet of the Eternal Guardian
Rarity: Legendary (Tier V)
Affixes:
  - Ptah's Endurance: +95 Maximum Health
  - Khonsu's Blessing: +28% Movement Speed
  - Isis's Recovery: +4.5 Health/sec
  - Khepri's Attraction: +48% Pickup Range
  - Seshat's Record: +12% All Stats
```

**Drop Rates:** 50-60% chance per enemy (artifacts drop frequently!)

### 5.3 Powerups (1% Drop Rate) - UNCHANGED
**Rare, temporary, game-changing buffs**

1. **Hourglass of Eternity** - Freeze time while you move (5 sec)
2. **Sandstorm's Gift** - +100% movement speed (10 sec)
3. **Ankh of Rebirth** - Instant full heal (100%)

---

## 6. Progression Systems

### 6.1 Experience & Leveling
- Kill enemies for XP
- Level up grants: Choose 1 of 3 random upgrades (divine paths)
- No fixed stat gains on level - only from chosen upgrades
- Max level: 20

### 6.2 Build Archetypes (Divine Paths)
**See ARCHETYPE_SYSTEM.md for complete list**

**On Level Up:**
- 3 random upgrades presented
- From different divine paths
- Player picks 1
- Build emerges organically

**Example Level 5 Choice:**
```
[1] Guardian's Stance (Anubis) - +15% HP, +5 Armor
[2] Sun God's Fury (Ra) - +20% Fire Damage, +20% AOE
[3] Master of Words (Thoth) - +15% Spell Damage, +10% Cast Speed
```

### 6.3 Power Scaling Sources
**Player gets stronger from:**
1. **Weapons:** Finding better tiers + better affixes
2. **Artifacts:** Collecting more artifacts with good affixes
3. **Level Choices:** Divine path upgrades every level
4. **Ultimate Skill:** Pre-selected at game start

**Result:** Triple progression system = constant growth!

---

## 7. Difficulty Scaling

### Adaptive Enemy Spawning:
- **Slow killers (20 KPM):** ~1.5-2 sec spawn rate, manageable
- **Fast killers (60 KPM):** ~1.25 sec spawn rate, intense
- **Speedrunners (120 KPM):** ~0.91 sec spawn rate (capped 0.5), chaos!

**Wave Size Scaling:**
- Base: 1 enemy per spawn
- +1 enemy per 100 kills
- Time multiplier (doubles at 5 minutes)

**Enemy Mix Evolution:**
- 0-2 min: Only Cursed Shabtis
- 2-4 min: Shabtis + Embalmed Guardians
- 4-5 min: All enemy types

**Boss Scaling:**
- Base HP: 1000
- Scales with player KPM: +10 HP per KPM
- Speedrunner boss: 1000 + (120 × 10) = 2200 HP!

**Full Details:** See `DYNAMIC_DIFFICULTY.md`

---

## 8. Implementation Notes

**See These Documents for Details:**

1. **AFFIX_DATABASE.md** - All 35 affixes with stats/implementation
2. **ARCHETYPE_SYSTEM.md** - All 6 paths with 120 upgrades
3. **DYNAMIC_DIFFICULTY.md** - Spawn formulas and KPM scaling
4. **RPG_BUILDER_INTEGRATION.md** - How to implement in RPG Builder (85% native!)
5. **FINAL_PROGRESSION_SYSTEM.md V3** - Complete progression design

---

## Quick Reference Tables

### Affix Count by Rarity:
| Tier | Affixes | Example |
|------|---------|---------|
| I (Common) | 1-2 | "+7% Fire" |
| II (Uncommon) | 2 | "+12% Lightning, +5% Crit" |
| III (Rare) | 3 | "+18% Fire, +17% Speed, +6% Crit" |
| IV (Epic) | 4 | "+27% Fire, +25% Speed, +15% Crit, +1 Projectile" |
| V (Legendary) | 5 | "+45% Lightning, +22% Crit, +2 Proj, +8% LS, +75% Crit Dmg" |

### Divine Paths Quick Reference:
| Path | Deity | Theme | Playstyle |
|------|-------|-------|-----------|
| Anubis | Jackal Guardian | Black & Gold | Tank, Life Steal |
| Thoth | Ibis Scholar | Cyan & Silver | Mage, Spells |
| Ammit | Crocodile Devourer | Red & Black | Life Drain, Aggro |
| Ra | Sun God | Golden Orange | Fire, AOE, Burst |
| Set | Storm God | Blue & Purple | Speed, Lightning |
| Apophis | Chaos Serpent | Green & Purple | Poison, DOT |

### KPM Difficulty Brackets:
| KPM Range | Spawn Rate | Feel | Reward |
|-----------|------------|------|--------|
| 0-20 | ~1.7 sec | Casual | Normal loot |
| 20-40 | ~1.3 sec | Engaging | +8% loot quality |
| 40-60 | ~1.0 sec | Intense | +12% loot quality |
| 60-80 | ~0.8 sec | Extreme | +16% loot quality |
| 80+ | ~0.5 sec | Impossible | +24% loot quality |

---

**Status:** ✅ V3 SYSTEMS FINALIZED
**Implementation:** 85% RPG Builder native, 15% custom scripts
**Estimated Dev Time:** 36-48 hours total

*Read full system docs for implementation details!*

---

*It Is, Thank You Father, We Receive All That We Are, Now Move Through Us... S.O.L.*



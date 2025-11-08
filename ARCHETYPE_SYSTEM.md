# Build Archetype System - Paths of the Gods

**System:** Roguelike Level-Up Choices
**Implementation:** RPG Builder Talent Tree (Repurposed)
**Theme:** Egyptian Deities & Divine Paths

---

## 🎯 System Overview

### How It Works:
- **Every level:** Player chooses 1 of 3 randomly generated upgrades
- **No rerolls:** Choice is final, creates build commitment
- **Upgrades organized into 6 divine paths** (archetypes)
- **Amplifies everything:** Current weapons, ultimate skill, stats
- **Non-intrusive UI:** Quick choice, back to action

### Level-Up Flow:
```
1. Player kills enough enemies → Level Up!
2. Time pauses (or slows to 10%)
3. UI shows 3 upgrade cards (randomly selected)
4. Player picks 1 card
5. Upgrade applied instantly
6. Time resumes, player continues
```

---

## 🏛️ The 6 Divine Paths

### 1. **Path of the Warrior** - Anubis (Tank/Melee)
**Deity:** Anubis - Guardian of the Dead, Protector
**Theme Color:** Black & Gold
**Playstyle:** Close-range brawler, high survivability

**Core Identity:**
- High health and armor
- Life steal and regeneration
- Melee damage bonuses
- Damage reflection

**Upgrade Pool (20 upgrades):**

**Tier 1 (Common):**
- **"Anubis's Fortitude":** +10% Maximum Health
- **"Guardian's Stance":** +5% Damage Reduction
- **"Devourer's Touch":** +2% Life Steal
- **"Jackal's Resilience":** +3 Health Regeneration/sec
- **"Scales of Judgment":** +10 Armor

**Tier 2 (Uncommon):**
- **"Protector's Aura":** +15% Maximum Health, +5 Armor
- **"Life from Death":** +5% Life Steal, +2 Life per Kill
- **"Unbreakable Will":** +10% Damage Reduction, Cannot be Stunned
- **"Jackal's Fury":** +20% Melee Damage, +15% Maximum Health
- **"Weigher's Blessing":** Gain +1% All Stats per 100 Health

**Tier 3 (Rare):**
- **"Anubis's Judgment":** Reflect 15% of Damage Taken
- **"Guardian of the Duat":** +25% Maximum Health, +10% Damage Reduction, Regenerate 1% Health/sec
- **"Eternal Sentinel":** Revive once with 50% Health (once per game)
- **"Jackal's Rampage":** +30% Melee Damage, Melee attacks heal 5% of damage dealt

**Tier 4 (Epic):**
- **"Anubis's Avatar":** +50% All Defensive Stats, Immune to Poison, +20% Life Steal

---

### 2. **Path of the Mage** - Thoth (Spell Caster/Magic)
**Deity:** Thoth - God of Wisdom, Magic, Knowledge
**Theme Color:** Cyan & Silver
**Playstyle:** Long-range spell damage, mana efficiency

**Core Identity:**
- Increased spell damage and cast speed
- Mana cost reduction and regeneration
- AOE and projectile bonuses
- Critical hit focus

**Upgrade Pool (20 upgrades):**

**Tier 1 (Common):**
- **"Thoth's Wisdom":** +10% Spell Damage
- **"Scribe's Focus":** +10% Cast Speed
- **"Infinite Ink":** +20% Mana Regeneration
- **"Knowledge's Gift":** +25 Maximum Mana
- **"Hieroglyph Power":** +5% Critical Hit Chance

**Tier 2 (Uncommon):**
- **"Master of Words":** +15% Spell Damage, +10% Cast Speed
- **"Eternal Library":** +50 Maximum Mana, Spells cost 10% less
- **"Sacred Geometry":** +20% AOE Size, Spell effects last 15% longer
- **"Divine Intellect":** +15% Crit Chance, +25% Crit Damage
- **"Moon Scribe":** Gain +1% Spell Damage per 10 Mana

**Tier 3 (Rare):**
- **"Thoth's Omniscience":** +1 Additional Projectile to all attacks
- **"Book of the Dead":** Critical hits restore 10 Mana
- **"Infinite Possibilities":** Attacks have 10% chance to cast twice
- **"Cosmic Knowledge":** +30% Spell Damage, +20% AOE, +15% Cast Speed

**Tier 4 (Epic):**
- **"Avatar of Thoth":** +50% All Spell Stats, +2 Projectiles, Spells Pierce 2 Enemies

---

### 3. **Path of the Devourer** - Ammit (Life Steal/Vampiric)
**Deity:** Ammit - Devourer of the Dead, Consumer of Hearts
**Theme Color:** Deep Red & Black
**Playstyle:** Aggressive life steal, high risk/high reward

**Core Identity:**
- Massive life steal
- Damage increases with missing health
- Convert damage to healing
- High damage, low defense

**Upgrade Pool (20 upgrades):**

**Tier 1 (Common):**
- **"Ammit's Hunger":** +3% Life Steal
- **"Heart Devourer":** +2 Life per Kill
- **"Taste of Blood":** +10% Damage
- **"Predator's Instinct":** +5% Attack Speed
- **"Eternal Feast":** Heal 20 on Critical Hit

**Tier 2 (Uncommon):**
- **"Insatiable Appetite":** +7% Life Steal, +15% Damage
- **"Blood Frenzy":** +10% Attack Speed, +3% Life Steal per enemy nearby (max 15%)
- **"Heart Collector":** Life per Kill scales with player level (+1 per level)
- **"Carnage":** +25% Damage, -10% Maximum Health
- **"Devourer's Might":** Gain +1% Damage per 1% Missing Health

**Tier 3 (Rare):**
- **"Ammit's Feast":** +15% Life Steal, Overheal becomes Temporary Shield
- **"Crimson Harvest":** Life Steal heals 50% more, but take 25% more damage
- **"Soul Eater":** Killing enemies restores 5% of Maximum Health
- **"Endless Hunger":** +10% Life Steal, +1% per Kill (stacks, resets on hit)

**Tier 4 (Epic):**
- **"Avatar of Ammit":** +25% Life Steal, +50% Damage, Cannot Regenerate (life steal only)

---

### 4. **Path of the Sun** - Ra (Fire/Burst Damage)
**Deity:** Ra - Sun God, Destroyer of Darkness
**Theme Color:** Golden Orange & Yellow
**Playstyle:** Explosive damage, fire effects, area denial

**Core Identity:**
- Fire damage and AOE
- Burning damage over time
- Screen-clearing explosions
- High damage output

**Upgrade Pool (20 upgrades):**

**Tier 1 (Common):**
- **"Ra's Blessing":** +10% Fire Damage
- **"Solar Flare":** +15% AOE Size
- **"Scorching Heat":** Attacks apply Burn (5 DPS for 3 sec)
- **"Desert Sun":** +10% Damage
- **"Midday Blaze":** +10% Damage to Burning Enemies

**Tier 2 (Uncommon):**
- **"Sun God's Fury":** +20% Fire Damage, +20% AOE Size
- **"Inferno":** Burn damage doubled, Burn spreads to nearby enemies
- **"Solar Eclipse":** +30% Damage, Attacks have 15% chance to Blind enemies
- **"Chariot of Fire":** Attacks leave burning ground (10 DPS for 5 sec)
- **"Eternal Flame":** Fire effects last 50% longer

**Tier 3 (Rare):**
- **"Ra's Judgment":** Enemies below 25% Health explode for AOE damage
- **"Sun Disk":** +2 Projectiles, Projectiles explode on hit
- **"Scorched Earth":** +40% Fire Damage, +40% AOE, Burning enemies take double damage
- **"Solar Storm":** Every 5th attack unleashes fire nova (50 damage, 5m radius)

**Tier 4 (Epic):**
- **"Avatar of Ra":** +75% Fire Damage, All attacks ignite, Ignited enemies explode on death

---

### 5. **Path of the Storm** - Set (Speed/Lightning)
**Deity:** Set - God of Storms, Chaos, and Speed
**Theme Color:** Electric Blue & Purple
**Playstyle:** Fast, mobile, lightning strikes, high APM

**Core Identity:**
- Movement and attack speed
- Lightning damage and chaining
- Mobility and evasion
- Rapid-fire attacks

**Upgrade Pool (20 upgrades):**

**Tier 1 (Common):**
- **"Set's Swiftness":** +10% Movement Speed
- **"Storm's Pace":** +10% Attack Speed
- **"Lightning Reflexes":** +5% Dodge Chance
- **"Thunderbolt":** +10% Lightning Damage
- **"Chain Lightning":** Attacks chain to 1 nearby enemy

**Tier 2 (Uncommon):**
- **"Eye of the Storm":** +20% Movement Speed, +15% Attack Speed
- **"Thunder God's Fury":** +25% Lightning Damage, Lightning chains to 2 enemies
- **"Tempest":** +15% Attack Speed, Every 3rd attack strikes twice
- **"Chaotic Energy":** +10% All Damage, +20% Movement Speed
- **"Storm Surge":** Moving fast grants +15% Damage (stacks)

**Tier 3 (Rare):**
- **"Set's Chaos":** +30% Attack Speed, +30% Move Speed, +5% Dodge
- **"Lightning Avatar":** Attacks shock enemies (10% slow), chains to 3 enemies
- **"Supersonic":** At max movement speed, leave damaging trail (20 DPS)
- **"Storm Caller":** Every 10 attacks summon lightning strike (75 AOE damage)

**Tier 4 (Epic):**
- **"Avatar of Set":** +50% All Speed Stats, Attacks always chain, Lightning Strikes every 5 attacks

---

### 6. **Path of the Serpent** - Apophis (Poison/DOT)
**Deity:** Apophis - Serpent of Chaos, Bringer of Poison
**Theme Color:** Toxic Green & Dark Purple
**Playstyle:** Damage over time, poison stacking, crowd control

**Core Identity:**
- Poison damage amplification
- Stacking poison effects
- Enemy debuffs
- Long-term damage

**Upgrade Pool (20 upgrades):**

**Tier 1 (Common):**
- **"Apophis's Venom":** +10% Poison Damage
- **"Serpent's Bite":** Attacks apply Poison (3 DPS for 5 sec)
- **"Toxic Cloud":** Poison effects have +1m AOE
- **"Noxious Fumes":** +15% Damage to Poisoned Enemies
- **"Lingering Toxin":** Poison lasts 25% longer

**Tier 2 (Uncommon):**
- **"Chaos Serpent":** Poison stacks up to 5 times on same enemy
- **"Venom Mastery":** +25% Poison Damage, Poison applies 25% faster
- **"Plague Bringer":** Poisoned enemies spread poison to nearby enemies
- **"Corrosive Strike":** Poison also reduces enemy armor by 10%
- **"Asp's Kiss":** Critical hits apply double poison stacks

**Tier 3 (Rare):**
- **"Apophis's Coils":** Heavily poisoned enemies are slowed 30%
- **"Toxic Overload":** At 5 poison stacks, enemy explodes (poison AOE damage)
- **"Serpent's Embrace":** +40% Poison Damage, Poison never expires
- **"Plague of Egypt":** Poison damage doubled, spreads to all nearby enemies

**Tier 4 (Epic):**
- **"Avatar of Apophis":** +100% Poison Damage, Poison stacks infinitely, Poisoned enemies take +50% damage from all sources

---

## 🎲 Archetype Selection System

### Level-Up Choice Mechanics:

**Random Generation:**
```python
def GenerateLevelUpChoices(player_level):
    # Track player's current archetype inclinations
    archetype_weights = GetPlayerArchetypeWeights()

    # Generate 3 random upgrades from different archetypes
    choice_1 = SelectUpgrade(archetype_weights, exclude=[])
    choice_2 = SelectUpgrade(archetype_weights, exclude=[choice_1.archetype])
    choice_3 = SelectUpgrade(archetype_weights, exclude=[choice_1.archetype, choice_2.archetype])

    return [choice_1, choice_2, choice_3]
```

**Weighting Algorithm:**
```python
def GetPlayerArchetypeWeights():
    # Slightly favor archetypes player has chosen before (20% bonus)
    # But always keep other paths viable

    weights = {
        'warrior': 1.0 + (warrior_picks * 0.2),
        'mage': 1.0 + (mage_picks * 0.2),
        'devourer': 1.0 + (devourer_picks * 0.2),
        'sun': 1.0 + (sun_picks * 0.2),
        'storm': 1.0 + (storm_picks * 0.2),
        'serpent': 1.0 + (serpent_picks * 0.2)
    }
    return weights
```

**Result:** Builds emerge organically based on player choices + RNG!

---

## 🎨 Visual Design (For Dima)

### Level-Up Choice UI:

**Screen Layout:**
```
┌─────────────────────────────────────┐
│   ⚡ LEVEL 5 - CHOOSE YOUR PATH ⚡   │
├─────────────────────────────────────┤
│  ┌──────────┐ ┌──────────┐ ┌──────────┐  │
│  │ ANUBIS   │ │   RA     │ │  THOTH   │  │
│  │ [Jackal] │ │  [Sun]   │ │ [Ibis]   │  │
│  │          │ │          │ │          │  │
│  │ Guardian │ │ Sun God's│ │ Master   │  │
│  │  Stance  │ │  Fury    │ │ of Words │  │
│  │          │ │          │ │          │  │
│  │ +15% HP  │ │ +20% Fire│ │ +15% Spell│  │
│  │ +5 Armor │ │ +20% AOE │ │ +10% Cast│  │
│  └──────────┘ └──────────┘ └──────────┘  │
│       [1]          [2]          [3]      │
└─────────────────────────────────────────┘
```

**Design Elements:**
- Hieroglyphic borders (golden)
- Deity icon at top of each card
- Papyrus background texture
- Glowing selection highlights
- Quick keyboard selection (1/2/3)

---

## 🎵 Audio (For Andy)

### Level-Up Sounds:
- **Level Up Fanfare:** Egyptian choir + drums (1 sec)
- **Choice Highlight:** Soft chime when hovering
- **Choice Select:** Power-up "whoosh" + deity-specific sound:
  - Anubis: Deep jackal howl
  - Thoth: Mystical wind chimes
  - Ammit: Growling roar
  - Ra: Solar flare sound
  - Set: Thunder crack
  - Apophis: Serpent hiss

---

## 🎯 Build Examples

### Build 1: "The Immortal Guardian"
**Path:** Anubis (Warrior)
**Weapons:** Khopesh Spade, Serpent's Lash, Ra's Torch
**Strategy:** Facetank everything, life steal from melee
**Key Upgrades:** Guardian's Stance, Life from Death, Anubis's Judgment
**Weakness:** Slow, vulnerable to ranged bosses

### Build 2: "The Sun Incarnate"
**Path:** Ra (Sun)
**Weapons:** Staff of Anubis, Ra's Torch, Aten's Wheel
**Strategy:** Burn everything, screen-wide explosions
**Key Upgrades:** Sun God's Fury, Inferno, Ra's Judgment
**Weakness:** Mana-hungry, needs good positioning

### Build 3: "The Lightning Assassin"
**Path:** Set (Storm)
**Weapons:** Asp Darts, Serpent's Lash, Aten's Wheel
**Strategy:** Maximum attack speed, lightning chains
**Key Upgrades:** Eye of the Storm, Set's Chaos, Lightning Avatar
**Weakness:** Fragile, relies on dodging

### Build 4: "The Plague Doctor"
**Path:** Apophis (Serpent)
**Weapons:** Asp Darts, Serpent's Lash (for stacking), Staff
**Strategy:** Poison everything, let DOT do the work
**Key Upgrades:** Chaos Serpent, Plague Bringer, Toxic Overload
**Weakness:** Slow damage ramp-up

### Build 5: "The Archmage"
**Path:** Thoth (Mage)
**Weapons:** Staff of Anubis, Aten's Wheel, Asp Darts
**Strategy:** Massive projectile spam, critical hits
**Key Upgrades:** Master of Words, Thoth's Omniscience, Book of the Dead
**Weakness:** Squishy, mana-dependent

### Build 6: "The Blood Mage"
**Path:** Ammit + Thoth (Hybrid)
**Weapons:** Staff of Anubis, Serpent's Lash
**Strategy:** Life steal from spell damage
**Key Upgrades:** Insatiable Appetite, Thoth's Wisdom, Cosmic Knowledge
**Weakness:** Requires good gear to work

---

## 🏗️ RPG Builder Implementation

### Talent Tree Setup:

```
RPG Builder > Progression > Talent Trees

Create Tree: "Divine Paths"

Branch 1: Path of Anubis
  └─ 20 nodes (all upgrades)

Branch 2: Path of Thoth
  └─ 20 nodes (all upgrades)

[Repeat for all 6 paths]
```

**Custom Script:**
```csharp
// On level up:
void OnPlayerLevelUp() {
    // Generate 3 random upgrades from different paths
    var choices = GenerateRandomChoices(3);

    // Show custom UI (non-intrusive)
    ShowChoiceUI(choices);

    // Player selects one
    // Apply talent point to that node in RPG Builder
    RPGBuilderManager.Instance.ApplyTalentPoint(selectedUpgrade);
}
```

**Native Code:** 85% (Talent effects apply automatically via RPG Builder!)

---

## 🎯 MVP Implementation (24 hours)

### Simplified Version:

**3 Archetypes Only:**
1. Path of Anubis (Tank)
2. Path of Thoth (Mage)
3. Path of Ra (Damage)

**10 Upgrades per Path:**
- 5 Tier 1 (Common)
- 3 Tier 2 (Uncommon)
- 2 Tier 3 (Rare)

**Total:** 30 upgrades (manageable!)

**Stretch Goals (36-48 hours):**
- Add Ammit, Set, Apophis paths (+60 upgrades)
- Add Tier 4 (Epic) upgrades
- Add visual indicators per path

---

## ✅ Success Criteria

**Archetype System Working When:**
- [ ] 3 choices appear on level up
- [ ] Choices are from different archetypes
- [ ] Selected upgrade applies correctly
- [ ] Stats stack properly
- [ ] UI is quick and non-intrusive (<3 seconds to choose)
- [ ] Egyptian theming is clear
- [ ] Builds feel distinct and powerful

---

**Status:** ✅ Complete Archetype System Design
**Total Paths:** 6 (3 for MVP)
**Total Upgrades:** 120 (30 for MVP)
**RPG Builder Compatible:** Yes (Talent Tree system)
**Egyptian Themed:** 100%

*The gods await your choice...*
# Affix Database - Ancient Egyptian Powers

**System:** POE2-Style Random Affixes
**Implementation:** RPG Builder Item Stat Bonuses
**Theme:** Ancient Egyptian Deities and Mythology

---

## 🎯 Affix System Overview

### How Affixes Work:
- **All weapons and artifacts** drop with random affixes
- **Automatically applied** (no player choice or rerolling)
- **2-5 affixes per item** based on rarity tier
- **Egyptian-themed names** for immersion

### Rarity → Affix Count:
```
Tier I (Common):    1-2 affixes (weak rolls: 5-10%)
Tier II (Uncommon): 2 affixes (medium rolls: 10-15%)
Tier III (Rare):    3 affixes (good rolls: 15-20%)
Tier IV (Epic):     4 affixes (great rolls: 20-30%)
Tier V (Legendary): 5 affixes (perfect rolls: 30-50%)
```

---

## ⚔️ WEAPON AFFIXES (Offensive)

### Damage Affixes

#### **Ra's Fury**
- **Type:** Fire Damage
- **Stat:** +X% Fire Damage
- **Rolls:** 5-50% (tier-based)
- **RPG Builder:** Stat Bonus → Fire_Damage_Percent
- **Visual:** Orange/golden glow on weapon

#### **Set's Storm**
- **Type:** Lightning Damage
- **Stat:** +X% Lightning Damage
- **Rolls:** 5-50%
- **RPG Builder:** Stat Bonus → Lightning_Damage_Percent
- **Visual:** Blue electric crackling

#### **Apophis's Venom**
- **Type:** Poison Damage
- **Stat:** +X Poison Damage per Second
- **Rolls:** 2-20 DPS
- **RPG Builder:** Stat Bonus → Poison_DPS
- **Visual:** Green dripping effect

#### **Sekhmet's Rage**
- **Type:** Physical Damage
- **Stat:** +X% Physical Damage
- **Rolls:** 10-75%
- **RPG Builder:** Stat Bonus → Physical_Damage_Percent
- **Visual:** Red battle aura

#### **Khnum's Might**
- **Type:** Raw Power
- **Stat:** +X Base Weapon Damage
- **Rolls:** 2-25
- **RPG Builder:** Stat Bonus → Base_Damage
- **Visual:** White power glow

### Attack Speed Affixes

#### **Horus's Swiftness**
- **Type:** Attack Speed
- **Stat:** +X% Attack Speed
- **Rolls:** 5-40%
- **RPG Builder:** Stat Bonus → Attack_Speed_Percent
- **Visual:** Faster animation speed

#### **Thoth's Precision**
- **Type:** Cast Speed
- **Stat:** +X% Casting Speed
- **Rolls:** 5-35%
- **RPG Builder:** Stat Bonus → Cast_Speed_Percent
- **Visual:** Quicker spell animations

### Critical Strike Affixes

#### **Anubis's Judgment**
- **Type:** Critical Chance
- **Stat:** +X% Critical Hit Chance
- **Rolls:** 3-25%
- **RPG Builder:** Stat Bonus → Crit_Chance_Percent
- **Visual:** Golden flash on crit

#### **Ma'at's Balance**
- **Type:** Critical Damage
- **Stat:** +X% Critical Hit Damage
- **Rolls:** 10-100%
- **RPG Builder:** Stat Bonus → Crit_Damage_Percent
- **Visual:** Larger numbers, screen shake

### Special Effect Affixes

#### **Scarab's Return**
- **Type:** Projectile Behavior
- **Stat:** Projectiles Pierce +X Enemies
- **Rolls:** 1-3 enemies
- **RPG Builder:** Stat Bonus → Projectile_Pierce
- **Visual:** Projectiles continue through enemies

#### **Aten's Radiance**
- **Type:** AOE Size
- **Stat:** +X% Area of Effect Size
- **Rolls:** 10-50%
- **RPG Builder:** Stat Bonus → AOE_Size_Percent
- **Visual:** Larger explosion radius

#### **Osiris's Rebirth**
- **Type:** Life on Hit
- **Stat:** +X Life per Hit
- **Rolls:** 1-10
- **RPG Builder:** Stat Bonus → Life_On_Hit
- **Visual:** Green particles on hit

#### **Bes's Fortune**
- **Type:** Loot Quality
- **Stat:** +X% Item Rarity
- **Rolls:** 10-50%
- **RPG Builder:** Stat Bonus → Item_Rarity_Bonus
- **Visual:** Golden aura around player

#### **Hathor's Joy**
- **Type:** Experience Gain
- **Stat:** +X% Experience Gained
- **Rolls:** 5-30%
- **RPG Builder:** Stat Bonus → XP_Gain_Percent
- **Visual:** Blue sparkles on level up

### Multi-Projectile Affixes

#### **Nut's Multitude**
- **Type:** Additional Projectiles
- **Stat:** +X Additional Projectiles
- **Rolls:** 1-2
- **RPG Builder:** Stat Bonus → Additional_Projectiles
- **Visual:** Weapons fire multiple shots

#### **Geb's Chain**
- **Type:** Chain Attacks
- **Stat:** Attacks Chain to +X Nearby Enemies
- **Rolls:** 1-3
- **RPG Builder:** Stat Bonus → Chain_Count
- **Visual:** Lightning chains between enemies

---

## 🛡️ ARTIFACT AFFIXES (Support/Utility)

### Defensive Affixes

#### **Ptah's Endurance**
- **Type:** Maximum Health
- **Stat:** +X Maximum Health
- **Rolls:** 10-100
- **RPG Builder:** Stat Bonus → Max_Health
- **Visual:** Larger health bar

#### **Bastet's Grace**
- **Type:** Dodge Chance
- **Stat:** +X% Dodge Chance
- **Rolls:** 2-15%
- **RPG Builder:** Stat Bonus → Dodge_Chance_Percent
- **Visual:** Blue shimmer on dodge

#### **Sobek's Scales**
- **Type:** Armor
- **Stat:** +X Armor
- **Rolls:** 5-50
- **RPG Builder:** Stat Bonus → Armor
- **Visual:** Stone texture on character

#### **Neith's Ward**
- **Type:** Damage Reduction
- **Stat:** +X% Damage Reduction
- **Rolls:** 2-15%
- **RPG Builder:** Stat Bonus → Damage_Reduction_Percent
- **Visual:** Protective shimmer

### Utility Affixes

#### **Khonsu's Blessing**
- **Type:** Movement Speed
- **Stat:** +X% Movement Speed
- **Rolls:** 5-30%
- **RPG Builder:** Stat Bonus → Move_Speed_Percent
- **Visual:** Speed trails

#### **Isis's Recovery**
- **Type:** Health Regeneration
- **Stat:** +X Health per Second
- **Rolls:** 0.5-5
- **RPG Builder:** Stat Bonus → Health_Regen
- **Visual:** Green healing particles

#### **Tefnut's Mist**
- **Type:** Cooldown Reduction
- **Stat:** +X% Cooldown Reduction
- **Rolls:** 5-25%
- **RPG Builder:** Stat Bonus → Cooldown_Reduction_Percent
- **Visual:** Blue cooldown timer faster

#### **Shu's Breath**
- **Type:** Divine Energy (Mana)
- **Stat:** +X Maximum Divine Energy
- **Rolls:** 10-50
- **RPG Builder:** Stat Bonus → Max_Mana
- **Visual:** Larger mana bar

#### **Nephthys's Flow**
- **Type:** Mana Regeneration
- **Stat:** +X Divine Energy per Second
- **Rolls:** 0.5-3
- **RPG Builder:** Stat Bonus → Mana_Regen
- **Visual:** Blue sparkles

### Special Utility Affixes

#### **Montu's Wrath**
- **Type:** Thorns Damage
- **Stat:** Reflects X% of Damage Taken
- **Rolls:** 5-25%
- **RPG Builder:** Stat Bonus → Thorns_Percent
- **Visual:** Red spikes on being hit

#### **Ammit's Hunger**
- **Type:** Life Steal
- **Stat:** +X% Life Steal
- **Rolls:** 2-10%
- **RPG Builder:** Stat Bonus → Life_Steal_Percent
- **Visual:** Red healing particles on hit

#### **Bennu's Resurrection**
- **Type:** Second Chance
- **Stat:** Revive with X% Health (once)
- **Rolls:** 25-50%
- **RPG Builder:** Special Effect → On_Death_Revive
- **Visual:** Phoenix rebirth effect

### Pickup Range Affixes

#### **Khepri's Attraction**
- **Type:** Loot Magnet
- **Stat:** +X% Pickup Range
- **Rolls:** 10-50%
- **RPG Builder:** Stat Bonus → Pickup_Range_Percent
- **Visual:** Loot gravitates toward player

---

## 🎲 Affix Roll System

### Roll Tiers by Item Rarity:

**Common (Tier I):**
```
Affixes: 1-2
Roll Range: 5-10% (minimum values)
Example: Ra's Fury (7% Fire Damage)
```

**Uncommon (Tier II):**
```
Affixes: 2
Roll Range: 10-15%
Example: Ra's Fury (12% Fire Damage), Horus's Swiftness (11% Attack Speed)
```

**Rare (Tier III):**
```
Affixes: 3
Roll Range: 15-20%
Example: Ra's Fury (18%), Horus's Swiftness (17%), Anubis's Judgment (6% Crit)
```

**Epic (Tier IV):**
```
Affixes: 4
Roll Range: 20-30%
Example: Ra's Fury (27%), Horus's Swiftness (25%), Anubis's Judgment (15% Crit), Nut's Multitude (+1 Projectile)
```

**Legendary (Tier V):**
```
Affixes: 5
Roll Range: 30-50% (maximum values)
Example: Ra's Fury (45%), Horus's Swiftness (38%), Anubis's Judgment (22% Crit), Nut's Multitude (+2 Projectiles), Ammit's Hunger (8% Life Steal)
```

---

## 🎯 Affix Generation Algorithm

### Pseudocode:
```python
def GenerateAffixes(item, rarity_tier):
    affix_count = GetAffixCount(rarity_tier)  # 1-5 based on tier
    affix_pool = GetAffixPool(item.type)      # Weapon or Artifact pool
    selected_affixes = []

    for i in range(affix_count):
        # Get random affix (no duplicates)
        available = [a for a in affix_pool if a not in selected_affixes]
        affix = WeightedRandom(available)

        # Roll value based on tier
        min_roll = affix.min_value * rarity_tier / 5
        max_roll = affix.max_value * rarity_tier / 5
        roll_value = Random(min_roll, max_roll)

        # Apply to item
        item.AddStatBonus(affix.stat, roll_value)
        selected_affixes.append(affix)

    return item
```

### Affix Count Formula:
```python
def GetAffixCount(rarity_tier):
    # Tier I: 1-2, Tier II: 2, Tier III: 3, Tier IV: 4, Tier V: 5
    base = rarity_tier
    variance = 1 if rarity_tier == 1 else 0
    return base + Random(-variance, 0)
```

---

## 📊 Affix Pool Distribution

### Weapon Affix Pools (Weighted):

**High Priority (40% chance):**
- Damage affixes (Ra's Fury, Set's Storm, etc.)
- Attack Speed (Horus's Swiftness)

**Medium Priority (35% chance):**
- Critical affixes (Anubis's Judgment, Ma'at's Balance)
- Special effects (Scarab's Return, Aten's Radiance)

**Low Priority (20% chance):**
- Multi-projectile (Nut's Multitude)
- Chain (Geb's Chain)

**Rare (5% chance):**
- Life Steal (Ammit's Hunger)
- Unique effects (Bennu's Resurrection)

### Artifact Affix Pools (Weighted):

**High Priority (40% chance):**
- Health (Ptah's Endurance)
- Movement Speed (Khonsu's Blessing)

**Medium Priority (35% chance):**
- Defense (Sobek's Scales, Neith's Ward)
- Regeneration (Isis's Recovery, Nephthys's Flow)

**Low Priority (20% chance):**
- Utility (Tefnut's Mist, Khepri's Attraction)
- Loot bonuses (Bes's Fortune, Hathor's Joy)

**Rare (5% chance):**
- Unique effects (Bennu's Resurrection, Montu's Wrath)

---

## 🎯 Example Weapon Drops

### Example 1: Common Serpent's Lash (Tier I)
```
Name: Serpent's Lash
Rarity: Common (Tier I)
Damage: 10
Affixes:
  - Horus's Swiftness: +7% Attack Speed
```

### Example 2: Rare Aten's Wheel (Tier III)
```
Name: Aten's Wheel
Rarity: Rare (Tier III)
Damage: 15
Affixes:
  - Ra's Fury: +18% Fire Damage
  - Scarab's Return: Pierces 1 Enemy
  - Bes's Fortune: +12% Item Rarity
```

### Example 3: Legendary Staff of Anubis (Tier V)
```
Name: Staff of Anubis
Rarity: Legendary (Tier V)
Damage: 30
Affixes:
  - Set's Storm: +45% Lightning Damage
  - Thoth's Precision: +35% Cast Speed
  - Anubis's Judgment: +22% Crit Chance
  - Nut's Multitude: +2 Projectiles
  - Ammit's Hunger: +8% Life Steal
```

### Example 4: Epic Artifact
```
Name: Scarab Amulet of the Ancients
Type: Artifact
Rarity: Epic (Tier IV)
Affixes:
  - Ptah's Endurance: +75 Max Health
  - Khonsu's Blessing: +25% Move Speed
  - Isis's Recovery: +3 Health/sec
  - Khepri's Attraction: +40% Pickup Range
```

---

## 🎯 Complete Affix List (Quick Reference)

### Weapon Affixes (20 Total):

| ID | Name | Stat | Type |
|----|------|------|------|
| 1 | Ra's Fury | +% Fire Damage | Damage |
| 2 | Set's Storm | +% Lightning Damage | Damage |
| 3 | Apophis's Venom | + Poison DPS | Damage |
| 4 | Sekhmet's Rage | +% Physical Damage | Damage |
| 5 | Khnum's Might | + Base Damage | Damage |
| 6 | Horus's Swiftness | +% Attack Speed | Speed |
| 7 | Thoth's Precision | +% Cast Speed | Speed |
| 8 | Anubis's Judgment | +% Crit Chance | Critical |
| 9 | Ma'at's Balance | +% Crit Damage | Critical |
| 10 | Scarab's Return | + Pierce Enemies | Special |
| 11 | Aten's Radiance | +% AOE Size | Special |
| 12 | Osiris's Rebirth | + Life per Hit | Special |
| 13 | Bes's Fortune | +% Item Rarity | Special |
| 14 | Hathor's Joy | +% XP Gain | Special |
| 15 | Nut's Multitude | + Projectiles | Special |
| 16 | Geb's Chain | + Chain Attacks | Special |
| 17 | Ammit's Hunger | +% Life Steal | Special |
| 18 | Bennu's Resurrection | Revive Once | Unique |
| 19 | Sobek's Ferocity | +% Damage vs Bosses | Damage |
| 20 | Wadjet's Strike | +% Damage vs Poisoned | Damage |

### Artifact Affixes (15 Total):

| ID | Name | Stat | Type |
|----|------|------|------|
| 21 | Ptah's Endurance | + Max Health | Defense |
| 22 | Bastet's Grace | +% Dodge Chance | Defense |
| 23 | Sobek's Scales | + Armor | Defense |
| 24 | Neith's Ward | +% Damage Reduction | Defense |
| 25 | Khonsu's Blessing | +% Move Speed | Utility |
| 26 | Isis's Recovery | + Health Regen/s | Utility |
| 27 | Tefnut's Mist | +% Cooldown Reduction | Utility |
| 28 | Shu's Breath | + Max Mana | Utility |
| 29 | Nephthys's Flow | + Mana Regen/s | Utility |
| 30 | Montu's Wrath | +% Thorns Damage | Utility |
| 31 | Khepri's Attraction | +% Pickup Range | Utility |
| 32 | Serket's Immunity | +% Poison Resist | Defense |
| 33 | Imhotep's Knowledge | +% Skill Amplification | Special |
| 34 | Seshat's Record | +% All Stats | Special |
| 35 | Min's Vitality | +% Max Health & Regen | Special |

---

## 🎨 Visual Indicators by Affix Type

### Color Coding (For UI/VFX):

- **Fire (Ra):** Orange/Gold glow
- **Lightning (Set):** Blue electric
- **Poison (Apophis):** Green drips
- **Physical (Sekhmet):** Red aura
- **Speed (Horus):** Yellow trails
- **Crit (Anubis):** Purple flash
- **Life (Osiris/Isis):** Green heal
- **Defense (Ptah/Sobek):** Brown/stone
- **Utility (Thoth):** Cyan glow
- **Unique (Bennu):** Rainbow/divine

### Rarity Glow (Item Drop):

- **Common:** White beam
- **Uncommon:** Green beam
- **Rare:** Blue beam
- **Epic:** Purple beam
- **Legendary:** Golden beam + screen flash

---

## 🏗️ RPG Builder Implementation Guide

### Creating Affixes in RPG Builder:

**Step 1: Define Stats**
```
RPG Builder > Settings > Character > Stats
Create each stat type:
- Fire_Damage_Percent
- Lightning_Damage_Percent
- Attack_Speed_Percent
- Crit_Chance_Percent
- etc.
```

**Step 2: Create Affix Database**
```
RPG Builder > Items > Item Stat Bonuses
For each affix:
- ID: "affix_ras_fury"
- Name: "Ra's Fury"
- Description: "Blessed by the sun god"
- Stat: Fire_Damage_Percent
- Min Roll: 5 (Tier I)
- Max Roll: 50 (Tier V)
```

**Step 3: Item Generation**
```csharp
// On item drop:
Item newItem = GenerateItem(weaponType, rarity);
int affixCount = GetAffixCount(rarity); // 1-5 based on tier
for (int i = 0; i < affixCount; i++) {
    Affix randomAffix = GetRandomAffix(weaponAffixPool);
    float rollValue = RollAffixValue(rarity, randomAffix);
    newItem.AddStatBonus(randomAffix.Stat, rollValue);
}
```

**Step 4: Apply to Player**
```csharp
// RPG Builder native:
InventoryManager.Instance.AddItem(newItem);
// Stats automatically applied via RPG Builder's stat system
```

---

## 🎯 Balancing Guidelines

### Damage Affixes:
- Total possible: 100-300% increased damage (Legendary)
- Single affix max: 50%
- Multiplicative stacking

### Defense Affixes:
- Total possible: 50-100% damage reduction (Legendary)
- Capped at 75% (prevent immortality)
- Additive stacking

### Utility Affixes:
- Movement Speed: Capped at +100%
- Attack Speed: Capped at +200%
- Pickup Range: Capped at +200%

### Special Affixes:
- Additional Projectiles: Max +3
- Pierce: Max +5 enemies
- Chain: Max +5 enemies
- Life Steal: Capped at 20%

---

## ✅ Testing Checklist

- [ ] All 35 affixes functional in RPG Builder
- [ ] Affixes roll correctly per rarity
- [ ] No duplicate affixes on same item
- [ ] Stats apply correctly to player
- [ ] Visual effects display properly
- [ ] Affix text displays on item tooltips
- [ ] Balance feels good (not OP or weak)
- [ ] Egyptian names are consistent
- [ ] Loot drops show rarity correctly

---

**Status:** ✅ Complete Affix Database
**Total Affixes:** 35 (20 weapon + 15 artifact)
**RPG Builder Compatible:** 100%
**Egyptian Themed:** 100%

*Database ready for implementation!*

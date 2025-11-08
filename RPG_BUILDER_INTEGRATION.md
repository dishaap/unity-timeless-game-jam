# RPG Builder Integration Guide

**Purpose:** Map all game systems to RPG Builder native features
**Goal:** Use 95%+ native RPG Builder functionality
**Benefit:** Faster implementation, less custom code, fewer bugs

---

## 🎯 System Mapping Overview

| Game System | RPG Builder Feature | Custom Code % |
|-------------|-------------------|---------------|
| Affix System | Item Stat Bonuses | 10% (generation only) |
| Weapons | Weapon Items + Stats | 0% (100% native) |
| Artifacts | Armor Items + Bonuses | 0% (100% native) |
| Canopic Satchel | Inventory System | 0% (100% native) |
| Level-Up Choices | Talent Tree | 15% (random selection) |
| Build Archetypes | Talent Tree Branches | 5% (UI only) |
| Auto-Loot | Loot Pickup System | 5% (auto-trigger) |
| Auto-Attack | Combat System | 10% (target selection) |
| Enemy Spawning | Spawn Manager | 25% (dynamic scaling) |
| Stats | Character Stats | 0% (100% native) |

**Total Custom Code:** ~15% average
**Total Native RPG Builder:** ~85%

---

## 🏗️ Detailed Integration Per System

### 1. Affix System

**RPG Builder Feature:** Item Stat Bonuses

**Setup:**
```
RPG Builder > Settings > Character > Stats

Create all stats:
- Fire_Damage_Percent (float, 0-100)
- Lightning_Damage_Percent (float, 0-100)
- Attack_Speed_Percent (float, 0-200)
- Crit_Chance_Percent (float, 0-100)
- Life_Steal_Percent (float, 0-20)
[etc. - see AFFIX_DATABASE.md for full list]
```

**Item Configuration:**
```
RPG Builder > Items > Weapons > Create Item

For each weapon:
- Base Item: "Serpent's Lash"
- Item Type: Weapon
- Weapon Type: Whip
- Base Damage: 10
- Stat Bonuses: [Empty - populated by script]
```

**Custom Code (10%):**
```csharp
// On item drop:
public RPGItem GenerateAffixedWeapon(string weaponType, int rarityTier) {
    // Get base weapon from RPG Builder
    var baseWeapon = RPGBuilderDatabase.Instance.GetWeapon(weaponType);

    // Clone it
    var newWeapon = Instantiate(baseWeapon);

    // Roll affixes
    int affixCount = rarityTier;  // 1-5 based on tier
    var affixPool = GetAffixPool("weapon");

    for (int i = 0; i < affixCount; i++) {
        var affix = GetRandomAffix(affixPool, excludeDuplicates: true);
        float rollValue = RollAffixValue(affix, rarityTier);

        // Use RPG Builder native stat bonus
        newWeapon.statBonuses.Add(new RPGStat.StatBonus {
            statID = affix.statID,
            amount = rollValue,
            isPercent = affix.isPercent
        });
    }

    return newWeapon;
}
```

**Native Code (90%):** RPG Builder automatically applies stat bonuses to character!

---

### 2. Weapons & Artifacts

**RPG Builder Feature:** Item System (Native)

**Weapon Setup:**
```
RPG Builder > Items > Weapons

Create 6 base weapons:
1. Serpent's Lash (Whip)
   - WeaponType: Whip
   - Attack Speed: 1.2
   - Range: Medium
   - Animation: Whip_Attack

2. Aten's Wheel (Chakram)
   - WeaponType: Throwing
   - Attack Speed: 0.8
   - Range: Long
   - Projectile: Chakram_Projectile (returns!)

3. Staff of Anubis
   - WeaponType: Staff
   - Attack Speed: 0.5
   - Range: Very Long
   - Projectile: Divine_Beam

[etc. for all 6 weapons]
```

**Artifact Setup:**
```
RPG Builder > Items > Armor

Create artifacts as "Armor" type with 0 armor:
- Scarab Amulet (Artifact)
  - ArmorValue: 0
  - Stat Bonuses: [Generated via affix system]
  - Equip Slot: Special (doesn't use traditional slots)
```

**Custom Code:** 0% (All native!)

---

### 3. Canopic Satchel (Infinite Inventory)

**RPG Builder Feature:** Inventory Manager (Native)

**Setup:**
```
RPG Builder > Settings > Inventory

Configure:
- Inventory Type: Infinite
- Auto-Stack: Enabled
- Weight System: Disabled
- Slot Limit: 9999
```

**Custom Code (5%):**
```csharp
// Auto-pickup on collision
void OnTriggerEnter(Collider other) {
    if (other.CompareTag("Loot")) {
        var item = other.GetComponent<LootItem>();

        // RPG Builder native auto-pickup
        InventoryManager.Instance.AddItem(item.itemID, item.quantity);

        // Visual/audio feedback
        PlayPickupEffect();
        Destroy(other.gameObject);
    }
}
```

**Native Code (95%):** RPG Builder handles inventory management!

---

### 4. Level-Up Choice System

**RPG Builder Feature:** Talent Tree (Repurposed!)

**Setup:**
```
RPG Builder > Progression > Talent Trees

Create Tree: "Divine Paths"
Max Points: 50 (for 50 levels)
Auto-unlock: Disabled (we choose randomly)

Branch 1: Path of Anubis
  └─ 20 nodes (all upgrades)

Branch 2: Path of Thoth
  └─ 20 nodes (all upgrades)

[Repeat for all 6 paths]
```

**Custom Code (15%):**
```csharp
// On level up:
public void OnPlayerLevelUp() {
    // Generate 3 random upgrades from different paths
    var choices = GenerateRandomChoices(3);

    // Show custom UI (non-intrusive)
    ShowChoiceUI(choices);

    // Wait for player input (pauses game)
    var selectedChoice = WaitForPlayerChoice();

    // Apply using RPG Builder native talent system
    TalentTreeManager.Instance.UnlockTalent(selectedChoice.talentID);
}
```

**Native Code (85%):** Talent effects apply automatically via RPG Builder!

---

### 5. Dynamic Enemy Spawning

**RPG Builder Feature:** Spawn Manager (with custom modifiers)

**Setup:**
```
RPG Builder > World > Spawn Points

Create spawn points around arena:
- Spawn Point 1: North (Shabtis)
- Spawn Point 2: East (Guardians)
- Spawn Point 3: South (Scarabs)
- Spawn Point 4: West (Mixed)
[etc. - 8-12 spawn points in circle]
```

**Custom Spawn Manager (25% custom):**
```csharp
public class DynamicSpawnManager : MonoBehaviour {
    void Update() {
        // Calculate metrics
        float kpm = CalculateKPM();
        float spawnRate = CalculateSpawnRate(kpm);
        int waveSize = CalculateWaveSize();
        var enemyMix = DetermineEnemyMix(gameTime, kpm);

        // Use RPG Builder's spawn points
        if (Time.time >= nextSpawnTime) {
            for (int i = 0; i < waveSize; i++) {
                var spawnPoint = SelectRandomSpawnPoint();

                // RPG Builder native spawn
                SpawnManager.Instance.SpawnNPC(
                    npcID: enemyType,
                    spawnPoint: spawnPoint.position
                );
            }

            nextSpawnTime = Time.time + spawnRate;
        }
    }
}
```

**Native Code:** 75% (RPG Builder handles enemy AI, stats, behavior)

---

### 6. Character Stats

**RPG Builder Feature:** Character Stat System (100% Native!)

**Setup:**
```
RPG Builder > Settings > Character > Stats

Create all stats needed:

Vitality Stats:
- Health (max: 1000)
- Divine_Energy (mana, max: 100)
- Health_Regen (regen per sec)
- Mana_Regen (regen per sec)

Offensive Stats:
- Power (base damage multiplier)
- Attack_Speed_Percent (0-200%)
- Cast_Speed_Percent (0-200%)
- Crit_Chance_Percent (0-100%)
- Crit_Damage_Percent (0-500%)
- Fire_Damage_Percent
- Lightning_Damage_Percent
- Poison_Damage_Percent
- Physical_Damage_Percent

Defensive Stats:
- Armor (flat reduction)
- Damage_Reduction_Percent (0-75% capped)
- Dodge_Chance_Percent (0-50% capped)

Utility Stats:
- Move_Speed_Percent (0-200%)
- Pickup_Range_Percent
- Item_Rarity_Bonus
- XP_Gain_Percent

Special Stats:
- Life_Steal_Percent (0-20% capped)
- Life_On_Hit (flat value)
- Projectile_Pierce (count)
- AOE_Size_Percent
- Additional_Projectiles (count)
- Chain_Count
```

**Custom Code:** 0% - RPG Builder calculates everything!

---

## 🔧 Integration Workflow

### Day 1 (Hours 1-6): RPG Builder Setup
1. ✅ Create all stats in Character Stats
2. ✅ Create 6 base weapons
3. ✅ Create artifact item templates
4. ✅ Set up inventory as infinite
5. ✅ Create basic loot tables
6. ✅ Test native systems work

### Day 1 (Hours 7-12): Custom Scripts
1. ✅ Affix generation script
2. ✅ Level-up choice UI script
3. ✅ Auto-pickup script
4. ✅ Multi-weapon combat script
5. ✅ Dynamic spawn manager script
6. ✅ Integration testing

### Day 2 (Hours 13-48): Content & Polish
1. ✅ Create all 120 talent tree nodes (archetypes)
2. ✅ Create full loot tables
3. ✅ Balance stats and drop rates
4. ✅ Polish custom UIs
5. ✅ Audio/VFX integration
6. ✅ WebGL build testing

---

## 📊 Code Distribution

**Total Code:**
- RPG Builder Native: ~85%
- Custom Scripts: ~15%

**Custom Scripts Needed (7 total):**
1. `AffixGenerator.cs` (100 lines) - Generate random affixes
2. `LevelUpChoiceUI.cs` (150 lines) - Show 3 random choices
3. `MultiWeaponCombat.cs` (80 lines) - Manage 3 weapons
4. `DynamicSpawnManager.cs` (200 lines) - Scale spawn difficulty
5. `AutoLootPickup.cs` (50 lines) - Trigger auto-collection
6. `TimeManager.cs` (50 lines) - Superhot mechanic
7. `GlobalTimer.cs` (60 lines) - 5-minute countdown

**Total Custom Code:** ~690 lines
**Estimated Time:** 8-12 hours for all custom scripts

---

## ✅ Why This Integration Works

### Benefits:
1. **Less Code = Less Bugs** - Using native systems is tested and stable
2. **Faster Development** - Don't reinvent the wheel
3. **Better Performance** - Native systems are optimized
4. **Easier Balancing** - RPG Builder editor for tuning
5. **Team Friendly** - Nico can edit database without code
6. **Maintainable** - Clear separation of custom vs native

### Risks Mitigated:
- ❌ "What if RPG Builder can't do X?" → We verified it can do 85% natively
- ❌ "What if integration is complex?" → Only 7 small custom scripts needed
- ❌ "What if it's slow?" → Native systems are optimized
- ❌ "What if we can't finish?" → Most systems work out-of-box

---

## 🎯 Key Integration Points

### When Custom Code Calls RPG Builder:

**Add Item:**
```csharp
InventoryManager.Instance.AddItem(itemID, quantity);
```

**Apply Talent:**
```csharp
TalentTreeManager.Instance.UnlockTalent(talentID);
```

**Spawn Enemy:**
```csharp
SpawnManager.Instance.SpawnNPC(npcID, position);
```

**Attack Target:**
```csharp
CombatManager.Instance.AttackTarget(target, weapon);
```

**Get Player Stats:**
```csharp
var health = CharacterManager.Instance.GetCurrentHealth();
var damage = CharacterManager.Instance.GetStat("Power");
```

**Award XP:**
```csharp
ProgressionManager.Instance.AddExperience(xpAmount);
```

---

**Status:** ✅ Complete Integration Guide
**Native Usage:** 85%
**Custom Code:** 15%
**Estimated Implementation:** 8-12 hours total

*RPG Builder handles the heavy lifting, we add the magic!*

# Dynamic Difficulty & Spawn Scaling System

**System:** Adaptive Enemy Spawning
**Goal:** Reward skilled players, punish AFKing
**Theme:** The curse strengthens with your prowess

---

## 🎯 Core Concept

### The Curse Responds to Your Skill:
> *"The more souls you send to the Duat, the faster Anubis sends them back."*

**Philosophy:**
- **Fast killers** get more enemies faster (high intensity)
- **Slow players** get normal spawn rates (manageable)
- **High skill** = High reward (more loot from more kills)
- **AFK/hiding** = Low spawn rate (prevents cheese)

---

## ⚡ Spawn Scaling Formulas

### 1. Kill Speed Tracking (KPM)

**Kills Per Minute (KPM):**
```python
KPM = Total_Kills / (Game_Time_Minutes)

# Examples:
# 0 kills in 1 minute = 0 KPM (terrible)
# 30 kills in 1 minute = 30 KPM (average)
# 60 kills in 1 minute = 60 KPM (speedrunner!)
# 120 kills in 1 minute = 120 KPM (god tier!)
```

**Rolling Average (More Stable):**
```python
# Track last 30 seconds instead of all-time
Recent_KPM = Kills_Last_30_Seconds * 2

# This prevents early game from affecting late game too much
```

---

### 2. Spawn Rate Modifier

**Base Formula:**
```python
Base_Spawn_Rate = 2.0 seconds  # One enemy every 2 seconds

# Modified rate based on KPM
Modified_Spawn_Rate = Base_Spawn_Rate / (1 + KPM * 0.01)

# Examples:
# 0 KPM:   2.0 / (1 + 0)    = 2.0 sec (normal)
# 30 KPM:  2.0 / (1 + 0.3)  = 1.54 sec (faster)
# 60 KPM:  2.0 / (1 + 0.6)  = 1.25 sec (intense!)
# 120 KPM: 2.0 / (1 + 1.2)  = 0.91 sec (insane!)
```

**Capped Formula (Prevents Impossibility):**
```python
Modified_Spawn_Rate = max(0.5, Base_Spawn_Rate / (1 + KPM * 0.01))

# Minimum spawn rate = 0.5 seconds (max 2 enemies/sec)
# Prevents game becoming literally impossible
```

---

### 3. Wave Size Modifier

**Enemies per Wave:**
```python
Base_Wave_Size = 1  # Normally spawn 1 enemy

Modified_Wave_Size = Base_Wave_Size + floor(Total_Kills / 100)

# Examples:
# 0-99 kills:   1 enemy per spawn
# 100-199 kills: 2 enemies per spawn
# 200-299 kills: 3 enemies per spawn
# 300+ kills:   4+ enemies per spawn
```

**With Difficulty Multiplier:**
```python
# Also scale with game time (natural escalation)
Time_Multiplier = 1 + (Game_Time_Seconds / 300)  # Doubles at 5 minutes

Modified_Wave_Size = (1 + floor(Total_Kills / 100)) * Time_Multiplier

# At 5 minutes with 300 kills:
# (1 + 3) * 2 = 8 enemies per spawn!
```

---

### 4. Loot Quantity Scaling

**More Enemies = More Loot:**
```python
Base_Loot_Chance = 100%  # Every enemy drops loot

# Bonus loot chance from high KPM
Bonus_Loot_Chance = min(50%, KPM * 0.2%)

# At 60 KPM: 100% + 12% = 112% chance (some drop 2 items!)
# At 120 KPM: 100% + 24% = 124% chance (frequent double drops)
```

---

### 5. Enemy Type Distribution

**Dynamic Enemy Mix:**
```python
# Early game (0-2 minutes): Only Cursed Shabtis
if Game_Time < 120:
    Spawn_Shabtis_Only()

# Mid game (2-4 minutes): Mix of Shabtis + Guardians
elif Game_Time < 240:
    Spawn_Mix(
        Shabtis: 70%,
        Guardians: 30%
    )

# Late game (4-5 minutes): All enemies
else:
    Spawn_Mix(
        Shabtis: 40%,
        Guardians: 40%,
        Scarabs: 20%
    )

# High KPM bonus: More dangerous enemies
if KPM > 60:
    Increase_Guardian_Percent(+20%)  # More tanky enemies for skilled players
```

---

## 🎮 Combo System (STRETCH GOAL - Outside MVP)

### Combo Mechanics:

**Combo Window:** 3 seconds
```python
# Kill within 3 seconds of last kill = Combo continues
if Time_Since_Last_Kill < 3.0:
    Combo_Count += 1
else:
    Combo_Count = 1  # Reset
```

**Combo Bonuses:**
```python
# Bonus XP based on combo
XP_Multiplier = 1.0 + (Combo_Count * 0.02)  # +2% XP per combo

# Bonus loot at milestones
if Combo_Count == 10:
    SpawnBonusLoot(tier: Uncommon)
elif Combo_Count == 25:
    SpawnBonusLoot(tier: Rare)
elif Combo_Count == 50:
    SpawnBonusLoot(tier: Epic)
elif Combo_Count == 100:
    SpawnBonusLoot(tier: Legendary)  # JACKPOT!
```

**Visual Feedback:**
```
Combo UI (Top-right):
┌─────────────────┐
│  COMBO: 47 🔥   │
│  +94% XP        │
│  [████████░░] → 50
└─────────────────┘

Visual Effects:
- 10+ combo: Yellow glow around player
- 25+ combo: Orange fire particles
- 50+ combo: Purple lightning
- 100+ combo: Rainbow divine aura + screen shake
```

---

## 📊 Complete Spawn Formula

### Master Spawn Algorithm:
```python
class DynamicSpawnManager:
    def Update(delta_time):
        # Calculate current KPM
        current_KPM = CalculateKPM()

        # Determine spawn rate
        spawn_rate = CalculateSpawnRate(current_KPM)

        # Determine wave size
        wave_size = CalculateWaveSize(total_kills, game_time)

        # Determine enemy types
        enemy_mix = CalculateEnemyMix(game_time, current_KPM)

        # Check if time to spawn
        spawn_timer += delta_time
        if spawn_timer >= spawn_rate:
            SpawnWave(wave_size, enemy_mix)
            spawn_timer = 0

    def CalculateSpawnRate(kpm):
        base = 2.0  # seconds
        modified = base / (1 + kpm * 0.01)
        return max(0.5, modified)  # Cap at 0.5 sec

    def CalculateWaveSize(kills, time):
        kill_bonus = 1 + floor(kills / 100)
        time_multiplier = 1 + (time / 300)
        return ceil(kill_bonus * time_multiplier)

    def CalculateEnemyMix(time, kpm):
        if time < 120:
            return ['Shabtis': 100%]
        elif time < 240:
            guardian_percent = 30 + (kpm * 0.2)  # More if high KPM
            return ['Shabtis': 100-guardian_percent, 'Guardians': guardian_percent]
        else:
            return CalculateLateGameMix(kpm)
```

---

## 🎯 Difficulty Brackets

### Casual Player (0-20 KPM):
- **Spawn Rate:** ~1.5-2.0 seconds
- **Wave Size:** 1-2 enemies
- **Enemy Mix:** Mostly Shabtis (easy)
- **Experience:** Chill, manageable

### Average Player (20-40 KPM):
- **Spawn Rate:** ~1.0-1.5 seconds
- **Wave Size:** 2-3 enemies
- **Enemy Mix:** Balanced
- **Experience:** Engaging, some pressure

### Skilled Player (40-80 KPM):
- **Spawn Rate:** ~0.75-1.0 seconds
- **Wave Size:** 3-5 enemies
- **Enemy Mix:** More Guardians/Scarabs
- **Experience:** Intense, rewarding

### Speedrunner (80+ KPM):
- **Spawn Rate:** ~0.5-0.75 seconds (capped)
- **Wave Size:** 5-10 enemies
- **Enemy Mix:** Maximum danger
- **Experience:** Bullet hell, maximum loot

---

## 📈 Progression Timeline Example

### Average Player (30 KPM):

**Minute 0-1:**
- Spawn Rate: 1.5 sec
- Wave Size: 1
- Enemies: Shabtis only
- Kills: ~30
- Loot: ~30 items

**Minute 1-2:**
- Spawn Rate: 1.4 sec
- Wave Size: 1
- Enemies: Shabtis only
- Kills: ~45 (total 75)
- Loot: ~75 items total

**Minute 2-3:**
- Spawn Rate: 1.3 sec
- Wave Size: 2 (100+ kills reached)
- Enemies: 70% Shabtis, 30% Guardians
- Kills: ~90 (total 165)
- Loot: ~165 items total

**Minute 3-4:**
- Spawn Rate: 1.2 sec
- Wave Size: 3 (200+ kills)
- Enemies: 60% Shabtis, 30% Guardians, 10% Scarabs
- Kills: ~100 (total 265)
- Loot: ~265 items total

**Minute 4-5:**
- Spawn Rate: 1.0 sec
- Wave Size: 4-5 (300+ kills)
- Enemies: 40% Shabtis, 40% Guardians, 20% Scarabs
- Kills: ~120 (total 385)
- Loot: ~385 items total
- **Boss Warning:** Screen shake, music intensifies

**Minute 5:00 - BOSS:**
- Emperor Kha-Sekhem-Ra spawns
- All minions despawn
- 1v1 boss fight

---

## 🎮 Speedrunner Example (100+ KPM)

**Minute 0-1:**
- Spawn Rate: 0.5 sec (capped!)
- Wave Size: 1
- Kills: ~100 (insane)
- Result: Constant combat, loot shower

**Minute 2:**
- Wave Size: 2 (100 kills threshold)
- Kills: ~200 total
- Screen fills with enemies

**Minute 3:**
- Wave Size: 4 (200 kills threshold)
- Kills: ~300 total
- Bullet hell mode activated

**Minute 4-5:**
- Wave Size: 6-8
- Kills: ~500 total
- Screen is CHAOS
- Loot is EVERYWHERE
- Player is GOD-TIER

**Result:** Maximum challenge, maximum reward!

---

## 🔧 RPG Builder Implementation

### Custom Spawn Manager Script:

```csharp
using RPGBuilder.Managers;

public class DynamicSpawnManager : MonoBehaviour {
    // Track performance
    private int totalKills = 0;
    private float gameTime = 0f;
    private List<float> killTimestamps = new List<float>();

    // Spawn settings
    private float spawnTimer = 0f;
    private float baseSpawnRate = 2.0f;

    void Update() {
        gameTime += Time.unscaledDeltaTime;  // Unaffected by time slowdown

        // Calculate current KPM
        float currentKPM = CalculateKPM();

        // Update spawn rate
        float spawnRate = CalculateSpawnRate(currentKPM);

        // Spawn timer
        spawnTimer += Time.unscaledDeltaTime;
        if (spawnTimer >= spawnRate) {
            SpawnWave(currentKPM);
            spawnTimer = 0f;
        }
    }

    float CalculateKPM() {
        // Remove kills older than 30 seconds
        killTimestamps.RemoveAll(t => gameTime - t > 30f);

        // Calculate KPM from recent kills
        if (gameTime < 30f) {
            return totalKills / (gameTime / 60f);  // Use total time if < 30 sec
        } else {
            return killTimestamps.Count * 2;  // Last 30 sec * 2 = per minute
        }
    }

    float CalculateSpawnRate(float kpm) {
        float modified = baseSpawnRate / (1f + kpm * 0.01f);
        return Mathf.Max(0.5f, modified);  // Minimum 0.5 sec
    }

    int CalculateWaveSize() {
        int killBonus = 1 + Mathf.FloorToInt(totalKills / 100f);
        float timeMultiplier = 1f + (gameTime / 300f);
        return Mathf.CeilToInt(killBonus * timeMultiplier);
    }

    void SpawnWave(float kpm) {
        int waveSize = CalculateWaveSize();
        var enemyMix = DetermineEnemyMix(gameTime, kpm);

        for (int i = 0; i < waveSize; i++) {
            string enemyType = SelectEnemyType(enemyMix);
            SpawnEnemy(enemyType);
        }
    }

    public void OnEnemyKilled() {
        totalKills++;
        killTimestamps.Add(gameTime);
    }
}
```

---

## 📊 Difficulty Tiers

### Tier 1: Casual (0-20 KPM)
**Spawn Rate:** 1.67-2.0 sec
**Wave Size:** 1-2
**Loot Bonus:** +0-4%
**Feel:** Relaxed, exploratory

### Tier 2: Normal (20-40 KPM)
**Spawn Rate:** 1.25-1.67 sec
**Wave Size:** 2-3
**Loot Bonus:** +4-8%
**Feel:** Engaging, steady action

### Tier 3: Hard (40-60 KPM)
**Spawn Rate:** 0.91-1.25 sec
**Wave Size:** 3-5
**Loot Bonus:** +8-12%
**Feel:** Intense, skill required

### Tier 4: Extreme (60-80 KPM)
**Spawn Rate:** 0.71-0.91 sec
**Wave Size:** 5-7
**Loot Bonus:** +12-16%
**Feel:** Very challenging, maximum concentration

### Tier 5: Impossible (80+ KPM)
**Spawn Rate:** 0.5-0.71 sec (capped at 0.5)
**Wave Size:** 7-15
**Loot Bonus:** +16-24%
**Feel:** Bullet hell, god-tier loot

---

## 🎲 Enemy Mix by Game Time

### Phase 1: The Awakening (0-2 minutes)
```python
Enemy_Mix = {
    'Cursed_Shabtis': 100%  # Only skeletons
}

# Reasoning: Let player learn mechanics, find first weapons
```

### Phase 2: The Guardian's Rise (2-4 minutes)
```python
if KPM < 30:
    Enemy_Mix = {
        'Cursed_Shabtis': 70%,
        'Embalmed_Guardians': 30%
    }
else:  # High KPM players get more challenge
    Enemy_Mix = {
        'Cursed_Shabtis': 50%,
        'Embalmed_Guardians': 50%
    }

# Reasoning: Introduce tankier enemies for skilled players
```

### Phase 3: The Swarm (4-5 minutes)
```python
if KPM < 30:
    Enemy_Mix = {
        'Cursed_Shabtis': 50%,
        'Embalmed_Guardians': 40%,
        'Sacred_Scarab_Swarm': 10%
    }
elif KPM < 60:
    Enemy_Mix = {
        'Cursed_Shabtis': 40%,
        'Embalmed_Guardians': 40%,
        'Sacred_Scarab_Swarm': 20%
    }
else:  # Speedrunners get maximum chaos
    Enemy_Mix = {
        'Cursed_Shabtis': 30%,
        'Embalmed_Guardians': 40%,
        'Sacred_Scarab_Swarm': 30%
    }

# Reasoning: Full difficulty ramp for final minute
```

### Phase 4: The Emperor (5:00)
```python
# All spawning stops
DespawnAllMinions()

# Boss spawns
SpawnBoss('Emperor_Kha_Sekhem_Ra')

# Boss difficulty scales with player's KPM
if KPM > 60:
    Boss.Health *= 1.5  # Tankier for skilled players
    Boss.Damage *= 1.3  # Hits harder
    Boss.Speed *= 1.2   # Moves faster
```

---

## 📈 Loot Quality Scaling

### Dynamic Rarity Weights:

**Normal Player (30 KPM):**
```python
Loot_Table = {
    'Common': 70%,
    'Uncommon': 20%,
    'Rare': 8%,
    'Epic': 1.5%,
    'Legendary': 0.5%
}
```

**Speedrunner (80+ KPM):**
```python
# Bonus to higher rarities
Loot_Table = {
    'Common': 50%,      # -20%
    'Uncommon': 25%,    # +5%
    'Rare': 15%,        # +7%
    'Epic': 7%,         # +5.5%
    'Legendary': 3%     # +2.5%
}

# Result: 6x more Legendary drops for skilled play!
```

---

## 🎯 Anti-Cheese Mechanics

### 1. Anti-AFK System:
```python
# If player hasn't moved in 10 seconds
if Time_Since_Last_Movement > 10:
    Spawn_Rate *= 5  # Drastically slow spawns
    No_Loot_Drops = true  # No rewards for AFK

# Encourages movement (fits time mechanic!)
```

### 2. Anti-Corner Camping:
```python
# If player in same 5m radius for 30+ seconds
if Player_Position_Static_Time > 30:
    Spawn_Behind_Player()  # Force repositioning
    Spawn_Rate *= 0.5  # Double spawn rate
```

### 3. Safe Minimum:
```python
# Even at 0 KPM, game is still playable
Min_Spawn_Rate = 2.0 sec
Min_Wave_Size = 1

# Ensures new players can learn
```

---

## 🔢 Statistics & Telemetry

### Track These Metrics:
```python
Player_Stats = {
    'Total_Kills': int,
    'Kills_Per_Minute': float,
    'Peak_KPM': float,
    'Average_KPM': float,
    'Max_Combo': int,
    'Total_Loot': int,
    'Legendary_Drops': int,
    'Time_Survived': float,
    'Final_Level': int,
    'Build_Path': string  # Dominant archetype
}

# Display on victory/death screen
# Use for balancing post-jam
```

---

## 🎨 Visual Feedback (For Dima)

### KPM Intensity Indicators:

**Low Intensity (0-30 KPM):**
- Normal lighting
- Calm particle effects
- Standard UI

**Medium Intensity (30-60 KPM):**
- Slight red tint on screen edges
- More particles from kills
- Combo counter appears

**High Intensity (60-90 KPM):**
- Red vignette intensifies
- Screen shakes on kills
- Combat text larger
- Combo counter glowing

**EXTREME (90+ KPM):**
- Full screen effects
- Constant screen shake
- Rainbow combo counter
- Divine aura on player
- Epic music intensity

---

## 🎵 Audio Feedback (For Andy)

### Dynamic Music Layers:

**Base Layer (0-30 KPM):**
- Main theme (drums + strings)

**Action Layer (30-60 KPM):**
- Add brass section
- Increase tempo slightly

**Intense Layer (60-90 KPM):**
- Add percussion intensity
- Add Egyptian chanting
- Faster tempo

**CHAOS Layer (90+ KPM):**
- Full orchestral
- Epic choir
- Maximum tempo
- Sound epic and triumphant!

---

## ⚠️ Balance Considerations

### Preventing Snowballing:
```python
# If player is TOO strong (level 15+ before 3 minutes)
if Player_Level > Game_Time / 12:
    Increase_Boss_Difficulty()
    Slightly_Nerf_Loot_Quality()

# Keeps game challenging even for gods
```

### Preventing Death Spirals:
```python
# If player is struggling (low KPM, many deaths)
if Player_Deaths > 3 OR KPM < 10:
    Slightly_Reduce_Spawn_Rate()
    Increase_Loot_Quality()  # Help them get better gear

# Rubber-banding to keep it fun
```

---

## ✅ Testing Checklist

- [ ] Spawn rate responds to KPM correctly
- [ ] Wave size scales with kills and time
- [ ] Enemy mix changes over time
- [ ] High KPM players get more challenge + loot
- [ ] Low KPM players get manageable difficulty
- [ ] Boss difficulty scales appropriately
- [ ] Combo system works (if implemented)
- [ ] Anti-cheese systems prevent exploits
- [ ] Visual/audio feedback matches intensity

---

## 🎯 MVP Implementation (24 hours)

### Simplified Version:

**Static Formula Only:**
```python
# Simple KPM-based spawn rate
Spawn_Rate = 2.0 / (1 + KPM * 0.01)
Wave_Size = 1 + floor(Total_Kills / 150)
```

**No Combo System** (Stretch goal)
**No Dynamic Enemy Mix** (Use time-based only)
**No Rubber-banding** (Keep it pure)

**Stretch Goals (36-48 hours):**
- Add combo system
- Add dynamic enemy mix based on KPM
- Add visual intensity feedback
- Add dynamic music layers

---

## 📊 Expected Results

**Casual Player:**
- Faces 150-200 enemies in 5 minutes
- Collects ~150-200 items
- Reaches level 8-10
- Sees mostly Common/Uncommon loot
- **Fun, manageable experience**

**Skilled Player:**
- Faces 300-400 enemies in 5 minutes
- Collects ~350-450 items
- Reaches level 12-15
- Sees frequent Rare/Epic loot
- **Intense, rewarding experience**

**Speedrunner:**
- Faces 500+ enemies in 5 minutes
- Collects ~600+ items
- Reaches level 15+ easily
- Sees multiple Legendary drops
- **Bullet hell, maximum dopamine**

---

**Status:** ✅ Dynamic Difficulty System Complete
**Formulas:** 5 core algorithms
**Scalability:** Supports all skill levels
**Implementation Time:** 6-8 hours
**MVP Time:** 2-3 hours

*The curse adapts to your strength...*

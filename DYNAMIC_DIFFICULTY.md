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
        modified = base / (1f + kpm * 0.01f)
        return Mathf.Max(0.5f, modified)  # Cap at 0.5 sec

    def CalculateWaveSize(kills, time):
        kill_bonus = 1 + Mathf.FloorToInt(kills / 100f)
        time_multiplier = 1f + (time / 300f)
        return Mathf.CeilToInt(kill_bonus * time_multiplier)

    def CalculateEnemyMix(time, kpm):
        if time < 120:
            return ['Shabtis': 100%]
        elif time < 240:
            guardian_percent = 30 + (kpm * 0.2f)  # More if high KPM
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
- **Experience:** Intense, skill required

### Speedrunner (80+ KPM):
- **Spawn Rate:** ~0.5-0.75 seconds (capped)
- **Wave Size:** 5-10 enemies
- **Enemy Mix:** Maximum danger
- **Experience:** Bullet hell, maximum loot

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

## 📊 Statistics & Telemetry

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

## 🎯 Implementation Statistics

**Total Lines:** 508
**Estimated Implementation Time:** 6-8 hours
**Custom Code:** 25% (spawn manager)
**RPG Builder Native:** 75%

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

**Status:** ✅ Dynamic Difficulty System Complete
**Formulas:** 5 core algorithms
**Scalability:** Supports all skill levels
**Implementation Time:** 6-8 hours

*The curse adapts to your strength...*

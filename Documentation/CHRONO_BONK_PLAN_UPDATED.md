# Chrono-Bonk Unity Game Jam Technical Plan (Updated)

## Project Overview

**Game:** Chrono-Bonk (Timeless-themed ARPG with Superhot mechanic)
**Platform:** WebGL (Browser)
**Duration:** 48-hour game jam
**Team:**
- Nico (Lead Design/Coordination)
- Disha (Lead Dev/Git)
- Dima (Tech Art)
- Andy (Audio)
- jsynk (3D Generalist - Characters, Animations, 3D Assets)

**Core Mechanic:** Time moves at 100% when player moves, 10% when player stops. All combat is auto-attack. 5-minute global timer leads to boss wave.

**Note:** All suggestions in this plan are open to team verdict. Team should discuss and agree on approach before implementation.

**Status:** Base Unity project and GitHub repository already created.

---

## Phase 0: Pre-Jam Setup - COMPLETED

**Verified Assets (Confirm these are imported):**
- RPG Builder 2.0 (Location: `Assets/Blink/Tools/RPGBuilder/`)
- Malbers Animal Controller (Location: `Assets/Malbers Animations/`)
- Projectile Factory (Location: `Assets/InfinityPBR - Magic Pig Games/Projectile Factory/`)
- Stylized Lost Cave environment pack
- PBR Realistic Skeleton
- **Toon Shader Asset** (ready for integration)

**Next Steps:**
- Verify all assets are properly imported and accessible
- Confirm project settings are configured for WebGL
- Proceed directly to Phase 1: Core Systems

---

## Phase 1: Core Systems (Hours 1-6)

### 1.1 Time Management System
**Owner:** Disha
**Files to Create:**
- `Scripts/Core/TimeManager.cs` - Superhot time mechanic
- `Scripts/Core/GlobalTimer.cs` - 5-minute countdown (unscaled)

**TimeManager.cs Implementation:**
```csharp
// Checks player Rigidbody.velocity.magnitude
// If < 0.1f: Time.timeScale = 0.1f
// Else: Time.timeScale = 1.0f
// Uses unscaledDeltaTime for player checks
```

**GlobalTimer.cs Implementation:**
```csharp
// Counts down from 300 seconds using Time.unscaledDeltaTime
// Fires UnityEvent OnTimerEnd when reaching 0
// Displays timer in UI (unscaled)
```

**Testing Checklist:**
- [ ] Player movement triggers time correctly
- [ ] Player stopping slows time to 10%
- [ ] Global timer unaffected by time scale
- [ ] Timer UI updates correctly

### 1.2 Scene Setup & Environment
**Owner:** Nico (with Dima and jsynk support)
**Tasks:**
- Create main game scene: `Scenes/MainGame.unity`
- Import and place Stylized Lost Cave prefabs
- Block out single large arena (no multiple rooms)
- Bake NavMesh for enemy pathfinding
- Set up lighting (directional light, ambient)
- Create spawn points for enemies (empty GameObjects)

**jsynk's Contribution:**
- Review environment layout for gameplay flow
- Suggest optimal camera angles and player movement paths
- Provide feedback on arena size and obstacle placement

**Artist-Friendly Notes:**
- All environment placement is drag-and-drop
- NavMesh baking: Window > AI > Navigation > Bake
- Spawn points: Create empty GameObject, position, name "SpawnPoint_01", etc.

### 1.3 Toon Shader Asset Integration
**Owner:** Dima (with jsynk support)
**Asset:** Toon Shader Asset (already in project)

**Integration Approach:**
1. **Locate Toon Shader Asset:**
   - Find the toon shader asset in Project window
   - Identify the main shader file(s) and material presets
   - Check asset documentation/readme for usage instructions

2. **Create Material Presets:**
   - Create material presets for different asset types:
     - `Materials/Toon_Character.mat` - For player and enemies
     - `Materials/Toon_Environment.mat` - For Stylized Lost Cave assets
     - `Materials/Toon_Weapon.mat` - For weapon models
   - Apply toon shader to each preset
   - Adjust shader parameters (if available) for each use case

3. **Shader Configuration Best Practices:**
   - **For Characters (Player/Enemies):**
     - Use toon shader with rim lighting enabled (for visibility)
     - Set appropriate shadow settings (cast/receive shadows)
     - Ensure shader works with animation (skinned meshes)

   - **For Environment:**
     - Apply toon shader to Stylized Lost Cave materials
     - May need to adjust lighting model to match environment style
     - Test that toon shader doesn't break environment lighting

   - **For WebGL Performance:**
     - Verify shader is WebGL-compatible (no unsupported features)
     - Test shader performance in WebGL build
     - Consider reducing shader complexity if needed

4. **Application Workflow:**
   - **For Artists (jsynk, Dima):**
     - Apply toon material presets to character models
     - Replace existing materials with toon materials
     - Test in scene to ensure lighting looks correct

   - **For Non-Tech Team Members:**
     - Simple drag-and-drop: Select GameObject > Assign Material
     - Or use Material Property Block if shader supports it

5. **Testing Checklist:**
   - [ ] Toon shader works on player character
   - [ ] Toon shader works on enemy models (Skeleton, Mummy, Scarab)
   - [ ] Toon shader works on environment assets
   - [ ] Shader performs well in WebGL build
   - [ ] Lighting looks consistent across all assets
   - [ ] Shadows work correctly with toon shader

**Caveats:**
- Some toon shaders may not work well with time slowdown (test early)
- WebGL has shader limitations - verify compatibility before committing
- Toon shaders may require specific lighting setup - document requirements

### 1.4 Audio Foundation
**Owner:** Andy
**Tasks:**
- Set up Audio Mixer (Window > Audio > Audio Mixer)
- Create mixer groups: Music, SFX, Ambient
- Compose main theme loop (Egyptian-themed, high-energy)
- Create placeholder SFX slots for:
  - Whip attack
  - Skeleton attack
  - Rib boomerang
  - Auto-pickup
  - Player death

---

## Phase 2: RPG Builder Integration (Hours 7-18)

### 2.1 RPG Builder Database Setup (Part 1)
**Owner:** Nico
**Step-by-Step Process:**

**A. Clean Up RPG Builder UI:**
1. Open `DEMO_RPGBuilder2.0` scene
2. Find `[UI]` Canvas GameObject
3. Delete these panels:
   - `Quest_Journal_Panel`
   - `Dialogue_Panel`
   - `Talent_Tree_Panel`
4. Save scene as `Scenes/RPGBuilder_Clean.unity`

**B. Create Stats:**
1. Open `RPG Builder Editor > Settings > Character > Stats`
2. Create these stats:
   - `Health` (Vitality type, starts at 100)
   - `Time` (Vitality type, starts at 50, max 100) - This is "mana"
   - `Power` (Offensive type, starts at 10) - Damage multiplier
   - `Haste` (Offensive type, starts at 1.0) - Attack speed multiplier
   - `CC Power` (Defensive type, starts at 1.0) - Crowd control duration multiplier
3. Save all stats

**C. Create Level Template:**
1. Open `Editor > Progression > Level Templates`
2. Create template: "Timeless_Level"
3. Settings:
   - Max Level: 20
   - Base XP: 100
   - Increase by %: 20
4. Click "Click to Generate"
5. Save

**D. Create Character Class & Race:**
1. `Editor > Character > Classes`: Create "Timeless Explorer"
2. `Editor > Character > Races`: Create "Human"
3. Assign stats to class
4. Assign class to race

**Non-Tech Friendly Guide:**
- All steps are menu-driven in RPG Builder Editor
- No code required
- Each step has "Save" button - use it frequently
- Take screenshots for reference

### 2.2 Enemy AI Integration (Part 1 - Skeleton)
**Owner:** Dima (with Disha and jsynk support)
**Step-by-Step Process:**

**A. Prepare Skeleton Prefab (jsynk's Tasks):**
1. **jsynk:** Import/verify PBR Realistic Skeleton asset
2. **jsynk:** Review skeleton model for rigging compatibility
3. **jsynk:** Ensure skeleton has proper bone structure for animations
4. **Dima:** Create prefab: `Prefabs/Enemies/Skeleton.prefab`
5. **Dima:** Add components:
   - `Malbers Animal Controller` (core script)
   - `AI Animal Control` (NavMesh movement)
   - `MAnimalBrain` (AI logic - located at: `Assets/Malbers Animations/Common/Scripts/Animal Controller/AI Brain/MAnimalBrain.cs`)
   - `RPG Builder CombatNode` (stats/combat)

**B. Configure Malbers AI:**
1. In `MAnimalBrain` component:
   - Set `currentState` to AI State ScriptableObject
   - Create AI State with Tasks: "Go To" (Target: Player), "Attack" (Target: Player, Range: 2.0)
   - Reference: `MAnimalBrain.cs` uses `MAIState` ScriptableObjects for AI logic
2. Set NavMesh Agent settings (in `AI Animal Control` component):
   - Speed: 3.0
   - Stopping Distance: 1.5
   - Radius: 0.5

**C. Configure RPG Builder Combat:**
1. In `RPG Builder Editor > World > NPCs`:
   - Create "Skeleton" NPC entry
   - Assign Health stat (value: 50)
   - Set Faction: Hostile
   - Set XP value: 10
   - Create/assign Loot Table (empty for now)
2. In Skeleton prefab's `CombatNode`:
   - Assign the "Skeleton" NPC ScriptableObject
   - Set attack range: 2.0

**D. Create Rib Boomerang Attack (jsynk's Tasks):**
1. **jsynk:** Model/create rib cage boomerang asset (or use existing)
2. **Dima:** In `Projectile Factory`:
   - Create `PF_RibBoomerang` prefab
   - Visual: Rib cage model/particle effect
   - Physics: Arc trajectory, returns to skeleton
   - Use `ProjectileSpawner.cs` API: `SpawnProjectile()` method
   - Damage: Links to RPG Builder damage system
3. **jsynk:** Create/assign attack animation for skeleton
4. **Dima:** Link to Skeleton's attack animation (animation event)

**Testing:**
- [ ] Skeleton spawns and moves toward player
- [ ] Skeleton attacks at range
- [ ] Rib boomerang fires and returns
- [ ] Skeleton takes damage and dies
- [ ] Skeleton drops loot (when loot system ready)

**Caveats:**
- Malbers AI may need adjustment for time slowdown - test early
- `MAnimalBrain` uses ScriptableObject-based AI states - create states in advance
- Projectile Factory integration with RPG Builder damage may require custom script
- Animation events must work during time slowdown (use unscaled time)

### 2.3 Auto-Pickup System Foundation
**Owner:** Disha
**Files to Create:**
- `Scripts/Loot/AutoPickup.cs` - Trigger-based pickup
- `Scripts/Loot/AutoEquipManager.cs` - Auto-equip logic

**AutoPickup.cs Implementation:**
```csharp
// Sphere Collider trigger on player
// OnTriggerEnter: Check if GameObject has Loot component
// Call RPG Builder API: InventoryManager.AddItem()
// Call AutoEquipManager to equip item
```

**RPG Builder API Integration (Verified from Codebase):**
- **Location:** `Assets/Blink/Tools/RPGBuilder/Scripts/Managers/InventoryManager.cs`
- **Add Item Method:** `InventoryManager.Instance.AddItem(int itemID, int Amount, bool automaticallyEquip, int itemDataID)`
  - Set `automaticallyEquip = true` for auto-equip
  - Item ID from `RPGItem` ScriptableObject
- **Equip Item Method:** `InventoryManager.Instance.EquipItem(RPGItem itemToEquip, int bagIndex, int slotIndex, int itemDataID)`
  - Private method - may need to use `AddItem` with `automaticallyEquip = true` or create wrapper
- **Access:** `InventoryManager.Instance` (singleton pattern)
- **Item Database:** `GameDatabase.Instance.GetItems()[itemID]` to get `RPGItem` reference

**AutoEquipManager.cs Implementation:**
```csharp
// Check item type (Weapon, Armor/Scroll, Gem/Relic)
// For Weapons: Check weapon slots 1-3, equip to first empty or replace slot 1 (FIFO)
// For Scrolls: Check Scroll1-3 slots, same FIFO logic
// For Relics: Find first empty Relic socket, FIFO if all full
// Use InventoryManager.EquipItem() or AddItem() with auto-equip
```

**Testing:**
- [ ] Player walks over loot
- [ ] Item added to inventory via `InventoryManager.AddItem()`
- [ ] Item auto-equipped to correct slot
- [ ] Stat bonuses apply immediately

**Caveats:**
- `EquipItem()` is private - may need to use `AddItem()` with `automaticallyEquip = true` or create public wrapper
- FIFO replacement logic must be implemented manually
- Item data IDs may need to be tracked for proper equipping
- Test with time slowdown to ensure pickup works correctly

---

## Phase 3: Combat & Loot Systems (Hours 19-30)

### 3.1 RPG Builder Database Setup (Part 2)
**Owner:** Nico
**Tasks:**

**A. Create Item Types:**
1. `Editor > Economy > Item Types`:
   - Weapon (already exists, verify)
   - Armor (already exists, verify)
   - Create: "Gem Socket Type" called "Relic"

**B. Create Armor Slots:**
1. `Editor > Character > Armor Slots`:
   - Create: "Scroll1", "Scroll2", "Scroll3"

**C. Create Weapons (3 total):**
1. `Editor > Economy > Items`:
   - `Item_Whip` (Weapon type, Common rarity)
   - `Item_Boomerang` (Weapon type, Uncommon rarity)
   - `Item_FireballStaff` (Weapon type, Rare rarity)
2. For each weapon:
   - Assign to weapon slot
   - Set base damage stat bonus
   - Create ability reference (link to abilities created in 3.2)

**D. Create Scrolls (3 total):**
1. `Editor > Economy > Items`:
   - `Scroll_Power` (Armor type, Scroll1 slot, +10 Power)
   - `Scroll_Haste` (Armor type, Scroll2 slot, +0.5 Haste)
   - `Scroll_CCPower` (Armor type, Scroll3 slot, +0.2 CC Power)
2. Set rarity tiers (Common to Antique)
3. Add stat bonuses per rarity:
   - Common: +1 stat
   - Uncommon: +2 stats
   - Rare: +3 stats
   - Antique: +3 stats + special effect

**E. Create Relics (10 total):**
1. `Editor > Economy > Items`:
   - Create 10 relic items (Gem type, Relic socket)
   - Examples: `Relic_Haste_5Percent`, `Relic_Power_5Percent`, etc.
   - Each adds percentage-based stat bonus
   - Vary rarities

**F. Create Loot Tables:**
1. `Editor > Economy > Loot Tables`:
   - `LootTable_Skeleton`: 70% Common, 20% Uncommon, 8% Rare, 2% Antique
   - `LootTable_Mummy`: 60% Common, 25% Uncommon, 12% Rare, 3% Antique
   - `LootTable_Scarab`: 80% Common, 15% Uncommon, 4% Rare, 1% Antique
2. Assign items to each table with drop chances

**G. Link Loot Tables to NPCs:**
1. Update Skeleton NPC (from 2.2)
2. Assign `LootTable_Skeleton`
3. Repeat for Mummy and Scarab (when created)

### 3.2 Player Combat Abilities
**Owner:** Disha (with Nico support)
**Tasks:**

**A. Create Main Weapon Ability (Whip):**
1. `RPG Builder Editor > Combat > Abilities`:
   - Create `Ability_Whip`
   - Activation Type: **Auto Attack**
   - Cooldown: 1.0 second (uses unscaled time)
   - Range: 3.0 units
   - Target: Nearest Enemy
2. Add Effect:
   - Effect Type: Spawn Prefab
   - Prefab: `PF_Whip` (from Projectile Factory)
   - Damage: Links to Power stat

**B. Create Ultimate Skills (3 total):**
1. `Ability_Time_Freeze`:
   - Effect Type: Stat Modifier
   - Target: All Enemies in Radius
   - Stat: Movement Speed
   - Modifier: -100% (duration scales with CC Power)
   - Duration: 5 seconds base
   - Cost: 50 Time (mana)

2. `Ability_Haste`:
   - Effect Type: Stat Modifier
   - Target: Self
   - Stat: Haste
   - Modifier: +50%
   - Duration: 10 seconds
   - Cost: 30 Time

3. `Ability_Summon_Pet`:
   - Effect Type: Spawn Prefab
   - Prefab: Friendly Malbers AI (faction: Hostile to enemies)
   - Duration: 30 seconds
   - Cost: 40 Time

**C. Create Skill Selection UI:**
1. Create Canvas: `UI_SkillSelect`
2. Three buttons (one per ultimate skill)
3. On click:
   - Grant ability via RPG Builder API
   - Set `Time.timeScale = 1.0`
   - Hide UI
   - Start game

**Critical Note:** All ability cooldowns MUST use `Time.unscaledDeltaTime` to work during time slowdown.

### 3.3 Enemy Integration (Part 2 - Mummy & Scarab)
**Owner:** Dima (with jsynk support)
**Tasks:**

**A. Mummy Prefab (jsynk's Tasks):**
1. **jsynk:** Model/create Mummy character (or use existing asset)
2. **jsynk:** Rig Mummy for Malbers Animal Controller
3. **jsynk:** Create animations:
   - Bite attack animation
   - Bandage whip attack animation
   - Walk/run animations
   - Death animation
4. **Dima:** Create `Prefabs/Enemies/Mummy.prefab`
5. **Dima:** Add Malbers components (same as Skeleton):
   - `Malbers Animal Controller`
   - `AI Animal Control`
   - `MAnimalBrain` (AI logic)
   - `RPG Builder CombatNode`
6. **Dima:** Configure:
   - Melee attack (bite animation) - link via animation event
   - Bandage whip attack (Projectile Factory prefab)
   - Health: 75
   - Speed: 2.5 (slower than Skeleton)
7. **Dima:** Link to RPG Builder NPC entry

**B. Scarab Prefab (jsynk's Tasks):**
1. **jsynk:** Model/create Scarab character (or use existing asset)
2. **jsynk:** Rig Scarab for Malbers Animal Controller
3. **jsynk:** Create animations:
   - Walk/run animations (fast movement)
   - Death/explosion animation
4. **Dima:** Create `Prefabs/Enemies/Scarab.prefab`
5. **Dima:** Add Malbers components
6. **Dima:** Configure:
   - Explosion attack on death (triggered via death event)
   - Swarm behavior (multiple scarabs - handled by spawner)
   - Health: 25
   - Speed: 4.0 (faster)
7. **Dima:** Create `PF_ScarabExplosion` in Projectile Factory
   - Use `ProjectileSpawner.cs` API for spawning
   - Link to death event

**C. Animation Integration (jsynk's Tasks):**
1. **jsynk:** Link attack animations to Projectile Factory prefabs via animation events
2. **jsynk:** Ensure animation events use unscaled time for time slowdown compatibility
3. **Dima:** Test that animations work with time slowdown
4. **Dima:** Verify Projectile Factory prefabs spawn correctly from animation events

**Caveats:**
- Mummy and Scarab models must be compatible with Malbers rigging system
- Animation events must use unscaled time to work during time slowdown
- Projectile Factory integration may require custom event handlers
- Swarm behavior for Scarabs needs spawner system (not individual AI)

### 3.4 Auto-Equip System Completion
**Owner:** Disha
**Files to Modify:**
- `Scripts/Loot/AutoEquipManager.cs` - Complete implementation

**Logic:**
1. Check item type (Weapon, Armor/Scroll, Gem/Relic)
2. For Weapons:
   - Check if weapon slot 1, 2, or 3 is empty
   - If empty, equip to first available slot
   - If all full, replace slot 1 (FIFO)
3. For Scrolls:
   - Check Scroll1, Scroll2, Scroll3 slots
   - Same FIFO logic
4. For Relics:
   - Find first empty Relic socket
   - If all full, replace first socket (FIFO)

**RPG Builder API (Verified from Codebase):**
- **Location:** `Assets/Blink/Tools/RPGBuilder/Scripts/Managers/InventoryManager.cs`
- **Add Item with Auto-Equip:** `InventoryManager.Instance.AddItem(int itemID, int Amount, bool automaticallyEquip, int itemDataID)`
  - Set `automaticallyEquip = true` - this may handle equipping automatically
  - If not, need to manually call equip logic
- **Equip Item (Private):** `private void EquipItem(RPGItem itemToEquip, int bagIndex, int slotIndex, int itemDataID)`
  - This is private - may need to use `AddItem()` with `automaticallyEquip = true`
  - Or create public wrapper method
- **Access Equipped Items:**
  - Weapons: `Character.Instance.CharacterData.WeaponsEquipped[i]`
  - Armor: `Character.Instance.CharacterData.ArmorPiecesEquipped`
  - Check if slot is empty: `itemID == -1`
- **Item Database:** `GameDatabase.Instance.GetItems()[itemID]` returns `RPGItem`

**Implementation Approach:**
1. Use `AddItem()` with `automaticallyEquip = true` first - test if it handles FIFO
2. If not, implement custom logic:
   - Check equipped slots via `Character.Instance.CharacterData`
   - Determine which slot to use/replace
   - May need to unequip old item first (if API allows)
   - Then equip new item

**Testing:**
- [ ] Weapon auto-equips correctly
- [ ] Scroll auto-equips to correct slot
- [ ] Relic sockets properly
- [ ] FIFO replacement works
- [ ] Stat bonuses apply immediately

**Caveats:**
- `EquipItem()` is private - may need wrapper or use `AddItem()` with auto-equip
- FIFO logic may not be built into RPG Builder - implement manually
- Item data IDs must be tracked for proper equipping
- Unequipping old items may be required before equipping new ones
- Test with multiple item types to ensure correct slot assignment

### 3.5 Audio Integration
**Owner:** Andy
**Tasks:**
1. Integrate SFX with Projectile Factory prefabs:
   - Whip attack sound on `PF_Whip` spawn
   - Rib boomerang sound on `PF_RibBoomerang` spawn
   - Scarab explosion on `PF_ScarabExplosion`
2. Link to Malbers animation events:
   - Mummy bite sound
   - Skeleton attack sound
3. Create audio triggers:
   - Auto-pickup sound (in AutoPickup.cs)
   - Player death sound
   - Boss wave music transition
4. Set up audio mixer routing
5. Balance volume levels

---

## Phase 4: Boss Wave & Polish (Hours 31-40)

### 4.1 Boss Wave System
**Owner:** Disha
**Files to Create:**
- `Scripts/Enemies/BossWaveSpawner.cs` - Spawns boss on timer end

**Implementation:**
1. Subscribe to `GlobalTimer.OnTimerEnd` event
2. Stop regular enemy spawning
3. Spawn boss prefab at arena center
4. Play boss music (Audio Mixer transition)
5. Increase difficulty (more enemies spawn with boss)

**Boss Design:**
- Owner: Nico (design), Dima (implementation), jsynk (model/animations if needed)
- 1-2 boss prefabs (Pharaoh, Anubis, etc.)
- Higher health (500+)
- Multiple attack patterns
- Drops guaranteed Antique rarity items

### 4.2 Enemy Spawning System
**Owner:** Disha
**Files to Create:**
- `Scripts/Enemies/EnemySpawner.cs` - Manages enemy waves

**Implementation:**
1. Spawn enemies at random spawn points
2. Gradually increase spawn rate over 5 minutes
3. Spawn different enemy types based on timer
4. Pause spawning during time slowdown (optional - test for fun)

### 4.3 UI Systems
**Owner:** Disha (with Nico design)
**UI Elements Needed:**
1. **Global Timer Display:**
   - Large countdown (MM:SS format)
   - Changes color as time runs out
   - Uses unscaled time for updates

2. **Player Stats Display:**
   - Health bar
   - Time (mana) bar
   - Current level/XP

3. **Loot Notification:**
   - Brief popup when item auto-equips
   - Shows item name and stat bonus
   - Fades out after 2 seconds

4. **Ultimate Skill Cooldown:**
   - Shows cooldown for selected ultimate
   - Visual indicator when ready

**Implementation:**
- Use Unity UI (Canvas, Text, Image components)
- All UI updates use unscaled time
- Keep UI minimal (no inventory windows)

### 4.4 Balance & Tuning
**Owner:** Nico
**Parameters to Tune:**
1. Enemy spawn rates (start slow, ramp up)
2. Loot drop rates (ensure player gets upgrades)
3. Stat curve scaling (ensure progression feels good)
4. Time (mana) regeneration rate
5. Ultimate skill cooldowns and costs
6. Boss health and damage

**Testing Process:**
- Play full 5-minute run
- Note when game feels too easy/hard
- Adjust parameters
- Repeat until fun

### 4.5 Visual Polish
**Owner:** Dima
**Tasks:**
1. **Apply Toon Shader Asset to All Assets:**
   - Verify all characters (player, enemies) use toon shader materials
   - Ensure environment assets use appropriate toon materials
   - Check that weapon models have toon materials applied
   - Test that all materials render correctly in scene

2. **Polish VFX for All Attacks:**
   - Ensure VFX work with toon shader aesthetic
   - May need to adjust particle colors/styles to match toon look
   - Test VFX visibility during time slowdown

3. **Add Particle Effects:**
   - Loot pickup (sparkle effect, matches toon style)
   - Enemy death (toon-styled explosion/poof)
   - Ultimate skill activations (dramatic toon effects)

4. **Ensure Consistent Art Style:**
   - All assets should have cohesive toon aesthetic
   - Lighting should complement toon shader
   - Colors should be vibrant but not overwhelming

5. **Optimize for WebGL:**
   - Reduce draw calls (batch similar materials)
   - Optimize texture sizes (512x512 or 1024x1024 max)
   - Test shader performance in WebGL build
   - Ensure toon shader doesn't cause performance issues

**Artist-Friendly Checklist:**
- [ ] All characters use toon shader material from asset
- [ ] All environment uses consistent toon materials
- [ ] Particle effects match toon aesthetic
- [ ] UI matches game aesthetic
- [ ] Performance is smooth (60 FPS target in WebGL)
- [ ] Toon shader works correctly in WebGL build

---

## Phase 5: Build & Deploy (Hours 41-48)

### 5.1 Pre-Build Checklist
**Owner:** Disha
**Checklist:**
- [ ] All scenes saved
- [ ] All prefabs saved
- [ ] No console errors
- [ ] All assets properly referenced (no missing references)
- [ ] WebGL platform selected
- [ ] Compression Format: Disabled (critical!)
- [ ] Company Name and Product Name set
- [ ] Icon assigned (if available)

### 5.2 WebGL Build
**Owner:** Disha
**Steps:**
1. File > Build Settings
2. Select WebGL platform
3. Click "Switch Platform" (if not already)
4. Player Settings > WebGL:
   - Compression Format: **Disabled** (critical for Itch.io)
   - Template: Minimal (or Default)
   - Code Optimization: Speed
5. Build (start no later than Hour 44)
6. Build will create `Build/WebGL/` folder
7. Test build locally in browser

### 5.3 Itch.io Submission
**Owner:** Nico
**Steps:**
1. Create Itch.io project page
2. Upload `Build/WebGL/` folder as ZIP
3. Check "This file will be played in the browser"
4. Set game title: "Chrono-Bonk"
5. Add description, screenshots, tags
6. Publish

### 5.4 Final Testing
**Owner:** All Team Members
**Testing Checklist:**
- [ ] Clear browser cache
- [ ] Play public Itch.io link
- [ ] Test time mechanic (move/stop)
- [ ] Test combat (auto-attack works)
- [ ] Test loot pickup and auto-equip
- [ ] Test ultimate skills
- [ ] Test boss wave spawns at 5 minutes
- [ ] Test on different browsers (Chrome, Firefox, Edge)
- [ ] Verify audio works
- [ ] Check for performance issues

---

## Technical Considerations & Gotchas

### Critical Technical Points:

1. **Time Scale Immunity:**
   - Player Animator: Update Mode = Unscaled Time
   - All player scripts: Use `Time.unscaledDeltaTime`
   - Global timer: Use `Time.unscaledDeltaTime`
   - Ability cooldowns: Use `Time.unscaledDeltaTime`
   - UI updates: Use `Time.unscaledDeltaTime`
   - **CAVEAT:** Animation events must also use unscaled time or they won't fire during slowdown

2. **RPG Builder Integration:**
   - **API Location:** `Assets/Blink/Tools/RPGBuilder/Scripts/Managers/`
   - **InventoryManager:** `InventoryManager.Instance.AddItem(int itemID, int Amount, bool automaticallyEquip, int itemDataID)`
   - **EquipItem is private** - may need wrapper or use `AddItem()` with `automaticallyEquip = true`
   - Test all API calls before implementing
   - Keep backup of original RPG Builder scenes
   - Document all custom modifications
   - **CAVEAT:** RPG Builder may have its own time scale handling - test compatibility

3. **Malbers Animal Controller:**
   - **AI Brain Location:** `Assets/Malbers Animations/Common/Scripts/Animal Controller/AI Brain/MAnimalBrain.cs`
   - **AI Uses ScriptableObjects:** `MAIState` ScriptableObjects for AI logic
   - Ensure NavMesh is baked before testing AI
   - Test AI behavior with time slowdown
   - May need to adjust AI update rates
   - **CAVEAT:** Malbers AI may not respect time scale - may need custom time handling

4. **Projectile Factory:**
   - **Spawner API:** `ProjectileSpawner.cs` - `SpawnProjectile()` method
   - **Location:** `Assets/InfinityPBR - Magic Pig Games/Projectile Factory/Scripts/ProjectileSpawner.cs`
   - Link projectiles to RPG Builder damage system
   - Test projectiles work with time slowdown
   - Ensure projectiles are destroyed properly
   - **CAVEAT:** Projectile Factory may need custom integration with RPG Builder damage

5. **WebGL Limitations:**
   - No file system access
   - Limited memory
   - Compression must be disabled for Itch.io
   - Test early and often
   - **CAVEAT:** Some shaders/features may not work in WebGL - test toon shader early

6. **Asset Integration Caveats:**
   - **RPG Builder + Malbers:** May have conflicting character controllers - use Malbers for AI only
   - **RPG Builder + Projectile Factory:** Damage integration may require custom bridge script
   - **Time Slowdown + All Systems:** Every system must be tested with time slowdown
   - **Animation Events:** Must use unscaled time or won't fire during slowdown
   - **NavMesh:** Must be rebaked if environment changes significantly

### Artist/Non-Tech Friendly Guidelines:

1. **For 3D Artists (jsynk, Dima):**
   - All character models: Export as FBX
   - Rigging: Use humanoid rig if possible (for Malbers compatibility)
   - Animations: Export as separate FBX files
   - Textures: 512x512 or 1024x1024 max (WebGL optimization)
   - Naming convention: `Character_Action.fbx` (e.g., `Skeleton_Attack.fbx`)

2. **For Audio (Andy):**
   - Export as OGG Vorbis (WebGL compatible)
   - Music: 128 kbps (balance quality/size)
   - SFX: 44.1 kHz, mono (unless stereo needed)
   - Naming: `SFX_Action.ogg` (e.g., `SFX_Whip.ogg`)

3. **For Designers (Nico):**
   - RPG Builder Editor is menu-driven (no code)
   - All stats/items/abilities created through UI
   - Take screenshots of important settings
   - Document any "weird" RPG Builder behaviors

### Asset Integration Checklist:

- [ ] RPG Builder: Database setup complete, UI cleaned, API tested
- [ ] Malbers: AI working, NavMesh baked, enemies pathfinding
- [ ] Projectile Factory: All attack prefabs created, linked to abilities
- [ ] Stylized Lost Cave: Environment placed, NavMesh baked, lighting set
- [ ] PBR Realistic Skeleton: Rigged, animated, AI configured
- [ ] **Toon Shader Asset: Integrated, material presets created, applied to all characters and environment, WebGL tested**
- [ ] Audio: All sounds integrated, mixer configured

---

## Risk Mitigation

### High-Risk Areas:

1. **RPG Builder API Complexity:**
   - Risk: API may not work as expected
   - Mitigation: Test early (Hour 7-12), have backup plan (manual inventory if needed)
   - **Verified API:** `InventoryManager.Instance.AddItem()` confirmed in codebase

2. **Time Scale Mechanic Bugs:**
   - Risk: Some systems may not respect time scale
   - Mitigation: Test thoroughly, use unscaled time everywhere for player systems
   - **Critical:** Animation events must use unscaled time

3. **WebGL Build Issues:**
   - Risk: Build may fail or not work in browser
   - Mitigation: Test build early (Hour 30), fix issues immediately
   - **Critical:** Compression Format must be Disabled

4. **Asset Integration Conflicts:**
   - Risk: Assets may conflict with each other
   - Mitigation: Test asset combinations early, isolate problematic assets
   - **Known Issue:** RPG Builder + Malbers may have controller conflicts

5. **Toon Shader Compatibility:**
   - Risk: Toon shader may not work in WebGL or with time slowdown
   - Mitigation: Test shader early, have fallback shader ready

### Backup Plans:

- If RPG Builder auto-equip fails: Manual equip on pickup (slower but works)
- If time mechanic breaks: Simplify to binary on/off (no gradual slowdown)
- If WebGL build fails: Export as Windows build (not ideal but playable)
- If assets conflict: Use only essential features, disable problematic modules
- If toon shader fails: Use Unity built-in toon shader or standard shader with toon lighting

---

## Success Criteria

**Minimum Viable Product (MVP):**
- [ ] Player can move and stop (time mechanic works)
- [ ] Player auto-attacks nearest enemy
- [ ] At least 1 enemy type spawns and attacks
- [ ] Enemies drop loot
- [ ] Loot auto-picks up and equips
- [ ] 5-minute timer counts down
- [ ] Boss spawns at timer end
- [ ] Game is playable in browser

**Stretch Goals (if time permits):**
- [ ] All 3 enemy types implemented
- [ ] All 3 weapons implemented
- [ ] All 3 ultimate skills working
- [ ] Multiple boss types
- [ ] Polished UI
- [ ] Full audio integration
- [ ] Visual polish complete

---

## Team Communication Protocol

1. **Git Workflow:**
   - Create feature branches: `feature/time-manager`, `feature/enemy-ai`, `feature/player-character`, etc.
   - Commit frequently with clear messages
   - Push to GitHub regularly
   - Disha manages main branch merges
   - **jsynk's branches:** `feature/skeleton-model`, `feature/mummy-model`, `feature/scarab-model`, `feature/animations`

2. **Asset Naming:**
   - Scripts: `Scripts/Category/Name.cs`
   - Prefabs: `Prefabs/Type/Name.prefab`
   - Scenes: `Scenes/Name.unity`
   - Materials: `Materials/Name.mat`
   - **jsynk's assets:** `Models/Characters/Name.fbx`, `Animations/Character_Action.fbx`

3. **Documentation:**
   - Keep `GDD_CHRONO_BONK.md` updated
   - Document any "weird" asset behaviors
   - Screenshot important RPG Builder settings
   - Note any workarounds needed
   - **jsynk:** Document model requirements, rigging specs, animation naming conventions

4. **Team Verdict Process:**
   - All suggestions in this plan are open to team discussion
   - Team should agree on approach before major implementation
   - Use Discord/chat for quick decisions
   - Document final decisions in plan updates

---

## Workload Distribution Summary

**Nico (Lead Design):**
- RPG Builder database setup (stats, items, loot tables, NPCs)
- Gameplay balance and tuning
- Scene setup and environment placement
- Itch.io submission

**Disha (Lead Dev/Git):**
- Time management system (TimeManager, GlobalTimer)
- Auto-pickup and auto-equip systems
- Player combat abilities and ultimate skills
- UI systems
- Boss wave spawner
- Enemy spawner system
- WebGL build and deployment
- Git repository management

**Dima (Tech Art):**
- Toon shader integration and material setup
- Enemy AI integration (Malbers + RPG Builder)
- Projectile Factory prefab creation
- VFX and particle effects
- Visual polish and optimization

**jsynk (3D Generalist):**
- Character models (Skeleton, Mummy, Scarab review/creation)
- Character rigging for Malbers Animal Controller
- Character animations (attack, walk, death)
- Weapon models (if needed)
- Animation event setup
- Art asset optimization for WebGL
- Rib boomerang asset creation
- Environment layout feedback

**Andy (Audio):**
- Main theme composition
- Combat SFX (whip, attacks, explosions)
- UI sounds (pickup, skill selection)
- Audio mixer setup
- Audio integration with Projectile Factory and animation events

---

## Post-Jam Notes

After the jam, document:
- What worked well
- What didn't work
- Asset integration challenges
- Time estimates vs. actual time
- Lessons learned for future jams
- API reference corrections (update this plan with actual working methods)
- Asset compatibility issues discovered
- Toon shader performance and compatibility notes

This plan ensures technical soundness, provides clear artist/non-tech friendly steps, integrates all required assets systematically, and distributes workload appropriately across team members with verified API references from the actual codebase.

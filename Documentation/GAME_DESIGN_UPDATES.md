# Chrono-Bonk Game Design Updates

**Date:** 2025-11-08
**Source:** Team Meeting & Discord Discussion
**Status:** 🔴 IMPORTANT CHANGES - GDD needs update

---

## 🚨 Key Changes from Original GDD

### 1. Weapons System - EXPANDED ✅

**Original (GDD):** 3 weapons - Whip, Boomerang, Fireball Staff

**Updated (Team Meeting):** 8 weapons organized by range

#### Melee Range:
1. **Shovel** - Regular hit
   - Range: Short
   - Style: Standard melee attack
   - Visual: Archaeological tool

2. **Torch** - Short range burn
   - Range: Short
   - Style: Fire damage over time
   - Visual: Flaming torch with embers

#### Medium Range:
3. **Whip** ⭐ (Original - KEPT)
   - Range: Medium
   - Style: Cleave attack
   - Visual: Classic Indiana Jones style

4. **Chakram** (Replaces "Boomerang")
   - Type: Sun Disk / Aten Disk
   - Range: Medium
   - Style: Pierce - boomerangs back, hits multiple enemies
   - Visual: Circular bladed ring with solar trails

#### Long Range:
5. **Spell Amulet** (Replaces "Fireball Staff")
   - Type: Eye of Ra Amulet / Light Staff of Anubis
   - Range: Long
   - Style: Auto-target magic, summons sunlight beams
   - Visual: Divine light bursts (not laser-like)
   - Can do AOE damage

6. **Poisoned Blow Darts**
   - Range: Long
   - Style: Single target, high precision
   - Visual: Tribal blow dart weapon

#### Additional Mentions (Uncertain):
- **Spear** - mentioned in chat, unclear if confirmed
- **Shield** - mentioned in chat, unclear if confirmed

**Impact:** Need to update weapon database, asset list, and auto-attack logic to handle 6-8 weapons instead of 3.

---

### 2. Ultimate Skills - COMPLETELY REDESIGNED ❗

**Original (GDD):**
1. Time Freeze - Freezes enemies in radius for 5 seconds
2. Haste - Increases attack speed 50% for 10 seconds
3. Summon Pet - Spawns AI companion for 30 seconds

**Updated (Team Meeting):** 3 new ultimate skills

#### New Ultimate Skills:

1. **Rolling Boulders** (CC Type)
   - Type: Crowd Control
   - Effect: Knockback enemies with massive AOE damage
   - Range: Entire screen
   - Direction: Rolls in direction player is facing
   - Visual: Boulders rolling from one side of screen to the other
   - Theme: Indiana Jones boulder trap reference

2. **Speed Boost** (Speed Type)
   - Effect: Increases attack speed, casting speed, AND movement speed
   - Duration: TBD
   - Multiplier: TBD
   - Note: More comprehensive than original "Haste"

3. **Immunity** (Defensive Type)
   - Effect: Grants immunity to all damage/death
   - Secondary: Reflects damage back to attacker/caster
   - Duration: TBD
   - Note: Completely new defensive mechanic

**Impact:** Complete overhaul of ultimate skill system. Original skills scrapped.

---

### 3. Powerups - NEW SYSTEM 🆕

**Not in Original GDD**

**Added (Team Meeting):** Random powerup drops

#### Powerup System:
- **Drop Chance:** 1% on loot drop
- **Duration:** Temporary buffs (TBD)

#### Powerup Types:
1. **Freeze Time Around You**
   - Effect: Time stops for enemies, player can still move
   - Synergy: Works with core "Superhot" mechanic

2. **Move Faster**
   - Effect: Temporary movement speed boost
   - Use: Quick repositioning, escape

3. **Restore Health**
   - Effect: Instant health recovery
   - Amount: TBD

**Impact:** New loot drop logic needed. Add to RPG Builder database.

---

### 4. Team Structure & Workflow - CONFIRMED ✅

#### Team Roles (Confirmed):

**jsynk** - 3D Generalist
- Characters (player, enemies, bosses)
- Animations (attack, walk, death)
- 3D Assets (weapons, props)

**Nico (UnDeR_EsTiMaTeD)** - Lead Design
- RPG Builder database setup
- Scene layout
- Gameplay balancing

**di (Disha)** - Lead Dev/Git
- Time management system
- Core systems programming
- Git repository management

**Dima** - Tech Art
- Toon shader integration
- Visual effects
- Material setup

**Andy** - Audio
- Music composition
- Sound effects
- Audio integration

#### Git Workflow (Confirmed):

**Branching Strategy:**
- User-based branches (each person has their own branch)
- Branch naming: User's name (e.g., `nico`, `disha`, `jsynk`, etc.)
- Main branch: Protected, requires PR
- Merges: Pull Requests reviewed by Disha

**Current Branch Status:**
- `nico` - Active, has latest changes
- `main` - Production branch
- `disha-development` - Exists on remote

**Workflow:**
1. Work on personal branch
2. Commit frequently
3. Push to origin/your-name
4. Open PR when ready
5. Disha merges to main

---

### 5. Character Design - CONFIRMED ✅

**Player Character:**
- Inspired by: Indiana Jones + Lara Croft
- Art Style: Clash Royale-like cartoon
- Age Rating: 4+ (all ages)
- Starting Weapon: Whip (confirmed)

**Enemies (Confirmed - No Changes):**
- Ranged Skeleton - throws rib cage as boomerang ✅
- Melee Mummy - bite + bandage whips ✅
- 1-2 Bosses - timeless theme in lost cavern ✅

---

## 📋 Action Items

### For Nico:
- [ ] Update `GDD_CHRONO_BONK.md` with new weapons
- [ ] Update `GDD_CHRONO_BONK.md` with new ultimate skills
- [ ] Add powerups section to GDD
- [ ] Update weapon count: 3 → 6-8
- [ ] Clarify if Spear/Shield are included

### For Disha:
- [ ] Update `CHRONO_BONK_PLAN_UPDATED.md` with new weapon logic
- [ ] Plan auto-attack system for multiple weapon ranges
- [ ] Plan ultimate skill implementation (3 new mechanics)
- [ ] Add powerup drop system to loot logic

### For jsynk:
- [ ] Review updated weapon list
- [ ] Confirm which weapons need 3D models
- [ ] Plan animation requirements per weapon
- [ ] Coordinate with Dima on weapon visual style

### For Dima:
- [ ] Plan VFX for new weapons (especially Chakram, Amulet)
- [ ] Plan VFX for Rolling Boulders ultimate
- [ ] Plan VFX for Immunity shield/reflect
- [ ] Coordinate with jsynk on weapon models

### For Andy:
- [ ] SFX for 6-8 weapons instead of 3
- [ ] SFX for Rolling Boulders
- [ ] SFX for Immunity activation
- [ ] SFX for powerup pickups

---

## ⚠️ Development Impact

### High Impact:
1. **Weapon System:** 3 → 6-8 weapons (3x expansion)
   - More 3D models needed
   - More animations needed
   - More auto-attack logic
   - More SFX needed

2. **Ultimate Skills:** Complete redesign
   - Original skills scrapped
   - New mechanics need implementation
   - Different VFX requirements

### Medium Impact:
3. **Powerup System:** New feature
   - Loot drop logic expansion
   - UI indicators needed
   - Visual/audio feedback

### Low Impact:
4. **Git Workflow:** Confirmed structure
   - Already implemented
   - No changes needed

---

## 🔄 Comparison Table

| Feature | Original GDD | Updated (Team Meeting) | Status |
|---------|-------------|----------------------|--------|
| **Weapons** | 3 (Whip, Boomerang, Staff) | 6-8 (Shovel, Whip, Torch, Chakram, Amulet, Darts, Spear?, Shield?) | ⚠️ CHANGED |
| **Ultimate Skills** | Time Freeze, Haste, Summon Pet | Rolling Boulders, Speed Boost, Immunity | ⚠️ CHANGED |
| **Powerups** | None | 3 types (Freeze, Speed, Heal) @ 1% drop | 🆕 NEW |
| **Enemies** | Skeleton, Mummy, Scarab, Boss | Same | ✅ SAME |
| **Player** | Indiana Jones inspired | Indiana Jones + Lara Croft | ✅ SAME |
| **Art Style** | Clash Royale-like | Clash Royale-like | ✅ SAME |
| **Git Workflow** | Not specified | User-based branches | 🆕 NEW |

---

## 📝 Documentation Status

### Needs Update:
- ❌ `GDD_CHRONO_BONK.md` - Section 5 (Weapons & Items)
- ❌ `GDD_CHRONO_BONK.md` - Section 3.1 (Ultimate Skills)
- ❌ `GDD_CHRONO_BONK.md` - Add new Powerups section
- ❌ `CHRONO_BONK_PLAN_UPDATED.md` - Weapon implementation
- ❌ `ASSET_STATUS.md` - Update asset requirements

### Already Current:
- ✅ `BRANCH_SYNC_STATUS.md` - Git workflow documented
- ✅ `CONFIGURATION_COMPLETE.md` - Setup complete
- ✅ Technical plan structure (just needs content updates)

---

## 🎯 Next Meeting Topics

### Clarifications Needed:
1. **Weapons:** Confirm final count (6 or 8?)
2. **Weapons:** Are Spear and Shield included?
3. **Ultimate Skills:** Durations and cooldowns?
4. **Ultimate Skills:** Specific damage/multiplier values?
5. **Powerups:** Duration times?
6. **Powerups:** Visual indicators?

### Asset Planning:
1. **3D Models:** Priority list for jsynk
2. **Animations:** Which weapons share animations?
3. **VFX:** Priority list for Dima
4. **SFX:** Priority list for Andy

---

## 📊 Scope Impact

**Time Estimate Changes:**

| Task | Original Estimate | New Estimate | Reason |
|------|------------------|--------------|--------|
| Weapon System | 4 hours | 8-10 hours | 3x more weapons |
| Ultimate Skills | 3 hours | 6-8 hours | Complete redesign |
| Loot System | 3 hours | 4-5 hours | Added powerups |
| 3D Asset Creation | TBD | +50% | More weapons |
| Animation | TBD | +50% | More weapons |
| VFX | TBD | +30% | New ultimates |
| SFX | TBD | +50% | More weapons |

**Total Scope Increase:** ~40-50% in asset/implementation work

**Recommendation:** Prioritize MVP (Minimum Viable Product):
- Start with 3 core weapons (Whip, Chakram, Amulet)
- Start with 1 ultimate (Rolling Boulders - most unique)
- Add powerups last (lowest priority)
- Expand if time permits

---

## ✅ Team Communication

**This document shared with:**
- [x] Team uploaded to repo
- [ ] GDD updated (pending)
- [ ] Technical plan updated (pending)
- [ ] Team notified in Discord (pending)

**Follow-up Meeting:** Recommend quick sync to finalize:
1. Final weapon count
2. MVP prioritization
3. Asset creation pipeline

---

*Last Updated: 2025-11-08*
*Branch: nico*
*Source: Team Discord Chat (Nov 8, 12:00-4:00 PM)*


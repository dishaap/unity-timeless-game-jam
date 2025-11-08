# Unity Project Streamlining Plan

**Issue:** Unity keeps crashing
**Library Size:** 323 MB (bloated - should be regenerated)
**Status:** Executing cleanup to improve stability

---

## Identified Problems

### 1. Excessive Example/Demo Content (High Priority)
- 19 example/demo/sample folders consuming memory
- These are not needed for actual game development
- Cause: Asset packages include tutorials/demos

### 2. Unused Shader Packages (High Priority)
- **Current:** All render pipeline packages included (Built-In, LWRP, HDRP, URP)
- **Needed:** Only URP (Universal Render Pipeline)
- **Wasting:** ~50+ MB of unused shader packages

### 3. Multiple Editor Extensions (Medium Priority)
- FastScriptReload (hot reload - can cause crashes)
- Easy Build System (not essential for jam)
- vFolders (editor organization - nice-to-have)
- vInspector (inspector enhancement - nice-to-have)

### 4. Bloated Library Folder (High Priority)
- 323 MB cached data
- May contain corrupted cache
- Should be regenerated

---

## Cleanup Actions

### Phase 1: Remove Example/Demo Content ✅
**Remove these folders:**
- `Assets/RealToon/RealToon Examples/` (entire folder)
- `Assets/MagicArsenal/Demo/`
- `Assets/FastScriptReload/Samples/`
- `Assets/Easy Build System/Packages/Demos/`
- `Assets/vInspector/Examples/`
- `Assets/Malbers Animations/Animal Controller/Demo Scenes/`
- `Assets/Blink/Art/Icons/Demo/`
- `Assets/InfinityPBR - Magic Pig Games/Projectile Factory/Demo/`

**Impact:** Save ~100-200 MB, reduce scene clutter, improve load times

### Phase 2: Remove Unused Shader Packages ✅
**Keep only:**
- `Assets/RealToon/RealToon Shader Packages/SRP (LWRP - URP - HDRP)/URP/`

**Remove:**
- `Assets/RealToon/RealToon Shader Packages/Built-In RP [3D]/`
- `Assets/RealToon/RealToon Shader Packages/SRP (LWRP - URP - HDRP)/HDRP/`
- `Assets/RealToon/RealToon Shader Packages/SRP (LWRP - URP - HDRP)/LWRP/`

**Impact:** Save ~50 MB, reduce shader compilation time

### Phase 3: Disable/Remove Problematic Editor Extensions ✅
**FastScriptReload:** Known to cause crashes - REMOVE
**Easy Build System:** Not needed for jam - REMOVE
**vFolders:** Keep if stable, remove if causing issues
**vInspector:** Keep if stable, remove if causing issues

**Impact:** Improve editor stability, faster startup

### Phase 4: Clean Library/Temp ✅
**Action:** Delete and regenerate
- Close Unity
- Delete `Library/` folder
- Delete `Temp/` folder
- Reopen Unity (will regenerate clean cache)

**Impact:** Fix corrupted cache, improve stability

### Phase 5: Optimize Project Settings ✅
- Disable auto-refresh (manual refresh instead)
- Reduce import workers
- Disable unnecessary editor features

---

## Execution Order

1. **Commit current state** (backup before cleanup)
2. **Remove example/demo folders**
3. **Remove unused shader packages**
4. **Remove problematic editor extensions**
5. **Close Unity**
6. **Delete Library and Temp folders**
7. **Commit cleanup**
8. **Reopen Unity** (regenerate clean cache)
9. **Verify stability**

---

## Expected Results

**Before:**
- Library: 323 MB
- Assets: ~86 files with examples
- Unity crashes frequently
- Slow load times

**After:**
- Library: ~150 MB (clean)
- Assets: Core game assets only
- Stable Unity editor
- Faster load times
- Smaller repo size

---

## Rollback Plan

If issues occur:
```bash
git checkout nico~1  # Revert to before cleanup
```

Or cherry-pick specific removals that work.

---

**Status:** Ready to execute
**Backup:** Git commit before changes
**Safety:** All changes reversible via git


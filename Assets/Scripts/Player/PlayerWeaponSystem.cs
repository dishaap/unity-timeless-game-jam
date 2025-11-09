using UnityEngine;
using System;
using System.Collections;

public class PlayerWeaponSystem : MonoBehaviour
{
    [System.Serializable]
    public class WeaponSlot
    {
        public string slotName = "Primary";
        public float attackCooldown = 1f;
        public GameObject projectilePrefab; // optional for ranged attacks
        [HideInInspector] public bool canAttack = true;
    }

    [Header("Weapon Slots")]
    public WeaponSlot[] weapons;

    [Header("Targeting")]
    public float targetRange = 15f;
    public LayerMask enemyLayer;

    [Header("References")]
    public Transform projectileSpawn;
    public PlayerAttackEffects attackEffects;

    private void Update()
    {
        // Left-click fires primary weapon
        if (Input.GetMouseButton(0))
            TryAttack(0, null, null);
    }

    /// <summary>
    /// Fires the weapon at a target and applies damage callback
    /// </summary>
    public void TryAttack(int slotIndex, Transform target, Action<Transform, float> onDamage)
    {
        if (slotIndex >= weapons.Length) return;
        WeaponSlot slot = weapons[slotIndex];
        if (!slot.canAttack) return;

        StartCoroutine(AttackRoutine(slot, target, onDamage));
    }

    private IEnumerator AttackRoutine(WeaponSlot slot, Transform target, Action<Transform, float> onDamage)
    {
        slot.canAttack = false;

        // Play attack VFX/SFX
        attackEffects?.PlayAttackEffect();

        if (target != null)
        {
            // Spawn projectile if assigned
            if (slot.projectilePrefab)
            {
                GameObject proj = Instantiate(slot.projectilePrefab, projectileSpawn.position, Quaternion.identity);
                proj.GetComponent<Rigidbody>().linearVelocity = (target.position - projectileSpawn.position).normalized * 20f;
            }

            // Call damage callback
            onDamage?.Invoke(target, 10f); // example: 10 damage per attack
        }

        // Cooldown uses unscaled time for Chrono-Bonk slow-motion
        yield return new WaitForSecondsRealtime(slot.attackCooldown);
        slot.canAttack = true;
    }
}

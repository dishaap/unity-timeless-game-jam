using UnityEngine;
using System.Collections;
using MalbersAnimations.Controller;

public class PlayerCombatController : MonoBehaviour
{
    public PlayerWeaponSystem weaponSystem;
    public float attackRange = 15f;
    public LayerMask enemyLayer;

    private Transform currentTarget;

    private void Update()
    {
        AutoTargetNearestEnemy();

        // Auto-attack primary weapon
        if (currentTarget != null)
            TryAttack(0);  // slot 0 = primary weapon
    }

    private void AutoTargetNearestEnemy()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, attackRange, enemyLayer);
        if (hits.Length == 0)
        {
            currentTarget = null;
            return;
        }

        float minDist = float.MaxValue;
        Transform nearest = null;

        foreach (var hit in hits)
        {
            float dist = Vector3.Distance(transform.position, hit.transform.position);
            if (dist < minDist)
            {
                minDist = dist;
                nearest = hit.transform;
            }
        }

        currentTarget = nearest;
    }

    private void TryAttack(int slotIndex)
    {
        if (weaponSystem == null || currentTarget == null) return;

        weaponSystem.TryAttack(slotIndex, currentTarget, (target, dmg) =>
        {
            // Deal damage using Malbers internal stats
            var mAnimal = target.GetComponent<MAnimal>();
            if (mAnimal != null)
            {
                var healthField = mAnimal.GetType().GetField("Health", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                if (healthField != null)
                {
                    float currentHealth = (float)healthField.GetValue(mAnimal);
                    healthField.SetValue(mAnimal, currentHealth - dmg);
                }
            }
        });
    }
}

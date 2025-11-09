using UnityEngine;
using System.Collections;
using MalbersAnimations.Controller;
using MalbersAnimations;

public class PlayerUltimateController : MonoBehaviour
{
    [Header("References")]
    public MAnimal playerAnimal;
    public MAnimalSpeedModifier speedModifier;
    public PlayerWeaponSystem weaponSystem;
    public Stats playerStats;

    [Header("Ultimate Settings")]
    public float ultimateCooldown = 10f;
    private bool isOnCooldown = false;

    #region Ultimates

    public void HealUltimate(float amount)
    {
        if (isOnCooldown) return;
        isOnCooldown = true;

        ApplyStatChange("Health", amount);
        StartCoroutine(UltimateCooldownRoutine());
    }

    public void TimeStopUltimate(float duration, float enemyTimeScale = 0.1f)
    {
        if (isOnCooldown) return;
        isOnCooldown = true;
        StartCoroutine(TimeStopRoutine(duration, enemyTimeScale));
        StartCoroutine(UltimateCooldownRoutine());
    }

    public void MovementSpeedUltimate(float multiplier, float duration)
    {
        if (speedModifier != null)
            speedModifier.ApplySpeedBoost(multiplier, duration);
        StartCoroutine(UltimateCooldownRoutine());
    }

    #endregion

    #region Helpers

    private void ApplyStatChange(string statName, float amount)
    {
        if (playerStats == null) return;

        foreach (var s in playerStats.stats)
        {
            if (s.name == statName)
            {
                s.Value += amount;
                break;
            }
        }
    }

    private IEnumerator TimeStopRoutine(float duration, float enemyTimeScale)
    {
        var enemies = FindObjectsOfType<MAnimal>();
        foreach (var e in enemies)
        {
            if (e != playerAnimal)
            {
                // Use reflection to slow enemy speed
                var speedField = e.GetType().GetField("SpeedMultiplier",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                if (speedField != null)
                    speedField.SetValue(e, enemyTimeScale);
            }
        }

        yield return new WaitForSecondsRealtime(duration);

        // Reset all enemies
        foreach (var e in enemies)
        {
            if (e != playerAnimal)
            {
                var speedField = e.GetType().GetField("SpeedMultiplier",
                    System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                if (speedField != null)
                    speedField.SetValue(e, 1f);
            }
        }
    }

    private IEnumerator UltimateCooldownRoutine()
    {
        yield return new WaitForSecondsRealtime(ultimateCooldown);
        isOnCooldown = false;
    }

    #endregion
}

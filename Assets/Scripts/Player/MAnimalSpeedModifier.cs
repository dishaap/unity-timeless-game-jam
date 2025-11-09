using UnityEngine;
using MalbersAnimations.Controller;

public class MAnimalSpeedModifier : MonoBehaviour
{
    private MAnimal animal;
    private float baseSpeed;
    private bool isBoosted = false;

    private void Awake()
    {
        animal = GetComponent<MAnimal>();
        if (animal == null) Debug.LogError("MAnimal component missing!");

        // Capture initial speed from internal MAnimal field (via SerializeField or inspector)
        baseSpeed = animal.GetType().GetField("Speed", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(animal) is float s ? s : 5f;
    }

    public void ApplySpeedBoost(float multiplier, float duration)
    {
        if (isBoosted) return; // prevent stacking
        StartCoroutine(SpeedBoostRoutine(multiplier, duration));
    }

    private System.Collections.IEnumerator SpeedBoostRoutine(float multiplier, float duration)
    {
        isBoosted = true;

        // Use reflection to modify protected SpeedMultiplier
        var speedField = animal.GetType().GetField("SpeedMultiplier", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        if (speedField != null)
        {
            speedField.SetValue(animal, multiplier);
        }

        yield return new WaitForSecondsRealtime(duration);

        // Reset
        if (speedField != null)
        {
            speedField.SetValue(animal, 1f);
        }

        isBoosted = false;
    }
}

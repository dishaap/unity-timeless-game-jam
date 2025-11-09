using UnityEngine;
using BLINK.RPGBuilder.Templates;
using MalbersAnimations;
using MalbersAnimations.Controller;

/// <summary>
/// Spawns loot/powerups when an enemy dies (1% chance).
/// </summary>
public class EnemyDeathLootDropper : MonoBehaviour
{
    [Range(0f, 1f)]
    public float boostSpawnChance = 0.01f;

    public GameObject[] boostPrefabs;

    private MalbersAnimations.Controller.MAnimal animal;

    private void Awake()
    {
        animal = GetComponent<MAnimal>();
        if (animal != null)
            animal.OnStateActivate.AddListener(OnStateActivated);
    }

    private void OnStateActivated(int stateId)
    {
        var activeState = animal.ActiveState;
        if (activeState != null && activeState.name.ToLower().Contains("death"))
        {
            TrySpawnBoost();
        }
    }

    private void TrySpawnBoost()
    {
        if (Random.value <= boostSpawnChance && boostPrefabs.Length > 0)
        {
            GameObject prefab = boostPrefabs[Random.Range(0, boostPrefabs.Length)];
            Instantiate(prefab, transform.position + Vector3.up * 0.5f, Quaternion.identity);
        }
    }
}

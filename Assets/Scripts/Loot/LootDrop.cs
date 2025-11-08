using UnityEngine;


/// <summary>
/// Defines random spawning behaviour of loot/powerups. Attach to loot/powerup prefabs
/// </summary>
public class LootDrop : MonoBehaviour
{

    // TODO: Make enum to specify which type, hook up to loot table

    [Header("Loot Data")]
    public int itemID;
    public int amount = 1;
    [Tooltip("Optional, for unique items")]
    public int itemDataID = -1;
    public AudioClip pickupSound;

    [Header("Visuals")]
    public float floatHeight = 0.2f;
    public float floatSpeed = 1.0f;

    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        // simple floating animation using unscaled time
        transform.position = startPos + Vector3.up * Mathf.Sin(Time.unscaledTime * floatSpeed) * floatHeight;
    }
}

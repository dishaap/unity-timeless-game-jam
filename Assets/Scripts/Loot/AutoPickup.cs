using UnityEngine;
using BLINK.RPGBuilder.Managers;
using BLINK.RPGBuilder.Logic;


/// <summary>
/// Detect whether player has picked up collectible loot.
/// </summary>


[RequireComponent(typeof(SphereCollider))]
public class AutoPickup : MonoBehaviour
{
    [Header("Auto Pickup Settings")]
    [Tooltip("Distance at which loot is detected.")]
    [SerializeField] private float pickupRadius = 2.5f;
    [Tooltip("Layer Mask for loot.")]
    [SerializeField] private LayerMask lootLayer;

    private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        SphereCollider col = GetComponent<SphereCollider>();
        col.isTrigger = true;
        col.radius = pickupRadius;

        if(!audioSource)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.spatialBlend = 1f;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        // If trigger is not on Loot layer, return
        if ((lootLayer.value & (1 << other.gameObject.layer)) == 0) return;

        // find RPGMaker Loot component
        LootDrop drop = other.GetComponent<LootDrop>();
        if (drop == null) return;

        // add loot to inventory
        InventoryManager.Instance.AddItem(drop.itemID, drop.amount, true, drop.itemDataID);
        // TODO: add check for loot existing in inventory

        if (drop.pickupSound) audioSource.PlayOneShot(drop.pickupSound);

        Destroy(other.gameObject);
        Debug.Log($"Picked up item {drop.itemID}");
    }
}
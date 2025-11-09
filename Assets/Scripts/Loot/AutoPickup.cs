using UnityEngine;
using MalbersAnimations;

[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(LootDrop))]
public class AutoPickup : MonoBehaviour
{
    private LootDrop lootDrop;
    public string playerTag = "Player";

    private void Awake()
    {
        lootDrop = GetComponent<LootDrop>();
        Collider col = GetComponent<Collider>();
        if (col != null) col.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag(playerTag)) return;

        // Play pickup sound
        if (lootDrop.pickupSound != null)
            AudioSource.PlayClipAtPoint(lootDrop.pickupSound, transform.position);

        // Apply effect
        var buffHandler = other.GetComponent<PlayerBuffHandler>();
        if (buffHandler != null)
            buffHandler.ApplyTemporaryBuff();

        Destroy(gameObject);
    }
}

using UnityEngine;
using BLINK.RPGBuilder.Managers;

public class PlayerAttackEffects : MonoBehaviour
{
    [Header("Attack Effects")]
    public GameObject attackVFX;
    public AudioClip attackSFX;
    public Transform spawnPoint; // assign weapon tip or hand transform
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.spatialBlend = 1f;
    }

    // Called from animation event or WeaponManager
    public void PlayAttackEffect()
    {
        if (attackVFX != null)
        {
            Instantiate(attackVFX, spawnPoint.position, spawnPoint.rotation);
        }

        if (attackSFX != null)
        {
            audioSource.PlayOneShot(attackSFX);
        }
    }
}

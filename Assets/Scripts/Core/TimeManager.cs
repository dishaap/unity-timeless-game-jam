using UnityEngine;

public class TimeManager : MonoBehaviour
{
    [Header("Speed Thresholds")]
    [Tooltip("Speed at which player is considered to stop.")]
    [SerializeField] private float stopThreshold = 0.1f; // when player stops
    [Tooltip("Speed at which player is considered to move, buffered slightly to prevent jittering.")]
    [SerializeField] private float moveThreshold = 0.2f; // slight buffer to prevent jittering

    private GameObject player;
    private Rigidbody playerRb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player");

        if (player != null)
            playerRb = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerRb == null) return;

        float velocity = playerRb.linearVelocity.magnitude;
        AdjustTimeScale(velocity);
    }

    void AdjustTimeScale(float velocity)
    {
        // player stops but time scale is large
        if (Time.timeScale > 0.5f && velocity < stopThreshold)
        {
            // Player stopped
            Time.timeScale = 0.1f;
        }

        // player moves but time scale is small
        else if (Time.timeScale < 0.5f && velocity > moveThreshold)
        {
            Time.timeScale = 1.0f;
        }
    }
}

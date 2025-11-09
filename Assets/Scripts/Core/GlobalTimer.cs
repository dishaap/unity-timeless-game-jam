using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class GlobalTimer : MonoBehaviour
{
    [Header("Timer Settings")]
    [Tooltip("Starting time in seconds")]
    [SerializeField] private float totalTime = 300f; // total time available, 5 min by default

    [Header("UI")]
    [Tooltip("Assign a TextMeshProUGUI to show the timer")]
    public TextMeshProUGUI timerText;

    [Header("Events")]
    public UnityEvent OnTimerEnd;

    // references to current states
    private float currentTime;
    private bool isRunning = true;
    private bool eventFired = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentTime = totalTime;
        UpdateTimerDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isRunning) return;

        // countdown using unscaled time
        currentTime -= Time.unscaledDeltaTime;
        if (currentTime <= 0f)
        {
            currentTime = 0f;
            isRunning = false;
            if (!eventFired)
            {
                eventFired = true;
                OnTimerEnd?.Invoke();
            }
        }

        UpdateTimerDisplay();
    }

    private void UpdateTimerDisplay()
    {
        if (timerText == null) return;

        int minutes = Mathf.FloorToInt(currentTime / 60f);
        int seconds = Mathf.FloorToInt(currentTime % 60f);
        timerText.text = $"{minutes:00}:{seconds:00}";
    }

    // attach to button for resetting timer, testing purposes
    public void ResetTimer()
    {
        currentTime = totalTime;
        isRunning = true;
        eventFired = false;
        UpdateTimerDisplay();
    }
}

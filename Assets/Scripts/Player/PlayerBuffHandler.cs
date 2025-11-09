using UnityEngine;
using System.Collections;
using MalbersAnimations;

public class PlayerBuffHandler : MonoBehaviour
{
    public float buffDuration = 5f;
    public float buffAmount = 10f; // increase value for some stat
    public string statName = "Haste"; // example stat

    private Stats playerStats;

    private void Awake()
    {
        playerStats = GetComponent<Stats>();
    }

    public void ApplyTemporaryBuff()
    {
        if (playerStats == null) return;

        Stat stat = null;
        foreach (var s in playerStats.stats)
        {
            if (s.Name == statName)
            {
                stat = s;
                break;
            }
        }

        if (stat != null)
        {
            stat.Value += buffAmount;
            StartCoroutine(RemoveBuffAfterDelay(stat, buffDuration));
        }
    }

    private IEnumerator RemoveBuffAfterDelay(Stat stat, float delay)
    {
        yield return new WaitForSecondsRealtime(delay); // unscaled time
        stat.Value -= buffAmount;
    }
}

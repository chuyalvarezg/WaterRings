using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickUpgrades : MonoBehaviour
{
    [SerializeField]
    private UpgradeStats stats;
    [SerializeField]
    private GameObject[] sticks;
    private int level;

    public void UpgradeSticks()
    {
        level = stats.GetCurrentLevel();
        if (level == 20)
        {
            sticks[0].SetActive(true);
        }else if(level == 40)
        {
            sticks[1].SetActive(true);
        }
        else if (level == 60)
        {
            sticks[2].SetActive(true);
        }
        else if (level == 80)
        {
            sticks[3].SetActive(true);

        }
        else if (level == 100)
        {
            sticks[4].SetActive(true);

        }
    }
}

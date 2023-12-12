using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingUpgrades : MonoBehaviour
{
    [SerializeField]
    private Transform ringSpawn;

    [SerializeField]
    private GameObject ring;
    [SerializeField]
    private UpgradeStats stats;
    private int level;

    public void UpgradeRings()
    {
        level = stats.GetCurrentLevel();
        if (level % 10 == 0)
        {
            Instantiate(ring, ringSpawn.position, Quaternion.Euler(new Vector3(0, 0, 0)));
        }
        stats.UpgradeRingValue(level + 10);
    }
}

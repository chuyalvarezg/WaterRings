using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushersUpgrade : MonoBehaviour
{
    [SerializeField]
    private PushUpwards[] pushers;
    private int level;

    public void UpgradePushers()
    {
        
        foreach(PushUpwards pusher in pushers)
        {
            pusher.Upgrade();
        }
    }
}

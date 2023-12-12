using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointStick : MonoBehaviour
{
    [SerializeField]
    private int StickMultiplier = 1;
    [SerializeField]
    private GameManager game;
 
    public void ScorePoint()
    {
        game.AddScore(StickMultiplier);
    }
}

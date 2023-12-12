using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpgradeStats : MonoBehaviour
{
    [SerializeField]
    private string buttonName;
    [SerializeField]
    private string progressionType;
    [SerializeField]
    private int baseValue;
    [SerializeField]
    private float levelMultiplier;
    [SerializeField]
    private float scale;

    [SerializeField]
    private GameManager game;

    private float currentPrice = 0;
    private int level;
    // Start is called before the first frame update
    void Start()
    {
        //level = PlayerPrefs.GetInt(progressionType, 0);
        level = 0;
        UpdatePrice();
        UpdateText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public double GetCurrentPrice()
    {
        return currentPrice;
    }

    public int GetCurrentLevel()
    {
        return level;
    }

    public void BuyUpgrade()
    {
        float temp = currentPrice;
        level++;
        PlayerPrefs.SetInt(progressionType, level);
        UpdatePrice();
        game.DeductFunds(temp);
        
        
        UpdateText();
    }

    public void UpgradeRingValue(int val)
    {
        game.UpdateRingValue(val);
    }

    private void UpdatePrice()
    {
        currentPrice = baseValue + (float)(Math.Round((decimal)Mathf.Pow(levelMultiplier,(level+1)/scale),2)*10);
    }

    private void UpdateText()
    {
        this.gameObject.transform.GetChild(0).GetComponent<TMP_Text>().text = buttonName + " Lv. " + level + "\n" + currentPrice;
    }
}

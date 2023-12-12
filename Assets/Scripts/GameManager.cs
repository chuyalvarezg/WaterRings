using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private float Score = 0;
    private int ringValue = 10;
    [SerializeField]
    private Text scoreText;
   

    [SerializeField]
    private Button[] buttons;

    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    private void Update()
    {
        scoreText.text = Score.ToString();
    }

    public void UpdateRingValue(int val)
    {

        ringValue = val;
        //Debug.Log("ringVal "+ringValue);
    }

    public void AddScore(int multiplier)
    {
        Score += multiplier*ringValue;
        //Debug.Log("addingScore "+multiplier * ringValue);
        ValidateButtons();
    }

    private void ValidateButtons()
    {
        foreach(Button button in buttons)
        {
            if (Score >= button.gameObject.GetComponent<UpgradeStats>().GetCurrentPrice())
            {
                button.interactable = true;
            }
            else
            {
                button.interactable = false;
            }
        }
    }

    public void DeductFunds(float price)
    {
        Score = Score - price;
        ValidateButtons();
    }
}

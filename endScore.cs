using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endScore : MonoBehaviour
{
    public Text txtScore;
    public Text scoreCounter;


    void Update()
    {
        txtScore.text = scoreCounter.text;

        if(txtScore.text == "")
        {
            txtScore.text = "0";
        }

        else if(int.Parse(scoreCounter.text) > PlayerPrefs.GetInt("total"))
        {
            PlayerPrefs.SetInt("total" , int.Parse(scoreCounter.text));
            
            
        }
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getHigh : MonoBehaviour
{
    public GameObject[] colors;
    void Start()
    {



        if(PlayerPrefs.GetInt("total") >= 2)
        {
            colors[1].SetActive(false);
        }
        if(PlayerPrefs.GetInt("total") >= 4)
        {
            colors[2].SetActive(false);
        }
        if(PlayerPrefs.GetInt("total") >= 6)
        {
            colors[3].SetActive(false);
        }
        if(PlayerPrefs.GetInt("total") >= 10)
        {
            colors[4].SetActive(false);
        }
        if(PlayerPrefs.GetInt("total") >= 15)
        {
            colors[5].SetActive(false);
        }
        if(PlayerPrefs.GetInt("total") >= 20)
        {
            colors[6].SetActive(false);
        }
        if(PlayerPrefs.GetInt("total") >= 25)
        {
            colors[7].SetActive(false);
        }
        if(PlayerPrefs.GetInt("total") >= 50)
        {
            colors[8].SetActive(false);
        }








    }

    
}

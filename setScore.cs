using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setScore : MonoBehaviour
{
    public Text scoretxt;
    private int score;
   public void scoreAdd()
   {
       score += 1;
   }

   void Update()
   {
       if(score > 0)
       {
       scoretxt.text = score + "";
       }
   }

   public void setmyScore(int scoreSet)
   {
       score = scoreSet;
       if(PlayerPrefs.GetInt("score") != 0)
       {
           PlayerPrefs.SetInt("revive" , 1);
       }
       else
       {
           PlayerPrefs.SetInt("revive" , 0);
       }
       PlayerPrefs.SetInt("score" , 0);
   }



}

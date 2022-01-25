using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class death : MonoBehaviour
{
    public Text score;
    public GameObject panel;
    public GameObject cover;
    public GameObject deathPart;
    public AudioSource deathSound;



    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "wall")
        {
            deathPart.transform.position = this.transform.position;
            this.gameObject.SetActive(false);
        
        deathPart.SetActive(true);
        Invoke("PanelActive" , .5f);
        deathSound.Play();
        PlayerPrefs.SetInt("score" , int.Parse(score.text));
        }
        

    }

    public void PanelActive()
    {
        cover.SetActive(true);
        panel.SetActive(true);
    }

}

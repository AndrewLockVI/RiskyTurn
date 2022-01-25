using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScore : MonoBehaviour
{
    public GameObject[] scores;
    private int zone;


    public void spawnRnd(int zone1)
    {
        zone = zone1;
        Invoke("spawning" , .1f);


    }
    public void spawning()
    {
        int random1 = Random.Range(0 , 4);
        random1 = random1 + (zone * 4);
        scores[random1].SetActive(true);
    }



    
}

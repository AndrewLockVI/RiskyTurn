using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScoring : MonoBehaviour
{
    public spawnScore spawnin;
    public setScore scoringSet;
    public GameObject scoreParticle;
    public AudioSource collectionSound;




    void Start()
    {
        spawnin.spawnRnd(3);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "score")
        {
            collectionSound.Play();
            Instantiate(scoreParticle , this.gameObject.transform.position , this.gameObject.transform.rotation);

            col.gameObject.SetActive(false);
            if(this.gameObject.transform.position.x > 0 & this.gameObject.transform.position.y > 0)
            {
                if(Random.Range(0 , 60) < 20)
                {
                spawnin.spawnRnd(3);
                }
                else if (Random.Range(0 , 60) > 20)
                {
                 spawnin.spawnRnd(0);
                }
                else
                {
                    spawnin.spawnRnd(2);
                }
            }
            if(this.gameObject.transform.position.x <= 0 & this.gameObject.transform.position.y > 0)
            {
                if(Random.Range(0 , 60) < 20)
                {
                spawnin.spawnRnd(2);
                }
                else if (Random.Range(0 , 60) > 20)
                {
                 spawnin.spawnRnd(3);
                }
                else
                {
                    spawnin.spawnRnd(1);

                }
            }
            if(this.gameObject.transform.position.x > 0 & this.gameObject.transform.position.y <= 0)
            {
                if(Random.Range(0 , 60) < 20)
                {
                spawnin.spawnRnd(0);
                }
                else if (Random.Range(0 , 60) > 20)
                {
                 spawnin.spawnRnd(1);
                }
                else
                {
                    spawnin.spawnRnd(3);

                }
            }
            if(this.gameObject.transform.position.x <= 0 & this.gameObject.transform.position.y <= 0)
                if(Random.Range(0 , 60) < 20)
                {
                spawnin.spawnRnd(1);
                }
                else if (Random.Range(0 , 60) > 20)
                {
                 spawnin.spawnRnd(2);
                }
                else
                {
                    spawnin.spawnRnd(0);
                }
                scoringSet.scoreAdd();
                
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateScore : MonoBehaviour
{
    public float roationMult;
    private float rotate;

    void Start()
    {
        rotate = 1f;
        rotate = rotate * roationMult * 2;  
    }

    void Update()
    {
        if(this.gameObject.activeInHierarchy == true)
        {
            this.gameObject.transform.Rotate(0 , 0 , rotate * Time.deltaTime);
        }
    }
}

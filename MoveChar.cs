using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveChar : MonoBehaviour
{
    public Rigidbody2D player;
    public GameObject cube;
    public float movementSpeed;


    private Vector3 upRight;
    private Vector3 downRight;
    private Vector3 downLeft;
    private Vector3 upLeft;
    public float direction;
    public AudioSource turnSound;
    public float time = 0;
    public bool right = true;


    private float turnTime;
    private bool justTurned = false;




    void Start()
    {
        upRight = new Vector3 (movementSpeed , movementSpeed , 0);
        upLeft = new Vector3 (movementSpeed , -movementSpeed , 0);
        downLeft = new Vector3 (-movementSpeed , -movementSpeed , 0);
        downRight = new Vector3 (-movementSpeed , movementSpeed , 0);



    }



    void Update()
    {
        if(justTurned == true)
        {
        turnTime += Time.deltaTime;
        }
        if(turnTime > .1f)
        {
            justTurned = false;
            turnTime = 0;
        }

        upRight = new Vector3 (movementSpeed , movementSpeed , 0);
        upLeft = new Vector3 (movementSpeed , -movementSpeed , 0);
        downLeft = new Vector3 (-movementSpeed , -movementSpeed , 0);
        downRight = new Vector3 (-movementSpeed , movementSpeed , 0);
        movementSpeed = movementSpeed + (time * .000002f);
        time += Time.deltaTime;
        

        if(Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
            if(TouchPhase.Began == touch.phase & justTurned == false)
            {
                justTurned = true;
                turnSound.Play();
                
            if(right == true)
            {
            player.transform.Rotate(0 , 0 , -90);
            }
            else
            {
                player.transform.Rotate(0 , 0 , 90);
            }


        if(cube.transform.localEulerAngles.z >= 130 & cube.transform.localEulerAngles.z <= 140)
        {
            player.velocity = downRight;
        }
        else if(cube.transform.localEulerAngles.z >= 220 & cube.transform.localEulerAngles.z <= 230)
        {
            player.velocity = downLeft;
        }
        else if(cube.transform.localEulerAngles.z >= 315 & cube.transform.localEulerAngles.z <= 315)
        {
            player.velocity = upLeft;
        }
        else
        {
            player.velocity = upRight;
        }
    }
}






        if(Input.GetKeyDown("space") == true & justTurned == false)
        {
            turnSound.Play();
            if(right == true)
            {
            player.transform.Rotate(0 , 0 , -90);
            }
            else
            {
                player.transform.Rotate(0 , 0 , 90);
            }

            justTurned = true;
        if(cube.transform.localEulerAngles.z >= 130 & cube.transform.localEulerAngles.z <= 140)
        {
            player.velocity = downRight;
        }
        else if(cube.transform.localEulerAngles.z >= 220 & cube.transform.localEulerAngles.z <= 230)
        {
            player.velocity = downLeft;
        }
        else if(cube.transform.localEulerAngles.z >= 315 & cube.transform.localEulerAngles.z <= 315)
        {
            player.velocity = upLeft;
        }
        else
        {
            player.velocity = upRight;
        }
        }
    }

       void OnCollisionEnter2D(Collision2D col)
    {
       if(col.gameObject.tag == "score")
       {
           if(Random.Range(0,50) < 20)
           {
               if(right == true)
               {
                    right = false;
               }
               else
               {
                   right = true;
               }

               turn();
               turn();
           }
       }
    }

    public void turn()
    {
            if(right == true)
            {
            player.transform.Rotate(0 , 0 , -90);
            }
            else
            {
                player.transform.Rotate(0 , 0 , 90);
            }

            justTurned = true;
        if(cube.transform.localEulerAngles.z >= 130 & cube.transform.localEulerAngles.z <= 140)
        {
            player.velocity = downRight;
        }
        else if(cube.transform.localEulerAngles.z >= 220 & cube.transform.localEulerAngles.z <= 230)
        {
            player.velocity = downLeft;
        }
        else if(cube.transform.localEulerAngles.z >= 315 & cube.transform.localEulerAngles.z <= 315)
        {
            player.velocity = upLeft;
        }
        else
        {
            player.velocity = upRight;
        }
        }








}

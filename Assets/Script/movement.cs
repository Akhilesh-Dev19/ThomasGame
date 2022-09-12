using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class movement : MonoBehaviour
{
    public PathCreator pathCreator;
   // public float moveSpeed;
    private float speed ;
    float distanceTravelled;
    public bool MoveOnTouch = true;
    public bool GameOn = false;
    public GameObject WinScreen;
    public GameObject LostScreen ;
    public AudioSource HornSound;
    public AudioSource MoveSound;
    public GameObject HomeScreen;


    // Start is called before the first frame update
    void Start()
    {
        WinScreen.SetActive(false);
        LostScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if (GameOn == true)
        {

            distanceTravelled += speed * Time.deltaTime;
            transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
            transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravelled);

        }
       
           
        

     if(MoveOnTouch== true)
        {
            HomeScreen.SetActive(true);
        }
        else
        {
            HomeScreen.SetActive(false);
        }
        if (speed > 0)
        {
            //MoveSound.Play();
        }

    }

    public void Move()
    {
        if (Input.GetMouseButton(0))
        {
            MoveOnTouch = false;
            speed = 5f;

        }


        else if (Input.GetMouseButtonUp(0))
        {
            speed = 0f;

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
       
        if(collision.gameObject.tag == "finish")
        {
            
            WinScreen.SetActive(true);
            this.gameObject.SetActive(false);
            

        }
        if (collision.gameObject.tag == "obstacle")
        {
            
            LostScreen.SetActive(true);
            this.gameObject.SetActive(false);
           

        }
        

        

    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Horn")
        {
            HornSound.Play();
        }
    }


}

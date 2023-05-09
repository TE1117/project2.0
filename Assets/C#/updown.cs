using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updown : MonoBehaviour
{
    AudioSource audio;
    public float speed=1;
    float timer = 0;
    bool up = true;
    void Start()

    {
        audio = GetComponent<AudioSource>();
        
    }
    private void FixedUpdate()
    {
        //Debug.Log(timer);
        if (timer == 0) up = true;
        if (timer == 25) up = false;
        if (up==true)
        {
            transform.position += new Vector3(0, speed, 0);
            timer+=1;
        }
        if (up==false) {
            this.gameObject.transform.position += new Vector3(0, -speed, 0);
            timer -= 1;
        }
        
    }
    private void OnCollisionStay(Collision collision)
    {
        collision.gameObject.tag="dis";
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        audio.Play();
        //Debug.Log("t");
    }
}

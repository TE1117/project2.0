using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updown : MonoBehaviour
{
    public float speed=1;
    float timer = 0;
    bool up = true;
    void Start()
    {
    }
    private void FixedUpdate()
    {
        
        Debug.Log(timer);
        if (timer == 0) up = true;
        if (timer == 10) up = false;
        if (up==true)
        {
            transform.position += new Vector3(0, speed, 0);
            timer+=1;
        }
        if (up==false) {
            this.gameObject.transform.position += new Vector3(0, -speed, 0);
            timer -= 1;
        }
        //if(timer==0) {
        //    
        //    timer -= 1;

        //}





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

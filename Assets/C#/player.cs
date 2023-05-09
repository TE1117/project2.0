using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    AudioSource bulletAud;
    void Start()
    {
        bulletAud=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullt") {
            Destroy(collision.gameObject);
            GameManager.bullet += 1;
            bulletAud.Play();

        }
    }
}

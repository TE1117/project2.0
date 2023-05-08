using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sped : MonoBehaviour
{
    Rigidbody m_rigidbody;
    AudioSource audio;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }

    //private void FixedUpdate()
    //{
    //    Vector3 pos = m_rigidbody.position;

        
    //    m_rigidbody.position += Vector3.left * speed * Time.fixedDeltaTime;
    //    m_rigidbody.MovePosition(pos);
    //}

    // Update is called once per frame
    void Update()
    {

    }
    //private void OnCollisionStay(Collision collision)
    //{
    //    //Debug.Log(collision.gameObject.name);
    //}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") {
            Vector3 pos = m_rigidbody.position;
            Debug.Log("P");

            m_rigidbody.AddForce(100,0,0);
            m_rigidbody.MovePosition(pos);
        }
    }
}


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

    private void FixedUpdate()
    {
        Vector3 pos = m_rigidbody.position;
        m_rigidbody.position += Vector3.left * speed * Time.fixedDeltaTime;
        m_rigidbody.MovePosition(pos);
    }

    void Update()
    {

    }
}


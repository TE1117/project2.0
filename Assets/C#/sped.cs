using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sped : MonoBehaviour
{
    Rigidbody m_rigidbody;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 pos = m_rigidbody.position;
        m_rigidbody.position += Vector3.left * speed * Time.fixedDeltaTime;
        m_rigidbody.MovePosition(pos);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
    }
}


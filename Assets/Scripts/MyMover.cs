using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMover : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.forward * speed;
    }

}

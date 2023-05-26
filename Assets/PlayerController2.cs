using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    private float speed;
    Rigidbody rb;
    
    void Start()
    {
        speed = 10.0f;

        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector3 position = new Vector3(x, y, 0);
        rb.velocity = position.normalized * speed;


    }
}

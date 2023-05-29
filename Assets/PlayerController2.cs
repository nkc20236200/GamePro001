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


        transform.position = new Vector2(
            Mathf.Clamp(transform.position.x + x, -11.0f, 11.0f),
            Mathf.Clamp(transform.position.y +y, -5.0f, 5.0f)
            );


    }
}
